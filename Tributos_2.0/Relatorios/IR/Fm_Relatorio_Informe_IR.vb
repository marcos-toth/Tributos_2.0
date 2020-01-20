Imports System.Data.SqlClient
Public Class Fm_Relatorio_Informe_IR

    Private Sub Fm_Relatorio_Informe_IR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Preencher_ComboAno()
        Cb_Ano.Text = Date.Today.Year - 1
        Preencher_Combo()

    End Sub
    Private Sub Preencher_ComboAno()
        'Busca o Nome do usuário logado  
        Try
            sql = "Select Ano from Anos where Condicao<>"
            sql += "'" & "N" & "'ORDER BY Ano ASC"
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

    Private Sub btnRelatorio_Click(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Try
            If Rb_PF.Checked Then
                CPF_CNPJ = txt_CPF.Text
            Else
                CPF_CNPJ = Txt_CNPJ.Text
            End If
            vlAno = Cb_Ano.Text
            Entidades = cbo_NomeEntidade.Text
            'Entidades = cbo_NomeEntidade.Text
            If Rb_RelatorioAnalitico.Checked Then
                TipoRel = "1"
                Entidade()
                Fm_Relatorio_Informe_IR_R.Show()
            ElseIf Rb_RelatorioGeral.Checked Then
                TipoRel = "1"
                Entidades = cbo_NomeEntidade.Text
                Entidade()
                Fm_Relatorio_IR_R.Show()
            ElseIf Rb_DIRF.Checked Then
                Fm_Inform.Show()
                Entidades = cbo_NomeEntidade.Text
                Entidade()
                Fm_Relatorio_Informe_DIRF_R.Show()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub Rb_RelatorioGeral_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioGeral.CheckedChanged
        G_CNPJ.Visible = False
        G_CPF.Visible = False
        G_Pessoa.Enabled = False
    End Sub

    Private Sub Rb_RelatorioAnalitico_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_RelatorioAnalitico.CheckedChanged
        G_CPF.Visible = True
        G_CNPJ.Visible = False
        Rb_RelatorioAnalitico.Enabled = True
        G_Pessoa.Enabled = True
        Rb_PF.Checked = True
    End Sub
    Private Sub Rb_DIRF_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_DIRF.CheckedChanged
        G_CPF.Visible = False
        G_Entidade.Visible = True
        G_Pessoa.Enabled = False
    End Sub
    Private Sub Preencher_Combo()
        Try
            'Busca o Nome do usuário logado  
            conectar.Open()
            sql = "Select  DISTINCT EntidadeMae from Entidade where Filiais="
            sql += "'" & EntidadeLogada & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            cbo_NomeEntidade.ValueMember = "id"
            cbo_NomeEntidade.DisplayMember = "EntidadeMae"
            cbo_NomeEntidade.DataSource = local.Tables(0)
            cbo_NomeEntidade.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_CPF_Leave(sender As Object, e As EventArgs) Handles txt_CPF.Leave ' Seleciona a Entidade que pertence
        Try
            sql = "select DISTINCT EntidadeMae from IR where CPF_CNPJ="
            sql += "'" & txt_CPF.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            resultado = local.Tables("IR").Rows.Count
            If resultado > 0 Then
                registro = local.Tables("IR").Rows(0)
                Entidades = registro("EntidadeMae")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Entidade()
        Try
            sql = "select DISTINCT Razao_Social, CNPJ from Entidade where EntidadeMae="
            sql += "'" & Entidades & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            resultado = local.Tables("Entidade").Rows.Count
            If resultado > 0 Then
                registro = local.Tables("Entidade").Rows(0)
                EntidadeIR = registro("Razao_Social")
                CNPJ = registro("CNPJ")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Rb_PJ_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_PJ.CheckedChanged
        G_CNPJ.Visible = True
        G_CPF.Visible = False
    End Sub

    Private Sub Rb_PF_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_PF.CheckedChanged
        G_CNPJ.Visible = False
        G_CPF.Visible = True
    End Sub

   
End Class