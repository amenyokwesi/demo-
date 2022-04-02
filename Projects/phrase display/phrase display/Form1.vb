Public Class Form1
    Private Sub cmdPressMe_Click(sender As Object, e As EventArgs) Handles cmdPressMe.Click
        Dim Bless As String

        Bless = txtInput.Text

        lblOutput.Text = Bless

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
