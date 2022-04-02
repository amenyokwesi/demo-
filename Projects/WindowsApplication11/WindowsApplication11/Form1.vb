Public Class Form1
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        Dim phrase As String
        Dim number As Integer
        phrase = txtphrase.Text
        number = txtnumber.Text
        For Counter = 1 To number
            lbldisplay.Text = lbldisplay.Text & phrase & vbCrLf
        Next
    End Sub
End Class
