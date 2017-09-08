Module Module1

    Sub Main()

        Dim day = GetDay()


        Dim key = Console.ReadKey().Key

        Console.ForegroundColor = ConsoleColor.DarkMagenta


        Select Case (day)
            Case Wochentag.Montag

            Case Wochentag.Dienstag
        End Select

    End Sub

    Public Function GetDay() As Wochentag
        'irgend eine komplexe Berechnung....
        Return Wochentag.Freitag
    End Function

End Module
