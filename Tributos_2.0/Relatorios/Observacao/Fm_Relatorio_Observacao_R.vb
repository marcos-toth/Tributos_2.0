Public Class Fm_Relatorio_Observacao_R

    Private Sub Fm_Relatorio_Observacao_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "mes" Then
                If Tipo = "1" Then
                    Me.ObservacaoTableAdapter.Observacao_Geral(Me.DS_Tributos.Observacao, vlAno, vlMes)
                Else
                    Me.ObservacaoTableAdapter.Obsevacao_Entidade(Me.DS_Tributos.Observacao, vlAno, vlMes, Entidades)
                End If
            Else
                If Tipo = "1" Then
                    Me.ObservacaoTableAdapter.Observacao_Anual(Me.DS_Tributos.Observacao, vlAno)
                Else
                    Me.ObservacaoTableAdapter.Observacao_anual_entidade(Me.DS_Tributos.Observacao, vlAno, Entidades)
                End If
            End If
            Me.Report_Observacao.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.Report_Observacao.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Observacao.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Report_Observacao_Load(sender As Object, e As EventArgs) Handles Report_Observacao.Load

    End Sub
End Class