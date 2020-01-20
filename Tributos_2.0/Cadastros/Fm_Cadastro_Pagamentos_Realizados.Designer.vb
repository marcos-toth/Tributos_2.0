<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Pagamentos_Realizados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Pagamentos_Realizados))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.ChekBox_Periodo = New System.Windows.Forms.CheckBox()
        Me.RB_FGTS = New System.Windows.Forms.RadioButton()
        Me.Rb_INSS = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chek_Varios = New System.Windows.Forms.CheckBox()
        Me.Btn_Observacao = New System.Windows.Forms.Button()
        Me.Cb_Periodo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValorCorrigido = New System.Windows.Forms.TextBox()
        Me.TxtPago = New System.Windows.Forms.TextBox()
        Me.txtCodEntidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.LbNomeEntidade = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbCab = New System.Windows.Forms.Label()
        Me.Lb_Total = New System.Windows.Forms.Label()
        Me.DG_Cadastro = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.G_Cadastro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Cadastro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.ChekBox_Periodo)
        Me.G_Cadastro.Controls.Add(Me.RB_FGTS)
        Me.G_Cadastro.Controls.Add(Me.Rb_INSS)
        Me.G_Cadastro.Controls.Add(Me.Label5)
        Me.G_Cadastro.Controls.Add(Me.Chek_Varios)
        Me.G_Cadastro.Controls.Add(Me.Btn_Observacao)
        Me.G_Cadastro.Controls.Add(Me.Cb_Periodo)
        Me.G_Cadastro.Controls.Add(Me.Label7)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.Label6)
        Me.G_Cadastro.Controls.Add(Me.TxtValorCorrigido)
        Me.G_Cadastro.Controls.Add(Me.TxtPago)
        Me.G_Cadastro.Controls.Add(Me.txtCodEntidade)
        Me.G_Cadastro.Controls.Add(Me.Label2)
        Me.G_Cadastro.Controls.Add(Me.txtData)
        Me.G_Cadastro.Controls.Add(Me.Label3)
        Me.G_Cadastro.Controls.Add(Me.txtValor)
        Me.G_Cadastro.Controls.Add(Me.LbNomeEntidade)
        Me.G_Cadastro.Controls.Add(Me.btnSalvar)
        Me.G_Cadastro.Controls.Add(Me.lbInform)
        Me.G_Cadastro.Controls.Add(Me.btnLimpar)
        Me.G_Cadastro.Controls.Add(Me.Label4)
        Me.G_Cadastro.Controls.Add(Me.Label1)
        Me.G_Cadastro.ForeColor = System.Drawing.Color.Black
        Me.G_Cadastro.Location = New System.Drawing.Point(266, 37)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(480, 325)
        Me.G_Cadastro.TabIndex = 10080
        Me.G_Cadastro.TabStop = False
        Me.G_Cadastro.Text = "Cadastro"
        '
        'ChekBox_Periodo
        '
        Me.ChekBox_Periodo.AutoSize = True
        Me.ChekBox_Periodo.Location = New System.Drawing.Point(221, 79)
        Me.ChekBox_Periodo.Name = "ChekBox_Periodo"
        Me.ChekBox_Periodo.Size = New System.Drawing.Size(151, 17)
        Me.ChekBox_Periodo.TabIndex = 10092
        Me.ChekBox_Periodo.Text = "Libera Períodos Anteriores"
        Me.ChekBox_Periodo.UseVisualStyleBackColor = True
        '
        'RB_FGTS
        '
        Me.RB_FGTS.AutoSize = True
        Me.RB_FGTS.Location = New System.Drawing.Point(233, 20)
        Me.RB_FGTS.Name = "RB_FGTS"
        Me.RB_FGTS.Size = New System.Drawing.Size(53, 17)
        Me.RB_FGTS.TabIndex = 10082
        Me.RB_FGTS.TabStop = True
        Me.RB_FGTS.Text = "FGTS"
        Me.RB_FGTS.UseVisualStyleBackColor = True
        '
        'Rb_INSS
        '
        Me.Rb_INSS.AutoSize = True
        Me.Rb_INSS.Location = New System.Drawing.Point(292, 20)
        Me.Rb_INSS.Name = "Rb_INSS"
        Me.Rb_INSS.Size = New System.Drawing.Size(50, 17)
        Me.Rb_INSS.TabIndex = 10082
        Me.Rb_INSS.TabStop = True
        Me.Rb_INSS.Text = "INSS"
        Me.Rb_INSS.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(50, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 15)
        Me.Label5.TabIndex = 10081
        Me.Label5.Text = "Selecionar a Guia a Deduzir"
        '
        'Chek_Varios
        '
        Me.Chek_Varios.AutoSize = True
        Me.Chek_Varios.Enabled = False
        Me.Chek_Varios.Location = New System.Drawing.Point(254, 164)
        Me.Chek_Varios.Name = "Chek_Varios"
        Me.Chek_Varios.Size = New System.Drawing.Size(118, 17)
        Me.Chek_Varios.TabIndex = 10078
        Me.Chek_Varios.Text = "Somar Várias Guias"
        Me.Chek_Varios.UseVisualStyleBackColor = True
        '
        'Btn_Observacao
        '
        Me.Btn_Observacao.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Observacao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Observacao.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Btn_Observacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Observacao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.Btn_Observacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Observacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Observacao.ForeColor = System.Drawing.Color.Black
        Me.Btn_Observacao.Image = CType(resources.GetObject("Btn_Observacao.Image"), System.Drawing.Image)
        Me.Btn_Observacao.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Observacao.Location = New System.Drawing.Point(283, 252)
        Me.Btn_Observacao.Name = "Btn_Observacao"
        Me.Btn_Observacao.Size = New System.Drawing.Size(169, 58)
        Me.Btn_Observacao.TabIndex = 10077
        Me.Btn_Observacao.Text = "&Cadastro Observações"
        Me.Btn_Observacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Observacao.UseVisualStyleBackColor = False
        '
        'Cb_Periodo
        '
        Me.Cb_Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Periodo.FormattingEnabled = True
        Me.Cb_Periodo.Location = New System.Drawing.Point(150, 75)
        Me.Cb_Periodo.MaxDropDownItems = 12
        Me.Cb_Periodo.Name = "Cb_Periodo"
        Me.Cb_Periodo.Size = New System.Drawing.Size(66, 21)
        Me.Cb_Periodo.TabIndex = 10075
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(4, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 15)
        Me.Label7.TabIndex = 10076
        Me.Label7.Text = "Período de Competência:"
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
        Me.btnDeletar.Location = New System.Drawing.Point(194, 252)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(68, 58)
        Me.btnDeletar.TabIndex = 10069
        Me.btnDeletar.Text = "&Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(80, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 10068
        Me.Label6.Text = "Valor Pago:"
        '
        'TxtValorCorrigido
        '
        Me.TxtValorCorrigido.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.TxtValorCorrigido.Enabled = False
        Me.TxtValorCorrigido.Location = New System.Drawing.Point(150, 191)
        Me.TxtValorCorrigido.Name = "TxtValorCorrigido"
        Me.TxtValorCorrigido.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorCorrigido.TabIndex = 10067
        Me.TxtValorCorrigido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPago
        '
        Me.TxtPago.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.TxtPago.Enabled = False
        Me.TxtPago.Location = New System.Drawing.Point(150, 162)
        Me.TxtPago.Name = "TxtPago"
        Me.TxtPago.Size = New System.Drawing.Size(100, 20)
        Me.TxtPago.TabIndex = 10065
        Me.TxtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Enabled = False
        Me.txtCodEntidade.Location = New System.Drawing.Point(150, 105)
        Me.txtCodEntidade.MaxLength = 6
        Me.txtCodEntidade.Name = "txtCodEntidade"
        Me.txtCodEntidade.Size = New System.Drawing.Size(50, 20)
        Me.txtCodEntidade.TabIndex = 2
        Me.txtCodEntidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(45, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 10053
        Me.Label2.Text = "Data do Cadastro:"
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(150, 49)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(66, 20)
        Me.txtData.TabIndex = 0
        Me.txtData.ValidatingType = GetType(Date)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(91, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 10055
        Me.Label3.Text = "Entidade:"
        '
        'txtValor
        '
        Me.txtValor.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(150, 134)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(100, 20)
        Me.txtValor.TabIndex = 3
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LbNomeEntidade
        '
        Me.LbNomeEntidade.AutoSize = True
        Me.LbNomeEntidade.BackColor = System.Drawing.Color.Transparent
        Me.LbNomeEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LbNomeEntidade.ForeColor = System.Drawing.Color.Black
        Me.LbNomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbNomeEntidade.Location = New System.Drawing.Point(205, 107)
        Me.LbNomeEntidade.Name = "LbNomeEntidade"
        Me.LbNomeEntidade.Size = New System.Drawing.Size(238, 15)
        Me.LbNomeEntidade.TabIndex = 10063
        Me.LbNomeEntidade.Text = "Preencher Somente o Código da Entidade"
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
        Me.btnSalvar.Location = New System.Drawing.Point(46, 252)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 4
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbInform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbInform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbInform.Location = New System.Drawing.Point(45, 234)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(27, 15)
        Me.lbInform.TabIndex = 10062
        Me.lbInform.Text = "Inf."
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
        Me.btnLimpar.Location = New System.Drawing.Point(120, 252)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(86, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 10057
        Me.Label4.Text = "Valor APS:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(49, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 15)
        Me.Label1.TabIndex = 10066
        Me.Label1.Text = "Valor a Recolher:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(28, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10079
        Me.PictureBox1.TabStop = False
        '
        'LbCab
        '
        Me.LbCab.AutoSize = True
        Me.LbCab.BackColor = System.Drawing.Color.Transparent
        Me.LbCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LbCab.ForeColor = System.Drawing.Color.Black
        Me.LbCab.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCab.Location = New System.Drawing.Point(270, 9)
        Me.LbCab.Name = "LbCab"
        Me.LbCab.Size = New System.Drawing.Size(478, 25)
        Me.LbCab.TabIndex = 10078
        Me.LbCab.Text = "Guias Recolhidas na Entidade Local - ADRA"
        '
        'Lb_Total
        '
        Me.Lb_Total.BackColor = System.Drawing.Color.Silver
        Me.Lb_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lb_Total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_Total.Location = New System.Drawing.Point(269, 365)
        Me.Lb_Total.Name = "Lb_Total"
        Me.Lb_Total.Size = New System.Drawing.Size(477, 20)
        Me.Lb_Total.TabIndex = 10098
        Me.Lb_Total.Text = "Soma Valores Cadastrados R$ "
        Me.Lb_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DG_Cadastro
        '
        Me.DG_Cadastro.AllowUserToAddRows = False
        Me.DG_Cadastro.AllowUserToDeleteRows = False
        Me.DG_Cadastro.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_Cadastro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Cadastro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Cadastro.BackgroundColor = System.Drawing.Color.White
        Me.DG_Cadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Cadastro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5})
        Me.DG_Cadastro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG_Cadastro.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_Cadastro.Location = New System.Drawing.Point(270, 388)
        Me.DG_Cadastro.MultiSelect = False
        Me.DG_Cadastro.Name = "DG_Cadastro"
        Me.DG_Cadastro.ReadOnly = True
        Me.DG_Cadastro.RowHeadersVisible = False
        Me.DG_Cadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Cadastro.Size = New System.Drawing.Size(476, 104)
        Me.DG_Cadastro.TabIndex = 10097
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Período"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.ToolTipText = "Período do Recolhimento"
        Me.Column1.Width = 80
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Cod. Entidade"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "#,##0.00"
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "INSS Pago no Campo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 140
        '
        'Column5
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "#,##0.00"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column5.HeaderText = "FGTS Pago no Campo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 140
        '
        'Fm_Cadastro_Pagamentos_Realizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(789, 531)
        Me.Controls.Add(Me.Lb_Total)
        Me.Controls.Add(Me.DG_Cadastro)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbCab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Cadastro_Pagamentos_Realizados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Pagamentos Realizados No Campo Local"
        Me.G_Cadastro.ResumeLayout(False)
        Me.G_Cadastro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Cadastro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents Chek_Varios As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_Observacao As System.Windows.Forms.Button
    Friend WithEvents Cb_Periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtValorCorrigido As System.Windows.Forms.TextBox
    Friend WithEvents TxtPago As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents LbNomeEntidade As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbCab As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RB_FGTS As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_INSS As System.Windows.Forms.RadioButton
    Friend WithEvents Lb_Total As System.Windows.Forms.Label
    Friend WithEvents DG_Cadastro As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Protected WithEvents ChekBox_Periodo As System.Windows.Forms.CheckBox
End Class
