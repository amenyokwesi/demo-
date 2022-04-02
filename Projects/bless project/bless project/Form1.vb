Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdSignin.Click
        'create a storage 
        Dim username, password, correctusername, correctpassword As String

        username = txtUsername.Text
        password = txtPassword.Text

        'set values for correct username and password
        correctusername = "BLess"
        correctpassword = "bliss1234"
        correctusername = correctusername.ToUpper()

        'check if your user name or password is correct
        If username.Equals(correctusername) And password.Equals(correctpassword) Then
            lblResult.Text = "your username and password is correct"
        Else
            lblResult.Text = "your password or username is incorrect"
            End
        End If
    End Sub
End Class
