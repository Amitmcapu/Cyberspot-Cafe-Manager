Imports System.Data.SqlClient


Public Class LoginForm



    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged

        If chkShow.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"


        End If
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        OpenConnection()
        Dim dr As SqlDataReader
        Dim cmd As SqlCommand
        Dim sql As String
        cmd = New SqlCommand
        cmd.CommandType = CommandType.Text
        cmd.Connection = connection
        sql = "Select * from tblmembers where email='" & txtUsername.Text & "' and password=CONVERT(NVARCHAR(32),Hashbytes('MD5','" & txtPassword.Text & "'),2)"
        cmd.CommandText = sql

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            If dr.Item("level") = 1 Then
                MsgBox("Welcome Administrator")
            ElseIf dr.Item("level") = 2 Then
                MsgBox("Welcome User")
            ElseIf dr.Item("level") = 3 Then
                MsgBox("Welcome Guest")
            End If
        Else
            MsgBox("Access Denied")

        End If
        connection.Close()
        cmd.Dispose()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        SignupForm.Show()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class