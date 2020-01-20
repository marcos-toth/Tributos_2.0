<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Centralizacao_Entidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Centralizacao_Entidade))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.cbo_Campo = New System.Windows.Forms.ComboBox()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBO_Categoria = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(26, 9)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(261, 24)
        CNPJClientesLabel.TabIndex = 10095
        CNPJClientesLabel.Text = "Selecione o Campo e a Categoria"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.Controls.Add(Me.Cb_Mes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(79, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(154, 53)
        Me.GroupBox3.TabIndex = 10094
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mês de Competência / Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Ano.Location = New System.Drawing.Point(77, 19)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(67, 21)
        Me.Cb_Ano.TabIndex = 54
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(6, 19)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(48, 21)
        Me.Cb_Mes.TabIndex = 53
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.cbo_Campo)
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(71, 114)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(170, 53)
        Me.G_Entidade.TabIndex = 10093
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Campo"
        '
        'cbo_Campo
        '
        Me.cbo_Campo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbo_Campo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_Campo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Campo.FormattingEnabled = True
        Me.cbo_Campo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_Campo.Location = New System.Drawing.Point(6, 19)
        Me.cbo_Campo.Name = "cbo_Campo"
        Me.cbo_Campo.Size = New System.Drawing.Size(94, 21)
        Me.cbo_Campo.TabIndex = 10077
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
        Me.btnRelatorio.Location = New System.Drawing.Point(94, 291)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10092
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CBO_Categoria)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(71, 173)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 53)
        Me.GroupBox1.TabIndex = 10094
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categoria"
        '
        'CBO_Categoria
        '
        Me.CBO_Categoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBO_Categoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBO_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_Categoria.FormattingEnabled = True
        Me.CBO_Categoria.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CBO_Categoria.Location = New System.Drawing.Point(6, 19)
        Me.CBO_Categoria.Name = "CBO_Categoria"
        Me.CBO_Categoria.Size = New System.Drawing.Size(94, 21)
        Me.CBO_Categoria.TabIndex = 10077
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox2.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(51, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 66)
        Me.GroupBox2.TabIndex = 10092
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo"
        '
        'Rb_RelatorioGeral
        '
        Me.Rb_RelatorioGeral.AutoSize = True
        Me.Rb_RelatorioGeral.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeral.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeral.Location = New System.Drawing.Point(6, 15)
        Me.Rb_RelatorioGeral.Name = "Rb_RelatorioGeral"
        Me.Rb_RelatorioGeral.Size = New System.Drawing.Size(108, 19)
        Me.Rb_RelatorioGeral.TabIndex = 49
        Me.Rb_RelatorioGeral.Text = "Relatório Geral"
        Me.Rb_RelatorioGeral.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioEntidade
        '
        Me.Rb_RelatorioEntidade.AutoSize = True
        Me.Rb_RelatorioEntidade.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioEntidade.Checked = True
        Me.Rb_RelatorioEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioEntidade.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioEntidade.Location = New System.Drawing.Point(6, 37)
        Me.Rb_RelatorioEntidade.Name = "Rb_RelatorioEntidade"
        Me.Rb_RelatorioEntidade.Size = New System.Drawing.Size(148, 19)
        Me.Rb_RelatorioEntidade.TabIndex = 50
        Me.Rb_RelatorioEntidade.TabStop = True
        Me.Rb_RelatorioEntidade.Text = "Relatório por Entidade"
        Me.Rb_RelatorioEntidade.UseVisualStyleBackColor = False
        '
        'Fm_Relatorio_Centralizacao_Entidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(325, 394)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.btnRelatorio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Relatorio_Centralizacao_Entidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório Centralização Por Entidade"
        Me.GroupBox3.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Campo As System.Windows.Forms.ComboBox
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBO_Categoria As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
End Class
