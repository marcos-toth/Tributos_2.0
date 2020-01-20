<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Nao_Depositositaram_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Nao_Depositositaram_R))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Nao_Depositaram = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DepositosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepositosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter()
        Me.DataTable1TableAdapter = New Tributos_2._0.DS_TributosTableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Nao_Depositaram
        '
        Me.Report_Nao_Depositaram.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Nao_Depositou"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.Report_Nao_Depositaram.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Nao_Depositaram.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatório_Nao_Depositou.rdlc"
        Me.Report_Nao_Depositaram.Location = New System.Drawing.Point(0, 0)
        Me.Report_Nao_Depositaram.Name = "Report_Nao_Depositaram"
        Me.Report_Nao_Depositaram.Size = New System.Drawing.Size(581, 265)
        Me.Report_Nao_Depositaram.TabIndex = 0
        '
        'DepositosBindingSource
        '
        Me.DepositosBindingSource.DataMember = "Depositos"
        Me.DepositosBindingSource.DataSource = Me.DS_Tributos
        '
        'DepositosTableAdapter
        '
        Me.DepositosTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Nao_Depositositaram_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 265)
        Me.Controls.Add(Me.Report_Nao_Depositaram)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Nao_Depositositaram_R"
        Me.Text = "Relatório das Entidades que Não Depositaram"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Nao_Depositaram As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DepositosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents DepositosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As Tributos_2._0.DS_TributosTableAdapters.DataTable1TableAdapter
End Class
