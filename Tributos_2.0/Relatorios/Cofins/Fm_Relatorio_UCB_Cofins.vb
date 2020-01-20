Imports System.Data.SqlClient
Public Class Fm_Relatorio_UCB_Cofins
    Private Sub Fm_Relatorio_COFINS_UCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Me.MdiParent = Fm_Principal
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        vlAno = DateTime.Now.Year
        ComboMes()
        
        Cb_Mes.SelectedIndex = 0
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo()
        txtData.Text = Date.Today
        Cb_Mes.Text = vlMes
        Preencher_Combo_Entidade()
    End Sub
    Private Sub ComboMes()
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
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text

        If Rb_RelatorioEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        If RB_Recolhido.Checked = True Then
            Contabilizado = "S"
        Else
            Contabilizado = "N"
        End If
        If Rb_RelatorioGeral.Checked = True Then
            TipoRel = "Consolidado"
        Else
            TipoRel = "Analitico"
        End If
        Fm_Relatorio_UCB_Cofins_R.Show()
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub
    Private Sub Preencher_Combo()
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
            sql = "Select  DISTINCT CodEntidade from Entidade Where Cofins="
            sql += "'" & "S" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cb_EntidadeMae.ValueMember = "id"
            Cb_EntidadeMae.DisplayMember = "CodEntidade"
            Cb_EntidadeMae.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class