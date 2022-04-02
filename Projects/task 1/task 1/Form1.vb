Public Class Form1
    Private Sub CmDdisplayPhrase_TextChanged(sender As Object, e As EventArgs) Handles txtPhrase.TextChanged



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
+
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim phrase As String
        Dim times As Integer

        phrase = txtPhrase.Text
        times = txtNumber.Text

        For counter = 1 To times
            lblOutput.Text = lblOutput.Text & phrase & times & vbCrLf
        Next
    End Sub
End Class
