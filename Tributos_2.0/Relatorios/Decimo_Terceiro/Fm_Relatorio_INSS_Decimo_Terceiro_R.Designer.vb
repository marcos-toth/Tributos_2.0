﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Deposito_Decimo_Terceiro
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
        Me.Decimo_TerceiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Decimo_Terceiro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Decimo_TerceiroTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.Decimo_TerceiroTableAdapter()
        CType(Me.Decimo_TerceiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Decimo_TerceiroBindingSource
        '
        Me.Decimo_TerceiroBindingSource.DataMember = "Decimo_Terceiro"
        Me.Decimo_TerceiroBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Decimo_Terceiro
        '
        Me.Report_Decimo_Terceiro.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Decimo_Terceiro"
        ReportDataSource1.Value = Me.Decimo_TerceiroBindingSource
        Me.Report_Decimo_Terceiro.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Decimo_Terceiro.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_INSS_Decimo_Terceiro.rdlc"
        Me.Report_Decimo_Terceiro.Location = New System.Drawing.Point(0, 0)
        Me.Report_Decimo_Terceiro.Name = "Report_Decimo_Terceiro"
        Me.Report_Decimo_Terceiro.Size = New System.Drawing.Size(474, 353)
        Me.Report_Decimo_Terceiro.TabIndex = 0
        '
        'Decimo_TerceiroTableAdapter
        '
        Me.Decimo_TerceiroTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Deposito_Decimo_Terceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 353)
        Me.Controls.Add(Me.Report_Decimo_Terceiro)
        Me.Name = "Fm_Relatorio_Deposito_Decimo_Terceiro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de INSS 13º Salário"
        CType(Me.Decimo_TerceiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Decimo_Terceiro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Decimo_TerceiroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents Decimo_TerceiroTableAdapter As Tributos_2._0.DS_TributosTableAdapters.Decimo_TerceiroTableAdapter
End Class
