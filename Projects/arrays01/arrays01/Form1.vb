Public Class Form1
    Dim ages(4) As Integer
    Dim i = 0
    Private Sub cmdAddNumber_Click(sender As Object, e As EventArgs) Handles cmdAddNumber.Click
        If i < 5 Then
            ages(i) = txtEnterNumber.Text
            DisplayNumbers.Text = DisplayNumbers.Text & vbCrLf & ages(i)
            i += 1
        Else
            DisplayNumbers.Text = DisplayNumbers.Text & vbCrLf & "You have exceeded the array size"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim ages(4) As Integer
    End Sub
End Class
