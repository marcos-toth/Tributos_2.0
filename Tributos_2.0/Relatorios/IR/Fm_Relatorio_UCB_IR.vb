Imports System.Data.SqlClient
Public Class Fm_Relatorio_UCB_IR
    Private Sub Fm_Relatorio_UCB_IR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month
        vlAno = DateTime.Now.Year

        ComboData_Inicial()
        Cb_Mes.Text = vlMes
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo()
        Preencher_Combo_Entidade()
        'Cb_EntidadeMae.SelectedIndex = 0
        'Cb_Mes.Text = Date.Today.Month
        'Cb_Ano.Text = Date.Today.Year
        G_Entidade.Enabled = False
        G_Datas.Enabled = True
    End Sub

    Private Sub ComboData_Inicial()

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


    Private Sub Rb_RelatorioGeral_CheckedChanged1(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub

    Private Sub Rb_RelatorioEntidade_CheckedChanged1(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub

    Private Sub Preencher_Combo()
        Try
            sql = "Select Ano from Anos where Condicao<>"
            sql += "'" & "N" & "'"
            sql += "" & "ORDER BY Ano DESC" & ""
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


    Private Sub RB_Recolhido_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Recolhido.CheckedChanged

        G_Datas.Enabled = True
    End Sub

    Private Sub Rb_N_Recolhido_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_N_Recolhido.CheckedChanged

        vlMes = DateTime.Now.Month

        ComboData_Inicial()
        Cb_Mes.Text = vlMes
        G_Entidade.Enabled = False
        G_Datas.Enabled = True
        Rb_RelatorioGeral.Checked = True
        Rb_RelatorioEntidade.Checked = False
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
    Private Sub btnRelatorio_Click_1(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        If Rb_RelatorioEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
        ComboData()
        If Rb_RelatorioGeral.Checked = True Then
            TipoRel = "Consolidado"
        Else
            TipoRel = "Analitico"
        End If
        If RB_Recolhido.Checked = True Then
            Recolhido = "S"
        Else
            Recolhido = "N"
        End If
        Fm_Relatorio_UCB_IR_R.Show()
    End Sub
    Private Sub ComboData()

        If vlMes = "01" Then
            vlMes = "12"
            vlAno = vlAno - 1
        ElseIf vlMes = "02" Then
            vlMes = "01"
        ElseIf vlMes = "03" Then
            vlMes = "02"
        ElseIf vlMes = "04" Then
            vlMes = "03"
        ElseIf vlMes = "05" Then
            vlMes = "04"
        ElseIf vlMes = "06" Then
            vlMes = "05"
        ElseIf vlMes = "07" Then
            vlMes = "06"
        ElseIf vlMes = "08" Then
            vlMes = "07"
        ElseIf vlMes = "09" Then
            vlMes = "08"
        ElseIf vlMes = "10" Then
            vlMes = "09"
        ElseIf vlMes = "11" Then
            vlMes = "10"
        ElseIf vlMes = "12" Then
            vlMes = "11"
        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Fm_Relatorio_IR_Data_Recolhimento.Show()
    End Sub
End Class