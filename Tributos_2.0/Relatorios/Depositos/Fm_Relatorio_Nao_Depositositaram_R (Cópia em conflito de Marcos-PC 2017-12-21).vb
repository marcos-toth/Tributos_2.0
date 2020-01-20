Public Class Fm_Relatorio_Nao_Depositositaram_R

    Private Sub Fm_Relatorio_Nao_Depositositaram_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try  '
            Me.WindowState = FormWindowState.Maximized
            If TipoRel = "1" Then
                Me.DataTable1TableAdapter.Nao_Depositou_Geral(Me.DS_Tributos.DataTable1, VPeriodo, vlAno, vlMes, Tipo)
            Else
                Me.DataTable1TableAdapter.Nao_Depositou_Entidade(Me.DS_Tributos.DataTable1, VPeriodo, Entidades, vlAno, vlMes, Tipo)
            End If
            Me.Report_Nao_Depositaram.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class