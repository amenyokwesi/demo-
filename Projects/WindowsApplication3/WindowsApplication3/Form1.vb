Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles CmdDivide.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 / num2
    End Sub

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 + num2
    End Sub

    Private Sub CmdMultiply_Click(sender As Object, e As EventArgs) Handles CmdMultiply.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 * num2


    End Sub

    Private Sub CmdSubtract_Click(sender As Object, e As EventArgs) Handles CmdSubtract.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 - num2
    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub
End Class
