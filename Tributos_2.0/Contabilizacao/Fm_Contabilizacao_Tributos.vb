Imports System.Data.SqlClient
Public Class Fm_Contabilizacao_Tributos
    Private Sub Fm_Contabilizacao_Tributos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        Carregar_DG_A()
        Verificar()
        LB_Inform.Text = ""
    End Sub
    Private Sub DG_PeriodoA_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PeriodoA.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedrow As DataGridViewRow
        selectedrow = DG_PeriodoA.Rows(index)
        Txt_Periodo.Text = selectedrow.Cells(0).Value.ToString()
        BTN_Calcular.Enabled = True
        LB_Inform.Text = ""
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
        End Try
    End Sub
    Private Sub BTN_Calcular_Click(sender As Object, e As EventArgs) Handles BTN_Calcular.Click
        Try
            VPeriodo = Txt_Periodo.Text
            vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
            vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
            Tipo = "1"
            If MsgBox("Deseja Realmente Calcular Esse Período!", MsgBoxStyle.YesNo + vbCritical, "Calcular Período") = MsgBoxResult.Yes Then
                TipoRel = "Consolidado"
                If VPeriodo2 = Txt_Periodo.Text Then
                    Tipo = "1"
                    UPDATE_Tributos()
                Else
                    sql = "update Entidade set Periodo='" & Txt_Periodo.Text & "' "
                    Conectar_Banco()
                    UPDATE_Tributos()
                    Tipo = "1"
                End If
                sql = "update Tributos set Recolhido='" & "N" & "' "
                sql += " where Periodo='" & VPeriodo & "'"
                Conectar_Banco()
                Verificar()
                Exit Sub
            End If
            MsgBox("Processo Cancelado", vbInformation, "Update")
            Txt_Periodo.Text = ""
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message)
            conectar.Close()
        End Try
    End Sub
    Private Sub Verificar()
        Try
            sql = "Select Min(Periodo) MinPeriodo from Entidade"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Entidade")
            resultado = local.Tables("Entidade").Rows.Count
            registro = local.Tables("Entidade").Rows(0)
            VPeriodo2 = local.Tables(0).Rows(0)("MinPeriodo")
            'If resultado > 0 Then
            '    'BTN_Calcular.Text = "UPDATE"
            'Else
            '    BTN_Calcular.Text = "Calcular"
            'End If
        Catch ex As Exception
            conectar.Close()
        End Try
    End Sub
    Private Sub Cb_Ano_Validated(sender As Object, e As EventArgs)
        Try
            sql = "select * from Tributos where Periodo="
            sql += "'" & Txt_Periodo.Text & "'"
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Tributos")
            resultado = local.Tables("Tributos").Rows.Count
            BTN_Calcular.Enabled = True
            'If resultado > 0 Then
            '    BTN_Calcular.Text = "UPDATE"
            'Else
            '    BTN_Calcular.Text = "Calcular"
            'End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Cb_Ano_KeyPress(sender As Object, e As KeyPressEventArgs)
        If AscW(e.KeyChar) = Keys.Enter Then
            BTN_Calcular.Focus()
        End If
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
    Private Sub UPDATE_Tributos()
        Try
            If vlMes = "12" Then
                Query = "Update_Tributos_Dez"
            Else
                Query = "Update_Tributos"
            End If
            comando.Connection = conectar
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = Query
            comando.CommandTimeout = 360
            conectar.Open()
            comando.ExecuteNonQuery()
            conectar.Close()
            MsgBox("Dados Atualizados Com Sucesso!", vbInformation, "Update")
            Fm_Relatorio_Tributos_Geral_R.Show()
            BTN_Calcular.Enabled = False
            LB_Inform.Text = "Dados Atualizados com Sucesso"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class