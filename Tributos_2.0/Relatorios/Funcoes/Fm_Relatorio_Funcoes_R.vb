Public Class Fm_Relatorio_Funcoes_R

    Private Sub Fm_Relatorio_Funcoes_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Try
            If Tipo = "1" Then
                Me.FuncaoTableAdapter.Geral(Me.DS_Tributos.Funcao)
            ElseIf Tipo = "2" Then
                Me.FuncaoTableAdapter.Entidade(Me.DS_Tributos.Funcao, Entidades)
            ElseIf Tipo = "3" Then
                Me.FuncaoTableAdapter.Funcao(Me.DS_Tributos.Funcao, Entidades)
            ElseIf Tipo = "4" Then
                Me.FuncaoTableAdapter.Campo(Me.DS_Tributos.Funcao, Entidades)
            End If

            Me.RV_Funcoes.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RV_Funcoes.RefreshReport()
        Catch ex As Exception

        End Try
    End Sub
End Class