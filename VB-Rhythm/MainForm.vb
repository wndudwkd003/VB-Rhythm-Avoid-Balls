
Imports System.Threading
Imports System.Timers
Imports Newtonsoft.Json.Linq

Public Class MainForm

    Private Structure ScoreBall
        Dim scoreBall As Ball
        Dim flag As Boolean
    End Structure

    Private gameManager As GameManager = GameManager.getInstance
    Private gameSndIns As New GameSounds
    Private balls(100) As Ball
    Private userBall As New Ball(userFirstCoord, 0, userFirstAngle, userFirstDistance)
    Private scoreBalls(50) As ScoreBall
    Private inputKeys As New ArrayList
    Private mainGameStart As Boolean
    Private angle As Double = 0.0
    Private timerNow As ULong
    Private scoreTimerRecent As ULong = 0
    Private powerTimerRecent As ULong = 0
    Private recodTimerRecent As ULong = 0
    Private scoreGetTimerRecent As ULong = 0
    Private powerTime As Integer = 6
    Private MainLoopTimer As System.Timers.Timer
    Private MainLoopInterval As Integer = 33


    Private Delegate Sub DelegateInstance(str As String)


    Private Delegate Sub DelegateInstance2(gameManager As GameManager)


    Private Sub DelPlaySounds(str As String)
        gameSndIns.Play(str)
    End Sub

    Private Sub DelGameOver(gameManager As GameManager)
        Dim user As New User
        user.nickname = "test"
        user.score = gameManager.playScore
        user.hTime = gameManager.hourPlayTime
        user.mTime = gameManager.minPlayTime
        user.sTime = gameManager.secPlayTime
        Dim result As DialogResult = MessageBox.Show("기록을 남기시겠습니까?", "Game Over", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim input = InputBox("닉네임을 입력해주세요")
            user.nickname = input.ToString
            gameManager.user = user
        End If
        With StartForm
            .Show()
        End With

        Dim gmJson As String = gameManager.rank
        Dim tmpJson As New JObject()

        With tmpJson
            .Add("nickname", user.nickname)
            .Add("score", user.score)
            .Add("hTime", user.hTime)
            .Add("mTime", user.mTime)
            .Add("sTime", user.sTime)
        End With


        tmpJson.ToString()


        Close()
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysMduleInit()
        CheckForIllegalCrossThreadCalls = False

        gameManager.playLife = 3
        gameManager.playTime = 0
        gameManager.hourPlayTime = 0
        gameManager.minPlayTime = 0
        gameManager.secPlayTime = 0
        gameManager.playScore = 0
        gameManager.gameOverFlag = False
        gameManager.userDieState = 0

        gameSndIns.AddSound("start", "./Music/Start.wav")
        gameSndIns.AddSound("score", "./Music/GetScore.wav")
        gameSndIns.AddSound("die", "./Music/die.wav")

        TimeLabel.Text = "Timer : 00.00.00"
        ScoreLabel.Text = "Score : 0"
        LifeLable.Text = "Life : 3"
        PowerLabel.Text = ""

        With TimeLabel
            .Font = m6Font
        End With

        With ScoreLabel
            .Font = m6Font
        End With

        With LifeLable
            .Font = m6Font
        End With

        With PowerLabel
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
        If mainGameStart = True Then
            'If Not gameManager.gameSnds.IsPlaying("start") Then
            '    Me.Invoke(New DelegateInstance(AddressOf DelPlaySounds), "start")
            'End If

            ''''''''''''''''''''''''''''

            TimeLabel.Text = gameManager.TimeToString
            ScoreLabel.Text = gameManager.ScoreToString
            LifeLable.Text = gameManager.LifeToString


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


            If timerNow >= scoreTimerRecent + 50000000 Then
                scoreTimerRecent = timerNow
                For i = 0 To maxScoreCnt
                    If scoreBalls(i).flag = False Then
                        scoreBalls(i).scoreBall.coord.X = Math.Cos(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Width / 2 - enemySBallSize.Width / 2
                        scoreBalls(i).scoreBall.coord.Y = Math.Sin(scoreBalls(i).scoreBall.angle) * scoreBalls(i).scoreBall.distance + bgSize.Height / 2 - enemySBallSize.Height / 2
                        scoreBalls(i).flag = True
                        Exit For
                    End If
                Next
            End If

            If timerNow >= recodTimerRecent + 1000000 Then
                recodTimerRecent = timerNow
                gameManager.playTime += 100
            End If

            If timerNow >= scoreGetTimerRecent + 10000 Then
                scoreGetTimerRecent = timerNow
                gameManager.scoreState = False
            End If

            If gameManager.userDieState = 1 And timerNow >= powerTimerRecent + 10000000 Then
                powerTimerRecent = timerNow
                If powerTime <= 0 Then
                    powerTime = 0
                    PowerLabel.Text = ""
                    gameManager.userDieState = 0
                    powerTime = 6
                Else
                    powerTime -= 1
                    PowerLabel.Text = powerTime
                End If
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
                    If Not gameManager.userDieState = 1 Then
                        userBall.angle = userFirstAngle
                        PowerLabel.Visible = True
                        gameManager.userDieState = 1
                        gameManager.playLife -= 1
                        'Me.Invoke(New DelegateInstance(AddressOf DelPlaySounds), "die")
                        gameManager.gameSnds.Play("die")
                        If gameManager.playLife <= -1 And Not gameManager.gameOverFlag = True Then
                            gameManager.gameOverFlag = True
                            mainGameStart = False
                            MainLoopTimer.Enabled = False
                            MainLoopTimer.Stop()

                            Me.Invoke(New DelegateInstance2(AddressOf DelGameOver), gameManager)
                            Exit Sub
                        End If
                    End If
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
                    If Not gameManager.scoreState = True Then
                        gameManager.scoreState = True
                        scoreBalls(u).scoreBall.coord.X = -10
                        scoreBalls(u).scoreBall.coord.Y = -10
                        gameManager.playScore += 1
                        'Me.Invoke(New DelegateInstance(AddressOf DelPlaySounds), "score")
                        scoreBalls(u).flag = False
                    End If
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
                gameManager.gameSnds.Play("loby")
            End With
            Close()
        End If

    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        inputKeys.Remove(e.KeyCode)
    End Sub


    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        gameManager.gameSnds.Stop("start")
    End Sub

End Class