Imports System.Data.SqlClient
Public Class Fm_Configuracao_Fecha_Periodo

    Private Sub Fm_Configuracao_Fecha_Periodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        IDMAx()
        Carregar_DG_F()
        Carregar_DG_A()
        Periodo()
        Periodo2()
    End Sub
    Private Sub IDMAx()
        Try
            sql = "Select Min(Id) MinID from IR "
            sql += "Where Contabilizado='" & "N" & "'"
            sql += " and Mes<='" & vlMes & "' "
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "IR")
            resultado = local.Tables("IR").Rows.Count
            registro = local.Tables("IR").Rows(0)
            Id = local.Tables(0).Rows(0)("MinId")
            Id = Id - 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Carregar_DG_F()
        Try
            conectar.Open()
            sql = "select Periodo from periodo where Condicao="
            sql += "'" & "F" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            DG_PeriodoF.DataSource = local.Tables(0)

        Catch ex As Exception
        End Try
    End Sub
    Private Sub Carregar_DG_A()
        Try
            conectar.Open()
            sql = "select Periodo from periodo where Condicao="
            sql += "'" & "A" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            conta_Mes_Aberto = local.Tables("Periodo").Rows.Count
            DG_PeriodoA.DataSource = local.Tables(0)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Periodo()
        Try
            sql = "Select Min(Periodo) MinPeriodo from Periodo where Condicao="
            sql += "'" & "A" & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            resultado = local.Tables("Periodo").Rows.Count
            registro = local.Tables("Periodo").Rows(0)
            VPeriodo = local.Tables(0).Rows(0)("MinPeriodo")
        Catch ex As Exception
            conectar.Close()
        End Try
    End Sub
    Private Sub Periodo2()
        Try
            sql = "Select Max(Periodo) MaxPeriodo from Periodo where Condicao="
            sql += "'" & "F" & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            resultado = local.Tables("Periodo").Rows.Count
            registro = local.Tables("Periodo").Rows(0)
            VPeriodo2 = local.Tables(0).Rows(0)("MaxPeriodo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DG_PeriodoA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PeriodoA.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DG_PeriodoA.Rows(index)
        Txt_Periodo.Text = selectedrow.Cells(0).Value.ToString()
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

                vlAno = Microsoft.VisualBasic.Left(Txt_Periodo.Text, 4)
                vlMes = Microsoft.VisualBasic.Right(Txt_Periodo.Text, 2)
                If Txt_Periodo.Text <> "" Then

                    If conta_Mes_Aberto < "3" Then
                        If Txt_Periodo.Text = VPeriodo Then
                            sql = "update Periodo set Condicao='" & "F" & "' "
                            sql += " where Periodo='" & Txt_Periodo.Text & "' "
                            Conectar_Banco()
                            'sql = "update tributos set Recolhido='" & "S" & "' "
                            'sql += " where Periodo='" & Txt_Periodo.Text & "' "
                            'Conectar_Banco()
                            'sql = "update COFINS set Contabilizado='" & "S" & "' "
                            'sql += "Where Mes<='" & vlMes & "'"
                            'sql += "and Ano='" & vlAno & "'"
                            ''Conectar_Banco()
                            sql = "update IR set Fechado='" & "S" & "',"
                            sql += "DataFechamento='" & Date.Today & "'"
                            sql += "Where Id>'" & Id & "'"
                            sql += " And Mes<='" & vlMes & "'"
                            sql += " And Ano='" & vlAno & "'"
                            sql += " And Contabilizado='" & "N" & "'"
                            Conectar_Banco()
                            Carregar_DG_F()
                            Carregar_DG_A()
                            Btn_Fecha_Mes.Enabled = False
                            MsgBox("O Período Foi Fechado Com Sucesso!", vbInformation, "Encerrar Período")
                        Else
                            MsgBox("Já Existe Dois Periodos em Aberto!", vbExclamation, "Encerrar Período")
                        End If
                    Else
                        MsgBox("Você Está Fechando Um Periodo Fora da Sequencia!", vbExclamation, "Encerrar Período")
                    End If
                Else
                    MsgBox("Por Favor Clica em um Período para Fechar!", vbExclamation, "Encerrar Período")
                End If
                Periodo()
                Periodo2()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class