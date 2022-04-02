Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CmdDisplayEvenNums.Click
        For counter = 2 To 40 Step 2
            lblOutput.Text = lblOutput.Text & counter & vbCrLf
        Next
    End Sub
End Class
