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
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.cmdAddNumber = New System.Windows.Forms.Button()
        Me.DisplayNumbers = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Number :"
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(143, 27)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(95, 20)
        Me.txtEnterNumber.TabIndex = 1
        '
        'cmdAddNumber
        '
        Me.cmdAddNumber.Location = New System.Drawing.Point(255, 27)
        Me.cmdAddNumber.Name = "cmdAddNumber"
        Me.cmdAddNumber.Size = New System.Drawing.Size(75, 23)
        Me.cmdAddNumber.TabIndex = 2
        Me.cmdAddNumber.Text = "Add Number"
        Me.cmdAddNumber.UseVisualStyleBackColor = True
        '
        'DisplayNumbers
        '
        Me.DisplayNumbers.AutoSize = True
        Me.DisplayNumbers.Location = New System.Drawing.Point(42, 68)
        Me.DisplayNumbers.Name = "DisplayNumbers"
        Me.DisplayNumbers.Size = New System.Drawing.Size(107, 13)
        Me.DisplayNumbers.TabIndex = 3
        Me.DisplayNumbers.Text = "Numbers Inside Array"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 399)
        Me.Controls.Add(Me.DisplayNumbers)
        Me.Controls.Add(Me.cmdAddNumber)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEnterNumber As TextBox
    Friend WithEvents cmdAddNumber As Button
    Friend WithEvents DisplayNumbers As Label
End Class
