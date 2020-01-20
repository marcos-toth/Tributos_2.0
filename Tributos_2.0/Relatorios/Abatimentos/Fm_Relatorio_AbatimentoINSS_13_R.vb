Public Class Fm_relatorio_AbatimentoINSS_13_R

    Private Sub Fm_relatorio_AbatimentoINSS_13_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DS_Tributos.Decimo_Terceiro'. Você pode movê-la ou removê-la conforme necessário.
        Try
            Me.WindowState = FormWindowState.Maximized
            If Tipo = "1" Then
                Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_UCB_Geral(Me.DS_Tributos.Decimo_Terceiro, VPeriodo)
            Else
                Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_UCB_Entidade(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, Entidades)
            End If
            Me.Report_Deducao_INSS_13.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Deducao_INSS_13.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class