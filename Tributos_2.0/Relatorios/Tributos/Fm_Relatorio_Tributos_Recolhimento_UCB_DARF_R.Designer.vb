<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_Recolhimento_UCB_DARF_R
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Tributos_Recolhimento_UCB_DARF_R))
        Me.Tributos_RHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RV_RH_UCB = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tributos_RHTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Tributos_RHTableAdapter()
        Me.RV_RH_Educ = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RV_RH_UNASP = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RV_RH_IPAPS = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.Tributos_RHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tributos_RHBindingSource
        '
        Me.Tributos_RHBindingSource.DataMember = "Tributos_RH"
        Me.Tributos_RHBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RV_RH_UCB
        '
        Me.RV_RH_UCB.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Ds_Recolhimento_Federal"
        ReportDataSource1.Value = Me.Tributos_RHBindingSource
        Me.RV_RH_UCB.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV_RH_UCB.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Recolhimento_UCB_DARF.rdlc"
        Me.RV_RH_UCB.Location = New System.Drawing.Point(0, 0)
        Me.RV_RH_UCB.Name = "RV_RH_UCB"
        Me.RV_RH_UCB.Size = New System.Drawing.Size(584, 372)
        Me.RV_RH_UCB.TabIndex = 0
        Me.RV_RH_UCB.Visible = False
        '
        'Tributos_RHTableAdapter
        '
        Me.Tributos_RHTableAdapter.ClearBeforeFill = True
        '
        'RV_RH_Educ
        '
        Me.RV_RH_Educ.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "Ds_Recolhimento_Federal"
        ReportDataSource2.Value = Me.Tributos_RHBindingSource
        Me.RV_RH_Educ.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RV_RH_Educ.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Recolhimento_UCB_DARF_Educ.rdlc"
        Me.RV_RH_Educ.Location = New System.Drawing.Point(0, 0)
        Me.RV_RH_Educ.Name = "RV_RH_Educ"
        Me.RV_RH_Educ.Size = New System.Drawing.Size(584, 372)
        Me.RV_RH_Educ.TabIndex = 1
        Me.RV_RH_Educ.Visible = False
        '
        'RV_RH_UNASP
        '
        Me.RV_RH_UNASP.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "Ds_Recolhimento_Federal"
        ReportDataSource3.Value = Me.Tributos_RHBindingSource
        Me.RV_RH_UNASP.LocalReport.DataSources.Add(ReportDataSource3)
        Me.RV_RH_UNASP.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Recolhimento_UCB_DARF_UNASP.rdlc"
        Me.RV_RH_UNASP.Location = New System.Drawing.Point(0, 0)
        Me.RV_RH_UNASP.Name = "RV_RH_UNASP"
        Me.RV_RH_UNASP.Size = New System.Drawing.Size(584, 372)
        Me.RV_RH_UNASP.TabIndex = 2
        Me.RV_RH_UNASP.Visible = False
        '
        'RV_RH_IPAPS
        '
        Me.RV_RH_IPAPS.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource4.Name = "Ds_Recolhimento_Federal"
        ReportDataSource4.Value = Me.Tributos_RHBindingSource
        Me.RV_RH_IPAPS.LocalReport.DataSources.Add(ReportDataSource4)
        Me.RV_RH_IPAPS.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Tributos_Recolhimento_UCB_DARF_IPAPS.rdlc"
        Me.RV_RH_IPAPS.Location = New System.Drawing.Point(0, 0)
        Me.RV_RH_IPAPS.Name = "RV_RH_IPAPS"
        Me.RV_RH_IPAPS.Size = New System.Drawing.Size(584, 372)
        Me.RV_RH_IPAPS.TabIndex = 3
        Me.RV_RH_IPAPS.Visible = False
        '
        'Fm_Relatorio_Tributos_Recolhimento_UCB_DARF_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 372)
        Me.Controls.Add(Me.RV_RH_IPAPS)
        Me.Controls.Add(Me.RV_RH_UNASP)
        Me.Controls.Add(Me.RV_RH_Educ)
        Me.Controls.Add(Me.RV_RH_UCB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Tributos_Recolhimento_UCB_DARF_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Para Recolhimento dos Tributos - IR"
        CType(Me.Tributos_RHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tributos_RHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents Tributos_RHTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Tributos_RHTableAdapter
    Private WithEvents RV_RH_UCB As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents RV_RH_Educ As Microsoft.Reporting.WinForms.ReportViewer
    Private WithEvents RV_RH_UNASP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RV_RH_IPAPS As Microsoft.Reporting.WinForms.ReportViewer
End Class
