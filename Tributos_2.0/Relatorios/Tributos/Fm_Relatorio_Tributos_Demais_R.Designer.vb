<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_Demais_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Tributos_Demais_R))
        Me.TributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Tributos_Demais = New Microsoft.Reporting.WinForms.ReportViewer()
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
        'Report_Tributos_Demais
        '
        Me.Report_Tributos_Demais.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Tributos_Demais"
        ReportDataSource1.Value = Me.TributosBindingSource
        Me.Report_Tributos_Demais.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Tributos_Demais.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Demais.rdlc"
        Me.Report_Tributos_Demais.Location = New System.Drawing.Point(0, 0)
        Me.Report_Tributos_Demais.Name = "Report_Tributos_Demais"
        Me.Report_Tributos_Demais.Size = New System.Drawing.Size(284, 261)
        Me.Report_Tributos_Demais.TabIndex = 0
        '
        'TributosTableAdapter
        '
        Me.TributosTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Tributos_Demais_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Report_Tributos_Demais)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Tributos_Demais_R"
        Me.Text = "Relatório Tributos Para Depósito"
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Tributos_Demais As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents TributosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter
End Class
