﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_cadastro_IR_Recisao_Aluguel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_cadastro_IR_Recisao_Aluguel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Txt_Data_Deposito = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChekBox_Periodo = New System.Windows.Forms.CheckBox()
        Me.Cb_Periodo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_vBase = New System.Windows.Forms.TextBox()
        Me.Rb_PJ = New System.Windows.Forms.RadioButton()
        Me.Rb_PF = New System.Windows.Forms.RadioButton()
        Me.DG_IR = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Txt_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodEntidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lb_Total = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LbCab = New System.Windows.Forms.Label()
        Me.LbNomeEntidade = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Txt_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.Lb_CPF = New System.Windows.Forms.Label()
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_Justificativa = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DG_IR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.G_Cadastro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_Data_Deposito
        '
        Me.Txt_Data_Deposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Txt_Data_Deposito.Location = New System.Drawing.Point(163, 79)
        Me.Txt_Data_Deposito.Name = "Txt_Data_Deposito"
        Me.Txt_Data_Deposito.Size = New System.Drawing.Size(82, 20)
        Me.Txt_Data_Deposito.TabIndex = 10091
        Me.Txt_Data_Deposito.Value = New Date(2019, 3, 7, 19, 8, 58, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(41, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 15)
        Me.Label9.TabIndex = 10090
        Me.Label9.Text = "Data do Pagamento:"
        '
        'ChekBox_Periodo
        '
        Me.ChekBox_Periodo.AutoSize = True
        Me.ChekBox_Periodo.Location = New System.Drawing.Point(234, 108)
        Me.ChekBox_Periodo.Name = "ChekBox_Periodo"
        Me.ChekBox_Periodo.Size = New System.Drawing.Size(151, 17)
        Me.ChekBox_Periodo.TabIndex = 10086
        Me.ChekBox_Periodo.Text = "Libera Períodos Anteriores"
        Me.ChekBox_Periodo.UseVisualStyleBackColor = True
        '
        'Cb_Periodo
        '
        Me.Cb_Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Periodo.FormattingEnabled = True
        Me.Cb_Periodo.Location = New System.Drawing.Point(163, 106)
        Me.Cb_Periodo.MaxDropDownItems = 12
        Me.Cb_Periodo.Name = "Cb_Periodo"
        Me.Cb_Periodo.Size = New System.Drawing.Size(66, 21)
        Me.Cb_Periodo.TabIndex = 10073
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(9, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 15)
        Me.Label6.TabIndex = 10074
        Me.Label6.Text = "Ano e Mês do Pagamento:"
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
        Me.btnDeletar.Location = New System.Drawing.Point(417, 223)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(68, 58)
        Me.btnDeletar.TabIndex = 10072
        Me.btnDeletar.Text = "&Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(90, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 10071
        Me.Label1.Text = "Valor Pago:"
        '
        'Txt_vBase
        '
        Me.Txt_vBase.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.Txt_vBase.Location = New System.Drawing.Point(162, 221)
        Me.Txt_vBase.Name = "Txt_vBase"
        Me.Txt_vBase.Size = New System.Drawing.Size(96, 20)
        Me.Txt_vBase.TabIndex = 5
        Me.Txt_vBase.Text = "0,00"
        Me.Txt_vBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Rb_PJ
        '
        Me.Rb_PJ.AutoSize = True
        Me.Rb_PJ.Location = New System.Drawing.Point(157, 19)
        Me.Rb_PJ.Name = "Rb_PJ"
        Me.Rb_PJ.Size = New System.Drawing.Size(101, 17)
        Me.Rb_PJ.TabIndex = 10069
        Me.Rb_PJ.Text = "Pessoa Jurídica"
        Me.Rb_PJ.UseVisualStyleBackColor = True
        '
        'Rb_PF
        '
        Me.Rb_PF.AutoSize = True
        Me.Rb_PF.Checked = True
        Me.Rb_PF.Location = New System.Drawing.Point(43, 19)
        Me.Rb_PF.Name = "Rb_PF"
        Me.Rb_PF.Size = New System.Drawing.Size(92, 17)
        Me.Rb_PF.TabIndex = 10069
        Me.Rb_PF.TabStop = True
        Me.Rb_PF.Text = "Pessoa Fisíca"
        Me.Rb_PF.UseVisualStyleBackColor = True
        '
        'DG_IR
        '
        Me.DG_IR.AllowUserToAddRows = False
        Me.DG_IR.AllowUserToDeleteRows = False
        Me.DG_IR.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_IR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_IR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_IR.BackgroundColor = System.Drawing.Color.White
        Me.DG_IR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_IR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DG_IR.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DG_IR.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DG_IR.Location = New System.Drawing.Point(15, 484)
        Me.DG_IR.MultiSelect = False
        Me.DG_IR.Name = "DG_IR"
        Me.DG_IR.ReadOnly = True
        Me.DG_IR.RowHeadersVisible = False
        Me.DG_IR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_IR.Size = New System.Drawing.Size(730, 168)
        Me.DG_IR.TabIndex = 10095
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "dd/MM/yyyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Recolhimento"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.ToolTipText = "Data do Depósito"
        '
        'Column2
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Mês"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 50
        '
        'Column3
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Nome Beneficíario"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.FillWeight = 120.0!
        Me.Column4.HeaderText = "CPF / CNPJ"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "#,##0.00"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column5.HeaderText = "Valor Base"
        Me.Column5.MaxInputLength = 13
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column6.HeaderText = "Valor IR"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 80
        '
        'Txt_CPF
        '
        Me.Txt_CPF.Location = New System.Drawing.Point(163, 163)
        Me.Txt_CPF.Mask = "000,000,000-00"
        Me.Txt_CPF.Name = "Txt_CPF"
        Me.Txt_CPF.Size = New System.Drawing.Size(86, 20)
        Me.Txt_CPF.TabIndex = 3
        '
        'Txt_Nome
        '
        Me.Txt_Nome.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Nome.Location = New System.Drawing.Point(162, 192)
        Me.Txt_Nome.MaxLength = 50
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(323, 20)
        Me.Txt_Nome.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(32, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 15)
        Me.Label7.TabIndex = 10065
        Me.Label7.Text = "Nome do Beneficiário:"
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Location = New System.Drawing.Point(163, 135)
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
        Me.Label2.Location = New System.Drawing.Point(56, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 10053
        Me.Label2.Text = "Data do Cadastro:"
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(163, 48)
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
        Me.Label3.Location = New System.Drawing.Point(102, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 10055
        Me.Label3.Text = "Entidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(91, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 10057
        Me.Label4.Text = "Valor do IR:"
        '
        'Lb_Total
        '
        Me.Lb_Total.BackColor = System.Drawing.Color.Silver
        Me.Lb_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lb_Total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_Total.Location = New System.Drawing.Point(331, 461)
        Me.Lb_Total.Name = "Lb_Total"
        Me.Lb_Total.Size = New System.Drawing.Size(414, 20)
        Me.Lb_Total.TabIndex = 10096
        Me.Lb_Total.Text = "O Valor do IR Para ser Recolhido é R$ 25.598,88"
        Me.Lb_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtValor
        '
        Me.txtValor.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(162, 253)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(95, 20)
        Me.txtValor.TabIndex = 9999
        Me.txtValor.Text = "0,00"
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(111, 38)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(101, 42)
        Me.GroupBox4.TabIndex = 10094
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Base de Cálculo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(32, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 15)
        Me.Label8.TabIndex = 10094
        Me.Label8.Text = "15%"
        '
        'LbCab
        '
        Me.LbCab.AutoSize = True
        Me.LbCab.BackColor = System.Drawing.Color.Transparent
        Me.LbCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LbCab.ForeColor = System.Drawing.Color.Black
        Me.LbCab.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCab.Location = New System.Drawing.Point(106, 4)
        Me.LbCab.Name = "LbCab"
        Me.LbCab.Size = New System.Drawing.Size(548, 25)
        Me.LbCab.TabIndex = 10091
        Me.LbCab.Text = "Cadastro dos Valores de IR Sobre Recisão Aluguel"
        '
        'LbNomeEntidade
        '
        Me.LbNomeEntidade.AutoSize = True
        Me.LbNomeEntidade.BackColor = System.Drawing.Color.Transparent
        Me.LbNomeEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LbNomeEntidade.ForeColor = System.Drawing.Color.Black
        Me.LbNomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbNomeEntidade.Location = New System.Drawing.Point(219, 138)
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
        Me.btnSalvar.Location = New System.Drawing.Point(269, 223)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 7
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
        Me.lbInform.Location = New System.Drawing.Point(162, 283)
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
        Me.btnLimpar.Location = New System.Drawing.Point(343, 223)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 1000
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Txt_CNPJ
        '
        Me.Txt_CNPJ.Location = New System.Drawing.Point(162, 163)
        Me.Txt_CNPJ.Mask = "00,000,000/0000-00"
        Me.Txt_CNPJ.Name = "Txt_CNPJ"
        Me.Txt_CNPJ.Size = New System.Drawing.Size(109, 20)
        Me.Txt_CNPJ.TabIndex = 3
        Me.Txt_CNPJ.Visible = False
        '
        'Lb_CPF
        '
        Me.Lb_CPF.AutoSize = True
        Me.Lb_CPF.BackColor = System.Drawing.Color.Transparent
        Me.Lb_CPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Lb_CPF.ForeColor = System.Drawing.Color.Black
        Me.Lb_CPF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lb_CPF.Location = New System.Drawing.Point(128, 165)
        Me.Lb_CPF.Name = "Lb_CPF"
        Me.Lb_CPF.Size = New System.Drawing.Size(33, 15)
        Me.Lb_CPF.TabIndex = 10068
        Me.Lb_CPF.Text = "CPF:"
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.TextBox1)
        Me.G_Cadastro.Controls.Add(Me.Label5)
        Me.G_Cadastro.Controls.Add(Me.Txt_Justificativa)
        Me.G_Cadastro.Controls.Add(Me.Txt_Data_Deposito)
        Me.G_Cadastro.Controls.Add(Me.Label9)
        Me.G_Cadastro.Controls.Add(Me.ChekBox_Periodo)
        Me.G_Cadastro.Controls.Add(Me.Cb_Periodo)
        Me.G_Cadastro.Controls.Add(Me.Label6)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.Label1)
        Me.G_Cadastro.Controls.Add(Me.Txt_vBase)
        Me.G_Cadastro.Controls.Add(Me.Rb_PJ)
        Me.G_Cadastro.Controls.Add(Me.Rb_PF)
        Me.G_Cadastro.Controls.Add(Me.Txt_CPF)
        Me.G_Cadastro.Controls.Add(Me.Txt_Nome)
        Me.G_Cadastro.Controls.Add(Me.Label7)
        Me.G_Cadastro.Controls.Add(Me.txtCodEntidade)
        Me.G_Cadastro.Controls.Add(Me.Label2)
        Me.G_Cadastro.Controls.Add(Me.txtData)
        Me.G_Cadastro.Controls.Add(Me.Label3)
        Me.G_Cadastro.Controls.Add(Me.Label4)
        Me.G_Cadastro.Controls.Add(Me.txtValor)
        Me.G_Cadastro.Controls.Add(Me.LbNomeEntidade)
        Me.G_Cadastro.Controls.Add(Me.btnSalvar)
        Me.G_Cadastro.Controls.Add(Me.lbInform)
        Me.G_Cadastro.Controls.Add(Me.btnLimpar)
        Me.G_Cadastro.Controls.Add(Me.Txt_CNPJ)
        Me.G_Cadastro.Controls.Add(Me.Lb_CPF)
        Me.G_Cadastro.ForeColor = System.Drawing.Color.Black
        Me.G_Cadastro.Location = New System.Drawing.Point(15, 86)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(833, 368)
        Me.G_Cadastro.TabIndex = 10093
        Me.G_Cadastro.TabStop = False
        Me.G_Cadastro.Text = "Cadastro"
        '
        'TextBox1
        '
        Me.TextBox1.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.TextBox1.Location = New System.Drawing.Point(502, 192)
        Me.TextBox1.MaxLength = 499
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(308, 162)
        Me.TextBox1.TabIndex = 10094
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(83, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 10093
        Me.Label5.Text = "Observação:"
        '
        'Txt_Justificativa
        '
        Me.Txt_Justificativa.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Justificativa.Location = New System.Drawing.Point(162, 312)
        Me.Txt_Justificativa.MaxLength = 499
        Me.Txt_Justificativa.Multiline = True
        Me.Txt_Justificativa.Name = "Txt_Justificativa"
        Me.Txt_Justificativa.Size = New System.Drawing.Size(323, 42)
        Me.Txt_Justificativa.TabIndex = 10092
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(85, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10092
        Me.PictureBox1.TabStop = False
        '
        'Fm_cadastro_IR_Recisao_Aluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 655)
        Me.Controls.Add(Me.DG_IR)
        Me.Controls.Add(Me.Lb_Total)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.LbCab)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(879, 694)
        Me.MinimumSize = New System.Drawing.Size(879, 694)
        Me.Name = "Fm_cadastro_IR_Recisao_Aluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rescisão contrato de Aluguel"
        CType(Me.DG_IR,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.G_Cadastro.ResumeLayout(false)
        Me.G_Cadastro.PerformLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Txt_Data_Deposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Protected WithEvents ChekBox_Periodo As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_vBase As System.Windows.Forms.TextBox
    Friend WithEvents Rb_PJ As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_PF As System.Windows.Forms.RadioButton
    Friend WithEvents DG_IR As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Txt_Nome As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Lb_Total As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LbCab As System.Windows.Forms.Label
    Friend WithEvents LbNomeEntidade As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Txt_CNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lb_CPF As System.Windows.Forms.Label
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Txt_Justificativa As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class