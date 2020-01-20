<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Decimo_Terceiro_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Decimo_Terceiro_R))
        Me.RP_Tributos_13 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Decimo_TerceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Decimo_TerceiroTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Decimo_TerceiroTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Decimo_TerceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RP_Tributos_13
        '
        Me.RP_Tributos_13.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Tributos_13Salario"
        ReportDataSource1.Value = Me.Decimo_TerceiroBindingSource
        Me.RP_Tributos_13.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_Tributos_13.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Decimo_Terceiro.rdlc"
        Me.RP_Tributos_13.Location = New System.Drawing.Point(0, 0)
        Me.RP_Tributos_13.Name = "RP_Tributos_13"
        Me.RP_Tributos_13.Size = New System.Drawing.Size(630, 322)
        Me.RP_Tributos_13.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Decimo_TerceiroBindingSource
        '
        Me.Decimo_TerceiroBindingSource.DataMember = "Decimo_Terceiro"
        Me.Decimo_TerceiroBindingSource.DataSource = Me.DS_Tributos
        '
        'Decimo_TerceiroTableAdapter
        '
        Me.Decimo_TerceiroTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Decimo_Terceiro_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 322)
        Me.Controls.Add(Me.RP_Tributos_13)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Decimo_Terceiro_R"
        Me.Text = "Relatório Encargos Décimo Terceiro"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Decimo_TerceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_Tributos_13 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Decimo_TerceiroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents Decimo_TerceiroTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Decimo_TerceiroTableAdapter
End Class
