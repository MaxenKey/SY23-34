Imports Accessibility

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CurrentTotal2.Text = Module1.price.ToString("C")
    End Sub

    Private Sub UpdatePrice()
        CurrentTotal2.Text = Module1.price.ToString("C")
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub CalculateTotalPrice()
        Module1.price = NumericUpDown1.Value * 50.99 +
        NumericUpDown2.Value * 37.99 +
        NumericUpDown3.Value * 67.99 +
        NumericUpDown4.Value * 30.99 +
        NumericUpDown5.Value * 31.99
        UpdatePrice()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        CalculateTotalPrice()
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        CurrentTotal2.Text = 0.00
    End Sub
End Class