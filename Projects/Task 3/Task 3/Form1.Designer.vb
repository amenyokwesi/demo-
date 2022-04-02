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
        Me.Cmdcountdown = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbloutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cmdcountdown
        '
        Me.Cmdcountdown.Location = New System.Drawing.Point(103, 9)
        Me.Cmdcountdown.Name = "Cmdcountdown"
        Me.Cmdcountdown.Size = New System.Drawing.Size(118, 39)
        Me.Cmdcountdown.TabIndex = 0
        Me.Cmdcountdown.Text = "Countdown"
        Me.Cmdcountdown.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(8, 8)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbloutput
        '
        Me.lbloutput.AutoSize = True
        Me.lbloutput.Location = New System.Drawing.Point(22, 75)
        Me.lbloutput.Name = "lbloutput"
        Me.lbloutput.Size = New System.Drawing.Size(137, 13)
        Me.lbloutput.TabIndex = 2
        Me.lbloutput.Text = "Countdown will display here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 261)
        Me.Controls.Add(Me.lbloutput)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Cmdcountdown)
        Me.Name = "Form1"
        Me.Text = "Countdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmdcountdown As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbloutput As Label
End Class
