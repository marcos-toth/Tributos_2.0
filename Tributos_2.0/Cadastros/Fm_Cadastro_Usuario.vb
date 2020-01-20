Imports System.Data.SqlClient

Public Class Fm_Cadastro_Usuario

    Private Sub Fm_CasastroUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        txtCPF.Focus()
        'Parentes()
        Me.MdiParent = Fm_Principal
        Preencher_Combo_Entidades()
        Cbo_EntidadeLogada.Text = EntidadeLogada
        If vnivel = "0" Then
            Cbo_EntidadeLogada.Enabled = True
        End If
        btnDeletar.Enabled = False
    End Sub
    Private Sub Fm_CadUsuario_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        InsereEnter(Me)
    End Sub
    Private Sub Preencher_Combo_Entidades()
        Try
            conectar.Open()
            sql = "Select  DISTINCT Filiais from Entidade"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cbo_EntidadeLogada.ValueMember = "id"
            Cbo_EntidadeLogada.DisplayMember = "Filiais"
            Cbo_EntidadeLogada.DataSource = local.Tables(0)
            ' CB_Codigo.SelectedIndex = -1
            'CB_Codigo.Text = "101111"
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Limpar()
        txtNome.Text = ""
        txtSenha.Text = "iasd"
        txtCPF.Text = ""
        txtSenha2.Text = "iasd"
        txtNivel.Text = ""
        txtNomeCompleto.Text = ""
        Cbo_EntidadeLogada.Text = EntidadeLogada
        Cbo_TrocaSenha.Text = "S"
        txtCPF.Focus()
        btnDeletar.Enabled = False
    End Sub
    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        conectar.Close()
        sql = "delete from Usuarios where Id='" & Id & "'"
        If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
            If resultado > 0 Then
                conectar.Open()
                comando = New SqlCommand(sql)
                comando.Connection = conectar
                comando.ExecuteNonQuery()
                conectar.Close()
                lbInf.Text = "Cadastro Deletado com Sucesso!!!"
            Else
                lbInf.Text = "Não existem registros para ser Eliminados"
                txtCPF.Focus()
                Exit Sub
            End If
        End If
        Limpar()
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If txtCPF.Text = "" Then
            MsgBox("Favor Inserir Um CPF")
            txtCPF.Focus()
            Exit Sub
        End If
        If txtNome.Text = "" Then
            MsgBox("Favor Inserir Um Nome")
            txtNome.Focus()
            Exit Sub
        End If
        If txtSenha.Text = txtSenha2.Text Then

            If resultado > 0 Then
                sql = "update Usuarios set NomeUsuario='" & txtNome.Text & "' ,"
                sql += "SenhaUsuario='" & txtSenha.Text & "',"
                sql += "Nivel='" & txtNivel.Text & "',"
                sql += "NomeCompleto='" & txtNomeCompleto.Text & "', "
                sql += "CPF='" & txtCPF.Text & "', "
                sql += "EntidadeLogada='" & Cbo_EntidadeLogada.Text & "', "
                sql += "TrocaSenha='" & Cbo_TrocaSenha.Text & "' "
                sql += "Where Id='" & Id & "' "
            ElseIf resultado = 0 Then
                sql = " insert into Usuarios (NomeUsuario,SenhaUsuario,EntidadeLogada,Nivel, NomeCompleto,TrocaSenha,CPF)"
                sql += "values ('" & txtNome.Text & "',"
                sql += "'" & txtSenha.Text & "',"
                sql += "'" & Cbo_EntidadeLogada.Text & "',"
                sql += "'" & txtNivel.Text & "',"
                sql += "'" & txtNomeCompleto.Text & "',"
                sql += "'" & Cbo_TrocaSenha.Text & "',"
                sql += "'" & txtCPF.Text & "')"
            End If

            Try
                conectar.Open()
                comando = New SqlCommand(sql)
                comando.Connection = conectar
                comando.ExecuteNonQuery()
                If btnSalvar.Text = "Inserir" Then
                    lbInf.Text = "Cadastro Salvo com Sucesso!!!"
                Else
                    lbInf.Text = "Cadastro Editado com Sucesso!!!"
                End If

            Catch ex As Exception
                MsgBox("Erro")
                conectar.Close()
                Exit Sub
            End Try
            conectar.Close()
            Limpar()
        Else
            MsgBox("Senha Não Confere", vbExclamation, "Senha")
            txtSenha.Focus()
            txtSenha.Text = ""
            txtSenha2.Text = ""
        End If
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
        lbInf.Text = ""
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Limpar()
        Me.Hide()
    End Sub

    Private Sub txtCPF_Leave(sender As Object, e As EventArgs) Handles txtCPF.Leave
        Try
            lbInf.Text = ""
            sql = "select * from Usuarios where CPF="
            sql += "'" & txtCPF.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Usuarios")
            resultado = local.Tables("Usuarios").Rows.Count

            If resultado > 0 Then
                registro = local.Tables("Usuarios").Rows(0)
                txtNome.Text = registro("NomeUsuario")
                txtSenha.Text = registro("SenhaUsuario")
                txtSenha2.Text = registro("SenhaUsuario")
                txtNomeCompleto.Text = registro("NomeCompleto")
                txtNivel.Text = registro("Nivel")
                Id = registro("Id")
                Cbo_EntidadeLogada.Text = registro("EntidadeLogada")
                btnSalvar.Text = "Editar"
                CarregaNivel()
                btnDeletar.Enabled = True
            ElseIf resultado = 0 Then
                btnSalvar.Text = "Inserir"
                txtNomeCompleto.Focus()
            End If
        Catch ex As Exception
            MsgBox("erro de validação")
        End Try
    End Sub
    Private Sub txtNomeCompleto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeCompleto.TextChanged, txtNomeCompleto.TextChanged
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.txtNomeCompleto.SelectionStart
        selLength = Me.txtNomeCompleto.SelectionLength
        Me.txtNomeCompleto.Text = StrConv(Me.txtNomeCompleto.Text, VbStrConv.ProperCase)
        Me.txtNomeCompleto.SelectionStart = selStart
        Me.txtNomeCompleto.SelectionLength = selLength
    End Sub
    Private Sub txtCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCPF.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtNomeCompleto.Focus()
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtNomeCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeCompleto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtNome.Focus()
        End If
    End Sub
    Private Sub txtNome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtSenha.Focus()
        End If
    End Sub
    Private Sub txtSenha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtSenha2.Focus()
        End If
    End Sub
    Private Sub txtSenha2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSenha2.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtNivel.Focus()
        End If
    End Sub

    Private Sub txtNivel_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Focus()
        End If
    End Sub
    Private Sub txtSenha2_Validated(sender As Object, e As EventArgs) Handles txtSenha2.Validated
        If txtSenha.Text <> txtSenha2.Text Then
            MsgBox("Senha Não Confere", vbExclamation, "Senha")
            txtSenha.Focus()
            txtSenha.Text = ""
            txtSenha2.Text = ""
        End If
    End Sub
    Private Sub btn_Sair_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CarregaNivel()
        If txtNivel.Text = "1" Then
            Cb_NomeNivel.Text = "1 - Acesso Total"
        ElseIf txtNivel.Text = "2" Then
            Cb_NomeNivel.Text = "2 - Acesso Total - Cadastro Usuários"
        ElseIf txtNivel.Text = "3" Then
            Cb_NomeNivel.Text = "3 - Somente Relatório"
        End If
    End Sub


    Private Sub Cb_NomeNivel_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cb_NomeNivel.SelectedValueChanged
        If Cb_NomeNivel.Text = "1 - Acesso Total" Then
            txtNivel.Text = "1"
        ElseIf Cb_NomeNivel.Text = "2 - Acesso Total - Cadastro Usuários" Then
            txtNivel.Text = "2"
        ElseIf Cb_NomeNivel.Text = "3 - Somente Relatório" Then
            txtNivel.Text = "3"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Cbo_EntidadeLogada.Enabled = True
    End Sub
End Class