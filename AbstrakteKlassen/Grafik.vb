Public MustInherit Class Grafik
    'MustInherit: Man kann keine Instanz mehr von Grafik anlegen
    'Um Grafik verwenden zu können, muss man davon erben.

    Private _farbe As String
    Public Property Farbe() As String
        Get
            Return _farbe
        End Get
        Set(ByVal value As String)
            _farbe = value
        End Set
    End Property

    Public MustOverride Sub Zeichnen()  'MustOverride Methoden müssen überschrieben werden

End Class
