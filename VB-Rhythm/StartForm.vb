Imports System.Formats.Asn1
Imports Microsoft.VisualBasic.Devices

Imports Newtonsoft.Json.Linq

Public Class StartForm

    Private client As ClientSock
    Private userName As String
    Private servAddr As String
    Const port_n As Integer = 8080
    Public IsConn As Boolean = False

    Public Enum Header
        Connect = 0
        Disconn = 1
        Data = 2
    End Enum

    Private Sub Output(msg As String)
        MsgBox(msg)
    End Sub

    Private Function ServerConnect() As Boolean
        Try
            client = New ClientSock()

            If client.ConnectServer(servAddr, port_n) Then
                client.Initiate()
                AddHandler client.ReceiveProc, AddressOf Receiving
                Threading.Thread.Sleep(500)
                Dim data As String
                Dim h_type As Integer = Header.Connect
                data = h_type.ToString & userName
                client.SendData(data)
            Else
                MsgBox("서버와의 연결에 실패하였습니다", vbOKOnly, "에러")
                client.Del()
                Return False
            End If
        Catch
        End Try
        IsConn = True
        Return True
    End Function

    Private Sub Disconnect()
        If IsConn = True Then
            Dim h_type As Integer = Header.Disconn
            client.SendData(h_type.ToString)
            IsConn = False

            client.Close()
            client.Del()
        End If
    End Sub

    Private Sub Receiving(sender As ClientSock, data As String)
        Dim h_type As Integer
        h_type = CInt(data.Substring(0, 1))
        data = data.Substring(1)

        Select Case h_type
            Case 0
                Output("(System) 서버 (" & servAddr & ") 에 접속되었습니다.")
            Case 1
                Output("(System) 서버와의 연결이 종료되었습니다.")
                MsgBox("dis")
            Case 2
                Output(data)
        End Select
    End Sub








    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If IsConn = True Then
            Dim h_type As Integer = Header.Disconn
            client.SendData(h_type.ToString)

            client.Close()
            client.Del()
        End If
    End Sub






    Private gameManager As GameManager = GameManager.getInstance
    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysMduleInit()
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)



        servAddr = "127.0.0.1"
        userName = "asd"

        If ServerConnect() = True Then
            MsgBox("server on")
        End If
        Dim h_type As Integer = Header.Data
        Dim data As String
        data = h_type.ToString & "asd"
        client.SendData(data)








        'If gameManager.gameSnds.IsPlaying("start") Then
        '    gameManager.gameSnds.Stop("start")
        'End If

        'gameManager.gameSnds.Play("loby")

        With StartButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With RankButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With LearnButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With
        With ExitButton
            .Font = m6Font
            .Padding = New Padding(0, 3, 0, 0)
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.BorderColor = Color.Gray
            .FlatAppearance.MouseDownBackColor = fixedDGRAY
            .FlatAppearance.MouseOverBackColor = fixedGRAY
            .BackColor = Color.Transparent
            .Focus()
        End With


    End Sub

    Private Sub StartForm_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawEllipse(bgPen_01, 200, 53, midCircleSize.Width, midCircleSize.Height)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles StartButton.Click, RankButton.Click, LearnButton.Click, ExitButton.Click
        Dim btn As Button = DirectCast(sender, Button)

        gameManager.gameSnds.Play("click")

        Select Case btn.Name
            Case "StartButton"
                gameManager.gameSnds.Stop("loby")
                Dim formPlay As New MainForm
                formPlay.Show()
                Hide()

            Case "RankButton"
                Dim formPlay As New Rank
                formPlay.Show()
                Hide()

            Case "LearnButton"
                Dim formPlay As New LearnForm
                formPlay.Show()
                Hide()

            Case "ExitButton"
                Dim result As DialogResult = MessageBox.Show("정말로 종료하시겠습니까?", "Game Exit", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Disconnect()
                    MsgBox("dis")
                    Close()
                End If
        End Select
    End Sub



End Class