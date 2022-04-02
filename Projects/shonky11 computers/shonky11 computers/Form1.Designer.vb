<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbGraphic = New System.Windows.Forms.ComboBox()
        Me.cmbSoftware = New System.Windows.Forms.ComboBox()
        Me.cmbMemory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCPU = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(15, 22)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(73, 17)
        Me.chk1.TabIndex = 12
        Me.chk1.Text = "HDD 1TB"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(15, 46)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(88, 17)
        Me.chk2.TabIndex = 13
        Me.chk2.Text = "InkJet Printer"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(15, 69)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(86, 17)
        Me.chk3.TabIndex = 14
        Me.chk3.Text = "Card Reader"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(15, 93)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(49, 17)
        Me.chk4.TabIndex = 15
        Me.chk4.Text = "DVD"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(15, 117)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(66, 17)
        Me.chk5.TabIndex = 16
        Me.chk5.Text = "Scanner"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk4)
        Me.GroupBox1.Controls.Add(Me.chk5)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Controls.Add(Me.chk3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 139)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose any peripheral you want "
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(281, 81)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(358, 267)
        Me.lblDisplay.TabIndex = 18
        Me.lblDisplay.Text = "You order details will be deplayed here"
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(6, 16)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(80, 17)
        Me.opt1.TabIndex = 19
        Me.opt1.TabStop = True
        Me.opt1.Text = "17''1080HP"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(6, 39)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(81, 17)
        Me.opt2.TabIndex = 20
        Me.opt2.TabStop = True
        Me.opt2.Text = "19""1080HP"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(6, 62)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(87, 17)
        Me.opt3.TabIndex = 21
        Me.opt3.TabStop = True
        Me.opt3.Text = "23""FULL HD"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(6, 86)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(87, 17)
        Me.opt4.TabIndex = 22
        Me.opt4.TabStop = True
        Me.opt4.Text = "24""FULL HD"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.Location = New System.Drawing.Point(6, 110)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(87, 17)
        Me.opt5.TabIndex = 23
        Me.opt5.TabStop = True
        Me.opt5.Text = "27""FULL HD"
        Me.opt5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.opt1)
        Me.GroupBox2.Controls.Add(Me.opt5)
        Me.GroupBox2.Controls.Add(Me.opt2)
        Me.GroupBox2.Controls.Add(Me.opt4)
        Me.GroupBox2.Controls.Add(Me.opt3)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 138)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Monitors "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbGraphic)
        Me.GroupBox3.Controls.Add(Me.cmbSoftware)
        Me.GroupBox3.Controls.Add(Me.cmbMemory)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbCPU)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 47)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'cmbGraphic
        '
        Me.cmbGraphic.FormattingEnabled = True
        Me.cmbGraphic.Items.AddRange(New Object() {"Sapphire HD 6450", "Gigabyte Radeon RX 460", "NVIDIA Quadro K620"})
        Me.cmbGraphic.Location = New System.Drawing.Point(474, 20)
        Me.cmbGraphic.Name = "cmbGraphic"
        Me.cmbGraphic.Size = New System.Drawing.Size(121, 21)
        Me.cmbGraphic.TabIndex = 19
        '
        'cmbSoftware
        '
        Me.cmbSoftware.FormattingEnabled = True
        Me.cmbSoftware.Items.AddRange(New Object() {"None", "Microsoft windows 10 ", "Microsoft windows 8.1 ", "Microsoft windows", "Ubuntu 16.04.1 LTS "})
        Me.cmbSoftware.Location = New System.Drawing.Point(325, 20)
        Me.cmbSoftware.Name = "cmbSoftware"
        Me.cmbSoftware.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftware.TabIndex = 18
        '
        'cmbMemory
        '
        Me.cmbMemory.FormattingEnabled = True
        Me.cmbMemory.Items.AddRange(New Object() {"2GB DDRE 1333MHz", "4GB DDR3 2000MHz", "4GB DDR4 3000MHz ", "8GB DDR4 3400MHz "})
        Me.cmbMemory.Location = New System.Drawing.Point(169, 20)
        Me.cmbMemory.Name = "cmbMemory"
        Me.cmbMemory.Size = New System.Drawing.Size(121, 21)
        Me.cmbMemory.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(471, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Graphic"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Software"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Memory"
        '
        'cmbCPU
        '
        Me.cmbCPU.FormattingEnabled = True
        Me.cmbCPU.Items.AddRange(New Object() {"Intel Pentuim G4400", "Intel Core i7 4790", "Intel core i5", "Intel i3 6100", "AMD FX 8350", "AMD A4 6300", "AMD A6 7600K"})
        Me.cmbCPU.Location = New System.Drawing.Point(18, 20)
        Me.cmbCPU.Name = "cmbCPU"
        Me.cmbCPU.Size = New System.Drawing.Size(121, 21)
        Me.cmbCPU.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CPU"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(15, 382)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 26
        Me.cmdCalculate.Text = "Calculate "
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 490)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents opt1 As RadioButton
    Friend WithEvents opt2 As RadioButton
    Friend WithEvents opt3 As RadioButton
    Friend WithEvents opt4 As RadioButton
    Friend WithEvents opt5 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbGraphic As ComboBox
    Friend WithEvents cmbSoftware As ComboBox
    Friend WithEvents cmbMemory As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCPU As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmdCalculate As Button
End Class
