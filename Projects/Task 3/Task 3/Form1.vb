Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmdcountdown.Click
        lbloutput.Text = ""
        For counter = 10 To 0 Step -1
            lbloutput.Text = lbloutput.Text & counter & vbCrLf
        Next
        lbloutput.Text = lbloutput.Text & "we have to lift-off"
    End Sub
End Class
