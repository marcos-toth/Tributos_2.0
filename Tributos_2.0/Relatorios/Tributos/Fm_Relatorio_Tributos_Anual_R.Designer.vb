<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_Anual_R
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Relatorio_Tributos_Anual = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.TributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TributosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Relatorio_Tributos_Anual
        '
        Me.Relatorio_Tributos_Anual.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Tributos_Geral"
        ReportDataSource1.Value = Me.TributosBindingSource
        Me.Relatorio_Tributos_Anual.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Relatorio_Tributos_Anual.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Geral.rdlc"
        Me.Relatorio_Tributos_Anual.Location = New System.Drawing.Point(0, 0)
        Me.Relatorio_Tributos_Anual.Name = "Relatorio_Tributos_Anual"
        Me.Relatorio_Tributos_Anual.Size = New System.Drawing.Size(526, 282)
        Me.Relatorio_Tributos_Anual.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TributosBindingSource
        '
        Me.TributosBindingSource.DataMember = "Tributos"
        Me.TributosBindingSource.DataSource = Me.DS_Tributos
        '
        'TributosTableAdapter
        '
        Me.TributosTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Tributos_Anual_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 282)
        Me.Controls.Add(Me.Relatorio_Tributos_Anual)
        Me.Name = "Fm_Relatorio_Tributos_Anual_R"
        Me.Text = "Fm_Relatorio_Tributos_Anual_R"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Relatorio_Tributos_Anual As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents TributosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter
End Class
