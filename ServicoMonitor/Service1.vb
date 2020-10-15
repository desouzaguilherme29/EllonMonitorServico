Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class ServicoMonitor
    Dim monitor As System.Threading.Timer

    Protected Overrides Sub OnStart(ByVal args() As String)
        Try
            'Debugger.Launch()
            'teste
            EscreveArquivoLog("Serviço iniciado em: " & DateTime.Now)

            Dim oCallback As New TimerCallback(AddressOf OnTimedEvent)
            monitor = New System.Threading.Timer(oCallback, Nothing, 0, 60000)

        Catch ex As Exception
            EscreveArquivoLog("Erro: " & Environment.NewLine & ex.Message & Environment.NewLine & DateTime.Now)
        End Try
    End Sub

    Protected Overrides Sub OnStop()
        Try
            EscreveArquivoLog("Serviço encerrado em: " & DateTime.Now)
        Catch ex As Exception
            EscreveArquivoLog("Erro: " & Environment.NewLine & ex.Message & Environment.NewLine & DateTime.Now)
        End Try
    End Sub

    Private Sub OnTimedEvent(ByVal state As Object)
        Dim fluxoTexto As IO.StreamReader
        Dim Cs, json, dados As String
        Const arquivoConf As String = "\conf.ellon"
        Dim dt As DataTable

        Try
            If Threading.Monitor.TryEnter(monitor) Then

                If Not System.IO.File.Exists(Application.StartupPath & arquivoConf) Then
                    Exit Sub
                End If

                fluxoTexto = New IO.StreamReader(Application.StartupPath & arquivoConf)
                Cs = Replace(fluxoTexto.ReadToEnd, vbCrLf, "")
                fluxoTexto.Close()

                dados = Criptografia(Cs)
                json = "[" & dados.Substring(0, dados.Length - 1) & "]"

                dt = JsonConvert.DeserializeObject(Of DataTable)(json)

                For Each linha In dt.Rows
                    reiniciarServico(Trim(linha("servico")), Trim(linha("url")))
                Next
                'http://localhost:8830/MOBILE/MBSERVER.V/?FUNCAO=GETSCRIPT&VERSAO=20191030&ROTINA=PRODUTO&FILTRO=false
            End If
        Catch ex As Exception
            EscreveArquivoLog("Erro: " & Environment.NewLine & ex.Message & Environment.NewLine & Date.Now)
        Finally
            Threading.Monitor.Exit(Me.monitor)
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

    Public Sub EscreveArquivoLog(ByVal Texto As String)
        Try
            If Not Directory.Exists((Application.StartupPath & "\temp\logs\")) Then
                Directory.CreateDirectory((Application.StartupPath & "\temp\logs\"))
            End If
            Dim writer As New StreamWriter((Application.StartupPath & "\temp\logs\Monitor-" & DateAndTime.Now.ToString("ddMMyyyy") & ".log"), True)
            writer.WriteLine((Texto & Environment.NewLine))
            writer.Close()
        Catch ex As Exception
            If Not Directory.Exists((Application.StartupPath & "\temp\logs\")) Then
                Directory.CreateDirectory((Application.StartupPath & "\temp\logs\"))
            End If
            Dim writer2 As New StreamWriter((Application.StartupPath & "\temp\logs\Monitor_Erros-" & DateAndTime.Now.ToString("ddMMyyyy") & ".log"), True)
            writer2.WriteLine("Erro: " & Environment.NewLine & ex.Message & Environment.NewLine & DateTime.Now)
            writer2.Close()
        End Try
    End Sub

    Public Sub reiniciarServico(nomeServico As String, urlTeste As String)
        Try
            If Not VerificaConexao_WebRequest(urlTeste) Then
                EscreveArquivoLog(DateTime.Now & "    Serviço: " & nomeServico & " Status: PARADO Reiniciado...")

                If StatusService(nomeServico) = "RODANDO" Then
                    PararServico(nomeServico)
                    Threading.Thread.Sleep(1000)
                End If

                IniciarServico(nomeServico)
            Else
                EscreveArquivoLog(DateTime.Now & "    Serviço: " & nomeServico & " Status: RODANDO")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub IniciarServico(ByVal nomeServico As String)
        Dim listaSvcs() As ServiceProcess.ServiceController
        Dim SingleSvc As ServiceProcess.ServiceController
        listaSvcs = ServiceProcess.ServiceController.GetServices
        Try
            For Each SingleSvc In listaSvcs
                If UCase(SingleSvc.ServiceName) = UCase(nomeServico) Then
                    SingleSvc.Start()
                    Exit For
                End If
            Next
        Catch e As Exception
            EscreveArquivoLog("Não é possivel Iniciar o serviço. Veririque se o mesmo esta habilitado ou se você tem permissões de Administrador!" & Environment.NewLine & "Erro: " & e.Message)
        End Try
    End Sub

    Public Sub PararServico(ByVal nomeServico As String)
        Dim listaSvcs() As ServiceProcess.ServiceController
        Dim SingleSvc As ServiceProcess.ServiceController
        listaSvcs = ServiceProcess.ServiceController.GetServices
        Try
            For Each SingleSvc In listaSvcs
                If UCase(SingleSvc.ServiceName) = UCase(nomeServico) Then
                    SingleSvc.Stop()
                    Exit For
                End If
            Next
        Catch e As Exception
            EscreveArquivoLog("Não é possivel parar o serviço. Veririque se o mesmo esta habilitado ou se você tem permissões de Administrador!" & Environment.NewLine & "Erro: " & e.Message)
        End Try
    End Sub

    Public Shared Function VerificaConexao_WebRequest(url As String) As Boolean
        Dim objUrl As New System.Uri(url)
        Dim objWebReq As System.Net.WebRequest
        objWebReq = System.Net.WebRequest.Create(objUrl)
        Dim objresp As System.Net.WebResponse
        Try
            objresp = objWebReq.GetResponse
            objresp.Close()
            objresp = Nothing
            Return True
        Catch ex As Exception
            objresp = Nothing
            objWebReq = Nothing
            Return False
        End Try
    End Function

    Public Function StatusService(nomeServico As String) As String
        Try
            Dim listaSvcs() As ServiceProcess.ServiceController
            Dim SingleSvc As ServiceProcess.ServiceController
            listaSvcs = ServiceProcess.ServiceController.GetServices

            For Each SingleSvc In listaSvcs
                If UCase(SingleSvc.ServiceName) = UCase(nomeServico) Then
                    If UCase(SingleSvc.Status.ToString) = "STOPPED" Then
                        Return "PARADO"
                    ElseIf UCase(SingleSvc.Status.ToString) = "RUNNING" Then
                        Return "RODANDO"
                    Else
                        Return "NÃO INSTALADO"
                    End If
                    Exit For
                End If
            Next
        Catch ex As Exception
            EscreveArquivoLog("Não é possivel Iniciar o serviço. Veririque se o mesmo esta habilitado ou se você tem permissões de Administrador!" & Environment.NewLine & "Erro: " & ex.Message)
        End Try
    End Function

End Class
