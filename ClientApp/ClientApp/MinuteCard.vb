Imports System.Net
Imports System.IO
Imports System.Net.Sockets


Public Class MinuteCard
    Public Cost, Rate As String


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
            'xUpdate("You are not server")
        End Try

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.Refresh()


        Me.btnConnect.PerformClick()


        ' MsgBox("Recieving Permission !")
        MessageBox.Show("RECIEVING DATA", "SERVER ALERT !", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If TextBox5.Text.Contains("allow") Then

            MsgBox("Permission Granted")

            TextBox5.Clear()
            ClientHome.Show()
        ElseIf TextBox5.Text.Contains("game") Then
            Process.Start("C:\Buziol Games\Mario Forever\Info MF.exe")

        ElseIf TextBox5.Text.Contains("off") Then
            ClientHome.NoSetProxy()

        Else
            TextBox5.Clear()

        End If




        Me.btnConnect.PerformClick()

    End Sub


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TBRate.Text = "40"
            TextBox3.Text = "30"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            TBRate.Text = "60"
            TextBox3.Text = "50"

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        TBRate.Text = "120"
        TextBox3.Text = "70"
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Cost = TextBox3.Text
        Rate = TBRate.Text

        If TBRate.Text = "" Then
            'MsgBox("Please Choose Any Plan !! ")
            MessageBox.Show("PLEASE CHOOSE ANY PLAN", "ERROR ALERT !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If btnConnect.Text = "Connect" Then
                Try
                    client = New TcpClient(TextBox1.Text, CInt(TextBox2.Text))
                    client.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf read), Nothing)
                    btnConnect.Text = "Disconnect"
                    txtconnect.BackColor = Color.Green
                    txtConnect2.BackColor = Color.Green
                Catch ex As Exception
                    '
                    'xUpdate("Can't connect to the server !")
                    txtconnect.BackColor = Color.Red
                    Label5.Visible = True

                    txtConnect2.BackColor = Color.Red
                End Try
            Else
                client.Client.Close()
                client = Nothing
                btnConnect.Text = "Connect"
                txtconnect.BackColor = Color.Yellow
                txtConnect2.BackColor = Color.Yellow
            End If
        End If

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TBRate.Text = "20"
            TextBox3.Text = "10"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TBRate.Text = "1"
            TextBox3.Text = "5"
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            TBRate.Text = "720"
            TextBox3.Text = "200"
        End If
    End Sub

  
    Private Sub XLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Users\OFFICIAL\Pictures\sing.wav")
    End Sub
End Class