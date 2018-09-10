Imports System.Net
Imports System.IO
Imports System.Net.Sockets


Public Class ProjectTCPServer


    Dim listening As TcpListener
    Dim Allclient As TcpClient
    Dim clientLis As New List(Of ClassForClient)
    Dim pReader As StreamReader
    Dim pclient As ClassForClient

    Private Sub ProjectTCPServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listening = New TcpListener(IPAddress.Any, 8080)
        'listening = New TcpListener(192.168.43.50, 1433)
        listening.Start()
        UpdateList("Server Starting", False)
        listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), listening)



    End Sub
    Delegate Sub _cUpdate(ByVal str As String, ByVal relay As String)



    Sub UpdateList(ByVal str As String, ByVal relay As Boolean)
        On Error Resume Next
        If InvokeRequired Then
            Invoke(New _cUpdate(AddressOf UpdateList), str, relay)
        Else

            TextBox1.AppendText(str & vbNewLine)
            If relay Then send(str)
        End If

    End Sub
    Sub AcceptClient(ByVal ar As IAsyncResult)
        pclient = New ClassForClient(listening.EndAcceptTcpClient(ar))
        AddHandler (pclient.getMessage), AddressOf MessageRecieved
        AddHandler (pclient.clientLogout), AddressOf ClientExited
        clientLis.Add(pclient)
        UpdateList("New Client Joined", True)
        listening.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), listening)

    End Sub
    Sub MessageRecieved(ByVal str As String)
        UpdateList(str, True)

    End Sub
    Sub ClientExited(ByVal client As ClassForClient)

        clientLis.Remove(client)
        'UpdateList("CLIENT EXCITED !", True)



    End Sub

    Sub send(ByVal str As String)
        For x As Integer = 0 To clientLis.Count - 1
            Try
                clientLis(x).Send(str)
                clientLis.RemoveAt(x)
                UpdateList("cLIENT eXCITED !", True)
            Catch ex As Exception

            End Try

        Next
    End Sub


    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            UpdateList("::   " & TextBox2.Text, True)
            TextBox2.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateList("::    " & TextBox2.Text, True)
        TextBox2.Clear()


    End Sub
End Class