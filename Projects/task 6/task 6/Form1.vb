Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles CmdDrawRectangle.Click
        Dim rows As Integer
        Dim columns As Integer
        'get the row and column values from the textboxes
        rows = txtRows.Text
        columns = txtColumns.Text

        'clear the label text 
        lblRectangle.Text = ""

        ' Draw the rectangle
        For i - 1 To rows
            'draw each row one at a time 
            For j - 1 To columns
                lblRectangle.Text = lblRectangle.Text & "*"
            Next
            'After each row, add a line break
            lblRectangle.Text = lblRectangle.Text & vbCrLf
        Next
    End Sub
End Class
