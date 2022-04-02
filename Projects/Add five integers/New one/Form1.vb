Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtnum2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numone As Integer
        Dim numtwo As Integer
        Dim numthree As Integer
        Dim numfour As Integer
        Dim numfive As Integer
        Dim Answer As Integer

        numone = txtnum1.Text
        numtwo = txtnum2.Text
        numthree = txtnum3.Text
        numfour = txtnum4.Text
        numfive = txtnum5.Text
        Answer = numone + numtwo + numthree + numfour + numfive

        lblAnswer.Text = Answer

    End Sub
End Class
