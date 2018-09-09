Imports System.Data.SqlClient

Public Class ClientWelcome
    Public User As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User = TextBox1.Text


        Try

            ClientHome.Close()

        Catch ex As Exception

        End Try

        Dim con As New SqlClient.SqlConnection(SqlControl.MYCONString)
        con.Open()
        Dim dr As SqlClient.SqlDataReader

        Dim cmd As New SqlClient.SqlCommand("Select * from tblAddUser where Name='" & TextBox1.Text & "' and UserId='" & TextBox2.Text & "'", con)
        Dr = cmd.ExecuteReader


        If dr.Read Then
            MsgBox("You are logged in as " & TextBox1.Text)
            User = TextBox1.Text

            MinuteCard.Show()

            Me.Hide()

        Else
            MsgBox("Invalid User Credentials")


        End If
        con.Close()


        'Me.Hide()

    End Sub

    Private Sub ClientWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class