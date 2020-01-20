Imports System.Data.SqlClient
Public Class Fm_Relatorio_Nao_Depositaram
    Private Sub Fm_Relatorio_Nao_Depositaram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Cb_Mes.SelectedIndex = 0
        Preencher_Combo()
        Preencher_Combo_Entidade()
        Cb_Mes.Text = DateTime.Now.Month
        Cb_EntidadeMae.Text = "101111 - UCB"
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text - 1
        VPeriodo = vlAno & vlMes
        If Rb_RelatorioEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        If Rb_RelatorioGeral.Checked Then
            TipoRel = "1"
        ElseIf Rb_Demais.Checked Then
            TipoRel = "2"
        ElseIf Rb_Decimo_Terceiro.Checked Then
            TipoRel = "3"
        End If
        If Rb_FGTS.Checked Then ' Determina qual valor vai filtrar
            Tipo = "1"
            Fm_Relatorio_Nao_Depositositaram_R.Show()
        Else
            Tipo = "2"
            Fm_Relatorio_Nao_Depositositaram_R.Show()
        End If
    End Sub
    Private Sub Preencher_Combo_Entidade()
        Try
            'Busca Entidade Mae
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
    Private Sub Preencher_Combo()
        'Busca o Ano  
        conectar.Open()
        sql = "Select * from Anos ORDER BY Ano"
        adaptar = New SqlDataAdapter(sql, conectar)
        conectar.Close()
        local = New DataSet
        adaptar.Fill(local, "Anos")
        Cb_Ano.ValueMember = "Id"
        Cb_Ano.DisplayMember = "Ano"
        Cb_Ano.DataSource = local.Tables(0)
        Cb_Ano.SelectedIndex = 0
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub
End Class