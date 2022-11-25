Module SysModule



    ''''''''''''''''''''''''''''
    ' 오브젝트 관련
    Public ReadOnly bgSize As New Size(1280, 720)
    Public ReadOnly midCircleCoord As New Point(555, 275)
    Public ReadOnly midCircleSize As New Size(170, 170)
    Public ReadOnly userFirstCoord As New Point(628, 220)
    Public ReadOnly userFirstAngle As Double = 224.631
    Public ReadOnly userFirstDistance As Double = 130.0
    Public ReadOnly userFirstSize As New Size(24, 24)
    Public ReadOnly enemySBallSize As New Size(8, 8)
    Public ReadOnly angleIncrease As Double = 0.001
    Public ReadOnly userAngleIncrease As Double = 0.02
    Public ReadOnly userMaxMoveAngle As Double = userAngleIncrease * 10
    Public ReadOnly userReMoveSpeed As Double = userAngleIncrease - 0.005

    ''''''''''''''''''''''''''''
    ' Sound 관련



    ''''''''''''''''''''''''''''
    ' UI 관련
    Public bgPen_01 As Pen
    Public bgPen_02 As Pen
    Public ReadOnly m6Font As New Font("m6x11", 20)
    Public ReadOnly dosFont As New Font("DOSIyagiBoldface", 20)
    Public MAX_ALPHA As Short = 255
    Public GRAY_DEEP As Color = Color.FromArgb(MAX_ALPHA, 66, 71, 75)
    Public GRAY As Color = Color.FromArgb(MAX_ALPHA, 79, 81, 91)
    Public GRAY_LIGHT As Color = Color.FromArgb(MAX_ALPHA, 107, 121, 141)
    Public fixedGRAY As Color = Color.FromArgb(80, GRAY_DEEP.R, GRAY_DEEP.G, GRAY_DEEP.B)
    Public fixedDGRAY As Color = Color.FromArgb(160, GRAY_DEEP.R, GRAY_DEEP.G, GRAY_DEEP.B)
    Public bgBrush_01 As Brush
    Public scoreBrush_01 As Brush
    Public bgColor As Color = Color.FromArgb(MAX_ALPHA, 251, 251, 251)
    ''''''''''''''''''''''''''''
    ' 기타 값
    Public ReadOnly maxEnemyCnt As Integer = 100
    Public ReadOnly maxScoreCnt As Integer = 50

    Public Sub SysMduleInit()
        bgPen_01 = New Pen(Brushes.Black) With {
            .Width = 2
        }
        bgPen_02 = New Pen(Brushes.DarkGray) With {
            .Width = 2
        }
        bgBrush_01 = New SolidBrush(bgColor)

    End Sub


End Module
