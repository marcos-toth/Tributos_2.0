Imports System.Data.SqlClient
Public Class Fm_Cad_Data_Deposito
    Private Sub Fm_Cad_Data_Deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        DataGrid()
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If MsgBox("Deseja Realmente Alterar Esse Cadastro!!", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                sql = "update Data_Deposito set FGTS='" & Txt_Data_Primeiro.Text & "' ,"
                sql += "Demais_Tributos='" & Txt_Data_Segundo.Text & "' "
                sql += " where Id='" & Id & "' "
                Conectar_Banco()
                lbInform.Text = "Dados Gravado com Sucesso!!!"
                DataGrid()
            End If

        Catch ex As Exception

        End Try
    End Sub


    Private Sub DG_Depositos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Depositos.CellContentClick
        Try
            Txt_Data_Primeiro.Enabled = True
            Txt_Data_Segundo.Enabled = True
            btnSalvar.Enabled = True
            resultado = "1"
            Dim index As Integer
            index = e.RowIndex
            Dim selectedrow As DataGridViewRow
            selectedrow = DG_Depositos.Rows(index)

            Id = selectedrow.Cells(0).Value.ToString()
            'Cb_Mes.Text = selectedrow.Cells(1).Value.ToString()
            Txt_Data_Primeiro.Text = selectedrow.Cells(2).Value.ToString()
            Txt_Data_Segundo.Text = selectedrow.Cells(3).Value.ToString()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Conectar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conectar.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub DataGrid()

        Try
            DG_Depositos.Rows.Clear()
            conectar.Open()
            sql = "Select id, Mes, FGTS, Demais_Tributos From Data_Deposito order by Mes"
           
            comando = New SqlCommand(sql, conectar)
            Dim dr As SqlDataReader = comando.ExecuteReader
            Do While dr.Read
                DG_Depositos.Rows.Add(dr("Id"), dr("Mes"), dr("FGTS"), dr("Demais_Tributos"))
            Loop
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class