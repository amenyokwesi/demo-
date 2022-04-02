Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles optSingle.CheckedChanged

    End Sub

    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim gender, Status, name As String

        If optMale.Checked = True Then
            gender = "male"
        Else
            gender = "Female"

        End If
        If optSingle.Checked = True Then
            Status = "single"
        ElseIf optMarried.Checked = True Then
            Status = "Married"
        ElseIf optDivorced.Checked = True Then
            Status = "Divorced"
        Else
            Status = "widowed"
        End If
        name = txtName.Text

        If gender = "Female" And Status = "single" Then
            lblDisplay.Text = "Hello Ms." & name & "single"
        End If
        If gender = "Female" And Status = "married" Then
            lblDisplay.Text = lblDisplay.Text
        End If
        If gender = "male" Then
            lblDisplay.Text = "Hello Mr." & name & "You are" & Status
        End If
        If gender = "female" And (Status = "Divorced" Or Status = "widowed") Then
            lblDisplay = "Hello Miss ." & name & " you are " & Status

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
