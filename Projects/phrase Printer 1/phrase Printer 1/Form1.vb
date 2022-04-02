Public Class form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDisplayPhrase.Click
        Dim Phrase As String
        Dim Times As Integer

        Phrase = txtInput1.Text
        Times = txtinput2.Text

        For counter = 1 To Times

            lblOutput.Text = lblOutput.Text & Phrase & vbCrLf
        Next

    End Sub
End Class
