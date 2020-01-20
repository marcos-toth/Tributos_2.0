<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Funcao
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
        Dim Label5 As System.Windows.Forms.Label
        Dim ContaCorrenteClientePJLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim NomeClientePJLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Funcao))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LbD = New System.Windows.Forms.Label()
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.RB_Nao = New System.Windows.Forms.RadioButton()
        Me.RB_Sim = New System.Windows.Forms.RadioButton()
        Me.TxtData = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeCompleto = New System.Windows.Forms.TextBox()
        Me.Lb_NomeEntidade = New System.Windows.Forms.Label()
        Me.Txt_CodEntidade = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_FoneCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_FoneComercial = New System.Windows.Forms.MaskedTextBox()
        Me.Cb_Funcao = New System.Windows.Forms.ComboBox()
        Me.Cbo_Campo = New System.Windows.Forms.ComboBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Txt_email = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.lbInf = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.DG_Depositos = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Label5 = New System.Windows.Forms.Label()
        ContaCorrenteClientePJLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        NomeClientePJLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Me.G_Cadastro.SuspendLayout()
        CType(Me.DG_Depositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Location = New System.Drawing.Point(74, 95)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(43, 13)
        Label5.TabIndex = 79
        Label5.Text = "Campo:"
        Label5.UseWaitCursor = True
        '
        'ContaCorrenteClientePJLabel
        '
        ContaCorrenteClientePJLabel.AutoSize = True
        ContaCorrenteClientePJLabel.BackColor = System.Drawing.Color.Transparent
        ContaCorrenteClientePJLabel.Location = New System.Drawing.Point(16, 147)
        ContaCorrenteClientePJLabel.Name = "ContaCorrenteClientePJLabel"
        ContaCorrenteClientePJLabel.Size = New System.Drawing.Size(101, 13)
        ContaCorrenteClientePJLabel.TabIndex = 65
        ContaCorrenteClientePJLabel.Text = "Telefone Comercial:"
        ContaCorrenteClientePJLabel.UseWaitCursor = True
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.BackColor = System.Drawing.Color.Transparent
        Label3.Location = New System.Drawing.Point(32, 40)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(85, 13)
        Label3.TabIndex = 77
        Label3.Text = "Nome Comlpeto:"
        Label3.UseWaitCursor = True
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.BackColor = System.Drawing.Color.Transparent
        Label2.Location = New System.Drawing.Point(71, 67)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(46, 13)
        Label2.TabIndex = 75
        Label2.Text = "Função:"
        Label2.UseWaitCursor = True
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.Color.Transparent
        Label4.Location = New System.Drawing.Point(75, 173)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(42, 13)
        Label4.TabIndex = 73
        Label4.Text = "Celular:"
        Label4.UseWaitCursor = True
        '
        'NomeClientePJLabel
        '
        NomeClientePJLabel.AutoSize = True
        NomeClientePJLabel.BackColor = System.Drawing.Color.Transparent
        NomeClientePJLabel.Location = New System.Drawing.Point(80, 121)
        NomeClientePJLabel.Name = "NomeClientePJLabel"
        NomeClientePJLabel.Size = New System.Drawing.Size(37, 13)
        NomeClientePJLabel.TabIndex = 64
        NomeClientePJLabel.Text = "e-mail:"
        NomeClientePJLabel.UseWaitCursor = True
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Location = New System.Drawing.Point(29, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 13)
        Label1.TabIndex = 102
        Label1.Text = "Código Entidade:"
        Label1.UseWaitCursor = True
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.Transparent
        Label6.Location = New System.Drawing.Point(83, 200)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(34, 13)
        Label6.TabIndex = 107
        Label6.Text = "Ativo:"
        Label6.UseWaitCursor = True
        '
        'LbD
        '
        Me.LbD.AutoSize = True
        Me.LbD.BackColor = System.Drawing.Color.Transparent
        Me.LbD.Location = New System.Drawing.Point(16, 229)
        Me.LbD.Name = "LbD"
        Me.LbD.Size = New System.Drawing.Size(0, 13)
        Me.LbD.TabIndex = 109
        Me.LbD.UseWaitCursor = True
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.RB_Nao)
        Me.G_Cadastro.Controls.Add(Me.RB_Sim)
        Me.G_Cadastro.Controls.Add(Me.TxtData)
        Me.G_Cadastro.Controls.Add(Label6)
        Me.G_Cadastro.Controls.Add(Me.txtNomeCompleto)
        Me.G_Cadastro.Controls.Add(Me.Lb_NomeEntidade)
        Me.G_Cadastro.Controls.Add(Label1)
        Me.G_Cadastro.Controls.Add(Me.Txt_CodEntidade)
        Me.G_Cadastro.Controls.Add(Me.Txt_FoneCelular)
        Me.G_Cadastro.Controls.Add(Me.Txt_FoneComercial)
        Me.G_Cadastro.Controls.Add(Me.Cb_Funcao)
        Me.G_Cadastro.Controls.Add(Me.Cbo_Campo)
        Me.G_Cadastro.Controls.Add(Label5)
        Me.G_Cadastro.Controls.Add(Me.btnLimpar)
        Me.G_Cadastro.Controls.Add(ContaCorrenteClientePJLabel)
        Me.G_Cadastro.Controls.Add(Label3)
        Me.G_Cadastro.Controls.Add(Me.Txt_email)
        Me.G_Cadastro.Controls.Add(Label2)
        Me.G_Cadastro.Controls.Add(Me.btnSalvar)
        Me.G_Cadastro.Controls.Add(Label4)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.lbInf)
        Me.G_Cadastro.Controls.Add(Me.btnSair)
        Me.G_Cadastro.Controls.Add(NomeClientePJLabel)
        Me.G_Cadastro.Controls.Add(Me.LbD)
        Me.G_Cadastro.Location = New System.Drawing.Point(93, 12)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(416, 344)
        Me.G_Cadastro.TabIndex = 10083
        Me.G_Cadastro.TabStop = False
        '
        'RB_Nao
        '
        Me.RB_Nao.AutoSize = True
        Me.RB_Nao.Location = New System.Drawing.Point(174, 198)
        Me.RB_Nao.Name = "RB_Nao"
        Me.RB_Nao.Size = New System.Drawing.Size(45, 17)
        Me.RB_Nao.TabIndex = 111
        Me.RB_Nao.Text = "Não"
        Me.RB_Nao.UseVisualStyleBackColor = True
        '
        'RB_Sim
        '
        Me.RB_Sim.AutoSize = True
        Me.RB_Sim.Checked = True
        Me.RB_Sim.Location = New System.Drawing.Point(122, 198)
        Me.RB_Sim.Name = "RB_Sim"
        Me.RB_Sim.Size = New System.Drawing.Size(42, 17)
        Me.RB_Sim.TabIndex = 110
        Me.RB_Sim.TabStop = True
        Me.RB_Sim.Text = "Sim"
        Me.RB_Sim.UseVisualStyleBackColor = True
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(122, 225)
        Me.TxtData.Mask = "00/00/0000"
        Me.TxtData.Name = "TxtData"
        Me.TxtData.Size = New System.Drawing.Size(72, 20)
        Me.TxtData.TabIndex = 108
        Me.TxtData.ValidatingType = GetType(Date)
        Me.TxtData.Visible = False
        '
        'txtNomeCompleto
        '
        Me.txtNomeCompleto.Location = New System.Drawing.Point(122, 38)
        Me.txtNomeCompleto.MaxLength = 90
        Me.txtNomeCompleto.Name = "txtNomeCompleto"
        Me.txtNomeCompleto.Size = New System.Drawing.Size(290, 20)
        Me.txtNomeCompleto.TabIndex = 2
        '
        'Lb_NomeEntidade
        '
        Me.Lb_NomeEntidade.AutoSize = True
        Me.Lb_NomeEntidade.BackColor = System.Drawing.Color.Transparent
        Me.Lb_NomeEntidade.Location = New System.Drawing.Point(171, 16)
        Me.Lb_NomeEntidade.Name = "Lb_NomeEntidade"
        Me.Lb_NomeEntidade.Size = New System.Drawing.Size(80, 13)
        Me.Lb_NomeEntidade.TabIndex = 104
        Me.Lb_NomeEntidade.Text = "Nome Entidade"
        Me.Lb_NomeEntidade.UseWaitCursor = True
        '
        'Txt_CodEntidade
        '
        Me.Txt_CodEntidade.Location = New System.Drawing.Point(122, 11)
        Me.Txt_CodEntidade.Mask = "000000"
        Me.Txt_CodEntidade.Name = "Txt_CodEntidade"
        Me.Txt_CodEntidade.Size = New System.Drawing.Size(44, 20)
        Me.Txt_CodEntidade.TabIndex = 1
        '
        'Txt_FoneCelular
        '
        Me.Txt_FoneCelular.Location = New System.Drawing.Point(122, 170)
        Me.Txt_FoneCelular.Mask = "(99) 00000-0000"
        Me.Txt_FoneCelular.Name = "Txt_FoneCelular"
        Me.Txt_FoneCelular.Size = New System.Drawing.Size(90, 20)
        Me.Txt_FoneCelular.TabIndex = 7
        '
        'Txt_FoneComercial
        '
        Me.Txt_FoneComercial.Location = New System.Drawing.Point(122, 144)
        Me.Txt_FoneComercial.Mask = "(99) 0000-0000"
        Me.Txt_FoneComercial.Name = "Txt_FoneComercial"
        Me.Txt_FoneComercial.Size = New System.Drawing.Size(84, 20)
        Me.Txt_FoneComercial.TabIndex = 6
        '
        'Cb_Funcao
        '
        Me.Cb_Funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Funcao.FormattingEnabled = True
        Me.Cb_Funcao.Location = New System.Drawing.Point(122, 64)
        Me.Cb_Funcao.Name = "Cb_Funcao"
        Me.Cb_Funcao.Size = New System.Drawing.Size(216, 21)
        Me.Cb_Funcao.TabIndex = 3
        '
        'Cbo_Campo
        '
        Me.Cbo_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Campo.Enabled = False
        Me.Cbo_Campo.FormattingEnabled = True
        Me.Cbo_Campo.Items.AddRange(New Object() {"Cínica CEVISA", "Clínica São Roque", "Paulistana", "Paulista Sul", "Paulista Leste", "Paulista Central", "Paulista Oeste", "Paulista do Vale", "Paulista Sudoeste", "Paulista Sudeste", "HASP", "Reitoria", "UNASP SP", "UNASP EC", "UNASP HT", "UNASP Virtual"})
        Me.Cbo_Campo.Location = New System.Drawing.Point(122, 91)
        Me.Cbo_Campo.Name = "Cbo_Campo"
        Me.Cbo_Campo.Size = New System.Drawing.Size(138, 21)
        Me.Cbo_Campo.TabIndex = 4
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
        Me.btnLimpar.Location = New System.Drawing.Point(230, 278)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 68
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Txt_email
        '
        Me.Txt_email.Location = New System.Drawing.Point(122, 118)
        Me.Txt_email.MaxLength = 45
        Me.Txt_email.Name = "Txt_email"
        Me.Txt_email.Size = New System.Drawing.Size(186, 20)
        Me.Txt_email.TabIndex = 5
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
        Me.btnSalvar.Location = New System.Drawing.Point(56, 278)
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
        Me.btnDeletar.Enabled = False
        Me.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletar.ForeColor = System.Drawing.Color.Black
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeletar.Location = New System.Drawing.Point(143, 278)
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
        Me.lbInf.Location = New System.Drawing.Point(126, 256)
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
        Me.btnSair.Location = New System.Drawing.Point(320, 278)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(68, 58)
        Me.btnSair.TabIndex = 70
        Me.btnSair.Text = "Sai&r"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'DG_Depositos
        '
        Me.DG_Depositos.AllowUserToAddRows = False
        Me.DG_Depositos.AllowUserToDeleteRows = False
        Me.DG_Depositos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_Depositos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Depositos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Depositos.BackgroundColor = System.Drawing.Color.White
        Me.DG_Depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Depositos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Telefone})
        Me.DG_Depositos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG_Depositos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_Depositos.Location = New System.Drawing.Point(543, 19)
        Me.DG_Depositos.MultiSelect = False
        Me.DG_Depositos.Name = "DG_Depositos"
        Me.DG_Depositos.ReadOnly = True
        Me.DG_Depositos.RowHeadersVisible = False
        Me.DG_Depositos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Depositos.Size = New System.Drawing.Size(548, 337)
        Me.DG_Depositos.TabIndex = 10084
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "Entidade"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 60
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column4.HeaderText = "Função"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Telefone
        '
        Me.Telefone.HeaderText = "Telefone"
        Me.Telefone.Name = "Telefone"
        Me.Telefone.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10082
        Me.PictureBox1.TabStop = False
        '
        'Fm_Cadastro_Funcao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 358)
        Me.Controls.Add(Me.DG_Depositos)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Cadastro_Funcao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funções"
        Me.G_Cadastro.ResumeLayout(False)
        Me.G_Cadastro.PerformLayout()
        CType(Me.DG_Depositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Funcao As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_Campo As System.Windows.Forms.ComboBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Txt_email As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents lbInf As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents DG_Depositos As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_FoneCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txt_FoneComercial As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_CodEntidade As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lb_NomeEntidade As System.Windows.Forms.Label
    Friend WithEvents txtNomeCompleto As System.Windows.Forms.TextBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents RB_Nao As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Sim As System.Windows.Forms.RadioButton
    Friend WithEvents LbD As System.Windows.Forms.Label
End Class
