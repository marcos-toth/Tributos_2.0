Public Class Fm_Relatorio_UCB_IR_R

    Private Sub Fm_Relatorio_UCB_IR_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            If Recolhido = "N" Then
                If TipoRel = "Consolidado" Then
                    Me.IRTableAdapter.IR_Geral_UCB(Me.DS_Tributos.IR, Recolhido, vlMes)
                ElseIf TipoRel = "Analitico" Then
                    Me.IRTableAdapter.IR_Geral_UCB_Entidade(Me.DS_Tributos.IR, Entidades, Recolhido, vlMes)
                End If
            Else
                If TipoRel = "Consolidado" Then
                    Me.IRTableAdapter.IR_Geral_UCB_Mes(Me.DS_Tributos.IR, vlAno, vlMes, Recolhido)
                ElseIf TipoRel = "Analitico" Then
                    Me.IRTableAdapter.IR_Geral_UCB_Entidade_Mes(Me.DS_Tributos.IR, vlAno, vlMes, Entidades, Recolhido)
                End If
            End If
            Me.Report_Relatorio_IR_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", VPeriodo))
            Me.Report_Relatorio_IR_UCB.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Relatorio_IR_UCB.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class