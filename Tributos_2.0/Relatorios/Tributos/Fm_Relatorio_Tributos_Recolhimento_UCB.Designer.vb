<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Tributos_Recolhimento_UCB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Tributos_Recolhimento_UCB))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_FGTS = New System.Windows.Forms.RadioButton()
        Me.Rb_Demais = New System.Windows.Forms.RadioButton()
        Me.Rb_IR = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Chec_Codigo = New System.Windows.Forms.RadioButton()
        Me.CB_Codigo = New System.Windows.Forms.ComboBox()
        Me.cbo_NomeEntidade = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(12, 9)
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
        Me.GroupBox4.Controls.Add(Me.RB_FGTS)
        Me.GroupBox4.Controls.Add(Me.Rb_Demais)
        Me.GroupBox4.Controls.Add(Me.Rb_IR)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(28, 36)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(210, 53)
        Me.GroupBox4.TabIndex = 10090
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Tributo"
        '
        'RB_FGTS
        '
        Me.RB_FGTS.AutoSize = True
        Me.RB_FGTS.BackColor = System.Drawing.Color.Transparent
        Me.RB_FGTS.Checked = True
        Me.RB_FGTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_FGTS.ForeColor = System.Drawing.Color.White
        Me.RB_FGTS.Location = New System.Drawing.Point(7, 19)
        Me.RB_FGTS.Name = "RB_FGTS"
        Me.RB_FGTS.Size = New System.Drawing.Size(56, 19)
        Me.RB_FGTS.TabIndex = 51
        Me.RB_FGTS.TabStop = True
        Me.RB_FGTS.Text = "FGTS"
        Me.RB_FGTS.UseVisualStyleBackColor = False
        '
        'Rb_Demais
        '
        Me.Rb_Demais.AutoSize = True
        Me.Rb_Demais.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Demais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Demais.ForeColor = System.Drawing.Color.White
        Me.Rb_Demais.Location = New System.Drawing.Point(132, 19)
        Me.Rb_Demais.Name = "Rb_Demais"
        Me.Rb_Demais.Size = New System.Drawing.Size(53, 19)
        Me.Rb_Demais.TabIndex = 51
        Me.Rb_Demais.Text = "INSS"
        Me.Rb_Demais.UseVisualStyleBackColor = False
        '
        'Rb_IR
        '
        Me.Rb_IR.AutoSize = True
        Me.Rb_IR.BackColor = System.Drawing.Color.Transparent
        Me.Rb_IR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_IR.ForeColor = System.Drawing.Color.White
        Me.Rb_IR.Location = New System.Drawing.Point(69, 19)
        Me.Rb_IR.Name = "Rb_IR"
        Me.Rb_IR.Size = New System.Drawing.Size(57, 19)
        Me.Rb_IR.TabIndex = 50
        Me.Rb_IR.Text = "DARF"
        Me.Rb_IR.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.Controls.Add(Me.Cb_Mes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(29, 252)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 53)
        Me.GroupBox3.TabIndex = 10089
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mês de Competência / Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Ano.Location = New System.Drawing.Point(105, 19)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(67, 21)
        Me.Cb_Ano.TabIndex = 54
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(33, 19)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(48, 21)
        Me.Cb_Mes.TabIndex = 53
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.Chec_Codigo)
        Me.G_Entidade.Controls.Add(Me.CB_Codigo)
        Me.G_Entidade.Controls.Add(Me.cbo_NomeEntidade)
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(29, 193)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(210, 53)
        Me.G_Entidade.TabIndex = 10088
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Entidade"
        '
        'Chec_Codigo
        '
        Me.Chec_Codigo.AutoSize = True
        Me.Chec_Codigo.BackColor = System.Drawing.Color.Transparent
        Me.Chec_Codigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chec_Codigo.ForeColor = System.Drawing.Color.White
        Me.Chec_Codigo.Location = New System.Drawing.Point(127, 19)
        Me.Chec_Codigo.Name = "Chec_Codigo"
        Me.Chec_Codigo.Size = New System.Drawing.Size(64, 19)
        Me.Chec_Codigo.TabIndex = 51
        Me.Chec_Codigo.Text = "Código"
        Me.Chec_Codigo.UseVisualStyleBackColor = False
        '
        'CB_Codigo
        '
        Me.CB_Codigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_Codigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_Codigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Codigo.Enabled = False
        Me.CB_Codigo.FormattingEnabled = True
        Me.CB_Codigo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CB_Codigo.Location = New System.Drawing.Point(6, 19)
        Me.CB_Codigo.Name = "CB_Codigo"
        Me.CB_Codigo.Size = New System.Drawing.Size(94, 21)
        Me.CB_Codigo.TabIndex = 10079
        Me.CB_Codigo.Visible = False
        '
        'cbo_NomeEntidade
        '
        Me.cbo_NomeEntidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_NomeEntidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_NomeEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_NomeEntidade.Enabled = False
        Me.cbo_NomeEntidade.FormattingEnabled = True
        Me.cbo_NomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_NomeEntidade.Location = New System.Drawing.Point(6, 19)
        Me.cbo_NomeEntidade.Name = "cbo_NomeEntidade"
        Me.cbo_NomeEntidade.Size = New System.Drawing.Size(94, 21)
        Me.cbo_NomeEntidade.TabIndex = 10077
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 92)
        Me.GroupBox1.TabIndex = 10087
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
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
        Me.btnRelatorio.Location = New System.Drawing.Point(114, 311)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10086
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'Fm_Relatorio_Tributos_Recolhimento_UCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(271, 418)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_Relatorio_Tributos_Recolhimento_UCB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Tributos - Recolhimento UCB"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.G_Entidade.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_FGTS As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Demais As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_IR As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Chec_Codigo As System.Windows.Forms.RadioButton
    Friend WithEvents CB_Codigo As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_NomeEntidade As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
End Class
