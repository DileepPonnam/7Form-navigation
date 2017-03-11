Public Class Results

    Dim curentScore As Integer
    Dim mainForm As Form1

    Public Sub New(mainForm As Form1)
        InitializeComponent()
        Me.mainForm = mainForm
    End Sub


    Public Sub setScore(s As Integer)
        curentScore = s
    End Sub

    Private Sub Results_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Function IsCorrect(Question As Integer, Answer As Integer) As Boolean
        Dim correct As String
        correct = mainForm.Questions(Question, 5)
        If correct = "A" And Answer = 1 Then Return True
        If correct = "B" And Answer = 2 Then Return True
        If correct = "C" And Answer = 3 Then Return True
        If correct = "D" And Answer = 4 Then Return True
        Return False
    End Function


    Private Sub Results_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        scoreLabel.Text = "Your score: " + Str(curentScore) + " / 5"
        nameLabel.Text = mainForm.FirstName + "  " + mainForm.LastName

        If curentScore = 5 Then
            wrongLabel.Text = "You have no wrong answers"
        Else

            wrongLabel.Text = "Wrong answers:" + vbCrLf
            For i = 0 To 4
                If Not IsCorrect(i, mainForm.answers(i)) Then
                    wrongLabel.Text = wrongLabel.Text + "Question " + Str(i + 1) + ". Correct answer: " + mainForm.Questions(i, 5) + vbCrLf
                End If
            Next
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
        mainForm.Show()
    End Sub
End Class