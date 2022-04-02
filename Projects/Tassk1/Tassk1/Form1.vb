Public Class Form1
    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim Phrase As String
        Dim Times As Integer

        Phrase = txtPhrase.Text
        Times = txtTime.Text

        For i = 1 To Times
            lblDisplay.Text = lblDisplay.Text & vbCrLf & Phrase
        Next
    End Sub
End Class
