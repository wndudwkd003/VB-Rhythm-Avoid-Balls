Public Class Rank

    Private gameManager As GameManager = GameManager.getInstance
    Private list As New ArrayList

    Dim t1 As User
    Dim t2 As User
    Dim t3 As User
    Dim t4 As User
    Dim t5 As User

    Private Function tmpCompare(x As User, y As User)
        Return x.score.CompareTo(y.score)
    End Function

    Private Sub Rank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameManager = GameManager.getInstance
        list = gameManager.rankList
        list.Sort()

        With RankButton_1
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
        End With


        If list.Count > 0 Then
            t1 = list(0)
            RankButton_1.Text = t1.nickname
        End If

        With RankButton_2
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
        End With


        If list.Count > 1 Then
            t2 = list(1)
            RankButton_2.Text = t2.nickname
        End If

        With RankButton_3
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
        End With


        If list.Count > 2 Then
            t3 = list(2)
            RankButton_3.Text = t3.nickname
        End If

        With RankButton_4
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
        End With


        If list.Count > 3 Then
            t4 = list(3)
            RankButton_4.Text = t4.nickname
        End If

        With RankButton_5
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
        End With


        If list.Count > 4 Then
            t5 = list(4)
            RankButton_5.Text = t5.nickname
        End If

        If gameManager.user.nickname = "" Then
            gameManager.user.nickname = "test"
        End If

        NicknameLabel.Text = gameManager.user.nickname
        ScoreLabel.Text = gameManager.user.score
        TimeLabel.Text = gameManager.user.hTime & "." & gameManager.user.mTime & "." & gameManager.user.sTime

    End Sub

    Private Sub Rank_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            With StartForm
                .Show()
            End With
            Close()
        End If
    End Sub


    Private Sub ButtonClick(sender As Object, e As EventArgs) Handles RankButton_1.Click, RankButton_2.Click, RankButton_3.Click, RankButton_4.Click, RankButton_5.Click
        Dim btn As Button = DirectCast(sender, Button)

        gameManager.gameSnds.Play("click")
        Dim t As New User
        t.nickname = ""
        t.score = 0
        t.hTime = 0
        t.mTime = 0
        t.sTime = 0

        Select Case btn.Name
            Case "RankButton_1"
                If list.Count > 0 Then
                    t = t1
                End If
            Case "RankButton_2"
                If list.Count > 1 Then
                    t = t2
                End If
            Case "RankButton_3"
                If list.Count > 2 Then
                    t = t3
                End If
            Case "RankButton_4"
                If list.Count > 3 Then
                    t = t4
                End If
            Case "RankButton_5"
                If list.Count > 4 Then
                    t = t5
                End If
        End Select

        UsNickname.Text = t.nickname
        UsScore.Text = t.score
        UsTime.Text = t.hTime & "." & t.mTime & "." & t.sTime

    End Sub

End Class