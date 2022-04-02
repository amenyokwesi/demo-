Public Class Form1
    Private Sub cmdPressMe_Click(sender As Object, e As EventArgs) Handles cmdPressMe.Click
        Dim msg As String
        msg = txtMessage.Text
        lblOutput.Text = lblOutput.Text & vbCrLf & msg
        txtMessage.Text = ""

    End Sub


End Class
