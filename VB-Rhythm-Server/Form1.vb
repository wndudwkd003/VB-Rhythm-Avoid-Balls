Imports System.Net.Sockets '소켓 라이브러리
Imports System.Threading

Imports Newtonsoft.Json.Linq


Public Class Form1
    Public Structure Rank
        Dim nickname As String
        Dim score As Integer
        Dim hTime As Integer
        Dim mTime As Integer
        Dim sTime As Integer
    End Structure

    Dim jsonList As New JArray
    Dim rankList As New ArrayList
    Private tcplisten As TcpListener '연결을 확인하는 클라이언트
    Private listenthread As Thread '연결을 대기하는 스레드
    Const port_n As Integer = 8080 '서버가 연결을 받을 포트
    Dim clientSockList As New ArrayList
    Dim isConn As Boolean = False

    Private Sub initListen() '연결대기 시작
        listenthread = New Threading.Thread(AddressOf actListen) '스레드를 처리할 프로시저를 지정하면서 스레드 생성
        listenthread.Start() ' 스레드를 시작
    End Sub

    Private Sub actListen() '스레드에 연결작업이 들어왔을시 수행하는 프로시저
        Try
            tcplisten = New TcpListener(port_n) '대기할 소켓을 만든다
            tcplisten.Start() '대기할 소켓을 대기상태로 시작한다
            Do
                Dim clientSock As ServerSock '대기에 사용할 소켓
                clientSock = New ServerSock(tcplisten.AcceptTcpClient) '대기할 소켓에 클라이언트의 소켓이 도착하면 서버소켓을 생성해 도착한 소켓을 저장한다.
                AddHandler clientSock.ReceiveProc, AddressOf Receiving '저장된 소켓에 있는 데이터를 수신하기 위한 프로시저를 지정한다.
                clientSockList.Add(clientSock)
            Loop Until False
        Catch ex As Exception

        End Try
    End Sub

    Public Enum Header '헤더 설정 각번호에 따라 패킷의 종류를 구분한다. 0=연결 1=연결종료 2=데이터
        Connect = 0
        Disconn = 1
        Data = 2
    End Enum

    Private Sub Receiving(sender As ServerSock, data As String) '수신된 데이터를 분해하여 데이터의 유형을 파악해 각각 처리 프로시저로 보낸다.
        Dim h_type As Integer
        h_type = CInt(data.Substring(0, 1)) '헤더를 잘라내어 변수에 저장한다.
        data = data.Substring(1) '헤더를 제외한 나머지 데이터를 변수에 재저장한다.
        Select Case h_type
            Case 0
                Connect(data, sender)
            Case 1
                Disconnect(sender)
            Case 2
                'Output("(" & sender.Name & ") " & data)
                Dim result As String = data
                Dim tmpRank As New Rank
                Dim tmpJson As JObject = JObject.Parse(result)
                tmpRank.nickname = tmpJson.Item("nickname").ToString
                tmpRank.score = tmpJson.Item("score").ToString
                tmpRank.hTime = tmpJson.Item("hTime").ToString
                tmpRank.mTime = tmpJson.Item("mTime").ToString
                tmpRank.sTime = tmpJson.Item("sTime").ToString
                rankList.Add(tmpRank)
                RankListBox.Items.Add(tmpRank.nickname)
                jsonList.Add(tmpJson)

                SendToAllClient(sender, jsonList.ToString)
        End Select
    End Sub

    Private Sub SendToAllClient(sender As ServerSock, data As String)

        Dim h_type As Integer
        h_type = Header.Data

        data = h_type & data
        For Each client As ServerSock In clientSockList
            client.SendData(data)
        Next
    End Sub

    Private Sub Connect(name As String, sender As ServerSock)
        sender.Name = name
        'Output("(System) 클라이언트 (" & name & ") 연결되었습니다.")
        Dim h_type As Integer
        h_type = Header.Connect
        SendtoSender(h_type.ToString, sender)
        isConn = True
    End Sub

    Private Sub SendtoSender(data As String, sender As ServerSock)
        sender.SendData(data)
    End Sub

    Private Sub Disconnect(sender As ServerSock)
        Dim h_type As Integer
        h_type = Header.Disconn
        Try
            SendtoSender(h_type.ToString, sender)
        Catch ex As Exception
        End Try
        clientSockList.Remove(sender)
        isConn = False
    End Sub

    Private Sub Output(msg As String)
        tbChatList.Text = tbChatList.Text & vbNewLine
        tbChatList.AppendText(msg & vbNewLine)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
        initListen()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isConn = True Then
            For Each client As ServerSock In clientSockList
                Disconnect(client)
            Next
        End If
        tcplisten.Stop()
        clientSockList.Clear()
    End Sub

    Private Sub RankListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RankListBox.SelectedIndexChanged
        Dim tmp As Rank = rankList(RankListBox.SelectedIndex)
        Dim json As New JObject
        json.Add("nickname", tmp.nickname)
        json.Add("score", tmp.score)
        json.Add("hTime", tmp.hTime)
        json.Add("mTime", tmp.mTime)
        json.Add("sTime", tmp.sTime)
        ResultText.Text = json.ToString()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each client As ServerSock In clientSockList
            client.SendData(CInt(Header.Data).ToString & jsonList.ToString)
        Next
    End Sub
End Class
