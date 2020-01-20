Imports System.Data.SqlClient

Public Class Fm_Contabilizacao_Decimo_Terceiro

    Dim Fm_Relatorio_Decimo_Terceiro_R As Object

    Private Sub Fm_Contabilizacao_Decimo_Terceiro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            sql = "select DISTINCT Periodo from Decimo_Terceiro where Recolhido<>"
            sql += "'" & "S" & "'"
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
            If MsgBox("Deseja Realmente Calcular o Décimo Terceiro?!", MsgBoxStyle.YesNo + vbCritical, "Calcular") = MsgBoxResult.Yes Then
                TipoRel = "Consolidado"
                VPeriodo = Txt_Periodo.Text
                vlAno = Microsoft.VisualBasic.Left(VPeriodo, 4)
                vlMes = Microsoft.VisualBasic.Right(VPeriodo, 2)
                If VPeriodo2 = Txt_Periodo.Text Then
                    UPDATE_Tributos()
                End If
                sql = "update Entidade set Periodo='" & Txt_Periodo.Text & "' "
                Conectar_Banco()
                UPDATE_Tributos()
                Exit Sub
            End If
            MsgBox("Processo Cancelado", vbInformation, "Update")
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
           
        Catch ex As Exception
            conectar.Close()
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
            Conectar.Close()
            Exit Sub
        End Try
    End Sub
    Private Sub UPDATE_Tributos()
        Try
            comando.Connection = conectar
            comando.CommandType = CommandType.StoredProcedure
            comando.CommandText = "UPDATE_Decimo_Terceiro"
            comando.CommandTimeout = 360
            conectar.Open()
            comando.ExecuteNonQuery()
            conectar.Close()
            MsgBox("Décimo Terceiro Atualizados Com Sucesso!", vbInformation, "Update")

            BTN_Calcular.Enabled = False
            LB_Inform.Text = "Dados Atualizados com Sucesso"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class