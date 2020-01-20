Imports System.Data.SqlClient
Public Class Fm_Cadastro_COFINS
    Private Sub Fm_Cad_COFINS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        'Conectar ao banco
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        lbInform.Text = ""
        Carrega_Periodo()
        txtData.Text = Date.Today
    End Sub
    'Private Sub Preencher_Combo_Periodo()
    '    'Busca o Nome do usuário logado  
    '    Try
    '        conectar.Open()
    '        sql = "Select Periodo from Periodo where Condicao="
    '        sql += "'" & "A" & "'"
    '        adaptar = New SqlDataAdapter(sql, conectar)
    '        conectar.Close()
    '        local = New DataSet
    '        adaptar.Fill(local, "Periodo")
    '        Cb_Periodo.ValueMember = "Id"
    '        Cb_Periodo.DisplayMember = "Periodo"
    '        Cb_Periodo.DataSource = local.Tables(0)
    '        Cb_Periodo.SelectedIndex = 0
    '    Catch ex As Exception
    '    End Try
    'End Sub
    Private Sub Limpar()
        txtValor.Text = ""
        txtCodEntidade.Text = ""
        txtCodEntidade.Focus()
        LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
        lb_Aviso.Text = ""
    End Sub
    Private Sub Valores_Banco()
        vValor = txtValor.Text
        vValor = Replace(vValor, "R$", "")
        vValor = Replace(vValor, ".", "")
        vValor = Replace(vValor, ",", ".")
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Valores_Banco()
        VPeriodo = Cb_Periodo.Text
        vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
        vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)

        If resultado > 0 Then
            If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                sql = "update COFINS set valor='" & vValor & "' ,"
                sql += "Data='" & txtData.Text & "' ,"
                sql += "Mes='" & vlMes & "', "
                sql += "Usuario='" & Usuario & "' "
                sql += " where Id='" & Id & "' "
                Conectar_Banco()
                sql = "update Tributos set Cofins='" & vValor & "' "
                sql += " where Periodo='" & VPeriodo & "' "
                sql += " and CodEntidade='" & txtCodEntidade.Text & "' "
                Conectar_Banco()
            End If

        ElseIf resultado = 0 Then
            If txtValor.Text <> "" Then
                sql = "insert into COFINS (Data,CodEntidade,NomeEntidade,EntidadeMae,Valor,Usuario,Ano,Mes,EntidadeLogada,Contabilizado)"
                sql += "values ('" & txtData.Text & "',"
                sql += "'" & txtCodEntidade.Text & "',"
                sql += "'" & LbNomeEntidade.Text & "',"
                sql += "'" & Entidades & "',"
                sql += "'" & vValor & "',"
                sql += "'" & Usuario & "',"
                sql += "'" & vlAno & "',"
                sql += "'" & vlMes & "',"
                sql += "'" & EntidadeLogada & "',"
                sql += "'" & "N" & "')"
                Conectar_Banco()
                sql = "update Tributos set Cofins='" & vValor & "' "
                sql += " where Periodo='" & VPeriodo & "' "
                sql += " and CodEntidade='" & txtCodEntidade.Text & "' "
                Conectar_Banco()
            End If
        End If
        Try
            lbInform.Text = "Dados Gravado com Sucesso!!!"

        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            conectar.Close()
            Exit Sub
        End Try
        conectar.Close()
        Limpar()
        Exit Sub
        lbInform.Text = "Favor Inserir Um Valor de COFINS!!"
        txtValor.Focus()
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
    Private Sub txtCodEntidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEntidade.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            txtValor.Focus()
        End If
    End Sub
    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
        End If
    End Sub
    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtValor.Text = Format(txtValor.Text, "currency")
        lbInform.Text = ""
        If txtValor.Text = "" Then
            lbInform.Text = "Favor Inserir Um Valor de Depósito!!"
            txtValor.Focus()
        End If
    End Sub
    Private Sub txtCodEntidade_Validated(sender As Object, e As EventArgs) Handles txtCodEntidade.Validated
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
            registro = local.Tables("Entidade").Rows(0)
            txtCodEntidade.Text = registro("CodEntidade")
            LbNomeEntidade.Text = registro("NomeEntidade")
            Entidades = registro("EntidadeMae")
        Else
            lbInform.Text = "Favor Inserir Um Código de Entidade Válido!!"
            txtCodEntidade.Focus()
            Limpar()
            Exit Sub
        End If
        ValidaCadastro()
        lbInform.Text = ""
    End Sub
    Private Sub Tributos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Limpar()
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Limpar()
    End Sub
    Private Sub Cb_Mes_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            txtCodEntidade.Focus()
        End If
    End Sub
    Private Sub ValidaCadastro()
        VPeriodo = Cb_Periodo.Text
        vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
        vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
        sql = "select * from Cofins where CodEntidade="
        sql += "'" & txtCodEntidade.Text & "'and Mes="
        sql += "'" & vlMes & "'and Ano="
        sql += "'" & vlAno & "'and EntidadeLogada="
        sql += "'" & EntidadeLogada & "'"
        conectar.Open()
        adaptar = New SqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "Cofins")
        resultado = local.Tables("Cofins").Rows.Count

        If resultado > 0 Then
            DataGrid()
            registro = local.Tables("Cofins").Rows(0)
            vValor = registro("Valor")
            txtValor.Text = Format(vValor, "Currency")
            Contabilizado = registro("Contabilizado")
            Id = registro("Id")
            btnSalvar.Text = "Editar"
            If Contabilizado = "S" Then
                btnSalvar.Enabled = False
                lb_Aviso.Text = "Guia Recolhida, Não Pode Alterar o Valor"
                Exit Sub
            End If
            btnSalvar.Enabled = True
            lb_Aviso.Text = ""
        ElseIf resultado = 0 Then
            btnSalvar.Text = "Inserir"
            lb_Aviso.Text = ""
            btnSalvar.Enabled = True
            txtValor.Text = ""
        End If

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        conectar.Close()
        If txtCodEntidade.Text <> "" Then
            If Contabilizado = "N" Then
                sql = "delete from Cofins where Id='" & Id & "'"
                If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                    If resultado > 0 Then
                        Conectar_Banco()
                        sql = "update Tributos set Cofins='" & "0" & "' "
                        sql += " where Periodo='" & VPeriodo & "' "
                        sql += " and CodEntidade='" & txtCodEntidade.Text & "' "
                        Conectar_Banco()
                        lbInform.Text = "Cadastro Deletado com Sucesso!!!"
                    Else
                        lbInform.Text = "Não existem registros para ser Eliminados"
                        Cb_Periodo.Select()
                        Exit Sub
                    End If
                End If
            Else
                MsgBox("Esse Valor Não Pode Ser Excluido Pois a Guia ja Foi Recolhida", vbExclamation, "Exclusão")
                Limpar()
            End If
        End If

        Limpar()
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
            Conectar.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub DG_Cadastro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Cadastro.CellContentClick
        Try
            resultado = "1"
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DG_Cadastro.Rows(index)
            txtData.Text = selectedrow.Cells(0).Value.ToString()
            txtCodEntidade.Text = selectedrow.Cells(1).Value.ToString()
            LbNomeEntidade.Text = selectedrow.Cells(2).Value.ToString()
            Tipo = selectedrow.Cells(3).Value.ToString()
            txtValor.Text = selectedrow.Cells(3).Value.ToString()

            txtValor.Text = Format(txtValor.Text, "currency")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub SomarGrid()
        Try
            Dim linha As DataGridViewRow
            Dim valor As Double
            For Each linha In DG_Cadastro.Rows
                valor = valor + linha.Cells(3).Value
            Next
            Lb_Total.Text = "A Soma dos Valores Cadastrados é " & FormatCurrency(valor)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGrid()
        VPeriodo = Cb_Periodo.Text
        vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
        vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)

        Try
            DG_Cadastro.Rows.Clear()
            conectar.Open()
            sql = "Select Data, CodEntidade, NomeEntidade, Valor from COFINS where Ano="
            sql += "'" & vlAno & "'and Mes="
            sql += "'" & vlMes & "'and EntidadeLogada="
            sql += "'" & EntidadeLogada & "'and CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'"
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_Cadastro.Rows.Add(dr("Data"), dr("CodEntidade"), dr("NomeEntidade"), dr("Valor"))
            Loop

            conectar.Close()
        Catch ex As Exception

        End Try
        SomarGrid()
    End Sub

    Private Sub ChekBox_Periodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChekBox_Periodo.CheckedChanged
        If MsgBox("Os Períodos Anteriores já Foram Encerrados e Recolhidos, Deseja Realmente Lançar Em Períodos Anteriores? Os Juros Gerados Será Enviados Para a Entidade!", MsgBoxStyle.YesNo + vbCritical, "Multa e Juros") = MsgBoxResult.Yes Then
            Carrega_Periodo()
            ChekBox_Periodo.Checked = True
            Exit Sub
        End If
        ChekBox_Periodo.Checked = False
        Carrega_Periodo()
    End Sub
    Private Sub Carrega_Periodo()
        Try
            conectar.Open()
            If ChekBox_Periodo.Checked = True Then
                sql = "Select Periodo from Periodo where Condicao<>"
                sql += "'" & "N" & "'order by Periodo Desc"
            Else
                sql = "Select Periodo from Periodo where Condicao="
                sql += "'" & "A" & "'"
            End If
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            Cb_Periodo.ValueMember = "Id"
            Cb_Periodo.DisplayMember = "Periodo"
            Cb_Periodo.DataSource = local.Tables(0)
            Cb_Periodo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class