Imports System.Data.SqlClient
Imports System



Public Class SqlControl

    Public Shared MYCONString As String = "Data Source=(Local); Initial Catalog=master; Integrated Security=SSPI; User Id=sa;Password=Official#123;"
    Dim Sqlcon As New SqlConnection("Data Source=(Local); Initial Catalog=master; Integrated Security=SSPI; User Id=sa; Password=Official#123")

    Private SqlCmd As New SqlCommand
    Public SQLDA As New SqlDataAdapter
    Public SQLDS As New DataSet

    Public Function hasConnection() As Boolean
        Try
            Sqlcon.Open()
            Sqlcon.Close()

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False

    End Function

    Public Sub RunQuery(Query As String)
        Try
            Sqlcon.Open()
            'Create Command
            SqlCmd = New SqlCommand(Query, Sqlcon)

            'Fill dataset

            SQLDA = New SqlDataAdapter(Query, Sqlcon)
            SQLDS = New DataSet
            SQLDA.Fill(SQLDS)

            Sqlcon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

            'Make Sure Connection is closed
            If Sqlcon.State = ConnectionState.Open Then
                Sqlcon.Close()

            End If
        End Try
    End Sub

End Class
