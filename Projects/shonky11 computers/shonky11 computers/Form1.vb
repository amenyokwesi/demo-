Public Class Form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim total As Decimal
        Dim items As String
        total = 0
        items = "You order details will be deplayed here"



        If cmbCPU.SelectedItem = "Intel Pentuim G4400" Then
            total = total + 70
            items = items & vbCrLf & "Intel Pentuim G4400"
        ElseIf cmbCPU.SelectedItem = "Intel Core i7 4790" Then
            total = total + 65
            items = items & vbCrLf & "Intel Core i7 4790"
        ElseIf cmbCPU.SelectedItem = "Intel core i5" Then
            total = total + 47
            items = items & vbCrLf & "Intel core i5"
        ElseIf cmbCPU.SelectedItem = "Intel i3 6100" Then
            total = total + 67
            items = items & vbCrLf & "Intel i3 6100"
        ElseIf cmbCPU.SelectedItem = "AMD FX 8350" Then
            total = total + 75
            items = items & vbCrLf & "AMD FX 8350"
        ElseIf cmbCPU.SelectedItem = "AMD A4 6300" Then
            total = total + 45
            items = items & vbCrLf & "AMD A4 6300"
        ElseIf cmbCPU.SelectedItem = "AMD A6 7600K" Then
            total = total + 64
            items = items & vbCrLf & "AMD A6 7600K"
        End If

        If cmbMemory.SelectedItem = "2GB DDRE 1333MHz" Then
            total = total + 64
            items = items & vbCrLf & "2GB DDRE 1333MHz"
        ElseIf cmbMemory.SelectedItem = "4GB DDR3 2000MHz" Then
            total = total + 43
            items = items & vbCrLf & "4GB DDR3 2000MHz"
        ElseIf cmbMemory.SelectedItem = "4GB DDR4 3000MHz " Then
            total = total + 32
            items = items & vbCrLf & "4GB DDR4 3000MHz "
        ElseIf cmbMemory.SelectedItem = "8GB DDR4 3400MHz" Then
            total = total + 23
            items = items & vbCrLf & "8GB DDR4 3400MHz"
        End If

        If cmbSoftware.SelectedItem = "" Then
            total = total + 0
            items = items & vbCrLf & ""
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows 10 " Then
            total = total + 45
            items = items & vbCrLf & "Microsoft windows 10 "
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows 8.1 " Then
            total = total + 56
            items = items & vbCrLf & "Microsoft windows 8.1 "
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows" Then
            total = total + 78
            items = items & vbCrLf & "Microsoft windows"
        ElseIf cmbSoftware.SelectedItem = "Ubuntu 16.04.1 LTS " Then
            total = total + 34
            items = items & vbCrLf & "Ubuntu 16.04.1 LTS "
        End If

        If cmbGraphic.SelectedItem = "Sapphire HD 6450" Then
            total = total + 57
            items = items & vbCrLf & "Sapphire HD 6450"
        ElseIf cmbGraphic.SelectedItem = "Gigabyte Radeon RX 460" Then
            total = total + 56
            items = items & vbCrLf & "Gigabyte Radeon RX 460"
        ElseIf cmbGraphic.SelectedItem = "NVIDIA Quadro K620" Then
            total = total + 63
            items = items & vbCrLf & "NVIDIA Quadro K620"
        End If

        If opt1.Checked = True Then
            items = items & vbCrLf & "17''1080HP"
            total = total + 45
        ElseIf opt2.Checked = True Then
            items = items & vbCrLf & "19''1080HP"
            total = total + 65
        ElseIf opt3.Checked = True Then
            items = items & vbCrLf & "23''FULL HD"
            total = total + 43
        ElseIf opt4.Checked = True Then
            items = items & vbCrLf & "24''FULL HD"
            total = total + 84
        ElseIf opt5.Checked = True Then
            items = items & vbCrLf & "27''FULL HD"
            total = total + 46
        End If

        If chk1.Checked = True Then
            items = items & vbCrLf & ""
            total = total + 33
        ElseIf chk2.checked = True Then
            items = items & vbCrLf & ""
            total = total + 35
        ElseIf chk3.Checked = True Then
            items = items & vbCrLf & ""
            total = total + 64
        ElseIf chk4.Checked = True Then
            items = items & vbCrLf & ""
            total = total + 43
        ElseIf chk5.Checked = True Then
            items = items & vbCrLf & ""
            total = total + 23
        End If
        lblDisplay.Text = items & vbCrLf & "total" & total


    End Sub
End Class
