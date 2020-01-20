<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Cadastro_Entidade
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Cadastro_Entidade))
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.txtCodEntidade = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Nome_Entidade = New System.Windows.Forms.TextBox()
        Me.Txt_entidade_Mae = New System.Windows.Forms.TextBox()
        Me.Txt_IP = New System.Windows.Forms.TextBox()
        Me.Txt_Categoria = New System.Windows.Forms.TextBox()
        Me.Txt_Filiais = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Cb_Cofins = New System.Windows.Forms.ComboBox()
        Me.Cb_Deposito = New System.Windows.Forms.ComboBox()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Banco = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_Nome_Entidade_Mae = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txt_CNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnDeletar
        '
        Me.btnDeletar.BackColor = System.Drawing.Color.Transparent
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.Enabled = False
        Me.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeletar.ForeColor = System.Drawing.Color.Black
        Me.btnDeletar.Image = CType(resources.GetObject("btnDeletar.Image"), System.Drawing.Image)
        Me.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDeletar.Location = New System.Drawing.Point(169, 500)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(68, 58)
        Me.btnDeletar.TabIndex = 10068
        Me.btnDeletar.Text = "&Deletar"
        Me.btnDeletar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalvar.ForeColor = System.Drawing.Color.Black
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalvar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSalvar.Location = New System.Drawing.Point(16, 500)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 10085
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Image = CType(resources.GetObject("btnLimpar.Image"), System.Drawing.Image)
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLimpar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnLimpar.Location = New System.Drawing.Point(90, 500)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(68, 58)
        Me.btnLimpar.TabIndex = 10086
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'txtCodEntidade
        '
        Me.txtCodEntidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.txtCodEntidade.Location = New System.Drawing.Point(15, 27)
        Me.txtCodEntidade.MaxLength = 6
        Me.txtCodEntidade.Name = "txtCodEntidade"
        Me.txtCodEntidade.Size = New System.Drawing.Size(55, 20)
        Me.txtCodEntidade.TabIndex = 10076
        Me.txtCodEntidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 10070
        Me.Label3.Text = "Código da Entidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(12, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 15)
        Me.Label1.TabIndex = 10071
        Me.Label1.Text = "Nome da Entidade:"
        '
        'Txt_Nome_Entidade
        '
        Me.Txt_Nome_Entidade.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Nome_Entidade.Enabled = False
        Me.Txt_Nome_Entidade.Location = New System.Drawing.Point(15, 68)
        Me.Txt_Nome_Entidade.MaxLength = 55
        Me.Txt_Nome_Entidade.Name = "Txt_Nome_Entidade"
        Me.Txt_Nome_Entidade.Size = New System.Drawing.Size(272, 20)
        Me.Txt_Nome_Entidade.TabIndex = 10077
        '
        'Txt_entidade_Mae
        '
        Me.Txt_entidade_Mae.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_entidade_Mae.Enabled = False
        Me.Txt_entidade_Mae.Location = New System.Drawing.Point(15, 109)
        Me.Txt_entidade_Mae.MaxLength = 6
        Me.Txt_entidade_Mae.Name = "Txt_entidade_Mae"
        Me.Txt_entidade_Mae.Size = New System.Drawing.Size(72, 20)
        Me.Txt_entidade_Mae.TabIndex = 10078
        Me.Txt_entidade_Mae.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_IP
        '
        Me.Txt_IP.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_IP.Enabled = False
        Me.Txt_IP.Location = New System.Drawing.Point(15, 314)
        Me.Txt_IP.MaxLength = 50
        Me.Txt_IP.Name = "Txt_IP"
        Me.Txt_IP.Size = New System.Drawing.Size(110, 20)
        Me.Txt_IP.TabIndex = 10083
        Me.Txt_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Categoria
        '
        Me.Txt_Categoria.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Categoria.Enabled = False
        Me.Txt_Categoria.Location = New System.Drawing.Point(15, 188)
        Me.Txt_Categoria.MaxLength = 50
        Me.Txt_Categoria.Name = "Txt_Categoria"
        Me.Txt_Categoria.Size = New System.Drawing.Size(55, 20)
        Me.Txt_Categoria.TabIndex = 10080
        Me.Txt_Categoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Filiais
        '
        Me.Txt_Filiais.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Filiais.Enabled = False
        Me.Txt_Filiais.Location = New System.Drawing.Point(15, 150)
        Me.Txt_Filiais.MaxLength = 6
        Me.Txt_Filiais.Name = "Txt_Filiais"
        Me.Txt_Filiais.Size = New System.Drawing.Size(55, 20)
        Me.Txt_Filiais.TabIndex = 10079
        Me.Txt_Filiais.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(12, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 10080
        Me.Label2.Text = "COFINS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 10081
        Me.Label4.Text = "Filiais"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(12, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 10082
        Me.Label5.Text = "Deposito"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(12, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 15)
        Me.Label6.TabIndex = 10083
        Me.Label6.Text = "Categoria"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(21, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 15)
        Me.Label10.TabIndex = 10087
        Me.Label10.Text = "IP"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(12, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 15)
        Me.Label11.TabIndex = 10088
        Me.Label11.Text = "Entidade Mãe"
        '
        'Cb_Cofins
        '
        Me.Cb_Cofins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Cofins.Enabled = False
        Me.Cb_Cofins.FormattingEnabled = True
        Me.Cb_Cofins.Items.AddRange(New Object() {"S", "N"})
        Me.Cb_Cofins.Location = New System.Drawing.Point(15, 231)
        Me.Cb_Cofins.Name = "Cb_Cofins"
        Me.Cb_Cofins.Size = New System.Drawing.Size(53, 21)
        Me.Cb_Cofins.TabIndex = 10081
        '
        'Cb_Deposito
        '
        Me.Cb_Deposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cb_Deposito.Enabled = False
        Me.Cb_Deposito.FormattingEnabled = True
        Me.Cb_Deposito.Items.AddRange(New Object() {"S", "N"})
        Me.Cb_Deposito.Location = New System.Drawing.Point(15, 273)
        Me.Cb_Deposito.Name = "Cb_Deposito"
        Me.Cb_Deposito.Size = New System.Drawing.Size(53, 21)
        Me.Cb_Deposito.TabIndex = 10082
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbInform.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbInform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbInform.Location = New System.Drawing.Point(21, 482)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(27, 15)
        Me.lbInform.TabIndex = 10091
        Me.lbInform.Text = "Inf."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(12, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 10093
        Me.Label7.Text = "Banco"
        '
        'Txt_Banco
        '
        Me.Txt_Banco.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Banco.Enabled = False
        Me.Txt_Banco.Location = New System.Drawing.Point(15, 354)
        Me.Txt_Banco.MaxLength = 50
        Me.Txt_Banco.Name = "Txt_Banco"
        Me.Txt_Banco.Size = New System.Drawing.Size(110, 20)
        Me.Txt_Banco.TabIndex = 10092
        Me.Txt_Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(13, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 15)
        Me.Label8.TabIndex = 10096
        Me.Label8.Text = "Nome Entidade Mãe"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(13, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 15)
        Me.Label9.TabIndex = 10094
        Me.Label9.Text = "IP"
        '
        'Txt_Nome_Entidade_Mae
        '
        Me.Txt_Nome_Entidade_Mae.AccessibleDescription = "Colocar Apenas o Codigo da Entidade"
        Me.Txt_Nome_Entidade_Mae.Enabled = False
        Me.Txt_Nome_Entidade_Mae.Location = New System.Drawing.Point(15, 403)
        Me.Txt_Nome_Entidade_Mae.MaxLength = 55
        Me.Txt_Nome_Entidade_Mae.Name = "Txt_Nome_Entidade_Mae"
        Me.Txt_Nome_Entidade_Mae.Size = New System.Drawing.Size(280, 20)
        Me.Txt_Nome_Entidade_Mae.TabIndex = 10097
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(14, 432)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 15)
        Me.Label12.TabIndex = 10098
        Me.Label12.Text = "C.N.P.J Entidade Mãe"
        '
        'Txt_CNPJ
        '
        Me.Txt_CNPJ.Enabled = False
        Me.Txt_CNPJ.Location = New System.Drawing.Point(16, 450)
        Me.Txt_CNPJ.Mask = "00,000,000/0000-00"
        Me.Txt_CNPJ.Name = "Txt_CNPJ"
        Me.Txt_CNPJ.Size = New System.Drawing.Size(109, 20)
        Me.Txt_CNPJ.TabIndex = 10099
        '
        'Fm_Cadastro_Entidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 563)
        Me.Controls.Add(Me.Txt_CNPJ)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Txt_Nome_Entidade_Mae)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_Banco)
        Me.Controls.Add(Me.lbInform)
        Me.Controls.Add(Me.Cb_Deposito)
        Me.Controls.Add(Me.Cb_Cofins)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txt_Filiais)
        Me.Controls.Add(Me.Txt_Categoria)
        Me.Controls.Add(Me.Txt_IP)
        Me.Controls.Add(Me.Txt_entidade_Mae)
        Me.Controls.Add(Me.Txt_Nome_Entidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodEntidade)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnDeletar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLimpar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Cadastro_Entidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro da Entidade Entidade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeletar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents txtCodEntidade As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Nome_Entidade As System.Windows.Forms.TextBox
    Friend WithEvents Txt_entidade_Mae As System.Windows.Forms.TextBox
    Friend WithEvents Txt_IP As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Filiais As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Cb_Cofins As System.Windows.Forms.ComboBox
    Friend WithEvents Cb_Deposito As System.Windows.Forms.ComboBox
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Banco As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_Nome_Entidade_Mae As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_CNPJ As System.Windows.Forms.MaskedTextBox
End Class
