Imports System.Data.SqlClient
Public Class Fm_Relatório_Usuario
    Private Sub Fm_Relatório_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_Combo_Entidade()
        Rb_RelatorioGeral.Checked = True
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
            Tipo = "1"
        Else
            Tipo = "2"
            Entidades = cbo_NomeEntidade.Text
        End If
        Fm_Relatório_Usuario_R.Show()
    End Sub

    Private Sub Preencher_Combo_Entidade()
        Try
            'Busca o Nome do usuário logado  
            conectar.Open()
            sql = "Select  DISTINCT Filiais from Entidade"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            cbo_NomeEntidade.ValueMember = "id"
            cbo_NomeEntidade.DisplayMember = "Filiais"
            cbo_NomeEntidade.DataSource = local.Tables(0)
            cbo_NomeEntidade.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class