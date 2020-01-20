<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Deposito_Decimo_13_R
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
        Me.Report_13 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.DepositosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepositosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Report_13
        '
        Me.Report_13.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Depositos_Decimo_Terceiro_Salario"
        ReportDataSource1.Value = Me.DepositosBindingSource
        Me.Report_13.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_13.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Deposito_Decimo_13.rdlc"
        Me.Report_13.Location = New System.Drawing.Point(0, 0)
        Me.Report_13.Name = "Report_13"
        Me.Report_13.Size = New System.Drawing.Size(284, 261)
        Me.Report_13.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Fm_Relatorio_Deposito_Decimo_13_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Report_13)
        Me.Name = "Fm_Relatorio_Deposito_Decimo_13_R"
        Me.Text = "Fm_Relatorio_Deposito_Decimo_13"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_13 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DepositosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents DepositosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter
End Class
