<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Informe_IR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Informe_IR))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.Rb_RelatorioAnalitico = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_DIRF = New System.Windows.Forms.RadioButton()
        Me.G_CPF = New System.Windows.Forms.GroupBox()
        Me.txt_CPF = New System.Windows.Forms.MaskedTextBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.cbo_NomeEntidade = New System.Windows.Forms.ComboBox()
        Me.G_Pessoa = New System.Windows.Forms.GroupBox()
        Me.Rb_PJ = New System.Windows.Forms.RadioButton()
        Me.Rb_PF = New System.Windows.Forms.RadioButton()
        Me.G_CNPJ = New System.Windows.Forms.GroupBox()
        Me.Txt_CNPJ = New System.Windows.Forms.MaskedTextBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.G_CPF.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.G_Pessoa.SuspendLayout()
        Me.G_CNPJ.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(10, 9)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10085
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(35, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(88, 53)
        Me.GroupBox3.TabIndex = 10089
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Location = New System.Drawing.Point(13, 19)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(67, 21)
        Me.Cb_Ano.TabIndex = 54
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
        Me.btnRelatorio.Location = New System.Drawing.Point(35, 339)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(118, 93)
        Me.btnRelatorio.TabIndex = 10086
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioAnalitico
        '
        Me.Rb_RelatorioAnalitico.AutoSize = True
        Me.Rb_RelatorioAnalitico.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioAnalitico.Checked = True
        Me.Rb_RelatorioAnalitico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioAnalitico.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioAnalitico.Location = New System.Drawing.Point(6, 19)
        Me.Rb_RelatorioAnalitico.Name = "Rb_RelatorioAnalitico"
        Me.Rb_RelatorioAnalitico.Size = New System.Drawing.Size(172, 19)
        Me.Rb_RelatorioAnalitico.TabIndex = 50
        Me.Rb_RelatorioAnalitico.TabStop = True
        Me.Rb_RelatorioAnalitico.Text = "Relatório Analítico Por CPF"
        Me.Rb_RelatorioAnalitico.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioGeral
        '
        Me.Rb_RelatorioGeral.AutoSize = True
        Me.Rb_RelatorioGeral.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeral.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeral.Location = New System.Drawing.Point(6, 44)
        Me.Rb_RelatorioGeral.Name = "Rb_RelatorioGeral"
        Me.Rb_RelatorioGeral.Size = New System.Drawing.Size(182, 19)
        Me.Rb_RelatorioGeral.TabIndex = 49
        Me.Rb_RelatorioGeral.Text = "Relatório Geral Por Entidade"
        Me.Rb_RelatorioGeral.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_DIRF)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioAnalitico)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(35, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 97)
        Me.GroupBox1.TabIndex = 10087
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'Rb_DIRF
        '
        Me.Rb_DIRF.AutoSize = True
        Me.Rb_DIRF.BackColor = System.Drawing.Color.Transparent
        Me.Rb_DIRF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_DIRF.ForeColor = System.Drawing.Color.White
        Me.Rb_DIRF.Location = New System.Drawing.Point(6, 69)
        Me.Rb_DIRF.Name = "Rb_DIRF"
        Me.Rb_DIRF.Size = New System.Drawing.Size(106, 19)
        Me.Rb_DIRF.TabIndex = 51
        Me.Rb_DIRF.Text = "Relatório DIRF"
        Me.Rb_DIRF.UseVisualStyleBackColor = False
        '
        'G_CPF
        '
        Me.G_CPF.BackColor = System.Drawing.Color.Transparent
        Me.G_CPF.Controls.Add(Me.txt_CPF)
        Me.G_CPF.ForeColor = System.Drawing.Color.White
        Me.G_CPF.Location = New System.Drawing.Point(35, 280)
        Me.G_CPF.Name = "G_CPF"
        Me.G_CPF.Size = New System.Drawing.Size(109, 53)
        Me.G_CPF.TabIndex = 10090
        Me.G_CPF.TabStop = False
        Me.G_CPF.Text = "CPF:"
        '
        'txt_CPF
        '
        Me.txt_CPF.Location = New System.Drawing.Point(13, 20)
        Me.txt_CPF.Mask = "999,999,999-99"
        Me.txt_CPF.Name = "txt_CPF"
        Me.txt_CPF.Size = New System.Drawing.Size(86, 20)
        Me.txt_CPF.TabIndex = 0
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.cbo_NomeEntidade)
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(136, 221)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(109, 53)
        Me.G_Entidade.TabIndex = 10092
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Entidade"
        '
        'cbo_NomeEntidade
        '
        Me.cbo_NomeEntidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_NomeEntidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_NomeEntidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_NomeEntidade.FormattingEnabled = True
        Me.cbo_NomeEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_NomeEntidade.Location = New System.Drawing.Point(6, 19)
        Me.cbo_NomeEntidade.Name = "cbo_NomeEntidade"
        Me.cbo_NomeEntidade.Size = New System.Drawing.Size(94, 21)
        Me.cbo_NomeEntidade.TabIndex = 10077
        '
        'G_Pessoa
        '
        Me.G_Pessoa.BackColor = System.Drawing.Color.Transparent
        Me.G_Pessoa.Controls.Add(Me.Rb_PJ)
        Me.G_Pessoa.Controls.Add(Me.Rb_PF)
        Me.G_Pessoa.ForeColor = System.Drawing.Color.White
        Me.G_Pessoa.Location = New System.Drawing.Point(35, 40)
        Me.G_Pessoa.Name = "G_Pessoa"
        Me.G_Pessoa.Size = New System.Drawing.Size(210, 72)
        Me.G_Pessoa.TabIndex = 10088
        Me.G_Pessoa.TabStop = False
        Me.G_Pessoa.Text = "Tipo do Relatório"
        '
        'Rb_PJ
        '
        Me.Rb_PJ.AutoSize = True
        Me.Rb_PJ.BackColor = System.Drawing.Color.Transparent
        Me.Rb_PJ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_PJ.ForeColor = System.Drawing.Color.White
        Me.Rb_PJ.Location = New System.Drawing.Point(6, 44)
        Me.Rb_PJ.Name = "Rb_PJ"
        Me.Rb_PJ.Size = New System.Drawing.Size(112, 19)
        Me.Rb_PJ.TabIndex = 49
        Me.Rb_PJ.Text = "Pessoa Jurídica"
        Me.Rb_PJ.UseVisualStyleBackColor = False
        '
        'Rb_PF
        '
        Me.Rb_PF.AutoSize = True
        Me.Rb_PF.BackColor = System.Drawing.Color.Transparent
        Me.Rb_PF.Checked = True
        Me.Rb_PF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_PF.ForeColor = System.Drawing.Color.White
        Me.Rb_PF.Location = New System.Drawing.Point(6, 19)
        Me.Rb_PF.Name = "Rb_PF"
        Me.Rb_PF.Size = New System.Drawing.Size(101, 19)
        Me.Rb_PF.TabIndex = 50
        Me.Rb_PF.TabStop = True
        Me.Rb_PF.Text = "Pessoa Física"
        Me.Rb_PF.UseVisualStyleBackColor = False
        '
        'G_CNPJ
        '
        Me.G_CNPJ.BackColor = System.Drawing.Color.Transparent
        Me.G_CNPJ.Controls.Add(Me.Txt_CNPJ)
        Me.G_CNPJ.ForeColor = System.Drawing.Color.White
        Me.G_CNPJ.Location = New System.Drawing.Point(35, 280)
        Me.G_CNPJ.Name = "G_CNPJ"
        Me.G_CNPJ.Size = New System.Drawing.Size(135, 53)
        Me.G_CNPJ.TabIndex = 10091
        Me.G_CNPJ.TabStop = False
        Me.G_CNPJ.Text = "CNPJ:"
        '
        'Txt_CNPJ
        '
        Me.Txt_CNPJ.Location = New System.Drawing.Point(13, 20)
        Me.Txt_CNPJ.Mask = "99,999,999/9999-99"
        Me.Txt_CNPJ.Name = "Txt_CNPJ"
        Me.Txt_CNPJ.Size = New System.Drawing.Size(110, 20)
        Me.Txt_CNPJ.TabIndex = 0
        '
        'Fm_Relatorio_Informe_IR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 445)
        Me.Controls.Add(Me.G_CNPJ)
        Me.Controls.Add(Me.G_Pessoa)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.G_CPF)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Relatorio_Informe_IR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Informe IR Aluguéis"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.G_CPF.ResumeLayout(False)
        Me.G_CPF.PerformLayout()
        Me.G_Entidade.ResumeLayout(False)
        Me.G_Pessoa.ResumeLayout(False)
        Me.G_Pessoa.PerformLayout()
        Me.G_CNPJ.ResumeLayout(False)
        Me.G_CNPJ.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents Rb_RelatorioAnalitico As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents G_CPF As System.Windows.Forms.GroupBox
    Friend WithEvents txt_CPF As System.Windows.Forms.MaskedTextBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_NomeEntidade As System.Windows.Forms.ComboBox
    Friend WithEvents Rb_DIRF As System.Windows.Forms.RadioButton
    Friend WithEvents G_Pessoa As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_PJ As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_PF As System.Windows.Forms.RadioButton
    Friend WithEvents G_CNPJ As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_CNPJ As System.Windows.Forms.MaskedTextBox
End Class
