<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Contabilizacao_Decimo_Terceiro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Contabilizacao_Decimo_Terceiro))
        Me.LB_Inform = New System.Windows.Forms.Label()
        Me.Txt_Periodo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG_PeriodoA = New System.Windows.Forms.DataGridView()
        Me.BTN_Calcular = New System.Windows.Forms.Button()
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_Inform
        '
        Me.LB_Inform.AutoSize = True
        Me.LB_Inform.ForeColor = System.Drawing.Color.DarkGreen
        Me.LB_Inform.Location = New System.Drawing.Point(27, 196)
        Me.LB_Inform.Name = "LB_Inform"
        Me.LB_Inform.Size = New System.Drawing.Size(0, 13)
        Me.LB_Inform.TabIndex = 18
        '
        'Txt_Periodo
        '
        Me.Txt_Periodo.Location = New System.Drawing.Point(247, 84)
        Me.Txt_Periodo.Name = "Txt_Periodo"
        Me.Txt_Periodo.Size = New System.Drawing.Size(70, 20)
        Me.Txt_Periodo.TabIndex = 17
        Me.Txt_Periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Período Para Buscar Saldo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Dupblo Click no Período Para Selecionar"
        '
        'DG_PeriodoA
        '
        Me.DG_PeriodoA.AllowUserToAddRows = False
        Me.DG_PeriodoA.AllowUserToDeleteRows = False
        Me.DG_PeriodoA.BackgroundColor = System.Drawing.Color.White
        Me.DG_PeriodoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_PeriodoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PeriodoA.Location = New System.Drawing.Point(30, 29)
        Me.DG_PeriodoA.Name = "DG_PeriodoA"
        Me.DG_PeriodoA.ReadOnly = True
        Me.DG_PeriodoA.Size = New System.Drawing.Size(165, 150)
        Me.DG_PeriodoA.TabIndex = 14
        '
        'BTN_Calcular
        '
        Me.BTN_Calcular.Enabled = False
        Me.BTN_Calcular.Location = New System.Drawing.Point(232, 110)
        Me.BTN_Calcular.Name = "BTN_Calcular"
        Me.BTN_Calcular.Size = New System.Drawing.Size(93, 23)
        Me.BTN_Calcular.TabIndex = 13
        Me.BTN_Calcular.Text = "Buscar Saldos"
        Me.BTN_Calcular.UseVisualStyleBackColor = True
        '
        'Fm_Contabilizacao_Decimo_Terceiro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 216)
        Me.Controls.Add(Me.LB_Inform)
        Me.Controls.Add(Me.Txt_Periodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DG_PeriodoA)
        Me.Controls.Add(Me.BTN_Calcular)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Contabilizacao_Decimo_Terceiro"
        Me.Text = "Contabilização Décimo Terceiro"
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Inform As System.Windows.Forms.Label
    Friend WithEvents Txt_Periodo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DG_PeriodoA As System.Windows.Forms.DataGridView
    Friend WithEvents BTN_Calcular As System.Windows.Forms.Button
End Class
