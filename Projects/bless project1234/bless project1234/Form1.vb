Public Class Form1
    Private Sub cmdPressme_Click(sender As Object, e As EventArgs) Handles cmdPressme.Click
        Dim gender, hobby, name As String

        If optMale.Checked = True Then
            gender = "male"
        ElseIf optFemale.Checked = True Then
            gender = "female"
        ElseIf optBisexual.Checked = True
            gender = "bisexual"
        End If

        If chkRead.Checked = True Then
            hobby = "Read"
        ElseIf chkRead.Checked = True
            hobby = "Read"
        End If

        name = txtName.Text

        If gender = "male" And hobby = "reading" Then
            lblDisplay.Text = "my hobby is reading." & name & "i am a male"

        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
