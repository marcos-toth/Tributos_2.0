Public Class Fm_Relatorio_Tributos_Anual_R

    Private Sub Fm_Relatorio_Tributos_Anual_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If Tipo = "2" Then
            Me.TributosTableAdapter.Relatorio_Anual_Entidade(Me.DS_Tributos.Tributos, 201801, Entidades)
        Else
            Me.TributosTableAdapter.Relatorio_Anual(Me.DS_Tributos.Tributos, 201801)
        End If

        Me.Relatorio_Tributos_Anual.RefreshReport()
    End Sub
End Class