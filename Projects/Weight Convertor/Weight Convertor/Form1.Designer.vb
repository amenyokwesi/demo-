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
        Me.txtinput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter weight in Kilogram "
        '
        'txtinput
        '
        Me.txtinput.Location = New System.Drawing.Point(274, 6)
        Me.txtinput.Name = "txtinput"
        Me.txtinput.Size = New System.Drawing.Size(100, 20)
        Me.txtinput.TabIndex = 1
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(16, 50)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(184, 13)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "Weight in pounds will be display here."
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(132, 174)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(109, 23)
        Me.cmdConvert.TabIndex = 3
        Me.cmdConvert.Text = "Convert Weight "
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 306)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtinput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Weight Convertor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdConvert As Button
End Class
