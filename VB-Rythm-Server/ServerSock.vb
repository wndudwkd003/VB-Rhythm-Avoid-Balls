Imports System.Net.Sockets '소켓 라이브러리
Imports System.IO '동기 및 비동기 읽기/쓰기를 가능하게 하는 형식들을 포함하는 라이브러리
Imports System.Text '수신된 데이터를 인코딩하기 위한 텍스트 라이브러리


Public Class ServerSock
    Private clientSock As TcpClient
    Private Buffer(b_size) As Byte
    Const b_size As Integer = 1024
    Private connName As String '연결된 사용자 이름
    Private sendWriter As StreamWriter '데이터 송신 스트림
    Private encoderKor As Encoding '한글 인코더

    Public Sub New(client As TcpClient) 'ServerSock을 생성하면 이루어지는 작업
        Me.clientSock = client '접속한 클라이언트 소켓을 현재 소켓에 저장한다
        Me.encoderKor = Encoding.GetEncoding(949) '한글로 인코딩한다
        Me.sendWriter = New StreamWriter(clientSock.GetStream, Me.encoderKor) '데이터 전송시 한글을 인코딩하여 전송하기 위한 설정
        Me.clientSock.GetStream.BeginRead(Buffer, 0, b_size, AddressOf ReceiveData, Nothing) '비동기 읽기를 준비한다. 버퍼만큼의 데이터를 받아내고 읽기가 끝나면 ReceiveData라는 프로시저에 따라 처리한다.
    End Sub

    Public Sub ReceiveData(iar As IAsyncResult) '수신 데이터 처리
        Dim data_size As Integer ' 수신된 데이터의 크기
        Dim data As String ' 수신된 데이터
        Try
            SyncLock clientSock.GetStream
                data_size = clientSock.GetStream.EndRead(iar) ' 읽기의 끝부분을 데이터의 크기로 산정한다.
            End SyncLock

            data = encoderKor.GetString(Buffer, 0, data_size - 1) '한국어로 변환 후 맨끝의 변환문자를 삭제
            RaiseEvent ReceiveProc(Me, data) '이벤트를 발생시켜 메인폼에서 데이터가 처리되게 한다.

            SyncLock clientSock.GetStream '여러개의 실행 스레드가 동시에 같은 문장을 실행하는 것을 방지한다.
                clientSock.GetStream.BeginRead(Buffer, 0, b_size, AddressOf ReceiveData, Nothing)
            End SyncLock

        Catch ex As Exception

        End Try
    End Sub

    Public Sub SendData(data As String) '데이터 송신 처리
        SyncLock clientSock.GetStream
            sendWriter.Write(data & vbNewLine) '송신 스트림에 데이터를 기록한다.
            sendWriter.Flush() '버퍼의 내용을 지우면서 데이터를 내부 스트림에 기록한다.
        End SyncLock
    End Sub

    Public Property Name() As String '접속한 클라이언트의 이름을 설정하거나 반환해주는 Getter 겸 Setter
        Get
            Return connName
        End Get
        Set(value As String)
            connName = value
        End Set
    End Property

    Public Event ReceiveProc(sender As ServerSock, data As String)

End Class
