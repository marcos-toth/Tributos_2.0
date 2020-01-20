<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Informe_IR_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Informe_IR_R))
        Me.IRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Informe_IR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IRTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter()
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IRBindingSource
        '
        Me.IRBindingSource.DataMember = "IR"
        Me.IRBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Informe_IR
        '
        Me.Report_Informe_IR.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Informe_IR_Aluguel"
        ReportDataSource1.Value = Me.IRBindingSource
        Me.Report_Informe_IR.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Informe_IR.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Informe_Individual_IR.rdlc"
        Me.Report_Informe_IR.Location = New System.Drawing.Point(0, 0)
        Me.Report_Informe_IR.Name = "Report_Informe_IR"
        Me.Report_Informe_IR.Size = New System.Drawing.Size(458, 308)
        Me.Report_Informe_IR.TabIndex = 0
        '
        'IRTableAdapter
        '
        Me.IRTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Informe_IR_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 308)
        Me.Controls.Add(Me.Report_Informe_IR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Informe_IR_R"
        Me.Text = "Informe Rendimento e Retenções de IR Aluguéis"
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Informe_IR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents IRTableAdapter As Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter
End Class
