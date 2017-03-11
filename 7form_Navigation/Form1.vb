Public Class Form1

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Public FirstName As String
    Public LastName As String
    Public answers(5) As Integer
    Public Questions As String(,)

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Questions =
                                         {{"How much is 5+9?", "15", "14", "59", "13", "B"},
                                          {"How much is 8x4?", "32", "16", "84", "12", "A"},
                                          {"How much is 12-5?", "125", "19", "7", "8", "C"},
                                          {"How much is 60/12?", "60", "12", "6", "5", "D"},
                                          {"How much is 5x9?", "59", "35", "45", "40", "C"}}

        FirstName = TextBox1.Text
        LastName = TextBox2.Text

        Dim QuestionForm As New Question(Questions, 0, Me, Me)
        QuestionForm.setScore(0)
        QuestionForm.Show()
        Hide()
    End Sub
End Class
