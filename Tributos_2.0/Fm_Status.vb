Public Class Fm_Status
    Dim a As Double = 0
    Dim b As Double = 0
    Private Sub Fm_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressBar.Value = 0
        Timer_Statua.Start()
    End Sub

    Private Sub Timer_Statua_Tick(sender As Object, e As EventArgs) Handles Timer_Statua.Tick
        a = a + 1
        If a > 9 Then
            a = 0
            b = b + 1
        End If
        If b > 100 Then
            b = 0
            Timer_Statua.Stop()
        End If
        'If b >= 0 Then
        '    CircularProgressBar.ProgressColor = Color.White
        'End If
        'If b = 15 Then
        '    CircularProgressBar.ProgressColor = Color.Orange
        'End If
        'If b = 30 Then
        '    CircularProgressBar.ProgressColor = Color.DarkRed
        'End If
        'If b = 40 Then
        '    CircularProgressBar.ProgressColor = Color.Red
        'End If
        CircularProgressBar.SubscriptText = "." & a
        CircularProgressBar.Value = b
        CircularProgressBar.Text = CircularProgressBar.Value
    End Sub

End Class