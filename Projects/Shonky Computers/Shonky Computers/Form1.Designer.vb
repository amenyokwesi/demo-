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
        Me.cmbCPU = New System.Windows.Forms.ComboBox()
        Me.cmbMemory = New System.Windows.Forms.ComboBox()
        Me.cmbSoftware = New System.Windows.Forms.ComboBox()
        Me.cmbGraphic = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.opt5 = New System.Windows.Forms.RadioButton()
        Me.opt4 = New System.Windows.Forms.RadioButton()
        Me.opt3 = New System.Windows.Forms.RadioButton()
        Me.opt2 = New System.Windows.Forms.RadioButton()
        Me.opt1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk5 = New System.Windows.Forms.CheckBox()
        Me.chk4 = New System.Windows.Forms.CheckBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.label = New System.Windows.Forms.Label()
        Me.lbl67 = New System.Windows.Forms.Label()
        Me.lbl50 = New System.Windows.Forms.Label()
        Me.lblo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbCPU
        '
        Me.cmbCPU.FormattingEnabled = True
        Me.cmbCPU.Items.AddRange(New Object() {"Intel Pentuim G4400", "Intel Core i7 4790", "Intel core i5", "Intel i3 6100", "AMD FX 8350", "AMD A4 6300", "AMD A6 7600K"})
        Me.cmbCPU.Location = New System.Drawing.Point(3, 67)
        Me.cmbCPU.Name = "cmbCPU"
        Me.cmbCPU.Size = New System.Drawing.Size(121, 21)
        Me.cmbCPU.TabIndex = 0
        '
        'cmbMemory
        '
        Me.cmbMemory.FormattingEnabled = True
        Me.cmbMemory.Items.AddRange(New Object() {"2GB DDRE 1333MHz", "4GB DDR3 2000MHz", "4GB DDR4 3000MHz ", "8GB DDR4 3400MHz "})
        Me.cmbMemory.Location = New System.Drawing.Point(130, 67)
        Me.cmbMemory.Name = "cmbMemory"
        Me.cmbMemory.Size = New System.Drawing.Size(121, 21)
        Me.cmbMemory.TabIndex = 1
        '
        'cmbSoftware
        '
        Me.cmbSoftware.FormattingEnabled = True
        Me.cmbSoftware.Items.AddRange(New Object() {"None", "Microsoft windows 10 ", "Microsoft windows 8.1 ", "Microsoft windows", "Ubuntu 16.04.1 LTS "})
        Me.cmbSoftware.Location = New System.Drawing.Point(253, 67)
        Me.cmbSoftware.Name = "cmbSoftware"
        Me.cmbSoftware.Size = New System.Drawing.Size(121, 21)
        Me.cmbSoftware.TabIndex = 2
        '
        'cmbGraphic
        '
        Me.cmbGraphic.FormattingEnabled = True
        Me.cmbGraphic.Items.AddRange(New Object() {"Sapphire HD 6450", "Gigabyte Radeon RX 460", "NVIDIA Quadro K620"})
        Me.cmbGraphic.Location = New System.Drawing.Point(380, 67)
        Me.cmbGraphic.Name = "cmbGraphic"
        Me.cmbGraphic.Size = New System.Drawing.Size(121, 21)
        Me.cmbGraphic.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSlateGray
        Me.GroupBox1.Controls.Add(Me.opt5)
        Me.GroupBox1.Controls.Add(Me.opt4)
        Me.GroupBox1.Controls.Add(Me.opt3)
        Me.GroupBox1.Controls.Add(Me.opt2)
        Me.GroupBox1.Controls.Add(Me.opt1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(3, 162)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(485, 56)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Monitor"
        '
        'opt5
        '
        Me.opt5.AutoSize = True
        Me.opt5.BackColor = System.Drawing.Color.LightSlateGray
        Me.opt5.Location = New System.Drawing.Point(365, 19)
        Me.opt5.Name = "opt5"
        Me.opt5.Size = New System.Drawing.Size(87, 17)
        Me.opt5.TabIndex = 4
        Me.opt5.TabStop = True
        Me.opt5.Text = "27""FULL HD"
        Me.opt5.UseVisualStyleBackColor = False
        '
        'opt4
        '
        Me.opt4.AutoSize = True
        Me.opt4.Location = New System.Drawing.Point(272, 19)
        Me.opt4.Name = "opt4"
        Me.opt4.Size = New System.Drawing.Size(87, 17)
        Me.opt4.TabIndex = 3
        Me.opt4.TabStop = True
        Me.opt4.Tag = ""
        Me.opt4.Text = "24""FULL HD"
        Me.opt4.UseVisualStyleBackColor = True
        '
        'opt3
        '
        Me.opt3.AutoSize = True
        Me.opt3.Location = New System.Drawing.Point(179, 19)
        Me.opt3.Name = "opt3"
        Me.opt3.Size = New System.Drawing.Size(87, 17)
        Me.opt3.TabIndex = 2
        Me.opt3.TabStop = True
        Me.opt3.Text = "23""FULL HD"
        Me.opt3.UseVisualStyleBackColor = True
        '
        'opt2
        '
        Me.opt2.AutoSize = True
        Me.opt2.Location = New System.Drawing.Point(92, 19)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(81, 17)
        Me.opt2.TabIndex = 1
        Me.opt2.TabStop = True
        Me.opt2.Text = "19""1080HP"
        Me.opt2.UseVisualStyleBackColor = True
        '
        'opt1
        '
        Me.opt1.AutoSize = True
        Me.opt1.Location = New System.Drawing.Point(6, 19)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(80, 17)
        Me.opt1.TabIndex = 0
        Me.opt1.TabStop = True
        Me.opt1.Text = "17''1080HP"
        Me.opt1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox2.Controls.Add(Me.chk5)
        Me.GroupBox2.Controls.Add(Me.chk4)
        Me.GroupBox2.Controls.Add(Me.chk3)
        Me.GroupBox2.Controls.Add(Me.chk2)
        Me.GroupBox2.Controls.Add(Me.chk1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(485, 43)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Peripheral"
        '
        'chk5
        '
        Me.chk5.AutoSize = True
        Me.chk5.Location = New System.Drawing.Point(325, 19)
        Me.chk5.Name = "chk5"
        Me.chk5.Size = New System.Drawing.Size(66, 17)
        Me.chk5.TabIndex = 4
        Me.chk5.Text = "Scanner"
        Me.chk5.UseVisualStyleBackColor = True
        '
        'chk4
        '
        Me.chk4.AutoSize = True
        Me.chk4.Location = New System.Drawing.Point(271, 19)
        Me.chk4.Name = "chk4"
        Me.chk4.Size = New System.Drawing.Size(49, 17)
        Me.chk4.TabIndex = 3
        Me.chk4.Text = "DVD"
        Me.chk4.UseVisualStyleBackColor = True
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(179, 19)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(86, 17)
        Me.chk3.TabIndex = 2
        Me.chk3.Text = "Card Reader"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(85, 20)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(88, 17)
        Me.chk2.TabIndex = 1
        Me.chk2.Text = "InkJet Printer"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(7, 20)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(73, 17)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "HDD 1TB"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(0, 280)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(488, 138)
        Me.lblDisplay.TabIndex = 6
        Me.lblDisplay.Text = "Quote"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(3, 536)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.Location = New System.Drawing.Point(0, 51)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(32, 13)
        Me.label.TabIndex = 8
        Me.label.Text = "CPU"
        '
        'lbl67
        '
        Me.lbl67.AutoSize = True
        Me.lbl67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl67.Location = New System.Drawing.Point(132, 51)
        Me.lbl67.Name = "lbl67"
        Me.lbl67.Size = New System.Drawing.Size(50, 13)
        Me.lbl67.TabIndex = 9
        Me.lbl67.Text = "Memory"
        '
        'lbl50
        '
        Me.lbl50.AutoSize = True
        Me.lbl50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl50.Location = New System.Drawing.Point(253, 51)
        Me.lbl50.Name = "lbl50"
        Me.lbl50.Size = New System.Drawing.Size(57, 13)
        Me.lbl50.TabIndex = 10
        Me.lbl50.Text = "Software"
        '
        'lblo
        '
        Me.lblo.AutoSize = True
        Me.lblo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblo.Location = New System.Drawing.Point(377, 51)
        Me.lblo.Name = "lblo"
        Me.lblo.Size = New System.Drawing.Size(51, 13)
        Me.lblo.TabIndex = 11
        Me.lblo.Text = "Graphic"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(249, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "SHONKY COMPUTERS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 571)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblo)
        Me.Controls.Add(Me.lbl50)
        Me.Controls.Add(Me.lbl67)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbGraphic)
        Me.Controls.Add(Me.cmbSoftware)
        Me.Controls.Add(Me.cmbMemory)
        Me.Controls.Add(Me.cmbCPU)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbCPU As ComboBox
    Friend WithEvents cmbMemory As ComboBox
    Friend WithEvents cmbSoftware As ComboBox
    Friend WithEvents cmbGraphic As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents opt5 As RadioButton
    Friend WithEvents opt4 As RadioButton
    Friend WithEvents opt3 As RadioButton
    Friend WithEvents opt2 As RadioButton
    Friend WithEvents opt1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk5 As CheckBox
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents label As Label
    Friend WithEvents lbl67 As Label
    Friend WithEvents lbl50 As Label
    Friend WithEvents lblo As Label
    Friend WithEvents Label1 As Label
End Class
