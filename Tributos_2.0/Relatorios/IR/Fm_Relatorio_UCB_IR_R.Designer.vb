<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_UCB_IR_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_UCB_IR_R))
        Me.IRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Relatorio_IR_UCB = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IRTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter()
        Me.DSTributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSTributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Report_Relatorio_IR_UCB
        '
        Me.Report_Relatorio_IR_UCB.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Relatorio_IR_UCB"
        ReportDataSource1.Value = Me.IRBindingSource
        Me.Report_Relatorio_IR_UCB.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Relatorio_IR_UCB.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_UCB_IR.rdlc"
        Me.Report_Relatorio_IR_UCB.Location = New System.Drawing.Point(0, 0)
        Me.Report_Relatorio_IR_UCB.Name = "Report_Relatorio_IR_UCB"
        Me.Report_Relatorio_IR_UCB.Size = New System.Drawing.Size(284, 261)
        Me.Report_Relatorio_IR_UCB.TabIndex = 0
        '
        'IRTableAdapter
        '
        Me.IRTableAdapter.ClearBeforeFill = True
        '
        'DSTributosBindingSource
        '
        Me.DSTributosBindingSource.DataSource = Me.DS_Tributos
        Me.DSTributosBindingSource.Position = 0
        '
        'Fm_Relatorio_UCB_IR_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Report_Relatorio_IR_UCB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_UCB_IR_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório IR Aluguel "
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSTributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Relatorio_IR_UCB As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents IRTableAdapter As Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter
    Friend WithEvents DSTributosBindingSource As System.Windows.Forms.BindingSource
End Class
