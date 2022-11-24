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
        Dim tmpJarry As JArray = JArray.Parse(data)
        Dim uList As New ArrayList
        For i = 0 To tmpJarry.Count - 1
            Dim u As New User
            Dim tmpJson As JObject = tmpJarry(i)
            u.nickname = tmpJson.Item("nickname").ToString
            u.score = tmpJson.Item("score").ToString
            u.hTime = tmpJson.Item("hTime").ToString
            u.mTime = tmpJson.Item("mTime").ToString
            u.sTime = tmpJson.Item("sTime").ToString
            uList.Add(u)
        Next
        gameManager.rankList = uList
        MsgBox(tmpJarry.ToString)
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
            MsgBox("서버에 정상적으로 연결되었습니다.")
        End If
        If gameManager.gameSnds.IsPlaying("start") Then
            gameManager.gameSnds.Stop("start")
        End If
        gameManager.gameSnds.Play("loby")


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
                gameManager.gameSnds.Play("start")
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
                    Close()
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        gameManager = GameManager.getInstance
        If Not gameManager.serverSendFlag = True Then
            If Not gameManager.rank = "" Then
                client.SendData(CInt(Header.Data).ToString & gameManager.rank)
                gameManager.serverSendFlag = True

            End If
        End If

    End Sub
End Class