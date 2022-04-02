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
        Me.txtSideOne = New System.Windows.Forms.TextBox()
        Me.txtSideTwo = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the length of side 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter the length of side 2"
        '
        'txtSideOne
        '
        Me.txtSideOne.Location = New System.Drawing.Point(275, 5)
        Me.txtSideOne.Name = "txtSideOne"
        Me.txtSideOne.Size = New System.Drawing.Size(100, 20)
        Me.txtSideOne.TabIndex = 2
        '
        'txtSideTwo
        '
        Me.txtSideTwo.Location = New System.Drawing.Point(275, 34)
        Me.txtSideTwo.Name = "txtSideTwo"
        Me.txtSideTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtSideTwo.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(26, 85)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(153, 13)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "hypotenuse will be display here"
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(275, 168)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(75, 23)
        Me.cmdCalculate.TabIndex = 5
        Me.cmdCalculate.Text = "calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 371)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtSideTwo)
        Me.Controls.Add(Me.txtSideOne)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "hypotenuse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSideOne As TextBox
    Friend WithEvents txtSideTwo As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents cmdCalculate As Button
End Class
