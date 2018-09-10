Imports System.Data.SqlClient


Public Class SqlControl
    Dim Sqlcon As New SqlConnection("Data Source=192.168.43.50,1433\SQLEXPRESS; Initial Catalog=Official; User ID=sa; Password=Official#123 ")
    Private sqlCmd As New SqlCommand
    Public SQLDA As New SqlDataAdapter
    Public SQLDS As New DataSet


    Public Function hasConnection() As Boolean
        Try
            SqlCon.Open()

            SqlCon.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        Return False

    End Function

    Public Sub RunQuery(Query As String)
        Try
            SqlCon.Open()
            'Create Command

            sqlCmd = New SqlCommand(Query, SqlCon)

            'Fill Dataset

            SQLDA = New SqlDataAdapter(sqlCmd)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            SqlCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            'Make sure that the connection is closed
            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()

            End If
        End Try
    End Sub



End Class
