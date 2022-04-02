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
        Me.CmdDisplay = New System.Windows.Forms.Label()
        Me.cmd = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdDisplay
        '
        Me.CmdDisplay.AutoSize = True
        Me.CmdDisplay.Location = New System.Drawing.Point(22, 24)
        Me.CmdDisplay.Name = "CmdDisplay"
        Me.CmdDisplay.Size = New System.Drawing.Size(142, 13)
        Me.CmdDisplay.TabIndex = 0
        Me.CmdDisplay.Text = "Output will be displayed here"
        '
        'cmd
        '
        Me.cmd.Location = New System.Drawing.Point(174, 308)
        Me.cmd.Name = "cmd"
        Me.cmd.Size = New System.Drawing.Size(211, 92)
        Me.cmd.TabIndex = 1
        Me.cmd.Text = "Display"
        Me.cmd.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(22, 52)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(490, 240)
        Me.lblOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 401)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.cmd)
        Me.Controls.Add(Me.CmdDisplay)
        Me.Name = "Form1"
        Me.Text = "Counter Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdDisplay As Label
    Friend WithEvents cmd As Button
    Friend WithEvents lblOutput As Label
End Class
