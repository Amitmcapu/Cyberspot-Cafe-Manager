Imports System.Data.SqlClient


Module ModuleConnection
    Public connection As SqlConnection


    Sub OpenConnection()

        Try
            connection = New SqlConnection("Data Source= 192.168.43.50,1433\SQLEXPRESS; Initial Catalog=Official; Integrated Security=true; User Id=sa; Password=Official#123")
            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If
        Catch ex As Exception
            MsgBox("Failed to connect, Error at " & ex.ToString)
        End Try


    End Sub
End Module
