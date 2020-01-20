Imports System.Data.SqlClient
Public Class Fm_Trocar_Entidade_Logada

    Private Sub Fm_Trocar_Entidade_Logada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        Preencher_Combo()
        CB_Codigo.Text = EntidadeLogada
        CB_Tipo.Text = vnivel

    End Sub
    Private Sub Preencher_Combo()
        'Busca o Nome do usuário logado  
        Try
            conectar.Open()
            sql = "Select  DISTINCT Filiais from Entidade"

            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            CB_Codigo.ValueMember = "id"
            CB_Codigo.DisplayMember = "Filiais"
            CB_Codigo.DataSource = local.Tables(0)
            ' CB_Codigo.SelectedIndex = -1
            'CB_Codigo.Text = "101111"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        EntidadeLogada = CB_Codigo.Text
        vnivel = CB_Tipo.Text
        Fm_Principal.StatusBar1.Panels(4).Text = "Entidade Logada: " & EntidadeLogada
        Me.Close()

    End Sub

End Class