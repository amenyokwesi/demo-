Public Class Form1
    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim num As Integer
        Dim message As String

        lblDisplay.Text = ""
        num = txtInput.Text

        If num = 1 Then
            message = "1:You have won a sheet of paper"

        ElseIf num = 2 Then
            message = "2:You have won a car"

        ElseIf num = 3 Then
            message = "3:you have won a pair of slippers"

        ElseIf num - 4 Then
            message = "4:you have won a litre bottle of water"

        ElseIf num = 5 Then
            message = "5:you have won a 52 LCD inch television"

        ElseIf num = 6 Then
            message = "6:you have won an unbrella"

        End If
        lblDisplay.Text = message
    End Sub
End Class
