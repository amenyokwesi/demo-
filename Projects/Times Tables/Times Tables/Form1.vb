Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdDisplayTable.Click
        Dim table As Integer
        Dim answer As Integer
        'clear the label
        lblOutput.Text = ""

        'get the times table from your textbox
        table = txtTimes.Text

        For counter = 1 To 10
            ' calculate the current sum
            answer = table * counter
            'output  the sum and the answer to the label
            lblOutput.Text = lbloutput.Text & TAB() counter &"times" & counter & "is" & answer & vbCrlf

        Next
    End Sub
End Class
