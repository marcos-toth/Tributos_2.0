<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Nao_Depositaram
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Nao_Depositaram))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rb_Demais = New System.Windows.Forms.RadioButton()
        Me.Rb_FGTS = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Cb_EntidadeMae = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.Rb_Decimo_Terceiro = New System.Windows.Forms.RadioButton()
        Me.RB_Decimo = New System.Windows.Forms.RadioButton()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.G_Entidade.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.Black
        CNPJClientesLabel.Location = New System.Drawing.Point(14, 12)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10077
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.RB_Decimo)
        Me.GroupBox4.Controls.Add(Me.Rb_Decimo_Terceiro)
        Me.GroupBox4.Controls.Add(Me.Rb_Demais)
        Me.GroupBox4.Controls.Add(Me.Rb_FGTS)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(32, 49)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 53)
        Me.GroupBox4.TabIndex = 10082
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Tributo"
        '
        'Rb_Demais
        '
        Me.Rb_Demais.AutoSize = True
        Me.Rb_Demais.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Demais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Demais.ForeColor = System.Drawing.Color.Black
        Me.Rb_Demais.Location = New System.Drawing.Point(81, 19)
        Me.Rb_Demais.Name = "Rb_Demais"
        Me.Rb_Demais.Size = New System.Drawing.Size(68, 19)
        Me.Rb_Demais.TabIndex = 51
        Me.Rb_Demais.Text = "Demais"
        Me.Rb_Demais.UseVisualStyleBackColor = False
        '
        'Rb_FGTS
        '
        Me.Rb_FGTS.AutoSize = True
        Me.Rb_FGTS.BackColor = System.Drawing.Color.Transparent
        Me.Rb_FGTS.Checked = True
        Me.Rb_FGTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_FGTS.ForeColor = System.Drawing.Color.Black
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(32, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 53)
        Me.GroupBox3.TabIndex = 10081
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mês do Depósito / Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Location = New System.Drawing.Point(76, 19)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(67, 21)
        Me.Cb_Ano.TabIndex = 54
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(9, 19)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(48, 21)
        Me.Cb_Mes.TabIndex = 53
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
        Me.btnRelatorio.ForeColor = System.Drawing.Color.Black
        Me.btnRelatorio.Image = CType(resources.GetObject("btnRelatorio.Image"), System.Drawing.Image)
        Me.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRelatorio.Location = New System.Drawing.Point(61, 311)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 88)
        Me.btnRelatorio.TabIndex = 10078
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(233, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 273)
        Me.PictureBox1.TabIndex = 10076
        Me.PictureBox1.TabStop = False
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.Cb_EntidadeMae)
        Me.G_Entidade.Enabled = False
        Me.G_Entidade.ForeColor = System.Drawing.Color.Black
        Me.G_Entidade.Location = New System.Drawing.Point(32, 185)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(154, 53)
        Me.G_Entidade.TabIndex = 10095
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Tipo Entidade"
        '
        'Cb_EntidadeMae
        '
        Me.Cb_EntidadeMae.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Cb_EntidadeMae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_EntidadeMae.FormattingEnabled = True
        Me.Cb_EntidadeMae.Location = New System.Drawing.Point(9, 19)
        Me.Cb_EntidadeMae.Name = "Cb_EntidadeMae"
        Me.Cb_EntidadeMae.Size = New System.Drawing.Size(119, 21)
        Me.Cb_EntidadeMae.TabIndex = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(32, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(154, 69)
        Me.GroupBox1.TabIndex = 10096
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'Rb_RelatorioGeral
        '
        Me.Rb_RelatorioGeral.AutoSize = True
        Me.Rb_RelatorioGeral.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeral.Checked = True
        Me.Rb_RelatorioGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeral.ForeColor = System.Drawing.Color.Black
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
        Me.Rb_RelatorioEntidade.ForeColor = System.Drawing.Color.Black
        Me.Rb_RelatorioEntidade.Location = New System.Drawing.Point(6, 44)
        Me.Rb_RelatorioEntidade.Name = "Rb_RelatorioEntidade"
        Me.Rb_RelatorioEntidade.Size = New System.Drawing.Size(148, 19)
        Me.Rb_RelatorioEntidade.TabIndex = 50
        Me.Rb_RelatorioEntidade.Text = "Relatório por Entidade"
        Me.Rb_RelatorioEntidade.UseVisualStyleBackColor = False
        '
        'Rb_Decimo_Terceiro
        '
        Me.Rb_Decimo_Terceiro.AutoSize = True
        Me.Rb_Decimo_Terceiro.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Decimo_Terceiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Decimo_Terceiro.ForeColor = System.Drawing.Color.Black
        Me.Rb_Decimo_Terceiro.Location = New System.Drawing.Point(281, 19)
        Me.Rb_Decimo_Terceiro.Name = "Rb_Decimo_Terceiro"
        Me.Rb_Decimo_Terceiro.Size = New System.Drawing.Size(68, 19)
        Me.Rb_Decimo_Terceiro.TabIndex = 52
        Me.Rb_Decimo_Terceiro.Text = "Demais"
        Me.Rb_Decimo_Terceiro.UseVisualStyleBackColor = False
        '
        'RB_Decimo
        '
        Me.RB_Decimo.AutoSize = True
        Me.RB_Decimo.BackColor = System.Drawing.Color.Transparent
        Me.RB_Decimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Decimo.ForeColor = System.Drawing.Color.Black
        Me.RB_Decimo.Location = New System.Drawing.Point(159, 19)
        Me.RB_Decimo.Name = "RB_Decimo"
        Me.RB_Decimo.Size = New System.Drawing.Size(116, 19)
        Me.RB_Decimo.TabIndex = 53
        Me.RB_Decimo.Text = "Décimo Terceiro"
        Me.RB_Decimo.UseVisualStyleBackColor = False
        '
        'Fm_Relatorio_Nao_Depositaram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(623, 432)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Nao_Depositaram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório das Entidades que Não  Depositaram os Valores dos Encargos"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.G_Entidade.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_Demais As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_FGTS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_EntidadeMae As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Decimo_Terceiro As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Decimo As System.Windows.Forms.RadioButton
End Class
