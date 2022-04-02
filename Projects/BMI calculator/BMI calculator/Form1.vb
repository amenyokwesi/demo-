Public Class Form1
    Private Sub cmdcal_Click(sender As Object, e As EventArgs) Handles cmdcal.Click
        Dim height As Double
        Dim weight As Double
        Dim Answer As Double
        height = txtheight.Text
        weight = txtweight.Text
        Answer = weight / (height * height)
        lblOutput.Text = Answer


    End Sub
End Class
