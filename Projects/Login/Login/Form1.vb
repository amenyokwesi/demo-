Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim uname, pass, preusername, prepassword As String
        preusername = "Admin"
        prepassword = "Pswd"
        uname = txtUsername.Text
        pass = txtPassword.Text

        preusername = preusername.ToUpper
        uname = uname.ToUpper

        If uname.Equals(preusername) And pass.Equals(prepassword) Then
            lblDisplay.Text = "YOU ARE LOGGED IN"
        Else
            lblDisplay.Text = "PASSWORD OR USERNAME IS INVALID"
        End If

    End Sub
End Class
