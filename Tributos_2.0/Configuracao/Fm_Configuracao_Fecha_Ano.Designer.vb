<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Configuracao_Fecha_Ano
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Configuracao_Fecha_Ano))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG_PeriodoF = New System.Windows.Forms.DataGridView()
        Me.Btn_Fecha_Mes = New System.Windows.Forms.Button()
        Me.Txt_Periodo = New System.Windows.Forms.TextBox()
        Me.DG_PeriodoA = New System.Windows.Forms.DataGridView()
        CType(Me.DG_PeriodoF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(381, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Período Fechado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ano Para Encerrar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Dupblo Click no Período Para Fechar"
        '
        'DG_PeriodoF
        '
        Me.DG_PeriodoF.AllowUserToAddRows = False
        Me.DG_PeriodoF.AllowUserToDeleteRows = False
        Me.DG_PeriodoF.BackgroundColor = System.Drawing.Color.White
        Me.DG_PeriodoF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_PeriodoF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PeriodoF.Location = New System.Drawing.Point(336, 41)
        Me.DG_PeriodoF.Name = "DG_PeriodoF"
        Me.DG_PeriodoF.ReadOnly = True
        Me.DG_PeriodoF.Size = New System.Drawing.Size(165, 150)
        Me.DG_PeriodoF.TabIndex = 17
        '
        'Btn_Fecha_Mes
        '
        Me.Btn_Fecha_Mes.Enabled = False
        Me.Btn_Fecha_Mes.Location = New System.Drawing.Point(221, 78)
        Me.Btn_Fecha_Mes.Name = "Btn_Fecha_Mes"
        Me.Btn_Fecha_Mes.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Fecha_Mes.TabIndex = 16
        Me.Btn_Fecha_Mes.Text = "Fechar Mês"
        Me.Btn_Fecha_Mes.UseVisualStyleBackColor = True
        '
        'Txt_Periodo
        '
        Me.Txt_Periodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Periodo.Location = New System.Drawing.Point(221, 41)
        Me.Txt_Periodo.Name = "Txt_Periodo"
        Me.Txt_Periodo.Size = New System.Drawing.Size(0, 20)
        Me.Txt_Periodo.TabIndex = 15
        Me.Txt_Periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DG_PeriodoA
        '
        Me.DG_PeriodoA.AllowUserToAddRows = False
        Me.DG_PeriodoA.AllowUserToDeleteRows = False
        Me.DG_PeriodoA.BackgroundColor = System.Drawing.Color.White
        Me.DG_PeriodoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_PeriodoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PeriodoA.Location = New System.Drawing.Point(16, 41)
        Me.DG_PeriodoA.Name = "DG_PeriodoA"
        Me.DG_PeriodoA.ReadOnly = True
        Me.DG_PeriodoA.Size = New System.Drawing.Size(165, 150)
        Me.DG_PeriodoA.TabIndex = 14
        '
        'Fm_Configuracao_Fecha_Ano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 208)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_PeriodoF)
        Me.Controls.Add(Me.Btn_Fecha_Mes)
        Me.Controls.Add(Me.Txt_Periodo)
        Me.Controls.Add(Me.DG_PeriodoA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Fm_Configuracao_Fecha_Ano"
        Me.Text = "Encerramento do Ano"
        CType(Me.DG_PeriodoF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_PeriodoF As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Fecha_Mes As System.Windows.Forms.Button
    Friend WithEvents Txt_Periodo As System.Windows.Forms.TextBox
    Friend WithEvents DG_PeriodoA As System.Windows.Forms.DataGridView
End Class
