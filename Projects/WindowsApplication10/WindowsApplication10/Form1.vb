Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDisplayPhrase.Click
        Dim phrase As String
        Dim times As Integer

        phrase = txtPhrase.Text
        times = txtNumber.Text

        For counter = 1 To times
            lblDisplay.Text = lblDisplay.Text & phrase & vbCrLf
        Next

    End Sub
End Class
