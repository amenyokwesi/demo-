Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbPressme_Click(sender As Object, e As EventArgs) Handles cmbPressme.Click
        Dim total As Decimal
        Dim items As String
        total = 0
        items = "Quotation"

        If cmbCPU.SelectedItem = "Intel Pentuim G4400" Then
            total = total + 950
            items = items & vbCrLf & "Intel Pentuim G4400:950"
        ElseIf cmbCPU.SelectedItem = "Intel Core i7 4790" Then
            total = total + 150
            items = items & vbCrLf & "Intel Core i7 4790:150"
        ElseIf cmbCPU.SelectedItem = "Intel core i5" Then
            total = total + 120
            items = items & vbCrLf & "Intel core i5:120"
        ElseIf cmbCPU.SelectedItem = "Intel i3 6100" Then
            total = total + 300
            items = items & vbCrLf & "Intel i3 6100:300"
        ElseIf cmbCPU.SelectedItem = "AMD FX 8350" Then
            total = total + 120
            items = items & vbCrLf & "AMD FX 8350:120"
        ElseIf cmbCPU.SelectedItem = "AMD A4 6300" Then
            total = total + 300
            items = items & vbCrLf & "AMD A4 6300:600"
        ElseIf cmbCPU.SelectedItem = "AMD A6 7600K" Then
            total = total + 150
            items = items & vbCrLf & "AMD A6 7600K:150"
        End If


        If cmbMemory.SelectedItem = "2GB DDRE 1333MHz" Then
            total = total + 456
            items = items & vbCrLf & "2GB DDRE 1333MHz:909"

        ElseIf cmbMemory.SelectedItem = "4GB DDR3 2000MHz" Then
            total = total + 125
            items = items & vbCrLf & "4GB DDR3 2000MHz:125"

        ElseIf cmbMemory.SelectedItem = "4GB DDR4 3000MHz" Then
            total = total + 254
            items = items & vbCrLf & "4GB DDR4 3000MHz:254"
        ElseIf cmbMemory.SelectedItem = "8GB DDR4 3400MHz "
            total = total + 564
            items = items & vbCrLf & "8GB DDR4 3400MHz "
        End If

        If cmbSoftware.SelectedItem = "" Then
            total = total + 355
            items = items & vbCrLf & ""
        ElseIf cmbSoftware.selecteditem = "microsoft windows 10:$253" Then
            total = total + 564
            items = items & vbCrLf & "microsoft windows 10:$253"
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows 8.1" Then
            total = total +
                items = items & vbCrLf & "Microsoft windows 8.1"
        ElseIf cmbSoftware.SelectedItem = "Microsoft windows" Then
            total = total + 89
            items = items & vbCrLf & "Microsoft windows:123"
        ElseIf cmbSoftware.selecteditem = "Ubuntu:456" Then
            total = total + 456
            items = items & vbCrLf & "Ubuntu:$456"
        End If

        If cmbGraphic.SelectedItem = "Sapphire HD 6450" Then
            total = total + 123
            items = items & vbCrLf & "Sapphire HD 6450:$123"
        ElseIf cmbGraphic.SelectedItem = "Gigabyte Radeon RX 460" Then
            total = total + 265
            items = items & vbCrLf & "Gigabyte Radeon RX 460:564"
        ElseIf cmbGraphic.SelectedItem = "NVIDIA Quadro K620" Then
            total = total + 555
            items = items & vbCrLf & "NVIDIA Quadro K620:555"
        End If

        If opt1.Checked = True Then
            total = total + 52
            items = items & vbCrLf & "17inch:52"
        ElseIf opt2.Checked = True Then
            total = total + 58
            items = items & vbCrLf & "19inch:58"
        ElseIf opt3.Checked = True Then
            total = total + 666
            items = items & vbCrLf & "23inch:666"
        ElseIf opt4.Checked = True Then
            total = total + 555
            items = items & vbCrLf & "24inch:555"
        ElseIf opt5.Checked = True Then
            total = total + 656
            items = items & vbCrLf & "27inch:656"
        End If

        If chk1.Checked = True Then
            total = total + 455
            items = items & vbCrLf & "HDD 1TB:455"
        End If
        If chk2.Checked = True Then
            total = total + 545
            items = items & vbCrLf & "Inkjet Printer:545"
        End If
        If chk3.Checked = True Then
            total = total + 545
            items = items & vbCrLf & "Card Reader:545"
        End If
        If chk4.Checked = True Then
            total = total + 545
            items = items & vbCrLf & "DVD:545"
        End If
        If chk5.Checked = True Then
            total = total + 454
            items = items & vbCrLf & "scanner:454"
        End If
        lblDisplay.Text = items & vbCrLf & total









        End
    End Sub
End Class
