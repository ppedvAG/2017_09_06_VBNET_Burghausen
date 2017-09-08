Module Module1

    Sub Main()

        Dim f = New Fahrzeug()
        f.Farbe = "Blau"

        Dim g = New Grafik()
        g.Farbe = "Rot"

        Lackieren(f)
        Lackieren(g)

        Console.ReadLine()

    End Sub

    Public Sub Lackieren(o As ILackierbar)
        o.Farbe = "neue Farbe"
    End Sub

End Module
