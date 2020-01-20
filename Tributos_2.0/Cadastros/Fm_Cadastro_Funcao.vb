Imports System.Data.SqlClient
Public Class Fm_Cadastro_Funcao

    Dim Lb_Desligamento As Object


    Private Sub Fm_Cadastro_Funcao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Me.MdiParent = Fm_Principal
        TxtData.Text = Date.Today
        Txt_CodEntidade.Focus()
        DataGrid()
        Preencher_Campo()
        Preencher_Funcao()
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
    Private Sub limpar()
        Txt_CodEntidade.Text = ""
        Lb_NomeEntidade.Text = ""
        txtNomeCompleto.Text = ""
        Cb_Funcao.Text = ""
        Cbo_Campo.Text = ""
        Txt_email.Text = ""
        Txt_FoneComercial.Text = ""
        Txt_FoneCelular.Text = ""
        RB_Sim.Checked = True
        Txt_CodEntidade.Focus()
        If resultado <= "0" Then
            lbInf.Text = ""
        End If
        DataGrid()
        resultado = "0"
        btnSalvar.Text = "Inserir"
    End Sub
    Private Sub DataGrid()
        Try
            DG_Depositos.Rows.Clear()
            conectar.Open()
            sql = "Select CodEntidade, Nome, Funcao, Telefone from Funcao where Campo="
            sql += "'" & EntidadeLogada & "'and Ativo="
            sql += "'" & "Sim" & "'"
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_Depositos.Rows.Add(dr("CodEntidade"), dr("Nome"), dr("Funcao"), dr("Telefone"))
            Loop

            conectar.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Preencher_Campo()
        Try
            If vnivel = "0" Then
                Cbo_Campo.Enabled = True
                sql = "Select DISTINCT Filiais from Entidade "
            Else
                sql = "Select  DISTINCT Filiais from Entidade Where Filiais= "
                sql += "'" & EntidadeLogada & "'"
            End If

            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cbo_Campo.DisplayMember = "Filiais"
            Cbo_Campo.DataSource = local.Tables(0)
            Cbo_Campo.SelectedIndex = -1
            If vnivel = "0" Then
                Cbo_Campo.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Funcao()
        Try
            Cbo_Campo.Enabled = True
            sql = "Select DISTINCT Funcao from Descricao_funcao "
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Descricao_funcao")
            Cb_Funcao.DisplayMember = "Funcao"
            Cb_Funcao.DataSource = local.Tables(0)
            Cb_Funcao.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSalvar_Click_1(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If RB_Sim.Checked Then
            Ativo = "Sim"
        Else
            Ativo = "Não"
        End If

        If TxtData.Text <> "  /  /" Then
            dataAtual = Convert.ToDateTime(TxtData.Text).ToString("yyyy-MM-dd")
        End If
        Try
            If txtNomeCompleto.Text = "" Then
                MsgBox("Favor Inserir um Nome!")
                Exit Sub
            ElseIf Cb_Funcao.Text = "" Then
                MsgBox("Favor Inserir Uma Função!")
                Exit Sub
            ElseIf Cbo_Campo.Text = "" Then
                MsgBox("Favor Inserir Um Campo!")
                Exit Sub
            ElseIf Txt_email.Text = "" Then
                MsgBox("Favor Inserir Um E-Mail!")
                Exit Sub
            ElseIf Txt_FoneComercial.Text = "" Then
                MsgBox("Favor Inserir Um Telefone Comercial")
                Exit Sub
            ElseIf resultado > 0 Then
                If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                    sql = "update Funcao set CodEntidade='" & Txt_CodEntidade.Text & "' ,"
                    sql += "NomeEntidade='" & Lb_NomeEntidade.Text & "' ,"
                    sql += "Nome='" & txtNomeCompleto.Text & "' ,"
                    sql += "Funcao='" & Cb_Funcao.Text & "' ,"
                    sql += "Campo='" & Cbo_Campo.Text & "', "
                    sql += "Email='" & Txt_email.Text & "', "
                    sql += "Telefone='" & Txt_FoneComercial.Text & "', "
                    sql += "Celular='" & Txt_FoneCelular.Text & "', "
                    sql += "Ativo='" & Ativo & "', "
                    sql += "Categoria='" & Categoria & "', "
                    sql += "DataInativo='" & dataAtual & "' "
                    sql += " where Id='" & Id & "' "
                End If
            Else
                sql = "insert into Funcao (CodEntidade,NomeEntidade,Nome,Funcao,Campo,Email,Telefone,Celular,Categoria,Ativo, DataCadastro)"
                sql += "values ('" & Txt_CodEntidade.Text & "',"
                sql += "'" & Lb_NomeEntidade.Text & "',"
                sql += "'" & txtNomeCompleto.Text & "',"
                sql += "'" & Cb_Funcao.Text & "',"
                sql += "'" & Cbo_Campo.Text & "',"
                sql += "'" & Txt_email.Text & "',"
                sql += "'" & Txt_FoneComercial.Text & "',"
                sql += "'" & Txt_FoneCelular.Text & "',"
                sql += "'" & Categoria & "',"
                sql += "'" & Ativo & "',"
                sql += "'" & dataAtual & "')"
            End If
            Abrir_Conexcao()

        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            Exit Sub
        End Try
        lbInf.Text = "Dados Salvos Com Sucesso!"
        limpar()
        DataGrid()
    End Sub
    Private Sub Abrir_Conexcao()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            conectar.Close()
        End Try
    End Sub

    Private Sub txtNomeCompleto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNomeCompleto.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Cb_Funcao.Select()
        End If
    End Sub
    Private Sub Cb_Funcao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Funcao.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Cbo_Campo.Focus()
        End If
    End Sub
    Private Sub Cbo_Campo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cbo_Campo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_email.Focus()
        End If
    End Sub
    Private Sub Txt_email_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_email.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_FoneComercial.Focus()
        End If
    End Sub
    Private Sub Txt_FoneComercial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_FoneComercial.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_FoneCelular.Focus()
        End If
    End Sub
    Private Sub Txt_FoneCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_FoneCelular.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Focus()
        End If
    End Sub

    Private Sub Txt_CodEntidade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CodEntidade.KeyPress
        Try

            sql = "select * from Entidade where CodEntidade="
            sql += "'" & Txt_CodEntidade.Text & "'and Filiais="
            sql += "'" & EntidadeLogada & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            resultado = local.Tables("Entidade").Rows.Count

            If resultado > 0 Then
                registro = local.Tables("Entidade").Rows(0)
                Nome_Entidade = registro("NomeEntidade")
                Categoria = registro("Categoria")
                Lb_NomeEntidade.Text = Nome_Entidade
                txtNomeCompleto.Select()
                resultado = "0"
                lbInf.Text = ""
            ElseIf resultado = 0 Then
                Lb_NomeEntidade.Text = "Insira um Código de Entidade"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Txt_CodEntidade_Validated(sender As Object, e As EventArgs) Handles Txt_CodEntidade.Validated
    '    Try

    '        sql = "select * from Entidade where CodEntidade="
    '        sql += "'" & Txt_CodEntidade.Text & "'and Campo="
    '        sql += "'" & EntidadeLogada & "'"
    '        conectar.Open()
    '        adaptar = New SqlDataAdapter(sql, conectar)
    '        conectar.Close()
    '        local = New DataSet
    '        adaptar.Fill(local, "Entidade")
    '        resultado = local.Tables("Entidade").Rows.Count

    '        If resultado > 0 Then
    '            registro = local.Tables("Entidade").Rows(0)
    '            Lb_NomeEntidade = registro("NomeEntidade")
    '        ElseIf resultado = 0 Then
    '            btnSalvar.Text = "Inserir"
    '            txtValor.Text = ""
    '            btnDeletar.Enabled = False
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limpar()
    End Sub

    Private Sub DG_Depositos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Depositos.CellContentClick
        Try
            limpar()
            btnDeletar.Enabled = True
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DG_Depositos.Rows(index)
            Cod_Entidade = selectedrow.Cells(0).Value.ToString()
            Nome_Cadastrado = selectedrow.Cells(1).Value.ToString()

            sql = "select * from Funcao where CodEntidade="
            sql += "'" & Cod_Entidade & "'and Nome="
            sql += "'" & Nome_Cadastrado & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Funcao")
            resultado = local.Tables("Funcao").Rows.Count

            If resultado > 0 Then
                registro = local.Tables("Funcao").Rows(0)
                Id = registro("Id")
                Txt_CodEntidade.Text = registro("CodEntidade")
                Nome_Entidade = registro("NomeEntidade")
                Lb_NomeEntidade.Text = Nome_Entidade
                txtNomeCompleto.Text = registro("Nome")
                Categoria = registro("Categoria")
                RB_Sim.Checked = True
                Cbo_Campo.Text = registro("Campo")
                Cb_Funcao.Text = registro("Funcao")
                Txt_email.Text = registro("Email")
                Txt_FoneComercial.Text = registro("Telefone")
                Txt_FoneCelular.Text = registro("Celular")
                txtNomeCompleto.Select()
                lbInf.Text = "Verifique todos os campos antes de Salva"
                btnSalvar.Text = "Update"
            ElseIf resultado = 0 Then
                Lb_NomeEntidade.Text = "Tente Novamente"
                resultado = "0"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click

        Try
            If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                If resultado > 0 Then
                    sql = "delete from Funcao where Id='" & Id & "'"
                    lbInf.Text = "Cadastro Deletado com Sucesso!!!"
                    btnDeletar.Enabled = False
                    Abrir_Conexcao()
                Else
                    lbInf.Text = "Não existem registros para ser Eliminados"
                    Txt_CodEntidade.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de Conexão")
        End Try
        Limpar()
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub
    Private Sub RB_Sim_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sim.CheckedChanged
        TxtData.Visible = False
        LbD.Text = ""
    End Sub
    Private Sub RB_Nao_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Nao.CheckedChanged
        TxtData.Visible = True
        LbD.Text = "Data Desligamento:"
    End Sub
End Class