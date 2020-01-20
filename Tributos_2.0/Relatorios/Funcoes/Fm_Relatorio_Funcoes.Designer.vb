<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Funcoes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Funcoes))
        Me.G_Campo = New System.Windows.Forms.GroupBox()
        Me.CBO_Entidade = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.CBO_Campo = New System.Windows.Forms.ComboBox()
        Me.G_Funcao = New System.Windows.Forms.GroupBox()
        Me.cbo_Funcao = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_Campo = New System.Windows.Forms.RadioButton()
        Me.Rb_Funcao = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.G_Campo.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.G_Funcao.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(96, -34)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10091
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'G_Campo
        '
        Me.G_Campo.BackColor = System.Drawing.Color.Transparent
        Me.G_Campo.Controls.Add(Me.CBO_Entidade)
        Me.G_Campo.ForeColor = System.Drawing.Color.White
        Me.G_Campo.Location = New System.Drawing.Point(12, 152)
        Me.G_Campo.Name = "G_Campo"
        Me.G_Campo.Size = New System.Drawing.Size(127, 53)
        Me.G_Campo.TabIndex = 10096
        Me.G_Campo.TabStop = False
        Me.G_Campo.Text = "Tipo de Entidade"
        '
        'CBO_Entidade
        '
        Me.CBO_Entidade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBO_Entidade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBO_Entidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Entidade.Enabled = False
        Me.CBO_Entidade.FormattingEnabled = True
        Me.CBO_Entidade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBO_Entidade.Location = New System.Drawing.Point(6, 19)
        Me.CBO_Entidade.Name = "CBO_Entidade"
        Me.CBO_Entidade.Size = New System.Drawing.Size(108, 21)
        Me.CBO_Entidade.TabIndex = 10080
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.CBO_Campo)
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(343, 152)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(113, 53)
        Me.G_Entidade.TabIndex = 10095
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Campo"
        '
        'CBO_Campo
        '
        Me.CBO_Campo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBO_Campo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBO_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Campo.Enabled = False
        Me.CBO_Campo.FormattingEnabled = True
        Me.CBO_Campo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBO_Campo.Location = New System.Drawing.Point(6, 19)
        Me.CBO_Campo.Name = "CBO_Campo"
        Me.CBO_Campo.Size = New System.Drawing.Size(94, 21)
        Me.CBO_Campo.TabIndex = 10079
        '
        'G_Funcao
        '
        Me.G_Funcao.BackColor = System.Drawing.Color.Transparent
        Me.G_Funcao.Controls.Add(Me.cbo_Funcao)
        Me.G_Funcao.ForeColor = System.Drawing.Color.White
        Me.G_Funcao.Location = New System.Drawing.Point(145, 152)
        Me.G_Funcao.Name = "G_Funcao"
        Me.G_Funcao.Size = New System.Drawing.Size(192, 53)
        Me.G_Funcao.TabIndex = 10094
        Me.G_Funcao.TabStop = False
        Me.G_Funcao.Text = "Função"
        '
        'cbo_Funcao
        '
        Me.cbo_Funcao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Funcao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Funcao.Enabled = False
        Me.cbo_Funcao.FormattingEnabled = True
        Me.cbo_Funcao.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_Funcao.Location = New System.Drawing.Point(6, 19)
        Me.cbo_Funcao.Name = "cbo_Funcao"
        Me.cbo_Funcao.Size = New System.Drawing.Size(180, 21)
        Me.cbo_Funcao.TabIndex = 10077
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_Campo)
        Me.GroupBox1.Controls.Add(Me.Rb_Funcao)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 134)
        Me.GroupBox1.TabIndex = 10093
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'Rb_Campo
        '
        Me.Rb_Campo.AutoSize = True
        Me.Rb_Campo.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Campo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Campo.ForeColor = System.Drawing.Color.White
        Me.Rb_Campo.Location = New System.Drawing.Point(6, 94)
        Me.Rb_Campo.Name = "Rb_Campo"
        Me.Rb_Campo.Size = New System.Drawing.Size(139, 19)
        Me.Rb_Campo.TabIndex = 52
        Me.Rb_Campo.Text = "Relatório por Campo"
        Me.Rb_Campo.UseVisualStyleBackColor = False
        '
        'Rb_Funcao
        '
        Me.Rb_Funcao.AutoSize = True
        Me.Rb_Funcao.BackColor = System.Drawing.Color.Transparent
        Me.Rb_Funcao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_Funcao.ForeColor = System.Drawing.Color.White
        Me.Rb_Funcao.Location = New System.Drawing.Point(6, 69)
        Me.Rb_Funcao.Name = "Rb_Funcao"
        Me.Rb_Funcao.Size = New System.Drawing.Size(140, 19)
        Me.Rb_Funcao.TabIndex = 51
        Me.Rb_Funcao.Text = "Relatório por Função"
        Me.Rb_Funcao.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioGeral
        '
        Me.Rb_RelatorioGeral.AutoSize = True
        Me.Rb_RelatorioGeral.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeral.Checked = True
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
        Me.Rb_RelatorioEntidade.Location = New System.Drawing.Point(6, 44)
        Me.Rb_RelatorioEntidade.Name = "Rb_RelatorioEntidade"
        Me.Rb_RelatorioEntidade.Size = New System.Drawing.Size(148, 19)
        Me.Rb_RelatorioEntidade.TabIndex = 50
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
        Me.btnRelatorio.Location = New System.Drawing.Point(214, 35)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10092
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'Fm_Relatorio_Funcoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(557, 216)
        Me.Controls.Add(Me.G_Campo)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.G_Funcao)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Relatorio_Funcoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Nomes e Funções"
        Me.G_Campo.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.G_Funcao.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G_Campo As System.Windows.Forms.GroupBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents G_Funcao As System.Windows.Forms.GroupBox
    Friend WithEvents CBO_Campo As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Funcao As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents Rb_Funcao As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_Campo As System.Windows.Forms.RadioButton
    Friend WithEvents CBO_Entidade As System.Windows.Forms.ComboBox
End Class
