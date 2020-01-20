Public Class Fm_Relatorio_Tributos_Recolhimento_UCB_DARF_R
    Private Sub Fm_Relatorio_Tributos_Recolhimento_UCB_Federais_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If Tipo = "1" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_Geral(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2)
            ElseIf Tipo = "2" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_EntidadeMae(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2, Entidades)
            ElseIf Tipo = "3" Then
                Me.Tributos_RHTableAdapter.Tributos_RH_CodEntidade(Me.DS_Tributos.Tributos_RH, VPeriodo, VPeriodo2, Entidades)
            End If
        Catch ex As Exception
        End Try
        Try
            If Entidades = "IPAEAS" Then
                RV_RH_Educ.Visible = True
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetenciaAnterior", VPeriodo2))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
                Me.RV_RH_Educ.RefreshReport()
            ElseIf Entidades = "UNASP" Then
                RV_RH_UNASP.Visible = True
                Me.RV_RH_UNASP.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
                Me.RV_RH_UNASP.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetenciaAnterior", VPeriodo2))
                Me.RV_RH_UNASP.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
                Me.RV_RH_UNASP.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
                Me.RV_RH_UNASP.RefreshReport()
            ElseIf Entidades = "ADRA" Then
                RV_RH_Educ.Visible = True
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetenciaAnterior", VPeriodo2))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
                Me.RV_RH_Educ.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
                Me.RV_RH_Educ.RefreshReport()
            ElseIf Entidades = "IPAPS" Then
                RV_RH_IPAPS.Visible = True
                Me.RV_RH_IPAPS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
                Me.RV_RH_IPAPS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetenciaAnterior", VPeriodo2))
                Me.RV_RH_IPAPS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
                Me.RV_RH_IPAPS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
                Me.RV_RH_IPAPS.RefreshReport()
            Else
                RV_RH_UCB.Visible = True
                Me.RV_RH_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
                Me.RV_RH_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetenciaAnterior", VPeriodo2))
                Me.RV_RH_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
                Me.RV_RH_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
                Me.RV_RH_UCB.RefreshReport()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles RV_RH_IPAPS.Load

    End Sub
End Class