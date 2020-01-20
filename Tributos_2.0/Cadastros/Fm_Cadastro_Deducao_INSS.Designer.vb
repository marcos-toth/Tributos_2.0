<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Deducao_INSS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Deducao_INSS))
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.Chek_Varios = New System.Windows.Forms.CheckBox()
        Me.Btn_Observacao = New System.Windows.Forms.Button()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_FIES = New System.Windows.Forms.CheckBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtValorCorrigido = New System.Windows.Forms.TextBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.G_Cadastro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.Chek_Varios)
        Me.G_Cadastro.Controls.Add(Me.Btn_Observacao)
        Me.G_Cadastro.Controls.Add(Me.Cb_Ano)
        Me.G_Cadastro.Controls.Add(Me.Label7)
        Me.G_Cadastro.Controls.Add(Me.CB_FIES)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.Label6)
        Me.G_Cadastro.Controls.Add(Me.TxtTotal)
        Me.G_Cadastro.Controls.Add(Me.TxtValorCorrigido)
        Me.G_Cadastro.Controls.Add(Me.Cb_Mes)
        Me.G_Cadastro.Controls.Add(Me.Label5)
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
        Me.G_Cadastro.Location = New System.Drawing.Point(252, 59)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(441, 303)
        Me.G_Cadastro.TabIndex = 10077
        Me.G_Cadastro.TabStop = False
        Me.G_Cadastro.Text = "Cadastro"
        '
        'Chek_Varios
        '
        Me.Chek_Varios.AutoSize = True
        Me.Chek_Varios.Enabled = False
        Me.Chek_Varios.Location = New System.Drawing.Point(226, 168)
        Me.Chek_Varios.Name = "Chek_Varios"
        Me.Chek_Varios.Size = New System.Drawing.Size(126, 17)
        Me.Chek_Varios.TabIndex = 10078
        Me.Chek_Varios.Text = "Somar Vários Valores"
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
        Me.Btn_Observacao.Location = New System.Drawing.Point(257, 221)
        Me.Btn_Observacao.Name = "Btn_Observacao"
        Me.Btn_Observacao.Size = New System.Drawing.Size(169, 58)
        Me.Btn_Observacao.TabIndex = 10077
        Me.Btn_Observacao.Text = "&Cadastro Observações"
        Me.Btn_Observacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Observacao.UseVisualStyleBackColor = False
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Location = New System.Drawing.Point(124, 81)
        Me.Cb_Ano.MaxDropDownItems = 12
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(66, 21)
        Me.Cb_Ano.TabIndex = 10075
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(4, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 15)
        Me.Label7.TabIndex = 10076
        Me.Label7.Text = "Ano de Competência:"
        '
        'CB_FIES
        '
        Me.CB_FIES.AutoSize = True
        Me.CB_FIES.Location = New System.Drawing.Point(358, 168)
        Me.CB_FIES.Name = "CB_FIES"
        Me.CB_FIES.Size = New System.Drawing.Size(49, 17)
        Me.CB_FIES.TabIndex = 10070
        Me.CB_FIES.Text = "FIES"
        Me.CB_FIES.UseVisualStyleBackColor = True
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
        Me.btnDeletar.Location = New System.Drawing.Point(168, 221)
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
        Me.Label6.Location = New System.Drawing.Point(254, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 10068
        Me.Label6.Text = "Ajuste:"
        '
        'TxtTotal
        '
        Me.TxtTotal.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Location = New System.Drawing.Point(303, 141)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotal.TabIndex = 10067
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtValorCorrigido
        '
        Me.TxtValorCorrigido.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.TxtValorCorrigido.Location = New System.Drawing.Point(123, 164)
        Me.TxtValorCorrigido.Name = "TxtValorCorrigido"
        Me.TxtValorCorrigido.Size = New System.Drawing.Size(100, 20)
        Me.TxtValorCorrigido.TabIndex = 10065
        Me.TxtValorCorrigido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(123, 54)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(38, 21)
        Me.Cb_Mes.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(0, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 10064
        Me.Label5.Text = "Mês de Competência:"
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Location = New System.Drawing.Point(123, 107)
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
        Me.Label2.Location = New System.Drawing.Point(17, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 10053
        Me.Label2.Text = "Data do Cadastro:"
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(123, 24)
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
        Me.Label3.Location = New System.Drawing.Point(66, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 10055
        Me.Label3.Text = "Entidade:"
        '
        'txtValor
        '
        Me.txtValor.AccessibleDescription = "Colocar o Valor do Depósito"
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(123, 138)
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
        Me.LbNomeEntidade.Location = New System.Drawing.Point(179, 109)
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
        Me.btnSalvar.Location = New System.Drawing.Point(20, 221)
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
        Me.lbInform.Location = New System.Drawing.Point(19, 203)
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
        Me.btnLimpar.Location = New System.Drawing.Point(94, 221)
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
        Me.Label4.Location = New System.Drawing.Point(60, 141)
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
        Me.Label1.Location = New System.Drawing.Point(33, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 10066
        Me.Label1.Text = "Valor Corrigido:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10076
        Me.PictureBox1.TabStop = False
        '
        'LbCab
        '
        Me.LbCab.AutoSize = True
        Me.LbCab.BackColor = System.Drawing.Color.Transparent
        Me.LbCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LbCab.ForeColor = System.Drawing.Color.Black
        Me.LbCab.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCab.Location = New System.Drawing.Point(329, 22)
        Me.LbCab.Name = "LbCab"
        Me.LbCab.Size = New System.Drawing.Size(234, 25)
        Me.LbCab.TabIndex = 10075
        Me.LbCab.Text = "Abatimentos do INSS"
        '
        'Fm_Cadastro_Deducao_INSS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 374)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbCab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Cadastro_Deducao_INSS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Controle de Abatimentos de INSS"
        Me.G_Cadastro.ResumeLayout(False)
        Me.G_Cadastro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents LbNomeEntidade As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbCab As System.Windows.Forms.Label
    Friend WithEvents TxtValorCorrigido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents CB_FIES As System.Windows.Forms.CheckBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Btn_Observacao As System.Windows.Forms.Button
    Friend WithEvents Chek_Varios As System.Windows.Forms.CheckBox
End Class
