Imports Microsoft.Win32
Public Class SampleRegistry

    Private Sub SampleRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   
    End Sub
    Public Sub SetProxy()
        On Error Resume Next
        Dim regkey1 As RegistryKey
        regkey1 = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", RegistryKeyPermissionCheck.Default)
        regkey1.SetValue("ProxyServer", "ftp=10.10.80.11:3128;http=10.10.80.11:3128;https=10.10.80.11:3128;socks=10.10.80.11:3128", RegistryValueKind.Unknown)
        regkey1.SetValue("ProxyEnable", True, RegistryValueKind.DWord)
        regkey1.Close()

        Label1.Text = "Connected to Pondicherry Proxy Server"
        Label1.ForeColor = Color.Green

   


    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next


        SetProxy()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Dim regKey As RegistryKey
        regKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", RegistryKeyPermissionCheck.Default)
        regKey.SetValue("ProxyEnable", False, RegistryValueKind.DWord)
        regKey.Close()

        Label1.Text = "Disconnected from Pondicherry Proxy Server"
        Label1.ForeColor = Color.Red
    End Sub
End Class