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
        Me.txtinput1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOutput1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.txtinput2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter distance in miles "
        '
        'txtinput1
        '
        Me.txtinput1.Location = New System.Drawing.Point(138, 12)
        Me.txtinput1.Name = "txtinput1"
        Me.txtinput1.Size = New System.Drawing.Size(100, 20)
        Me.txtinput1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "distance in km:"
        '
        'lblOutput1
        '
        Me.lblOutput1.AutoSize = True
        Me.lblOutput1.Location = New System.Drawing.Point(199, 53)
        Me.lblOutput1.Name = "lblOutput1"
        Me.lblOutput1.Size = New System.Drawing.Size(125, 13)
        Me.lblOutput1.TabIndex = 3
        Me.lblOutput1.Text = "Distance will display here"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Distancein in Miles" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Enter Distance in Kilometres"
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(199, 218)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(142, 13)
        Me.lblOutput2.TabIndex = 6
        Me.lblOutput2.Text = "Distance will be Display here" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(32, 103)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(167, 23)
        Me.cmdConvert.TabIndex = 7
        Me.cmdConvert.Text = "Convert miles to kilometres "
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'txtinput2
        '
        Me.txtinput2.Location = New System.Drawing.Point(202, 171)
        Me.txtinput2.Name = "txtinput2"
        Me.txtinput2.Size = New System.Drawing.Size(100, 20)
        Me.txtinput2.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Convert Kilometres to Miles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 356)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtinput2)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOutput1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtinput1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtinput1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOutput1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents cmdConvert As Button
    Friend WithEvents txtinput2 As TextBox
    Friend WithEvents Button2 As Button
End Class
