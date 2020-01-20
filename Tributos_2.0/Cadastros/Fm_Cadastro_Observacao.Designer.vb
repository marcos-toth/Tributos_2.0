<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Observacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Observacao))
        Me.lb_Aviso = New System.Windows.Forms.Label()
        Me.G_Cadastro = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtObs = New System.Windows.Forms.TextBox()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodEntidade = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbNomeEntidade = New System.Windows.Forms.Label()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbCab = New System.Windows.Forms.Label()
        Me.G_Cadastro.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lb_Aviso
        '
        Me.lb_Aviso.AutoSize = True
        Me.lb_Aviso.BackColor = System.Drawing.Color.Transparent
        Me.lb_Aviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Aviso.ForeColor = System.Drawing.Color.Red
        Me.lb_Aviso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lb_Aviso.Location = New System.Drawing.Point(12, 296)
        Me.lb_Aviso.Name = "lb_Aviso"
        Me.lb_Aviso.Size = New System.Drawing.Size(0, 20)
        Me.lb_Aviso.TabIndex = 10079
        '
        'G_Cadastro
        '
        Me.G_Cadastro.BackColor = System.Drawing.Color.Transparent
        Me.G_Cadastro.Controls.Add(Me.Cb_Ano)
        Me.G_Cadastro.Controls.Add(Me.Label6)
        Me.G_Cadastro.Controls.Add(Me.TxtObs)
        Me.G_Cadastro.Controls.Add(Me.btnDeletar)
        Me.G_Cadastro.Controls.Add(Me.Cb_Mes)
        Me.G_Cadastro.Controls.Add(Me.Label5)
        Me.G_Cadastro.Controls.Add(Me.txtCodEntidade)
        Me.G_Cadastro.Controls.Add(Me.Label2)
        Me.G_Cadastro.Controls.Add(Me.txtData)
        Me.G_Cadastro.Controls.Add(Me.Label3)
        Me.G_Cadastro.Controls.Add(Me.LbNomeEntidade)
        Me.G_Cadastro.Controls.Add(Me.btnSalvar)
        Me.G_Cadastro.Controls.Add(Me.lbInform)
        Me.G_Cadastro.Controls.Add(Me.btnLimpar)
        Me.G_Cadastro.Controls.Add(Me.Label4)
        Me.G_Cadastro.ForeColor = System.Drawing.Color.Black
        Me.G_Cadastro.Location = New System.Drawing.Point(251, 64)
        Me.G_Cadastro.Name = "G_Cadastro"
        Me.G_Cadastro.Size = New System.Drawing.Size(441, 331)
        Me.G_Cadastro.TabIndex = 10078
        Me.G_Cadastro.TabStop = False
        Me.G_Cadastro.Text = "Cadastro"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Location = New System.Drawing.Point(126, 85)
        Me.Cb_Ano.MaxDropDownItems = 12
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(66, 21)
        Me.Cb_Ano.TabIndex = 10075
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(6, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 15)
        Me.Label6.TabIndex = 10076
        Me.Label6.Text = "Ano de Competência:"
        '
        'TxtObs
        '
        Me.TxtObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObs.Location = New System.Drawing.Point(127, 150)
        Me.TxtObs.MaxLength = 255
        Me.TxtObs.Multiline = True
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(290, 67)
        Me.TxtObs.TabIndex = 10066
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
        Me.btnDeletar.Location = New System.Drawing.Point(280, 223)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(68, 58)
        Me.btnDeletar.TabIndex = 10065
        Me.btnDeletar.Text = "&Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(127, 54)
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
        Me.Label5.Location = New System.Drawing.Point(3, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 15)
        Me.Label5.TabIndex = 10064
        Me.Label5.Text = "Mês de Competência:"
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Location = New System.Drawing.Point(127, 114)
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
        Me.Label2.Location = New System.Drawing.Point(21, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 10053
        Me.Label2.Text = "Data do Cadastro:"
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Location = New System.Drawing.Point(127, 24)
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
        Me.Label3.Location = New System.Drawing.Point(70, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 15)
        Me.Label3.TabIndex = 10055
        Me.Label3.Text = "Entidade:"
        '
        'LbNomeEntidade
        '
        Me.LbNomeEntidade.AutoSize = True
        Me.LbNomeEntidade.BackColor = System.Drawing.Color.Transparent
        Me.LbNomeEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.LbNomeEntidade.ForeColor = System.Drawing.Color.Black
        Me.LbNomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbNomeEntidade.Location = New System.Drawing.Point(179, 116)
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
        Me.btnSalvar.Location = New System.Drawing.Point(127, 223)
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
        Me.lbInform.Location = New System.Drawing.Point(124, 293)
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
        Me.btnLimpar.Location = New System.Drawing.Point(201, 223)
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
        Me.Label4.Location = New System.Drawing.Point(89, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 15)
        Me.Label4.TabIndex = 10057
        Me.Label4.Text = "Obs:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10077
        Me.PictureBox1.TabStop = False
        '
        'LbCab
        '
        Me.LbCab.AutoSize = True
        Me.LbCab.BackColor = System.Drawing.Color.Transparent
        Me.LbCab.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LbCab.ForeColor = System.Drawing.Color.Black
        Me.LbCab.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbCab.Location = New System.Drawing.Point(252, 9)
        Me.LbCab.Name = "LbCab"
        Me.LbCab.Size = New System.Drawing.Size(285, 25)
        Me.LbCab.TabIndex = 10076
        Me.LbCab.Text = "Cadastro de Observações"
        '
        'Fm_Cadastro_Observacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 415)
        Me.Controls.Add(Me.lb_Aviso)
        Me.Controls.Add(Me.G_Cadastro)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbCab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Cadastro_Observacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Observações"
        Me.G_Cadastro.ResumeLayout(False)
        Me.G_Cadastro.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_Aviso As System.Windows.Forms.Label
    Friend WithEvents G_Cadastro As System.Windows.Forms.GroupBox
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LbNomeEntidade As System.Windows.Forms.Label
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents LbCab As System.Windows.Forms.Label
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
