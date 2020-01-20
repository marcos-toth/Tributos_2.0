Module Modulo_tabEnter
    Dim CorFundoWindows As Color = Color.FromKnownColor(KnownColor.Window)
    Dim CorFundoControl As Color = Color.FromKnownColor(KnownColor.Control)
    Private Sub TabEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            e.SuppressKeyPress = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Public Sub InsereEnter(ByVal controle As Control)
        For Each elemento In controle.Controls
            If elemento.GetType.Name().ToString = "GroupBox" Or elemento.GetType.Name().ToString = "Panel" Then
            Else
                AddHandler CType(elemento, Control).KeyDown, AddressOf TabEnter
                AddHandler CType(elemento, Control).Enter, AddressOf Focar
                AddHandler CType(elemento, Control).Leave, AddressOf Desfocar
            End If
        Next
    End Sub
    Private Sub Focar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.GetType().Name
            Case "TextBox", "ListBox", "MaskedTextBox"
                CType(sender, Control).BackColor = Color.FromKnownColor(KnownColor.Info)
        End Select
    End Sub
    Private Sub Desfocar(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case sender.GetType().Name
            Case "TextBox", "ListBox", "MaskedTextBox"
                CType(sender, Control).BackColor = CorFundoWindows
        End Select
    End Sub
End Module
