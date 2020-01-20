<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_UCB_IR_Resisao_Contrato_R
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_UCB_IR_Resisao_Contrato_R))
        Me.RP_UCB_IR_Resisao = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'RP_UCB_IR_Resisao
        '
        Me.RP_UCB_IR_Resisao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RP_UCB_IR_Resisao.Location = New System.Drawing.Point(0, 0)
        Me.RP_UCB_IR_Resisao.Name = "RP_UCB_IR_Resisao"
        Me.RP_UCB_IR_Resisao.Size = New System.Drawing.Size(685, 329)
        Me.RP_UCB_IR_Resisao.TabIndex = 0
        '
        'Fm_UCB_IR_Resisao_Contrato_R
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 329)
        Me.Controls.Add(Me.RP_UCB_IR_Resisao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_UCB_IR_Resisao_Contrato_R"
        Me.Text = "Relatório IR Rescisão Aluguel"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RP_UCB_IR_Resisao As Microsoft.Reporting.WinForms.ReportViewer
End Class
