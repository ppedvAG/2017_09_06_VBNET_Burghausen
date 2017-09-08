Public Class Kreis
    Inherits Grafik

    Private _radius As Double
    Public Property Radius As Double
        Get
            Return _radius
        End Get
        Set(ByVal value As Double)
            _radius = value
        End Set
    End Property

    Public Overrides Sub Zeichnen()
        Console.WriteLine($"Zeichne Kreis in der Farbe {Farbe} mit einem Radius von {Radius}.")
    End Sub

End Class
