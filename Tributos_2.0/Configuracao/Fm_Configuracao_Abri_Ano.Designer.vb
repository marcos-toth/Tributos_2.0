<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Configuracao_Abri_Ano
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Configuracao_Abri_Ano))
        Me.Cbo_Ano = New System.Windows.Forms.ComboBox()
        Me.Btn_Abri_Ano = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_Inform = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cbo_Ano
        '
        Me.Cbo_Ano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Ano.FormattingEnabled = True
        Me.Cbo_Ano.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021"})
        Me.Cbo_Ano.Location = New System.Drawing.Point(80, 54)
        Me.Cbo_Ano.Name = "Cbo_Ano"
        Me.Cbo_Ano.Size = New System.Drawing.Size(62, 21)
        Me.Cbo_Ano.TabIndex = 0
        '
        'Btn_Abri_Ano
        '
        Me.Btn_Abri_Ano.Location = New System.Drawing.Point(148, 54)
        Me.Btn_Abri_Ano.Name = "Btn_Abri_Ano"
        Me.Btn_Abri_Ano.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Abri_Ano.TabIndex = 1
        Me.Btn_Abri_Ano.Text = "Verificar"
        Me.Btn_Abri_Ano.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selecione o Ano Que Deseja Abrir"
        '
        'LB_Inform
        '
        Me.LB_Inform.AutoSize = True
        Me.LB_Inform.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Inform.ForeColor = System.Drawing.Color.SandyBrown
        Me.LB_Inform.Location = New System.Drawing.Point(13, 87)
        Me.LB_Inform.Name = "LB_Inform"
        Me.LB_Inform.Size = New System.Drawing.Size(282, 20)
        Me.LB_Inform.TabIndex = 3
        Me.LB_Inform.Text = "Selecione o Ano Que Deseja Abrir"
        '
        'Fm_Configuracao_Abri_Ano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 139)
        Me.Controls.Add(Me.LB_Inform)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Abri_Ano)
        Me.Controls.Add(Me.Cbo_Ano)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Configuracao_Abri_Ano"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Abrir Ano"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbo_Ano As System.Windows.Forms.ComboBox
    Friend WithEvents Btn_Abri_Ano As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LB_Inform As System.Windows.Forms.Label
End Class
