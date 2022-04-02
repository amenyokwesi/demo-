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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.cmbEnterSpecification = New System.Windows.Forms.Button()
        Me.cmbKitchenstyle = New System.Windows.Forms.ComboBox()
        Me.chkA = New System.Windows.Forms.CheckBox()
        Me.chkB = New System.Windows.Forms.CheckBox()
        Me.chkC = New System.Windows.Forms.CheckBox()
        Me.chkD = New System.Windows.Forms.CheckBox()
        Me.chkE = New System.Windows.Forms.CheckBox()
        Me.chkF = New System.Windows.Forms.CheckBox()
        Me.optInstallation = New System.Windows.Forms.RadioButton()
        Me.cmbSelectkitchen = New System.Windows.Forms.Button()
        Me.optShipping = New System.Windows.Forms.RadioButton()
        Me.cmbPurchase = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBudget = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "length"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "width"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kitchen Style"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(59, 16)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(100, 20)
        Me.txtLength.TabIndex = 4
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(59, 57)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtWidth.TabIndex = 5
        '
        'cmbEnterSpecification
        '
        Me.cmbEnterSpecification.Location = New System.Drawing.Point(17, 128)
        Me.cmbEnterSpecification.Name = "cmbEnterSpecification"
        Me.cmbEnterSpecification.Size = New System.Drawing.Size(158, 23)
        Me.cmbEnterSpecification.TabIndex = 7
        Me.cmbEnterSpecification.Text = "Enter Specification"
        Me.cmbEnterSpecification.UseVisualStyleBackColor = True
        '
        'cmbKitchenstyle
        '
        Me.cmbKitchenstyle.FormattingEnabled = True
        Me.cmbKitchenstyle.Location = New System.Drawing.Point(38, 187)
        Me.cmbKitchenstyle.Name = "cmbKitchenstyle"
        Me.cmbKitchenstyle.Size = New System.Drawing.Size(121, 21)
        Me.cmbKitchenstyle.TabIndex = 8
        '
        'chkA
        '
        Me.chkA.AutoSize = True
        Me.chkA.Location = New System.Drawing.Point(37, 240)
        Me.chkA.Name = "chkA"
        Me.chkA.Size = New System.Drawing.Size(122, 17)
        Me.chkA.TabIndex = 9
        Me.chkA.Text = "Basic Fridge Freezer"
        Me.chkA.UseVisualStyleBackColor = True
        '
        'chkB
        '
        Me.chkB.AutoSize = True
        Me.chkB.Location = New System.Drawing.Point(37, 263)
        Me.chkB.Name = "chkB"
        Me.chkB.Size = New System.Drawing.Size(158, 17)
        Me.chkB.TabIndex = 10
        Me.chkB.Text = "American style fridge freezer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.chkB.UseVisualStyleBackColor = True
        '
        'chkC
        '
        Me.chkC.AutoSize = True
        Me.chkC.Location = New System.Drawing.Point(36, 286)
        Me.chkC.Name = "chkC"
        Me.chkC.Size = New System.Drawing.Size(44, 17)
        Me.chkC.TabIndex = 11
        Me.chkC.Text = "hob"
        Me.chkC.UseVisualStyleBackColor = True
        '
        'chkD
        '
        Me.chkD.AutoSize = True
        Me.chkD.Location = New System.Drawing.Point(36, 309)
        Me.chkD.Name = "chkD"
        Me.chkD.Size = New System.Drawing.Size(83, 17)
        Me.chkD.TabIndex = 12
        Me.chkD.Text = "single oven "
        Me.chkD.UseVisualStyleBackColor = True
        '
        'chkE
        '
        Me.chkE.AutoSize = True
        Me.chkE.Location = New System.Drawing.Point(37, 333)
        Me.chkE.Name = "chkE"
        Me.chkE.Size = New System.Drawing.Size(95, 17)
        Me.chkE.TabIndex = 13
        Me.chkE.Text = "double washer"
        Me.chkE.UseVisualStyleBackColor = True
        '
        'chkF
        '
        Me.chkF.AutoSize = True
        Me.chkF.Location = New System.Drawing.Point(36, 357)
        Me.chkF.Name = "chkF"
        Me.chkF.Size = New System.Drawing.Size(82, 17)
        Me.chkF.TabIndex = 14
        Me.chkF.Text = "dish washer"
        Me.chkF.UseVisualStyleBackColor = True
        '
        'optInstallation
        '
        Me.optInstallation.AutoSize = True
        Me.optInstallation.Location = New System.Drawing.Point(121, 424)
        Me.optInstallation.Name = "optInstallation"
        Me.optInstallation.Size = New System.Drawing.Size(74, 17)
        Me.optInstallation.TabIndex = 15
        Me.optInstallation.TabStop = True
        Me.optInstallation.Text = "installation"
        Me.optInstallation.UseVisualStyleBackColor = True
        '
        'cmbSelectkitchen
        '
        Me.cmbSelectkitchen.Location = New System.Drawing.Point(235, 418)
        Me.cmbSelectkitchen.Name = "cmbSelectkitchen"
        Me.cmbSelectkitchen.Size = New System.Drawing.Size(161, 23)
        Me.cmbSelectkitchen.TabIndex = 16
        Me.cmbSelectkitchen.Text = "select kitchen"
        Me.cmbSelectkitchen.UseVisualStyleBackColor = True
        '
        'optShipping
        '
        Me.optShipping.AutoSize = True
        Me.optShipping.Location = New System.Drawing.Point(416, 418)
        Me.optShipping.Name = "optShipping"
        Me.optShipping.Size = New System.Drawing.Size(70, 17)
        Me.optShipping.TabIndex = 17
        Me.optShipping.TabStop = True
        Me.optShipping.Text = "shippinhg"
        Me.optShipping.UseVisualStyleBackColor = True
        '
        'cmbPurchase
        '
        Me.cmbPurchase.Location = New System.Drawing.Point(538, 415)
        Me.cmbPurchase.Name = "cmbPurchase"
        Me.cmbPurchase.Size = New System.Drawing.Size(75, 23)
        Me.cmbPurchase.TabIndex = 18
        Me.cmbPurchase.Text = "Purchase"
        Me.cmbPurchase.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDisplay.Location = New System.Drawing.Point(322, 36)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(377, 332)
        Me.lblDisplay.TabIndex = 19
        Me.lblDisplay.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "budget"
        '
        'txtBudget
        '
        Me.txtBudget.Location = New System.Drawing.Point(59, 93)
        Me.txtBudget.Name = "txtBudget"
        Me.txtBudget.Size = New System.Drawing.Size(100, 20)
        Me.txtBudget.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 528)
        Me.Controls.Add(Me.txtBudget)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmbPurchase)
        Me.Controls.Add(Me.optShipping)
        Me.Controls.Add(Me.cmbSelectkitchen)
        Me.Controls.Add(Me.optInstallation)
        Me.Controls.Add(Me.chkF)
        Me.Controls.Add(Me.chkE)
        Me.Controls.Add(Me.chkD)
        Me.Controls.Add(Me.chkC)
        Me.Controls.Add(Me.chkB)
        Me.Controls.Add(Me.chkA)
        Me.Controls.Add(Me.cmbKitchenstyle)
        Me.Controls.Add(Me.cmbEnterSpecification)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents cmbEnterSpecification As Button
    Friend WithEvents cmbKitchenstyle As ComboBox
    Friend WithEvents chkA As CheckBox
    Friend WithEvents chkB As CheckBox
    Friend WithEvents chkC As CheckBox
    Friend WithEvents chkD As CheckBox
    Friend WithEvents chkE As CheckBox
    Friend WithEvents chkF As CheckBox
    Friend WithEvents optInstallation As RadioButton
    Friend WithEvents cmbSelectkitchen As Button
    Friend WithEvents optShipping As RadioButton
    Friend WithEvents cmbPurchase As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBudget As TextBox
End Class
