<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Campo_Deposito
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
        Dim CNPJClientesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Campo_Deposito))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_Ano = New System.Windows.Forms.RadioButton()
        Me.Rb_Demais = New System.Windows.Forms.RadioButton()
        Me.RB_Mes = New System.Windows.Forms.RadioButton()
        Me.RB_Decimo = New System.Windows.Forms.RadioButton()
        Me.Rb_FGTS = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.cbo_NomeEntidade = New System.Windows.Forms.ComboBox()
        Me.G_Geral = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.G_Geral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(30, 25)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10085
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RB_Ano)
        Me.GroupBox4.Controls.Add(Me.Rb_Demais)
        Me.GroupBox4.Controls.Add(Me.RB_Mes)
        Me.GroupBox4.Controls.Add(Me.RB_Decimo)
        Me.GroupBox4.Controls.Add(Me.Rb_FGTS)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(48, 62)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(385, 53)
        Me.GroupBox4.TabIndex = 10090
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Tributo"
        '
        'RB_Ano
        '
        Me.RB_Ano.AutoSize = True
        Me.RB_Ano.BackColor = System.Drawing.Color.Transparent
        Me.RB_Ano.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Ano.ForeColor = System.Drawing.Color.White
        Me.RB_Ano.Location = New System.Drawing.Point(325, 20)
        Me.RB_Ano.Name = "RB_Ano"
        Me.RB_Ano.Size = New System.Drawing.Size(46, 19)
        Me.RB_Ano.TabIndex = 52
        Me.RB_Ano.Text = "Ano"
        Me.RB_Ano.UseVisualStyleBackColor = False
        '
        'Rb_Demais
        '
        Me.Rb_Demais.AutoSize = True
        Me.Rb_Demais.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Demais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Demais.ForeColor = System.Drawing.Color.White
        Me.Rb_Demais.Location = New System.Drawing.Point(71, 20)
        Me.Rb_Demais.Name = "Rb_Demais"
        Me.Rb_Demais.Size = New System.Drawing.Size(68, 19)
        Me.Rb_Demais.TabIndex = 51
        Me.Rb_Demais.Text = "Demais"
        Me.Rb_Demais.UseVisualStyleBackColor = False
        '
        'RB_Mes
        '
        Me.RB_Mes.AutoSize = True
        Me.RB_Mes.BackColor = System.Drawing.Color.Transparent
        Me.RB_Mes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Mes.ForeColor = System.Drawing.Color.White
        Me.RB_Mes.Location = New System.Drawing.Point(267, 20)
        Me.RB_Mes.Name = "RB_Mes"
        Me.RB_Mes.Size = New System.Drawing.Size(49, 19)
        Me.RB_Mes.TabIndex = 50
        Me.RB_Mes.Text = "Mês"
        Me.RB_Mes.UseVisualStyleBackColor = False
        '
        'RB_Decimo
        '
        Me.RB_Decimo.AutoSize = True
        Me.RB_Decimo.BackColor = System.Drawing.Color.Transparent
        Me.RB_Decimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Decimo.ForeColor = System.Drawing.Color.White
        Me.RB_Decimo.Location = New System.Drawing.Point(145, 20)
        Me.RB_Decimo.Name = "RB_Decimo"
        Me.RB_Decimo.Size = New System.Drawing.Size(116, 19)
        Me.RB_Decimo.TabIndex = 52
        Me.RB_Decimo.Text = "Décimo Terceiro"
        Me.RB_Decimo.UseVisualStyleBackColor = False
        '
        'Rb_FGTS
        '
        Me.Rb_FGTS.AutoSize = True
        Me.Rb_FGTS.BackColor = System.Drawing.Color.Transparent
        Me.Rb_FGTS.Checked = True
        Me.Rb_FGTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_FGTS.ForeColor = System.Drawing.Color.White
        Me.Rb_FGTS.Location = New System.Drawing.Point(13, 19)
        Me.Rb_FGTS.Name = "Rb_FGTS"
        Me.Rb_FGTS.Size = New System.Drawing.Size(56, 19)
        Me.Rb_FGTS.TabIndex = 50
        Me.Rb_FGTS.TabStop = True
        Me.Rb_FGTS.Text = "FGTS"
        Me.Rb_FGTS.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.Controls.Add(Me.Cb_Mes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(48, 278)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 53)
        Me.GroupBox3.TabIndex = 10089
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mês de Competência Folha / Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Ano.Location = New System.Drawing.Point(86, 19)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(80, 21)
        Me.Cb_Ano.TabIndex = 54
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(13, 19)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(56, 21)
        Me.Cb_Mes.TabIndex = 53
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.cbo_NomeEntidade)
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(48, 219)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(114, 53)
        Me.G_Entidade.TabIndex = 10088
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Entidade"
        '
        'cbo_NomeEntidade
        '
        Me.cbo_NomeEntidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_NomeEntidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_NomeEntidade.Enabled = False
        Me.cbo_NomeEntidade.FormattingEnabled = True
        Me.cbo_NomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_NomeEntidade.Location = New System.Drawing.Point(6, 19)
        Me.cbo_NomeEntidade.Name = "cbo_NomeEntidade"
        Me.cbo_NomeEntidade.Size = New System.Drawing.Size(94, 21)
        Me.cbo_NomeEntidade.TabIndex = 10077
        '
        'G_Geral
        '
        Me.G_Geral.BackColor = System.Drawing.Color.Transparent
        Me.G_Geral.Controls.Add(Me.Rb_RelatorioGeral)
        Me.G_Geral.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.G_Geral.ForeColor = System.Drawing.Color.White
        Me.G_Geral.Location = New System.Drawing.Point(48, 121)
        Me.G_Geral.Name = "G_Geral"
        Me.G_Geral.Size = New System.Drawing.Size(171, 92)
        Me.G_Geral.TabIndex = 10087
        Me.G_Geral.TabStop = False
        Me.G_Geral.Text = "Tipo"
        '
        'Rb_RelatorioGeral
        '
        Me.Rb_RelatorioGeral.AutoSize = True
        Me.Rb_RelatorioGeral.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeral.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeral.Location = New System.Drawing.Point(6, 19)
        Me.Rb_RelatorioGeral.Name = "Rb_RelatorioGeral"
        Me.Rb_RelatorioGeral.Size = New System.Drawing.Size(108, 19)
        Me.Rb_RelatorioGeral.TabIndex = 49
        Me.Rb_RelatorioGeral.TabStop = True
        Me.Rb_RelatorioGeral.Text = "Relatório Geral"
        Me.Rb_RelatorioGeral.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioEntidade
        '
        Me.Rb_RelatorioEntidade.AutoSize = True
        Me.Rb_RelatorioEntidade.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioEntidade.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioEntidade.Location = New System.Drawing.Point(6, 53)
        Me.Rb_RelatorioEntidade.Name = "Rb_RelatorioEntidade"
        Me.Rb_RelatorioEntidade.Size = New System.Drawing.Size(148, 19)
        Me.Rb_RelatorioEntidade.TabIndex = 50
        Me.Rb_RelatorioEntidade.TabStop = True
        Me.Rb_RelatorioEntidade.Text = "Relatório por Entidade"
        Me.Rb_RelatorioEntidade.UseVisualStyleBackColor = False
        '
        'btnRelatorio
        '
        Me.btnRelatorio.BackColor = System.Drawing.Color.Transparent
        Me.btnRelatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRelatorio.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRelatorio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelatorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelatorio.ForeColor = System.Drawing.Color.Transparent
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelatorio.Location = New System.Drawing.Point(134, 343)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10086
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(265, 174)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 273)
        Me.PictureBox1.TabIndex = 10084
        Me.PictureBox1.TabStop = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(581, 455)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 10091
        Me.txtData.Visible = False
        '
        'Fm_Relatorio_Campo_Deposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(588, 442)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.G_Geral)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Relatorio_Campo_Deposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatorio Depósitos Digitados"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.G_Geral.ResumeLayout(False)
        Me.G_Geral.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Demais As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_FGTS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_NomeEntidade As System.Windows.Forms.ComboBox
    Friend WithEvents G_Geral As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents RB_Ano As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Mes As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Decimo As System.Windows.Forms.RadioButton
End Class
