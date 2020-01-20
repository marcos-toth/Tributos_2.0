<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Usuario
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
        Dim CPFClientesLabel As System.Windows.Forms.Label
        Dim ContaCorrenteClientePJLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim NomeClientePJLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Usuario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.Cb_NomeNivel = New System.Windows.Forms.ComboBox()
        Me.txtNivel = New System.Windows.Forms.ComboBox()
        Me.Cbo_TrocaSenha = New System.Windows.Forms.ComboBox()
        Me.Cbo_EntidadeLogada = New System.Windows.Forms.ComboBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtCPF = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeCompleto = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtSenha2 = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.lbInf = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        CPFClientesLabel = New System.Windows.Forms.Label()
        ContaCorrenteClientePJLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        NomeClientePJLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G_Cadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPFClientesLabel
        '
        CPFClientesLabel.AutoSize = True
        CPFClientesLabel.BackColor = System.Drawing.Color.Transparent
        CPFClientesLabel.Location = New System.Drawing.Point(98, 56)
        CPFClientesLabel.Name = "CPFClientesLabel"
        CPFClientesLabel.Size = New System.Drawing.Size(30, 13)
        CPFClientesLabel.TabIndex = 66
        CPFClientesLabel.Text = "CPF:"
        CPFClientesLabel.UseWaitCursor = True
        '
        'ContaCorrenteClientePJLabel
        '
        ContaCorrenteClientePJLabel.AutoSize = True
        ContaCorrenteClientePJLabel.BackColor = System.Drawing.Color.Transparent
        ContaCorrenteClientePJLabel.Location = New System.Drawing.Point(92, 136)
        ContaCorrenteClientePJLabel.Name = "ContaCorrenteClientePJLabel"
        ContaCorrenteClientePJLabel.Size = New System.Drawing.Size(41, 13)
        ContaCorrenteClientePJLabel.TabIndex = 65
        ContaCorrenteClientePJLabel.Text = "Senha:"
        ContaCorrenteClientePJLabel.UseWaitCursor = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(46, 78)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(85, 13)
        Label3.TabIndex = 77
        Label3.Text = "Nome Comlpeto:"
        Label3.UseWaitCursor = True
        '
        'NomeClientePJLabel
        '
        NomeClientePJLabel.AutoSize = True
        NomeClientePJLabel.BackColor = System.Drawing.Color.Transparent
        NomeClientePJLabel.Location = New System.Drawing.Point(58, 106)
        NomeClientePJLabel.Name = "NomeClientePJLabel"
        NomeClientePJLabel.Size = New System.Drawing.Size(77, 13)
        NomeClientePJLabel.TabIndex = 64
        NomeClientePJLabel.Text = "Nome Usuário:"
        NomeClientePJLabel.UseWaitCursor = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(102, 189)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(34, 13)
        Label2.TabIndex = 75
        Label2.Text = "Nivel:"
        Label2.UseWaitCursor = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(17, 162)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(118, 13)
        Label4.TabIndex = 73
        Label4.Text = "Confirmação da Senha:"
        Label4.UseWaitCursor = True
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(34, 220)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(99, 13)
        Label5.TabIndex = 79
        Label5.Text = "Acesso a Entidade:"
        Label5.UseWaitCursor = True
        AddHandler Label5.Click, AddressOf Me.Label5_Click
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Location = New System.Drawing.Point(57, 247)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 79
        Label6.Text = "Troca Senha:"
        Label6.UseWaitCursor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(37, 66)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10075
        Me.PictureBox1.TabStop = False
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.Cb_NomeNivel)
        Me.G_Cadastro.Controls.Add(Me.txtNivel)
        Me.G_Cadastro.Controls.Add(Me.Cbo_TrocaSenha)
        Me.G_Cadastro.Controls.Add(Label6)
        Me.G_Cadastro.Controls.Add(Me.Cbo_EntidadeLogada)
        Me.G_Cadastro.Controls.Add(Label5)
        Me.G_Cadastro.Controls.Add(Me.btnLimpar)
        Me.G_Cadastro.Controls.Add(Me.txtCPF)
        Me.G_Cadastro.Controls.Add(CPFClientesLabel)
        Me.G_Cadastro.Controls.Add(Me.txtNomeCompleto)
        Me.G_Cadastro.Controls.Add(ContaCorrenteClientePJLabel)
        Me.G_Cadastro.Controls.Add(Label3)
        Me.G_Cadastro.Controls.Add(Me.txtNome)
        Me.G_Cadastro.Controls.Add(Label2)
        Me.G_Cadastro.Controls.Add(Me.txtSenha)
        Me.G_Cadastro.Controls.Add(Me.txtSenha2)
        Me.G_Cadastro.Controls.Add(Me.btnSalvar)
        Me.G_Cadastro.Controls.Add(Label4)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.lbInf)
        Me.G_Cadastro.Controls.Add(Me.btnSair)
        Me.G_Cadastro.Controls.Add(NomeClientePJLabel)
        Me.G_Cadastro.Location = New System.Drawing.Point(275, 17)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(444, 365)
        Me.G_Cadastro.TabIndex = 10081
        Me.G_Cadastro.TabStop = False
        Me.G_Cadastro.Text = "Cadastro de Usuário"
        '
        'Cb_NomeNivel
        '
        Me.Cb_NomeNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_NomeNivel.FormattingEnabled = True
        Me.Cb_NomeNivel.Items.AddRange(New Object() {"1 - Acesso Total", "2 - Acesso Total Menos Cadastro Usuários", "3 - Somente Relatório"})
        Me.Cb_NomeNivel.Location = New System.Drawing.Point(135, 186)
        Me.Cb_NomeNivel.Name = "Cb_NomeNivel"
        Me.Cb_NomeNivel.Size = New System.Drawing.Size(227, 21)
        Me.Cb_NomeNivel.TabIndex = 6
        '
        'txtNivel
        '
        Me.txtNivel.FormattingEnabled = True
        Me.txtNivel.Items.AddRange(New Object() {"1", "2", "3"})
        Me.txtNivel.Location = New System.Drawing.Point(6, 338)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(30, 21)
        Me.txtNivel.TabIndex = 99
        Me.txtNivel.Text = "2"
        Me.txtNivel.Visible = False
        '
        'Cbo_TrocaSenha
        '
        Me.Cbo_TrocaSenha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_TrocaSenha.FormattingEnabled = True
        Me.Cbo_TrocaSenha.Items.AddRange(New Object() {"S", "N"})
        Me.Cbo_TrocaSenha.Location = New System.Drawing.Point(135, 239)
        Me.Cbo_TrocaSenha.Name = "Cbo_TrocaSenha"
        Me.Cbo_TrocaSenha.Size = New System.Drawing.Size(30, 21)
        Me.Cbo_TrocaSenha.TabIndex = 8
        '
        'Cbo_EntidadeLogada
        '
        Me.Cbo_EntidadeLogada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_EntidadeLogada.Enabled = False
        Me.Cbo_EntidadeLogada.FormattingEnabled = True
        Me.Cbo_EntidadeLogada.Location = New System.Drawing.Point(135, 212)
        Me.Cbo_EntidadeLogada.Name = "Cbo_EntidadeLogada"
        Me.Cbo_EntidadeLogada.Size = New System.Drawing.Size(98, 21)
        Me.Cbo_EntidadeLogada.TabIndex = 7
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpar.Location = New System.Drawing.Point(257, 294)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 68
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'txtCPF
        '
        Me.txtCPF.Location = New System.Drawing.Point(134, 49)
        Me.txtCPF.Mask = "000,000,000-00"
        Me.txtCPF.Name = "txtCPF"
        Me.txtCPF.Size = New System.Drawing.Size(87, 20)
        Me.txtCPF.TabIndex = 1
        '
        'txtNomeCompleto
        '
        Me.txtNomeCompleto.Location = New System.Drawing.Point(134, 75)
        Me.txtNomeCompleto.MaxLength = 90
        Me.txtNomeCompleto.Name = "txtNomeCompleto"
        Me.txtNomeCompleto.Size = New System.Drawing.Size(290, 20)
        Me.txtNomeCompleto.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(134, 101)
        Me.txtNome.MaxLength = 45
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(99, 20)
        Me.txtNome.TabIndex = 3
        Me.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(134, 129)
        Me.txtSenha.MaxLength = 15
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(75, 20)
        Me.txtSenha.TabIndex = 4
        Me.txtSenha.Text = "iasd"
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSenha2
        '
        Me.txtSenha2.AcceptsReturn = True
        Me.txtSenha2.Location = New System.Drawing.Point(134, 155)
        Me.txtSenha2.MaxLength = 15
        Me.txtSenha2.Name = "txtSenha2"
        Me.txtSenha2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha2.Size = New System.Drawing.Size(75, 20)
        Me.txtSenha2.TabIndex = 5
        Me.txtSenha2.Text = "iasd"
        Me.txtSenha2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.Location = New System.Drawing.Point(83, 294)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 9
        Me.btnSalvar.Text = "&Inserir"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnDeletar
        '
        Me.btnDeletar.BackColor = System.Drawing.Color.Transparent
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletar.ForeColor = System.Drawing.Color.Black
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeletar.Location = New System.Drawing.Point(170, 294)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(68, 58)
        Me.btnDeletar.TabIndex = 69
        Me.btnDeletar.Text = "&Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'lbInf
        '
        Me.lbInf.AutoSize = True
        Me.lbInf.BackColor = System.Drawing.Color.DarkOrange
        Me.lbInf.Location = New System.Drawing.Point(136, 275)
        Me.lbInf.Name = "lbInf"
        Me.lbInf.Size = New System.Drawing.Size(0, 13)
        Me.lbInf.TabIndex = 71
        Me.lbInf.UseWaitCursor = True
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSair.Location = New System.Drawing.Point(346, 294)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(68, 58)
        Me.btnSair.TabIndex = 70
        Me.btnSair.Text = "Sai&r"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'Fm_Cadastro_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(743, 404)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Cadastro_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casastro de Usuário"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G_Cadastro.ResumeLayout(False)
        Me.G_Cadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtCPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNomeCompleto As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents lbInf As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents Cbo_EntidadeLogada As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_TrocaSenha As System.Windows.Forms.ComboBox
    Friend WithEvents txtNivel As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_NomeNivel As System.Windows.Forms.ComboBox
End Class
