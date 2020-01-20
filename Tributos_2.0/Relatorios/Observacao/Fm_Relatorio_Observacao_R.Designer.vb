<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Observacao_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Observacao_R))
        Me.ObservacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Observacao = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ObservacaoTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.ObservacaoTableAdapter()
        CType(Me.ObservacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ObservacaoBindingSource
        '
        Me.ObservacaoBindingSource.DataMember = "Observacao"
        Me.ObservacaoBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Observacao
        '
        Me.Report_Observacao.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Observacao"
        ReportDataSource1.Value = Me.ObservacaoBindingSource
        Me.Report_Observacao.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Observacao.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Observacao.rdlc"
        Me.Report_Observacao.Location = New System.Drawing.Point(0, 0)
        Me.Report_Observacao.Name = "Report_Observacao"
        Me.Report_Observacao.Size = New System.Drawing.Size(489, 428)
        Me.Report_Observacao.TabIndex = 0
        '
        'ObservacaoTableAdapter
        '
        Me.ObservacaoTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Observacao_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 428)
        Me.Controls.Add(Me.Report_Observacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Observacao_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Observações dos Pagamentos"
        CType(Me.ObservacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Observacao As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ObservacaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents ObservacaoTableAdapter As Tributos_2._0.DS_TributosTableAdapters.ObservacaoTableAdapter
End Class
