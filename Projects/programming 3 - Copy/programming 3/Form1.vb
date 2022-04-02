Public Class Form1
    Dim kitchenstyle(6) As String, countertop(2), appliance(5) As String
    Dim kitchenprice(20) As Integer, applianceprice(5) As Integer, installationprice(6) As Double
    Dim totalcost As Double
    Private itemselected As String

    Private Sub cmdPurchase_Click(sender As Object, e As EventArgs) Handles cmdPurchase.Click
        Me.Hide()
        Form2.Show()
    End Sub



    Private Sub cmbSelectkitchen_Click(sender As Object, e As EventArgs) Handles cmbSelectkitchen.Click
        totalcost = 0
        itemSelected = ""
        If chkA.Checked Then
            totalcost = totalcost + 180
            itemSelected = itemSelected & vbCrLf & "Basic Fridge Freezer:180"
        End If
        If chkB.Checked Then
            totalcost = totalcost + 750
            itemSelected = itemSelected & vbCrLf & "American Style Fridge Freezer:750"
        End If
        If chkC.Checked Then
            totalcost = totalcost + 400
            itemSelected = itemSelected & vbCrLf & "Hob:400"
        End If
        If chkD.Checked Then
            totalcost = totalcost + 340
            itemSelected = itemSelected & vbCrLf & "Single oven:340"
        End If
        If chkE.Checked Then
            totalcost = totalcost + 550
            itemSelected = itemSelected & vbCrLf & "Double oven:550"
        End If
        If chkF.Checked Then
            totalcost = totalcost + 270
            itemSelected = itemSelected & vbCrLf & "Dishwasher:270"
        End If


        If optinstallation.Checked Then

        Else

            totalcost = totalcost + 95
            itemSelected = itemSelected & vbCrLf & "shippment:95"
        End If

        lblDisplay.Text = itemSelected & vbCrLf & totalcost









    End Sub

    Private Sub cmdEnterspecification_Click(sender As Object, e As EventArgs) Handles cmdEnterspecification.Click

        'implementation of variable 
        Dim maxlength, maxwidth, maxbudget As String
        cmbKitchenstyle.Items.Clear()
        'maxwidth validation 
        maxwidth = txtWidth.Text
        maxwidth = txtWidth.Text
        While IsNumeric(maxwidth) = False Or maxwidth < 120 Or maxwidth > 600
            maxwidth = InputBox("Enter A width Between 120 and 600")
        End While

        'maxlength validation
        maxlength = txtLength.Text
        While IsNumeric(maxlength) = False Or maxlength < 150 Or maxlength > 600
            maxlength = InputBox("Enter a length Between 150 and 600")
        End While


        'maxbudget validation
        maxbudget = txtBudget.Text
        While IsNumeric(maxbudget) = False Or maxbudget < 1000 Or maxbudget > 23000
            maxbudget = InputBox("budget should not be less than 1000")
        End While

        Dim kitchenstyle As String
        kitchenstyle = ""
        If maxwidth >= 180 And maxlength >= 250 And maxbudget >= 3500 Then
            cmbKitchenstyle.Items.Add("Small L-shaped kitchen:Laminate")
        End If
        If maxwidth >= 180 And maxlength >= 250 And maxbudget >= 4500 Then
            cmbKitchenstyle.Items.Add("Small L-shaped kitchen:Woodblock")
        End If
        If maxwidth >= 180 And maxlength >= 250 And maxbudget >= 5750 Then
            cmbKitchenstyle.Items.Add("Small L-shaped kitchen:Granite")
        End If
        If maxwidth >= 240 And maxlength >= 350 And maxbudget >= 6500 Then
            cmbKitchenstyle.Items.Add("Medium L-shaped kitchen:Laminate")
        End If
        If maxwidth >= 240 And maxlength >= 350 And maxbudget >= 7750 Then
            cmbKitchenstyle.Items.Add("Medium L-shaped kitchen:Woodblock")
        End If
        If maxwidth >= 240 And maxlength >= 350 And maxbudget >= 9500 Then
            cmbKitchenstyle.Items.Add("Medium L-shaped kitchen:Granite")
        End If
        If maxwidth >= 350 And maxlength >= 450 And maxbudget >= 8250 Then
            cmbKitchenstyle.Items.Add("Large L-shaped kitchen:Laminate")
        End If
        If maxwidth >= 350 And maxlength >= 450 And maxbudget >= 9500 Then
            cmbKitchenstyle.Items.Add("Large L-shaped kitchen:Woodblock")
        End If
        If maxwidth >= 350 And maxlength >= 450 And maxbudget >= 12500 Then
            cmbKitchenstyle.Items.Add("Large L-shaped kitchen:Granite")
        End If
        If maxwidth >= 60 And maxlength >= 150 And maxbudget >= 1000 Then
            cmbKitchenstyle.Items.Add("Small straight kitchen:Laminate")
        End If
        If maxwidth >= 60 And maxlength >= 150 And maxbudget >= 1500 Then
            cmbKitchenstyle.Items.Add("Small straight kitchen:Woodblock")
        End If
        If maxwidth >= 60 And maxlength >= 150 And maxbudget >= 2200 Then
            cmbKitchenstyle.Items.Add("Small straight kitchen:Granite")
        End If
        If maxwidth >= 60 And maxlength >= 350 And maxbudget >= 5250 Then
            cmbKitchenstyle.Items.Add("Medium straight kitchen:Laminate")
        End If
        If maxwidth >= 60 And maxlength >= 350 And maxbudget >= 6200 Then
            cmbKitchenstyle.Items.Add("Medium straight kitchen:Woodblock")
        End If
        If maxwidth >= 60 And maxlength >= 350 And maxbudget >= 8000 Then
            cmbKitchenstyle.Items.Add("Medium straight kitchen:Granite")
        End If
        If maxwidth >= 60 And maxlength >= 500 And maxbudget >= 6750 Then
            cmbKitchenstyle.Items.Add("Large straight kitchen:Laminate")
        End If
        If maxwidth >= 60 And maxlength >= 500 And maxbudget >= 8500 Then
            cmbKitchenstyle.Items.Add("Large straight kitchen:Woodblock")
        End If
        If maxwidth >= 60 And maxlength >= 500 And maxbudget >= 11000 Then
            cmbKitchenstyle.Items.Add("Large straight kitchen:Granite")
        End If
        If maxwidth >= 450 And maxlength >= 450 And maxbudget >= 12500 Then
            cmbKitchenstyle.Items.Add("Large island kitchen:Laminate")
        End If
        If maxwidth >= 450 And maxlength >= 450 And maxbudget >= 15000 Then
            cmbKitchenstyle.Items.Add("Large island kitchen:Woodblock")
        End If
        If maxwidth >= 450 And maxlength >= 450 And maxbudget >= 23000 Then
            cmbKitchenstyle.Items.Add("Large island kitchen:Granite")
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'adding the kitchenstyle(6) arrays
        kitchenstyle(0) = "Small L-shaped kitchen"
        kitchenstyle(1) = "Medium L-shaped kitchen"
        kitchenstyle(2) = "Large L-shaped kitchen"
        kitchenstyle(3) = "Small straight kitchen"
        kitchenstyle(4) = "Medium straight kitchen"
        kitchenstyle(5) = "Large straight kitchen"
        kitchenstyle(6) = "Large island kitchen"







        'adding prices to the kitchenprice arrays
        kitchenprice(0) = "3500"
        kitchenprice(1) = "4500"
        kitchenprice(2) = "5750"
        kitchenprice(3) = "6500"
        kitchenprice(4) = "7750"
        kitchenprice(5) = "9500"
        kitchenprice(6) = "8250"
        kitchenprice(7) = "9500"
        kitchenprice(8) = "12500"
        kitchenprice(9) = "1000"
        kitchenprice(10) = "1500"
        kitchenprice(11) = "2200"
        kitchenprice(12) = "5250"
        kitchenprice(13) = "6200"
        kitchenprice(14) = "8000"
        kitchenprice(15) = "6750"
        kitchenprice(16) = "8500"
        kitchenprice(17) = "11000"
        kitchenprice(18) = "12500"
        kitchenprice(19) = "15000"
        kitchenprice(20) = "23000"

        'adding the appliances arrays
        appliance(0) = "Basic Fridge Freezer"
        appliance(1) = "American Style Fridge Freezer"
        appliance(2) = "Hob"
        appliance(3) = "Single oven"
        appliance(4) = "Double oven"
        appliance(5) = "Dishwasher"

        'adding the installation price arrays
        installationprice(0) = "1250"
        installationprice(1) = "2750"
        installationprice(2) = "3750"
        installationprice(3) = "750"
        installationprice(4) = "1500"
        installationprice(5) = "2500"
        installationprice(6) = "4750"













    End Sub
End Class
