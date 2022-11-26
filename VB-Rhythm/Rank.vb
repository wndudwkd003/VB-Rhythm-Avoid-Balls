Imports System.Drawing.Imaging

Public Class Rank

    Private gameManager As GameManager = GameManager.getInstance
    Private list As New ArrayList

    'Dim t1 As User
    'Dim t2 As User
    'Dim t3 As User
    'Dim t4 As User
    'Dim t5 As User

    Public gif2 As Bitmap
    Public fd2 As FrameDimension
    Public frameCount2 As Integer
    Public frameNum2 As Integer
    Private Delegate Sub DelegateInstance4(fd As FrameDimension, fn As Integer, fc As Integer)
    Private Sub DelDrawGif2(fd As FrameDimension, fn As Integer, fc As Integer)
        gif2.SelectActiveFrame(fd, fn Mod fc)
    End Sub
    Private Sub Rank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gameManager = GameManager.getInstance
        gif2 = My.Resources.bg_mid_al
        fd2 = New FrameDimension(gif2.FrameDimensionsList(0))
        frameCount2 = gif2.GetFrameCount(fd2)
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Invoke(New DelegateInstance4(AddressOf DelDrawGif2), fd2, frameNum2, frameCount2)
        frameNum2 += 1
        Invalidate()

    End Sub

    Private Sub Rank_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawImage(gif2, 250 - 85, 200)
    End Sub

    Private Sub Rank_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        gameManager.gameSnds.Stop("loby")
    End Sub
End Class