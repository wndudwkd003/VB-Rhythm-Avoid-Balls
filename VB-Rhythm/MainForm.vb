
Imports System.Threading
Imports System.Timers

Public Class MainForm

    Private Structure ScoreBall
        Dim scoreBall As Ball
        Dim flag As Boolean
    End Structure

    Private mainThread As Thread

    Private gameManager As GameManager = GameManager.getInstance


    Private balls(100) As Ball
    Private userBall As New Ball(userFirstCoord, 0, userFirstAngle, userFirstDistance)

    Private scoreBalls(50) As ScoreBall

    Private inputKeys As New ArrayList
    Private mainGameStart As Boolean

    Private angle As Double = 0.0

    Private timerRecent As ULong = 0
    Private timerNow As ULong

    Private MainLoopTimer As System.Timers.Timer
    Private MainLoopInterval As Integer = 33


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysMduleInit()

        gameManager.gameSnds.Play("start")

        TimeLabel.Text = "Timer : 00.00.00"
        ScoreLabel.Text = "Score : 0"

        With TimeLabel
            .Font = m6Font
        End With

        With ScoreLabel
            .Font = m6Font
        End With

        'With BackButton
        '    .Font = m6Font
        '    .Padding = New Padding(0, 3, 0, 0)
        '    .FlatAppearance.BorderSize = 0
        '    .FlatAppearance.BorderColor = Color.Gray
        '    .FlatAppearance.MouseDownBackColor = fixedDGRAY
        '    .FlatAppearance.MouseOverBackColor = fixedGRAY
        '    .BackColor = Color.Transparent
        'End With



        For i = 0 To maxEnemyCnt
            Dim ball As New Ball(New Point(0, 0), 0.0, 0.0, 0.0)
            ball.SetRandCoord()
            balls(i) = ball
        Next

        For i = 0 To maxScoreCnt
            Randomize()
            Dim score As New Ball(New Point(10, -10), 0, Rnd() * 360, userFirstDistance)
            scoreBalls(i).scoreBall = score
            scoreBalls(i).flag = False
        Next

        MainLoopTimer = New System.Timers.Timer(MainLoopInterval)
        AddHandler MainLoopTimer.Elapsed, AddressOf MainLoopFunction
        MainLoopTimer.AutoReset = True
        MainLoopTimer.Enabled = True

        mainGameStart = True

    End Sub

    Private Sub MainLoopFunction(sender As Object, e As ElapsedEventArgs)

        If Not gameManager.gameSnds.IsPlaying("start") Then
            gameManager.gameSnds.Play("start")
        End If

        If mainGameStart = True Then

            ''''''''''''''''''''''''''''

            TimeLabel.Text = gameManager.TimeToString
            ScoreLabel.Text = gameManager.ScoreToString


            ''''''''''''''''''''''''''''

            userBall.coord.X = Math.Cos(userBall.angle) * userBall.distance + bgSize.Width / 2 - userFirstSize.Width / 2
            userBall.coord.Y = Math.Sin(userBall.angle) * userBall.distance + bgSize.Height / 2 - userFirstSize.Height / 2

            For i = 0 To maxScoreCnt
                If scoreBalls(i).flag = True Then
                    scoreBalls(i).scoreBall.coord.X = Math.Cos(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Width / 2 - enemySBallSize.Width / 2
                    scoreBalls(i).scoreBall.coord.Y = Math.Sin(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Height / 2 - enemySBallSize.Height / 2
                End If
            Next


            timerNow = DateTime.Now.Ticks
            If timerNow >= timerRecent + 40000000 Then
                timerRecent = timerNow
                For i = 0 To maxScoreCnt
                    If scoreBalls(i).flag = False Then
                        scoreBalls(i).scoreBall.coord.X = Math.Cos(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Width / 2 - enemySBallSize.Width / 2
                        scoreBalls(i).scoreBall.coord.Y = Math.Sin(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Height / 2 - enemySBallSize.Height / 2
                        scoreBalls(i).flag = True
                        Exit For
                    End If
                Next
            End If

            For u = 0 To 100
                balls(u).angle += angle
                balls(u).distance -= balls(u).speed
                balls(u).coord.X = Math.Cos(balls(u).angle) * balls(u).distance + bgSize.Width / 2 - enemySBallSize.Width / 2
                balls(u).coord.Y = Math.Sin(balls(u).angle) * balls(u).distance + bgSize.Height / 2 - enemySBallSize.Height / 2

                If Math.Pow(midCircleSize.Width / 2, 2) >=
                (Math.Pow(midCircleCoord.X + midCircleSize.Width / 2 - balls(u).coord.X - enemySBallSize.Width / 2, 2) +
                Math.Pow(midCircleCoord.Y + midCircleSize.Height / 2 - balls(u).coord.Y - enemySBallSize.Height / 2, 2)) Then
                    balls(u).SetRandCoord()
                End If

                If Math.Pow(userFirstSize.Width / 2, 2) >=
                (Math.Pow(userBall.coord.X + userFirstSize.Width / 2 - balls(u).coord.X - enemySBallSize.Width / 2, 2) +
                Math.Pow(userBall.coord.Y + userFirstSize.Height / 2 - balls(u).coord.Y - enemySBallSize.Height / 2, 2)) Then
                    userBall.angle = userFirstAngle
                    gameManager.gameSnds.Play("die")
                End If
            Next

            For u = 0 To 50
                If scoreBalls(u).flag = True Then
                    scoreBalls(u).scoreBall.angle += angle
                    scoreBalls(u).scoreBall.coord.X = Math.Cos(scoreBalls(u).scoreBall.angle) * scoreBalls(u).scoreBall.distance + bgSize.Width / 2 - enemySBallSize.Width / 2
                    scoreBalls(u).scoreBall.coord.Y = Math.Sin(scoreBalls(u).scoreBall.angle) * scoreBalls(u).scoreBall.distance + bgSize.Height / 2 - enemySBallSize.Height / 2
                End If

                If Math.Pow(userFirstSize.Width / 2, 2) >=
                (Math.Pow(userBall.coord.X + userFirstSize.Width / 2 - scoreBalls(u).scoreBall.coord.X - enemySBallSize.Width / 2, 2) +
                Math.Pow(userBall.coord.Y + userFirstSize.Height / 2 - scoreBalls(u).scoreBall.coord.Y - enemySBallSize.Height / 2, 2)) Then
                    scoreBalls(u).scoreBall.coord.X = -10
                    scoreBalls(u).scoreBall.coord.Y = -10
                    gameManager.playScore += 1
                    gameManager.gameSnds.Play("score")
                    scoreBalls(u).flag = False
                End If
            Next

            ''''''''''''''''''''''''''''

            For i = 0 To inputKeys.Count - 1
                If inputKeys(i) = Keys.Left Then
                    angle += angleIncrease
                    userBall.angle -= userAngleIncrease

                ElseIf inputKeys(i) = Keys.Right Then
                    angle -= angleIncrease
                    userBall.angle += userAngleIncrease


                End If

                If userBall.angle >= userMaxMoveAngle + userFirstAngle Then
                    userBall.angle = userMaxMoveAngle + userFirstAngle
                ElseIf userBall.angle <= -userMaxMoveAngle + userFirstAngle Then
                    userBall.angle = -userMaxMoveAngle + userFirstAngle
                End If
            Next

            If inputKeys.Count = 0 Then
                If angle > 0 Then
                    angle -= angleIncrease
                ElseIf angle < 0 Then
                    angle += angleIncrease
                End If

                If userBall.angle <= 224.66 And userBall.angle >= 224.63 Then
                    userBall.angle = userFirstAngle
                ElseIf userBall.angle < userFirstAngle Then
                    userBall.angle += userReMoveSpeed
                ElseIf userBall.angle > userFirstAngle Then
                    userBall.angle -= userReMoveSpeed

                End If

            End If

            ''''''''''''''''''''''''''''

            Invalidate()
        End If
    End Sub

    Private Sub MainForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawEllipse(bgPen_01, midCircleCoord.X, midCircleCoord.Y, midCircleSize.Width, midCircleSize.Height)
        e.Graphics.DrawEllipse(bgPen_01, userBall.coord.X, userBall.coord.Y, userFirstSize.Width, userFirstSize.Height)
        For i = 0 To 100
            e.Graphics.FillEllipse(Brushes.Black, balls(i).coord.X, balls(i).coord.Y, enemySBallSize.Width, enemySBallSize.Height)
        Next
        For i = 0 To 50
            e.Graphics.FillEllipse(Brushes.Yellow, scoreBalls(i).scoreBall.coord.X, scoreBalls(i).scoreBall.coord.Y, enemySBallSize.Width, enemySBallSize.Height)
        Next
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not inputKeys.Contains(e.KeyCode) Then
            inputKeys.Add(e.KeyCode)
        End If

        If e.KeyCode = Keys.Escape Then
            With StartForm
                .Show()
            End With
            Close()
        End If

    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        inputKeys.Remove(e.KeyCode)
    End Sub

    Private Sub RecTimer_Tick(sender As Object, e As EventArgs) Handles RecTimer.Tick
        gameManager.playTime += RecTimer.Interval
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        RecTimer.Enabled = False
        gameManager.gameSnds.Stop("start")
    End Sub

End Class