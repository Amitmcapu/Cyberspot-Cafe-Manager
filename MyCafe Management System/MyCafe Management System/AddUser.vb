Imports System.IO
Imports System.Data.SqlClient


Public Class AddUser
   Dim cn As New SqlConnection("Data Source=192.168.43.50,1433\SQLEXPRESS; Initial Catalog=Official; User ID=sa; Password=Official#123 ")
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Gender As String

    Dim dt As New DataTable
    Dim i As Integer
    Dim a As New OpenFileDialog


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button3.Click

        'DataGridView1.Visible = True

        If String.IsNullOrEmpty(TxtName.Text) Then

            'My.Computer.Audio.Play("C:\Users\OFFICIAL\Pictures\RegID.wav")
            MsgBox("Please fill Name")

        ElseIf String.IsNullOrEmpty(TxtContact.Text) Then

            MsgBox("Please Enter Contact")

        ElseIf String.IsNullOrEmpty(LstAddress.Text) Then

            MsgBox("Please Enter Address")

        ElseIf String.IsNullOrEmpty(TxtIdCardNo.Text) Then

            MsgBox("Please Enter ID Card Number")

        ElseIf CMBidType.SelectedItem Is Nothing Then
            MsgBox("Please choose ID card Type")

     

        ElseIf PictureBox1.Image Is Nothing Then
            MsgBox("Please upload an image")
        Else

            cn.Open()
            Using cmd As New SqlClient.SqlCommand("Insert into tblAddUser(Name,UserID,Contact,Gender,Age,DateJoined,ID_CardType,IDNumber,AddressOf,PersonPic) Values('" & TxtName.Text & "','" & TxtUserId.Text & "','" & TxtContact.Text & "','" & Gender & "','" & txtAge.Text & "','" & txtdates.Text & "','" & CMBidType.SelectedItem & "','" & TxtIdCardNo.Text & "','" & LstAddress.Text & "', @PersonPic)", cn)
                cmd.Parameters.Add(New SqlClient.SqlParameter("@PersonPic", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
                i = cmd.ExecuteNonQuery


            End Using
            If (i > 0) Then

                'My.Computer.Audio.Play("C:\Users\OFFICIAL\Pictures\Saved.wav")
                MsgBox("Record Saved Successfully")


                ClearData()


            End If

            cn.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim picl As String
        a.Filter = Nothing
        picl = a.FileName
        a.ShowDialog()
        PictureBox1.Image = Image.FromFile(a.FileName)

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Gender = "Male"
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Gender = "Female"
        End If
    End Sub

    Sub ClearData()
        TextBox1.Clear()
        txtAge.Clear()
        TxtContact.Clear()
        txtdates.ResetText()
        TxtIdCardNo.Clear()
        TxtName.Clear()
        TxtUserId.Clear()
        CMBidType.Text = ""
        PictureBox1.Image = Nothing
        LstAddress.Text = Nothing




    End Sub








    Sub showrecord()

        cn.Open()

        With cmd
            .Connection = cn
            .CommandText = "Select * from tblAddUser"
        End With
        da.SelectCommand = cmd
        dt.clear()
        da.Fill(dt)
        DataGridView1.RowTemplate.Height = 150
        DataGridView1.DataSource = dt

        For i As Integer = 0 To DataGridView1.Columns.Count - 1
            If TypeOf DataGridView1.Columns(i) Is DataGridViewImageColumn Then
                DirectCast(DataGridView1.Columns(i), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Stretch
            End If
        Next
        cn.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showrecord()

    End Sub

    Private Sub btnSee_Click(sender As Object, e As EventArgs) Handles btnSee.Click
        TextBox1.Text = txtdates.Text

    End Sub
End Class