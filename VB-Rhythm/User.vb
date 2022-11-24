Public Class User
    Implements IComparable(Of User)

    Public nickname As String = ""
    Public score As Integer = 0
    Public hTime As Integer = 0
    Public mTime As Integer = 0
    Public sTime As Integer = 0

    Public Function CompareTo(other As User) As Integer Implements IComparable(Of User).CompareTo
        If score = other.score Then
            Return 0
        Else
            If score < other.score Then
                Return -1
            Else
                Return 1
            End If
        End If
    End Function
End Class
