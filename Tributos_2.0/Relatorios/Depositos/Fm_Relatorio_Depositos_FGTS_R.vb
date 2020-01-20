Public Class Fm_Relatorio_Depositos_FGTS_R

    Private Sub Fm_Relatorio_Deposito_FGTS_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If vnivel = "0" Or vnivel > "4" Then
                If TipoRel = "Consolidado" Then
                    Me.DepositosTableAdapter.GeralUCB(Me.DS_Tributos.Depositos, vlPeriodoComp, Tipo)
                Else
                    Me.DepositosTableAdapter.AnaliticoUCB(Me.DS_Tributos.Depositos, vlPeriodoComp, Entidades, Tipo)
                End If
            Else
                If TipoRel = "Consolidado" Then
                    Me.DepositosTableAdapter.CampoGeral(Me.DS_Tributos.Depositos, vlPeriodoComp, Tipo, EntidadeLogada, "S")
                Else
                    Me.DepositosTableAdapter.CampoAnalitico(Me.DS_Tributos.Depositos, vlPeriodoComp, Tipo, Entidades, EntidadeLogada, "S")
                End If
            End If
            Me.Report_Deposito_FGTS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Deposito_FGTS.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class