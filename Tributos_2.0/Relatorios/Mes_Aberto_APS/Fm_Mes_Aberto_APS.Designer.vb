<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Mes_Aberto_APS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Mes_Aberto_APS))
        Me.Periodo_APSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RP_Mes_APS = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Periodo_APSTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Periodo_APSTableAdapter()
        CType(Me.Periodo_APSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Periodo_APSBindingSource
        '
        Me.Periodo_APSBindingSource.DataMember = "Periodo_APS"
        Me.Periodo_APSBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RP_Mes_APS
        '
        Me.RP_Mes_APS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Periodo_APS"
        ReportDataSource1.Value = Me.Periodo_APSBindingSource
        Me.RP_Mes_APS.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_Mes_APS.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Mes_Aberto_APS.rdlc"
        Me.RP_Mes_APS.Location = New System.Drawing.Point(0, 0)
        Me.RP_Mes_APS.Name = "RP_Mes_APS"
        Me.RP_Mes_APS.Size = New System.Drawing.Size(500, 261)
        Me.RP_Mes_APS.TabIndex = 0
        '
        'Periodo_APSTableAdapter
        '
        Me.Periodo_APSTableAdapter.ClearBeforeFill = True
        '
        'Fm_Mes_Aberto_APS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 261)
        Me.Controls.Add(Me.RP_Mes_APS)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Mes_Aberto_APS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entidade Com o Mês Aberto no APS"
        CType(Me.Periodo_APSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_Mes_APS As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Periodo_APSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents Periodo_APSTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Periodo_APSTableAdapter
End Class
