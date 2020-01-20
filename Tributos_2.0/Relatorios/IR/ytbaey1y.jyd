Imports System.Data.SqlClient

Public Class Fm_Relatorio_Campo_IR
    Private Sub Fm_Relatorio_IR_UCB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        'Conectar ao banco
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        vlAno = DateTime.Now.Year
        ComboData()
        If vlMes = "0" Then
            Cb_Mes.Text = "12"
            Query = "ORDER BY Ano"
        Else
            Cb_Mes.Text = DateTime.Now.Month - 1
            Query = "ORDER BY Ano DESC"
        End If
        Cb_Mes.Text = vlMes
        Cb_Mes.SelectedIndex = 0
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo_Ano()
        Preencher_Combo_Entidade()
        Cb_EntidadeMae.SelectedIndex = 0
        txtData.Text = Date.Today
        Cb_Mes.Text = Month(txtData.Text) - 1
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
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        If Rb_RelatorioGeralAnualEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        If Rb_RelatorioGeral.Checked = True Then
            TipoRel = "1"
        ElseIf Rb_RelatorioGeralAnualEntidade.Checked = True Then
            TipoRel = "2"
        ElseIf Rb_RelatorioGeralMensal.Checked = True Then
            TipoRel = "3"
        ElseIf Rb_RelatorioGeralMensalEntidade.Checked = True Then
            TipoRel = "4"
        End If
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        Entidades = Cb_EntidadeMae.Text
        Fm_Relatorio_IR_R.Show()
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeralAnualEntidade.CheckedChanged
        G_Entidade.Enabled = True
        Cb_Mes.Enabled = False
    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
        Cb_Mes.Enabled = False
    End Sub
    Private Sub Rb_RelatorioGeralMensalEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeralMensalEntidade.CheckedChanged
        G_Entidade.Enabled = True
        Cb_Mes.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeralMensal_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeralMensal.CheckedChanged
        G_Entidade.Enabled = False
        Cb_Mes.Enabled = True
    End Sub
    Private Sub Preencher_Combo_Ano()
        Try
            sql = "Select Ano from Anos where Condicao<>"
            sql += "'" & "N" & "'"
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
    Private Sub Preencher_Combo_Entidade()
        Try
            'Busca o Nome do usuário logado  
            conectar.Open()
            sql = "Select  DISTINCT EntidadeMae from Entidade"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cb_EntidadeMae.ValueMember = "id"
            Cb_EntidadeMae.DisplayMember = "EntidadeMae"
            Cb_EntidadeMae.DataSource = local.Tables(0)
            Cb_EntidadeMae.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
End Class