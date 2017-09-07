Public Class LKW
    Inherits Fahrzeug

    Private _maxLadung As Integer
    Public Property MaxLadung As Integer
        Get
            Return _maxLadung
        End Get
        Set(value As Integer)
            _maxLadung = value
        End Set
    End Property

End Class
