Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim input As String
        input = txtinput.Text
        lbldisplay.Text = input
        txtinput.Text = ""
    End Sub
End Class
