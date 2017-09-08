Public Class Grafik

    Private _farbe As String
    Public Property Farbe() As String
        Get
            Return _farbe
        End Get
        Set(ByVal value As String)
            _farbe = value
        End Set
    End Property

    Public Overridable Sub Zeichnen()       'overridable -> Diese Methode darf überschrieben werden!
        Console.WriteLine($"Zeichne Grafik in der Farbe {Farbe}.")
    End Sub

    Public Overrides Function ToString() As String
        Return $"Eine Grafik in der Farbe {Farbe}."
    End Function

End Class
