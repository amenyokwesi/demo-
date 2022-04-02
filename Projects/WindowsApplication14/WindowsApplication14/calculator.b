Public Class Form1
    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim numone As Double
        Dim numtwo As Double
        Dim answer As Double
        numone = txtnum1.Text
        numtwo = txtnum2.Text
        answer = numone + numtwo
        lbldisplay.Text = answer
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmdsubtract.Click
        Dim numone As Double
        Dim numtwo As Double
        Dim Answer As Double
        numone = txtnum1.Text
        numtwo = txtnum2.Text
        Answer = numone - numtwo
        lbldisplay.Text = Answer
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmdmultiply.Click
        Dim numone As Double
        Dim numtwo As Double
        Dim answer As Double
        numone = txtnum1.Text
        numtwo = txtnum2.Text
        answer = numone * numtwo
        lbldisplay.Text = answer
    End Sub

    Private Sub cmddivision_Click(sender As Object, e As EventArgs) Handles cmddivision.Click
        Dim numone As Double
        Dim numtwo As Double
        Dim answer As Double
        numone = txtnum1.Text
        numtwo = txtnum2.Text
        answer = numone / numtwo
        lbldisplay.Text = answer
    End Sub
End Class
