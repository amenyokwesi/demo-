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
        Me.txtNumStudents = New System.Windows.Forms.TextBox()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.cmdFindClassroom = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of student"
        '
        'txtNumStudents
        '
        Me.txtNumStudents.Location = New System.Drawing.Point(126, 6)
        Me.txtNumStudents.Name = "txtNumStudents"
        Me.txtNumStudents.Size = New System.Drawing.Size(100, 20)
        Me.txtNumStudents.TabIndex = 1
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Location = New System.Drawing.Point(33, 61)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(193, 13)
        Me.lblRoom.TabIndex = 2
        Me.lblRoom.Text = "Allocated of class will be displayed here"
        '
        'cmdFindClassroom
        '
        Me.cmdFindClassroom.Location = New System.Drawing.Point(58, 195)
        Me.cmdFindClassroom.Name = "cmdFindClassroom"
        Me.cmdFindClassroom.Size = New System.Drawing.Size(168, 23)
        Me.cmdFindClassroom.TabIndex = 3
        Me.cmdFindClassroom.Text = "find class room"
        Me.cmdFindClassroom.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdFindClassroom)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.txtNumStudents)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumStudents As TextBox
    Friend WithEvents lblRoom As Label
    Friend WithEvents cmdFindClassroom As Button
End Class
