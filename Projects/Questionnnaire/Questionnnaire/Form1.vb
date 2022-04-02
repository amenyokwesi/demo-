Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If optFemale.Checked = True Then
            outputinfo.Text = outputinfo.Text & "You are a Female" & vbCrLf
        Else optMale.Checked = True
            outputinfo.Text = outputinfo.Text & "You are a Male" & vbCrLf
        End If

        If optAfrica.Checked = True Then
            outputinfo.Text = outputinfo.Text & "you are located in Africa." & vbCrLf
        ElseIf optAsia.Checked = True Then
            outputinfo.Text = outputinfo.Text & "you are located in Asia." & vbCrLf
        ElseIf optEurope.Checked = True Then
            outputinfo.Text = outputinfo.Text & "you are located in Europe" & vbCrLf
        ElseIf optNorthAmerica.Text = True Then
            outputinfo.Text = outputinfo.Text & "you are in North" & vbCrLf
        ElseIf optSouthAmerica.Text = True Then
            outputinfo.Text = outputinfo.Text & "you are in South America"
        End If
        If optFemale.Checked = True Then
            outputinfo.Text = outputinfo.Text & "" & vbCrLf
        Else
            outputinfo.Text = outputinfo.Text & ""







        End If

    End Sub
End Class
