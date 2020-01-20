<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Centralizacao_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Centralizacao_R))
        Me.TributosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.RP_Centralizacao = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tributos_RHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TributosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter()
        Me.Tributos_RHTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Tributos_RHTableAdapter()
        Me.COFINSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COFINSTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.COFINSTableAdapter()
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tributos_RHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COFINSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TributosBindingSource
        '
        Me.TributosBindingSource.DataMember = "Tributos"
        Me.TributosBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RP_Centralizacao
        '
        Me.RP_Centralizacao.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Centralizacao"
        ReportDataSource1.Value = Me.TributosBindingSource
        Me.RP_Centralizacao.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_Centralizacao.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Centralizacao.rdlc"
        Me.RP_Centralizacao.Location = New System.Drawing.Point(0, 0)
        Me.RP_Centralizacao.Name = "RP_Centralizacao"
        Me.RP_Centralizacao.Size = New System.Drawing.Size(433, 337)
        Me.RP_Centralizacao.TabIndex = 0
        '
        'Tributos_RHBindingSource
        '
        Me.Tributos_RHBindingSource.DataMember = "Tributos_RH"
        Me.Tributos_RHBindingSource.DataSource = Me.DS_Tributos
        '
        'TributosTableAdapter
        '
        Me.TributosTableAdapter.ClearBeforeFill = True
        '
        'Tributos_RHTableAdapter
        '
        Me.Tributos_RHTableAdapter.ClearBeforeFill = True
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
        'Fm_Relatorio_Centralizacao_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 337)
        Me.Controls.Add(Me.RP_Centralizacao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Centralizacao_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Centralização Encargos e Tributos "
        CType(Me.TributosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tributos_RHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COFINSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_Centralizacao As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TributosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents TributosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.TributosTableAdapter
    Friend WithEvents Tributos_RHBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tributos_RHTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Tributos_RHTableAdapter
    Friend WithEvents COFINSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COFINSTableAdapter As Tributos_2._0.DS_TributosTableAdapters.COFINSTableAdapter
End Class
