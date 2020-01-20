Imports System.Data.SqlClient
Public Class Fm_Relatorio_UCB_Depositos
    Private Sub Fm_Relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Cb_Mes.SelectedIndex = 0
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo()
        Preencher_ComboAno()
        txtData.Text = Date.Today

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
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text - 1
        ComboData()
        If vlMes = "0" Then
            vlMesComp = "12"
            vlPeriodoComp = vlAno - 1 & "12"
        Else
            vlPeriodoComp = vlAno & vlMes
        End If
        If Rb_RelatorioEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        If Rb_FGTS.Checked Then ' Determina qual valor vai filtrar
            Tipo = "1"
        ElseIf Rb_Demais.Checked Then
            Tipo = "2"
        ElseIf RB_Decimo_Terceiro.Checked Then
            Tipo = "3"
            vlMesComp = "12"
        End If
        If Rb_RelatorioGeral.Checked = True Then
            TipoRel = "Consolidado"
        Else
            TipoRel = "Analitico"
        End If
        
        If Rb_FGTS.Checked = True Then
            Fm_Relatorio_Depositos_FGTS_R.Show() 'OK
        ElseIf Rb_Demais.Checked = True Then
            Fm_Relatorio_Depositos_Demais_R.Show() ' Ok
        ElseIf Rb_Geral.Checked = True Then
            Fm_Relatorio_Depositos_Geral_R.Show() 'OK
        ElseIf RB_Decimo_Terceiro.Checked Then
            Fm_Relatorio_Deposito_Decimo_13_R.Show()
        End If
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub
    Private Sub Preencher_Combo()
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
    Private Sub Preencher_ComboAno()
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
            MsgBox(ex.Message)
        End Try
    End Sub

End Class