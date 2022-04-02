<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optSingle = New System.Windows.Forms.RadioButton()
        Me.optMarried = New System.Windows.Forms.RadioButton()
        Me.optDivorced = New System.Windows.Forms.RadioButton()
        Me.Widowed = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Location = New System.Drawing.Point(11, 19)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(48, 17)
        Me.optMale.TabIndex = 0
        Me.optMale.TabStop = True
        Me.optMale.Text = "Male"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Location = New System.Drawing.Point(107, 19)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(59, 17)
        Me.optFemale.TabIndex = 1
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "Female"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'optSingle
        '
        Me.optSingle.AutoSize = True
        Me.optSingle.Location = New System.Drawing.Point(6, 19)
        Me.optSingle.Name = "optSingle"
        Me.optSingle.Size = New System.Drawing.Size(54, 17)
        Me.optSingle.TabIndex = 2
        Me.optSingle.TabStop = True
        Me.optSingle.Text = "Single"
        Me.optSingle.UseVisualStyleBackColor = True
        '
        'optMarried
        '
        Me.optMarried.AutoSize = True
        Me.optMarried.Location = New System.Drawing.Point(114, 19)
        Me.optMarried.Name = "optMarried"
        Me.optMarried.Size = New System.Drawing.Size(60, 17)
        Me.optMarried.TabIndex = 3
        Me.optMarried.TabStop = True
        Me.optMarried.Text = "Married"
        Me.optMarried.UseVisualStyleBackColor = True
        '
        'optDivorced
        '
        Me.optDivorced.AutoSize = True
        Me.optDivorced.Location = New System.Drawing.Point(212, 19)
        Me.optDivorced.Name = "optDivorced"
        Me.optDivorced.Size = New System.Drawing.Size(62, 17)
        Me.optDivorced.TabIndex = 4
        Me.optDivorced.TabStop = True
        Me.optDivorced.Text = "Divorce"
        Me.optDivorced.UseVisualStyleBackColor = True
        '
        'Widowed
        '
        Me.Widowed.AutoSize = True
        Me.Widowed.Location = New System.Drawing.Point(333, 19)
        Me.Widowed.Name = "Widowed"
        Me.Widowed.Size = New System.Drawing.Size(70, 17)
        Me.Widowed.TabIndex = 5
        Me.Widowed.TabStop = True
        Me.Widowed.Text = "Widowed"
        Me.Widowed.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optMale)
        Me.GroupBox1.Controls.Add(Me.optFemale)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 52)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Widowed)
        Me.GroupBox2.Controls.Add(Me.optSingle)
        Me.GroupBox2.Controls.Add(Me.optDivorced)
        Me.GroupBox2.Controls.Add(Me.optMarried)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(429, 57)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Married Status"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(116, 144)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 20)
        Me.txtName.TabIndex = 10
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(176, 310)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(75, 23)
        Me.cmdSubmit.TabIndex = 11
        Me.cmdSubmit.Text = "SUBMIT"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(34, 185)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(381, 122)
        Me.lblDisplay.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 406)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optMale As RadioButton
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents optSingle As RadioButton
    Friend WithEvents optMarried As RadioButton
    Friend WithEvents optDivorced As RadioButton
    Friend WithEvents Widowed As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents lblDisplay As Label
End Class
