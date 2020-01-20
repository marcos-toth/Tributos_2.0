Imports System.Data.SqlClient
Public Class Fm_Mes_Aberto_APS
    Private Sub Fm_Mes_Aberto_APS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS_Tributos.Periodo_APS' table. You can move, or remove it, as needed.

        Me.MdiParent = Fm_Principal
        Me.WindowState = FormWindowState.Maximized
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
        MsgBox("Esse Relatório Demora 40 Segundos, o Sistema Vai Ficar Inoperante!", vbInformation, "Relatório")
        UPDATE_Consulta_Mes()
        Me.Periodo_APSTableAdapter.Fill(Me.DS_Tributos.Periodo_APS)
        Me.RP_Mes_APS.LocalReport.SetParameters(New Microsoft.Reporting.WinForms.ReportParameter("Usuario", NomeUsuario))
        Me.RP_Mes_APS.RefreshReport()
    End Sub
End Class