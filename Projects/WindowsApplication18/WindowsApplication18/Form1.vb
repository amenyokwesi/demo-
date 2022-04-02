Public Class Form1
    Dim bless As String
    Dim bliss As Integer
    Dim total As Integer





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        bless = txt1.Text
        bliss = txt2.Text
        total = bless + bliss
        display.Text = total

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdDivision_Click(sender As Object, e As EventArgs) Handles cmdDivision.Click
        bless = txt1.Text
        bliss = txt2.Text
        total = bless / bliss
        display.Text = total
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        bless = txt1.Text
        bliss = txt2.Text
        total = bless * bliss
        display.Text = total
    End Sub
End Class
