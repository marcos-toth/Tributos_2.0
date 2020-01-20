Public Class Fm_Relatorio_Centralizacao_R

    Private Sub Fm_Relatorio_Centralizacao_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If Tipo = "1" Then
                Me.TributosTableAdapter.Centralizacao_CodEntidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
            ElseIf Tipo = "3" Then
                Me.TributosTableAdapter.Centralizacao_Campo(Me.DS_Tributos.Tributos, VPeriodo, Entidades, Categoria)
            Else
                Me.TributosTableAdapter.Tributos_RH_EntidadeMae(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
            End If
            Me.RP_Centralizacao.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", Entidades))
            Me.RP_Centralizacao.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.RP_Centralizacao.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RP_Centralizacao.RefreshReport()
        Catch ex As Exception
        End Try
    End Sub
End Class