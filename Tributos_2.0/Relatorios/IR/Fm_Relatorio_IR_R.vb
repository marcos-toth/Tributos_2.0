Public Class Fm_Relatorio_IR_R

    Private Sub Fm_Relatorio_Informe_IR_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "1" Then
                Me.IRTableAdapter.IR_Geral_Campo(Me.DS_Tributos.IR, vlAno, EntidadeLogada)
            ElseIf TipoRel = "2" Then
                Me.IRTableAdapter.IR_Geral_Campo_Entidade(Me.DS_Tributos.IR, vlAno, EntidadeLogada, Entidades)
            ElseIf TipoRel = "3" Then
                Me.IRTableAdapter.IR_Geral_Campo_Mes(Me.DS_Tributos.IR, vlAno, vlMes, EntidadeLogada)
            ElseIf TipoRel = "4" Then
                Me.IRTableAdapter.IR_Geral_Campo_Entidade_Mes(Me.DS_Tributos.IR, vlAno, vlMes, EntidadeLogada, Entidades)
            End If
            Me.Report_Informe_IR.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", vlAno))
            Me.Report_Informe_IR.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Informe_IR.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class