Imports System.Data.SqlClient
Public Class Fm_Troca_Senha

    Private Sub Btn_Alterar_Click(sender As Object, e As EventArgs) Handles Btn_Alterar.Click
        If Txt_NSenha.Text = txt_CSenha.Text Then
            TrocadeSenha()
        Else
            MsgBox("Senha Não Confere!", vbExclamation, "Senha")
            txt_CSenha.Text = ""
            Txt_NSenha.Text = ""
            Txt_NSenha.Focus()
        End If
    End Sub
    Private Sub TrocadeSenha()
        Try
            sql = "update Usuarios set TrocaSenha='" & "N" & "' ,"
            sql += "SenhaUsuario='" & Txt_NSenha.Text & "'"
            sql += "Where Id='" & Id & "' "
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
            LBInfor.Text = "Alteração Concluida com Sucesso"
            G_Senha.Visible = False

            MsgBox("Senha Alterada com Sucesso!!", vbInformation, "Troca Senha")
            Me.Hide()
        Catch ex As Exception
            MsgBox("A senha Não pode ser Salva")
        End Try
    End Sub

    Private Sub Fm_Troca_Senha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        LBInfor.Text = ""
    End Sub

    Private Sub Btn_Sair2_Click(sender As Object, e As EventArgs) Handles Btn_Sair2.Click
        Me.Hide()
    End Sub
End Class