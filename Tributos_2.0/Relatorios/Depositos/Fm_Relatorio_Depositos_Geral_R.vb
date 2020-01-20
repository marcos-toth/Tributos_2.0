Public Class Fm_Relatorio_Depositos_Geral_R

    Private Sub Relatorio_Depositos_Geral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Me.DepositosTableAdapter.CampoGeralAnual(Me.DS_Tributos.Depositos, vlAno, EntidadeLogada)
                ElseIf TipoRel = "Analitico" Then

                    Me.DepositosTableAdapter.CampoGeralAnualEntidade(Me.DS_Tributos.Depositos, vlAno, EntidadeLogada, Entidades)
                ElseIf Tipo = "4" Then
                    Me.DepositosTableAdapter.CampoGeralMensal(Me.DS_Tributos.Depositos, vlPeriodoComp, EntidadeLogada)
                ElseIf Tipo = "5" Then
                    Me.DepositosTableAdapter.CampoGeralAnual(Me.DS_Tributos.Depositos, vlPeriodoComp, EntidadeLogada)
                End If
            End If
            Me.Report_Deposito_Geral.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Deposito_Geral.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Report_Deposito_Geral_Load(sender As Object, e As EventArgs) Handles Report_Deposito_Geral.Load

    End Sub
End Class