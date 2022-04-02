Public Class Form1
    Dim ages(4) As Integer
    Dim i = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If i < 5 Then
            ages(i) = txtinput.Text
            lblDisplay.Text = lblDisplay.Text & vbCrLf & ages(i)
            i += 1
        Else
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "you have exceeded the array"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
