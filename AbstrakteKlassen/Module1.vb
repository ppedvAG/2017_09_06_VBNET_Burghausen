Module Module1

    Sub Main()

        'Dim g = New Grafik()   '-> nicht mehr möglich, weil Grafik eine MustInherit Klasse ist

        Dim k = New Kreis()
        k.Farbe = "Blau"
        k.Radius = 2.12
        k.Zeichnen()

        Dim l = New Linie()
        l.Farbe = "Grün"
        l.Länge = 7
        l.Zeichnen()

        Console.WriteLine()
        VerwendeGrafik(k)
        VerwendeGrafik(l)

        Console.ReadLine()
    End Sub

    Private Sub VerwendeGrafik(g As Grafik)
        g.Zeichnen()
        'Obwohl Zeichnen in der Klasse Grafik nicht ausprogrammiert ist,
        'kann es trotzdem hier verwendet werden.
        'Durch das Schlüsselwort MustOverride ist sichergestellt, dass
        'Klassen, die von Grafik erben die Methode Zeichnen überschreiben.
    End Sub

End Module
