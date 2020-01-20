<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Deducao_IR_Aluguel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Deducao_IR_Aluguel))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Base_Reducao = New System.Windows.Forms.TextBox()
        Me.Txt_IPTU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Taxa_ADM = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Condominio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(10, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 15)
        Me.Label5.TabIndex = 10090
        Me.Label5.Text = "Dedução Base IR:"
        '
        'Txt_Base_Reducao
        '
        Me.Txt_Base_Reducao.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.Txt_Base_Reducao.Location = New System.Drawing.Point(118, 156)
        Me.Txt_Base_Reducao.Name = "Txt_Base_Reducao"
        Me.Txt_Base_Reducao.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Base_Reducao.TabIndex = 10089
        Me.Txt_Base_Reducao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_IPTU
        '
        Me.Txt_IPTU.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.Txt_IPTU.Location = New System.Drawing.Point(118, 97)
        Me.Txt_IPTU.Name = "Txt_IPTU"
        Me.Txt_IPTU.Size = New System.Drawing.Size(96, 20)
        Me.Txt_IPTU.TabIndex = 10089
        Me.Txt_IPTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(79, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 10090
        Me.Label1.Text = "IPTU:"
        '
        'Txt_Taxa_ADM
        '
        Me.Txt_Taxa_ADM.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.Txt_Taxa_ADM.Location = New System.Drawing.Point(118, 71)
        Me.Txt_Taxa_ADM.Name = "Txt_Taxa_ADM"
        Me.Txt_Taxa_ADM.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Taxa_ADM.TabIndex = 10089
        Me.Txt_Taxa_ADM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(32, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 10090
        Me.Label2.Text = "Taxa de ADM:"
        '
        'Txt_Condominio
        '
        Me.Txt_Condominio.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.Txt_Condominio.Location = New System.Drawing.Point(118, 123)
        Me.Txt_Condominio.Name = "Txt_Condominio"
        Me.Txt_Condominio.Size = New System.Drawing.Size(96, 20)
        Me.Txt_Condominio.TabIndex = 10089
        Me.Txt_Condominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(39, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 10090
        Me.Label3.Text = "Condomínio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(47, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 15)
        Me.Label4.TabIndex = 10091
        Me.Label4.Text = "Preencha os Campos  Abaixo "
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalvar.Location = New System.Drawing.Point(72, 182)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 10093
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpar.Location = New System.Drawing.Point(146, 182)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 10092
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(43, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 15)
        Me.Label6.TabIndex = 10094
        Me.Label6.Text = "Para Gerar a Base de Dedução"
        '
        'Fm_Deducao_IR_Aluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 261)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Taxa_ADM)
        Me.Controls.Add(Me.Txt_Condominio)
        Me.Controls.Add(Me.Txt_IPTU)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_Base_Reducao)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_Deducao_IR_Aluguel"
        Me.Text = "Gera Base de Dedução IR S/ Aluguel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_Base_Reducao As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IPTU As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Taxa_ADM As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Condominio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
