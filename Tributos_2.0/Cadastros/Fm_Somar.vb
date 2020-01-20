
Imports System.Data.SqlClient
Public Class Fm_Somar

    Private Sub Fm_Somar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        Me.DG_Somar.Rows.Clear()
        FormataGrid()

    End Sub

    Private Sub SomaGuia()
        Try
            Dim linha As DataGridViewRow
            Dim valor As Double
            For Each linha In DG_Somar.Rows
                valor = valor + linha.Cells(0).Value
            Next
            Lbl_Total.Text = FormatCurrency(valor)
            FormataGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub FormataGrid()
        With DG_Somar
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
            .Columns(0).DefaultCellStyle.Format = "currency"
        End With

    End Sub

    Private Sub btnSomar_Click(sender As Object, e As EventArgs) Handles btnSomar.Click
        If Txt_Valor.Text <> "" Then
            Me.DG_Somar.Rows.Add(Me.Txt_Valor.Text)
            Me.Txt_Valor.Text = ""
            SomaGuia()
            Txt_Valor.Select()
        Else
            MsgBox("Favor Inserir Valor para a Soma!")
            Txt_Valor.Select()
        End If

    End Sub
    Private Sub NovaLinha()
        Try

            With DG_Somar
                .Rows.Add()
                .CurrentCell = .Rows(.Rows.Count - 1).Cells(0)
                .BeginEdit(True)
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Fm_Cadastro_Deducao_INSS.Chek_Varios.Checked = False
        Fm_Cadastro_Deducao_INSS.TxtValorCorrigido.Text = Lbl_Total.Text
        Fm_Cadastro_Deducao_INSS.TxtValorCorrigido.Select()
        Fm_Cadastro_Deducao_INSS.Soma()
        Me.Dispose()


    End Sub

    Private Sub Txt_Valor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Valor.KeyPress
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_Valor.Text = Format(Txt_Valor.Text, "currency")
            btnSomar.Select()
        End If
    End Sub
End Class