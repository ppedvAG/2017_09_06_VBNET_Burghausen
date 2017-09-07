Module Module1

    Sub Main()

        Dim f = New Fahrzeug()
        f.Geschwindigkeit = 50
        f.Farbe = "Blau"
        f.Beschleunigen(10)
        f.Bremsen(20)

        Dim p = New PKW(3)
        p.Geschwindigkeit = 80
        p.Farbe = "Gelb"
        p.Beschleunigen(40)
        p.Bremsen(20)
        'p.Sitzplätze = 5

        Dim l = New LKW()
        l.Geschwindigkeit = 30
        l.Farbe = "Rot"
        l.Beschleunigen(10)
        l.Bremsen(5)
        l.MaxLadung = 18000

        Dim c = New Cabrio(2)
        c.Geschwindigkeit = 80
        c.Farbe = "Gelb"
        c.Beschleunigen(40)
        c.Bremsen(20)
        'c.Sitzplätze = 5
        c.Dachart = "Softtop"

    End Sub

End Module
