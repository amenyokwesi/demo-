Public Class Form1
    Public Property Maths As Object

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim Sideone As Double
        Dim Sidetwo As Double
        Dim hypotenus As Double
        Dim SideOneSquare As Double
        Dim SideTwoSquare As Double
        Dim hypotenusSquare As Double


        Sideone = txtSideOne.Text
        Sidetwo = txtSideTwo.Text

        Sideone = Sideone * Sideone
        Sidetwo = Sidetwo * Sidetwo
        hypotenusSquare = SideOneSquare + SideTwoSquare

        hypotenus = Maths.Sqrt(hypotenusSquare)
        lblOutput.Text = hypotenus




    End Sub
End Class
