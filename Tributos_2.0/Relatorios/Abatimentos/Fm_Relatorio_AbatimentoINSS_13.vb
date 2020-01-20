Imports System.Data.SqlClient
Public Class Fm_relatorio_AbatimentoINSS_13

    Private Sub Fm_relatorio_AbatimentoINSS_13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_ComboAno()
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo()
    End Sub
    Private Sub Preencher_ComboAno()
        'Busca o Nome do usuário logado  
        Try
            conectar.Open()
            sql = "Select distinct Periodo from Decimo_Terceiro where Recolhido="
            sql += "'" & "N" & "'"
            sql += "ORDER BY Ano DESC"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Decimo_Terceiro")
            Cb_Ano.ValueMember = "Id"
            Cb_Ano.DisplayMember = "Periodo"
            Cb_Ano.DataSource = local.Tables(0)
            Cb_Ano.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Rb_RelatorioEntidade_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.Click
        G_Entidade.Enabled = True

    End Sub

    Private Sub Rb_RelatorioGeral_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.Click
        G_Entidade.Enabled = False
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Try
            VPeriodo = Cb_Ano.Text 
            If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
                Tipo = "1"
            Else
                Tipo = "2"
                Entidades = Cb_EntidadeMae.Text
            End If
            Fm_relatorio_AbatimentoINSS_13_R.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Combo()
        'Busca o Nome do usuário logado  
        Try
            conectar.Open()
            sql = "Select  DISTINCT EntidadeMae from Entidade"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            Cb_EntidadeMae.ValueMember = "id"
            Cb_EntidadeMae.DisplayMember = "EntidadeMae"
            Cb_EntidadeMae.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class