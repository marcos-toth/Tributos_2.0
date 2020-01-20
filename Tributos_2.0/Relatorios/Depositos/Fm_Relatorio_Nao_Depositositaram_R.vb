Public Class Fm_Relatorio_Nao_Depositositaram_R

    Private Sub Fm_Relatorio_Nao_Depositositaram_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try  '
            Me.WindowState = FormWindowState.Maximized
            If Tipo = "1" Then
                If TipoRel = "1" Then
                    Me.DataTable1TableAdapter.Nao_Depositou_Geral_FGTS(Me.DS_Tributos.DataTable1, VPeriodo, VPeriodo, Tipo)
                Else
                    Me.DataTable1TableAdapter.Nao_Depositou_Entidade_FGTS(Me.DS_Tributos.DataTable1, VPeriodo, Entidades, VPeriodo, Tipo)
                End If
            Else
                If TipoRel = "1" Then
                    Me.DataTable1TableAdapter.Nao_Depositou_Geral_Demais(Me.DS_Tributos.DataTable1, VPeriodo, VPeriodo, Tipo)
                Else
                    Me.DataTable1TableAdapter.Nao_Depositou_Entidade_Demais(Me.DS_Tributos.DataTable1, VPeriodo, Entidades, VPeriodo, Tipo)
                End If
            End If

            
        Catch ex As Exception
        End Try
        Me.Report_Nao_Depositaram.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
        Me.Report_Nao_Depositaram.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("NomeRelatorio", TipoTributos))
        Me.Report_Nao_Depositaram.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Mes", vlMes))
        Me.Report_Nao_Depositaram.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Ano", vlAno))
        Me.Report_Nao_Depositaram.RefreshReport()
    End Sub
End Class