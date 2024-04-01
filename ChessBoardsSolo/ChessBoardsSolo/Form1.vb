Public Class Form1
    Public Shared price As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        price = 0
    End Sub

    Private Sub UpdatePrice()
        CurrentTotal1.Text = price.ToString("C")
    End Sub

    Private Sub GlassUpDown_ValueChanged(sender As Object, e As EventArgs) Handles GlassUpDown.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NormalUpDown_ValueChanged(sender As Object, e As EventArgs) Handles NormalUpDown.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NewspaperUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NewspaperUpDown2.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub IceUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles IceUpDown4.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub StoneUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles StoneUpDown6.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub CalculateTotalPrice()
        price = GlassUpDown.Value * 200 +
            NormalUpDown.Value * 130.5 +
            NewspaperUpDown2.Value * 142.5 +
            IceUpDown4.Value * 150 +
            StoneUpDown6.Value * 145

        UpdatePrice()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        CalculateTotalPrice()
        Form2.Show()
        Me.Hide()
    End Sub
    Private Sub BuyButton1_Click(sender As Object, e As EventArgs) Handles BuyButton1.Click
        CurrentTotal1.Text = 0.00
    End Sub
End Class