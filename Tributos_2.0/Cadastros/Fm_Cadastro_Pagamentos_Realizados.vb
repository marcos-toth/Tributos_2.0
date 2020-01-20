Imports System.Data.SqlClient
Public Class Fm_Cadastro_Pagamentos_Realizados

    Private Sub Fm_Cadastro_Pagamentos_Realizados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vlDia As String
        Me.MdiParent = Fm_Principal
        txtData.Text = Date.Today
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        vlAno = DateTime.Now.Year

        If vnivel > 0 Then
            If vlDia > 19 Then
                LbCab.Text = "Data Bloqueada para Digitação!"
                G_Cadastro.Enabled = False
                Exit Sub
            End If
        End If
        If vlMes = "0" Then
            Query = "ORDER BY Periodo"
        Else
            Query = "ORDER BY Periodo DESC"
        End If
        txtCodEntidade.Select()
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Carrega_Periodo()
        'Carrega_Ano()

    End Sub

    Private Sub Limpar()
        txtValor.Text = ""
        txtCodEntidade.Text = ""
        TxtPago.Text = "0,00"
        LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
        TxtValorCorrigido.Text = ""
        btnDeletar.Enabled = False
        txtCodEntidade.Select()
        Chek_Varios.Enabled = False
        TxtValorCorrigido.Enabled = False
        TxtPago.Enabled = True
    End Sub
    Private Sub Valores_Banco()

        vValor = txtValor.Text
        vValor = Replace(vValor, "R$", "")

        vCorr = TxtPago.Text
        vCorr = Replace(vCorr, "R$", "")

        Total = vValor - vCorr

        vValor = Replace(vValor, ".", "")
        vValor = Replace(vValor, ",", ".")


        vCorr = Replace(vCorr, ".", "")
        vCorr = Replace(vCorr, ",", ".")

        Total = Replace(Total, ".", "")
        Total = Replace(Total, ",", ".")

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
    Private Sub Carrega_Ano()
        Try
            sql = "Select Periodo from Periodo where Condicao="
            sql += "'" & "A" & "' "
            sql += "" & Query & ""
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            Cb_Periodo.ValueMember = "Id"
            Cb_Periodo.DisplayMember = "Periodo"
            Cb_Periodo.DataSource = local.Tables(0)
            Cb_Periodo.SelectedIndex = 0
        Catch ex As Exception
            conectar.Close()
        End Try
    End Sub

    Private Sub Btn_Observacao_Click(sender As Object, e As EventArgs) Handles Btn_Observacao.Click
        Fm_Cadastro_Observacao.Show()
    End Sub

    Private Sub Chek_Varios_CheckedChanged(sender As Object, e As EventArgs) Handles Chek_Varios.CheckedChanged
        Fm_Somar_2.Show()
    End Sub


    Private Sub TxtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtValorCorrigido.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
            Soma2()
        End If
    End Sub

    Public Sub Soma()
        Try
            Total = txtValor.Text - TxtPago.Text
            TxtValorCorrigido.Text = Format(Total, "Currency")
        Catch ex As Exception

        End Try
    End Sub
    Public Sub Soma2()
        Try
            Total = txtValor.Text - TxtValorCorrigido.Text
            TxtPago.Text = Format(Total, "Currency")
            TxtValorCorrigido.Text = Format(TxtValorCorrigido.Text, "Currency")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtCodEntidade_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEntidade.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            Try
                TxtPago.Focus()
                Carregar()
            Catch ex As Exception
                conectar.Close()
            End Try

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
    Private Sub TxtValorCorrigido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPago.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If

        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
            Soma()
        End If
    End Sub
    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        txtValor.Text = Format(txtValor.Text, "currency")
        lbInform.Text = ""
        If txtValor.Text = "" Then
            lbInform.Text = "Favor Inserir Um Valor Válido!!"
            txtValor.Focus()
        End If
    End Sub
    Private Sub TxtValorCorrigido_Leave(sender As Object, e As EventArgs) Handles TxtPago.Leave
        TxtPago.Text = Format(TxtPago.Text, "currency")
        lbInform.Text = ""
        If TxtPago.Text = "" Then
            lbInform.Text = "Favor Inserir Um Valor Válido!!"
            TxtPago.Focus()
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
        conectar.Close()
        If resultado > 0 Then

            registro = local.Tables("Entidade").Rows(0)
            txtCodEntidade.Text = registro("CodEntidade")
            Id = registro("Id")
            LbNomeEntidade.Text = registro("NomeEntidade")
            Entidades = registro("EntidadeMae")
            DataGrid()
        Else
            lbInform.Text = "Favor Inserir Um Código de Entidade Válido!!"
            txtCodEntidade.Focus()
            'Limpar()
            Exit Sub
        End If
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


    Private Sub Carregar()

        Try
            VPeriodo = Cb_Periodo.Text
            sql = "select * from Tributos where codEntidade="
            sql += "'" & txtCodEntidade.Text & "'and Periodo="
            sql += "'" & VPeriodo & "'and Campo="
            sql += "'" & EntidadeLogada & "'"

            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Tributos")
            resultado2 = local.Tables("Tributos").Rows.Count

            If resultado2 > 0 Then
                btnSalvar.Enabled = True
                If TipoTributos = "INSS" Then
                    Chek_Varios.Enabled = True
                    registro2 = local.Tables("Tributos").Rows(0)
                    Contabilizado = registro2("Recolhido")
                    Entidades = registro2("EntidadeMae")
                    INSS = registro2("INSS")
                    INSS_Deducao = registro2("INSS_Deducao")
                    INSS_RPA = registro2("INSS_RPA")
                    INSS_Aredondamento = registro2("INSS_Aredondamento")
                    Total = INSS + INSS_RPA - INSS_Deducao - INSS_Aredondamento
                    txtValor.Text = Format(Total, "Currency")
                    INSS_Pago_Campo = registro2("INSS_Pago_Campo")
                    TxtPago.Text = Format(INSS_Pago_Campo, "Currency")
                    If INSS_Pago_Campo <> "0.0" Then
                        vCorr = Total - INSS_Pago_Campo
                        TxtValorCorrigido.Text = Format(vCorr, "Currency")
                        btnSalvar.Text = "Alterar"
                        btnDeletar.Enabled = True
                    Else
                        btnSalvar.Text = "Inserir"
                        btnDeletar.Enabled = False
                    End If
                    If Contabilizado = "S" Then
                        btnSalvar.Enabled = False
                        btnDeletar.Enabled = False
                        lbInform.Text = "Guia Contabilizada, Não Pode Alterar o Valor"
                        Exit Sub
                    End If
                    btnSalvar.Enabled = True
                Else
                    Chek_Varios.Enabled = True
                    registro2 = local.Tables("Tributos").Rows(0)
                    Contabilizado = registro2("Recolhido")
                    Entidades = registro2("EntidadeMae")
                    FGTS_Mes = registro2("FGTS_Mes")
                    FGTS_Mes_SEFIP = registro2("FGTS_Mes_SEFIP")
                    FGTS_13_SEFIP = registro2("FGTS_13_SEFIP")
                    FGTS_13 = registro2("FGTS_13")
                    Total = FGTS_13 + FGTS_13_SEFIP + FGTS_Mes_13 + FGTS_Mes_SEFIP + FGTS_Mes
                    txtValor.Text = Format(Total, "Currency")
                    FGTS_Pago_Campo = registro2("FGTS_Pago_Campo")
                    TxtPago.Text = Format(FGTS_Pago_Campo, "Currency")

                    If FGTS_Pago_Campo <> "0.0" Then
                        vCorr = Total - FGTS_Pago_Campo
                        TxtValorCorrigido.Text = Format(vCorr, "Currency")
                        btnSalvar.Text = "Alterar"
                        btnDeletar.Enabled = True
                    Else
                        btnSalvar.Text = "Inserir"
                        btnDeletar.Enabled = False
                    End If
                    If Contabilizado = "S" Then
                        btnSalvar.Enabled = False
                        btnDeletar.Enabled = False
                        lbInform.Text = "Guia Contabilizada, Não Pode Alterar o Valor"
                        Exit Sub
                    End If
                    btnSalvar.Enabled = True

                End If

            ElseIf resultado2 = 0 Then
                btnSalvar.Enabled = False
                LbNomeEntidade.Text = "Você não tem acesso a essa Entidade"
                RB_FGTS.Checked = False
                Rb_INSS.Checked = False
                txtCodEntidade.Enabled = False
                txtValor.Enabled = False
            End If
        Catch ex As Exception
            'If resultado2 = "0" Then
            MsgBox(ex.Message)
            'End If
        End Try

    End Sub

    Private Sub RB_FGTS_CheckedChanged(sender As Object, e As EventArgs) Handles RB_FGTS.CheckedChanged
        txtCodEntidade.Enabled = True
        txtCodEntidade.Focus()
        TipoTributos = "FGTS"
        Limpar()
    End Sub

    Private Sub Rb_INSS_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_INSS.CheckedChanged
        txtCodEntidade.Enabled = True
        txtCodEntidade.Focus()
        TipoTributos = "INSS"
        Limpar()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Valores_Banco()
            VPeriodo = Cb_Periodo.Text
            If TipoTributos = "FGTS" Then
                sql = "update Tributos set FGTS_Pago_Campo='" & vCorr & "' "
                sql += " where Periodo='" & VPeriodo & "'"
                sql += " And CodEntidade='" & txtCodEntidade.Text & "' "
                Conectar_Banco()
                lbInform.Text = "Dados Gravados com Sucesso!!"
            Else
                sql = "update Tributos set INSS_Pago_Campo='" & vCorr & "' "
                sql += " where Periodo='" & VPeriodo & "'"
                sql += " And CodEntidade='" & txtCodEntidade.Text & "' "
                Conectar_Banco()
                lbInform.Text = "Dados Gravados com Sucesso!!"
            End If

        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            conectar.Close()
            Exit Sub
        End Try
        Limpar()
        Exit Sub

        lbInform.Text = "Favor Inserir o Valor da Dedução!!"
        txtValor.Focus()

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        MsgBox("Infelizmente esse processo não poderá ser feito, Entre em contato com o Suporte da UCB", MsgBoxStyle.Information)
    End Sub
    Private Sub DataGrid()
        VPeriodo = Cb_Periodo.Text
        vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
        vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)

        Try
            DG_Cadastro.Rows.Clear()
            conectar.Open()
            sql = "Select Periodo, CodEntidade, INSS_Pago_Campo, FGTS_Pago_Campo from Tributos where Periodo="
            sql += "'" & Cb_Periodo.Text & "'and Campo="
            sql += "'" & EntidadeLogada & "'and CodEntidade="
            sql += "'" & txtCodEntidade.Text & "'"
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_Cadastro.Rows.Add(dr("Periodo"), dr("CodEntidade"), dr("INSS_Pago_Campo"), dr("FGTS_Pago_Campo"))
            Loop

            conectar.Close()
        Catch ex As Exception
            conectar.Close()
            MsgBox(ex.Message)
        End Try
        SomarGrid()
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
                sql += "'" & "N" & "'order by Periodo desc "
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