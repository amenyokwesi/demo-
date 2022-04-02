Public Class Form1
    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        Dim postcode, cardnumber As Long
        Dim name, email, housenumber, streetname, towncity As String

        postcode = Val(txtPostCode.Text)
        cardnumber = Val(txtCreditCardNumber.Text)
        name = txtName.Text
        email = txtEmail.Text
        housenumber = txtHouseNumber.Text
        streetname = txtStreetName.Text
        towncity = txtTownCity.Text

        If name = "" Or email = "" Or housenumber = "" Or streetname = "" Or towncity = "" Then
            MsgBox("Please! Complete all fields")

        End If

    End Sub
End Class
