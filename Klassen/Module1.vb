Module Module1

    Sub Main()

        Dim f As Fahrzeug = New Fahrzeug(2004, "Blau")
        f.Geschwindigkeit = 500
        'f.geschwindigkeit = Integer.MaxValue
        'f.SetGeschwindigkeit(Integer.MaxValue)
        'f.Beschleunigen(10)
        'f.Bremsen(40)
        f.Leistung = 90

        Dim f2 As New Fahrzeug(1996)
        f2.Geschwindigkeit = 80
        f2.Farbe = "Silber"
        f2.Beschleunigen()
        f2.Beschleunigen(10)
        f2.Beschleunigen(1.1)
        'f2.SetGeschwindigkeit(80)
        'f2.Beschleunigen(40)
        'f2.Bremsen(100)

        Console.WriteLine("F:")
        Console.WriteLine(f.Geschwindigkeit)
        Console.WriteLine(f.Farbe)

        Console.WriteLine(vbNewLine)
        Console.WriteLine("F2:")
        Console.WriteLine(f2.Geschwindigkeit)
        Console.WriteLine(f2.Farbe)

        Console.ReadLine()

    End Sub

End Module
