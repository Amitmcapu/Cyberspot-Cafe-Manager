Imports System.Data.SqlClient
Imports System.IO



Public Class RatePlan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=OFFICIAL-PC\OFFICIAL;Initial Catalog=Official;Integrated Security=true")

        Dim cmd As New System.Data.SqlClient.SqlCommand
        cmd.CommandType = System.Data.CommandType.Text
        cmd.CommandText = "INSERT into tblRate (Duration,Rate)Values('" & cmbDuration.SelectedItem & "', '" & txtRate.Text & "')"
        cmd.Connection = sqlConnection1

        sqlConnection1.Open()
        cmd.ExecuteNonQuery()
        sqlConnection1.Close()

        MsgBox("Record updated Succesfully")
        RatePlan_Load(e, e)



    End Sub





    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
   
    End Sub

    Private Sub RatePlan_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim connectionString As String = "Data Source=OFFICIAL-PC\OFFICIAL;Initial Catalog=Official;Integrated Security=true"
        Dim sql As String = "Select * from tblRate"
        Dim connection As New SqlConnection(connectionString)
        Dim dataAdapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet
        connection.Open()
        dataAdapter.Fill(ds, "TblRate")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblRate"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Try
            con.ConnectionString = "Data Source=OFFICIAL-PC\OFFICIAL;Initial Catalog=Official;Integrated Security=true"
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Delete From tblRate where Rate=" & DataGridView1.SelectedRows(0).Cells(1).Value


            cmd.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")

                Exit Sub

            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")

        Finally
            RatePlan_Load(e, e)
            con.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

  
End Class