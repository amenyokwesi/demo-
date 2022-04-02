Public Class Form1
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim msg As String
        msg = "the counter is now at"
        lblDisplay.Text = ""
        For counter = 1 To 16
            lblDisplay.Text = lblDisplay.Text & msg & counter & vbCrLf
        Next
    End Sub
End Class
