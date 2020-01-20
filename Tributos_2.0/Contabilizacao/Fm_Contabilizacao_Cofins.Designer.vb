<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Contabilizacao_Cofins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Contabilizacao_Cofins))
        Me.LB_Informacao = New System.Windows.Forms.Label()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.Btn_Contabilizar = New System.Windows.Forms.Button()
        Me.Txt_Data_Pagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.R_Fechar = New System.Windows.Forms.RadioButton()
        Me.R_Contabilizar = New System.Windows.Forms.RadioButton()
        Me.LB_Periodo = New System.Windows.Forms.Label()
        Me.CB_Periodo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LB_Informacao
        '
        Me.LB_Informacao.AutoSize = True
        Me.LB_Informacao.Location = New System.Drawing.Point(28, 41)
        Me.LB_Informacao.Name = "LB_Informacao"
        Me.LB_Informacao.Size = New System.Drawing.Size(354, 13)
        Me.LB_Informacao.TabIndex = 10
        Me.LB_Informacao.Text = "Favor Inserir a Data do Fechamento da Guia de COFINS S/ Faturamento."
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInform.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbInform.Location = New System.Drawing.Point(28, 153)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(55, 16)
        Me.lbInform.TabIndex = 9
        Me.lbInform.Text = "Label2"
        '
        'Btn_Contabilizar
        '
        Me.Btn_Contabilizar.Location = New System.Drawing.Point(115, 120)
        Me.Btn_Contabilizar.Name = "Btn_Contabilizar"
        Me.Btn_Contabilizar.Size = New System.Drawing.Size(95, 23)
        Me.Btn_Contabilizar.TabIndex = 8
        Me.Btn_Contabilizar.Text = "Contabilizar"
        Me.Btn_Contabilizar.UseVisualStyleBackColor = True
        '
        'Txt_Data_Pagamento
        '
        Me.Txt_Data_Pagamento.Location = New System.Drawing.Point(28, 122)
        Me.Txt_Data_Pagamento.Mask = "00/00/0000"
        Me.Txt_Data_Pagamento.Name = "Txt_Data_Pagamento"
        Me.Txt_Data_Pagamento.Size = New System.Drawing.Size(69, 20)
        Me.Txt_Data_Pagamento.TabIndex = 7
        Me.Txt_Data_Pagamento.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Data:"
        '
        'R_Fechar
        '
        Me.R_Fechar.AutoSize = True
        Me.R_Fechar.Checked = True
        Me.R_Fechar.Location = New System.Drawing.Point(28, 12)
        Me.R_Fechar.Name = "R_Fechar"
        Me.R_Fechar.Size = New System.Drawing.Size(83, 17)
        Me.R_Fechar.TabIndex = 11
        Me.R_Fechar.TabStop = True
        Me.R_Fechar.Text = "Fechar Guia"
        Me.R_Fechar.UseVisualStyleBackColor = True
        '
        'R_Contabilizar
        '
        Me.R_Contabilizar.AutoSize = True
        Me.R_Contabilizar.Location = New System.Drawing.Point(115, 12)
        Me.R_Contabilizar.Name = "R_Contabilizar"
        Me.R_Contabilizar.Size = New System.Drawing.Size(79, 17)
        Me.R_Contabilizar.TabIndex = 11
        Me.R_Contabilizar.Text = "Contabilizar"
        Me.R_Contabilizar.UseVisualStyleBackColor = True
        '
        'LB_Periodo
        '
        Me.LB_Periodo.AutoSize = True
        Me.LB_Periodo.Location = New System.Drawing.Point(28, 66)
        Me.LB_Periodo.Name = "LB_Periodo"
        Me.LB_Periodo.Size = New System.Drawing.Size(132, 13)
        Me.LB_Periodo.TabIndex = 12
        Me.LB_Periodo.Text = "Mês Para Encerrar a Guia:"
        '
        'CB_Periodo
        '
        Me.CB_Periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Periodo.FormattingEnabled = True
        Me.CB_Periodo.Location = New System.Drawing.Point(28, 82)
        Me.CB_Periodo.Name = "CB_Periodo"
        Me.CB_Periodo.Size = New System.Drawing.Size(39, 21)
        Me.CB_Periodo.TabIndex = 13
        '
        'Fm_Contabilizacao_Cofins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 178)
        Me.Controls.Add(Me.CB_Periodo)
        Me.Controls.Add(Me.LB_Periodo)
        Me.Controls.Add(Me.R_Contabilizar)
        Me.Controls.Add(Me.R_Fechar)
        Me.Controls.Add(Me.LB_Informacao)
        Me.Controls.Add(Me.lbInform)
        Me.Controls.Add(Me.Btn_Contabilizar)
        Me.Controls.Add(Me.Txt_Data_Pagamento)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Contabilizacao_Cofins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encerramento COFINS S/ Faturamento "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Informacao As System.Windows.Forms.Label
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents Btn_Contabilizar As System.Windows.Forms.Button
    Friend WithEvents Txt_Data_Pagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents R_Fechar As System.Windows.Forms.RadioButton
    Friend WithEvents R_Contabilizar As System.Windows.Forms.RadioButton
    Friend WithEvents LB_Periodo As System.Windows.Forms.Label
    Friend WithEvents CB_Periodo As System.Windows.Forms.ComboBox
End Class
