Imports System.Threading

Module Module1

    Sub Main()
        Dim ergebnis = Rechner.Add(7, 9)

        'Dim r = New Rechner()
        'Dim r1 = New Rechner()
        'Dim r2 = New Rechner()
        'Dim r3 = New Rechner()
        ergebnis = Rechner.Subtract(4, 8)

        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("bla bla Blue")

        FurElise()

        Console.ReadLine()
    End Sub

    ' http://flanders.co.nz/2008/10/22/if-you-ever-wanted-to-play-fur-elise-in-the-console/
    Private Sub FurElise()
        Console.Beep(420, 200)
        Console.Beep(400, 200)
        Console.Beep(420, 200)
        Console.Beep(400, 200)
        Console.Beep(420, 200)
        Console.Beep(315, 200)
        Console.Beep(370, 200)
        Console.Beep(335, 200)
        Console.Beep(282, 600)
        Console.Beep(180, 200)
        Console.Beep(215, 200)
        Console.Beep(282, 200)
        Console.Beep(315, 600)
        Console.Beep(213, 200)
        Console.Beep(262, 200)
        Console.Beep(315, 200)
        Console.Beep(335, 600)
        Console.Beep(213, 200)
        Console.Beep(420, 200)
        Console.Beep(400, 200)
        Console.Beep(420, 200)
        Console.Beep(400, 200)
        Console.Beep(420, 200)
        Console.Beep(315, 200)
        Console.Beep(370, 200)
        Console.Beep(335, 200)
        Console.Beep(282, 600)
        Console.Beep(180, 200)
        Console.Beep(215, 200)
        Console.Beep(282, 200)
        Console.Beep(315, 600)
        Console.Beep(213, 200)
        Console.Beep(330, 200)
        Console.Beep(315, 200)
        Console.Beep(282, 600)
    End Sub

End Module
