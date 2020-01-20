<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_UCB_IR_Resisao_Contrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_UCB_IR_Resisao_Contrato))
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Cb_EntidadeMae = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_Recolhido = New System.Windows.Forms.RadioButton()
        Me.Rb_N_Recolhido = New System.Windows.Forms.RadioButton()
        Me.G_Datas = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.Cbo_Data = New System.Windows.Forms.ComboBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.G_Entidade.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.G_Datas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.Black
        CNPJClientesLabel.Location = New System.Drawing.Point(9, 32)
        CNPJClientesLabel.Name = "CNPJClientesLabel"
        CNPJClientesLabel.Size = New System.Drawing.Size(245, 24)
        CNPJClientesLabel.TabIndex = 10100
        CNPJClientesLabel.Text = "Selecione o Relatório Desejado"
        CNPJClientesLabel.UseCompatibleTextRendering = True
        CNPJClientesLabel.UseWaitCursor = True
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.Cb_EntidadeMae)
        Me.G_Entidade.Enabled = False
        Me.G_Entidade.ForeColor = System.Drawing.Color.Black
        Me.G_Entidade.Location = New System.Drawing.Point(26, 216)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(210, 53)
        Me.G_Entidade.TabIndex = 10105
        Me.G_Entidade.TabStop = False
        Me.G_Entidade.Text = "Tipo Entidade"
        '
        'Cb_EntidadeMae
        '
        Me.Cb_EntidadeMae.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Cb_EntidadeMae.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_EntidadeMae.FormattingEnabled = True
        Me.Cb_EntidadeMae.Location = New System.Drawing.Point(6, 19)
        Me.Cb_EntidadeMae.Name = "Cb_EntidadeMae"
        Me.Cb_EntidadeMae.Size = New System.Drawing.Size(119, 21)
        Me.Cb_EntidadeMae.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cbo_Data)
        Me.GroupBox2.Controls.Add(Me.RB_Recolhido)
        Me.GroupBox2.Controls.Add(Me.Rb_N_Recolhido)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(26, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 76)
        Me.GroupBox2.TabIndex = 10104
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Guia"
        '
        'RB_Recolhido
        '
        Me.RB_Recolhido.AutoSize = True
        Me.RB_Recolhido.BackColor = System.Drawing.Color.Transparent
        Me.RB_Recolhido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Recolhido.ForeColor = System.Drawing.Color.Black
        Me.RB_Recolhido.Location = New System.Drawing.Point(6, 19)
        Me.RB_Recolhido.Name = "RB_Recolhido"
        Me.RB_Recolhido.Size = New System.Drawing.Size(81, 19)
        Me.RB_Recolhido.TabIndex = 49
        Me.RB_Recolhido.Text = "Recolhido"
        Me.RB_Recolhido.UseVisualStyleBackColor = False
        '
        'Rb_N_Recolhido
        '
        Me.Rb_N_Recolhido.AutoSize = True
        Me.Rb_N_Recolhido.BackColor = System.Drawing.Color.Transparent
        Me.Rb_N_Recolhido.Checked = True
        Me.Rb_N_Recolhido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_N_Recolhido.ForeColor = System.Drawing.Color.Black
        Me.Rb_N_Recolhido.Location = New System.Drawing.Point(6, 44)
        Me.Rb_N_Recolhido.Name = "Rb_N_Recolhido"
        Me.Rb_N_Recolhido.Size = New System.Drawing.Size(107, 19)
        Me.Rb_N_Recolhido.TabIndex = 50
        Me.Rb_N_Recolhido.TabStop = True
        Me.Rb_N_Recolhido.Text = "Não Recolhido"
        Me.Rb_N_Recolhido.UseVisualStyleBackColor = False
        '
        'G_Datas
        '
        Me.G_Datas.BackColor = System.Drawing.Color.Transparent
        Me.G_Datas.Controls.Add(Me.Cb_Ano)
        Me.G_Datas.Controls.Add(Me.Cb_Mes)
        Me.G_Datas.ForeColor = System.Drawing.Color.Black
        Me.G_Datas.Location = New System.Drawing.Point(26, 275)
        Me.G_Datas.Name = "G_Datas"
        Me.G_Datas.Size = New System.Drawing.Size(210, 53)
        Me.G_Datas.TabIndex = 10103
        Me.G_Datas.TabStop = False
        Me.G_Datas.Text = "Mês / Ano Recolhimento"
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(26, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 69)
        Me.GroupBox1.TabIndex = 10102
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
        Me.btnRelatorio.Location = New System.Drawing.Point(69, 346)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10101
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'Cbo_Data
        '
        Me.Cbo_Data.FormattingEnabled = True
        Me.Cbo_Data.Location = New System.Drawing.Point(99, 17)
        Me.Cbo_Data.Name = "Cbo_Data"
        Me.Cbo_Data.Size = New System.Drawing.Size(105, 21)
        Me.Cbo_Data.TabIndex = 51
        Me.Cbo_Data.Visible = False
        '
        'Fm_UCB_IR_Resisao_Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(292, 488)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.G_Datas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_UCB_IR_Resisao_Contrato"
        Me.Text = "Relatótio Recolhimento IR Recisão Aluguel"
        Me.G_Entidade.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.G_Datas.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_EntidadeMae As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Recolhido As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_N_Recolhido As System.Windows.Forms.RadioButton
    Friend WithEvents G_Datas As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents Cbo_Data As System.Windows.Forms.ComboBox
End Class
