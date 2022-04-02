Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim msg As String

        msg = "We have our lift off"
        lblDisplay.Text = ""
        For counter = 10 To 0 Step -1

            lblDisplay.Text = lblDisplay.Text & msg & counter & vbCrLf

        Next

    End Sub
End Class
