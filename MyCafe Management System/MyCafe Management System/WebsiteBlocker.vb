Imports System.Data.SqlClient
Imports System.IO

Public Class WebsiteBlocker

    Dim path As String
    Dim sw As StreamWriter

    Private Sub DataGridView1_DataBindingComplete(ByVal sender As System.Object, _
    ByVal e As System.Windows.Forms.DataGridViewBindingCompleteEventArgs) _
    Handles DataGridView1.DataBindingComplete

        Dim gridView As DataGridView
        gridView = CType(sender, DataGridView)
        gridView.ClearSelection()
    End Sub


    Private Sub WebsiteBlocker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = Nothing


        Dim connectionString As String = "Data source=(Local);Initial Catalog=master;User Id=sa;Password=Official#123;Integrated Security=true"

        Dim sql As String = "Select * from tblWebsite"
        Dim connection As New SqlConnection(connectionString)
        Dim dataAdapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet
        connection.Open()
        dataAdapter.Fill(ds, "tblWebsite")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "tblWebsite"
    End Sub

    Sub Add_Website()
        path = "C:\Windows\System32\drivers\etc\hosts"
        sw = New StreamWriter(path, True)

        Dim siteToBlock As String = (Environment.NewLine & "127.0.0.1 " & txtSite.Text)
        sw.Write(siteToBlock)
        sw.Close()
    End Sub

    Sub Blank_Check()
        If txtSite.Text = "" Or txtSite.Text = "" Then
            MessageBox.Show("No Website Entered !", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Blank_Check()


        If txtSite.Text <> "" Then

            For Each Row As DataGridViewRow In DataGridView1.Rows
                Dim x As Integer
                For x = 0 To DataGridView1.RowCount

                    If txtSite.Text = Row.Cells(1).Value Then


                        MessageBox.Show("Website already exists", "Error Reporting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                        If MsgBoxResult.Yes Then

                            Return

                        End If

                    Else

                    End If
                Next
            Next


            Add_Website()

            Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection("Data Source=(Local);Initial Catalog=master;Integrated Security=SSPI")

            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT into tblWebsite(SiteName)Values( '" & txtSite.Text & "')"
            cmd.Connection = sqlConnection1

            sqlConnection1.Open()
            cmd.ExecuteNonQuery()
            sqlConnection1.Close()

            WebsiteBlocker_Load(e, e)
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.SelectedCells.Count = Nothing Then
            MessageBox.Show("No item selected !", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else

            Dim lines As New List(Of String)
            Using sr As New StreamReader("C:\Windows\System32\drivers\etc\hosts")
                While Not sr.EndOfStream
                    lines.Add(sr.ReadLine)
                End While
            End Using

            For Each line As String In lines
                If line.Contains(lblDisplay.Text) Then

                    lines.Remove(line)
                    Exit For 'must exit as we changed the iteration 
                End If
            Next

            Using sw As New StreamWriter("C:\Windows\System32\drivers\etc\hosts")
                For Each line As String In lines
                    sw.WriteLine(line)
                Next
            End Using

            Dim con As New SqlConnection
            Dim cmd As New SqlCommand
            Try
                con.ConnectionString = "Data Source=(Local);Initial Catalog=master;Integrated Security=SSPI"
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "Delete From tblwebsite where ID=" & DataGridView1.SelectedRows(0).Cells(0).Value


                If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    cmd.ExecuteNonQuery()

                End If

                 Catch ex As Exception
                'MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")

            Finally
                WebsiteBlocker_Load(e, e)
                con.Close()
            End Try

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then

            txtSite.Enabled = True
            Button1.Enabled = True

        ElseIf CheckBox1.Checked = False Then
            txtSite.Enabled = False
            Button1.Enabled = False

        End If
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            lblDisplay.Text = ""

            lblDisplay.Text = DataGridView1.SelectedRows(0).Cells(1).Value
        Catch ex As Exception
            MessageBox.Show("Invalid Selection", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded

    End Sub


    Sub Checker()


    End Sub




End Class