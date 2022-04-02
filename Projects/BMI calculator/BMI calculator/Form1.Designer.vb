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
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtheight = New System.Windows.Forms.TextBox()
        Me.txtweight = New System.Windows.Forms.TextBox()
        Me.cmdcal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Height"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter weight in kilogram "
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(23, 118)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(102, 13)
        Me.lblOutput.TabIndex = 2
        Me.lblOutput.Text = "BMI will display here"
        '
        'txtheight
        '
        Me.txtheight.Location = New System.Drawing.Point(134, 5)
        Me.txtheight.Name = "txtheight"
        Me.txtheight.Size = New System.Drawing.Size(100, 20)
        Me.txtheight.TabIndex = 3
        '
        'txtweight
        '
        Me.txtweight.Location = New System.Drawing.Point(134, 34)
        Me.txtweight.Name = "txtweight"
        Me.txtweight.Size = New System.Drawing.Size(100, 20)
        Me.txtweight.TabIndex = 4
        '
        'cmdcal
        '
        Me.cmdcal.Location = New System.Drawing.Point(227, 206)
        Me.cmdcal.Name = "cmdcal"
        Me.cmdcal.Size = New System.Drawing.Size(75, 23)
        Me.cmdcal.TabIndex = 7
        Me.cmdcal.Text = "Find BMI"
        Me.cmdcal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 287)
        Me.Controls.Add(Me.cmdcal)
        Me.Controls.Add(Me.txtweight)
        Me.Controls.Add(Me.txtheight)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "BMI Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtheight As TextBox
    Friend WithEvents txtweight As TextBox
    Friend WithEvents cmdcal As Button
End Class
