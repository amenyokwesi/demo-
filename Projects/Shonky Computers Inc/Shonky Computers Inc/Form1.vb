Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles opt32.CheckedChanged

    End Sub

    Private Sub cmdBuy_Click(sender As Object, e As EventArgs) Handles cmdBuy.Click
        Dim calculate As Double

        If opt1.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Intel pentium G4400"
            calculate = calculate + 10

        ElseIf opt2.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Intel core i7 4790"
            calculate = calculate + 50

        ElseIf opt3.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "AMD FX 8350" &
            calculate = calculate + 30

        ElseIf opt4.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "AMD A4 6500"
            calculate = calculate + 13

        ElseIf opt5.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Intel i5"
            calculate = calculate + 34

        ElseIf opt6.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Intel i3 6100"
            calculate = calculate + 10

        ElseIf opt7.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "AMD 6700K"
            calculate = calculate + 6
End If
        If opt8.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "2GB DDRE 1333MHz"
            calculate = calculate + 5

        ElseIf opt9.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "4GB DDR3 2000MHz"
            calculate = calculate + 9

        ElseIf If opt10.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "4GB DDR4 3000MHz "
            calculate = calculate + 11
        End If
        If opt11.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "8GB DDR4 3400MHz "
            calculate = calculate + 11

        ElseIf opt12.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "1TB"
            calculate = calculate + 20

        ElseIf opt13.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "2TB "
            calculate = calculate + 30

        ElseIf opt14.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "4TB "
            calculate = calculate + 40

        ElseIf opt15.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "6TB "
            calculate = calculate + 50

        ElseIf opt16.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "8TB "
            calculate = calculate + 60
        End If

        If opt17.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & " "
            calculate = calculate + ""

        ElseIf opt18.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Microsoft windows 10  "
            calculate = calculate + 10

        ElseIf opt19.Checked = True Then
            calculate = calculate + 40

        ElseIf opt20.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & vbCrLf & "Microsoft windows 7 "
            calculate = calculate + 30

        ElseIf opt21.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Ubuntu 16.04.1 LTS " & vbCrLf
            calculate = calculate + 20

        ElseIf opt22.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Sapphire HD 6450  " & vbCrLf
            calculate = calculate + 20

        ElseIf opt23.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Gigabyte Radeon RX 460 " & vbCrLf
            calculate = calculate + 30

        ElseIf opt24.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "NVIDIA Quadro K620  " & vbCrLf
            calculate = calculate + 40
        End If

        If opt25.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "17 1080 HP" & vbCrLf
            calculate = calculate + 50

        ElseIf opt26.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "19 1080 HP  " & vbCrLf
            calculate = calculate + 60

        ElseIf opt27.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "23 FULL HD " & vbCrLf
            calculate = calculate + 30

        ElseIf opt28.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "24 Full HD  " & vbCrLf
            calculate = calculate + 80

        ElseIf opt29.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "27 Full HD " & vbCrLf
            calculate = calculate + 90

        ElseIf opt30.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & " Portable External HDD 1TB
" & vbCrLf
            calculate = calculate + 50

        ElseIf opt31.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "DVD DDRIVE " & vbCrLf
            calculate = calculate + 60

        ElseIf opt32.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Injet Printer " & vbCrLf
            calculate = calculate + 70

        ElseIf opt33.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Scanner" & vbCrLf
            calculate = calculate + 80

        ElseIf opt34.Checked = True Then
            lblDisplay.Text = lblDisplay.Text & "Card Reader" & vbCrLf
            calculate = calculate + 90

        End If


            lblDisplay.Text = lblDisplay.Text & "Total Amount To be paid Is $" & calculate & vbCrLf
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub opt20_CheckedChanged(sender As Object, e As EventArgs) Handles opt20.CheckedChanged

    End Sub

    Private Sub opt1_CheckedChanged(sender As Object, e As EventArgs) Handles opt1.CheckedChanged

    End Sub
End Class
