
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        

        Timer1.Enabled = True
        Reelcontrol4.Spin()
        Reelcontrol5.Spin()
        Reelcontrol6.Spin()
        Label1.Text = Reelcontrol4.itemValue
        Label2.Text = Reelcontrol5.itemValue
        Label3.Text = Reelcontrol6.itemValue



    End Sub

    Dim WithEvents cs As New Class1

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertnickels()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertdollars()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertquarters()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.insertdimes()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Reelcontrol4.itemValue
        Label2.Text = Reelcontrol5.itemValue
        Label3.Text = Reelcontrol6.itemValue

        Dim equalCount As Integer = 0

        If Label1.Text = Label2.Text Then
            equalCount += 1
        End If

        If Label1.Text = Label3.Text Then
            equalCount += 1
        End If
        If Label2.Text = Label3.Text Then
            equalCount += 1
        End If

        If equalCount >= 1 Then
            LabelAlmost.Visible = True
        Else
            LabelAlmost.Visible = False
        End If
        If equalCount >= 2 Then
            LabelWin.Visible = True
        Else
            LabelWin.Visible = False
        End If
    End Sub

    Private Sub LabelWin_Click(sender As Object, e As EventArgs) Handles LabelWin.Click

    End Sub
End Class
