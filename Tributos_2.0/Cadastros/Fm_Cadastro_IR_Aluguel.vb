Imports System.Data.SqlClient
Public Class Fm_Cadastro_IR_Aluguel
    Private Sub Fm_Cad_IR_Aluguel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim vlDia As String
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Me.MdiParent = Fm_Principal
        txtData.Text = Date.Today
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        vlAno = DateTime.Now.Year
        vlCalendario = DateTime.Now.Year()

        Carrega_Periodo()
        lbInform.Text = ""
        txtCodEntidade.Select()
        DataGrid()
        btnDeletar.Enabled = False
        Txt_Data_Deposito.Text = Date.Today
    End Sub
    Private Sub Limpar()
        txtValor.Text = "0,00"
        'txtCodEntidade.Text = ""
        txtCodEntidade.Focus()
        LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
        Txt_CPF.Text = ""
        Txt_CNPJ.Text = ""
        Txt_Nome.Text = ""
        Txt_Nome.Enabled = True
        Txt_vBase.Text = "0,00"
        Txt_reducao.Text = "0,00"
        btnDeletar.Enabled = False
    End Sub
    Private Sub Valores_Banco()
        Try
            vValor = txtValor.Text
            vValor = Replace(vValor, "R$", "")
            vValor = Replace(vValor, ".", "")
            vValor = Replace(vValor, ",", ".")

            vlBase = Txt_vBase.Text
            vlBase = Replace(vlBase, "R$", "")
            vlBase = Replace(vlBase, ".", "")
            vlBase = Replace(vlBase, ",", ".")

            vlReducao = Txt_reducao.Text
            vlReducao = Replace(vlReducao, "R$", "")
            vlReducao = Replace(vlReducao, ".", "")
            vlReducao = Replace(vlReducao, ",", ".")

        Catch ex As Exception
            MsgBox("Valor Incorreto")
        End Try
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        If Txt_Nome.Text <> "" Then
            VPeriodo = Cb_Periodo.Text

            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
            vlCalendario = vlAno
            Valores_Banco()
            DataDeposito = Format(Txt_Data_Deposito.Value, "yyyy-MM-dd")
            If vlMes = 12 Then
                vlCalendario = vlAno
                vlCalendario = vlCalendario + 1
            End If

            If Rb_PF.Checked = True Then
                CPF_CNPJ = Txt_CPF.Text
            Else
                CPF_CNPJ = Txt_CNPJ.Text
            End If

            If resultado2 = 0 Then
                Inserir_Cadastro()
            End If

            If resultado > 0 Then

                If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                    sql = "update Ir set valor='" & vValor & "' ,"
                    sql += "Data='" & txtData.Text & "' ,"
                    sql += "NomeBeneficiario='" & Txt_Nome.Text & "' ,"
                    sql += "ValorBase='" & vlBase & "' ,"
                    sql += "Deducao_Base_IR='" & vlReducao & "' ,"
                    sql += "Mes='" & vlMes & "' ,"
                    sql += "Data_Deposito='" & DataDeposito & "' ,"
                    sql += "Usuario='" & Usuario & "' "
                    sql += " where Id='" & Id & "' "
                    Conectar_Banco()
                    Carregar_IR()

                    vValor_Banco = Replace(vValor_Banco, ".", "")
                    vValor_Banco = Replace(vValor_Banco, ",", ".")
                    sql = "update Tributos set IR_Aluguel='" & vValor_Banco & "' "
                    sql += " where Periodo='" & VPeriodo & "'"
                    sql += " And CodEntidade='" & txtCodEntidade.Text & "' "
                    Conectar_Banco()
                End If

            ElseIf resultado = 0 Then

                sql = "insert into IR (Data,CodEntidade,NomeEntidade,EntidadeMae,ValorBase,Deducao_Base_IR,Valor,Usuario,Ano,Mes,NomeBeneficiario,EntidadeLogada,CPF_CNPJ,Justificativa,Data_deposito,Contabilizado,Ano_Calendario)"
                sql += "values ('" & txtData.Text & "',"
                sql += "'" & txtCodEntidade.Text & "',"
                sql += "'" & LbNomeEntidade.Text & "',"
                sql += "'" & Entidades & "',"
                sql += "'" & vlBase & "',"
                sql += "'" & vlReducao & "',"
                sql += "'" & vValor & "',"
                sql += "'" & Usuario & "',"
                sql += "'" & vlAno & "',"
                sql += "'" & vlMes & "',"
                sql += "'" & Txt_Nome.Text & "',"
                sql += "'" & EntidadeLogada & "',"
                sql += "'" & CPF_CNPJ & "',"
                sql += "'" & Txt_Justificativa.Text & "',"
                sql += "'" & DataDeposito & "',"
                sql += "'" & "N" & "',"
                sql += "'" & vlCalendario & "')"
                Conectar_Banco()
                Carregar_IR()
                vValor_Banco = Replace(vValor_Banco, ".", "")
                vValor_Banco = Replace(vValor_Banco, ",", ".")
                sql = "update Tributos set IR_Aluguel='" & vValor_Banco & "' "
                sql += " where Periodo='" & VPeriodo & "'"
                sql += " And CodEntidade='" & txtCodEntidade.Text & "' "
                Conectar_Banco()
            End If
            Try
                lbInform.Text = "Dados Gravado com Sucesso!!!"

            Catch ex As Exception
                MsgBox("Seus Dados Não Foram Gravados")
                conectar.Close()
                Exit Sub
            End Try
            Limpar()
            DataGrid()
            Exit Sub
            lbInform.Text = "Favor Inserir Um Valor Base!!"
            txtValor.Focus()
        Else
            MsgBox("Favor Inserir um cadastro")
        End If

    End Sub
    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
    Private Sub txtCodEntidade_Validated(sender As Object, e As EventArgs) Handles txtCodEntidade.Validated ' Verifica se tem entidade
        Try
            VPeriodo = Cb_Periodo.Text
            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
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
                DataGrid()
            Else
                lbInform.Text = "Favor Inserir Um Código de Entidade Válido!!"
                txtCodEntidade.Focus()
                Limpar()
                Exit Sub
            End If
            lbInform.Text = ""
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Tributos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        Limpar()
    End Sub
    Private Sub btnSair_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Limpar()
    End Sub
    Private Sub txt_Nome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Nome.TextChanged, Txt_Nome.TextChanged
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.Txt_Nome.SelectionStart
        selLength = Me.Txt_Nome.SelectionLength
        Me.Txt_Nome.Text = StrConv(Me.Txt_Nome.Text, VbStrConv.ProperCase)
        Me.Txt_Nome.SelectionStart = selStart
        Me.Txt_Nome.SelectionLength = selLength
    End Sub
    Private Sub Txt_JustificativaChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Justificativa.TextChanged
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.Txt_Justificativa.SelectionStart
        selLength = Me.Txt_Justificativa.SelectionLength
        Me.Txt_Justificativa.Text = StrConv(Me.Txt_Justificativa.Text, VbStrConv.ProperCase)
        Me.Txt_Justificativa.SelectionStart = selStart
        Me.Txt_Justificativa.SelectionLength = selLength
    End Sub
    Private Sub Rb_PJ_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_PJ.CheckedChanged
        Lb_CPF.Text = "CNPJ:"
        Txt_CPF.Visible = False
        Txt_CNPJ.Visible = True
        Cb_Periodo.Select()
    End Sub
    Private Sub Rb_PF_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_PF.CheckedChanged
        Lb_CPF.Text = "CPF:"
        Txt_CPF.Visible = True
        Txt_CNPJ.Visible = False
        Cb_Periodo.Select()
    End Sub
    'Private Sub Cb_Mes_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If AscW(e.KeyChar) = Keys.Enter Then
    '        Cb_Periodo.Focus()
    '    End If
    'End Sub
    'Private Sub Cb_Ano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Periodo.KeyPress
    '    If AscW(e.KeyChar) = Keys.Enter Then
    '        
    '    End If
    'End Sub
    Private Sub Cb_Periodo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Periodo.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Limpar()
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
            If Rb_PF.Checked = True Then
                Txt_CPF.Select()
            Else
                Txt_CNPJ.Focus()
            End If
        End If
    End Sub
    Private Sub Txt_CPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CPF.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Try
                Txt_Nome.Focus()
            Catch ex As Exception
                Txt_vBase.Focus()
            End Try
        End If
    End Sub
    Private Sub Txt_CNPJ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_CNPJ.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_Nome.Focus()
        End If
    End Sub
    Private Sub Txt_Nome_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Nome.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_vBase.Focus()
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
    Private Sub txt_CPF_Leave(sender As Object, e As EventArgs) Handles Txt_CPF.Leave ' Seleciona o cliente cadastrado
        Try
            resultado = 0
            resultado2 = 0
            lbInform.Text = ""
            VPeriodo = Cb_Periodo.Text
            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
            sql = "select * from Cliente_IR where CPF_CNPJ="
            sql += "'" & Txt_CPF.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Cliente_IR")
            resultado2 = local.Tables("Cliente_IR").Rows.Count
            If resultado2 > 0 Then
                registro = local.Tables("Cliente_IR").Rows(0)
                Txt_Nome.Text = registro("Nome")
                Id = registro("Id")
            ElseIf resultado2 = 0 Then
                Txt_Nome.Enabled = Enabled
                Exit Sub
            End If
            'Txt_Nome.Enabled = False
            Txt_vBase.Focus()
            ValidaCadastro()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Txt_CNPJ_Leave(sender As Object, e As EventArgs) Handles Txt_CNPJ.Leave
        Try
            resultado = 0
            resultado2 = 0
            lbInform.Text = ""
            VPeriodo = Cb_Periodo.Text
            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
            sql = "select * from Cliente_IR where CPF_CNPJ="
            sql += "'" & Txt_CNPJ.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Cliente_IR")
            resultado2 = local.Tables("Cliente_IR").Rows.Count

            If resultado2 > 0 Then
                registro = local.Tables("Cliente_IR").Rows(0)
                Txt_Nome.Text = registro("Nome")
                Id = registro("Id")
                ValidaCadastro()

            ElseIf resultado2 = 0 Then
                Txt_Nome.Enabled = Enabled
                btnSalvar.Text = "Inserir"
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Txt_vBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_vBase.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            If Chek_base_Reduzida.Checked Then
                Txt_reducao.Select()
            Else
                btnSalvar.Select()
            End If
        End If
    End Sub
    Private Sub Txt_reducao_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_reducao.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
        End If
    End Sub
    Private Sub Txt_vBase_Leave(sender As Object, e As EventArgs) Handles Txt_vBase.Leave
        'Formatar()
        Calculo_IR()
    End Sub
    Private Sub Txt_reducao_Leave(sender As Object, e As EventArgs) Handles Txt_reducao.Leave
        'Formatar()
        Calculo_IR()
    End Sub
    Public Sub LimpRB()
        Rb_B2.Checked = False
        Rb_B1.Checked = False
        Rb_B3.Checked = False
        Rb_B4.Checked = False
    End Sub
    Public Sub Formatar()
        Txt_vBase.Text = Replace(vValor, "R$", "")
        vlBase = Replace(vValor, ".", "")
    End Sub
    Private Sub ValidaCadastro()
        Try
            btnDeletar.Enabled = True
            If Rb_PF.Checked = True Then
                CPF_CNPJ = Txt_CPF.Text
            Else
                CPF_CNPJ = Txt_CNPJ.Text
            End If
            sql = "select * from IR where CPF_CNPJ="
            sql += "'" & CPF_CNPJ & "'and Mes="
            sql += "'" & vlMes & "'and Ano="
            sql += "'" & vlAno & "'and EntidadeLogada="
            sql += "'" & EntidadeLogada & "' and codEntidade="
            sql += "'" & txtCodEntidade.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            resultado = local.Tables("IR").Rows.Count

            If resultado > 0 Then
                registro = local.Tables("IR").Rows(0)
                Txt_vBase.Text = Format(registro("ValorBase"), "Currency")
                Txt_reducao.Text = Format(registro("Deducao_Base_IR"), "Currency")
                vValor = registro("Valor")
                txtValor.Text = Format(vValor, "Currency")
                Contabilizado = registro("Contabilizado")
                Txt_Data_Deposito.Text = registro("Data_Deposito")
                Id = registro("Id")

                If Contabilizado = "S" Then
                    btnSalvar.Enabled = False
                    btnDeletar.Enabled = False
                    lbInform.Text = "Guia Recolhida, Não Pode Alterar o Valor"
                End If
                btnSalvar.Text = "Editar"

            ElseIf resultado = 0 Then
                btnSalvar.Enabled = True
                btnSalvar.Text = "Inserir"
                btnDeletar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        If Contabilizado = "N" Then

            If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                If resultado > 0 Then
                    sql = "delete from IR where Id='" & Id & "'"
                    Conectar_Banco()
                    Carregar_IR()
                    vValor_Banco = Replace(vValor_Banco, ".", "")
                    vValor_Banco = Replace(vValor_Banco, ",", ".")
                    sql = "update Tributos set IR_Aluguel='" & vValor_Banco & "' "
                    sql += " where Periodo='" & VPeriodo & "'"
                    sql += " And CodEntidade='" & txtCodEntidade.Text & "' "
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
        Limpar()
        DataGrid()
    End Sub
    Sub Inserir_Cadastro()
        Try
            sql = "insert into Cliente_IR (Nome,CPF_CNPJ)"
            sql += "values ('" & Txt_Nome.Text & "',"
            sql += "'" & CPF_CNPJ & "')"
            Conectar_Banco()
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Exit Sub
        End Try
    End Sub
    Private Sub Carregar_IR()

        Try
            sql = "Select sum(Valor) Valor from IR  Where codEntidade="
            sql += "'" & txtCodEntidade.Text & "'and Mes="
            sql += "'" & vlMes & "'and Ano="
            sql += "'" & vlAno & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            resultado = local.Tables("IR").Rows.Count
            registro = local.Tables("IR").Rows(0)
            vValor_Banco = local.Tables(0).Rows(0)("Valor")
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
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
    Private Sub DataGrid()
        Try
            DG_IR.Rows.Clear()
            conectar.Open()
            sql = "Select DataRecolhimento, Mes, NomeBeneficiario, CPF_CNPJ,ValorBase, Deducao_Base_IR, Valor from IR where Mes="
            sql += "'" & vlMes & "'and Ano="
            sql += "'" & vlAno & "'and EntidadeLogada="
            sql += "'" & EntidadeLogada & "'and CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'Order By NomeBeneficiario"
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_IR.Rows.Add(dr("DataRecolhimento"), dr("Mes"), dr("NomeBeneficiario"), dr("CPF_CNPJ"), dr("ValorBase"), dr("Deducao_Base_IR"), dr("Valor"))
            Loop
            conectar.Close()
            'Limpar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        SomarGrid()
    End Sub
    Private Sub SomarGrid()
        Try
            Dim linha As DataGridViewRow
            Dim valor As Double
            For Each linha In DG_IR.Rows
                valor = valor + linha.Cells(6).Value
            Next
            Lb_Total.Text = "O Valor do IR Cadastrado é " & FormatCurrency(valor)

        Catch ex As Exception
            'MsgBox(ex.Message)
            Lb_Total.Text = "O Valor do IR Cadastrado é 0,00"
        End Try
    End Sub
    Private Sub Ch_Periodo_CheckedChanged(sender As Object, e As EventArgs) Handles ChekBox_Periodo.CheckedChanged
        If MsgBox("Os Períodos Anteriores já Foram Encerrados e Recolhidos, Deseja Realmente Lançar Em Períodos Anteriores? Os Juros Gerados Será Enviados Para a Entidade!", MsgBoxStyle.YesNo + vbCritical, "Multa e Juros") = MsgBoxResult.Yes Then
            Carrega_Periodo()
            ChekBox_Periodo.Checked = True
            Limpar()
            Exit Sub
        End If
        ChekBox_Periodo.Checked = False
        Carrega_Periodo()
    End Sub
    Private Sub Cb_Periodo_Leave(sender As Object, e As EventArgs) Handles Cb_Periodo.Leave
        VPeriodo = Cb_Periodo.Text
        vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
        vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
        DataGrid()
    End Sub
    Private Sub Chek_base_Reduzida_CheckedChanged(sender As Object, e As EventArgs) Handles Chek_base_Reduzida.CheckedChanged
        If Chek_base_Reduzida.Checked = True Then
            Txt_reducao.Enabled = True
            Txt_reducao.Select()
            Calculo_IR()
            Lb_Inform_Reduc.Visible = True
            Lb_Inform_Reduc.Text = "Favor Inserir a Justificativa, Ex: Condôminio, Taxas ADM, IPTU, etc"
            Txt_Justificativa.Visible = True
        Else
            Txt_reducao.Enabled = False
            Lb_Inform_Reduc.Visible = False
            Txt_reducao.Text = "0,00"
            Calculo_IR()
            Txt_Justificativa.Visible = False
        End If

    End Sub
    Private Sub Calculo_IR()
        Try
            LimpRB()
            If Chek_base_Reduzida.Checked Then
                Reducao_Base_IR_Aluguel = Txt_reducao.Text
            Else
                Txt_reducao.Text = "0,00"
            End If
            Base_IR_Aluguel = Txt_vBase.Text
            Base = Base_IR_Aluguel - Txt_reducao.Text
        Catch ex As Exception
        End Try
        Dim base1, base2, base3, base4 As Double
        base1 = "2826,65"
        base2 = "3751,05"
        base3 = "4664,68"
        base4 = "4664,69"
        If Rb_PF.Checked Then
            Try
                lbInform.Text = ""
                If Txt_vBase.Text = "" Then
                    lbInform.Text = "Favor Inserir Um Valor No Campo Valor Base IR!"
                    txtCodEntidade.Focus()
                End If

                If Base <= base1 Then
                    Dim Soma, Tabela, Deducao As Single

                    Rb_B1.Checked = True

                    Tabela = "0,075"
                    Deducao = "142,80"
                    Soma = Base * Tabela - Deducao
                    txtValor.Text = Soma


                ElseIf Base <= base2 Then
                    Dim Soma, Tabela, Deducao As Single
                    'LimpRB()
                    Rb_B2.Checked = True

                    Tabela = "0,15"
                    Deducao = "354,80"
                    Soma = Base * Tabela - Deducao
                    txtValor.Text = Soma

                ElseIf Base <= base3 Then
                    Dim Soma, Tabela, Deducao As Single
                    'LimpRB()
                    Rb_B3.Checked = True

                    Tabela = "0,225"
                    Deducao = "636,13"
                    Soma = Base * Tabela - Deducao
                    txtValor.Text = Soma

                ElseIf Base > base4 Then
                    Dim Soma, Tabela, Deducao As Single
                    'LimpRB()
                    Rb_B4.Checked = True

                    Tabela = "0,275"
                    Deducao = "869,36"
                    Soma = Base * Tabela - Deducao
                    txtValor.Text = Soma

                End If
                If txtValor.Text < 10 Then
                    lbInform.Text = "Valor não Tributado, Mas Tem Que Ser Salvo Para Informe!"
                    txtValor.Text = "0"
                    txtValor.Text = Format(txtValor.Text, "currency")
                End If
            Catch ex As Exception
                If Txt_vBase.Text <> "" Then
                    MsgBox(ex.Message)
                End If
            End Try
        Else
            txtValor.Text = "0"
        End If
        Txt_vBase.Text = Format(Txt_vBase.Text, "currency")
        Txt_reducao.Text = Format(Txt_reducao.Text, "currency")
        txtValor.Text = Format(txtValor.Text, "currency")
    End Sub
End Class
