<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatório_Usuario_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatório_Usuario_R))
        Me.Report_Usuarios = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.UsuariosTableAdapter()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Report_Usuarios
        '
        Me.Report_Usuarios.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Usuarios"
        ReportDataSource1.Value = Me.UsuariosBindingSource
        Me.Report_Usuarios.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Usuarios.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatório_Usuario.rdlc"
        Me.Report_Usuarios.Location = New System.Drawing.Point(0, 0)
        Me.Report_Usuarios.Name = "Report_Usuarios"
        Me.Report_Usuarios.Size = New System.Drawing.Size(454, 297)
        Me.Report_Usuarios.TabIndex = 0
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DS_Tributos
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatório_Usuario_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 297)
        Me.Controls.Add(Me.Report_Usuarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatório_Usuario_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Usuários"
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Usuarios As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents UsuariosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.UsuariosTableAdapter
End Class
