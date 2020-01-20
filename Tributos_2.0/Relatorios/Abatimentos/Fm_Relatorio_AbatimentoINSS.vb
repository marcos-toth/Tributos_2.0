Imports System.Data.SqlClient

Public Class Fm_relatorio_AbatimentoINSS

    Private Sub Fm_relatorio_AimentoINSS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_ComboAno()
        Rb_RelatorioGeral.Checked = True
        Preencher_Combo()
        vlMes = Date.Today.Month - 1 '(txtData.Text) - 1
        ComboData()
        Cb_Mes.Text = vlMes
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
            vlAno = Cb_Ano.Text
            vlMes = Cb_Mes.Text
            VPeriodo = Cb_Ano.Text & Cb_Mes.Text

            If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
                Tipo = "1"
            Else
                Tipo = "2"
                Entidades = Cb_EntidadeMae.Text
            End If
            Fm_relatorio_AbatimentoINSS_R.Show()
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
End Class