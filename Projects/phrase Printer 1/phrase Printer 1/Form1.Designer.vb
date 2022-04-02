<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
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
        Me.txtInput1 = New System.Windows.Forms.TextBox()
        Me.txtinput2 = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdDisplayPhrase = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Phrase to be Repeated "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter times to be repeated "
        '
        'txtInput1
        '
        Me.txtInput1.Location = New System.Drawing.Point(318, 10)
        Me.txtInput1.Name = "txtInput1"
        Me.txtInput1.Size = New System.Drawing.Size(100, 20)
        Me.txtInput1.TabIndex = 2
        '
        'txtinput2
        '
        Me.txtinput2.Location = New System.Drawing.Point(318, 50)
        Me.txtinput2.Name = "txtinput2"
        Me.txtinput2.Size = New System.Drawing.Size(100, 20)
        Me.txtinput2.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(185, 101)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 13)
        Me.lblOutput.TabIndex = 4
        '
        'cmdDisplayPhrase
        '
        Me.cmdDisplayPhrase.Location = New System.Drawing.Point(82, 166)
        Me.cmdDisplayPhrase.Name = "cmdDisplayPhrase"
        Me.cmdDisplayPhrase.Size = New System.Drawing.Size(75, 23)
        Me.cmdDisplayPhrase.TabIndex = 5
        Me.cmdDisplayPhrase.Text = "PressMe"
        Me.cmdDisplayPhrase.UseVisualStyleBackColor = True
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 261)
        Me.Controls.Add(Me.cmdDisplayPhrase)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtinput2)
        Me.Controls.Add(Me.txtInput1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInput1 As TextBox
    Friend WithEvents txtinput2 As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdDisplayPhrase As Button
End Class
