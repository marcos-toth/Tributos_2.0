Public Class Fm_Cadastro_Cliente_IR_Aluguel_R

    Private Sub Fm_Cadastro_Cliente_IR_Aluguel_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Cliente_IRTableAdapter.Cliente_IR_Aluguel(Me.DS_Tributos.Cliente_IR)
        Me.RP_Cad_Cliente_IR.RefreshReport()
    End Sub
End Class