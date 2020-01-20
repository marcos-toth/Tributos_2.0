Public Class Fm_IR_Recisao_Aluguel_R

    Private Sub Fm_IR_Recisao_Aluguel_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "1" Then
                Me.IR_Multa_RescisaoTableAdapter.Ano(Me.DS_Tributos.IR_Multa_Rescisao, EntidadeLogada, vlAno)
            ElseIf TipoRel = "2" Then
                Me.IR_Multa_RescisaoTableAdapter.Entidade_Ano(Me.DS_Tributos.IR_Multa_Rescisao, EntidadeLogada, vlAno, Entidades)
            ElseIf TipoRel = "3" Then
                Me.IR_Multa_RescisaoTableAdapter.Geral_Ano_Mes(Me.DS_Tributos.IR_Multa_Rescisao, EntidadeLogada, vlAno, vlMes)
            ElseIf TipoRel = "4" Then
                Me.IR_Multa_RescisaoTableAdapter.Geral_Ano_Mes_Entidade(Me.DS_Tributos.IR_Multa_Rescisao, EntidadeLogada, vlAno, vlMes, Entidades)
            End If

            Me.RP_Recisao_IR_Aluguel.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("PeriodoCompetencia", Cabecalho))
            Me.RP_Recisao_IR_Aluguel.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RP_Recisao_IR_Aluguel.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class