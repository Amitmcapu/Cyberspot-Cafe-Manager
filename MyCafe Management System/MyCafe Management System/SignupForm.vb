Imports System.Data.SqlClient


Public Class SignupForm

    Private Sub signUp(ByVal sql As String)

        Dim cmd As New SqlCommand
        OpenConnection()
        Try
            cmd.Connection = connection
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql

            cmd.ExecuteNonQuery()
            cmd.Dispose()
            connection.Close()

        Catch ex As Exception
            MsgBox("Failed" & ex.ToString)


        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim TypeUser As String
        Dim level As Integer

        TypeUser = ComboBox1.Text
        If TypeUser = "Administrator" Then
            level = 1
        ElseIf TypeUser = "Staff" Then
            level = 2
        ElseIf TypeUser = "Guest" Then
            level = 3

        End If
        Dim sql As String = "insert into tblMembers(Username,password,level)values('" & txtUser.Text & "',Convert(nvarchar(32),Hashbytes('MD5','" & txtPass.Text & "'),2)," & level & ")"
        signUp(sql)
        MsgBox("Sign Up Success")


    End Sub

    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "Administrator"

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class