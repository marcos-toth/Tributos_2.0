Public Class Fm_Relatorio_Tributos_Geral_R

    Private Sub Fm_Relatorio_Tributos_Geral_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If vnivel = "0" Or vnivel = "5" Then
                If Tipo = "1" Then
                    Me.TributosTableAdapter.Tributos_UCB_Periodo(Me.DS_Tributos.Tributos, VPeriodo)
                ElseIf Tipo = "2" Then
                    Me.TributosTableAdapter.Tributo_UCB_Periodo_Entidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
                ElseIf Tipo = "3" Then
                    Me.TributosTableAdapter.Tributos_UCB_Periodo_CodEntidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
                End If
            Else
                If Tipo = "1" Then
                    Me.TributosTableAdapter.Tributos_Campo_Periodo(Me.DS_Tributos.Tributos, VPeriodo, EntidadeLogada)
                ElseIf Tipo = "2" Then
                    Me.TributosTableAdapter.Tributos_Campo_Periodo_Entidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades, EntidadeLogada)
                ElseIf Tipo = "3" Then
                    Me.TributosTableAdapter.Ttibutos_Campo_Periodo_CodEntidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades, EntidadeLogada)
                End If
            End If
            Me.Report_Tributos_Geral.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.Report_Tributos_Geral.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Tributos_Geral.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class