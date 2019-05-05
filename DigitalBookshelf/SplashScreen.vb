Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim gr As Graphics = picLMS.CreateGraphics
        Dim grTitle As Graphics = picTitile.CreateGraphics
        Dim p As Brush = New SolidBrush(Color.Red)
        Dim p1 As Brush = New SolidBrush(Color.Black)
        Dim f As Font = New Font("Consolas", 56)
        Dim arr() As String = {"Liabrary", "Management", "System"}
        For i = 0 To arr.Length - 1
            gr.DrawString(arr(i).Substring(0, 1), f, p, 90, (i * 150) + 50)
            gr.DrawString(arr(i).Substring(1), f, p1, i * 1 + 130, 50 + (i * 150))
        Next
        grTitle.DrawString("DigitalBookSelf", New Font("Consolas", 56), Brushes.Black, 5, 5)
        Timer1.Enabled = False
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub
End Class