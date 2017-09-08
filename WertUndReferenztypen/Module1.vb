Module Module1

    Sub Main()

        ' Objekte von Strukturen sind Werttypen         ValueTypes
        ' Objekte von Klassen sind Referenztpyen        ReferenceTypes
        ' Einzige Ausnahme: String

        Console.WriteLine($"{vbNewLine}{vbNewLine}{vbNewLine}------------ Werttypen")

        Dim zahl1 = 5
        Dim zahl2 = zahl1

        Console.WriteLine($"Zahl1: {zahl1}")
        Console.WriteLine($"Zahl2: {zahl2}")

        Console.WriteLine("Zahl2 ändern")
        zahl2 = 100

        Console.WriteLine($"Zahl1: {zahl1}")
        Console.WriteLine($"Zahl2: {zahl2}")

        Console.WriteLine($"{vbNewLine}{vbNewLine}{vbNewLine}------------ Referenztypen")

        Dim auto1 As Fahrzeug = New Fahrzeug()
        auto1.Geschwindikeit = 50
        Dim auto2 = auto1

        Console.WriteLine($"Auto1: {auto1.Geschwindikeit}")
        Console.WriteLine($"Auto2: {auto2.Geschwindikeit}")

        Console.WriteLine("Auto2 ändern")
        auto2.Geschwindikeit = 130

        Console.WriteLine($"Auto1: {auto1.Geschwindikeit}")
        Console.WriteLine($"Auto2: {auto2.Geschwindikeit}")

        Console.ReadLine()
    End Sub

End Module
