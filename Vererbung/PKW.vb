Public Class PKW
    Inherits Fahrzeug

    Public Sub New(sitzplätze As Integer)
        Me.Sitzplätze = sitzplätze
    End Sub

    Private _sitzplätze As Integer
    Public Property Sitzplätze As Integer
        Get
            Return _sitzplätze
        End Get
        Set(value As Integer)
            _sitzplätze = value
        End Set
    End Property
End Class
