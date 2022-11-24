Public Class GameManager
    Private Shared singleTonObj As GameManager

    Public playTime As ULong = 0
    Public playTimeStr As String
    Public hourPlayTime As UInteger = 0
    Public minPlayTime As UInteger = 0
    Public secPlayTime As UInteger = 0
    Public msPlayTime As UInteger = 0
    Public playScore As Integer = 0
    Public playScoreStr As String
    Public playLife As Short = 3
    Public playLifeStr As String
    Public gameOverFlag As Boolean = False
    Public scoreState As Boolean = False
    Public userDieState As Short = 0
    Public soundState As Short = 0
    Public gameSnds As GameSounds
    Public user As User
    Public rank As String



    Private Sub New()
        gameSnds = New GameSounds
        gameSnds.AddSound("start", "./Music/Start.wav")
        gameSnds.AddSound("loby", "./Music/Loby.wav")
        gameSnds.AddSound("click", "./Music/ButtonClick.wav")
        gameSnds.AddSound("text", "./Music/TextRead.wav")
        gameSnds.AddSound("score", "./Music/GetScore.wav")
        gameSnds.AddSound("die", "./Music/die.wav")
        gameSnds.AddSound("mouse", "./Music/mouse.wav")
    End Sub

    Public Shared Function getInstance() As GameManager
        If (singleTonObj Is Nothing) Then
            singleTonObj = New GameManager()
        End If
        Return singleTonObj
    End Function

    Public Function TimeToString()

        msPlayTime = ((playTime Mod 1000) \ 10)

        secPlayTime = (playTime - msPlayTime) \ 1000
        secPlayTime = secPlayTime Mod 60

        minPlayTime = (playTime - msPlayTime) \ 1000
        minPlayTime = minPlayTime \ 60

        hourPlayTime = (playTime - msPlayTime) \ 1000
        hourPlayTime = (hourPlayTime \ 60) \ 60

        playTimeStr = "Timer : " & Format(hourPlayTime, "00") & "." & Format(minPlayTime, "00") & "." & Format(secPlayTime, "00")

        Return playTimeStr

    End Function

    Public Function ScoreToString()

        playScoreStr = "Score : " & playScore

        Return playScoreStr

    End Function

    Public Function LifeToString()

        playLifeStr = "Life : " & playLife

        Return playLifeStr

    End Function
End Class
