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
        Me.cmdPressMe = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTV = New System.Windows.Forms.CheckBox()
        Me.chkBoard = New System.Windows.Forms.CheckBox()
        Me.chkVB = New System.Windows.Forms.CheckBox()
        Me.chkAnimals = New System.Windows.Forms.CheckBox()
        Me.chkBooks = New System.Windows.Forms.CheckBox()
        Me.lblAboutYou = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Check everything that you like"
        '
        'cmdPressMe
        '
        Me.cmdPressMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPressMe.Location = New System.Drawing.Point(100, 370)
        Me.cmdPressMe.Name = "cmdPressMe"
        Me.cmdPressMe.Size = New System.Drawing.Size(240, 51)
        Me.cmdPressMe.TabIndex = 6
        Me.cmdPressMe.Text = "Press Me!"
        Me.cmdPressMe.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTV)
        Me.GroupBox1.Controls.Add(Me.chkBoard)
        Me.GroupBox1.Controls.Add(Me.chkVB)
        Me.GroupBox1.Controls.Add(Me.chkAnimals)
        Me.GroupBox1.Controls.Add(Me.chkBooks)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 140)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'chkTV
        '
        Me.chkTV.AutoSize = True
        Me.chkTV.Location = New System.Drawing.Point(15, 65)
        Me.chkTV.Name = "chkTV"
        Me.chkTV.Size = New System.Drawing.Size(74, 17)
        Me.chkTV.TabIndex = 4
        Me.chkTV.Text = "Television"
        Me.chkTV.UseVisualStyleBackColor = True
        '
        'chkBoard
        '
        Me.chkBoard.AutoSize = True
        Me.chkBoard.Location = New System.Drawing.Point(15, 42)
        Me.chkBoard.Name = "chkBoard"
        Me.chkBoard.Size = New System.Drawing.Size(90, 17)
        Me.chkBoard.TabIndex = 3
        Me.chkBoard.Text = "Board Games"
        Me.chkBoard.UseVisualStyleBackColor = True
        '
        'chkVB
        '
        Me.chkVB.AutoSize = True
        Me.chkVB.Location = New System.Drawing.Point(15, 111)
        Me.chkVB.Name = "chkVB"
        Me.chkVB.Size = New System.Drawing.Size(83, 17)
        Me.chkVB.TabIndex = 5
        Me.chkVB.Text = "Visual Basic"
        Me.chkVB.UseVisualStyleBackColor = True
        '
        'chkAnimals
        '
        Me.chkAnimals.AutoSize = True
        Me.chkAnimals.Location = New System.Drawing.Point(15, 19)
        Me.chkAnimals.Name = "chkAnimals"
        Me.chkAnimals.Size = New System.Drawing.Size(62, 17)
        Me.chkAnimals.TabIndex = 2
        Me.chkAnimals.Text = "Animals"
        Me.chkAnimals.UseVisualStyleBackColor = True
        '
        'chkBooks
        '
        Me.chkBooks.AutoSize = True
        Me.chkBooks.Location = New System.Drawing.Point(15, 88)
        Me.chkBooks.Name = "chkBooks"
        Me.chkBooks.Size = New System.Drawing.Size(56, 17)
        Me.chkBooks.TabIndex = 4
        Me.chkBooks.Text = "Books"
        Me.chkBooks.UseVisualStyleBackColor = True
        '
        'lblAboutYou
        '
        Me.lblAboutYou.Location = New System.Drawing.Point(186, 51)
        Me.lblAboutYou.Name = "lblAboutYou"
        Me.lblAboutYou.Size = New System.Drawing.Size(246, 296)
        Me.lblAboutYou.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 445)
        Me.Controls.Add(Me.lblAboutYou)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdPressMe)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "All About You"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdPressMe As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkTV As CheckBox
    Friend WithEvents chkBoard As CheckBox
    Friend WithEvents chkVB As CheckBox
    Friend WithEvents chkAnimals As CheckBox
    Friend WithEvents chkBooks As CheckBox
    Friend WithEvents lblAboutYou As Label
End Class
