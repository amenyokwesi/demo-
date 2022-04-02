Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim uname, pass, preusername, prepassword As String

        preusername = "Bless"
        prepassword = "Bliss"

        uname = txt1.Text
        pass = txt2.Text

        preusername = preusername.ToUpper
        uname = uname.ToUpper

        If uname.Equals(preusername) And pass.Equals(prepassword) Then
            lblDisplay.text = "you are sign in"
        Else
            lblDisplay.Text = "Password or username is not correct"

        End If





    End Sub
End Class
