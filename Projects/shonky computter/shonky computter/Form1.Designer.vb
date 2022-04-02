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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCPU = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMemory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSoftware = New System.Windows.Forms.ComboBox()
        Me.cmbGraphic = New System.Windows.Forms.ComboBox()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt5 = New System.Windows.Forms.RadioButton()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPressme = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU"
        '
        'cmbCPU
        '
        Me.cmbCPU.FormattingEnabled = True
        Me.cmbCPU.Items.AddRange(New Object() {"Intel Pentuim G4400", "Intel Core i7 4790", "Intel core i5", "Intel i3 6100", "AMD FX 8350", "AMD A4 6300", "AMD A6 7600K"})
        Me.cmbCPU.Location = New System.Drawing.Point(30, 45)
        Me.cmbCPU.Name = "cmbCPU"
        Me.cmbCPU.Size = New System.Drawing.Size(121, 21)
        Me.cmbCPU.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Memory"
        '
        'cmbMemory
        '
        Me.cmbMemory.FormattingEnabled = True
        Me.cmbMemory.Items.AddRange(New Object() {"2GB DDRE 1333MHz", "4GB DDR3 2000MHz", "4GB DDR4 3000MHz ", "8GB DDR4 3400MHz "})
        Me.cmbMemory.Location = New System.Drawing.Point(181, 45)
        Me.cmbMemory.Name = "cmbMemory"
        Me.cmbMemory.Size = New System.Drawing.Size(121, 21)
        Me.cmbMemory.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(324, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Software"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(471, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Graphic"
        '
        'cmbSoftware
        '
        Me.cmbSoftware.FormattingEnabled = True
        Me.cmbSoftware.Items.AddRange(New Object() {"None", "Microsoft windows 10 ", "Microsoft windows 8.1 ", "Microsoft windows", "Ubuntu 16.04.1 LTS "})
        Me.cmbSoftware.Location = New System.Drawing.Point(327, 45)
        Me.cmbSoftware.Name = "cmbSoftware"
        Me.cmbSoftware.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftware.TabIndex = 6
        '
        'cmbGraphic
        '
        Me.cmbGraphic.FormattingEnabled = True
        Me.cmbGraphic.Items.AddRange(New Object() {"", "Sapphire HD 6450", "Gigabyte Radeon RX 460", "NVIDIA Quadro K620"})
        Me.cmbGraphic.Location = New System.Drawing.Point(474, 45)
        Me.cmbGraphic.Name = "cmbGraphic"
        Me.cmbGraphic.Size = New System.Drawing.Size(121, 21)
        Me.cmbGraphic.TabIndex = 7
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(17, 34)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(60, 17)
        Me.opt1.TabIndex = 8
        Me.opt1.TabStop = True
        Me.opt1.Text = "17 inch"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(122, 34)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(57, 17)
        Me.opt2.TabIndex = 9
        Me.opt2.TabStop = True
        Me.opt2.Text = "19inch"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(219, 34)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(57, 17)
        Me.opt3.TabIndex = 10
        Me.opt3.TabStop = True
        Me.opt3.Text = "23inch"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(315, 34)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(57, 17)
        Me.opt4.TabIndex = 11
        Me.opt4.TabStop = True
        Me.opt4.Text = "24inch"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.Location = New System.Drawing.Point(423, 34)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(57, 17)
        Me.opt5.TabIndex = 12
        Me.opt5.TabStop = True
        Me.opt5.Text = "27inch"
        Me.opt5.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(17, 86)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(73, 17)
        Me.chk1.TabIndex = 13
        Me.chk1.Text = "HDD 1TB"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(131, 86)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(85, 17)
        Me.chk2.TabIndex = 14
        Me.chk2.Text = "Inkjet Printer"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(228, 86)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(86, 17)
        Me.chk3.TabIndex = 15
        Me.chk3.Text = "Card Reader"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(314, 86)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(49, 17)
        Me.chk4.TabIndex = 16
        Me.chk4.Text = "DVD"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(416, 86)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(66, 17)
        Me.chk5.TabIndex = 17
        Me.chk5.Text = "Scanner"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(79, 246)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplay.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "monitors"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.opt4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.opt1)
        Me.GroupBox1.Controls.Add(Me.opt2)
        Me.GroupBox1.Controls.Add(Me.chk5)
        Me.GroupBox1.Controls.Add(Me.opt3)
        Me.GroupBox1.Controls.Add(Me.chk4)
        Me.GroupBox1.Controls.Add(Me.opt5)
        Me.GroupBox1.Controls.Add(Me.chk3)
        Me.GroupBox1.Controls.Add(Me.chk1)
        Me.GroupBox1.Controls.Add(Me.chk2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 120)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Peripheral"
        '
        'cmbPressme
        '
        Me.cmbPressme.Location = New System.Drawing.Point(143, 343)
        Me.cmbPressme.Name = "cmbPressme"
        Me.cmbPressme.Size = New System.Drawing.Size(75, 23)
        Me.cmbPressme.TabIndex = 21
        Me.cmbPressme.Text = "Press Me"
        Me.cmbPressme.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 394)
        Me.Controls.Add(Me.cmbPressme)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbGraphic)
        Me.Controls.Add(Me.cmbSoftware)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbMemory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbCPU)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCPU As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMemory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSoftware As ComboBox
    Friend WithEvents cmbGraphic As ComboBox
    Friend WithEvents opt1 As RadioButton
    Friend WithEvents opt2 As RadioButton
    Friend WithEvents opt3 As RadioButton
    Friend WithEvents opt4 As RadioButton
    Friend WithEvents opt5 As RadioButton
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbPressme As Button
End Class
