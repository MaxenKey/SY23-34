Imports System
Imports System.Windows

Namespace CurrencyConverter
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Convert_Click(sender As Object, e As RoutedEventArgs)
            Dim amount As Double
            If Double.TryParse(txtAmount.Text, amount) Then
                Dim selectedCurrency As ComboBoxItem = DirectCast(cmbCurrency.SelectedItem, ComboBoxItem)
                Dim currency As String = selectedCurrency.Content.ToString()
                Dim rate As Double = GetRate(currency)

                Dim convertedAmount As Double = amount * rate

                lblResult.Content = $"Amount in {currency}: {convertedAmount}"
            Else
                MessageBox.Show("Invalid amount. Please enter a valid number.")
            End If
        End Sub

        Private Function GetRate(currency As String) As Double
            Select Case currency
                Case "Euro (EUR)"
                    Return 0.84 ' Sample rate
                Case "British Pound (GBP)"
                    Return 0.73 ' Sample rate
                Case "Japanese Yen (JPY)"
                    Return 111.29 ' Sample rate
                Case "Australian Dollar (AUD)"
                    Return 1.33 ' Sample rate
                Case "Canadian Dollar (CAD)"
                    Return 1.29 ' Sample rate
                Case "Mexican Peso (MXN)"
                    Return 20.18 ' Sample rate
                Case Else
                    Return 1.0 ' Default rate
            End Select
        End Function

        Private Sub Clear_Click(sender As Object, e As RoutedEventArgs)
            txtAmount.Text = ""
            cmbCurrency.SelectedItem = Nothing
            lblResult.Content = ""
        End Sub
    End Class
End Namespace