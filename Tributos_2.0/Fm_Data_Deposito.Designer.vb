<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Data_Deposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Data_Deposito))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Rb_Data = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lb_Cabecalho = New System.Windows.Forms.Label()
        Me.LBFGTS = New System.Windows.Forms.Label()
        Me.LBDemais = New System.Windows.Forms.Label()
        Me.Lb_FGTS = New System.Windows.Forms.Label()
        Me.Lb_Demais = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 133)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(514, 10)
        Me.ProgressBar1.TabIndex = 55
        Me.ProgressBar1.Visible = False
        '
        'Rb_Data
        '
        Me.Rb_Data.AutoSize = True
        Me.Rb_Data.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Data.ForeColor = System.Drawing.Color.Black
        Me.Rb_Data.Location = New System.Drawing.Point(3, 149)
        Me.Rb_Data.Name = "Rb_Data"
        Me.Rb_Data.Size = New System.Drawing.Size(200, 19)
        Me.Rb_Data.TabIndex = 54
        Me.Rb_Data.Text = " Não Exibir Esse Aviso Este Mês"
        Me.Rb_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Rb_Data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Rb_Data.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Lb_Cabecalho
        '
        Me.Lb_Cabecalho.AutoSize = True
        Me.Lb_Cabecalho.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Cabecalho.ForeColor = System.Drawing.Color.White
        Me.Lb_Cabecalho.Location = New System.Drawing.Point(104, 18)
        Me.Lb_Cabecalho.Name = "Lb_Cabecalho"
        Me.Lb_Cabecalho.Size = New System.Drawing.Size(329, 24)
        Me.Lb_Cabecalho.TabIndex = 56
        Me.Lb_Cabecalho.Text = "Datas Para Depósitos dos Tributos"
        '
        'LBFGTS
        '
        Me.LBFGTS.AutoSize = True
        Me.LBFGTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFGTS.Location = New System.Drawing.Point(110, 57)
        Me.LBFGTS.Name = "LBFGTS"
        Me.LBFGTS.Size = New System.Drawing.Size(64, 24)
        Me.LBFGTS.TabIndex = 57
        Me.LBFGTS.Text = "FGTS"
        '
        'LBDemais
        '
        Me.LBDemais.AutoSize = True
        Me.LBDemais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBDemais.Location = New System.Drawing.Point(283, 57)
        Me.LBDemais.Name = "LBDemais"
        Me.LBDemais.Size = New System.Drawing.Size(161, 24)
        Me.LBDemais.TabIndex = 58
        Me.LBDemais.Text = "Demais Tributos"
        '
        'Lb_FGTS
        '
        Me.Lb_FGTS.AutoSize = True
        Me.Lb_FGTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_FGTS.ForeColor = System.Drawing.Color.Red
        Me.Lb_FGTS.Location = New System.Drawing.Point(84, 94)
        Me.Lb_FGTS.Name = "Lb_FGTS"
        Me.Lb_FGTS.Size = New System.Drawing.Size(110, 24)
        Me.Lb_FGTS.TabIndex = 59
        Me.Lb_FGTS.Text = "04/01/2018"
        '
        'Lb_Demais
        '
        Me.Lb_Demais.AutoSize = True
        Me.Lb_Demais.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Demais.ForeColor = System.Drawing.Color.Red
        Me.Lb_Demais.Location = New System.Drawing.Point(306, 94)
        Me.Lb_Demais.Name = "Lb_Demais"
        Me.Lb_Demais.Size = New System.Drawing.Size(110, 24)
        Me.Lb_Demais.TabIndex = 60
        Me.Lb_Demais.Text = "19/01/2018"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Fm_Data_Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 170)
        Me.Controls.Add(Me.Lb_Demais)
        Me.Controls.Add(Me.Lb_FGTS)
        Me.Controls.Add(Me.LBDemais)
        Me.Controls.Add(Me.LBFGTS)
        Me.Controls.Add(Me.Lb_Cabecalho)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Rb_Data)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_Data_Deposito"
        Me.Text = "Datas Para Depósitos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Rb_Data As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lb_Cabecalho As System.Windows.Forms.Label
    Friend WithEvents LBFGTS As System.Windows.Forms.Label
    Friend WithEvents LBDemais As System.Windows.Forms.Label
    Friend WithEvents Lb_FGTS As System.Windows.Forms.Label
    Friend WithEvents Lb_Demais As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
