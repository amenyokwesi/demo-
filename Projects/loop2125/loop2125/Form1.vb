Public Class Form1
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        Dim msg As String
        msg = txtMsg.Text

        For i = 1 To 10 Step 2
            lblDisplay.Text = lblDisplay.Text & vbCrLf & msg & "" & i
        Next

    End Sub
End Class
