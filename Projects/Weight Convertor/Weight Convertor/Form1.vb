Public Class Form1
    Private Sub cmdConvert_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        Dim kilogram As Double
        Dim Answer As Double
        kilogram = txtinput.Text
        Answer = kilogram * 2.2
        lblOutput.Text = Answer
    End Sub
End Class
