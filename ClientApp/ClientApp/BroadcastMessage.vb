Imports System.Net
Imports System.IO
Imports System.Net.Sockets



Public Class BroadcastMessage
    Dim client As TcpClient
    Dim Swriter As StreamWriter
    Dim NickFreFix As Integer = New Random().Next(1111, 9999)


    Sub XLoad() Handles Me.Load
        Me.Text &= " " & NickFreFix
    End Sub


    Delegate Sub _Xupdate(ByVal Str As String)
    Sub xUpdate(ByVal Str As String)

        If InvokeRequired Then
            Invoke(New _Xupdate(AddressOf xUpdate), Str)
        Else
            'TextBox3.AppendText(Str & vbNewLine)
            ' TextBox5.Text = Str
            TextBox5.AppendText(Str & vbNewLine)
        End If
    End Sub

    Sub read(ByVal ar As IAsyncResult)
        Try
            xUpdate(New StreamReader(client.GetStream).ReadLine)
            client.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf read, Nothing)

        Catch ex As Exception
            ' xUpdate("You Have Been Disconnected From Server")
            Exit Sub
        End Try

    End Sub

    Private Sub send(ByVal str As String)

        Try
            Swriter = New StreamWriter(client.GetStream)
            Swriter.WriteLine(str)
            Swriter.Flush()
        Catch ex As Exception
            xUpdate("You are not server")
        End Try

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        Me.btnConnect.PerformClick()
        MsgBox("New Notification !")
        Me.Show()

        If TextBox5.Text.Contains("amit") Then
            MsgBox("Command Found")
        End If




        Me.btnConnect.PerformClick()

    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            Try
                client = New TcpClient(TextBox1.Text, CInt(TextBox2.Text))
                client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                btnConnect.Text = "Disconnect"
                TextBox6.BackColor = Color.Green

            Catch ex As Exception
                '
                'xUpdate("Can't connect to the server !")
                TextBox6.BackColor = Color.Red




            End Try
        Else
            client.Client.Close()
            client = Nothing
            btnConnect.Text = "Connect"

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


End Class
