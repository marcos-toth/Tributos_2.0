Imports System.Data.SqlClient
Public Class Fm_Cadastro__Deducao_INSS_Decimo_Terceiro

    Private Sub Fm_Cadastro__Deducao_INSS_Decimo_Terceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vlDia As String
        Me.MdiParent = Fm_Principal
        txtData.Text = Date.Today
        vlDia = Date.Today.Day
        vlDia = DateTime.Now.Day
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        txtCodEntidade.Select()
        Carrega_Ano()
    End Sub
    Private Sub Limpar()
        txtValor.Text = ""
        txtCodEntidade.Text = ""
        TxtValorCorrigido.Text = "0,00"
        LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
        TxtTotal.Text = ""
        btnDeletar.Enabled = False
        txtCodEntidade.Select()
    End Sub
    Private Sub Valores_Banco()

        vValor = txtValor.Text
        vValor = Replace(vValor, "R$", "")

        vCorr = TxtValorCorrigido.Text
        vCorr = Replace(vCorr, "R$", "")

        Total = vValor - vCorr

        vValor = Replace(vValor, ".", "")
        vValor = Replace(vValor, ",", ".")


        vCorr = Replace(vCorr, ".", "")
        vCorr = Replace(vCorr, ",", ".")

        Total = Replace(Total, ".", "")
        Total = Replace(Total, ",", ".")

    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Valores_Banco()
        
            VPeriodo = Cb_Periodo.Text
            If resultado > 0 Then
                sql = "update Decimo_Terceiro set INSS_Arredondamento='" & Total & "', "
                sql += " Usuario='" & Usuario & "'"
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
            Try
                TxtValorCorrigido.Focus()
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
    Private Sub TxtValorCorrigido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValorCorrigido.KeyPress
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
    Private Sub TxtValorCorrigido_Leave(sender As Object, e As EventArgs) Handles TxtValorCorrigido.Leave
        TxtValorCorrigido.Text = Format(TxtValorCorrigido.Text, "currency")
        lbInform.Text = ""
        If TxtValorCorrigido.Text = "" Then
            lbInform.Text = "Favor Inserir Um Valor Válido!!"
            TxtValorCorrigido.Focus()
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
            LbNomeEntidade.Text = registro("NomeEntidade")
            Entidades = registro("EntidadeMae")
        Else
            lbInform.Text = "Favor Inserir Um Código de Entidade Válido!!"
            txtCodEntidade.Focus()
            Limpar()
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
    Private Sub Cb_Mes_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            txtCodEntidade.Focus()
        End If
    End Sub

    Private Sub Carregar()

        Try
            VPeriodo = Cb_Periodo.Text
            sql = "select * from Decimo_Terceiro where codEntidade="
            sql += "'" & txtCodEntidade.Text & "'and Periodo="
            sql += "'" & VPeriodo & "'"

            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Decimo_Terceiro")
            resultado2 = local.Tables("Decimo_Terceiro").Rows.Count

            If resultado2 > 0 Then
                registro2 = local.Tables("Decimo_Terceiro").Rows(0)
                Contabilizado = registro2("Recolhido")
                Entidades = registro2("EntidadeMae")
                INSS = registro2("INSS")
                INSS_Aredondamento = registro2("INSS_Arredondamento")
                INSS_Deducao = registro2("INSS_Deducao")
                Total = INSS - INSS_Deducao
                TxtValorCorrigido.Text = ""
                If INSS_Aredondamento <> "0" Then
                    vCorr = Total - INSS_Aredondamento
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
            ElseIf resultado2 = 0 Then
                btnSalvar.Text = "Inserir"
            End If
            txtValor.Text = Format(Total, "Currency")
            TxtTotal.Text = Format(INSS_Aredondamento, "Currency")
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Soma()
        Try
            Total = txtValor.Text - TxtValorCorrigido.Text
            TxtTotal.Text = Format(Total, "Currency")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        conectar.Close()
        If txtCodEntidade.Text <> "" Then
            If Contabilizado = "N" Then

                If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                    If resultado > 0 Then
                        sql = "update Decimo_Terceiro set INSS_Arredondamento='" & "0.0" & "' "
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
            conectar.Close()
            Exit Sub
        End Try
    End Sub
    Private Sub Carrega_Ano()
        Try
            sql = "Select Periodo from Decimo_terceiro where Recolhido="
            sql += "'" & "N" & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Decimo_terceiro")
            Cb_Periodo.ValueMember = "Id"
            Cb_Periodo.DisplayMember = "Periodo"
            Cb_Periodo.DataSource = local.Tables(0)
            Cb_Periodo.SelectedIndex = 0
        Catch ex As Exception
            conectar.Close()
        End Try
    End Sub
End Class