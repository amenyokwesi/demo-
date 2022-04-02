Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        For counter = 2 To 40 Step 2

            lblDisplay.Text = lblDisplay.Text & counter & vbCrLf
        Next
    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class
