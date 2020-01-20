Imports System.Data.SqlClient
Public Class Fm_Relatorio_Centralizacao_Entidade

    Private Sub Fm_Relatorio_Centralizacao_Entidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month - 1
        vlAno = DateTime.Now.Year

        ComboData()

        If vlMes = "0" Then
            Cb_Mes.Text = "12"
            Query = "ORDER BY Ano DESC"
        Else
            Cb_Mes.Text = vlMes
            Query = "ORDER BY Ano DESC"
        End If
        If Cb_Mes.Text = "0" Then
            Cb_Mes.Text = "12"
        End If
        Preencher_ComboAno()
        Preencher_Combo_Campo()
        Rb_RelatorioEntidade.Checked = True
    End Sub
    Private Sub Preencher_ComboAno()
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
            MsgBox(ex.Message)
        End Try
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
    Private Sub Preencher_Combo_Categoria()
        'Busca o Codigos das entidades 
        Try
            conectar.Open()
            sql = "Select  DISTINCT Categoria from Entidade Where Filiais="
            sql += "'" & Entidades & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            CBO_Categoria.ValueMember = "id"
            CBO_Categoria.DisplayMember = "Categoria"
            CBO_Categoria.DataSource = local.Tables(0)
            CBO_Categoria.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Preencher_Combo_Campo()
        'Busca o Codigos das entidades 
        Try
            conectar.Open()

            sql = "Select  DISTINCT Filiais from Entidade"

            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            cbo_Campo.ValueMember = "id"
            cbo_Campo.DisplayMember = "Filiais"
            cbo_Campo.DataSource = local.Tables(0)
            cbo_Campo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click


        Try
            If Cb_Mes.Text = "" Then
                MsgBox("Favor Selecionar um Período!")
            Else
                vlAno = Cb_Ano.Text
                vlMes = Cb_Mes.Text
                VPeriodo = Cb_Ano.Text & Cb_Mes.Text
                Entidades = cbo_Campo.Text
                Categoria = CBO_Categoria.Text
                Tipo = "3"
                Fm_Relatorio_Centralizacao_R.Show()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbo_Campo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_Campo.SelectedIndexChanged
        Entidades = cbo_Campo.Text
        Preencher_Combo_Categoria()
    End Sub

    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        Fm_Relatorio_Centralizacao.Show()
        Rb_RelatorioEntidade.Checked = True
        Me.Hide()
    End Sub

    
End Class