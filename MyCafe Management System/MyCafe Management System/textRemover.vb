Imports System.IO
Imports System.Data.SqlClient
Imports System.Threading

Imports System.Net
Imports System.Management
Imports System.Net.Sockets



Public Class textRemover


    Dim url As String
    Dim count As Integer = 3
    ' Public WithEvents time As Timer = New Timer()


    Private Sub textRemover_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://www.google.com")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        If CheckForInternetConnection() = False Then
            TextBox1.Text = "No Internet"
        Else
            TextBox1.Text = "Yes Internet is available"
        End If
    End Sub

    Private Sub Button1_Enter(sender As Object, e As EventArgs) Handles Button1.Enter
        Shell("NET STOP DHCP")
    End Sub



End Class