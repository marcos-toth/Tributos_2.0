Imports System.Data.SqlClient
Public Class Fm_Relatorio_Campo_Deposito
    Private Sub Fm_Relatorio_Campo_Deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        vlMes = DateTime.Now.Month - 1
        ComboData()
        Preencher_Combo()
        Preencher_ComboAno()
        Rb_RelatorioGeral.Checked = True
        txtData.Text = Date.Today
        Cb_Mes.Text = vlMes
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
    Private Sub Preencher_Combo()
        'Busca o Nome do usuário logado  
        Try
            conectar.Open()
            sql = "Select * from Entidade where Filiais="
            sql += "'" & EntidadeLogada & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            cbo_NomeEntidade.ValueMember = "id"
            cbo_NomeEntidade.DisplayMember = "CodEntidade"
            cbo_NomeEntidade.DataSource = local.Tables(0)
            cbo_NomeEntidade.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Preencher_ComboAno()
        'Busca o Nome do usuário logado  
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
    Private Sub Rb_RelatorioEntidade_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.Click
        cbo_NomeEntidade.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeral_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.Click
        cbo_NomeEntidade.Enabled = False
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        ComboData()
            vlMesComp = vlMes
        vlPeriodoComp = vlAno & vlMes
        Entidades = cbo_NomeEntidade.Text
        If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
            TipoRel = "Consolidado"
        Else
            TipoRel = "Analitico"
        End If
        If Rb_FGTS.Checked = True Then
            Tipo = "1"
            Fm_Relatorio_Depositos_FGTS_R.Show()
        ElseIf Rb_Demais.Checked = True Then
            Tipo = "2"
            Fm_Relatorio_Depositos_Demais_R.Show()
        ElseIf RB_Decimo.Checked Then
            Tipo = "3"
            vlMesComp = "12"
            Fm_Relatorio_Deposito_Decimo_13_R.Show()
        ElseIf RB_Mes.Checked Then
            Tipo = "4"
            Fm_Relatorio_Depositos_Mensal_R.Show()
        ElseIf RB_Ano.Checked Then
            Tipo = "5"
            vlAno = Cb_Ano.Text
            Fm_Relatorio_Depositos_Geral_R.Show()
        End If
    End Sub

    Private Sub RB_Ano_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Ano.CheckedChanged
        Rb_RelatorioGeral.Checked = True
        Rb_RelatorioEntidade.Checked = False
        G_Entidade.Enabled = False
        Cb_Mes.Enabled = False
        Rb_RelatorioEntidade.Checked = True
        Rb_RelatorioGeral.Enabled = False
    End Sub

    Private Sub Rb_Demais_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Demais.CheckedChanged
        Rb_RelatorioGeral.Checked = True
        Rb_RelatorioEntidade.Checked = False
        cbo_NomeEntidade.Enabled = False
        G_Entidade.Enabled = True
        Cb_Mes.Enabled = True
        Rb_RelatorioEntidade.Checked = False
        Rb_RelatorioGeral.Enabled = True
    End Sub

    Private Sub Rb_FGTS_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_FGTS.CheckedChanged
        Rb_RelatorioGeral.Checked = True
        Rb_RelatorioEntidade.Checked = False
        cbo_NomeEntidade.Enabled = False
        G_Entidade.Enabled = True
        Cb_Mes.Enabled = True
        Rb_RelatorioEntidade.Checked = False
        Rb_RelatorioGeral.Enabled = True
    End Sub

    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub

    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub

    Private Sub RB_Decimo_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Decimo.CheckedChanged
        Cb_Mes.Text = "12"
        Cb_Mes.Enabled = False
    End Sub

    Private Sub RB_Mes_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Mes.CheckedChanged
        Cb_Mes.Enabled = True
        Rb_RelatorioEntidade.Checked = True
        Rb_RelatorioGeral.Enabled = False
    End Sub
End Class