Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdPressMe_Click(sender As Object, e As EventArgs) Handles cmdPressMe.Click
        If chkAnimals.Checked = True Then
            lblAboutYou.Text = "You like Animals"

        End If
        If chkBoard.Checked = True Then
            lblAboutYou.Text = lblAboutYou.Text & vbCrLf & "You like Board Games"
        End If
        If chkTV.Checked = True Then
            lblAboutYou.Text = lblAboutYou.Text & vbCrLf & "You like Television"
        End If
        If chkBooks.Checked = True Then
            lblAboutYou.Text = lblAboutYou.Text & vbCrLf & "You like Books"
        End If
        If chkBoard.Checked = True Then
            lblAboutYou.Text = lblAboutYou.Text & vbCrLf & "You like Visual Basic"
        End If

    End Sub

    Private Sub chkBoard_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoard.CheckedChanged

    End Sub

    Private Sub chkVB_CheckedChanged(sender As Object, e As EventArgs) Handles chkVB.CheckedChanged

    End Sub

    Private Sub chkBooks_CheckedChanged(sender As Object, e As EventArgs) Handles chkBooks.CheckedChanged

    End Sub

    Private Sub chkAnimals_CheckedChanged(sender As Object, e As EventArgs) Handles chkAnimals.CheckedChanged

    End Sub
End Class
