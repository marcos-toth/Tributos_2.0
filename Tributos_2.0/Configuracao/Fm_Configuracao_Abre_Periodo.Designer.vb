<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Configuracao_Abre_Periodo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Configuracao_Abre_Periodo))
        Me.DG_PeriodoF = New System.Windows.Forms.DataGridView()
        Me.Txt_Periodo = New System.Windows.Forms.TextBox()
        Me.Btn_Abrir_Mes = New System.Windows.Forms.Button()
        Me.DG_PeriodoA = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DG_PeriodoF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_PeriodoF
        '
        Me.DG_PeriodoF.AllowUserToAddRows = False
        Me.DG_PeriodoF.AllowUserToDeleteRows = False
        Me.DG_PeriodoF.BackgroundColor = System.Drawing.Color.White
        Me.DG_PeriodoF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_PeriodoF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PeriodoF.Location = New System.Drawing.Point(12, 47)
        Me.DG_PeriodoF.Name = "DG_PeriodoF"
        Me.DG_PeriodoF.ReadOnly = True
        Me.DG_PeriodoF.Size = New System.Drawing.Size(165, 150)
        Me.DG_PeriodoF.TabIndex = 0
        '
        'Txt_Periodo
        '
        Me.Txt_Periodo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Periodo.Location = New System.Drawing.Point(217, 47)
        Me.Txt_Periodo.Name = "Txt_Periodo"
        Me.Txt_Periodo.Size = New System.Drawing.Size(70, 20)
        Me.Txt_Periodo.TabIndex = 1
        Me.Txt_Periodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Btn_Abrir_Mes
        '
        Me.Btn_Abrir_Mes.Enabled = False
        Me.Btn_Abrir_Mes.Location = New System.Drawing.Point(217, 84)
        Me.Btn_Abrir_Mes.Name = "Btn_Abrir_Mes"
        Me.Btn_Abrir_Mes.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Abrir_Mes.TabIndex = 2
        Me.Btn_Abrir_Mes.Text = "Abrir Mês"
        Me.Btn_Abrir_Mes.UseVisualStyleBackColor = True
        '
        'DG_PeriodoA
        '
        Me.DG_PeriodoA.AllowUserToAddRows = False
        Me.DG_PeriodoA.AllowUserToDeleteRows = False
        Me.DG_PeriodoA.BackgroundColor = System.Drawing.Color.White
        Me.DG_PeriodoA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_PeriodoA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_PeriodoA.Location = New System.Drawing.Point(332, 47)
        Me.DG_PeriodoA.Name = "DG_PeriodoA"
        Me.DG_PeriodoA.ReadOnly = True
        Me.DG_PeriodoA.Size = New System.Drawing.Size(165, 150)
        Me.DG_PeriodoA.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dupblo Click no Período Para Abrir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Período Para Abrir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Período Aberto"
        '
        'Fm_Configuracao_Abre_Periodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 213)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DG_PeriodoA)
        Me.Controls.Add(Me.Btn_Abrir_Mes)
        Me.Controls.Add(Me.Txt_Periodo)
        Me.Controls.Add(Me.DG_PeriodoF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Fm_Configuracao_Abre_Periodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Abre Período"
        CType(Me.DG_PeriodoF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_PeriodoA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_PeriodoF As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_Periodo As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Abrir_Mes As System.Windows.Forms.Button
    Friend WithEvents DG_PeriodoA As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
