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
        Me.CmdDisplayEvenNums = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CmdDisplayEvenNums
        '
        Me.CmdDisplayEvenNums.Location = New System.Drawing.Point(69, 44)
        Me.CmdDisplayEvenNums.Name = "CmdDisplayEvenNums"
        Me.CmdDisplayEvenNums.Size = New System.Drawing.Size(170, 38)
        Me.CmdDisplayEvenNums.TabIndex = 0
        Me.CmdDisplayEvenNums.Text = "Display Even Numbers"
        Me.CmdDisplayEvenNums.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.Location = New System.Drawing.Point(12, 103)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(425, 230)
        Me.lblOutput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 370)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.CmdDisplayEvenNums)
        Me.Name = "Form1"
        Me.Text = "Event Number to 40"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CmdDisplayEvenNums As Button
    Friend WithEvents lblOutput As Label
End Class
