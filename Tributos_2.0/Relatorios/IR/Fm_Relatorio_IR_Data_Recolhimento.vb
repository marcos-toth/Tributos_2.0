Imports System.Data.SqlClient
Public Class Fm_Relatorio_IR_Data_Recolhimento

    Private Sub Fm_Relatorio_IR_Data_Recolhimento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_Data()


    End Sub
    Private Sub Preencher_Data()
        Try
            'Busca o Nome do usuário logado  

            sql = "Select  DISTINCT DataFechamento from ir order by DataFechamento"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            Cbo_Data.ValueMember = "id"
            Cbo_Data.DisplayMember = "DataFechamento"
            Cbo_Data.DataSource = local.Tables(0)
            Cbo_Data.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Entidade()
        Try
            sql = "select DISTINCT EntidadeMae from Entidade order by EntidadeMae"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            cbo_Entidade.ValueMember = "id"
            cbo_Entidade.DisplayMember = "EntidadeMae"
            cbo_Entidade.DataSource = local.Tables(0)
            cbo_Entidade.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_CodEntidade()
        Try
            sql = "select DISTINCT CodEntidade from Entidade order by CodEntidade"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            cbo_Entidade.ValueMember = "id"
            cbo_Entidade.DisplayMember = "CodEntidade"
            cbo_Entidade.DataSource = local.Tables(0)
            cbo_Entidade.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        Preencher_Entidade()
        btnRelatorio.Enabled = True
    End Sub

    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Codigo.CheckedChanged
        Preencher_CodEntidade()
        btnRelatorio.Enabled = True
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        If Rb_Codigo.Checked Then
            TipoRel = "Codigo"
            Cod_Entidade = cbo_Entidade.Text
        Else
            TipoRel = "Entidade"
            EntidadeMae = cbo_Entidade.Text
        End If
        VlData = Cbo_Data.Text

        Fm_Relatorio_IR_Data_Recolhimento_R.Show()
    End Sub
End Class