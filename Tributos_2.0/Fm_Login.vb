Imports System.Data.SqlClient
Imports System.Net
Imports System.Security
Imports System.IO
Imports System.Text
Public Class Fm_Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abertura()
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        txtUsuario.Text = My.Settings.Usuario
        txtUsuario.Select()
        versao = lb_Versao.Text
        btnEntrar.Enabled = True
        txtSenha.Select()
    End Sub
    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        InsereEnter(Me)
    End Sub
    Private Sub cmdSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        If MsgBox("Deseja Sair do Sistema?" & Usuario, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Application.Exit()
        Else
        End If
    End Sub
    Private Sub txtSenha_Validated(sender As Object, e As EventArgs) Handles txtSenha.Validated
        Try
            If txtUsuario.Text = "" Or txtSenha.Text = "" Then
                lb_Inf.Text = "Insira o Usuário ou a Senha"
                txtUsuario.Focus()
                Exit Sub
            End If
            sql = "select * from Usuarios where NomeUsuario="
            sql += "'" & txtUsuario.Text & "'and SenhaUsuario="
            sql += "'" & txtSenha.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            local = New DataSet
            conectar.Close()
            adaptar.Fill(local, "Usuarios")
            resultado = local.Tables("Usuarios").Rows.Count
            If resultado > 0 Then
                registro = local.Tables("Usuarios").Rows(0)
                vnivel = registro("Nivel")
                NomeUsuario = registro("NomeCompleto")
                EntidadeLogada = registro("EntidadeLogada")
                TrocaSenha = registro("TrocaSenha")

                'lb_Inf.Text = "Seja Bem Vindo " & registro("NomeCompleto")
                Id = registro("Id")
                btnEntrar.Enabled = True
                lb_TrocaaSenha.Visible = True
                btnEntrar.Focus()
                lb_Inf.Text = ""
            ElseIf resultado = 0 Then

                lb_TrocaaSenha.Visible = False
                txtSenha.Text = ""
                txtSenha.Select()
                lb_Inf.Text = "Usuário ou senha incorretos"
            End If
        Catch ex As Exception
            MsgBox("Servidor em Manutenção", vbExclamation, "Login")
            Application.Exit()
        End Try
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
            lb_Inf.Text = "Alteração Concluida com Sucesso"
            G_Senha.Visible = False
            Usuario = txtUsuario.Text
            Fm_Principal.Show()
            MsgBox("Senha Alterada com Sucesso!!", vbInformation, "Troca Senha")
            Me.Hide()
        Catch ex As Exception
            MsgBox("A senha Não pode ser Salva")
        End Try
    End Sub
    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtSenha.Focus()
        End If
    End Sub
    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtSenha_Validated(sender, e)
        End If
    End Sub
    Private Sub txt_CSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_CSenha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Btn_Alterar.Select()
        End If
    End Sub
    Private Sub txt_CSenha_Leave(sender As Object, e As EventArgs) Handles txt_CSenha.Leave
        If Txt_NSenha.Text = txt_CSenha.Text Then
            Btn_Alterar.Enabled = True
            Btn_Alterar.Select()
        End If
    End Sub
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
    Private Sub Txt_NSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_NSenha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txt_CSenha.Focus()
        End If
    End Sub
    Private Sub Btn_Sair2_Click(sender As Object, e As EventArgs) Handles Btn_Sair2.Click
        Application.Exit()
    End Sub
    Private Sub lb_TrocaaSenha_Click(sender As Object, e As EventArgs) Handles lb_TrocaaSenha.Click
        G_Login.Visible = False
        G_Login.Enabled = False
        G_Senha.Visible = True
        Txt_NSenha.Select()
        Txt_NSenha.Focus()
    End Sub
    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        txtSenha_Validated(sender, e)
        My.Settings.Usuario = txtUsuario.Text
        My.Settings.Save()
        If TrocaSenha = "S" Then
            G_Login.Visible = False
            G_Login.Enabled = False
            G_Senha.Visible = True
            Txt_NSenha.Select()
            Txt_NSenha.Focus()
        End If
        If resultado = 1 Then
            Usuario = txtUsuario.Text
            Fm_Principal.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Fm_Principal.Show()
        Me.Hide()
    End Sub
    Private Sub Abertura()
        'AQUI É SEU PROGRAMA PRINCIPAL ONDE ELE IRÁ ABRIR O UPDATE.EXE
        'PARA VERIFICAR SE EXISTE ATUALIZAÇÕES
        Dim ErroText As String
        If Not File.Exists(My.Computer.FileSystem.CurrentDirectory + "\ErroUPDATE.txt") Then
        Else
            ErroText = My.Computer.FileSystem.ReadAllText("ErroUPDATE.txt")
        End If
        If ErroText = "Deu Erro 2" Then
            File.Delete(My.Computer.FileSystem.CurrentDirectory + "\ErroUPDATE.txt")
            Exit Sub
        Else
            Me.lb_Versao.Text = "Versão: " + Application.ProductVersion
            Timer1.Start()
            If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\atualizador.exe") = False Then
                My.Computer.FileSystem.WriteAllBytes(My.Computer.FileSystem.CurrentDirectory & "\Atualizador.exe", My.Resources.Atualizador, False)
            Else
            End If
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ErroAcessoSite = 0 Then
            Try

                Dim web As New Net.WebClient
                Dim site As String = "http://programacao.ucb.org.br/Tributos/UCB/Versao.txt"
                Dim versao As String = web.DownloadString(site)
                'versao = "1.0.0.3" '
                Timer1.Stop()
                If versao <> Application.ProductVersion = True Then
                    MsgBox("Atualizao Disponivel, o Sistema vai ser Atualizado", vbExclamation, "Atualização")
                    Process.Start(My.Computer.FileSystem.CurrentDirectory + "\Atualizador.exe")
                    Me.Close()
                    Application.Exit()
                Else
                    Lb_mensagem.Text = "Nenhuma Atualizão Disponível"
                    File.Delete(My.Computer.FileSystem.CurrentDirectory + "\ErroUPDATE.txt")
                End If

            Catch ex As Exception
                Lb_mensagem.Text = "Site de Atualização Não Disponível"
                File.Delete(My.Computer.FileSystem.CurrentDirectory + "\ErroUPDATE.txt")
                ErroAcessoSite = 1
            End Try
        End If
    End Sub
End Class
