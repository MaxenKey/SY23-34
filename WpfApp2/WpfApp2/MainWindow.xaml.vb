Class MainWindow
    Dim Pay As Integer

    Private Sub CCNum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles CCNum.TextChanged
        If Not PayButton Is Nothing Then
            If CCNum.Text Like "###" Then
                Pay = Pay + 1
            End If
        End If

    End Sub

    Private Sub ExpNum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ExpNum.TextChanged
        If Not PayButton Is Nothing Then
            If ExpNum.Text Like "##/##" Then
                Pay = Pay + 1
            End If
        End If
    End Sub

    Private Sub NameCard_TextChanged(sender As Object, e As TextChangedEventArgs) Handles NameCard.TextChanged
        If Not PayButton Is Nothing Then
            If NameCard.Text Like "*" Then
                Pay = Pay + 1
            End If
        End If
    End Sub

    Private Sub PhoneNum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles PhoneNum.TextChanged
        If Not PayButton Is Nothing Then
            If PhoneNum.Text Like "##########" Then
                Pay = Pay + 1
            End If
        End If
    End Sub

    Private Sub SecNum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles SecNum.TextChanged
        If Not PayButton Is Nothing Then
            If PhoneNum.Text Like "###" Then
                Pay = Pay + 1
            End If
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        PhoneNum.Text = ""
        NameCard.Text = ""
        ExpNum.Text = ""
        SecNum.Text = ""
        CCNum.Text = ""
    End Sub

    Private Sub PayButton_Click(sender As Object, e As RoutedEventArgs) Handles PayButton.Click
        If Pay = 5 Then
            PayButton.IsEnabled = True
        Else
            PayButton.IsEnabled = False
        End If
        PhoneNum.Text = ""
        NameCard.Text = ""
        ExpNum.Text = ""
        SecNum.Text = ""
        CCNum.Text = ""
    End Sub
End Class
