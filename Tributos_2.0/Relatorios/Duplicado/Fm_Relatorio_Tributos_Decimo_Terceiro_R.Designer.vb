﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_Decimo_Terceiro_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Tributos_Decimo_Terceiro_R))
        Me.DepositosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Tributos = New Tributos_2._0.DS_Tributos()
        Me.Report_Decimo_Terceiro = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DepositosTableAdapter = New Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter()
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepositosBindingSource
        '
        Me.DepositosBindingSource.DataMember = "Depositos"
        Me.DepositosBindingSource.DataSource = Me.DS_Tributos
        '
        'DS_Tributos
        '
        Me.DS_Tributos.DataSetName = "DS_Tributos"
        Me.DS_Tributos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Report_Decimo_Terceiro
        '
        Me.Report_Decimo_Terceiro.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DepositosBindingSource
        Me.Report_Decimo_Terceiro.LocalReport.DataSources.Add(ReportDataSource1)
        Me.Report_Decimo_Terceiro.LocalReport.ReportEmbeddedResource = "Tributos_2._0.Relatorio_Depositos_Decimo_Terceiro.rdlc"
        Me.Report_Decimo_Terceiro.Location = New System.Drawing.Point(0, 0)
        Me.Report_Decimo_Terceiro.Name = "Report_Decimo_Terceiro"
        Me.Report_Decimo_Terceiro.Size = New System.Drawing.Size(564, 288)
        Me.Report_Decimo_Terceiro.TabIndex = 0
        '
        'DepositosTableAdapter
        '
        Me.DepositosTableAdapter.ClearBeforeFill = True
        '
        'Fm_Relatorio_Tributos_Decimo_Terceiro_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 288)
        Me.Controls.Add(Me.Report_Decimo_Terceiro)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Tributos_Decimo_Terceiro_R"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório dos Depósitos  de Décimo Terceiro"
        CType(Me.DepositosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Tributos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Report_Decimo_Terceiro As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DepositosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_Tributos As Tributos_2._0.DS_Tributos
    Friend WithEvents DepositosTableAdapter As Tributos_2._0.DS_TributosTableAdapters.DepositosTableAdapter
End Class
