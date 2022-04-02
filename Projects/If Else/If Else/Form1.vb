Public Class Form1
    Private optDivorced As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim gender, Status, name As String
        If optMale.Checked = True Then
            gender = "Male"
        Else
            gender = "Female"
        End If

        If optSingle.Checked = True Then
            Status = "Single"
        ElseIf optMarried.Checked = True Then
            Status = "Married"
        ElseIf optDivorced.Checked = True Then
            Status = "Divorced"
        Else
            Status = "Windowed"
        End If
        name = txtName.Text

        If gender = "Female" And Status = "single" Then
            lblDisplay.Text = "Hello Ms." & name & "single"
        End If
        If gender = "Female" And Status = "Marriage" Then
            lblDisplay.Text = "Hello Mrs" & name & "You are Married"
        End If
        If gender = "Male" Then
            lblDisplay.Text = "Hello Mr." & name & "You are" & Status
        End If
        If gender = "Female" Then
            lblDisplay.Text = "Hello Mrs." & name & "You are" & Status
        End If




    End Sub
End Class
