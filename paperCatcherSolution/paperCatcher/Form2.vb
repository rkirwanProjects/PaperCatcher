Public Class Form2

    Dim Counter As Integer
    Dim pctPaper(3) As PictureBox
    Dim RandomSpawn As Integer

    Public Sub New()
        MyBase.New()
        'This call is required by the designer.
        InitializeComponent()

        pctPaper(0) = PictureBox1
        pctPaper(1) = PictureBox2
        pctPaper(2) = PictureBox3
        pctPaper(3) = PictureBox4
    End Sub

    'Set player score and time left
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Score = 0
        Counter = 60
        lblScoreTotal.Text = Score
        lblTimeLeft.Text = Counter
    End Sub

    'Move bin left and right
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                If pctBin.Location.X > 0 Then
                    pctBin.Location = New Point(pctBin.Location.X - 20, pctBin.Location.Y)
                End If
            Case Keys.Right
                If pctBin.Location.X < 530 Then
                    pctBin.Location = New Point(pctBin.Location.X + 20, pctBin.Location.Y)
                End If
        End Select
    End Sub

    'Make paper fall randomly
    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        For i As Integer = 0 To 3
            pctPaper(i).Top = pctPaper(i).Top + 10
            If pctBin.Bounds.IntersectsWith(pctPaper(i).Bounds) Then
                RandomSpawn = Int(Rnd() * 400)
                pctPaper(i).Location = New Point(RandomSpawn, -100)
                Score = Score + 1
                lblScoreTotal.Text = Score
            ElseIf pctPaper(i).Top > 400 Then
                RandomSpawn = Int(Rnd() * 400)
                pctPaper(i).Location = New Point(RandomSpawn, -100)
            End If
        Next

    End Sub

    'Count down time left
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Counter = Counter - 1
        lblTimeLeft.Text = Counter

        If Counter < 0 Then
            GameOver()
        End If
    End Sub

    'Change form when game finishes
    Sub GameOver()
        Timer1.Enabled = False
        Timer2.Enabled = False
        lblScore.Visible = False
        lblScoreTotal.Visible = False
        lblTime.Visible = False
        lblTimeLeft.Visible = False
        lblGameOver.Visible = True
        lblFinalScore.Visible = True
        lblFinalScoreTotal.Visible = True
        lblFinalScoreTotal.Text = Score
        btnLoadScore.Visible = True
    End Sub

    'Take player to highscores
    Private Sub btnLoadScore_Click(sender As Object, e As EventArgs) Handles btnLoadScore.Click
        Form3.Show()
        Me.Hide()
    End Sub

End Class