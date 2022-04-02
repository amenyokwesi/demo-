Public Class Form1
    Private Sub cmdSpecification_Click(sender As Object, e As EventArgs) Handles cmdSpecification.Click
        Dim width, budget, length As String
        width = txtWidth.Text
        budget = txtBudget.Text
        length = txtLength.Text

        'creating variable
        Dim maxlength, maxwidth, maxbudget As Double




        'maxwidth validation 
        maxwidth = txtWidth.Text
        While IsNumeric(width) = False Or maxwidth < 120 Or maxwidth > 600
            width = InputBox("Enter A number between 120 to 600")
        End While


        'maxbudget validation 
        maxbudget = txtBudget.Text
        While IsNumeric(budget) = False Or Val(budget) < 150
            maxbudget = InputBox("Enter  A number 1000 to 25000")
        End While


        'budget validation
        budget = txtBudget.Text
        While IsNumeric(length) = False Or maxlength < 150 Or maxlength > 600
            maxlength = InputBox("Enter a number between 150 and 600")
        End While
        If maxwidth >= 60 And maxwidth >= 150 And budget >= 1000 Then
            cmbKitchenStyle.Items.Add("small straight kitchen.Laminate")
        End If
        If maxwidth >= 60 And maxlength >= 150 And budget >= 1500 Then
            cmbKitchenStyle.Items.Add("small straight kitchen.wood block")
        End If
        If maxwidth >= 60 And maxlength >= 150 And budget >= 2200 Then
            cmbKitchenStyle.Items.Add("small straight kitchen.Granite")
        End If
        If maxwidth >= 60 And maxlength >= 350 And budget >= 5250 Then
            cmbKitchenStyle.Items.Add("small straight kitchen.Granite")
        End If

        If maxwidth >= 60 And maxlength >= 350 And budget >= 6200 Then
            cmbKitchenStyle.Items.Add("Meduim straight kitchen:Laminate")
        End If

        If maxwidth >= 60 And maxlength >= 350 And budget >= 8000 Then
            cmbKitchenStyle.Items.Add("Meduim straight kitchen:Granite")
        End If

        If maxwidth >= 60 And maxlength >= 500 And budget >= 6750 Then
            cmbKitchenStyle.Items.Add("Large straight kitchen:Laminate")
        End If

        If maxwidth >= 60 And maxlength >= 500 And budget >= 8500 Then
            cmbKitchenStyle.Items.Add("Large straight kitchen:Block")
        End If
        If maxwidth >= 60 And maxlength >= 500 And budget >= 11000 Then
            cmbKitchenStyle.Items.Add("Large straight kitchen:Granite")
        End If
        If maxwidth >= 180 And maxlength >= 250 And budget >= 3500 Then
            cmbKitchenStyle.Items.Add("small l-shape kitchen; Laminate")
        End If
        If maxwidth >= 180 And maxlength >= 250 And budget >= 3500 Then
            cmbKitchenStyle.Items.Add("small l-shape kitchen ;Wood Block")
        End If
        If maxwidth >= 180 And maxlength >= 250 And budget >= 3500 Then
            cmbKitchenStyle.Items.Add("small l-shape kitchen; Laminate")
        End If
        If maxwidth >= 180 And maxlength >= 250 And budget >= 4500 Then
            cmbKitchenStyle.Items.Add("small l-shape kitchen:Wood Block")
        End If
        If maxwidth >= 180 And maxlength >= 250 And budget >= 5750 Then
            cmbKitchenStyle.Items.Add("small l-shape kitchen:Granite")
        End If

        If maxwidth >= 240 And maxlength >= 350 And budget >= 6500 Then
            cmbKitchenStyle.Items.Add("Meduim L shape kitchen;Laminate")
        End If

        If maxwidth >= 240 And maxlength >= 350 And budget >= 7750 Then
            cmbKitchenStyle.Items.Add("Meduim L shape kitchen;wood Block")
        End If

        If maxwidth >= 240 And maxlength >= 350 And budget >= 9500 Then
            cmbKitchenStyle.Items.Add("Meduim L shape kitchen;Granite")
        End If
        If maxwidth >= 240 And maxlength >= 350 And budget >= 8250 Then
            cmbKitchenStyle.Items.Add("Large L Shape Kitchen;Laminate")
        End If
        If maxwidth >= 450 And maxlength >= 350 And budget >= 8250 Then
            cmbKitchenStyle.Items.Add("Large L shape kitchen:wood Block")
        End If

        If maxwidth >= 450 And maxlength >= 350 And budget >= 9500 Then
            cmbKitchenStyle.Items.Add("Large L Shape Kitchen;Wood Block")
        End If

        If maxwidth >= 450 And maxlength >= 350 And budget >= 12500 Then
            cmbKitchenStyle.Items.Add("Large L Shape Kitchen;Granite")
        End If


        If maxwidth >= 450 And maxlength >= 450 And budget >= 12500 Then
            cmbKitchenStyle.Items.Add("Large Island Kitchen;Laminate")
        End If
        If maxwidth >= 450 And maxlength > 450 And budget >= 15000 Then
            cmbKitchenStyle.Items.Add("Large Island Kitchen:Wood Block")
        End If
        If maxwidth >= 450 And maxlength >= 450 And budget <>= 23000 Then
            cmbKitchenStyle.Items.Add("Large island kitchen;Granite")
        End If

        If maxwidth >= 450 And maxlength >= 450 And budget >= 23000 Then
            cmbKitchenStyle.Items.Add("large Island Kitchen:Granite")
        End If

        'maxlenght validation 
        maxlength = txtLength.Text
        While IsNumeric(length) = False Or maxlength < 150 Or maxlength > 600
            maxlength = InputBox("Enter a number between  150 to 600")

        End While


    End Sub

    Private Sub cmdSpecification2_Click(sender As Object, e As EventArgs) Handles cmdSpecification2.Click
        Dim total As Decimal

        total = 0
        Dim item As String
        item = ""

        If chk1.Checked Then
            total = total + 180
            item = item & vbCrLf & "basic fridge freezer:        180"
        End If

        If chk2.Checked Then
            total = total + 750
            item = item & vbCrLf & "American style Freezer:750"
        End If

        If chk3.Checked Then
            total = total + 400
            item = item & vbCrLf & "hod:400"
        End If

        If chk4.Checked Then
            total = total + 340
            item = item & vbCrLf & "single oven:340"
        End If


        If chk5.Checked Then
            total = total + 550
            item = item & vbCrLf & "Double Oveen:550"
        End If

        If chk6.Checked Then
            total = total + 260
            item = item & vbCrLf & "Dish Washer:260"
        End If

        If opt1.Checked Then
        Else
            total = total + 95
            item = item & vbCrLf & "Shipment:95"

        End If
        lblDisplay.Text = item & vbCrLf & total


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'creating the arrays 
        Dim kitchenstyle(6), countertop(2), appliances(5) As String
        Dim kitchenprice(21), applianceprice(6), installationprice(6) As Double



        ' Populating the kitchen Arrays 
        kitchenstyle(0) = "Small L-Shape Kitchen"
        kitchenstyle(1) = "Medium L-Shape Kitchen"
        kitchenstyle(2) = "Large L-Shape Kitchen"
        kitchenstyle(3) = "Small Straight Kitchen"
        kitchenstyle(4) = "Medium Straight Kitchen"
        kitchenstyle(5) = "Large St-raight Kitche"
        kitchenstyle(6) = "Large Island Kitchen"



        'populating the various arrays 
        appliances(0) = "Basic fridge Freezer"
        appliances(1) = "American style fridge freezer"
        appliances(2) = "Hob"
        appliances(3) = "Single oven"
        appliances(4) = "Double oven"
        appliances(5) = "Dish washer"

        'Adding price to kitchenprice Arrays
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
        kitchenprice(11) = "12500"

        kitchenprice(12) = "2200"
        kitchenprice(13) = "5250"
        kitchenprice(14) = "6200"

        kitchenprice(15) = "8000"
        kitchenprice(16) = "6750"
        kitchenprice(17) = "8500"

        kitchenprice(18) = "11000"
        kitchenprice(19) = "12500"
        kitchenprice(20) = "15000"
        kitchenprice(21) = "23000"




        'appliance
        chk1.Text = "Basic Fridge Freezer"
        chk2.Text = "American style Fridge Freezer"
        chk3.Text = "Hod"
        chk4.Text = "single Oven"
        chk5.Text = "Double oven"
        chk6.Text = "Dish washer "
    End Sub

    Private Sub cmdPurchase_Click(sender As Object, e As EventArgs) Handles cmdPurchase.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
