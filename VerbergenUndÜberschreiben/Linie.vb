Public Class Linie
    Inherits Grafik

    Private _länge As Integer
    Public Property Länge As Integer
        Get
            Return _länge
        End Get
        Set(ByVal value As Integer)
            _länge = value
        End Set
    End Property

    Public Overloads Sub Zeichnen()
        Console.WriteLine($"Zeichne Linie in der Farbe {Farbe} mit einer Länge von {Länge}.")
    End Sub

End Class
