Public Class Fm_Relatorio_Tributos_Recolhimento_UCB_INSS_R

    Private Sub Fm_Relatorio_Tributos_Recolhimento_UCB_Demais_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If Tipo = "1" Then
                Me.TributosTableAdapter.Tributos_UCB_Periodo(Me.DS_Tributos.Tributos, VPeriodo)
            ElseIf Tipo = "2" Then
                Me.TributosTableAdapter.Tributo_UCB_Periodo_Entidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
            ElseIf Tipo = "3" Then
                Me.TributosTableAdapter.Tributos_UCB_Periodo_CodEntidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
            End If

            Me.RV_Demais_Tributos.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.RV_Demais_Tributos.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RV_Demais_Tributos.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
            Me.RV_Demais_Tributos.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub
End Class