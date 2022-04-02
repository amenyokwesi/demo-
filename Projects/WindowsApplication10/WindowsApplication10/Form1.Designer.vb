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
        Dim btnDisplay As System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblDisplay = New System.Windows.Forms.Label()
        btnDisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the phrase to be repeated:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter times to be repeated:"
        '
        'txtPhrase
        '
        Me.txtPhrase.Location = New System.Drawing.Point(224, 2)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(125, 20)
        Me.txtPhrase.TabIndex = 2
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(224, 29)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(125, 20)
        Me.txtNumber.TabIndex = 3
        '
        'btnDisplay
        '
        btnDisplay.Location = New System.Drawing.Point(144, 237)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New System.Drawing.Size(75, 23)
        btnDisplay.TabIndex = 4
        btnDisplay.Text = "Display"
        btnDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btnDisplay.UseVisualStyleBackColor = True
        AddHandler btnDisplay.Click, AddressOf Me.Button1_Click
        '
        'lblDisplay
        '
        Me.lblDisplay.Location = New System.Drawing.Point(15, 67)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(334, 151)
        Me.lblDisplay.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 321)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(btnDisplay)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Phrase Printer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblDisplay As Label
End Class
