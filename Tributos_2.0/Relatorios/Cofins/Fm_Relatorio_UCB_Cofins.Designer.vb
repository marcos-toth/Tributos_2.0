﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Relatorio_UCB_Cofins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Relatorio_UCB_Cofins))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cb_Ano = New System.Windows.Forms.ComboBox()
        Me.Cb_Mes = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rb_RelatorioGeral = New System.Windows.Forms.RadioButton()
        Me.Rb_RelatorioEntidade = New System.Windows.Forms.RadioButton()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_Recolhido = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.G_Entidade = New System.Windows.Forms.GroupBox()
        Me.Cb_EntidadeMae = New System.Windows.Forms.ComboBox()
        CNPJClientesLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.G_Entidade.SuspendLayout()
        Me.SuspendLayout()
        '
        'CNPJClientesLabel
        '
        CNPJClientesLabel.AutoSize = True
        CNPJClientesLabel.BackColor = System.Drawing.Color.Transparent
        CNPJClientesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CNPJClientesLabel.ForeColor = System.Drawing.Color.Black
        CNPJClientesLabel.Location = New System.Drawing.Point(23, 22)
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 265)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 53)
        Me.GroupBox3.TabIndex = 10088
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioGeral)
        Me.GroupBox1.Controls.Add(Me.Rb_RelatorioEntidade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(210, 69)
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
        Me.btnRelatorio.Location = New System.Drawing.Point(23, 336)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(125, 93)
        Me.btnRelatorio.TabIndex = 10085
        Me.btnRelatorio.Text = "&Gerar Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRelatorio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(288, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(378, 273)
        Me.PictureBox1.TabIndex = 10083
        Me.PictureBox1.TabStop = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(566, 3)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 10089
        Me.txtData.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.RB_Recolhido)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(23, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(210, 76)
        Me.GroupBox2.TabIndex = 10091
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
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(6, 44)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton2.TabIndex = 50
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Não Recolhido"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'G_Entidade
        '
        Me.G_Entidade.BackColor = System.Drawing.Color.Transparent
        Me.G_Entidade.Controls.Add(Me.Cb_EntidadeMae)
        Me.G_Entidade.Enabled = False
        Me.G_Entidade.ForeColor = System.Drawing.Color.Black
        Me.G_Entidade.Location = New System.Drawing.Point(23, 206)
        Me.G_Entidade.Name = "G_Entidade"
        Me.G_Entidade.Size = New System.Drawing.Size(210, 53)
        Me.G_Entidade.TabIndex = 10093
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
        'Fm_Relatorio_UCB_Cofins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(660, 448)
        Me.Controls.Add(Me.G_Entidade)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRelatorio)
        Me.Controls.Add(CNPJClientesLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Relatorio_UCB_Cofins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório COFINS - UCB"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.G_Entidade.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Mes As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rb_RelatorioGeral As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_RelatorioEntidade As System.Windows.Forms.RadioButton
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_Recolhido As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents G_Entidade As System.Windows.Forms.GroupBox
    Friend WithEvents Cb_EntidadeMae As System.Windows.Forms.ComboBox
End Class