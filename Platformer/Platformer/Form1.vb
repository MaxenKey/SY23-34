Public Class Frm2DPlatformer
    Dim movespeed As Integer = 40
    Dim isJumping As Boolean
    Dim collectedCoins As Integer
    Dim coins As Integer

    Private Sub Frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += movespeed
    End Sub

    Private Sub Frm2DPlatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp, MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
        End Select
        isJumping = False
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= movespeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= movespeed
    End Sub

    Private Sub Frm2DPlatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        For Each b As Control In Me.Controls
            If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
                tmrGravity.Stop()
            Else
                If isJumping = False Then
                    tmrGravity.Start()
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "Bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        collectedCoins += 1
                        coins += 1
                        scorelabel.Text = coins.ToString()
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += movespeed
    End Sub

    Private Sub picAir_Click(sender As Object, e As EventArgs) Handles picAir.Click
    End Sub
End Class