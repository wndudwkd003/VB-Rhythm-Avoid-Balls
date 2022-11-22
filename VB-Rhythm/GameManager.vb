Public Class GameManager
    Private Shared singleTonObj As GameManager

    Public playTime As ULong = 0
    Public playTimeStr As String
    Public hourPlayTime, minPlayTime, secPlayTime, msPlayTime As UInteger
    Public playScore As Integer = 0
    Public playScoreStr As String
    Public gameSnds As New GameSounds

    Private Sub New()
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

        playTimeStr = "Timer : " & Format(hourPlayTime, "00") & "." & Format(minPlayTime, "00") & "." & Format(secPlayTime, "00" & "." & Format(msPlayTime, "000"))

        Return playTimeStr

    End Function

    Public Function ScoreToString()

        playScoreStr = "Score : " & playScore

        Return playScoreStr

    End Function
End Class
