Imports System.Reflection.Emit
Imports System.Windows

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()
        Label2.Text = f2.NumericUpDown1.Value
        Me.Show()
    End Sub

End Class
