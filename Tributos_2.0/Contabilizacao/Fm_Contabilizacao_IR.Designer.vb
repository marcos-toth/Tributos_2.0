﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Contabilizacao_IR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Contabilizacao_IR))
        Me.LB_Data_Pag = New System.Windows.Forms.Label()
        Me.Txt_Data_Pagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Btn_Contabilizar = New System.Windows.Forms.Button()
        Me.lbInform = New System.Windows.Forms.Label()
        Me.LB_Informacao = New System.Windows.Forms.Label()
        Me.R_Contabilizar = New System.Windows.Forms.RadioButton()
        Me.R_Fechar = New System.Windows.Forms.RadioButton()
        Me.CB_Periodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LB_Data_Pag
        '
        Me.LB_Data_Pag.AutoSize = True
        Me.LB_Data_Pag.Location = New System.Drawing.Point(14, 101)
        Me.LB_Data_Pag.Name = "LB_Data_Pag"
        Me.LB_Data_Pag.Size = New System.Drawing.Size(102, 13)
        Me.LB_Data_Pag.TabIndex = 0
        Me.LB_Data_Pag.Text = "Data Encerramento:"
        '
        'Txt_Data_Pagamento
        '
        Me.Txt_Data_Pagamento.Location = New System.Drawing.Point(113, 97)
        Me.Txt_Data_Pagamento.Mask = "00/00/0000"
        Me.Txt_Data_Pagamento.Name = "Txt_Data_Pagamento"
        Me.Txt_Data_Pagamento.Size = New System.Drawing.Size(69, 20)
        Me.Txt_Data_Pagamento.TabIndex = 2
        Me.Txt_Data_Pagamento.ValidatingType = GetType(Date)
        '
        'Btn_Contabilizar
        '
        Me.Btn_Contabilizar.Location = New System.Drawing.Point(186, 96)
        Me.Btn_Contabilizar.Name = "Btn_Contabilizar"
        Me.Btn_Contabilizar.Size = New System.Drawing.Size(103, 23)
        Me.Btn_Contabilizar.TabIndex = 3
        Me.Btn_Contabilizar.Text = "Encerrar"
        Me.Btn_Contabilizar.UseVisualStyleBackColor = True
        '
        'lbInform
        '
        Me.lbInform.AutoSize = True
        Me.lbInform.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInform.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbInform.Location = New System.Drawing.Point(14, 124)
        Me.lbInform.Name = "lbInform"
        Me.lbInform.Size = New System.Drawing.Size(55, 16)
        Me.lbInform.TabIndex = 4
        Me.lbInform.Text = "Label2"
        '
        'LB_Informacao
        '
        Me.LB_Informacao.AutoSize = True
        Me.LB_Informacao.Location = New System.Drawing.Point(12, 44)
        Me.LB_Informacao.Name = "LB_Informacao"
        Me.LB_Informacao.Size = New System.Drawing.Size(302, 13)
        Me.LB_Informacao.TabIndex = 5
        Me.LB_Informacao.Text = "Favor Inserir a Data do Pagamento da Guia de IR de Aluguéis."
        '
        'R_Contabilizar
        '
        Me.R_Contabilizar.AutoSize = True
        Me.R_Contabilizar.Location = New System.Drawing.Point(108, 24)
        Me.R_Contabilizar.Name = "R_Contabilizar"
        Me.R_Contabilizar.Size = New System.Drawing.Size(79, 17)
        Me.R_Contabilizar.TabIndex = 12
        Me.R_Contabilizar.Text = "Contabilizar"
        Me.R_Contabilizar.UseVisualStyleBackColor = True
        '
        'R_Fechar
        '
        Me.R_Fechar.AutoSize = True
        Me.R_Fechar.Checked = True
        Me.R_Fechar.Location = New System.Drawing.Point(12, 24)
        Me.R_Fechar.Name = "R_Fechar"
        Me.R_Fechar.Size = New System.Drawing.Size(83, 17)
        Me.R_Fechar.TabIndex = 13
        Me.R_Fechar.TabStop = True
        Me.R_Fechar.Text = "Fechar Guia"
        Me.R_Fechar.UseVisualStyleBackColor = True
        '
        'CB_Periodo
        '
        Me.CB_Periodo.FormattingEnabled = True
        Me.CB_Periodo.Location = New System.Drawing.Point(143, 66)
        Me.CB_Periodo.Name = "CB_Periodo"
        Me.CB_Periodo.Size = New System.Drawing.Size(39, 21)
        Me.CB_Periodo.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Mês Para Encerrar a Guia:"
        '
        'Fm_Contabilizacao_IR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 157)
        Me.Controls.Add(Me.CB_Periodo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.R_Contabilizar)
        Me.Controls.Add(Me.R_Fechar)
        Me.Controls.Add(Me.LB_Informacao)
        Me.Controls.Add(Me.lbInform)
        Me.Controls.Add(Me.Btn_Contabilizar)
        Me.Controls.Add(Me.Txt_Data_Pagamento)
        Me.Controls.Add(Me.LB_Data_Pag)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Contabilizacao_IR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilização IR Aluguéis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Data_Pag As System.Windows.Forms.Label
    Friend WithEvents Txt_Data_Pagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Btn_Contabilizar As System.Windows.Forms.Button
    Friend WithEvents lbInform As System.Windows.Forms.Label
    Friend WithEvents LB_Informacao As System.Windows.Forms.Label
    Friend WithEvents R_Contabilizar As System.Windows.Forms.RadioButton
    Friend WithEvents R_Fechar As System.Windows.Forms.RadioButton
    Friend WithEvents CB_Periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
