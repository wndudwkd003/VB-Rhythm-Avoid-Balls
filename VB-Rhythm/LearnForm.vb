Public Class LearnForm
    Private inputKeys As New ArrayList
    Private gameManager As GameManager = GameManager.getInstance

    Private Sub LearnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SysMduleInit()

        With LearnLabel
            .Font = m6Font
        End With

    End Sub

    Private Sub LearnForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub

    Private Sub LearnForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If Not inputKeys.Contains(e.KeyCode) Then
            inputKeys.Add(e.KeyCode)
        End If

        If e.KeyCode = Keys.Escape Then
            With StartForm
                .Show()
            End With
            Close()
        End If
    End Sub

    Private Sub LearnForm_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        inputKeys.Remove(e.KeyCode)
    End Sub
End Class