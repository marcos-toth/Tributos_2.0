<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_IR_Recisao_Aluguel
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
        Dim CNPJClientesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_IR_Recisao_Aluguel))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Cb_EntidadeMae = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioGeralMensalEntidade = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioGeralMensal = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioGeralAnualEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.txtData = New System.Windows.Forms.TextBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
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
        CNPJClientesLabel.Location = New System.Drawing.Point(16, 11)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10084
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cb_Ano)
        Me.GroupBox3.Controls.Add(Me.Cb_Mes)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(51, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(166, 53)
        Me.GroupBox3.TabIndex = 10088
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mês do Lançamento / Ano"
        '
        'Cb_Ano
        '
        Me.Cb_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Ano.FormattingEnabled = True
        Me.Cb_Ano.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Ano.Location = New System.Drawing.Point(81, 20)
        Me.Cb_Ano.Name = "Cb_Ano"
        Me.Cb_Ano.Size = New System.Drawing.Size(67, 21)
        Me.Cb_Ano.TabIndex = 54
        '
        'Cb_Mes
        '
        Me.Cb_Mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Mes.Enabled = False
        Me.Cb_Mes.FormattingEnabled = True
        Me.Cb_Mes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.Cb_Mes.Location = New System.Drawing.Point(12, 20)
        Me.Cb_Mes.Name = "Cb_Mes"
        Me.Cb_Mes.Size = New System.Drawing.Size(48, 21)
        Me.Cb_Mes.TabIndex = 53
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.Cb_EntidadeMae)
        Me.G_Entidade.Enabled = False
        Me.G_Entidade.ForeColor = System.Drawing.Color.White
        Me.G_Entidade.Location = New System.Drawing.Point(51, 227)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(166, 53)
        Me.G_Entidade.TabIndex = 10087
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Tipo Entidade"
        '
        'Cb_EntidadeMae
        '
        Me.Cb_EntidadeMae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_EntidadeMae.FormattingEnabled = True
        Me.Cb_EntidadeMae.Location = New System.Drawing.Point(24, 19)
        Me.Cb_EntidadeMae.Name = "Cb_EntidadeMae"
        Me.Cb_EntidadeMae.Size = New System.Drawing.Size(119, 21)
        Me.Cb_EntidadeMae.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeralMensalEntidade)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeralMensal)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeralAnualEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(16, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 124)
        Me.GroupBox1.TabIndex = 10086
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
        Me.Rb_RelatorioGeral.Size = New System.Drawing.Size(142, 19)
        Me.Rb_RelatorioGeral.TabIndex = 49
        Me.Rb_RelatorioGeral.TabStop = True
        Me.Rb_RelatorioGeral.Text = "Relatório Geral Anual"
        Me.Rb_RelatorioGeral.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioGeralMensalEntidade
        '
        Me.Rb_RelatorioGeralMensalEntidade.AutoSize = True
        Me.Rb_RelatorioGeralMensalEntidade.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeralMensalEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeralMensalEntidade.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeralMensalEntidade.Location = New System.Drawing.Point(6, 88)
        Me.Rb_RelatorioGeralMensalEntidade.Name = "Rb_RelatorioGeralMensalEntidade"
        Me.Rb_RelatorioGeralMensalEntidade.Size = New System.Drawing.Size(226, 19)
        Me.Rb_RelatorioGeralMensalEntidade.TabIndex = 50
        Me.Rb_RelatorioGeralMensalEntidade.Text = "Relatório Geral Mensal Por Entidade"
        Me.Rb_RelatorioGeralMensalEntidade.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioGeralMensal
        '
        Me.Rb_RelatorioGeralMensal.AutoSize = True
        Me.Rb_RelatorioGeralMensal.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeralMensal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeralMensal.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeralMensal.Location = New System.Drawing.Point(6, 64)
        Me.Rb_RelatorioGeralMensal.Name = "Rb_RelatorioGeralMensal"
        Me.Rb_RelatorioGeralMensal.Size = New System.Drawing.Size(152, 19)
        Me.Rb_RelatorioGeralMensal.TabIndex = 50
        Me.Rb_RelatorioGeralMensal.Text = "Relatório Geral Mensal"
        Me.Rb_RelatorioGeralMensal.UseVisualStyleBackColor = False
        '
        'Rb_RelatorioGeralAnualEntidade
        '
        Me.Rb_RelatorioGeralAnualEntidade.AutoSize = True
        Me.Rb_RelatorioGeralAnualEntidade.BackColor = System.Drawing.Color.Transparent
        Me.Rb_RelatorioGeralAnualEntidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_RelatorioGeralAnualEntidade.ForeColor = System.Drawing.Color.White
        Me.Rb_RelatorioGeralAnualEntidade.Location = New System.Drawing.Point(6, 40)
        Me.Rb_RelatorioGeralAnualEntidade.Name = "Rb_RelatorioGeralAnualEntidade"
        Me.Rb_RelatorioGeralAnualEntidade.Size = New System.Drawing.Size(216, 19)
        Me.Rb_RelatorioGeralAnualEntidade.TabIndex = 50
        Me.Rb_RelatorioGeralAnualEntidade.Text = "Relatório Geral Anual Por Entidade"
        Me.Rb_RelatorioGeralAnualEntidade.UseVisualStyleBackColor = False
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
        Me.btnRelatorio.Location = New System.Drawing.Point(72, 295)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10085
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(438, 351)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 10089
        Me.txtData.Visible = False
        '
        'Fm_IR_Recisao_Aluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(274, 399)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_IR_Recisao_Aluguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IR Rescisão Contrato Aluguel"
        Me.GroupBox3.ResumeLayout(False)
        Me.G_Entidade.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_EntidadeMae As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioGeralMensalEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioGeralMensal As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioGeralAnualEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents txtData As System.Windows.Forms.TextBox
End Class
