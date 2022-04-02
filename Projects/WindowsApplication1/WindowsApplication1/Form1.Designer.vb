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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdPressMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(22, 12)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(486, 20)
        Me.txtMessage.TabIndex = 0
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(19, 61)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(486, 197)
        Me.lblOutput.TabIndex = 1
        '
        'cmdPressMe
        '
        Me.cmdPressMe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPressMe.Location = New System.Drawing.Point(105, 346)
        Me.cmdPressMe.Name = "cmdPressMe"
        Me.cmdPressMe.Size = New System.Drawing.Size(205, 59)
        Me.cmdPressMe.TabIndex = 2
        Me.cmdPressMe.Text = "Press me"
        Me.cmdPressMe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 482)
        Me.Controls.Add(Me.cmdPressMe)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtMessage)
        Me.Name = "Form1"
        Me.Text = "MyFirstEventDrivenApplication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdPressMe As Button
End Class
