Imports System.Drawing.Imaging
Imports System.Formats.Asn1
Imports Microsoft.VisualBasic.Devices

Imports Newtonsoft.Json.Linq

Public Class StartForm

    Private startBall(16) As Ball
    Private gameManager As GameManager = GameManager.getInstance

    Public gif As Bitmap
    Public fd As FrameDimension
    Public frameCount As Integer
    Public frameNum As Integer

    Private Delegate Sub DelegateInstance3(fd As FrameDimension, fn As Integer, fc As Integer)
    Private Sub DelDrawGif(fd As FrameDimension, fn As Integer, fc As Integer)
        gif.SelectActiveFrame(fd, fn Mod fc)
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysMduleInit()
        BackColor = bgColor
        gif = My.Resources.bg_start_audio
        fd = New FrameDimension(gif.FrameDimensionsList(0))
        frameCount = gif.GetFrameCount(fd)


        Dim ran As New Random
        If gameManager.gameSnds.IsPlaying("start") Then
            gameManager.gameSnds.Stop("start")
        End If
        gameManager.gameSnds.Play("loby")

        For i = 0 To 15
            Dim ball As New Ball(New Point(200, 54), 0.0, Rnd(1) * 360, Rnd(1) * 300 + 120)
            startBall(i) = ball
        Next


        With StartButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With RankButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With LearnButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With ExitButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With


    End Sub

    Private Sub StartForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawImage(gif, 140, 200)
        e.Graphics.DrawEllipse(bgPen_01, 200, 54, midCircleSize.Width, midCircleSize.Height)
        For i = 0 To 15
            e.Graphics.FillEllipse(Brushes.Black, startBall(i).coord.X, startBall(i).coord.Y, enemySBallSize.Width, enemySBallSize.Height)
        Next
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click, RankButton.Click, LearnButton.Click, ExitButton.Click
        Dim btn As Button = DirectCast(sender, Button)

        gameManager.gameSnds.Play("click")

        Select Case btn.Name
            Case "StartButton"
                gameManager.gameSnds.Stop("loby")
                gameManager.gameSnds.Play("start")
                Dim formPlay As New MainForm
                formPlay.Show()
                Hide()

            Case "RankButton"
                'MsgBox("점수 : " & gameManager.user.score & vbCr & "시간 : " & gameManager.user.hTime & "." & gameManager.user.mTime & "." & gameManager.user.sTime)
                Dim formPlay As New Rank
                formPlay.Show()
                Hide()

            Case "LearnButton"
                Dim formPlay As New LearnForm
                formPlay.Show()
                Hide()

            Case "ExitButton"
                Dim result As DialogResult = MessageBox.Show("정말로 종료하시겠습니까?", "Game Exit", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Close()
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Invoke(New DelegateInstance3(AddressOf DelDrawGif), fd, frameNum, frameCount)
        frameNum += 1
        For i = 0 To 15
            startBall(i).angle += 0.05
            startBall(i).coord.X = Math.Cos(startBall(i).angle) * startBall(i).distance + 200 + midCircleSize.Width / 2 - enemySBallSize.Width / 2
            startBall(i).coord.Y = Math.Sin(startBall(i).angle) * startBall(i).distance + 54 + midCircleSize.Height / 2 - enemySBallSize.Height / 2
        Next
        Invalidate()
    End Sub
End Class