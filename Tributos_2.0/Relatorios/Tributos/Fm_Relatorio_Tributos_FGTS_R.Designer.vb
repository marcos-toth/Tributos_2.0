<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_FGTS_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Tributos_FGTS_R))
        Me.Report_Tributo_FGTS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.TributosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter()
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Report_Tributo_FGTS
        '
        Me.Report_Tributo_FGTS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_FGTS"
        ReportDataSource1.Value = Me.TributosBindingSource
        Me.Report_Tributo_FGTS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Tributo_FGTS.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_FGTS.rdlc"
        Me.Report_Tributo_FGTS.Location = New System.Drawing.Point(0, 0)
        Me.Report_Tributo_FGTS.Name = "Report_Tributo_FGTS"
        Me.Report_Tributo_FGTS.Size = New System.Drawing.Size(449, 305)
        Me.Report_Tributo_FGTS.TabIndex = 0
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
        'TributosTableAdapter
        '
        Me.TributosTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Tributos_FGTS_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 305)
        Me.Controls.Add(Me.Report_Tributo_FGTS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Tributos_FGTS_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Tributos _FGTS"
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Tributo_FGTS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents TributosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter
End Class
