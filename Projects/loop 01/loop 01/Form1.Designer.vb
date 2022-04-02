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
        Me.btnRepeat = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMsg
        '
        Me.txtMsg.Location = New System.Drawing.Point(103, 17)
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(260, 20)
        Me.txtMsg.TabIndex = 0
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(112, 70)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(329, 336)
        Me.lblDisplay.TabIndex = 1
        '
        'btnRepeat
        '
        Me.btnRepeat.Location = New System.Drawing.Point(106, 430)
        Me.btnRepeat.Name = "btnRepeat"
        Me.btnRepeat.Size = New System.Drawing.Size(271, 41)
        Me.btnRepeat.TabIndex = 2
        Me.btnRepeat.Text = "REPEAT"
        Me.btnRepeat.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 514)
        Me.Controls.Add(Me.btnRepeat)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.txtMsg)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtMsg As TextBox
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnRepeat As Button
End Class
