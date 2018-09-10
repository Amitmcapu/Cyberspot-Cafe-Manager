Public Class Home

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles btnUser.MouseHover
        btnUser.Size = New Size(194, 58)

    End Sub

    Private Sub pbIcon_MouseHover(sender As Object, e As EventArgs)




    End Sub

    Private Sub pbIcon_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUser_MouseLeave(sender As Object, e As EventArgs) Handles btnUser.MouseLeave
        btnUser.Size = New Size(190, 56)

    End Sub

    Private Sub btnTickets_MouseHover(sender As Object, e As EventArgs) Handles btnTickets.MouseHover
        btnTickets.Size = New Size(194, 58)
    End Sub

    Private Sub btnTickets_MouseLeave(sender As Object, e As EventArgs) Handles btnTickets.MouseLeave
        btnTickets.Size = New Size(190, 56)

    End Sub

    Private Sub btnBroadcast_MouseHover(sender As Object, e As EventArgs) Handles btnBroadcast.MouseHover
        btnBroadcast.Size = New Size(194, 58)

    End Sub

    Private Sub btnBroadcast_MouseLeave(sender As Object, e As EventArgs) Handles btnBroadcast.MouseLeave
        btnBroadcast.Size = New Size(190, 56)
    End Sub

    Private Sub btnBroadcast_Click(sender As Object, e As EventArgs) Handles btnBroadcast.Click

    End Sub
    Private Sub BtnFind_MouseLeave(sender As Object, e As EventArgs) Handles BtnFind.MouseLeave
        BtnFind.Size = New Size(190, 56)

    End Sub

    Private Sub BtnFind_MouseHover(sender As Object, e As EventArgs) Handles BtnFind.MouseHover
        BtnFind.Size = New Size(194, 58)
    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click

    End Sub

    Private Sub btnSHUTDOWN_MouseHover(sender As Object, e As EventArgs) Handles btnSHUTDOWN.MouseHover
        btnSHUTDOWN.Size = New Size(194, 58)

    End Sub

    Private Sub btnRECONNECT_MouseHover(sender As Object, e As EventArgs) Handles btnRECONNECT.MouseHover
        btnRECONNECT.Size = New Size(194, 58)

    End Sub

    Private Sub btnSHUTDOWN_MouseLeave(sender As Object, e As EventArgs) Handles btnSHUTDOWN.MouseLeave
        btnSHUTDOWN.Size = New Size(190, 56)


    End Sub

    Private Sub btnRECONNECT_MouseLeave(sender As Object, e As EventArgs) Handles btnRECONNECT.MouseLeave
        btnRECONNECT.Size = New Size(194, 58)
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RatePlan.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
