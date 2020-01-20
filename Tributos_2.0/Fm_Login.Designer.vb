<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Login))
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.G_Senha = New System.Windows.Forms.GroupBox()
        Me.Btn_Sair2 = New System.Windows.Forms.Button()
        Me.txt_CSenha = New System.Windows.Forms.TextBox()
        Me.Txt_NSenha = New System.Windows.Forms.TextBox()
        Me.Btn_Alterar = New System.Windows.Forms.Button()
        Me.lb_Inf = New System.Windows.Forms.Label()
        Me.G_Login = New System.Windows.Forms.GroupBox()
        Me.lb_TrocaaSenha = New System.Windows.Forms.Label()
        Me.lb_Versao = New System.Windows.Forms.Label()
        Me.Lb_mensagem = New System.Windows.Forms.Label()
        Me.G_Senha.SuspendLayout()
        Me.G_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSenha.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSenha.Location = New System.Drawing.Point(144, 70)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(116, 21)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtSenha.UseSystemPasswordChar = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtUsuario.Location = New System.Drawing.Point(145, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(116, 21)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(93, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 998
        Me.Label2.Text = "Senha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 899
        Me.Label1.Text = "Nome de Usuário:"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.Transparent
        Me.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.Image = CType(resources.GetObject("btnSair.Image"), System.Drawing.Image)
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(180, 108)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(80, 29)
        Me.btnSair.TabIndex = 55
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnEntrar
        '
        Me.btnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntrar.Enabled = False
        Me.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen
        Me.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrar.Image = CType(resources.GetObject("btnEntrar.Image"), System.Drawing.Image)
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.Location = New System.Drawing.Point(63, 108)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(80, 29)
        Me.btnEntrar.TabIndex = 3
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntrar.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
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
        Me.G_Senha.Location = New System.Drawing.Point(371, 53)
        Me.G_Senha.Name = "G_Senha"
        Me.G_Senha.Size = New System.Drawing.Size(220, 95)
        Me.G_Senha.TabIndex = 10081
        Me.G_Senha.TabStop = False
        Me.G_Senha.Text = "Troca de Senha"
        Me.G_Senha.Visible = False
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
        'lb_Inf
        '
        Me.lb_Inf.BackColor = System.Drawing.Color.Transparent
        Me.lb_Inf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Inf.ForeColor = System.Drawing.Color.Black
        Me.lb_Inf.Location = New System.Drawing.Point(6, 187)
        Me.lb_Inf.Name = "lb_Inf"
        Me.lb_Inf.Size = New System.Drawing.Size(302, 18)
        Me.lb_Inf.TabIndex = 10082
        Me.lb_Inf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'G_Login
        '
        Me.G_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.G_Login.Controls.Add(Me.lb_TrocaaSenha)
        Me.G_Login.Controls.Add(Me.lb_Inf)
        Me.G_Login.Controls.Add(Me.btnEntrar)
        Me.G_Login.Controls.Add(Me.btnSair)
        Me.G_Login.Controls.Add(Me.Label2)
        Me.G_Login.Controls.Add(Me.txtSenha)
        Me.G_Login.Controls.Add(Me.txtUsuario)
        Me.G_Login.Controls.Add(Me.Label1)
        Me.G_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.G_Login.ForeColor = System.Drawing.Color.Black
        Me.G_Login.Location = New System.Drawing.Point(323, 34)
        Me.G_Login.Name = "G_Login"
        Me.G_Login.Size = New System.Drawing.Size(314, 208)
        Me.G_Login.TabIndex = 10081
        Me.G_Login.TabStop = False
        Me.G_Login.Text = "Login"
        '
        'lb_TrocaaSenha
        '
        Me.lb_TrocaaSenha.AutoSize = True
        Me.lb_TrocaaSenha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lb_TrocaaSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_TrocaaSenha.ForeColor = System.Drawing.Color.Blue
        Me.lb_TrocaaSenha.Location = New System.Drawing.Point(192, 165)
        Me.lb_TrocaaSenha.Name = "lb_TrocaaSenha"
        Me.lb_TrocaaSenha.Size = New System.Drawing.Size(69, 13)
        Me.lb_TrocaaSenha.TabIndex = 999
        Me.lb_TrocaaSenha.Text = "Troca Senha"
        Me.lb_TrocaaSenha.Visible = False
        '
        'lb_Versao
        '
        Me.lb_Versao.AutoSize = True
        Me.lb_Versao.BackColor = System.Drawing.Color.Transparent
        Me.lb_Versao.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_Versao.ForeColor = System.Drawing.Color.Black
        Me.lb_Versao.Location = New System.Drawing.Point(539, 18)
        Me.lb_Versao.Name = "lb_Versao"
        Me.lb_Versao.Size = New System.Drawing.Size(91, 13)
        Me.lb_Versao.TabIndex = 10083
        Me.lb_Versao.Text = "Versão 1.0.1.2"
        '
        'Lb_mensagem
        '
        Me.Lb_mensagem.AutoSize = True
        Me.Lb_mensagem.BackColor = System.Drawing.Color.Transparent
        Me.Lb_mensagem.Font = New System.Drawing.Font("Consolas", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_mensagem.ForeColor = System.Drawing.Color.Black
        Me.Lb_mensagem.Location = New System.Drawing.Point(321, 252)
        Me.Lb_mensagem.Name = "Lb_mensagem"
        Me.Lb_mensagem.Size = New System.Drawing.Size(0, 9)
        Me.Lb_mensagem.TabIndex = 10084
        '
        'Fm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 270)
        Me.Controls.Add(Me.Lb_mensagem)
        Me.Controls.Add(Me.lb_Versao)
        Me.Controls.Add(Me.G_Login)
        Me.Controls.Add(Me.G_Senha)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.G_Senha.ResumeLayout(False)
        Me.G_Senha.PerformLayout()
        Me.G_Login.ResumeLayout(False)
        Me.G_Login.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents G_Senha As System.Windows.Forms.GroupBox
    Friend WithEvents txt_CSenha As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NSenha As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Alterar As System.Windows.Forms.Button
    Friend WithEvents lb_Inf As System.Windows.Forms.Label
    Friend WithEvents G_Login As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Sair2 As System.Windows.Forms.Button
    Friend WithEvents lb_TrocaaSenha As System.Windows.Forms.Label
    Friend WithEvents lb_Versao As System.Windows.Forms.Label
    Friend WithEvents Lb_mensagem As System.Windows.Forms.Label
End Class
