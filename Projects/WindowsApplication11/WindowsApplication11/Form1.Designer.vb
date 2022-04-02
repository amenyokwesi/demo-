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
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtphrase = New System.Windows.Forms.TextBox()
        Me.txtnumber = New System.Windows.Forms.TextBox()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(117, 341)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(185, 67)
        Me.btndisplay.TabIndex = 0
        Me.btndisplay.Text = "Display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(25, 18)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(145, 13)
        Me.txt.TabIndex = 1
        Me.txt.Text = "Enter phrase to be repeated: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter times to be repeated: "
        '
        'txtphrase
        '
        Me.txtphrase.Location = New System.Drawing.Point(251, 11)
        Me.txtphrase.Name = "txtphrase"
        Me.txtphrase.Size = New System.Drawing.Size(176, 20)
        Me.txtphrase.TabIndex = 3
        '
        'txtnumber
        '
        Me.txtnumber.Location = New System.Drawing.Point(251, 43)
        Me.txtnumber.Name = "txtnumber"
        Me.txtnumber.Size = New System.Drawing.Size(176, 20)
        Me.txtnumber.TabIndex = 4
        '
        'lbldisplay
        '
        Me.lbldisplay.Location = New System.Drawing.Point(28, 86)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(383, 228)
        Me.lbldisplay.TabIndex = 5
        Me.lbldisplay.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 440)
        Me.Controls.Add(Me.lbldisplay)
        Me.Controls.Add(Me.txtnumber)
        Me.Controls.Add(Me.txtphrase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.btndisplay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btndisplay As Button
    Friend WithEvents txt As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtphrase As TextBox
    Friend WithEvents txtnumber As TextBox
    Friend WithEvents lbldisplay As Label
End Class
