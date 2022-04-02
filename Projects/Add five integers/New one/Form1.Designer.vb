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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum3 = New System.Windows.Forms.TextBox()
        Me.txtnum4 = New System.Windows.Forms.TextBox()
        Me.txtnum5 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter whole number one"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter whole number two"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter whole number three"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter whole number four"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Enter whole number five"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(27, 159)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(121, 13)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "Answer will display here."
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(320, 15)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 6
        '
        'txtnum3
        '
        Me.txtnum3.Location = New System.Drawing.Point(320, 68)
        Me.txtnum3.Name = "txtnum3"
        Me.txtnum3.Size = New System.Drawing.Size(100, 20)
        Me.txtnum3.TabIndex = 7
        '
        'txtnum4
        '
        Me.txtnum4.Location = New System.Drawing.Point(320, 94)
        Me.txtnum4.Name = "txtnum4"
        Me.txtnum4.Size = New System.Drawing.Size(100, 20)
        Me.txtnum4.TabIndex = 8
        '
        'txtnum5
        '
        Me.txtnum5.Location = New System.Drawing.Point(320, 116)
        Me.txtnum5.Name = "txtnum5"
        Me.txtnum5.Size = New System.Drawing.Size(100, 20)
        Me.txtnum5.TabIndex = 9
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(320, 42)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Calculate total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum5)
        Me.Controls.Add(Me.txtnum4)
        Me.Controls.Add(Me.txtnum3)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum3 As TextBox
    Friend WithEvents txtnum4 As TextBox
    Friend WithEvents txtnum5 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents Button1 As Button
End Class
