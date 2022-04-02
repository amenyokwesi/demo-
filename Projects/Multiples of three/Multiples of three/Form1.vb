Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = txtInput.Text

        If num Mod 3 = 0 Then
            lblOutput.Text = num & " is a multiple of three"
        Else
            lblOutput.Text = num & " is not a multiple of three"
        End If


    End Sub
End Class
