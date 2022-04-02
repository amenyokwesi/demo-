Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        Dim Num As Integer
        Num = txtNumber.Text
        lblDisplay.Text = ""
        For j = 2 To 12 Step 2
            lblDisplay.Text = lblDisplay.Text & vbCrLf & Num & " x " & j & " = " & (Num * j)
        Next

    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged

    End Sub
End Class
