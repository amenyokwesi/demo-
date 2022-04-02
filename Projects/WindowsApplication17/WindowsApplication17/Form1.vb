Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kay As Integer
        kay = txtInput.Text
        For b = 0 To 21 Step 3
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "" & b
        Next

    End Sub
End Class
