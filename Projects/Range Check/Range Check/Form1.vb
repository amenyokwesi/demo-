Public Class Form1
    Private Sub cmdEnter_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click
        Dim num As Integer

        num = txtNumber.Text

        While num < 10 Or num > 50
            num = InputBox("Please Enter a number between 10 to 50")
        End While
        lblOutput.Text = "You entered : " & num

    End Sub
End Class
