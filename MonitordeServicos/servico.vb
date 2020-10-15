Public Class servico

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
            MessageBox.Show("Não é possivel Iniciar o serviço. Veririque se o mesmo esta habilitado ou se você tem permissões de Administrador!" & Environment.NewLine & "Erro: " & e.Message, ":: TJ Backup")
        End Try
    End Sub

    Public Sub PararServico(ByVal nomeServico As String)
        Dim listaSvcs() As ServiceProcess.ServiceController '
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
            MessageBox.Show("Não é possivel parar o serviço. Veririque se o mesmo esta habilitado ou se você tem permissões de Administrador!" & Environment.NewLine & "Erro: " & e.Message, ":: TJ Backup")
        End Try
    End Sub

End Class
