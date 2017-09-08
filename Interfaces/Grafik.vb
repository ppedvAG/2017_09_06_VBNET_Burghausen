Public Class Grafik
    Implements ILackierbar

    Private _farbe As String
    Public Property Farbe As String Implements ILackierbar.Farbe
        Get
            Return _farbe
        End Get
        Set(ByVal value As String)
            _farbe = value
        End Set
    End Property

    Public Sub Zeichnen()
        Console.WriteLine($"Zeichne Grafik in der Farbe {Farbe}.")
    End Sub

End Class
