
Imports System.Data.SqlClient
Public Class Fm_Relatorio_Tributos
    Private Sub Fm_RelatorioFGTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Rb_RelatorioGeral.Checked = True
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
        Preencher_Combo()
            Preencher_ComboNome()
        Preencher_ComboAno()
        If vnivel = "0" Then
            Rb_Anual.Visible = True
        End If
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
    Private Sub Preencher_Combo()
        'Busca o Nome do usuário logado  
        Try
            conectar.Open()
            If vnivel = "0" Or vnivel > "4" Then
                sql = "Select  DISTINCT CodEntidade from Entidade"
            Else
                sql = "Select  DISTINCT CodEntidade from Entidade Where Filiais="
                sql += "'" & EntidadeLogada & "'"
            End If
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            CB_Codigo.ValueMember = "id"
            CB_Codigo.DisplayMember = "CodEntidade"
            CB_Codigo.DataSource = local.Tables(0)
            CB_Codigo.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Preencher_ComboNome()
        Try

            If vnivel = "0" Or vnivel > "4" Then
                conectar.Open()
                sql = "Select  DISTINCT EntidadeMae from Entidade"
                adaptar = New SqlDataAdapter(sql, conectar)
                conectar.Close()
                local = New DataSet
                adaptar.Fill(local, "Entidade")
                cbo_NomeEntidade.ValueMember = "id"
                cbo_NomeEntidade.DisplayMember = "EntidadeMae"
                cbo_NomeEntidade.DataSource = local.Tables(0)
            Else
                conectar.Open()
                sql = "Select  DISTINCT Categoria from Entidade Where Filiais= "
                sql += "'" & EntidadeLogada & "'"
                adaptar = New SqlDataAdapter(sql, conectar)
                conectar.Close()
                local = New DataSet
                adaptar.Fill(local, "Entidade")
                cbo_NomeEntidade.ValueMember = "id"
                cbo_NomeEntidade.DisplayMember = "Categoria"
                cbo_NomeEntidade.DataSource = local.Tables(0)
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
    Private Sub Rb_RelatorioEntidade_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioEntidade.Click
        cbo_NomeEntidade.Enabled = True
        Chec_Codigo.Enabled = True
    End Sub

    Private Sub Rb_RelatorioGeral_Click(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.Click
        cbo_NomeEntidade.Visible = True
        cbo_NomeEntidade.Enabled = False
        CB_Codigo.Visible = False
        Chec_Codigo.Visible = True
        Chec_Codigo.Enabled = False
        Chec_Codigo.Checked = False

    End Sub
    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click

        Try
            If Cb_Mes.Text = "" Then
                MsgBox("Favor Selecionar um Período!")
            Else
                vlAno = Cb_Ano.Text
                vlMes = Cb_Mes.Text
                VPeriodo = Cb_Ano.Text & Cb_Mes.Text
                Entidades = cbo_NomeEntidade.Text

                If Rb_RelatorioGeral.Checked Then ' Determina qual valor vai filtrar
                    Tipo = "1"
                ElseIf Rb_RelatorioEntidade.Checked Then
                    Tipo = "2"
                End If
                If Chec_Codigo.Checked Then
                    Tipo = "3"
                    Entidades = CB_Codigo.Text
                End If
                If Rb_Anual.Checked = True Then
                    Fm_Relatorio_Tributos_Anual_R.Show()
                    Exit Sub
                End If
                If Rb_FGTS.Checked = True Then
                    Fm_Relatorio_Tributos_FGTS_R.Show()
                ElseIf Rb_Demais.Checked = True Then
                    Fm_Relatorio_Tributos_Demais_R.Show()
                ElseIf RB_Todos.Checked = True Then
                    Fm_Relatorio_Tributos_Geral_R.Show()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub CB_Consolidar_CheckedChanged(sender As Object, e As EventArgs)
        Preencher_Combo()
        Chec_Codigo.Visible = False
        CB_Codigo.Visible = True
        CB_Codigo.Enabled = True
        cbo_NomeEntidade.Visible = False
    End Sub


    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        cbo_NomeEntidade.Visible = True
        cbo_NomeEntidade.Enabled = False
        CB_Codigo.Visible = False
        Chec_Codigo.Enabled = True
        Chec_Codigo.Enabled = False
        Chec_Codigo.Checked = False
        Consolidado = "N"
    End Sub

    Private Sub Chec_Codigo_CheckedChanged(sender As Object, e As EventArgs) Handles Chec_Codigo.CheckedChanged
        Preencher_Combo()
        Chec_Codigo.Enabled = False
        CB_Codigo.Visible = True
        CB_Codigo.Enabled = True
        cbo_NomeEntidade.Visible = False
    End Sub
End Class