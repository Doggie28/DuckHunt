Public Class Form1
    Dim shotAnimationCount As Integer
    Dim duckAnimationCount As Integer
    Dim duckFallAnimationCount As Integer
    Dim r As New Random
    Dim duckLeftSpeed As Integer
    Dim duckUpSpeed As Integer
    Dim goal(30) As PictureBox
    Dim goalDuckCounter As Integer
    Dim duckStart As Boolean = False
    Dim hits As Integer
    Dim shot As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hits = 0
        shot = 0
        shotAnimationCount = 0
        duckAnimationCount = 0
        duckFallAnimationCount = 0
        goalDuckCounter = -1
        makeGoalDucks()
        duckTimer.Stop()
        duckFall.Stop()
        duckMove.Stop()
        Me.BackgroundImage = System.Drawing.Image.FromFile(".\Yeet\DuckHuntStart.jpg")
    End Sub

    Private Sub pbField_MouseMove(sender As Object, e As MouseEventArgs) Handles pbField.MouseMove
        pbGun.Left = e.Location.X - pbGun.Width / 2

    End Sub

    Private Sub pbField_Click(sender As Object, e As EventArgs) Handles pbField.Click
        shot += 1
        accuracy.Text = ((hits / shot) * 100) \ 1
        shootTimer.Start()
    End Sub

    Sub makeGoalDucks()
        For i = 0 To 10
            goalDuckCounter += 1
            Me.Text = goalDuckCounter
            goal(i) = New PictureBox
            With goal(i)
                .Top = 29
                .Left = 326 + i * 30
                .Width = 25
                .Height = 30
                .Image = goalOriginal.Image
                .BackColor = Color.Transparent
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BringToFront()
            End With
            Me.Controls.Add(goal(i))

        Next
    End Sub

    Private Sub shootTimer_Tick(sender As Object, e As EventArgs) Handles shootTimer.Tick
        Select Case shotAnimationCount
            Case 0
                pbGun.Image = pbShot1.Image
                shotAnimationCount += 1
            Case 1
                pbGun.Image = pbShot2.Image
                shotAnimationCount += 1
            Case 2
                pbGun.Image = pbShot3.Image
                shotAnimationCount += 1
            Case 3
                pbGun.Image = pbReload.Image
                shotAnimationCount += 1
            Case 4
                pbGun.Image = pbReload2.Image
                shotAnimationCount += 1
            Case 5
                pbGun.Image = pbReload3.Image
                shotAnimationCount += 1
            Case 6
                pbGun.Image = pbShot.Image
                shootTimer.Stop()
                shotAnimationCount = 0
        End Select

    End Sub

    Private Sub duckTimer_Tick(sender As Object, e As EventArgs) Handles duckTimer.Tick
        Select Case duckAnimationCount
            Case 0
                pbDuck.Image = pbDuck1.Image
                duckAnimationCount += 1
            Case 1
                pbDuck.Image = pbDuck2.Image
                duckAnimationCount += 1
            Case 2
                pbDuck.Image = pbDuck3.Image
                duckAnimationCount += 1
            Case 3
                pbDuck.Image = pbDuck4.Image
                duckAnimationCount += 1
            Case 4
                pbDuck.Image = pbDuck5.Image
                duckAnimationCount += 1
            Case 5
                pbDuck.Image = pbDuck6.Image
                duckAnimationCount += 1
            Case 6
                pbDuck.Image = pbDuck5.Image
                duckAnimationCount = 5
        End Select

    End Sub

    Private Sub pbDuck_Click(sender As Object, e As EventArgs) Handles pbDuck.Click
        pbDuck.Enabled = False
        hits += 1
        shot += 1
        accuracy.Text = ((hits / shot) * 100) \ 1
        duckTimer.Stop()
        duckMove.Stop()
        duckFall.Start()
        goal(goalDuckCounter).Hide()
        goalDuckCounter -= 1
        levelUp()
    End Sub

    Sub levelUp()
        If goalDuckCounter <= 0 Then
            lblLevelUp.Show()
            duckTimer.Stop()
            duckMove.Stop()
            For i = 0 To 10
                goal(i).Show()
            Next
            goalDuckCounter = 11
        End If
    End Sub

    Private Sub lauchDuck()
        duckAnimationCount = 0
        pbDuck.Enabled = True
        pbDuck.Top = pbField.Bottom
        pbDuck.Left = r.Next(143, 647)
        duckLeftSpeed = r.Next(2, 10)
        duckUpSpeed = r.Next(-10, -2)
        duckMove.Start()
        duckTimer.Start()

    End Sub

    Private Sub duckMove_Tick(sender As Object, e As EventArgs) Handles duckMove.Tick

        pbDuck.Left += duckLeftSpeed
        pbDuck.Top += duckUpSpeed
        checkSides()

    End Sub

    Sub checkSides()

        If pbDuck.Left > 790 Then
            pbDuck.Left = r.Next(130, 760)
            pbDuck.Top = pbField.Bottom
        End If
        If pbDuck.Top < 0 Then
            pbDuck.Left = r.Next(130, 760)
            pbDuck.Top = pbField.Bottom
        End If
    End Sub

    Private Sub duckFall_Tick(sender As Object, e As EventArgs) Handles duckFall.Tick
        duckFallAnimationCount += 1
        If duckFallAnimationCount < 10 Then
            pbDuck.Image = pbDuckHit.Image
        Else
            pbDuck.Image = pbDuckFall.Image
            pbDuck.Top += 7
            If pbDuck.Bottom > pbField.Bottom Then
                duckFall.Stop()
                duckAnimationCount = 0
                lauchDuck()
            End If
        End If
    End Sub

    Private Sub lblStart_Click(sender As Object, e As EventArgs) Handles lblStart.Click
        pbDuck.Visible = True
        lbl.Visible = True
        Level.Visible = True
        duckStart = True
        lblStart.Hide()
        pbDuck.Show()
        lauchDuck()
        Level.Text += 1
        Me.BackgroundImage = System.Drawing.Image.FromFile(".\Yeet\background.png")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles accuracy.Click

    End Sub

    Private Sub lblaccuracy_Click(sender As Object, e As EventArgs) Handles lblaccuracy.Click

    End Sub
End Class
