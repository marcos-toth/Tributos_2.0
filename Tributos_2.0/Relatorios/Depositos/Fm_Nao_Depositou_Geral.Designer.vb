<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Nao_Depositou_Geral
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
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RV_Não_Depositaram = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataTable1TableAdapter = New Tributos_2._0.DS_TributosTableAdapters.DataTable1TableAdapter()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'RV_Não_Depositaram
        '
        Me.RV_Não_Depositaram.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Nao_Depositou"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        Me.RV_Não_Depositaram.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV_Não_Depositaram.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatório_Nao_Depositou_Geral.rdlc"
        Me.RV_Não_Depositaram.Location = New System.Drawing.Point(0, 0)
        Me.RV_Não_Depositaram.Name = "RV_Não_Depositaram"
        Me.RV_Não_Depositaram.Size = New System.Drawing.Size(959, 413)
        Me.RV_Não_Depositaram.TabIndex = 0
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Fm_Nao_Depositou_Geral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 413)
        Me.Controls.Add(Me.RV_Não_Depositaram)
        Me.Name = "Fm_Nao_Depositou_Geral"
        Me.Text = "Fm_Nao_Depositou_Geral"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RV_Não_Depositaram As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents DataTable1TableAdapter As Tributos_2._0.DS_TributosTableAdapters.DataTable1TableAdapter
End Class
