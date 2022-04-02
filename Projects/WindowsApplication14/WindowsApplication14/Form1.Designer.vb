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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdsubtract = New System.Windows.Forms.Button()
        Me.cmddivision = New System.Windows.Forms.Button()
        Me.cmdmultiply = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "number1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "number2"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(106, 5)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 2
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(106, 30)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 3
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(23, 132)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.cmdAdd.TabIndex = 4
        Me.cmdAdd.Text = "addition"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdsubtract
        '
        Me.cmdsubtract.Location = New System.Drawing.Point(131, 132)
        Me.cmdsubtract.Name = "cmdsubtract"
        Me.cmdsubtract.Size = New System.Drawing.Size(75, 23)
        Me.cmdsubtract.TabIndex = 5
        Me.cmdsubtract.Text = "subtraction"
        Me.cmdsubtract.UseVisualStyleBackColor = True
        '
        'cmddivision
        '
        Me.cmddivision.Location = New System.Drawing.Point(131, 173)
        Me.cmddivision.Name = "cmddivision"
        Me.cmddivision.Size = New System.Drawing.Size(75, 23)
        Me.cmddivision.TabIndex = 6
        Me.cmddivision.Text = "division"
        Me.cmddivision.UseVisualStyleBackColor = True
        '
        'cmdmultiply
        '
        Me.cmdmultiply.Location = New System.Drawing.Point(26, 173)
        Me.cmdmultiply.Name = "cmdmultiply"
        Me.cmdmultiply.Size = New System.Drawing.Size(75, 23)
        Me.cmdmultiply.TabIndex = 7
        Me.cmdmultiply.Text = "multiplication"
        Me.cmdmultiply.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(106, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 23)
        Me.Label3.TabIndex = 8
        '
        'lbldisplay
        '
        Me.lbldisplay.Location = New System.Drawing.Point(58, 67)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(156, 23)
        Me.lbldisplay.TabIndex = 9
        Me.lbldisplay.Text = "answer will be display here"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdmultiply)
        Me.Controls.Add(Me.cmddivision)
        Me.Controls.Add(Me.cmdsubtract)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents cmdAdd As Button
    Friend WithEvents cmdsubtract As Button
    Friend WithEvents cmddivision As Button
    Friend WithEvents cmdmultiply As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lbldisplay As Label
End Class
