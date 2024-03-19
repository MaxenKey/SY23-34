Public Class Class1
    Public Property quarters As Integer
    Public Property dimes As Integer
    Public Property nickels As Integer
    Public Property dollars As Integer
    Dim _total As Decimal

    Public ReadOnly Property total As Decimal
        Get
            _total = dollars + quarters * 0.25 + dimes * 0.1 + nickels * 0.05
            Return _total
        End Get
    End Property
    Sub insertquarters()
        quarters = quarters + 1
    End Sub
    Sub insertdimes()
        dimes = dimes + 1
    End Sub
    Sub insertnickels()
        nickels = nickels + 1
    End Sub
    Sub insertdollars()
        dollars = dollars + 1
    End Sub
End Class