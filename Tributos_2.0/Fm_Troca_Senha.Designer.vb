<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Troca_Senha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Troca_Senha))
        Me.G_Senha = New System.Windows.Forms.GroupBox()
        Me.Btn_Sair2 = New System.Windows.Forms.Button()
        Me.txt_CSenha = New System.Windows.Forms.TextBox()
        Me.Txt_NSenha = New System.Windows.Forms.TextBox()
        Me.Btn_Alterar = New System.Windows.Forms.Button()
        Me.LBInfor = New System.Windows.Forms.Label()
        Me.G_Senha.SuspendLayout()
        Me.SuspendLayout()
        '
        'G_Senha
        '
        Me.G_Senha.BackColor = System.Drawing.Color.Transparent
        Me.G_Senha.Controls.Add(Me.Btn_Sair2)
        Me.G_Senha.Controls.Add(Me.txt_CSenha)
        Me.G_Senha.Controls.Add(Me.Txt_NSenha)
        Me.G_Senha.Controls.Add(Me.Btn_Alterar)
        Me.G_Senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_Senha.ForeColor = System.Drawing.Color.Black
        Me.G_Senha.Location = New System.Drawing.Point(31, 21)
        Me.G_Senha.Name = "G_Senha"
        Me.G_Senha.Size = New System.Drawing.Size(220, 95)
        Me.G_Senha.TabIndex = 10082
        Me.G_Senha.TabStop = False
        Me.G_Senha.Text = "Alterar Senha"
        '
        'Btn_Sair2
        '
        Me.Btn_Sair2.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Sair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Sair2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sair2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Sair2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_Sair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Sair2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sair2.Image = CType(resources.GetObject("Btn_Sair2.Image"), System.Drawing.Image)
        Me.Btn_Sair2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Sair2.Location = New System.Drawing.Point(123, 51)
        Me.Btn_Sair2.Name = "Btn_Sair2"
        Me.Btn_Sair2.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Sair2.TabIndex = 56
        Me.Btn_Sair2.Text = "Sair"
        Me.Btn_Sair2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Sair2.UseVisualStyleBackColor = False
        '
        'txt_CSenha
        '
        Me.txt_CSenha.Location = New System.Drawing.Point(113, 19)
        Me.txt_CSenha.MaxLength = 45
        Me.txt_CSenha.Name = "txt_CSenha"
        Me.txt_CSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_CSenha.Size = New System.Drawing.Size(99, 21)
        Me.txt_CSenha.TabIndex = 2
        Me.txt_CSenha.Text = "123458"
        Me.txt_CSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_NSenha
        '
        Me.Txt_NSenha.Location = New System.Drawing.Point(8, 19)
        Me.Txt_NSenha.MaxLength = 45
        Me.Txt_NSenha.Name = "Txt_NSenha"
        Me.Txt_NSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_NSenha.Size = New System.Drawing.Size(99, 21)
        Me.Txt_NSenha.TabIndex = 1
        Me.Txt_NSenha.Text = "123456"
        Me.Txt_NSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Alterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alterar.Image = CType(resources.GetObject("Btn_Alterar.Image"), System.Drawing.Image)
        Me.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Alterar.Location = New System.Drawing.Point(18, 51)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.Size = New System.Drawing.Size(80, 29)
        Me.Btn_Alterar.TabIndex = 2
        Me.Btn_Alterar.Text = "Gravar"
        Me.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Alterar.UseVisualStyleBackColor = False
        '
        'LBInfor
        '
        Me.LBInfor.AutoSize = True
        Me.LBInfor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBInfor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LBInfor.Location = New System.Drawing.Point(31, 132)
        Me.LBInfor.Name = "LBInfor"
        Me.LBInfor.Size = New System.Drawing.Size(51, 15)
        Me.LBInfor.TabIndex = 10083
        Me.LBInfor.Text = "Label1"
        '
        'Fm_Troca_Senha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 157)
        Me.Controls.Add(Me.LBInfor)
        Me.Controls.Add(Me.G_Senha)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Troca_Senha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar a Senha"
        Me.G_Senha.ResumeLayout(False)
        Me.G_Senha.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents G_Senha As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Sair2 As System.Windows.Forms.Button
    Friend WithEvents txt_CSenha As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NSenha As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents LBInfor As System.Windows.Forms.Label
End Class
