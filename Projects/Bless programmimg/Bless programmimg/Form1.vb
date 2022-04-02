Public Class Form1
    Private Sub cmdFindClassroom_Click(sender As Object, e As EventArgs) Handles cmdFindClassroom.Click
        Dim numstudents As Integer
        Dim classroom As String
        'get number of student from textbook


        numstudents = txtNumStudents.Text
        'check which classroom to assignt to
        'as we said don't put them in too big a room
        'then check the lower limits as well as the upper limits where appropriate


        If numstudents <= 12 Then
            classroom = "y212"
        ElseIf numstudents > 12 And numStudents <= 15 Then
            classroom = "y212"
        ElseIf numstudents = 16
            classroom = "y213"
        ElseIf numstudents > 16 And numstudents <= 20
            classroom = "y214"
        ElseIf numstudents > 20 And numstudents <= 25
            classroom = "y215"
        Else
            classroom = "no suitable class Avaliable:" & vbCrLf &
            "break class into smaller groups and try again"

            'update variable
        End If
        lblRoom.Text = classroom
    End Sub
End Class
