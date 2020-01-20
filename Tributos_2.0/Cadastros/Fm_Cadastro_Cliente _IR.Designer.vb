<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Cliente__IR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Cliente__IR))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_entidade_Mae = New System.Windows.Forms.TextBox()
        Me.Txt_Nome_Entidade = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodEntidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Email = New System.Windows.Forms.TextBox()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Txt_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Telefone = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(1, -62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 10118
        Me.Label11.Text = "Entidade Mãe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1, -21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 10110
        Me.Label4.Text = "Filiais"
        '
        'Txt_entidade_Mae
        '
        Me.Txt_entidade_Mae.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_entidade_Mae.Enabled = False
        Me.Txt_entidade_Mae.Location = New System.Drawing.Point(4, -44)
        Me.Txt_entidade_Mae.MaxLength = 6
        Me.Txt_entidade_Mae.Name = "Txt_entidade_Mae"
        Me.Txt_entidade_Mae.Size = New System.Drawing.Size(72, 20)
        Me.Txt_entidade_Mae.TabIndex = 10105
        Me.Txt_entidade_Mae.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Nome_Entidade
        '
        Me.Txt_Nome_Entidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Nome_Entidade.Enabled = False
        Me.Txt_Nome_Entidade.Location = New System.Drawing.Point(4, -85)
        Me.Txt_Nome_Entidade.MaxLength = 55
        Me.Txt_Nome_Entidade.Name = "Txt_Nome_Entidade"
        Me.Txt_Nome_Entidade.Size = New System.Drawing.Size(272, 20)
        Me.Txt_Nome_Entidade.TabIndex = 10104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(1, -103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 10102
        Me.Label1.Text = "Nome da Entidade:"
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Location = New System.Drawing.Point(4, -126)
        Me.txtCodEntidade.MaxLength = 6
        Me.txtCodEntidade.Name = "txtCodEntidade"
        Me.txtCodEntidade.Size = New System.Drawing.Size(55, 20)
        Me.txtCodEntidade.TabIndex = 10103
        Me.txtCodEntidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1, -144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 10101
        Me.Label3.Text = "Código da Entidade:"
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbInform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbInform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbInform.Location = New System.Drawing.Point(6, 198)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(27, 15)
        Me.lbInform.TabIndex = 10138
        Me.lbInform.Text = "Inf."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(1, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 10137
        Me.Label2.Text = "E-Mail:"
        '
        'Txt_Email
        '
        Me.Txt_Email.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Email.Enabled = False
        Me.Txt_Email.Location = New System.Drawing.Point(4, 106)
        Me.Txt_Email.MaxLength = 149
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(272, 20)
        Me.Txt_Email.TabIndex = 3
        '
        'Txt_Nome
        '
        Me.Txt_Nome.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Nome.Enabled = False
        Me.Txt_Nome.Location = New System.Drawing.Point(4, 65)
        Me.Txt_Nome.MaxLength = 55
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(272, 20)
        Me.Txt_Nome.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(1, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 10121
        Me.Label15.Text = "Nome do Cliente:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(3, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 15)
        Me.Label16.TabIndex = 10120
        Me.Label16.Text = "CPF do Cliente:"
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalvar.Location = New System.Drawing.Point(30, 229)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 4
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
        Me.btnLimpar.Location = New System.Drawing.Point(104, 229)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 10135
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Txt_CPF
        '
        Me.Txt_CPF.Location = New System.Drawing.Point(6, 24)
        Me.Txt_CPF.Mask = "000,000,000-00"
        Me.Txt_CPF.Name = "Txt_CPF"
        Me.Txt_CPF.Size = New System.Drawing.Size(86, 20)
        Me.Txt_CPF.TabIndex = 1
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.Color.Black
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEditar.Location = New System.Drawing.Point(183, 229)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(68, 58)
        Me.btnEditar.TabIndex = 10119
        Me.btnEditar.Text = "&Editar"
        Me.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(3, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 15)
        Me.Label5.TabIndex = 10139
        Me.Label5.Text = "Celular:"
        '
        'Txt_Telefone
        '
        Me.Txt_Telefone.Enabled = False
        Me.Txt_Telefone.Location = New System.Drawing.Point(3, 147)
        Me.Txt_Telefone.Mask = "(00) 00000-0000"
        Me.Txt_Telefone.Name = "Txt_Telefone"
        Me.Txt_Telefone.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Telefone.TabIndex = 10140
        '
        'Fm_Cadastro_Cliente__IR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 299)
        Me.Controls.Add(Me.Txt_Telefone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_CPF)
        Me.Controls.Add(Me.lbInform)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Txt_Nome)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_entidade_Mae)
        Me.Controls.Add(Me.Txt_Nome_Entidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodEntidade)
        Me.Controls.Add(Me.Label3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_Cadastro_Cliente__IR"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Cliente IR Aluguel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_entidade_Mae As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nome_Entidade As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Email As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Txt_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Telefone As MaskedTextBox
End Class
