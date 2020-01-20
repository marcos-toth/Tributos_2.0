<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_IR_Recisao_Aluguel_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_IR_Recisao_Aluguel_R))
        Me.IR_Multa_RescisaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RP_Recisao_IR_Aluguel = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IR_Multa_RescisaoTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.IR_Multa_RescisaoTableAdapter()
        CType(Me.IR_Multa_RescisaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IR_Multa_RescisaoBindingSource
        '
        Me.IR_Multa_RescisaoBindingSource.DataMember = "IR_Multa_Rescisao"
        Me.IR_Multa_RescisaoBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RP_Recisao_IR_Aluguel
        '
        Me.RP_Recisao_IR_Aluguel.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_IR_Rescisao_Aluguel"
        ReportDataSource1.Value = Me.IR_Multa_RescisaoBindingSource
        Me.RP_Recisao_IR_Aluguel.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_Recisao_IR_Aluguel.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_IR_Recisao_Aluguel.rdlc"
        Me.RP_Recisao_IR_Aluguel.Location = New System.Drawing.Point(0, 0)
        Me.RP_Recisao_IR_Aluguel.Name = "RP_Recisao_IR_Aluguel"
        Me.RP_Recisao_IR_Aluguel.Size = New System.Drawing.Size(596, 393)
        Me.RP_Recisao_IR_Aluguel.TabIndex = 0
        '
        'IR_Multa_RescisaoTableAdapter
        '
        Me.IR_Multa_RescisaoTableAdapter.ClearBeforeFill = True
        '
        'Fm_IR_Recisao_Aluguel_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 393)
        Me.Controls.Add(Me.RP_Recisao_IR_Aluguel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_IR_Recisao_Aluguel_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório IR Multa Recisória Contrato de Aluguel"
        CType(Me.IR_Multa_RescisaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_Recisao_IR_Aluguel As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IR_Multa_RescisaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents IR_Multa_RescisaoTableAdapter As Tributos_2._0.DS_TributosTableAdapters.IR_Multa_RescisaoTableAdapter
End Class
