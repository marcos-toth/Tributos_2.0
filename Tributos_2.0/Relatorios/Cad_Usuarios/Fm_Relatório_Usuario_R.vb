Public Class Fm_Relatório_Usuario_R

    Private Sub Fm_Relatório_Usuario_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Tipo = "1" Then
                Me.UsuariosTableAdapter.Relatório_Usuario(Me.DS_Tributos.Usuarios)
            Else
                Me.UsuariosTableAdapter.Relatorio_Usuario_Entidade(Me.DS_Tributos.Usuarios, Entidades)
            End If
            Me.Report_Usuarios.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class