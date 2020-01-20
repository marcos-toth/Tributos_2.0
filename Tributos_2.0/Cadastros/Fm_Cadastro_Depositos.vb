Imports System.Data.SqlClient

Public Class Fm_Cadastro_Depositos
    Private Sub Fm_Cadastro_Load(sender As Object, e As EventArgs) Handles Me.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Me.MdiParent = Fm_Principal
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        ComboData()

        vlAno = DateTime.Now.Year
        If vlMes = "0" Then
            Cb_Mes.Text = "12"
            Query = "ORDER BY Ano"
        Else
            Cb_Mes.Text = vlMes
            Query = "ORDER BY Ano DESC"
        End If
        checkbox()

        CB_Data.Text = DateTime.Now.Date
        Preencher_Combo_Ano()
       
        lbInform.Text = ""
        Cb_Mes.Select()
        DG_Depositos.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
        SomarGrid()
    End Sub
    Private Sub ComboData()
      
        If vlMes = "1" Then
            vlMes = "01"
        ElseIf vlMes = "2" Then
            vlMes = "02"
        ElseIf vlMes = "3" Then
            vlMes = "03"
        ElseIf vlMes = "4" Then
            vlMes = "04"
        ElseIf vlMes = "5" Then
            vlMes = "05"
        ElseIf vlMes = "6" Then
            vlMes = "06"
        ElseIf vlMes = "7" Then
            vlMes = "07"
        ElseIf vlMes = "8" Then
            vlMes = "08"
        ElseIf vlMes = "9" Then
            vlMes = "09"
        End If
    End Sub
    Private Sub Checkbox()
        If vlDia > "15" Then
            Rb_Demais.Checked = True
        Else
            Rb_FGTS.Checked = True
        End If
    End Sub
    Private Sub Limpar()
        txtValor.Text = ""
        'txtCodEntidade.Text = ""
        Checkbox()
        txtCodEntidade.Select()
        btnDeletar.Enabled = False
        RB_Competencia.Checked = False
        Cb_Mes.Enabled = False
    End Sub
    Private Sub Valores_Banco()
        vValor = txtValor.Text
        vValor = Replace(vValor, "R$", "")
        vValor = Replace(vValor, ".", "")
        vValor = Replace(vValor, ",", ".")
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If txtValor.Text = "" Then
            lbInform.Text = "Favor Inserir Um Valor de Depósito!!"
            txtValor.Focus()
            Exit Sub
        End If
        Valores_Banco()
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        vlMesComp = vlAno & vlMes
        DataDeposito = CB_Data.Text
        DataCadastro = DateTime.Today
        
        ComboData()

        Try
            If Rb_FGTS.Checked Then ' Determina qual valor vai filtrar
                Tipo = "1"
            ElseIf Rb_Demais.Checked Then
                Tipo = "2"
            ElseIf RB_Decimo.Checked Then
                Tipo = "3"
            ElseIf RB_Adicional.Checked Then
                Tipo = "4"
            End If
            If resultado > 0 Then
                If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                    sql = "update Depositos set valor='" & vValor & "' ,"
                    sql += "Data='" & DataDeposito & "' ,"
                    sql += "Mes='" & vlMes & "' ,"
                    sql += "Ano='" & vlAno & "' ,"
                    sql += "PeriodoCompetencia='" & vlPeriodoComp & "' "
                    sql += " where Id='" & Id & "' "
                End If
            ElseIf resultado = 0 Then
                If txtValor.Text <> "" Then
                    sql = "insert into Depositos (Data,CodEntidade,NomeEntidade,Valor,EntidadeMae,Tipo,Ano,Mes,Usuario,DataCadastro,EntidadeLogada,Deposito,PeriodoCompetencia)"
                    sql += "values ('" & DataDeposito & "',"
                    sql += "'" & txtCodEntidade.Text & "',"
                    sql += "'" & LbNomeEntidade.Text & "',"
                    sql += "'" & vValor & "',"
                    sql += "'" & Entidades & "',"
                    sql += "'" & Tipo & "',"
                    sql += "'" & vlAno & "',"
                    sql += "'" & vlMes & "',"
                    sql += "'" & Usuario & "',"
                    sql += "'" & DataCadastro & "',"
                    sql += "'" & EntidadeLogada & "',"
                    sql += "'" & "S" & "',"
                    sql += "'" & vlPeriodoComp & "')"
                End If
            End If
            Abrir_Conexcao()
        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            Exit Sub
        End Try
        Limpar()
        lbInform.Text = "Dados Gravado com Sucesso!!!"
        DataGrid()
        Exit Sub
        lbInform.Text = "Favor Inserir Um Valor de Depósito!!"
    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
        DataGrid()
        RB_Adicional.Checked = False
    End Sub
    Private Sub Cb_Tipo_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            txtCodEntidade.Focus()
        End If
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
            CB_Data.Focus()
        End If
    End Sub
    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtValor.Text = Format(txtValor.Text, "currency")
        lbInform.Text = ""
        'If txtValor.Text = "" Then
        '    lbInform.Text = "Favor Inserir Um Valor de Depósito!!"
        '    txtValor.Focus()
        'End If
    End Sub

    Private Sub txtCodEntidade_Validated(sender As Object, e As EventArgs) Handles txtCodEntidade.Validated
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
            lbInform.Text = ""
        Catch ex As Exception
            MsgBox("Você Não Tem Acesso a Essa Entidade!")
        End Try
        ValidaCadastro()
    End Sub

    Private Sub Tributos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Limpar()
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Limpar()
    End Sub
    Private Sub Rb_FGTS_Click(sender As Object, e As EventArgs) Handles Rb_FGTS.Click
        G_Cadastro.Enabled = True
        txtCodEntidade.Focus()
    End Sub
    Private Sub Rb_Demais_Click(sender As Object, e As EventArgs) Handles Rb_Demais.Click
        G_Cadastro.Enabled = True
        txtCodEntidade.Focus()
    End Sub

    Private Sub ValidaCadastro()
        Try
            If Rb_FGTS.Checked Then ' Determina qual valor vai filtrar
                Tipo = "1"
            ElseIf Rb_Demais.Checked Then
                Tipo = "2"
            ElseIf RB_Decimo.Checked Then
                Tipo = "3"
            ElseIf RB_Adicional.Checked Then
                Tipo = "0"
            End If
            vlAno = Cb_Ano.Text
            vlMes = Cb_Mes.Text
            vlMesComp = Cb_Mes.Text
            vlPeriodoComp = vlAno & vlMes
            If vlMes = 12 Then
                vlMes = 1
            Else
                vlMes = Cb_Mes.Text + 1
            End If

            sql = "select * from Depositos where CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'and PeriodoCompetencia="
            sql += "'" & vlPeriodoComp & "'and EntidadeLogada="
            sql += "'" & EntidadeLogada & "'and Tipo="
            sql += "'" & Tipo & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Depositos")
            resultado = local.Tables("Depositos").Rows.Count

            If resultado > 0 Then
                registro = local.Tables("Depositos").Rows(0)
                vValor = registro("Valor")
                txtValor.Text = Format(vValor, "Currency")
                Id = registro("Id")
                CB_Data.Text = registro("Data")
                vlPeriodoComp = registro("PeriodoCompetencia")
                btnSalvar.Text = "Editar"
                Cb_Mes.Text = vlMes = Microsoft.VisualBasic.Right(vlPeriodoComp, 2)
                btnDeletar.Enabled = True

            ElseIf resultado = 0 Then
                btnSalvar.Text = "Inserir"
                txtValor.Text = ""
                btnDeletar.Enabled = False
            End If
            DataGrid()
        Catch ex As Exception
            MsgBox("Erro de Conexão")
        End Try
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try
            If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                If resultado > 0 Then
                    sql = "delete from Depositos where Id='" & Id & "'"
                    lbInform.Text = "Cadastro Deletado com Sucesso!!!"
                    btnDeletar.Enabled = False
                    Abrir_Conexcao()
                    DataGrid()
                Else
                    lbInform.Text = "Não existem registros para ser Eliminados"
                    Cb_Mes.Select()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MsgBox("Erro de Conexão")
        End Try
        Limpar()
        Cb_Mes.Focus()
    End Sub


    Private Sub Cb_Mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Mes.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            txtCodEntidade.Focus()
            lbInform.Text = ""
        End If
    End Sub

    Private Sub RB_Adicional_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Adicional.CheckedChanged
        Id = 0
        btnDeletar.Enabled = False
        resultado = "0"
        btnSalvar.Text = "Incluir"
        txtValor.Text = ""
        txtValor.Select()
        Cb_Mes.Enabled = True
        txtValor.Text = "0,00"
        txtValor.Select()
    End Sub

    Private Sub RB_Decimo_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Decimo.CheckedChanged
        Cb_Mes.Text = "12"
        Cb_Mes.Enabled = False
        txtCodEntidade.Select()
    End Sub

    Private Sub Rb_Demais_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Demais.CheckedChanged
        Cb_Mes.Enabled = True
        txtCodEntidade.Select()
    End Sub

    Private Sub Rb_FGTS_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_FGTS.CheckedChanged
        Cb_Mes.Enabled = True
        txtCodEntidade.Select()
    End Sub
    Private Sub Preencher_Combo_Ano()
        Try
            sql = "Select Ano from Anos where Condicao="
            sql += "'" & "A" & "' "
            sql += "" & Query & ""
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Anos")
            Cb_Ano.ValueMember = "Id"
            Cb_Ano.DisplayMember = "Ano"
            Cb_Ano.DataSource = local.Tables(0)
            Cb_Ano.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DataGrid()
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        vlMesComp = Cb_Mes.Text
        Try
            DG_Depositos.Rows.Clear()
            conectar.Open()
            sql = "Select Data, CodEntidade, NomeEntidade, Tipo, Valor from Depositos where PeriodoCompetencia="
            sql += "'" & vlPeriodoComp & "'and EntidadeLogada="
            sql += "'" & EntidadeLogada & "'and CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'"
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_Depositos.Rows.Add(dr("Data"), dr("CodEntidade"), dr("NomeEntidade"), dr("Tipo"), dr("Valor"))
            Loop
            conectar.Close()
        Catch ex As Exception

        End Try
        SomarGrid()
    End Sub
    Private Sub SomarGrid()
        Try
            Dim linha As DataGridViewRow
            Dim valor As Double
            For Each linha In DG_Depositos.Rows
                valor = valor + linha.Cells(4).Value
            Next
            Lb_Total.Text = FormatCurrency(valor)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cb_Mes_Validated(sender As Object, e As EventArgs) Handles Cb_Mes.Validated
        DataGrid()
    End Sub

    Private Sub CB_Data_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_Data.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Focus()
        End If
    End Sub

    Private Sub DataGrid_Depositos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Depositos.CellContentClick

        Try
            resultado = "1"
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DG_Depositos.Rows(index)
            CB_Data.Text = selectedrow.Cells(0).Value.ToString()
            txtCodEntidade.Text = selectedrow.Cells(1).Value.ToString()
            LbNomeEntidade.Text = selectedrow.Cells(2).Value.ToString()
            Tipo = selectedrow.Cells(3).Value.ToString()
            txtValor.Text = selectedrow.Cells(4).Value.ToString()
            If Tipo = "1" Then
                Rb_FGTS.Checked = True
            ElseIf Tipo = "2" Then
                Rb_Demais.Checked = True
            ElseIf Tipo = "3" Then
                RB_Decimo.Checked = True
            Else
                RB_Adicional.Checked = True
            End If
            txtValor.Text = Format(txtValor.Text, "currency")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RB_Competencia_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Competencia.CheckedChanged
        Cb_Mes.Enabled = True
        lbInform.Text = "Você Realmente Vai alterar a Competência desse Depósito?"
    End Sub

    Private Sub Abrir_Conexcao()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Cb_Ano_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Cb_Ano.MouseDoubleClick
        Limpar()
    End Sub
End Class