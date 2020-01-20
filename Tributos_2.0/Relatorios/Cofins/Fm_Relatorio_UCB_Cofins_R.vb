Public Class Fm_Relatorio_UCB_Cofins_R

    Private Sub Fm_Relatorio_UCB_Cofins_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "Consolidado" Then
                Me.COFINSTableAdapter.COFINS(Me.DS_Tributos.COFINS, vlAno, vlMes, Contabilizado)
            Else
                Me.COFINSTableAdapter.COFINS_Entidade(Me.DS_Tributos.COFINS, vlAno, vlMes, Entidades, Contabilizado)
            End If
            Me.Report_COFINS_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_COFINS_UCB.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class