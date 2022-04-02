Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Decimal
        Dim items As String
        total = 0
        items = "QUOTATION"

        If cmbCPU.SelectedItem = "Intel Pentuim G4400" Then
            total = total + 950
            items = items & vbCrLf & "Intel pentium G4400 : $950"
        ElseIf cmbCPU.SelectedItem = "Intel i3 6100" Then
            total = total + 1150
            items = items & vbCrLf & "Intel i3 6100 :$1150"
        ElseIf cmbCPU.SelectedItem = "Intel i3 " Then
            total = total + 1150
            items = items & vbCrLf & "Intel i5 core i5 4430 :$1150"
        ElseIf cmbCPU.SelectedItem = ""
            total = total + 1950
            items = items & vbCrLf & vbCrLf & "Intel i7 4790 :1950"

        ElseIf cmbCPU.SelectedItem = "AMD A4 6300" Then
            total = total + 1700
            items = items & vbCrLf & "AAMD A4 6300 : $1700"

        ElseIf cmbCPU.SelectedItem = "AMD A6 7400K" Then
            total = total + 1800
            items = items & vbCrLf & "AMD A6 7400K :   $1800"

        ElseIf cmbCPU.SelectedItem = "AMD FX 8350 " Then
            total = total + 2000
            items = items & vbCrLf & "AMD FX 8350 " & vbCrLf
        End If

        If cmbMemory.SelectedItem = "2GB DDRE 1333MHz" Then
            total = total + 40
            items = items & vbCrLf & "2GB DDRE 1333MHz:$40" & vbCrLf
        ElseIf cmbMemory.SelectedItem = "4GB DDR3 2000MHz" Then
            total = total + 30
            items = items & vbCrLf & "4GB DDR3 2000MHz:$30" & vbCrLf
        ElseIf cmbMemory.SelectedItem = "4GB DDR4 3000MHz " Then
            total = total + 40
            items = items & vbCrLf & "4GB DDR4 3000MHz :$40" & vbCrLf
        ElseIf cmbMemory.SelectedItem = "8GB DDR4 3400MHz " Then
            total = total + 50
            items = items & vbCrLf & "8GB DDR4 3400MHz :$50" & vbCrLf
        End If

        If cmbSoftware.SelectedItem = "" Then
            total = total + 0
            items = items & vbCrLf & "" & vbCrLf
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows 10 " Then
            total = total + 50
            items = items & vbCrLf & "Microsoft windows 10 :$50" & vbCrLf
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows 8.1 " Then
            total = total + 100
            items = items & "Microsoft windows 8.1 :$100" & vbCrLf
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows" Then
            total = total + 111
            items = items & "Microsoft windows:$111" & vbCrLf
        ElseIf cmbSoftware.SelectedItem = "" Then
            total = total + 555
            items = items & vbCrLf & "Microsoft windows:$555" & vbCrLf
        ElseIf cmbSoftware.SelectedItem = "Ubuntu 16.04.1 LTS " Then
            total = total + 654
            items = items & vbCrLf & "Ubuntu 16.04.1 LTS :$654" & vbCrLf
        End If

        If cmbGraphic.SelectedItem = "Sapphire HD 6450" Then
            total = total + 76
            items = items & "Sapphire HD 6450:$76" & vbCrLf

        ElseIf cmbGraphic.SelectedItem = "Gigabyte Radeon RX 460" Then
            total = total + 73
            items = items & "Gigabyte Radeon RX 460:$73" & vbCrLf

        ElseIf cmbGraphic.SelectedItem = "NVIDIA Quadro K620" Then
            total = total + 79
            items = items & "NVIDIA Quadro K620:$79" & vbCrLf
        End If

        If opt1.Checked = True Then
            items = items & "17'1080HP;$90" & vbCrLf
            total = total + 90
        ElseIf opt2.Checked = True Then
            items = items & "19'1080HP;$67" & vbCrLf
            total = total + 67
        ElseIf opt3.Checked = True Then
            items = items & "23'FULL HD;$100" & vbCrLf
            total = total + 100
        ElseIf opt4.Checked = True Then
            items = items & "24'FULL H;90D" & vbCrLf
            total = total + 90
        ElseIf opt4.Checked = True Then
            items = items & "27'FULL HD;97" & vbCrLf
            total = total + 97
        ElseIf opt5.Checked = True Then
            items = items & "test" & vbCrLf
            total = total + 87

        End If

        If chk1.Checked = True Then
            items = items & "HDD 1TB;$56" & vbCrLf
            total = total + 56
        End If

        If chk2.Checked = True Then
            items = items & "InkJet Printer;$60" & vbCrLf
            total = total + 60
        End If

        If chk3.Checked = True Then
            items = items & "Card Reader;$50" & vbCrLf
            total = total + 50
        End If

        If chk4.Checked = True Then
            items = items & "DVD;$60" & vbCrLf
            total = total + 60
        End If

        If chk5.Checked = True Then
            items = items & "Scanner:$80" & vbCrLf
            total = total + 80
        End If

        lblDisplay.Text = items & vbCrLf & "Total:" & total
    End Sub
End Class
