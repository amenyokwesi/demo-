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
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.CmdMultiply = New System.Windows.Forms.Button()
        Me.CmdDivide = New System.Windows.Forms.Button()
        Me.CmdSubtract = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number One:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number Two:"
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(166, 76)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 20)
        Me.txtNum2.TabIndex = 3
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(13, 125)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(121, 13)
        Me.lblDisplay.TabIndex = 4
        Me.lblDisplay.Text = "Answer will display here."
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(166, 41)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 20)
        Me.txtNum1.TabIndex = 5
        '
        'CmdAdd
        '
        Me.CmdAdd.Location = New System.Drawing.Point(46, 173)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(88, 44)
        Me.CmdAdd.TabIndex = 7
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdMultiply
        '
        Me.CmdMultiply.Location = New System.Drawing.Point(248, 173)
        Me.CmdMultiply.Name = "CmdMultiply"
        Me.CmdMultiply.Size = New System.Drawing.Size(88, 44)
        Me.CmdMultiply.TabIndex = 8
        Me.CmdMultiply.Text = "Multiply"
        Me.CmdMultiply.UseVisualStyleBackColor = True
        '
        'CmdDivide
        '
        Me.CmdDivide.Location = New System.Drawing.Point(248, 240)
        Me.CmdDivide.Name = "CmdDivide"
        Me.CmdDivide.Size = New System.Drawing.Size(88, 44)
        Me.CmdDivide.TabIndex = 9
        Me.CmdDivide.Text = "Divide"
        Me.CmdDivide.UseVisualStyleBackColor = True
        '
        'CmdSubtract
        '
        Me.CmdSubtract.Location = New System.Drawing.Point(46, 240)
        Me.CmdSubtract.Name = "CmdSubtract"
        Me.CmdSubtract.Size = New System.Drawing.Size(88, 44)
        Me.CmdSubtract.TabIndex = 10
        Me.CmdSubtract.Text = "Subtract"
        Me.CmdSubtract.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 436)
        Me.Controls.Add(Me.CmdSubtract)
        Me.Controls.Add(Me.CmdDivide)
        Me.Controls.Add(Me.CmdMultiply)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents CmdAdd As Button
    Friend WithEvents CmdMultiply As Button
    Friend WithEvents CmdDivide As Button
    Friend WithEvents CmdSubtract As Button
End Class
