<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.shootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pbDuck2 = New System.Windows.Forms.PictureBox()
        Me.pbDuck = New System.Windows.Forms.PictureBox()
        Me.pbShot = New System.Windows.Forms.PictureBox()
        Me.pbShot3 = New System.Windows.Forms.PictureBox()
        Me.pbShot2 = New System.Windows.Forms.PictureBox()
        Me.pbShot1 = New System.Windows.Forms.PictureBox()
        Me.pbReload3 = New System.Windows.Forms.PictureBox()
        Me.pbReload2 = New System.Windows.Forms.PictureBox()
        Me.pbReload = New System.Windows.Forms.PictureBox()
        Me.pbGun = New System.Windows.Forms.PictureBox()
        Me.pbField = New System.Windows.Forms.PictureBox()
        Me.pbDuck3 = New System.Windows.Forms.PictureBox()
        Me.pbDuck4 = New System.Windows.Forms.PictureBox()
        Me.pbDuck5 = New System.Windows.Forms.PictureBox()
        Me.pbDuck6 = New System.Windows.Forms.PictureBox()
        Me.pbDuckFall = New System.Windows.Forms.PictureBox()
        Me.pbDuckHit = New System.Windows.Forms.PictureBox()
        Me.pbDuck1 = New System.Windows.Forms.PictureBox()
        Me.duckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.duckMove = New System.Windows.Forms.Timer(Me.components)
        Me.duckFall = New System.Windows.Forms.Timer(Me.components)
        Me.goalOriginal = New System.Windows.Forms.PictureBox()
        Me.lblLevelUp = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.lblaccuracy = New System.Windows.Forms.Label()
        Me.accuracy = New System.Windows.Forms.Label()
        CType(Me.pbDuck2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbShot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReload3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReload2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbReload, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuckFall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuckHit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDuck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goalOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shootTimer
        '
        Me.shootTimer.Interval = 80
        '
        'pbDuck2
        '
        Me.pbDuck2.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck2.Image = Global.DuckHunt.My.Resources.Resources.Duck2
        Me.pbDuck2.Location = New System.Drawing.Point(968, 12)
        Me.pbDuck2.Name = "pbDuck2"
        Me.pbDuck2.Size = New System.Drawing.Size(52, 57)
        Me.pbDuck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck2.TabIndex = 10
        Me.pbDuck2.TabStop = False
        Me.pbDuck2.Visible = False
        '
        'pbDuck
        '
        Me.pbDuck.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck.Image = Global.DuckHunt.My.Resources.Resources.Duck1
        Me.pbDuck.Location = New System.Drawing.Point(279, 437)
        Me.pbDuck.Name = "pbDuck"
        Me.pbDuck.Size = New System.Drawing.Size(50, 46)
        Me.pbDuck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck.TabIndex = 9
        Me.pbDuck.TabStop = False
        Me.pbDuck.Visible = False
        '
        'pbShot
        '
        Me.pbShot.Image = Global.DuckHunt.My.Resources.Resources.shot0
        Me.pbShot.Location = New System.Drawing.Point(864, 327)
        Me.pbShot.Name = "pbShot"
        Me.pbShot.Size = New System.Drawing.Size(85, 68)
        Me.pbShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShot.TabIndex = 8
        Me.pbShot.TabStop = False
        Me.pbShot.Visible = False
        '
        'pbShot3
        '
        Me.pbShot3.Image = Global.DuckHunt.My.Resources.Resources.shot3
        Me.pbShot3.Location = New System.Drawing.Point(864, 178)
        Me.pbShot3.Name = "pbShot3"
        Me.pbShot3.Size = New System.Drawing.Size(85, 68)
        Me.pbShot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShot3.TabIndex = 7
        Me.pbShot3.TabStop = False
        Me.pbShot3.Visible = False
        '
        'pbShot2
        '
        Me.pbShot2.Image = Global.DuckHunt.My.Resources.Resources.shot2
        Me.pbShot2.Location = New System.Drawing.Point(855, 101)
        Me.pbShot2.Name = "pbShot2"
        Me.pbShot2.Size = New System.Drawing.Size(85, 68)
        Me.pbShot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShot2.TabIndex = 6
        Me.pbShot2.TabStop = False
        Me.pbShot2.Visible = False
        '
        'pbShot1
        '
        Me.pbShot1.Image = Global.DuckHunt.My.Resources.Resources.shot1
        Me.pbShot1.Location = New System.Drawing.Point(864, 26)
        Me.pbShot1.Name = "pbShot1"
        Me.pbShot1.Size = New System.Drawing.Size(85, 68)
        Me.pbShot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbShot1.TabIndex = 5
        Me.pbShot1.TabStop = False
        Me.pbShot1.Visible = False
        '
        'pbReload3
        '
        Me.pbReload3.Image = Global.DuckHunt.My.Resources.Resources.reload3
        Me.pbReload3.Location = New System.Drawing.Point(889, 493)
        Me.pbReload3.Name = "pbReload3"
        Me.pbReload3.Size = New System.Drawing.Size(85, 68)
        Me.pbReload3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReload3.TabIndex = 4
        Me.pbReload3.TabStop = False
        Me.pbReload3.Visible = False
        '
        'pbReload2
        '
        Me.pbReload2.Image = Global.DuckHunt.My.Resources.Resources.reload2
        Me.pbReload2.Location = New System.Drawing.Point(864, 415)
        Me.pbReload2.Name = "pbReload2"
        Me.pbReload2.Size = New System.Drawing.Size(85, 68)
        Me.pbReload2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReload2.TabIndex = 3
        Me.pbReload2.TabStop = False
        Me.pbReload2.Visible = False
        '
        'pbReload
        '
        Me.pbReload.Image = Global.DuckHunt.My.Resources.Resources.reload
        Me.pbReload.Location = New System.Drawing.Point(864, 253)
        Me.pbReload.Name = "pbReload"
        Me.pbReload.Size = New System.Drawing.Size(85, 68)
        Me.pbReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbReload.TabIndex = 2
        Me.pbReload.TabStop = False
        Me.pbReload.Visible = False
        '
        'pbGun
        '
        Me.pbGun.BackColor = System.Drawing.Color.Transparent
        Me.pbGun.Image = Global.DuckHunt.My.Resources.Resources.Doom
        Me.pbGun.Location = New System.Drawing.Point(291, 489)
        Me.pbGun.Name = "pbGun"
        Me.pbGun.Size = New System.Drawing.Size(85, 68)
        Me.pbGun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbGun.TabIndex = 1
        Me.pbGun.TabStop = False
        '
        'pbField
        '
        Me.pbField.BackColor = System.Drawing.Color.Transparent
        Me.pbField.Location = New System.Drawing.Point(0, 0)
        Me.pbField.Name = "pbField"
        Me.pbField.Size = New System.Drawing.Size(866, 499)
        Me.pbField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbField.TabIndex = 0
        Me.pbField.TabStop = False
        '
        'pbDuck3
        '
        Me.pbDuck3.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck3.Image = Global.DuckHunt.My.Resources.Resources.duck3
        Me.pbDuck3.Location = New System.Drawing.Point(968, 75)
        Me.pbDuck3.Name = "pbDuck3"
        Me.pbDuck3.Size = New System.Drawing.Size(52, 57)
        Me.pbDuck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck3.TabIndex = 11
        Me.pbDuck3.TabStop = False
        Me.pbDuck3.Visible = False
        '
        'pbDuck4
        '
        Me.pbDuck4.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck4.Image = Global.DuckHunt.My.Resources.Resources.Duck4
        Me.pbDuck4.Location = New System.Drawing.Point(978, 138)
        Me.pbDuck4.Name = "pbDuck4"
        Me.pbDuck4.Size = New System.Drawing.Size(52, 57)
        Me.pbDuck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck4.TabIndex = 12
        Me.pbDuck4.TabStop = False
        Me.pbDuck4.Visible = False
        '
        'pbDuck5
        '
        Me.pbDuck5.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck5.Image = Global.DuckHunt.My.Resources.Resources.Duck5
        Me.pbDuck5.Location = New System.Drawing.Point(978, 201)
        Me.pbDuck5.Name = "pbDuck5"
        Me.pbDuck5.Size = New System.Drawing.Size(52, 57)
        Me.pbDuck5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDuck5.TabIndex = 13
        Me.pbDuck5.TabStop = False
        Me.pbDuck5.Visible = False
        '
        'pbDuck6
        '
        Me.pbDuck6.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck6.Image = Global.DuckHunt.My.Resources.Resources.duck6
        Me.pbDuck6.Location = New System.Drawing.Point(978, 264)
        Me.pbDuck6.Name = "pbDuck6"
        Me.pbDuck6.Size = New System.Drawing.Size(52, 57)
        Me.pbDuck6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck6.TabIndex = 14
        Me.pbDuck6.TabStop = False
        Me.pbDuck6.Visible = False
        '
        'pbDuckFall
        '
        Me.pbDuckFall.BackColor = System.Drawing.Color.Transparent
        Me.pbDuckFall.Image = Global.DuckHunt.My.Resources.Resources.DuckFall
        Me.pbDuckFall.Location = New System.Drawing.Point(978, 327)
        Me.pbDuckFall.Name = "pbDuckFall"
        Me.pbDuckFall.Size = New System.Drawing.Size(52, 57)
        Me.pbDuckFall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDuckFall.TabIndex = 15
        Me.pbDuckFall.TabStop = False
        Me.pbDuckFall.Visible = False
        '
        'pbDuckHit
        '
        Me.pbDuckHit.BackColor = System.Drawing.Color.Transparent
        Me.pbDuckHit.Image = Global.DuckHunt.My.Resources.Resources.Hit
        Me.pbDuckHit.Location = New System.Drawing.Point(978, 390)
        Me.pbDuckHit.Name = "pbDuckHit"
        Me.pbDuckHit.Size = New System.Drawing.Size(52, 57)
        Me.pbDuckHit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbDuckHit.TabIndex = 16
        Me.pbDuckHit.TabStop = False
        Me.pbDuckHit.Visible = False
        '
        'pbDuck1
        '
        Me.pbDuck1.BackColor = System.Drawing.Color.Transparent
        Me.pbDuck1.Image = Global.DuckHunt.My.Resources.Resources.Duck1
        Me.pbDuck1.Location = New System.Drawing.Point(980, 453)
        Me.pbDuck1.Name = "pbDuck1"
        Me.pbDuck1.Size = New System.Drawing.Size(50, 46)
        Me.pbDuck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDuck1.TabIndex = 17
        Me.pbDuck1.TabStop = False
        Me.pbDuck1.Visible = False
        '
        'duckTimer
        '
        Me.duckTimer.Enabled = True
        '
        'duckMove
        '
        '
        'duckFall
        '
        Me.duckFall.Interval = 40
        '
        'goalOriginal
        '
        Me.goalOriginal.Image = Global.DuckHunt.My.Resources.Resources.goalOriginal
        Me.goalOriginal.Location = New System.Drawing.Point(257, 26)
        Me.goalOriginal.Name = "goalOriginal"
        Me.goalOriginal.Size = New System.Drawing.Size(29, 29)
        Me.goalOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goalOriginal.TabIndex = 18
        Me.goalOriginal.TabStop = False
        Me.goalOriginal.Visible = False
        '
        'lblLevelUp
        '
        Me.lblLevelUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLevelUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelUp.ForeColor = System.Drawing.Color.White
        Me.lblLevelUp.Location = New System.Drawing.Point(288, 213)
        Me.lblLevelUp.Name = "lblLevelUp"
        Me.lblLevelUp.Size = New System.Drawing.Size(354, 107)
        Me.lblLevelUp.TabIndex = 19
        Me.lblLevelUp.Text = "Level Up!"
        Me.lblLevelUp.Visible = False
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.Orange
        Me.lblStart.Location = New System.Drawing.Point(3, 376)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(209, 107)
        Me.lblStart.TabIndex = 20
        Me.lblStart.Text = "Start"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Lime
        Me.lbl.Location = New System.Drawing.Point(49, 26)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(38, 13)
        Me.lbl.TabIndex = 22
        Me.lbl.Text = "Level"
        Me.lbl.Visible = False
        '
        'Level
        '
        Me.Level.BackColor = System.Drawing.Color.Transparent
        Me.Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level.ForeColor = System.Drawing.Color.Lime
        Me.Level.Location = New System.Drawing.Point(128, 26)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(25, 19)
        Me.Level.TabIndex = 23
        Me.Level.Text = "0"
        Me.Level.Visible = False
        '
        'lblaccuracy
        '
        Me.lblaccuracy.BackColor = System.Drawing.Color.Transparent
        Me.lblaccuracy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaccuracy.ForeColor = System.Drawing.Color.Lime
        Me.lblaccuracy.Location = New System.Drawing.Point(648, 38)
        Me.lblaccuracy.Name = "lblaccuracy"
        Me.lblaccuracy.Size = New System.Drawing.Size(132, 18)
        Me.lblaccuracy.TabIndex = 24
        Me.lblaccuracy.Text = "Accuracy"
        '
        'accuracy
        '
        Me.accuracy.BackColor = System.Drawing.Color.Transparent
        Me.accuracy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accuracy.ForeColor = System.Drawing.Color.Lime
        Me.accuracy.Location = New System.Drawing.Point(777, 38)
        Me.accuracy.Name = "accuracy"
        Me.accuracy.Size = New System.Drawing.Size(54, 18)
        Me.accuracy.TabIndex = 25
        Me.accuracy.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DuckHunt.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 573)
        Me.Controls.Add(Me.accuracy)
        Me.Controls.Add(Me.lblaccuracy)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblLevelUp)
        Me.Controls.Add(Me.goalOriginal)
        Me.Controls.Add(Me.pbDuck1)
        Me.Controls.Add(Me.pbDuckHit)
        Me.Controls.Add(Me.pbDuckFall)
        Me.Controls.Add(Me.pbDuck6)
        Me.Controls.Add(Me.pbDuck5)
        Me.Controls.Add(Me.pbDuck4)
        Me.Controls.Add(Me.pbDuck3)
        Me.Controls.Add(Me.pbDuck2)
        Me.Controls.Add(Me.pbDuck)
        Me.Controls.Add(Me.pbShot)
        Me.Controls.Add(Me.pbShot3)
        Me.Controls.Add(Me.pbShot2)
        Me.Controls.Add(Me.pbShot1)
        Me.Controls.Add(Me.pbReload3)
        Me.Controls.Add(Me.pbReload2)
        Me.Controls.Add(Me.pbReload)
        Me.Controls.Add(Me.pbGun)
        Me.Controls.Add(Me.pbField)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.DeepSkyBlue
        CType(Me.pbDuck2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbShot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReload3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReload2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbReload, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuckFall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuckHit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDuck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goalOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGun As System.Windows.Forms.PictureBox
    Friend WithEvents pbReload As System.Windows.Forms.PictureBox
    Friend WithEvents pbReload2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbReload3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbShot1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbShot2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbShot3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbShot As System.Windows.Forms.PictureBox
    Friend WithEvents shootTimer As System.Windows.Forms.Timer
    Friend WithEvents pbDuck2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck As System.Windows.Forms.PictureBox
    Friend WithEvents pbField As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck3 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck5 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck6 As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuckFall As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuckHit As System.Windows.Forms.PictureBox
    Friend WithEvents pbDuck1 As System.Windows.Forms.PictureBox
    Friend WithEvents duckTimer As System.Windows.Forms.Timer
    Friend WithEvents duckMove As System.Windows.Forms.Timer
    Friend WithEvents duckFall As System.Windows.Forms.Timer
    Friend WithEvents goalOriginal As System.Windows.Forms.PictureBox
    Friend WithEvents lblLevelUp As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.Label
    Friend WithEvents lblaccuracy As System.Windows.Forms.Label
    Friend WithEvents accuracy As System.Windows.Forms.Label

End Class
