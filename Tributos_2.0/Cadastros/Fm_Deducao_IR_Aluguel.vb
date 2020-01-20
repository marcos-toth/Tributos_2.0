Public Class Fm_Deducao_IR_Aluguel

    Private Sub Txt_Taxa_ADM_Leave(sender As Object, e As EventArgs) Handles Txt_Taxa_ADM.Leave
        Soma()
    End Sub
    Private Sub Txt_IPTU_Leave(sender As Object, e As EventArgs) Handles Txt_IPTU.Leave
        Soma()
    End Sub
    Private Sub Txt_Condominio_Leave(sender As Object, e As EventArgs) Handles Txt_Condominio.Leave
        Soma()
    End Sub
    Private Sub Soma()
        Dim taxa, iptu, condom As Double
        taxa = Txt_Taxa_ADM.Text
        iptu = Txt_IPTU.Text
        condom = Txt_Condominio.Text
        Reducao_Base_IR_Aluguel = taxa + iptu + condom
        Txt_Base_Reducao.Text = Reducao_Base_IR_Aluguel
    End Sub
    Private Sub Txt_Taxa_ADM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Taxa_ADM.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_IPTU.Select()
        End If
    End Sub
    Private Sub Txt_IPTU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_IPTU.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            Txt_Condominio.Select()
        End If
    End Sub
    Private Sub Txt_Condominio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Condominio.KeyPress
        If e.KeyChar = "." Then
            e.KeyChar = ","
        ElseIf Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack And Not e.KeyChar = "," Then
            e.Handled = True
        End If
        If AscW(e.KeyChar) = Keys.Enter Then
            btnSalvar.Select()
        End If
    End Sub


  
End Class