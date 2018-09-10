Imports System.Net.Sockets
Imports System.IO




Public Class ClassForClient

    Public Event getMessage(ByVal str As String)
    Public Event clientLogout(ByVal client As ClassForClient)

    Private SendMessage As StreamWriter
    Private Listclient As TcpClient

    Sub New(ByVal forClient As TcpClient)
        Listclient = forClient
        Listclient.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf ReadAllClient, Nothing)



    End Sub

    Private Sub ReadAllClient()
        Try
            RaiseEvent getMessage(New StreamReader(Listclient.GetStream).ReadLine)
            Listclient.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf ReadAllClient), Nothing)

        Catch ex As Exception
            RaiseEvent clientLogout(Me)

        End Try
    End Sub

    Public Sub Send(ByRef Message As String)
        SendMessage = New StreamWriter(Listclient.GetStream)
        SendMessage.WriteLine(Message)
        SendMessage.Flush()




    End Sub

End Class
