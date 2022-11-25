Imports System.Formats.Asn1
Imports Microsoft.VisualBasic.Devices

Imports Newtonsoft.Json.Linq

Public Class StartForm

    Private client As ClientSock
    Private userName As String
    Private servAddr As String
    Const port_n As Integer = 8080
    Public IsConn As Boolean = False

    Private gameManager As GameManager = GameManager.getInstance
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysMduleInit()

        If gameManager.gameSnds.IsPlaying("start") Then
            gameManager.gameSnds.Stop("start")
        End If
        gameManager.gameSnds.Play("loby")


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
        e.Graphics.DrawEllipse(bgPen_01, 200, 53, midCircleSize.Width, midCircleSize.Height)
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

End Class