Public Class Fm_Relatorio_Tributos_Recolhimento_UCB_FGTS_R

    Private Sub Fm_Relatorio_Tributos_UCB_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized

            If Tipo = "1" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_Geral(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2)
            ElseIf Tipo = "2" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_EntidadeMae(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2, Entidades)
            ElseIf Tipo = "3" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_CodEntidade(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2, Entidades)
            End If
            Me.RP_Tributos_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.RP_Tributos_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RP_Tributos_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
            Me.RP_Tributos_UCB.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class