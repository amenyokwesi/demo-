Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMsg.TextChanged

    End Sub

    Private Sub btnRepeat_Click(sender As Object, e As EventArgs) Handles btnRepeat.Click
        Dim msg As String
        msg = txtMsg.Text
        ' lblDisplay.Text = msg
        For i = 1 To 10
            lblDisplay.Text = lblDisplay.Text & vbCrLf & msg & " " & i
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
