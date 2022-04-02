Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdConvert.Click
        Dim miles As Double
        Dim Answer As Double
        miles = txtinput1.Text
        Answer = miles / 1.61
        lblOutput1.Text = Answer

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim kilometres As Double
        Dim Answer As Double
        kilometres = txtinput2.Text
        Answer = kilometres * 1.61
        lblOutput2.Text = Answer
    End Sub
End Class
