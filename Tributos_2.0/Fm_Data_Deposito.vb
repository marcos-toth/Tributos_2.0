Imports System.Data.SqlClient
Public Class Fm_Data_Deposito
    Private Sub Fm_Data_Deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        ProgressBar1.Show()
        Timer1.Start()
        Timer2.Start()
        Preencher_Datas()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub Rb_Data_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Data.CheckedChanged
        My.Settings.Data = AvisoMes
        My.Settings.Save()
        Me.Close()
    End Sub
    Private intconta As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If intconta > 2 Then
            intconta = 0
        End If
        If intconta = 0 Then
            Lb_FGTS.ForeColor = Color.Red
            'LBFGTS.ForeColor = Color.White
            Lb_Demais.ForeColor = Color.Red
            'LBDemais.ForeColor = Color.White
            Lb_Cabecalho.ForeColor = Color.White
        ElseIf intconta = 1 Then
            Lb_FGTS.ForeColor = Color.White
            Lb_Demais.ForeColor = Color.White
            'LBFGTS.ForeColor = Color.LawnGreen
            'LBDemais.ForeColor = Color.LawnGreen
            'Lb_Cabecalho.ForeColor = Color.Black
        End If
        intconta += 1
    End Sub
    Private Sub Preencher_Datas()
        Try
            sql = "Select * from Data_Deposito where Mes="
            sql += "'" & AvisoMes & "'"
            sql += "" & Query & ""
            conectar.Open()
            adaptar = New SqlDataAdapter(sql, conectar)
            conectar.Close()
            local = New DataSet
            adaptar.Fill(local, "Data_Deposito")
            resultado = local.Tables("Data_Deposito").Rows.Count
            conectar.Close()
            If resultado > 0 Then
                registro = local.Tables("Data_Deposito").Rows(0)
                Lb_FGTS.Text = registro("FGTS")
                Lb_Demais.Text = registro("Demais_Tributos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class