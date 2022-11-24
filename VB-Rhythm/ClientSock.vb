Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class ClientSock
    Inherits TcpClient

    Const b_size As Integer = 1024
    Private buffer(b_size) As Byte
    Private userName As String
    Private sendWriter As StreamWriter
    Private encoderKor As Encoding

    Public Sub New()

    End Sub

    Public Sub Del()
        If Me.Active = True Then '연결되었을시
            Me.Dispose(True) '소켓을 삭제한다. 자기자신
        End If
    End Sub

    Public Event ReceiveProc(sender As ClientSock, data As String)

    Public Function ConnectServer(ip_n As String, port_n As Integer) As Boolean '서버 접속
        Try
            Me.Connect(ip_n, port_n) '서버에 접속한다
        Catch ex As Exception '예외 발생시
            Return False '거짓을 반환
        End Try
        Return True '연결 완료시 참을 반환
    End Function

    Public Sub Initiate()
        Me.encoderKor = Encoding.GetEncoding(949) '한글로 인코딩하게 준비시킨다.
        Me.sendWriter = New StreamWriter(Me.GetStream, Me.encoderKor)
        Me.GetStream.BeginRead(buffer, 0, b_size, AddressOf ReceiveData, Nothing)
    End Sub

    Public Sub SendData(data As String)
        Try
            sendWriter.Write(data & vbCr)
            sendWriter.Flush()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ReceiveData(iar As IAsyncResult)
        Dim data_size As Integer
        Dim data As String

        Try
            SyncLock Me.GetStream
                data_size = Me.GetStream.EndRead(iar)
            End SyncLock

            data = encoderKor.GetString(buffer, 0, data_size - 1)

            RaiseEvent ReceiveProc(Me, data)

            SyncLock Me.GetStream
                Me.GetStream.BeginRead(buffer, 0, b_size, AddressOf ReceiveData, Nothing)
            End SyncLock
        Catch ex As Exception

        End Try
    End Sub

End Class
