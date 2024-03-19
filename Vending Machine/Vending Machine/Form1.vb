Public Class Form1
    Dim WithEvents cs As New coinslot
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.insertnickels()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs.insertdollars()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs.insertquarter()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cs.insertdimes()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cs.coinreturn()
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub

    Private Sub cs_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles cs.coinreturnevent
        If d > 0 Then
            dollarpb.Visible = True
        Else
            dollarpb.Visible = False
        End If

        If di > 0 Then
            dimepb.Visible = True
        Else
            dimepb.Visible = False
        End If

        If n > 0 Then
            nickelpb.Visible = True
        Else
            nickelpb.Visible = False
        End If

        If q > 0 Then
            quarterpb.Visible = True
        Else
            quarterpb.Visible = False
        End If
    End Sub

    Private Sub Product_control1_Load(sender As Object, e As EventArgs) Handles Product_control1.Load

    End Sub

    Private Sub Product_control4_Load(sender As Object, e As EventArgs) Handles Product_control4.Load

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextbox.Text
            Case Product_control1.productID
                cs.buy(Product_control1)
            Case Product_control2.productID
                cs.buy(Product_control2)
            Case Product_control3.productID
                cs.buy(Product_control3)
            Case Product_control4.productID
                cs.buy(Product_control4)
            Case Product_control5.productID
                cs.buy(Product_control5)
            Case Product_control6.productID
                cs.buy(Product_control6)
            Case Product_control7.productID
                cs.buy(Product_control7)
            Case Product_control8.productID
                cs.buy(Product_control8)
            Case Product_control9.productID
                cs.buy(Product_control9)
            Case Product_control10.productID
                cs.buy(Product_control10)
            Case Product_control11.productID
                cs.buy(Product_control11)
            Case Product_control12.productID
                cs.buy(Product_control12)
            Case Product_control13.productID
                cs.buy(Product_control13)
            Case Product_control14.productID
                cs.buy(Product_control14)
            Case Product_control15.productID
                cs.buy(Product_control15)
            Case Product_control16.productID
                cs.buy(Product_control16)
            Case 2

            Case Else

        End Select
        TotalLabel.Text = cs.total.ToString("c2")
    End Sub
    Private Sub cs_buyevent(p As Image) Handles cs.buyevent
        ProductPictureBox.Image = p
    End Sub
End Class
