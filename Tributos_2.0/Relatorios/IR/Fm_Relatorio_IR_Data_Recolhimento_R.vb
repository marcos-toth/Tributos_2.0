Public Class Fm_Relatorio_IR_Data_Recolhimento_R

    Private Sub Fm_Relatorio_IR_Data_Recolhimento_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        If TipoRel = "Codigo" Then
            Me.IRTableAdapter.IR_Data_Recolhimento_CodEntidade(Me.DS_Tributos.IR, VlData, Cod_Entidade)
        Else

            Me.IRTableAdapter.IR_Data_Recolhimento_Entidade(Me.DS_Tributos.IR, VlData, EntidadeMae)
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class