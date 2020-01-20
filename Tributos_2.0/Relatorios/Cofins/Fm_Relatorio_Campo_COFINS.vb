Imports System.Data.SqlClient
Public Class Fm_Relatorio_Campo_COFINS
    Private Sub Fm_Relatorio_Campo_COFINS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Conectar ao banco
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        'Cb_Entidade.SelectedIndex = 0
        Cb_Mes.SelectedIndex = 0
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo_Ano()
        Preencher_Combo_Entidade()
        Me.MdiParent = Fm_Principal
        txtData.Text = Date.Today
        Cb_Mes.Text = Month(txtData.Text) - 1
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click

        If Rb_RelatorioGeral.Checked = True Then
            TipoRel = "Consolidado"
        Else
            TipoRel = "Analitico"
        End If
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        Entidades = Cb_Entidade.Text
        Fm_Relatorio_Campo_COFINS_R.Show()
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub

    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub
    Private Sub Preencher_Combo_Ano()
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

        End Try
    End Sub
    Private Sub Preencher_Combo_Entidade()
        Try
            conectar.Open()
            sql = "Select  DISTINCT CodEntidade from Entidade Where Filiais="
            sql += "'" & EntidadeLogada & "' and Cofins="
            sql += "'" & "S" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cb_Entidade.ValueMember = "id"
            Cb_Entidade.DisplayMember = "CodEntidade"
            Cb_Entidade.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class