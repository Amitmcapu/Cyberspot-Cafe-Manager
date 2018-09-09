Imports Microsoft.Win32
Imports System.Data.SqlClient
Imports System.IO

Public Class ClientHome

    Dim cn As New SqlConnection("Data Source=(Local);Initial Catalog=master;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet

    Dim dt As New DataTable
    Dim i As Integer
    Dim a As New OpenFileDialog




    Dim btntime As String = ""
    '??????????????????????????????
    Dim str As String = System.Net.Dns.GetHostName()
    Dim duration As Date
    'FOR CHANGING THE PORTS OF CLIENT COMPUTER
    Public Sub SetProxy()
        On Error Resume Next
        Dim regkey1 As RegistryKey
        regkey1 = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", RegistryKeyPermissionCheck.Default)
        regkey1.SetValue("ProxyServer", "ftp=10.10.80.11:3128;http=10.10.80.11:3128;https=10.10.80.11:3128;socks=10.10.80.11:3128", RegistryValueKind.Unknown)
        regkey1.SetValue("ProxyEnable", True, RegistryValueKind.DWord)
        regkey1.Close()

        Label10.Text = "Connected to Pondicherry Proxy Server"
        Label10.ForeColor = Color.Green


    End Sub
    'FOR DISTURBING THE PORTS
    Public Sub NoSetProxy()
        On Error Resume Next
        Dim regkey1 As RegistryKey
        regkey1 = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", RegistryKeyPermissionCheck.Default)
        regkey1.SetValue("ProxyServer", "ftp=10.10.80.11:8080;http=10.10.80.11:8080;https=10.10.80.11:8080;socks=10.10.80.11:8080", RegistryValueKind.Unknown)
        regkey1.SetValue("ProxyEnable", True, RegistryValueKind.DWord)
        regkey1.Close()

        Label10.Text = "Disconnected from Pondicherry Proxy Server"
        Label10.ForeColor = Color.Red

    End Sub


    Sub IP_Show()
        Dim strHostName As String
        Dim strIPAddress As String
        strHostName = System.Net.Dns.GetHostName()
        strIPAddress = System.Net.Dns.GetHostEntry(strHostName).AddressList(0).ToString()
        MessageBox.Show("Host Name : " & strHostName)

    End Sub


    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()

        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                GetIPv4Address = ipheal.ToString()
            End If
        Next

    End Function

    Private Sub ClientHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       

        txtHello.Text = ClientWelcome.User
        txtDuration.Text = MinuteCard.Rate

        TextBox1.Text = MinuteCard.Cost


        txtIP.Text = GetIPv4Address()
        txtPCName.Text = str

        'For Start time
        btntime = My.Computer.Clock.LocalTime.ToString

        btntime = btntime.Substring(btntime.IndexOf(" "))

        'MessageBox.Show(btntime)
        txtStartTime.Text = btntime




    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ts As TimeSpan = duration - DateTime.Now.AddSeconds(-1)
        'txtStart.Text = ts.Minutes.ToString("00") & ":" & ts.Seconds.ToString("00")

        txtStart.Text = ts.Hours.ToString("00") & ":" & ts.Minutes.ToString("00") & ":" & ts.Seconds.ToString("00")


        If txtStart.Text = "00:00:00" Then
            Timer1.Stop()
            MsgBox("Your time is up !")
          
            Button3.PerformClick()

            'OOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO()
            NoSetProxy()

           
            'For Start time
            btntime = My.Computer.Clock.LocalTime.ToString

            btntime = btntime.Substring(btntime.IndexOf(" "))

            'MessageBox.Show(btntime)
            txtEndTime.Text = btntime

            'PBBroadcast1.Enabled = False
            'BroadcastMessage.Enabled = False
            'PictureBox61.Enabled = False
            'PBGame1.Enabled = False




        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        duration = DateTime.Now.AddMinutes(2)
        Timer1.Start()

    End Sub



    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PBWWW_Click(sender As Object, e As EventArgs) Handles PBsurf1.Click
      


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PBBroadcast1.Click


    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        On Error Resume Next


        SetProxy()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        NoSetProxy()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        ClientWelcome.Show()

        Me.Close()

    End Sub



    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox61.Click



    End Sub


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PBBroadcast1.Enabled = True
        BroadcastMessage.Enabled = True
        PictureBox61.Enabled = True
        PBGame1.Enabled = True




        duration = DateTime.Now.AddMinutes(txtDuration.Text.ToString)

        PBBroadcast1.Enabled = True
        BroadcastMessage.Enabled = True
        PictureBox61.Enabled = True
        PBGame1.Enabled = True
        PictureBox2.Enabled = True

        Timer1.Start()
        Button1.Visible = False




    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Timer3.Start()
    End Sub

    Sub Time_Check()
        btntime = My.Computer.Clock.LocalTime.ToString

        btntime = btntime.Substring(btntime.IndexOf(" "))

        MessageBox.Show(btntime)
    End Sub




    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label9.Text = Now.Hour
        Label11.Text = Now.Minute
        Label12.Text = Now.Second
        Dim a As String = (Val(Label9.Text) / 3600000 Mod 24).ToString("n0") + " Hours, "
        Dim b As String = (Val(Label11.Text) / 120000 Mod 60).ToString("n0") + " Minutes, "
        Dim c As String = (Val(Label12.Text) / 1000 Mod 60).ToString("n0") + " Seconds, "
        Label13.Text = a + b + c
    End Sub

    Private Sub PBGame_Click(sender As Object, e As EventArgs) Handles PBGame1.Click
        Process.Start("C:\Buziol Games\Mario Forever\Info MF.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        cn.Open()
        Using cmd As New SqlClient.SqlCommand("Insert into tblclientData(Name,ClientIP,PCName,StartTime,EndTime,DurationAllowed,Cost ) Values('" & txtHello.Text & "','" & txtIP.Text & "','" & txtPCName.Text & "','" & txtStartTime.Text & "','" & txtEndTime.Text & "','" & txtDuration.Text & "','" & TextBox1.Text & "')", cn)
            ' cmd.Parameters.Add(New SqlClient.SqlParameter("@PersonPic", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
            i = cmd.ExecuteNonQuery


        End Using
        If (i > 0) Then


            MsgBox("Record Saved Successfully")

            'clear()


        End If

        cn.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PBsurf.Click
        If txtStart.Text = "" Then

        Else

            Dim webAddress As String = "http://www.example.com/"
            Process.Start(webAddress)
        End If

      
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles PBGame.Click
        If txtStart.Text = "" Then

        Else


            Process.Start("C:\Buziol Games\Mario Forever\Info MF.exe")
        End If


    End Sub

    Private Sub PBBroadcast_Click(sender As Object, e As EventArgs) Handles PBBroadcast.Click
        If txtStart.Text = "" Then

        Else

            BroadcastMessage.Show()
        End If
    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If txtStart.Text = "" Then

        Else
              WebsiteBlocker.Show()
        End If



    End Sub
End Class