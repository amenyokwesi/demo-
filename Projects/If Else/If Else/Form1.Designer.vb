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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.optWidowed = New System.Windows.Forms.RadioButton()
        Me.optDivorce = New System.Windows.Forms.RadioButton()
        Me.optMarried = New System.Windows.Forms.RadioButton()
        Me.optSingle = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optFemale)
        Me.GroupBox1.Controls.Add(Me.optMale)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Location = New System.Drawing.Point(108, 19)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(59, 17)
        Me.optFemale.TabIndex = 1
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "Female"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Location = New System.Drawing.Point(14, 19)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(48, 17)
        Me.optMale.TabIndex = 0
        Me.optMale.TabStop = True
        Me.optMale.Text = "Male"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optWidowed)
        Me.GroupBox2.Controls.Add(Me.optDivorce)
        Me.GroupBox2.Controls.Add(Me.optMarried)
        Me.GroupBox2.Controls.Add(Me.optSingle)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 56)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Marital status"
        '
        'optWidowed
        '
        Me.optWidowed.AutoSize = True
        Me.optWidowed.Location = New System.Drawing.Point(244, 19)
        Me.optWidowed.Name = "optWidowed"
        Me.optWidowed.Size = New System.Drawing.Size(70, 17)
        Me.optWidowed.TabIndex = 3
        Me.optWidowed.TabStop = True
        Me.optWidowed.Text = "Widowed"
        Me.optWidowed.UseVisualStyleBackColor = True
        '
        'optDivorce
        '
        Me.optDivorce.AutoSize = True
        Me.optDivorce.Location = New System.Drawing.Point(163, 19)
        Me.optDivorce.Name = "optDivorce"
        Me.optDivorce.Size = New System.Drawing.Size(62, 17)
        Me.optDivorce.TabIndex = 2
        Me.optDivorce.TabStop = True
        Me.optDivorce.Text = "Divorce"
        Me.optDivorce.UseVisualStyleBackColor = True
        '
        'optMarried
        '
        Me.optMarried.AutoSize = True
        Me.optMarried.Location = New System.Drawing.Point(91, 19)
        Me.optMarried.Name = "optMarried"
        Me.optMarried.Size = New System.Drawing.Size(66, 17)
        Me.optMarried.TabIndex = 1
        Me.optMarried.TabStop = True
        Me.optMarried.Text = "Marriage"
        Me.optMarried.UseVisualStyleBackColor = True
        '
        'optSingle
        '
        Me.optSingle.AutoSize = True
        Me.optSingle.Location = New System.Drawing.Point(14, 19)
        Me.optSingle.Name = "optSingle"
        Me.optSingle.Size = New System.Drawing.Size(54, 17)
        Me.optSingle.TabIndex = 0
        Me.optSingle.TabStop = True
        Me.optSingle.Text = "Single"
        Me.optSingle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(90, 172)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 20)
        Me.txtName.TabIndex = 3
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmit.Location = New System.Drawing.Point(-1, 371)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(375, 47)
        Me.cmdSubmit.TabIndex = 4
        Me.cmdSubmit.Text = "SUBMIT"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(50, 222)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(242, 109)
        Me.lblDisplay.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 430)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
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

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents optMale As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents optWidowed As RadioButton
    Friend WithEvents optDivorce As RadioButton
    Friend WithEvents optMarried As RadioButton
    Friend WithEvents optSingle As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents lblDisplay As Label
End Class
