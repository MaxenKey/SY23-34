<<<<<<< HEAD
<<<<<<< HEAD
=======
﻿Imports System.Reflection.Emit
=======
﻿Imports System.Reflection.Emit
=======
>>>>>>> main
>>>>>>> main


Public Class x
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim f2 As New Form2
        f2.ShowDialog()

        Me.Show()
    End Sub

﻿Public Class Form1
<<<<<<< HEAD
<<<<<<< HEAD
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

=======
Private Sub x_Load(sender As Object, e As EventArgs) Handles MyBase.Load
=======
Private Sub x_Load(sender As Object, e As EventArgs) Handles MyBase.Load
=======
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

>>>>>>> main
>>>>>>> main

    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim form2 As New Form2
        form2.Show()
        Me.Hide()
    End Sub

End Class
