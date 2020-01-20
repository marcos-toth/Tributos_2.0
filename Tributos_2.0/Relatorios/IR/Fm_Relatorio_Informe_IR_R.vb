Public Class Fm_Relatorio_Informe_IR_R

    Private Sub Fm_Relatorio_Informe_IR_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            Me.IRTableAdapter.Informe_IR_CPF(Me.DS_Tributos.IR, vlAno, CPF_CNPJ)
            Me.Report_Informe_IR.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Informe_IR.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Entidade", EntidadeIR))
            Me.Report_Informe_IR.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("CNPJ", CNPJ))
            Me.Report_Informe_IR.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class