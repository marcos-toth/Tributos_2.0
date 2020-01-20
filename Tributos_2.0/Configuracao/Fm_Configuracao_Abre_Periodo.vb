Imports System.Data.SqlClient
Public Class Fm_Configuracao_Abre_Periodo
    Private Sub Fm_Configuracao_Abre_Periodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.MdiParent = Fm_Principal
            conectar = New SqlConnection
            conectar.ConnectionString = cnn
            Carregar_DG()
            Carregar_DG_A()
            Periodo()
            Periodo2()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Carregar_DG()
        Try
            conectar.Open()
            sql = "select Periodo from periodo where Condicao="
            sql += "'" & "N" & "'"
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            DG_PeriodoF.DataSource = Local.tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
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
            DG_PeriodoA.DataSource = local.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Periodo()
        Try
            sql = "Select Periodo from Periodo where Condicao="
            sql += "'" & "N" & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            resultado = local.Tables("Periodo").Rows.Count
            registro = local.Tables("Periodo").Rows(0)
            'VPeriodo = local.Tables(0).Rows(0)("MinPeriodo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Periodo2()
        Try
            sql = "Select Min(Periodo) MinPeriodo from Periodo where Condicao="
            sql += "'" & "A" & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Periodo")
            resultado2 = local.Tables("Periodo").Rows.Count
            registro = local.Tables("Periodo").Rows(0)
            'VPeriodo2 = local.Tables(0).Rows(0)("MinPeriodo")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Btn_Abrir_Mes_Click(sender As Object, e As EventArgs) Handles Btn_Abrir_Mes.Click

        Try
            vlAno = Microsoft.VisualBasic.Left(Txt_Periodo.Text, 4)
            vlMes = Microsoft.VisualBasic.Right(Txt_Periodo.Text, 2)
            VPeriodo2 = vlAno & vlMes
            If Txt_Periodo.Text <> "" Then

                If resultado2 < "2" Then
                    If Txt_Periodo.Text = VPeriodo2 Then
                        sql = "update Periodo set Condicao='" & "A" & "' "
                        sql += " where Periodo='" & Txt_Periodo.Text & "' "
                        Conectar_Banco()
                        sql = "update Entidade set Periodo='" & Txt_Periodo.Text & "' "
                        Conectar_Banco()
                        sql = "update tributos set INSS_Arredondamento='" & "0" & "' "
                        sql += " where Periodo='" & Txt_Periodo.Text & "' "
                        Conectar_Banco()
                        Carregar_DG()
                        Carregar_DG_A()
                        Gera_Cabecalho()
                        Periodo()
                        Periodo2()
                        If vlMes = "12" Then
                            Gera_Cabecalho_Decimo_Terceiro()
                        End If
                        Btn_Abrir_Mes.Enabled = False
                        MsgBox("O Período Foi Aberto Com Sucesso!", vbInformation, "Abri Período")
                    Else
                        MsgBox("Já Existe Dois Periodos em Aberto!", vbExclamation, "Abri Período")
                    End If
                Else
                    MsgBox("Você Está Abrindo Um Periodo Fora da Sequencia!", vbExclamation, "Abri Período")
                End If
            Else
                MsgBox("Por Favor Clica em um Período para Abrir!", vbExclamation, "Abri Período")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DG_PeriodoF_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PeriodoF.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DG_PeriodoF.Rows(index)
        Txt_Periodo.Text = selectedrow.Cells(0).Value.ToString()
        Btn_Abrir_Mes.Enabled = True
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
            Conectar.Close()
            Exit Sub
        End Try
    End Sub
    Private Sub Gera_Cabecalho()
        command.Connection = conectar
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "Insere_Tributos"
        comando.CommandTimeout = 360
        conectar.Open()
        command.ExecuteNonQuery()
        conectar.Close()
        MsgBox("Períodos Criados Com Sucesso!", vbInformation, "Tributos")
    End Sub
    Private Sub Gera_Cabecalho_Decimo_Terceiro()
        command.Connection = conectar
        command.CommandType = CommandType.StoredProcedure
        command.CommandText = "Insere_Decimo_Terceiro"
        comando.CommandTimeout = 360
        conectar.Open()
        command.ExecuteNonQuery()
        conectar.Close()
        MsgBox("Períodos Décimo Terceiro Criados Com Sucesso!", vbInformation, "Tributos")
    End Sub
End Class