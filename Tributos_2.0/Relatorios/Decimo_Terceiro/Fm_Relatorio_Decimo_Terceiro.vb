Imports System.Data.SqlClient
Public Class Fm_Relatorio_Decimo_Terceiro

    Private Sub Fm_Relatorio_Decimo_Terceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Rb_RelatorioGeral.Checked = True
        'Cb_Mes.Text = Month(Date.Today) - 1
        Preencher_Combo()
        Preencher_ComboNome()
        Preencher_ComboAno()
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
            sql = "Select DISTINCT Periodo from Decimo_Terceiro"
            conectar.Open()
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
        VPeriodo = Cb_Ano.Text
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
        Fm_Relatorio_Decimo_Terceiro_R.Show()

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