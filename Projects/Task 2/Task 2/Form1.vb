Public Class Form1
    Private Sub CmdDisplay_Click(sender As Object, e As EventArgs) Handles CmdDisplay.Click
        Dim msg As String
        msg = "The counter is now at"

        lblOutput.Text = ""
        For counter = 1 To 10
            lblOutput.Text = lblOutput.Text & msg & vbCrLf
        Next



    End Sub

    Private Sub lbldisplay_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
