Public Class Rank

    Private gameManager As GameManager = GameManager.getInstance
    Private list As New ArrayList

    'Dim t1 As User
    'Dim t2 As User
    'Dim t3 As User
    'Dim t4 As User
    'Dim t5 As User


    Private Sub Rank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameManager = GameManager.getInstance

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



End Class