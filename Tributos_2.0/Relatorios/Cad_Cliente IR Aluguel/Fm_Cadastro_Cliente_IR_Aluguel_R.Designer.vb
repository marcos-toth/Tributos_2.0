<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Cliente_IR_Aluguel_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Cliente_IR_Aluguel_R))
        Me.Cliente_IRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RP_Cad_Cliente_IR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Cliente_IRTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Cliente_IRTableAdapter()
        CType(Me.Cliente_IRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cliente_IRBindingSource
        '
        Me.Cliente_IRBindingSource.DataMember = "Cliente_IR"
        Me.Cliente_IRBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RP_Cad_Cliente_IR
        '
        Me.RP_Cad_Cliente_IR.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Cliente_IRBindingSource
        Me.RP_Cad_Cliente_IR.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_Cad_Cliente_IR.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Cad_Cliente_IR.rdlc"
        Me.RP_Cad_Cliente_IR.Location = New System.Drawing.Point(0, 0)
        Me.RP_Cad_Cliente_IR.Name = "RP_Cad_Cliente_IR"
        Me.RP_Cad_Cliente_IR.Size = New System.Drawing.Size(643, 319)
        Me.RP_Cad_Cliente_IR.TabIndex = 0
        '
        'Cliente_IRTableAdapter
        '
        Me.Cliente_IRTableAdapter.ClearBeforeFill = True
        '
        'Fm_Cadastro_Cliente_IR_Aluguel_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 319)
        Me.Controls.Add(Me.RP_Cad_Cliente_IR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Cadastro_Cliente_IR_Aluguel_R"
        Me.Text = "Cadastro Cliente IR Aluguel"
        CType(Me.Cliente_IRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_Cad_Cliente_IR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Cliente_IRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents Cliente_IRTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Cliente_IRTableAdapter
End Class
