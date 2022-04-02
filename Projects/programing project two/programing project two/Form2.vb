Public Class Form2
    Private Sub cmdEnter_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click

        Dim name, housenumber, streetname, town, postcode As Long
        Dim email, creditcardnumber, width, length As String
        name = Val(txtName.Text)
        housenumber = Val(txtHousenumber.Text)
        streetname = Val(txtStreetname.Text)
        town = Val(txtTown.Text)
        postcode = Val(txtPostcode.Text)

        email = txtEmail.Text
        creditcardnumber = txtCreditnumber.Text
        width = txtWidth.Text
        length = TetxtLengthtBox.Text

        If email = "" Or creditcardnumber = "" Or width = "" Or length = "" Then
            MsgBox("please complete the form")


        End If

    End Sub
End Class