<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_IR_Data_Recolhimento_R
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.IRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IRTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Relatorio_IR_UCB"
        ReportDataSource1.Value = Me.IRBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_UCB_IR.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(392, 290)
        Me.ReportViewer1.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IRBindingSource
        '
        Me.IRBindingSource.DataMember = "IR"
        Me.IRBindingSource.DataSource = Me.DS_Tributos
        '
        'IRTableAdapter
        '
        Me.IRTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_IR_Data_Recolhimento_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 290)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Fm_Relatorio_IR_Data_Recolhimento_R"
        Me.Text = "Fm_Relatorio_IR_Data_Recolhimento_R"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents IRTableAdapter As Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter
End Class
