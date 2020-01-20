Public Class Fm_Versao
    Private Sub Fm_Versao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Fm_Principal
        ProgressBar1.Show()
        Timer1.Start()
        PictureBox1.Select()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub Rb_FGTS_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_FGTS.CheckedChanged
        My.Settings.VesaoAplic = versao
        My.Settings.Save()
        Me.Close()
    End Sub
End Class