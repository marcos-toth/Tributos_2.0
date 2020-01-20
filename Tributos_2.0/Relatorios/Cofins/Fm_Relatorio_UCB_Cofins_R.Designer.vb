<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_UCB_Cofins_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_UCB_Cofins_R))
        Me.Report_COFINS_UCB = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.COFINSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COFINSTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.COFINSTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COFINSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Report_COFINS_UCB
        '
        Me.Report_COFINS_UCB.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_COFINS"
        ReportDataSource1.Value = Me.COFINSBindingSource
        Me.Report_COFINS_UCB.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_COFINS_UCB.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_COFINS.rdlc"
        Me.Report_COFINS_UCB.Location = New System.Drawing.Point(0, 0)
        Me.Report_COFINS_UCB.Name = "Report_COFINS_UCB"
        Me.Report_COFINS_UCB.Size = New System.Drawing.Size(537, 359)
        Me.Report_COFINS_UCB.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'COFINSBindingSource
        '
        Me.COFINSBindingSource.DataMember = "COFINS"
        Me.COFINSBindingSource.DataSource = Me.DS_Tributos
        '
        'COFINSTableAdapter
        '
        Me.COFINSTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_UCB_Cofins_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 359)
        Me.Controls.Add(Me.Report_COFINS_UCB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_UCB_Cofins_R"
        Me.Text = "Fm_Relatorio_UCB_Cofins_R"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COFINSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_COFINS_UCB As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents COFINSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents COFINSTableAdapter As Tributos_2._0.DS_TributosTableAdapters.COFINSTableAdapter
End Class
