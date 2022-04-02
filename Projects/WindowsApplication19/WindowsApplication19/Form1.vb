Public Class Form1
    Dim bless(4) As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bless(0) = "xyz"
        bless(1) = "me"
        bless(2) = "us"
        bless(3) = "me1"
        Label1.Text = Label1.Text & vbCrLf& bless.text
            End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class
