Imports System.IO
Imports Newtonsoft.Json

Public Class Monitor_Ellon
    Dim tp_visivel As Boolean = False
    Private Sub btnInstalar_Click(sender As Object, e As EventArgs) Handles btnInstalar.Click
        Dim cmd As String = ""
        Dim tarefa As New servico
        Try
            cmd = "cmd /c SC.exe create " & txtNomeServico.Text & " binpath= """ & (Directory.GetCurrentDirectory() & "/ServicoMonitor.exe").ToString & """ type= own start= delayed-auto"
            Shell(cmd, AppWinStyle.MaximizedFocus, True)
            Threading.Thread.Sleep(1000)
            Application.DoEvents()
            If Not lblStatus.Text = "RODANDO" Then
                tarefa.IniciarServico(txtNomeServico.Text)
            End If
            Application.DoEvents()
            Threading.Thread.Sleep(1000)
            Call LeSvcs()
        Catch ex As Exception
            MsgBox("Erro de Instalação" & Environment.NewLine & ex.Message, vbExclamation, ":: ellon Tecnologia e Gestão - Alerta")
        End Try
    End Sub

    Private Sub btnDesistalar_Click(sender As Object, e As EventArgs) Handles btnDesistalar.Click
        Try
            Dim tarefa As New servico
            If Not lblStatus.Text = "PARADO" Then
                tarefa.PararServico(txtNomeServico.Text)
            End If
            Threading.Thread.Sleep(1000)
            Shell("cmd /c sc delete " & txtNomeServico.Text, AppWinStyle.MinimizedFocus, True)
            Threading.Thread.Sleep(1000)
            Call LeSvcs()
        Catch ex As Exception
            MsgBox("Erro " & Environment.NewLine & ex.Message, vbExclamation, ":: ellon Tecnologia e Gestão - Alerta")
        End Try
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim tarefa As New servico
        If Not lblStatus.Text = "RODANDO" Then
            tarefa.IniciarServico(txtNomeServico.Text)
        End If
        Threading.Thread.Sleep(1000)
        Call LeSvcs()
    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs) Handles btnParar.Click
        Dim tarefa As New servico
        If Not lblStatus.Text = "PARADO" Then
            tarefa.PararServico(txtNomeServico.Text)
        End If
        Threading.Thread.Sleep(1000)
        Call LeSvcs()
    End Sub

    Private Sub btnReinicarSair_Click(sender As Object, e As EventArgs) Handles btnReinicarSair.Click
        Try
            Dim tarefa As New servico
            If Not lblStatus.Text = "PARADO" Then
                tarefa.PararServico(txtNomeServico.Text)
            End If
            Threading.Thread.Sleep(1000)
            If Not lblStatus.Text = "RODANDO" Then
                tarefa.IniciarServico(txtNomeServico.Text)
            End If
            Threading.Thread.Sleep(1000)
            Application.Exit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub LeSvcs()
        Dim listaSvcs() As ServiceProcess.ServiceController
        Dim SingleSvc As ServiceProcess.ServiceController
        listaSvcs = ServiceProcess.ServiceController.GetServices
        Try
            lblStatus.Text = "NÃO INSTALADO"

            For Each SingleSvc In listaSvcs
                If UCase(SingleSvc.ServiceName) = UCase(txtNomeServico.Text) Then
                    If UCase(SingleSvc.Status.ToString) = "STOPPED" Then
                        lblStatus.Text = "PARADO"
                    ElseIf UCase(SingleSvc.Status.ToString) = "RUNNING" Then
                        lblStatus.Text = "RODANDO"
                    Else
                        lblStatus.Text = "NÃO INSTALADO"
                    End If
                    Exit For
                End If
            Next

            If UCase(lblStatus.Text) = "PARADO" Then
                lblStatus.ForeColor = Color.Red
                btnInstalar.Enabled = False
                btnIniciar.Enabled = True
                btnParar.Enabled = False
                btnReinicarSair.Enabled = True
            ElseIf UCase(lblStatus.Text) = "RODANDO" Then
                lblStatus.ForeColor = Color.Green
                btnInstalar.Enabled = False
                btnIniciar.Enabled = False
                btnParar.Enabled = True
                btnReinicarSair.Enabled = True
                btnDesistalar.Enabled = True
            ElseIf UCase(lblStatus.Text) = "NÃO INSTALADO" Then
                btnInstalar.Enabled = True
                btnIniciar.Enabled = False
                btnParar.Enabled = False
                btnReinicarSair.Enabled = False
                btnDesistalar.Enabled = False
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbreConfig()
        LeSvcs()
    End Sub

    Private Sub btIncluir_Click(sender As Object, e As EventArgs) Handles btIncluir.Click
        Try
            mostrarOcultarPainel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub mostrarOcultarPainel()
        Try
            If tp_visivel Then
                tp_visivel = False
                txtnmservice.Text = ""
                txturlservice.Text = ""
            Else
                tp_visivel = True
            End If

            gbDadosServi.Visible = tp_visivel
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function AbreConfig() As String
        Dim fluxoTexto As IO.StreamReader
        Dim Cs, json, dados As String
        Const arquivoConf As String = "\conf.ellon"
        Dim dt As DataTable

        Try
            If Not System.IO.File.Exists(Application.StartupPath & arquivoConf) Then
                Exit Function
            End If

            fluxoTexto = New IO.StreamReader(Application.StartupPath & arquivoConf)
            Cs = Replace(fluxoTexto.ReadToEnd, vbCrLf, "")
            fluxoTexto.Close()

            dados = Criptografia(Cs)
            json = "[" & dados.Substring(0, dados.Length - 1) & "]"

            dt = JsonConvert.DeserializeObject(Of DataTable)(json)

            dgServicos.Rows.Clear()

            For Each linha In dt.Rows
                dgServicos.Rows.Add(Trim(linha("servico")), Trim(linha("url")))
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Sub AddServicoConfig(ByVal Texto As String, tp_limpar_arq As Boolean)
        Try
            If tp_limpar_arq Then
                If System.IO.File.Exists(Application.StartupPath & "\conf.ellon") Then
                    System.IO.File.Delete(Application.StartupPath & "\conf.ellon")
                End If
            End If
            Dim writer As New StreamWriter((Application.StartupPath & "\conf.ellon"), True)
            writer.WriteLine(Texto)
            writer.Close()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Criptografia(Text As String) As String

        Dim strTempChar As String = ""

        For i = 1 To Len(Text)

            If Asc(Mid$(Text, i, 1)) < 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) + 128
            ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
                strTempChar = Asc(Mid$(Text, i, 1)) - 128
            End If

            Mid$(Text, i, 1) = Chr(strTempChar)

        Next i

        Criptografia = Text
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtnmservice.Text.Length > 0 And txturlservice.Text.Length > 0 Then
                AddServicoConfig(Criptografia("{""servico"":""" & txtnmservice.Text & """,""url"":""" & txturlservice.Text & """},"), False)

                AbreConfig()

            End If

            mostrarOcultarPainel()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim drc As DataGridViewSelectedRowCollection
        Try
            If dgServicos.SelectedRows.Count > 0 Then
                drc = dgServicos.SelectedRows
                dgServicos.Rows.Remove(drc(0))

                GravarLista()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Sub GravarLista()
        AddServicoConfig(Criptografia(getCamposSelecionados), True)
    End Sub

    Private Function getCamposSelecionados() As String
        Dim IntRegist As Integer
        Dim StrCampos As String
        Try
            StrCampos = ""
            IntRegist = dgServicos.Rows.Count - 1

            For i As Integer = 0 To IntRegist
                StrCampos = StrCampos & "{""servico"":""" & dgServicos.Rows(i).Cells(0).Value & """,""url"":""" & dgServicos.Rows(i).Cells(1).Value & """},"
                If i < IntRegist Then
                    StrCampos = StrCampos
                End If
            Next

            Return StrCampos
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
