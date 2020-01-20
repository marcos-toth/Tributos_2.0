Imports System.Data.SqlClient
Public Class Fm_Configuracao_Fecha_Ano

    Private Sub Fm_Configuracao_Fecha_Ano_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn

        Carregar_DG_F()
        Carregar_DG_A()

    End Sub
    Private Sub Carregar_DG_F()
        Try
            conectar.Open()
            sql = "select Ano from Anos where Condicao="
            sql += "'" & "E" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Ano")
            DG_PeriodoF.DataSource = local.Tables(0)

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Carregar_DG_A()
        Try
            conectar.Open()
            sql = "select Ano from Anos where Condicao="
            sql += "'" & "A" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Ano")
            DG_PeriodoA.DataSource = local.Tables(0)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DG_PeriodoA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PeriodoA.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DG_PeriodoA.Rows(index)
        Txt_Periodo.Text = Microsoft.VisualBasic.Left(selectedrow.Cells(0).Value.ToString(), 4)

        Btn_Fecha_Mes.Enabled = True
    End Sub
    Public Sub Conectar_Banco()
        Try
            conectar.Open()
            comando = New SqlCommand(sql)
            comando.Connection = conectar
            comando.ExecuteNonQuery()
            conectar.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Conectar.Close()
            Exit Sub
        End Try
    End Sub

    Private Sub Btn_Fecha_Mes_Click(sender As Object, e As EventArgs) Handles Btn_Fecha_Mes.Click

        Try
            If MsgBox("Deseja Realmente Fechar Esse Período?", MsgBoxStyle.YesNo + vbCritical, "Alterar Registro") = MsgBoxResult.Yes Then
                VPeriodo2 = VPeriodo2 + 1
                vlAno = Microsoft.VisualBasic.Left(Txt_Periodo.Text, 4)
                vlMes = Microsoft.VisualBasic.Right(Txt_Periodo.Text, 2)
                If Txt_Periodo.Text <> "" Then

                    If Txt_Periodo.Text = vlAno Then

                        sql = "update Periodo set Condicao='" & "E" & "' "
                        sql += " where condicao='" & "F" & "' "
                        Conectar_Banco()
                        sql = "update Anos set Condicao='" & "E" & "' "
                        sql += " where Ano='" & vlAno & "' "
                        Conectar_Banco()
                        Carregar_DG_F()
                        Carregar_DG_A()
                        Btn_Fecha_Mes.Enabled = False
                        MsgBox("O Período Foi Fechado Com Sucesso!", vbInformation, "Abrir Período")
                    
                Else
                    MsgBox("Você Está Fechando Um Periodo Fora da Sequencia!", vbExclamation, "Abrir Período")
                End If
                Else
                    MsgBox("Por Favor Clica em um Período para Fechar!", vbExclamation, "Abrir Período")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class