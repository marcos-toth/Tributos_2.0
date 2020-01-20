Public Class Fm_Video_Treinamentos

    Private Sub Fm_Video_Treinamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles P_Geral.Click
        System.Diagnostics.Process.Start("https://youtu.be/ag5GBnYcyNc")
    End Sub


    Private Sub P_PriAcesso_Click(sender As Object, e As EventArgs) Handles P_PriAcesso.Click
        System.Diagnostics.Process.Start("https://youtu.be/6AXWJUdhukc")
    End Sub

    Private Sub P_Cadastro_Click(sender As Object, e As EventArgs) Handles P_Cadastro.Click
        System.Diagnostics.Process.Start("https://youtu.be/5zw5nJF0Alc")
    End Sub

    Private Sub P_Relatorio_Click(sender As Object, e As EventArgs) Handles P_Relatorio.Click
        System.Diagnostics.Process.Start("https://youtu.be/WdKCIe3Hryw")
    End Sub
End Class