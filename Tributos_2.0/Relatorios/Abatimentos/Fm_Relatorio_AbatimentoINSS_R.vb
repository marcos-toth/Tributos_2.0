Public Class Fm_relatorio_AbatimentoINSS_R

    Private Sub Fm_relatorio_AbatimentoINSS_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Me.WindowState = FormWindowState.Maximized
            '        
            If Tipo = "1" Then
                Me.TributosTableAdapter.Deducao_Geral(Me.DS_Tributos.Tributos, VPeriodo)
            Else
                Me.TributosTableAdapter.Debucao_Entidade(Me.DS_Tributos.Tributos, VPeriodo, Entidades)
            End If
            Me.Report_Deducao_INSS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.Report_Deducao_INSS.RefreshReport()
        Catch ex As Exception
            MsgBox("Error ao Conectar no Banco de Dados, se persistir, favor entrar em contato com o Suporte", vbCritical, "Erro Conexão ao Banco")
            MsgBox(ex.Message)
        End Try
    
    End Sub

End Class