Imports System.Data.SqlClient
Public Class Fm_Relatorio_Funcoes

    Private Sub Fm_Relatorio_Funcoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        Preencher_Combo_Campo()
        Preencher_Combo_Entidade()
        Preencher_Combo_Funcao()
    End Sub
    Private Sub Preencher_Combo_Funcao()
        Try
            conectar.Open()
            sql = "Select  DISTINCT Funcao from Funcao"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Funcao")
            cbo_Funcao.ValueMember = "id"
            cbo_Funcao.DisplayMember = "Funcao"
            cbo_Funcao.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Combo_Campo()
        Try
            conectar.Open()
            sql = "Select  DISTINCT Campo from Funcao"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Funcao")
            CBO_Campo.ValueMember = "id"
            CBO_Campo.DisplayMember = "Campo"
            CBO_Campo.DataSource = local.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_Combo_Entidade()
        Try
            conectar.Open()
            sql = "Select  DISTINCT Categoria from Funcao"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Funcao")
            CBO_Entidade.ValueMember = "id"
            CBO_Entidade.DisplayMember = "Categoria"
            CBO_Entidade.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        CBO_Entidade.Enabled = True
        CBO_Campo.Enabled = False
        cbo_Funcao.Enabled = False
        G_Campo.Enabled = True

    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        CBO_Campo.Enabled = False
        cbo_Funcao.Enabled = False
        CBO_Entidade.Enabled = False
    End Sub
    Private Sub R_Funcao_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Funcao.CheckedChanged
        CBO_Campo.Enabled = False
        cbo_Funcao.Enabled = True
        CBO_Entidade.Enabled = False
    End Sub
    Private Sub R_Campo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Campo.CheckedChanged
        CBO_Campo.Enabled = True
        cbo_Funcao.Enabled = False
        G_Campo.Enabled = False
    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        If Rb_RelatorioGeral.Checked Then
            Tipo = "1"
        ElseIf Rb_RelatorioEntidade.Checked Then
            Entidades = CBO_Entidade.Text
            Tipo = "2"
        ElseIf Rb_Funcao.Checked Then
            Entidades = cbo_Funcao.Text
            Tipo = "3"
        ElseIf Rb_Campo.Checked Then
            Entidades = CBO_Campo.Text
            Tipo = "4"
        End If
        Fm_Relatorio_Funcoes_R.Show()
    End Sub

End Class