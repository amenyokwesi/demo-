Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblDisplay.Text = "button 1 has been clicked on"
        lblDisplay.Text = lblDisplay.Text & vbCrLf & "It Name is:" & Button1.Name
        lblDisplay.BackColor = Button1.BackColor
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblDisplay.Text = "button 2 has been click on"
    End Sub

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        lblDisplay.Text = "button 3 has been click on"
    End Sub

    Private Sub te_TextChanged(sender As Object, e As EventArgs) Handles te.TextChanged
        'lblDisplay.Text = "Textbox's content has changed"
        lblDisplay.Text = te.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lblDisplay.Text = "lable 1 has been click on"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        lblDisplay.Text = "label 2 has been click on"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        lblDisplay.Text = "label 3 has been click on"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblDisplay.Text = "TextBox1 has been clicked on"

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        'lblDisplay.Text = "Textbox's content has changed"
        lblDisplay.Text = TextBox2.Text
    End Sub
End Class
