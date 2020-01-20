
Imports System.Data.SqlClient
Public Class Fm_Cadastro_Entidade

    Private Sub Fm_Cadastro_Entidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        lbInform.Text = ""
        txtCodEntidade.Focus()
    End Sub
    Private Sub txtCodEntidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEntidade.KeyPress
        If e.KeyChar = "." Then
            e.Handled = True
        ElseIf e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            Ativar()
        End If
    End Sub
    Private Sub Ativar()
        Txt_Nome_Entidade.Focus()
        Txt_Nome_Entidade.Enabled = True
        Txt_entidade_Mae.Enabled = True
        Txt_Filiais.Enabled = True
        Txt_Categoria.Enabled = True
        Cb_Cofins.Enabled = True
        Cb_Deposito.Enabled = True
        Txt_IP.Enabled = True
        Txt_Nome_Entidade_Mae.Enabled = True
        Txt_CNPJ.Enabled = True
        Txt_Banco.Enabled = True
    End Sub

    Private Sub txtCodEntidade_Leave(sender As Object, e As EventArgs) Handles txtCodEntidade.Leave
        Try
            lbInform.Text = ""
            sql = "select * from Entidade where CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            resultado = local.Tables("Entidade").Rows.Count
            If resultado > 0 Then
                Ativar()
                registro = local.Tables("Entidade").Rows(0)
                Id = registro("id")
                Txt_Nome_Entidade.Text = registro("NomeEntidade")
                Txt_entidade_Mae.Text = registro("EntidadeMae")
                Txt_Filiais.Text = registro("Filiais")
                Txt_Categoria.Text = registro("Categoria")
                Cb_Cofins.Text = registro("COFINS")
                Cb_Deposito.Text = registro("Deposito")
                Txt_IP.Text = registro("IP")
                Entidades = registro("EntidadeMae")
                Txt_Banco.Text = registro("Banco")
                Txt_Nome_Entidade_Mae.Text = registro("Razao_Social")
                Txt_CNPJ.Text = registro("CNPJ")
                btnSalvar.Text = "Editar"
                btnDeletar.Enabled = True
            Else
                Txt_Nome_Entidade.Text = ""
                Txt_entidade_Mae.Text = ""
                Txt_Filiais.Text = ""
                Txt_Categoria.Text = ""
                Cb_Cofins.Text = "N"
                Cb_Deposito.Text = "S"
                Txt_IP.Text = ""
                lbInform.Text = "Você Tem Certeza Que Irá Inserir uma Nova Entidade!!!"
                Txt_Nome_Entidade.Focus()
                btnDeletar.Enabled = False
                btnSalvar.Text = "Inserir"
                Exit Sub
            End If

            lbInform.Text = ""
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCodEntidade_Validated(sender As Object, e As EventArgs) Handles txtCodEntidade.Validated
        
    End Sub
    Private Sub Limpar()
        txtCodEntidade.Text = ""
        Txt_Nome_Entidade.Text = ""
        Txt_entidade_Mae.Text = ""
        Txt_Filiais.Text = ""
        Txt_Categoria.Text = ""
        Cb_Cofins.Text = "N"
        Cb_Deposito.Text = "S"
        Txt_IP.Text = ""
        Txt_Banco.Text = ""

        btnDeletar.Enabled = False

        txtCodEntidade.Focus()
        Txt_Nome_Entidade.Enabled = False
        Txt_entidade_Mae.Enabled = False
        Txt_Filiais.Enabled = False
        Txt_Categoria.Enabled = False
        Cb_Cofins.Enabled = False
        Cb_Deposito.Enabled = False
        Txt_IP.Enabled = False
        Txt_Nome_Entidade_Mae.Enabled = False
        Txt_CNPJ.Enabled = False
        Txt_Banco.Enabled = False
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub

    Private Sub Txt_Nome_Entidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nome_Entidade.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_entidade_Mae.Focus()
        End If
    End Sub
    Private Sub Txt_Nome_Entidade_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Nome_Entidade.TextChanged
        'transforma os nomes com as primeiras em maiusculas
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.Txt_Nome_Entidade.SelectionStart
        selLength = Me.Txt_Nome_Entidade.SelectionLength
        Me.Txt_Nome_Entidade.Text = StrConv(Me.Txt_Nome_Entidade.Text, VbStrConv.ProperCase)
        Me.Txt_Nome_Entidade.SelectionStart = selStart
        Me.Txt_Nome_Entidade.SelectionLength = selLength
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If resultado = 0 Then
                sql = "insert into Entidade (CodEntidade,NomeEntidade,EntidadeMae,Filiais,Categoria, Cofins,Deposito,IP,Banco, Razao_Social, CNPJ)"
                sql += "values ('" & txtCodEntidade.Text & "',"
                sql += "'" & Txt_Nome_Entidade.Text & "',"
                sql += "'" & Txt_entidade_Mae.Text & "',"
                sql += "'" & Txt_Filiais.Text & "',"
                sql += "'" & Txt_Categoria.Text & "',"
                sql += "'" & Cb_Cofins.Text & "',"
                sql += "'" & Cb_Deposito.Text & "',"
                sql += "'" & Txt_IP.Text & "',"
                sql += "'" & Txt_Banco.Text & "',"
                sql += "'" & Txt_Nome_Entidade_Mae.Text & "',"
                sql += "'" & Txt_CNPJ.Text & "')"
                Conectar_Banco()
            Else

                sql = "update entidade set NomeEntidade ='" & Txt_Nome_Entidade.Text & "' ,"
                sql += "EntidadeMae='" & Txt_entidade_Mae.Text & "',"
                sql += "Filiais='" & Txt_Filiais.Text & "',"
                sql += "Categoria='" & Txt_Categoria.Text & "',"
                sql += "Cofins='" & Cb_Cofins.Text & "',"
                sql += "Deposito='" & Cb_Deposito.Text & "',"
                sql += "IP='" & Txt_IP.Text & "',"
                sql += "Banco='" & Txt_Banco.Text & "'"
                sql += " where id='" & Id & "' "
                Conectar_Banco()
            End If
            If Informe = "Erro" Then
                MsgBox("Os Dados Não Foram Salvo!!", vbInformation, "Atualizar")
                Exit Sub
            Else
                MsgBox("Dados Salvo com Sucesso!!", vbInformation, "Atualizar")
                Limpar()

            End If
        Catch ex As Exception

        End Try
       
    End Sub
    Private Sub Conectar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conectar.Close()
            Informe = "Erro"
            Exit Sub
        End Try
    End Sub
End Class