Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label3.Text = Val(Label3.Text) + 1
        If (ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Me.Hide()
            Form1.Show()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 100
    End Sub
End Class