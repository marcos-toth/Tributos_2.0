<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Informe_DIRF_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Informe_DIRF_R))
        Me.RV_DIRF = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IRBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.IRTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter()
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RV_DIRF
        '
        Me.RV_DIRF.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Informe_DIRF"
        ReportDataSource1.Value = Me.IRBindingSource
        Me.RV_DIRF.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV_DIRF.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Informe_DIRF.rdlc"
        Me.RV_DIRF.Location = New System.Drawing.Point(0, 0)
        Me.RV_DIRF.Name = "RV_DIRF"
        Me.RV_DIRF.Size = New System.Drawing.Size(575, 352)
        Me.RV_DIRF.TabIndex = 0
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
        'IRTableAdapter
        '
        Me.IRTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Informe_DIRF_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 352)
        Me.Controls.Add(Me.RV_DIRF)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Informe_DIRF_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório DIRF"
        CType(Me.IRBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RV_DIRF As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IRBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents IRTableAdapter As Tributos_2._0.DS_TributosTableAdapters.IRTableAdapter
End Class
