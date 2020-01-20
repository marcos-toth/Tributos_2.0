<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Funcoes_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Funcoes_R))
        Me.RV_Funcoes = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.FuncaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FuncaoTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.FuncaoTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FuncaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RV_Funcoes
        '
        Me.RV_Funcoes.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Funcoes"
        ReportDataSource1.Value = Me.FuncaoBindingSource
        Me.RV_Funcoes.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RV_Funcoes.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Funcoes.rdlc"
        Me.RV_Funcoes.Location = New System.Drawing.Point(0, 0)
        Me.RV_Funcoes.Name = "RV_Funcoes"
        Me.RV_Funcoes.Size = New System.Drawing.Size(284, 261)
        Me.RV_Funcoes.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FuncaoBindingSource
        '
        Me.FuncaoBindingSource.DataMember = "Funcao"
        Me.FuncaoBindingSource.DataSource = Me.DS_Tributos
        '
        'FuncaoTableAdapter
        '
        Me.FuncaoTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Funcoes_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.RV_Funcoes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Funcoes_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatõrio de Funções"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FuncaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RV_Funcoes As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FuncaoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents FuncaoTableAdapter As Tributos_2._0.DS_TributosTableAdapters.FuncaoTableAdapter
End Class
