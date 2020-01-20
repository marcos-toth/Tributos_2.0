Imports System.Data.SqlClient
Public Class Fm_Relatorio_Observacao

    Private Sub Fm_Observacao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_ComboAno()
        Preencher_Combo_Entidade()
        Rb_RelatorioGeral.Checked = True
        Cb_Mes.Text = Month(Date.Today) - 1
    End Sub
    Private Sub Preencher_ComboAno()
        'Busca o Nome do usuário logado  
        Try
            sql = "Select Ano from Anos where Condicao<>"
            sql += "'" & "N" & "'ORDER BY Ano DESC"
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
            sql = "Select  DISTINCT EntidadeMae from Entidade where Filiais="
            sql += "'" & EntidadeLogada & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            cbo_NomeEntidade.ValueMember = "id"
            cbo_NomeEntidade.DisplayMember = "EntidadeMae"
            cbo_NomeEntidade.DataSource = local.Tables(0)
            cbo_NomeEntidade.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Rb_RelatorioGeral_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.Click
        cbo_NomeEntidade.Visible = True
        cbo_NomeEntidade.Enabled = False
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text
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
        VPeriodo = vlAno & vlMes
        If Rb_Mes.Checked Then
            TipoRel = "Mes"
        Else
            VPeriodo = vlAno & "AA"
        End If

        If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
            Tipo = "1"
        Else
            Tipo = "2"
            Entidades = cbo_NomeEntidade.Text
        End If
        Fm_Relatorio_Observacao_R.Show()

    End Sub

    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        cbo_NomeEntidade.Enabled = True
    End Sub

    Private Sub RB_Ano_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Ano.CheckedChanged
        Cb_Mes.Enabled = False
    End Sub

    Private Sub Rb_Mes_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Mes.CheckedChanged
        Cb_Mes.Enabled = True
    End Sub
End Class