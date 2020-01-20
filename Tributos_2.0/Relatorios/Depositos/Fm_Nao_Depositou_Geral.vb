Public Class Fm_Nao_Depositou_Geral

    Private Sub Fm_Nao_Depositou_Geral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Me.RV_Não_Depositaram.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
            Me.RV_Não_Depositaram.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class