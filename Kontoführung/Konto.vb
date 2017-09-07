Public Class Konto

    Private _kontostand As Decimal
    Public Property Kontostand As Decimal
        Get
            Return _kontostand
        End Get
        Private Set(value As Decimal)
            _kontostand = value
        End Set
    End Property

    Public Sub New(startkapital As Decimal)
        _kontostand = startkapital
    End Sub

    Public Sub Einzahlen(betrag As Decimal)
        Kontostand += betrag
    End Sub
    Public Sub Auszaheln(betrag As Decimal)
        Kontostand -= betrag
    End Sub

End Class
