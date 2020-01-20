Public Class Fm_Relatorio_Campo_COFINS_R

    Private Sub Fm_Relatorio_Campo_COFINS_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "Consolidado" Then
                Me.COFINSTableAdapter.CampoGeral(Me.DS_Tributos.COFINS, vlAno, vlMes, EntidadeLogada)
            Else
                Me.COFINSTableAdapter.CampoDetalhada(Me.DS_Tributos.COFINS, vlAno, vlMes, EntidadeLogada, Entidades)
            End If
            Me.Report_Cofins.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Cofins.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class