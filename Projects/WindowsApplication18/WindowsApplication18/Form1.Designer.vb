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
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.display = New System.Windows.Forms.Label()
        Me.cmdDivision = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(80, 195)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add "
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(55, 27)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 1
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(55, 54)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 2
        '
        'display
        '
        Me.display.AutoSize = True
        Me.display.Location = New System.Drawing.Point(90, 113)
        Me.display.Name = "display"
        Me.display.Size = New System.Drawing.Size(39, 13)
        Me.display.TabIndex = 3
        Me.display.Text = "Label1"
        '
        'cmdDivision
        '
        Me.cmdDivision.Location = New System.Drawing.Point(12, 195)
        Me.cmdDivision.Name = "cmdDivision"
        Me.cmdDivision.Size = New System.Drawing.Size(75, 23)
        Me.cmdDivision.TabIndex = 4
        Me.cmdDivision.Text = "division"
        Me.cmdDivision.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(156, 195)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(75, 23)
        Me.cmdMultiply.TabIndex = 5
        Me.cmdMultiply.Text = "multiply "
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.cmdDivision)
        Me.Controls.Add(Me.display)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdAdd As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents display As Label
    Friend WithEvents cmdDivision As Button
    Friend WithEvents cmdMultiply As Button
End Class
