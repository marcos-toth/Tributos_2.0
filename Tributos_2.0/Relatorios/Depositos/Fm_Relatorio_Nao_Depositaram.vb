Imports System.Data.SqlClient
Public Class Fm_Relatorio_Nao_Depositaram
    Private Sub Fm_Relatorio_Nao_Depositaram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        vlDia = DateTime.Now.Day
        vlMes = DateTime.Now.Month
        vlAno = DateTime.Now.Year
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
        If vlMes = "0" Then
            Cb_Mes.Text = "12"
            Query = "ORDER BY Ano DESC"
        Else
            Cb_Mes.Text = vlMes
            Query = "ORDER BY Ano DESC"
        End If
        Preencher_Combo()
        Preencher_Combo_Entidade()
        Cb_Mes.Text = DateTime.Now.Month

    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        vlAno = Cb_Ano.Text
        vlMes = Cb_Mes.Text - 1
        If vlMes = "0" Then
            vlMes = "12"
            vlAno = vlAno - 1
        ElseIf vlMes = "1" Then
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
        ElseIf vlMes = "10" Then
            vlMes = "10"
        ElseIf vlMes = "11" Then
            vlMes = "11"
        ElseIf vlMes = "12" Then
            vlMes = "12"
        End If

        VPeriodo = vlAno & vlMes

        If Rb_RelatorioEntidade.Checked = True Then
            Entidades = Cb_EntidadeMae.Text
        End If
        If Rb_RelatorioGeral.Checked Then
            TipoRel = "1"
        Else
            TipoRel = "2"
        End If
        If Rb_FGTS.Checked Then
            Tipo = "1"
            TipoTributos = "FGTS"
        ElseIf Rb_Demais.Checked Then
            Tipo = "2"
            TipoTributos = "Demais Tributos"
        ElseIf RB_Decimo_Terceiro.Checked Then
            Tipo = "3"
            TipoTributos = "13º Salário"
            vlMesComp = "12"
        End If
        Fm_Relatorio_Nao_Depositositaram_R.Show()

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
        Try
            sql = "Select Ano from Anos where Condicao="
            sql += "'" & "A" & "'"
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

        End Try
    End Sub
    Private Sub Rb_RelatorioEntidade_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.CheckedChanged
        G_Entidade.Enabled = True
    End Sub
    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_Entidade.Enabled = False
    End Sub
End Class