Public Class Fm_Relatorio_Depositos_Mensal_R

    Private Sub Fm_Relatorio_Depositos_Mensal_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If vnivel = "0" Or vnivel > "4" Then
                If TipoRel = "Consolidado" Then
                    Me.DepositosTableAdapter.UCB_Geral(Me.DS_Tributos.Depositos, vlPeriodoComp)
                Else
                    Me.DepositosTableAdapter.UCB_Geral_Entidade(Me.DS_Tributos.Depositos, vlPeriodoComp, Entidades)
                End If
            Else
                If TipoRel = "Consolidado" Then
                    Me.DepositosTableAdapter.CampoGeralMensal(Me.DS_Tributos.Depositos, vlPeriodoComp, EntidadeLogada)
                Else
                    Me.DepositosTableAdapter.CampoGeralMensalEntidade(Me.DS_Tributos.Depositos, vlPeriodoComp, EntidadeLogada, Entidades)
                End If
            End If
            Me.Report_Depositos_Mensais.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Depositos_Mensais.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class