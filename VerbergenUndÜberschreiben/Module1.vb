Module Module1

    Sub Main()

        Dim g = New Grafik()
        g.Farbe = "Rot"
        g.Zeichnen()

        Dim k = New Kreis()
        k.Farbe = "Blau"
        k.Radius = 2.12
        k.Zeichnen()

        Dim l = New Linie()
        l.Farbe = "Grün"
        l.Länge = 7
        l.Zeichnen()

        Console.WriteLine()
        VerwendeGrafik(g)
        VerwendeGrafik(k)
        VerwendeGrafik(l)

        Console.WriteLine(g)
        Console.ReadLine()
    End Sub

    Private Sub VerwendeGrafik(g As Grafik)
        g.Zeichnen()
    End Sub

End Module
