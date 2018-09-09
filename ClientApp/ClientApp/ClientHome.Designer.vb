<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHello = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.txtStartTime = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPCName = New System.Windows.Forms.TextBox()
        Me.txtStart = New System.Windows.Forms.TextBox()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PBGame1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PBBroadcast1 = New System.Windows.Forms.PictureBox()
        Me.PBsurf1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox61 = New System.Windows.Forms.PictureBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.PBBroadcast = New System.Windows.Forms.Button()
        Me.PBsurf = New System.Windows.Forms.Button()
        Me.PBGame = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBGame1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBroadcast1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBsurf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Controls.Add(Me.txtDuration)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtHello)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1371, 101)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txtDuration
        '
        Me.txtDuration.Enabled = False
        Me.txtDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuration.Location = New System.Drawing.Point(1129, 32)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(72, 35)
        Me.txtDuration.TabIndex = 3
        Me.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(199, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Client Manager"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(11, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(284, 70)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CYBERSPOT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(898, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(225, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Duration Allowed (minutes)"
        '
        'txtHello
        '
        Me.txtHello.Enabled = False
        Me.txtHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHello.Location = New System.Drawing.Point(601, 29)
        Me.txtHello.Name = "txtHello"
        Me.txtHello.Size = New System.Drawing.Size(210, 38)
        Me.txtHello.TabIndex = 1
        Me.txtHello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Script", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(495, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 38)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hello !"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.txtEndTime)
        Me.GroupBox1.Controls.Add(Me.txtStartTime)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPCName)
        Me.GroupBox1.Controls.Add(Me.txtStart)
        Me.GroupBox1.Controls.Add(Me.txtIP)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 564)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(161, 196)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 26)
        Me.TextBox1.TabIndex = 12
        '
        'txtEndTime
        '
        Me.txtEndTime.Enabled = False
        Me.txtEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndTime.Location = New System.Drawing.Point(161, 164)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(175, 26)
        Me.txtEndTime.TabIndex = 11
        '
        'txtStartTime
        '
        Me.txtStartTime.Enabled = False
        Me.txtStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartTime.Location = New System.Drawing.Point(161, 123)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(175, 26)
        Me.txtStartTime.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label16.Location = New System.Drawing.Point(13, 197)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 25)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Cost (INR)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(13, 164)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 25)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "End Time"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(207, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Start Session "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(17, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Time Left "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(13, 117)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 25)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Start Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(11, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "PC Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Client IP"
        '
        'txtPCName
        '
        Me.txtPCName.Enabled = False
        Me.txtPCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPCName.Location = New System.Drawing.Point(161, 79)
        Me.txtPCName.Name = "txtPCName"
        Me.txtPCName.Size = New System.Drawing.Size(175, 26)
        Me.txtPCName.TabIndex = 1
        '
        'txtStart
        '
        Me.txtStart.Enabled = False
        Me.txtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStart.Location = New System.Drawing.Point(161, 234)
        Me.txtStart.Name = "txtStart"
        Me.txtStart.Size = New System.Drawing.Size(175, 26)
        Me.txtStart.TabIndex = 1
        '
        'txtIP
        '
        Me.txtIP.Enabled = False
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(161, 40)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(175, 26)
        Me.txtIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(407, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  DETAILS "
        '
        'Timer1
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(611, 107)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "   "
        '
        'PBGame1
        '
        Me.PBGame1.Enabled = False
        Me.PBGame1.Image = Global.ClientApp.My.Resources.Resources.super_mario_games
        Me.PBGame1.Location = New System.Drawing.Point(364, 300)
        Me.PBGame1.Name = "PBGame1"
        Me.PBGame1.Size = New System.Drawing.Size(225, 138)
        Me.PBGame1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBGame1.TabIndex = 19
        Me.PBGame1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ClientApp.My.Resources.Resources.disconnected_1440x900
        Me.PictureBox3.Location = New System.Drawing.Point(364, 444)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(239, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 18
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Image = Global.ClientApp.My.Resources.Resources.CONN
        Me.PictureBox2.Location = New System.Drawing.Point(609, 444)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(241, 64)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PBBroadcast1
        '
        Me.PBBroadcast1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBBroadcast1.Enabled = False
        Me.PBBroadcast1.Image = Global.ClientApp.My.Resources.Resources.picture14177535457641
        Me.PBBroadcast1.Location = New System.Drawing.Point(375, 135)
        Me.PBBroadcast1.Name = "PBBroadcast1"
        Me.PBBroadcast1.Size = New System.Drawing.Size(222, 150)
        Me.PBBroadcast1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBBroadcast1.TabIndex = 14
        Me.PBBroadcast1.TabStop = False
        '
        'PBsurf1
        '
        Me.PBsurf1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBsurf1.Enabled = False
        Me.PBsurf1.Image = Global.ClientApp.My.Resources.Resources.bigstock_world_connection_asia_oriented
        Me.PBsurf1.Location = New System.Drawing.Point(615, 136)
        Me.PBsurf1.Name = "PBsurf1"
        Me.PBsurf1.Size = New System.Drawing.Size(225, 150)
        Me.PBsurf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBsurf1.TabIndex = 13
        Me.PBsurf1.TabStop = False
        '
        'PictureBox61
        '
        Me.PictureBox61.Enabled = False
        Me.PictureBox61.Image = Global.ClientApp.My.Resources.Resources.dark_banner
        Me.PictureBox61.Location = New System.Drawing.Point(615, 304)
        Me.PictureBox61.Name = "PictureBox61"
        Me.PictureBox61.Size = New System.Drawing.Size(222, 134)
        Me.PictureBox61.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox61.TabIndex = 20
        Me.PictureBox61.TabStop = False
        '
        'Timer3
        '
        '
        'PBBroadcast
        '
        Me.PBBroadcast.Location = New System.Drawing.Point(522, 136)
        Me.PBBroadcast.Name = "PBBroadcast"
        Me.PBBroadcast.Size = New System.Drawing.Size(75, 23)
        Me.PBBroadcast.TabIndex = 21
        Me.PBBroadcast.Text = "      GO      "
        Me.PBBroadcast.UseVisualStyleBackColor = True
        '
        'PBsurf
        '
        Me.PBsurf.Location = New System.Drawing.Point(765, 139)
        Me.PBsurf.Name = "PBsurf"
        Me.PBsurf.Size = New System.Drawing.Size(75, 23)
        Me.PBsurf.TabIndex = 22
        Me.PBsurf.Text = "     GO     "
        Me.PBsurf.UseVisualStyleBackColor = True
        '
        'PBGame
        '
        Me.PBGame.Location = New System.Drawing.Point(514, 304)
        Me.PBGame.Name = "PBGame"
        Me.PBGame.Size = New System.Drawing.Size(75, 23)
        Me.PBGame.TabIndex = 23
        Me.PBGame.Text = "    GO    "
        Me.PBGame.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(765, 304)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(75, 23)
        Me.PictureBox6.TabIndex = 24
        Me.PictureBox6.Text = "    GO    "
        Me.PictureBox6.UseVisualStyleBackColor = True
        '
        'ClientHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1337, 742)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PBGame)
        Me.Controls.Add(Me.PBsurf)
        Me.Controls.Add(Me.PBBroadcast)
        Me.Controls.Add(Me.PictureBox61)
        Me.Controls.Add(Me.PBGame1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PBBroadcast1)
        Me.Controls.Add(Me.PBsurf1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ClientHome"
        Me.Text = "ClientHome"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBGame1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBroadcast1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBsurf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox61, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStart As System.Windows.Forms.TextBox
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHello As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPCName As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PBBroadcast1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PBsurf1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PBGame1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox61 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents txtEndTime As System.Windows.Forms.TextBox
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PBBroadcast As System.Windows.Forms.Button
    Friend WithEvents PBsurf As System.Windows.Forms.Button
    Friend WithEvents PBGame As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As System.Windows.Forms.Button
End Class
