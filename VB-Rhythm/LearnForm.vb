Imports System.Threading

Public Class LearnForm
    Private gameManager As GameManager = GameManager.getInstance
    Private messageNowIndex As Integer = 0
    Private scripts() As String = {"Avoid Balls에 오신것을 환영합니다! ▽",
    "이 게임은 화면속 작은 공을 조종하여 ▽",
    "날아오는 검은 공을 피하는 게임입니다! ▽",
    "여러분이 조종하는 작은 공은 화면 중앙에 있습니다 ▽",
    "ESC 키를 누르면 이전 화면으로 갑니다 ▽",
    "키보드 왼쪽과 오른쪽을 누르면 화면이 회전합니다 ▽",
    "밖에서 날아오는 검은 공을 피하시고 ▽",
    "노란 공을 획득하여 점수를 얻으면서 최대한 살아남으세요! ▽",
    "노란 공은 랜덤한 점수를 얻습니다.  ▽",
    "검은공에 닿으면 목숨이 하나 깎이면서 5초간의 무적 시간이 있습니다 ▽",
    "목숨을 전부 잃으면 게임 오버됩니다 ▽",
    "오랫동안 살아남아 기록을 남겨보세요! ▽",
    "OVER"}
    Private messageThread As Thread
    Private recentTime As Date
    Private messageIndex As Integer = 0
    Private thFlag As Boolean = True
    Private Sub LearnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False
        SysMduleInit()

        With LearnLabel
            .Font = dosFont
        End With

        messageThread = New Thread(AddressOf showMessageLoop) With {
                .IsBackground = True
            }
        messageThread.Start()
        recentTime = Now
    End Sub

    Private Sub showMessageLoop(obj As Object)
        While thFlag = True
            Dim appendStr As String = ""
            Dim rT As ULong = 1 - (Now.Ticks - recentTime.Ticks) / 1000000
            Dim str As String = scripts(messageIndex)
            If rT <= 0 Then
                For i = 0 To messageNowIndex - 1
                    appendStr += str.Chars(i)
                Next
                LearnLabel.Text = appendStr
                If messageNowIndex < scripts(messageIndex).Length Then
                    messageNowIndex += 1
                End If
                recentTime = Now
            End If
        End While
    End Sub

    Private Sub LearnForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub LearnForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            With StartForm
                .Show()
            End With
            Close()
        ElseIf e.KeyCode = Keys.Enter Then
            messageIndex += 1
            If messageIndex = scripts.Count - 1 Then
                messageIndex = 0
                thFlag = False
                With StartForm
                    .Show()
                End With
                Close()
            End If
            messageNowIndex = 0
        End If
    End Sub

    Private Sub LearnForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        gameManager.gameSnds.Stop("loby")
    End Sub
End Class