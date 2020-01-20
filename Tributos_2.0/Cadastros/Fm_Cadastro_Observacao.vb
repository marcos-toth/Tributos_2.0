Imports System.Data.SqlClient
Public Class Fm_Cadastro_Observacao

    Private Sub Fm_Cadastro_Observacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim vlDia As String
        Me.MdiParent = Fm_Principal
        txtData.Text = Date.Today
        vlDia = Date.Today.Day
        vlAno = DateTime.Now.Year
        vlMes = Date.Today.Month - 1
        Carrega_Ano()
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        lbInform.Text = ""
        Cb_Mes.Text = vlMes
        Cb_Mes.Select()

    End Sub
    Private Sub Limpar()
        TxtObs.Text = ""
        txtCodEntidade.Text = ""
        txtCodEntidade.Focus()
        LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
        lb_Aviso.Text = ""
    End Sub


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        If resultado > 0 Then
            If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                sql = "update Observacao set Observacao='" & TxtObs.Text & "' ,"
                'sql += "Data='" & txtData.Text & "' ,"
                sql += "Mes='" & Cb_Mes.Text & "', "
                sql += "Usuario='" & Usuario & "' "
                sql += " where Id='" & Id & "' "
            End If
        ElseIf resultado = 0 Then

            sql = "insert into Observacao (Data,CodEntidade,NomeEntidade,EntidadeMae,Campo,Observacao,Usuario,Ano,Mes)"
            sql += "values ('" & txtData.Text & "',"
            sql += "'" & txtCodEntidade.Text & "',"
            sql += "'" & LbNomeEntidade.Text & "',"
            sql += "'" & EntMae & "',"
            sql += "'" & Entidades & "',"
            sql += "'" & TxtObs.Text & "',"
            sql += "'" & Usuario & "',"
            sql += "'" & vlAno & "',"
            sql += "'" & vlMes & "')"

        End If
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            lbInform.Text = "Dados Gravado com Sucesso!!!"

        Catch ex As Exception
            MsgBox("Seus Dados Não Foram Gravados")
            conectar.Close()
            Exit Sub
        End Try
        conectar.Close()
        Limpar()
        Exit Sub

        lbInform.Text = "Favor Inserir Um Comentário!!"
        TxtObs.Focus()
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
            EntMae = registro("EntidadeMae")
            Entidades = registro("Filiais")
        Else
            lbInform.Text = "Favor Inserir Um Código de Entidade Válido!!"
            txtCodEntidade.Focus()
            Limpar()
            Exit Sub
        End If
        ValidaCadastro()
        lbInform.Text = ""
    End Sub

    Private Sub ValidaCadastro()

        sql = "select * from Observacao where CodEntidade="
        sql += "'" & txtCodEntidade.Text & "'and Mes="
        sql += "'" & Cb_Mes.Text & "'"
        conectar.Open()
        adaptar = New SqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "Observacao")
        resultado = local.Tables("Observacao").Rows.Count

        If resultado > 0 Then
            registro = local.Tables("Observacao").Rows(0)
            TxtObs.Text = registro("Observacao")
            Id = registro("Id")
            btnSalvar.Text = "Editar"
            btnSalvar.Enabled = True
            lb_Aviso.Text = ""
        ElseIf resultado = 0 Then
            btnSalvar.Text = "Inserir"
            lb_Aviso.Text = ""
            btnSalvar.Enabled = True
            TxtObs.Text = ""
        End If
    End Sub


    <System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Revisar as consultas SQL em busca de vulnerabilidades de segurança")> Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        conectar.Close()
        If txtCodEntidade.Text <> "" Then

            sql = "delete from Observacao where Id='" & Id & "'"
            If MsgBox("Deseja Realmente Deletar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Deletar Registro") = MsgBoxResult.Yes Then
                If resultado > 0 Then
                    conectar.Open()
                    comando = New SqlCommand(sql)
                    comando.Connection = conectar
                    comando.ExecuteNonQuery()
                    conectar.Close()
                    lbInform.Text = "Cadastro Deletado com Sucesso!!!"
                Else
                    lbInform.Text = "Não existem registros para ser Eliminados"
                    Cb_Mes.Select()
                    Exit Sub
                End If
            End If
        End If
        Limpar()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        Limpar()
    End Sub
    Private Sub Cb_Mes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Mes.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Cb_Ano.Focus()
        End If
    End Sub
    Private Sub Cb_Ano_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Cb_Ano.KeyPress
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
            TxtObs.Focus()
        End If
    End Sub
    Private Sub TxtObs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
        End If
    End Sub

    Private Sub TxtObs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtObs.TextChanged, TxtObs.TextChanged
        Dim selStart As Integer
        Dim selLength As Integer
        selStart = Me.TxtObs.SelectionStart
        selLength = Me.TxtObs.SelectionLength
        Me.TxtObs.Text = StrConv(Me.TxtObs.Text, VbStrConv.ProperCase)
        Me.TxtObs.SelectionStart = selStart
        Me.TxtObs.SelectionLength = selLength
    End Sub
    Private Sub Carrega_Ano()
        Try
            sql = "Select Ano from Anos where Condicao="
            sql += "'" & "A" & "'ORDER BY Ano DESC"
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
            conectar.Close()
        End Try
    End Sub
End Class