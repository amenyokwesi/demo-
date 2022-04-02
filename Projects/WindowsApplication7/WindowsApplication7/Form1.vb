Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged

    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        Num2 = txtNum2.Text
        lblDisplay.Text = num1 + num2
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text

        lblDisplay.Text = num1 * num2
    End Sub

    Private Sub cmdSubtract_Click(sender As Object, e As EventArgs) Handles cmdSubtract.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 - num2
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        Dim num1 As Double
        Dim num2 As Double
        num1 = txtNum1.Text
        num2 = txtNum2.Text
        lblDisplay.Text = num1 / num2
    End Sub
End Class

