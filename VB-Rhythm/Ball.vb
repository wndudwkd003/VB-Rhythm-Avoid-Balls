Public Class Ball
    Public coord As Point
    Public speed As Double
    Public angle As Double
    Public distance As Double

    Public Sub SetRandCoord()
        Dim ran As New Random

        Randomize()
        Dim x1 As Integer = ran.Next(0, 100)
        Dim y1 As Integer = ran.Next(0, 100)
        Dim x2 As Integer = ran.Next(1300, 1500)
        Dim y2 As Integer = ran.Next(800, 900)

        Dim n As Short = ran.Next(0, 1)
        If n = 0 Then
            coord = New Point(-x1, -y1)
        Else
            coord = New Point(x2, y2)
        End If

        speed = ran.Next(1, 7)
        distance = ran.Next(700, 1000)
        angle = ran.Next(0, 360)

    End Sub

    Public Sub New(c As Point, S As Double, a As Double, d As Double)
        coord = c
        speed = S
        angle = a
        distance = d
    End Sub

    Public Sub CreateScoreBall()

    End Sub
End Class
