<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_relatorio_AbatimentoINSS_R
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Deducao_INSS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TributosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter()
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TributosBindingSource
        '
        Me.TributosBindingSource.DataMember = "Tributos"
        Me.TributosBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Deducao_INSS
        '
        Me.Report_Deducao_INSS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Abatimentos"
        ReportDataSource1.Value = Me.TributosBindingSource
        Me.Report_Deducao_INSS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Deducao_INSS.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_AbatimentoINSS.rdlc"
        Me.Report_Deducao_INSS.Location = New System.Drawing.Point(0, 0)
        Me.Report_Deducao_INSS.Name = "Report_Deducao_INSS"
        Me.Report_Deducao_INSS.Size = New System.Drawing.Size(482, 300)
        Me.Report_Deducao_INSS.TabIndex = 0
        '
        'TributosTableAdapter
        '
        Me.TributosTableAdapter.ClearBeforeFill = True
        '
        'Fm_relatorio_AbatimentoINSS_R
        '
        Me.ClientSize = New System.Drawing.Size(482, 300)
        Me.Controls.Add(Me.Report_Deducao_INSS)
        Me.Name = "Fm_relatorio_AbatimentoINSS_R"
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Deducao_INSS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents TributosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter
   
End Class
