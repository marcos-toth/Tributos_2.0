<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_Campo_COFINS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_Campo_COFINS))
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Cb_Entidade = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.White
        CNPJClientesLabel.Location = New System.Drawing.Point(30, 20)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10091
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(573, 1)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 10096
        Me.txtData.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.Controls.Add(Me.Cb_Mes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(30, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 53)
        Me.GroupBox3.TabIndex = 10095
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
        Me.G_Entidade.Controls.Add(Me.Cb_Entidade)
        Me.G_Entidade.Enabled = False
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(30, 145)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(210, 53)
        Me.G_Entidade.TabIndex = 10094
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Entidade"
        '
        'Cb_Entidade
        '
        Me.Cb_Entidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Entidade.FormattingEnabled = True
        Me.Cb_Entidade.Location = New System.Drawing.Point(6, 19)
        Me.Cb_Entidade.Name = "Cb_Entidade"
        Me.Cb_Entidade.Size = New System.Drawing.Size(119, 21)
        Me.Cb_Entidade.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(30, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 92)
        Me.GroupBox1.TabIndex = 10093
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
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
        Me.Rb_RelatorioEntidade.Location = New System.Drawing.Point(6, 53)
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
        Me.btnRelatorio.Location = New System.Drawing.Point(30, 275)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10092
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(246, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 273)
        Me.PictureBox1.TabIndex = 10090
        Me.PictureBox1.TabStop = False
        '
        'Fm_Relatorio_Campo_COFINS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(557, 371)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Relatorio_Campo_COFINS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de COFINS Cadastrados "
        Me.GroupBox3.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Entidade As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
