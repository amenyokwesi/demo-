Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customername, Postcode, streetname, emailaddress, towncity As String
        Dim creditcardnumber, housenumber As Decimal
        customername = txt1.Text
        Postcode = txt2.Text
        towncity = txt3.Text
        Postcode = txt4.Text
        streetname = txt5.Text

        emailaddress = txt6.Text

        creditcardnumber = txt7.Text

        lblReciept.Text = lblReciept.Text & vbCrLf & "Customer name;" & customername & vbCrLf & "House numer: " & housenumber & vbCrLf & "towncity:" & towncity & vbCrLf & "Postcode; " & Postcode & vbCrLf & "street name:" & streetname & vbCrLf & "Email address:" & emailaddress & vbCrLf & "credit card  number  :" & creditcardnumber & vbCrLf
    End Sub
End Class