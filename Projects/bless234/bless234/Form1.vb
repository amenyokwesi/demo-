Public Class Form1
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        Dim meee As String
        meee = txtinput.Text
        lblDisplay.Text = txtinput.Text
        txtinput.Text = "" & vbCrLf & ""
    End Sub
End Class
