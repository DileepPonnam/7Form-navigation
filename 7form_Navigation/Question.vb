Public Class Question

    Dim Quest As String(,)
    Dim currentQuestion As Integer
    Dim previousForm As Form
    Dim nextForm As Form
    Dim currentScore As Integer
    Dim selected As Integer
    Dim rightAnswer As Integer
    Dim thisScore As Integer
    Dim mainForm As Form1


    Public Sub New(Questions As String(,), Q As Integer, previousForm As Form, mainForm As Form1)
        InitializeComponent()
        Quest = Questions
        currentQuestion = Q
        Me.mainForm = mainForm
        currentScore = 0
        thisScore = 0
        Me.previousForm = previousForm
        If Q < 4 Then
            nextForm = New Question(Questions, Q + 1, Me, mainForm)
        Else
            nextForm = New Results(mainForm)
        End If

        If Questions(Q, 5) = "A" Then
            rightAnswer = 1
        ElseIf Questions(Q, 5) = "B" Then
            rightAnswer = 2
        ElseIf Questions(Q, 5) = "C" Then
            rightAnswer = 3
        ElseIf Questions(Q, 5) = "D" Then
            rightAnswer = 4
        End If

    End Sub

    Private Sub Question_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Text = Quest(currentQuestion, 1)
        RadioButton2.Text = Quest(currentQuestion, 2)
        RadioButton3.Text = Quest(currentQuestion, 3)
        RadioButton4.Text = Quest(currentQuestion, 4)
        QuestionText.Text = Quest(currentQuestion, 0)
        ClearQuestions()
    End Sub

    Public Sub setScore(s As Integer)
        currentScore = s
    End Sub


    Private Sub ClearQuestions()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ClearQuestions()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        previousForm.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        mainForm.answers(currentQuestion) = selected
        If currentQuestion < 4 Then
            CType(nextForm, Question).setScore(currentScore + thisScore)
        Else
            CType(nextForm, Results).setScore(currentScore + thisScore)
        End If
        nextForm.Show()
        Hide()
    End Sub

    Private Sub RadioButton1_Click(sender As System.Object, e As System.EventArgs) Handles RadioButton1.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            selected = 2
        End If
        If selected = rightAnswer Then
            thisScore = 1
        Else
            thisScore = 0
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            selected = 3
        End If
        If selected = rightAnswer Then
            thisScore = 1
        Else
            thisScore = 0
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            selected = 1
        End If
        If selected = rightAnswer Then
            thisScore = 1
        Else
            thisScore = 0
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            selected = 4
        End If
        If selected = rightAnswer Then
            thisScore = 1
        Else
            thisScore = 0
        End If
    End Sub

    Private Sub Question_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        ClearQuestions()

    End Sub
End Class