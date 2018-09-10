Imports System.IO
Imports System.Net
Imports System
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports Microsoft.Win32


Public Class clientconnnected

    Public Class Form1


    End Class
    Private Sub clientconnnected_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Function InternetProxyEnabled() As Boolean
        ' See if Internet Explorer uses a proxy.
        Dim key As RegistryKey = _
            Registry.CurrentUser.OpenSubKey( _
            "Software\\Microsoft\\Windows\\CurrentVersion\\Internet " & _
                "Settings")
        Dim keys() As String = key.GetValueNames()
        Dim result As Boolean = _
            (CInt(key.GetValue("ProxyEnable", 0)) <> 0)
        key.Close()

        Return result
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InternetProxyEnabled() = True Then
            MsgBox("Proxy Checked")
        End If
    End Sub

End Class