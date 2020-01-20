<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fm_Somar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fm_Somar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Valor = New System.Windows.Forms.TextBox()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Lbl_Total = New System.Windows.Forms.Label()
        Me.DG_Somar = New System.Windows.Forms.DataGridView()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_Somar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adicionar Valores"
        '
        'Txt_Valor
        '
        Me.Txt_Valor.Location = New System.Drawing.Point(30, 81)
        Me.Txt_Valor.Name = "Txt_Valor"
        Me.Txt_Valor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Valor.TabIndex = 1
        Me.Txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSomar
        '
        Me.btnSomar.BackColor = System.Drawing.Color.Transparent
        Me.btnSomar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSomar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSomar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSomar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSomar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSomar.ForeColor = System.Drawing.Color.Black
        Me.btnSomar.Image = CType(resources.GetObject("btnSomar.Image"), System.Drawing.Image)
        Me.btnSomar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSomar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSomar.Location = New System.Drawing.Point(145, 44)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(68, 58)
        Me.btnSomar.TabIndex = 5
        Me.btnSomar.Text = "&Somar"
        Me.btnSomar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSomar.UseVisualStyleBackColor = False
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
        Me.btnSalvar.Location = New System.Drawing.Point(409, 132)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(68, 58)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "&Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'Lbl_Total
        '
        Me.Lbl_Total.BackColor = System.Drawing.Color.Gray
        Me.Lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.ForeColor = System.Drawing.Color.White
        Me.Lbl_Total.Location = New System.Drawing.Point(240, 165)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(150, 25)
        Me.Lbl_Total.TabIndex = 8
        Me.Lbl_Total.Text = "Total R$ 0,00"
        Me.Lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DG_Somar
        '
        Me.DG_Somar.AllowUserToAddRows = False
        Me.DG_Somar.AllowUserToDeleteRows = False
        Me.DG_Somar.AllowUserToResizeColumns = False
        Me.DG_Somar.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_Somar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Somar.BackgroundColor = System.Drawing.Color.White
        Me.DG_Somar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_Somar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Somar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Valor})
        Me.DG_Somar.Location = New System.Drawing.Point(243, 12)
        Me.DG_Somar.MultiSelect = False
        Me.DG_Somar.Name = "DG_Somar"
        Me.DG_Somar.RowHeadersVisible = False
        Me.DG_Somar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Somar.Size = New System.Drawing.Size(147, 150)
        Me.DG_Somar.TabIndex = 9
        '
        'Valor
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle2
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        Me.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Fm_Somar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 200)
        Me.Controls.Add(Me.DG_Somar)
        Me.Controls.Add(Me.Lbl_Total)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.Txt_Valor)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Fm_Somar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Somar Valores das Guias"
        CType(Me.DG_Somar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txt_Valor As System.Windows.Forms.TextBox
    Friend WithEvents btnSomar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents DG_Somar As System.Windows.Forms.DataGridView
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
