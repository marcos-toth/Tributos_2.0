Public Class Fm_Relatorio_Decimo_Terceiro_R

    Private Sub Fm_Relatorio_Decimo_Terceiro_R_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WindowState = FormWindowState.Maximized
            If vnivel = "0" Or vnivel = "5" Then
                If Tipo = "1" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_UCB_Geral(Me.DS_Tributos.Decimo_Terceiro, VPeriodo)
                ElseIf Tipo = "2" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_UCB_Entidade(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, Entidades)
                ElseIf Tipo = "3" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_terceiro_UCB_CodEntidade(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, Entidades)
                End If
            Else
                If Tipo = "1" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_Campo_Geral(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, EntidadeLogada)
                ElseIf Tipo = "2" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_Campo_Entidade(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, Entidades, EntidadeLogada)
                ElseIf Tipo = "3" Then
                    Me.Decimo_TerceiroTableAdapter.Decimo_Terceiro_Campo_CodEntidade(Me.DS_Tributos.Decimo_Terceiro, VPeriodo, Entidades, EntidadeLogada)
                End If
            End If
            Me.RP_Tributos_13.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RP_Tributos_13.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class