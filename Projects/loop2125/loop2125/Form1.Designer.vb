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
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(28, 12)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(100, 20)
        Me.txtMsg.TabIndex = 0
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(37, 56)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(183, 366)
        Me.lblDisplay.TabIndex = 1
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(107, 455)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(75, 23)
        Me.Button.TabIndex = 2
        Me.Button.Text = "Repeat"
        Me.Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 532)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtMsg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMsg As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Button As Button
End Class
