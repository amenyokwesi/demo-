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
        Me.cmdPressme = New System.Windows.Forms.Button()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.chkRead = New System.Windows.Forms.CheckBox()
        Me.chkSing = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.optBisexual = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPressme
        '
        Me.cmdPressme.Location = New System.Drawing.Point(109, 216)
        Me.cmdPressme.Name = "cmdPressme"
        Me.cmdPressme.Size = New System.Drawing.Size(75, 23)
        Me.cmdPressme.TabIndex = 0
        Me.cmdPressme.Text = "pressme"
        Me.cmdPressme.UseVisualStyleBackColor = True
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Location = New System.Drawing.Point(6, 19)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(43, 17)
        Me.optMale.TabIndex = 1
        Me.optMale.TabStop = True
        Me.optMale.Text = "Boy"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Location = New System.Drawing.Point(6, 42)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(40, 17)
        Me.optFemale.TabIndex = 2
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "Girl"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(144, 20)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(357, 114)
        Me.lblDisplay.TabIndex = 3
        '
        'chkRead
        '
        Me.chkRead.AutoSize = True
        Me.chkRead.Location = New System.Drawing.Point(6, 19)
        Me.chkRead.Name = "chkRead"
        Me.chkRead.Size = New System.Drawing.Size(52, 17)
        Me.chkRead.TabIndex = 4
        Me.chkRead.Text = "Read"
        Me.chkRead.UseVisualStyleBackColor = True
        '
        'chkSing
        '
        Me.chkSing.AutoSize = True
        Me.chkSing.Location = New System.Drawing.Point(6, 42)
        Me.chkSing.Name = "chkSing"
        Me.chkSing.Size = New System.Drawing.Size(47, 17)
        Me.chkSing.TabIndex = 5
        Me.chkSing.Text = "Sing"
        Me.chkSing.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optBisexual)
        Me.GroupBox1.Controls.Add(Me.optMale)
        Me.GroupBox1.Controls.Add(Me.optFemale)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(99, 84)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkRead)
        Me.GroupBox2.Controls.Add(Me.chkSing)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(76, 66)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hobby"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 178)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(343, 20)
        Me.txtName.TabIndex = 9
        '
        'optBisexual
        '
        Me.optBisexual.AutoSize = True
        Me.optBisexual.Location = New System.Drawing.Point(6, 61)
        Me.optBisexual.Name = "optBisexual"
        Me.optBisexual.Size = New System.Drawing.Size(64, 17)
        Me.optBisexual.TabIndex = 3
        Me.optBisexual.TabStop = True
        Me.optBisexual.Text = "Bisexual"
        Me.optBisexual.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 261)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmdPressme)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdPressme As Button
    Friend WithEvents optMale As RadioButton
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents lblDisplay As Label
    Friend WithEvents chkRead As CheckBox
    Friend WithEvents chkSing As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents optBisexual As RadioButton
End Class
