Public Class Fm_Relatorio_Informe_DIRF_R

    Private Sub Fm_Relatorio_Informe_DIRF_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            If vnivel = "0" Or vnivel = "5" Then
                If MsgBox("Você Deseja o Relatório Geral?", MsgBoxStyle.YesNo + vbExclamation, "Tipo de Relatório") = MsgBoxResult.Yes Then
                    Me.IRTableAdapter.DIRF_UCB(Me.DS_Tributos.IR, vlAno)

                Else
                    Me.IRTableAdapter.IR_Geral_Campo_Entidade(Me.DS_Tributos.IR, vlAno, EntidadeLogada, Entidades)
                End If

            Else
                Me.IRTableAdapter.IR_Geral_Campo_Entidade(Me.DS_Tributos.IR, vlAno, EntidadeLogada, Entidades)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Me.RV_DIRF.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", EntidadeIR))
            Me.RV_DIRF.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CNPJ", CNPJ))
            Me.RV_DIRF.RefreshReport()
            Fm_Inform.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class