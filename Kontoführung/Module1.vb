Option Strict On
Imports System.Text

Module Module1

    Sub Main()
        Console.OutputEncoding = Encoding.UTF8

        Dim girokonto = New Konto(5000)

        While True

            Console.WriteLine()
            Console.WriteLine($"Aktueller Kontostand: {girokonto.Kontostand}€")
            Console.Write("(1) Einzahlen | (2) Auszahlen | (0) Beenden : ")
            Dim eingabe = Console.ReadLine()

            Select Case eingabe
                Case "0" : Return

                Case "1"
                    Console.Write("Betrag einzahlen: ")
                    eingabe = Console.ReadLine()
                    girokonto.Einzahlen(CDec(eingabe))

                Case "2"
                    Console.Write("Betrag auszahlen: ")
                    eingabe = Console.ReadLine()
                    girokonto.Auszaheln(CDec(eingabe))

                Case Else
                    Console.WriteLine("Ungültige Eingabe.")

            End Select

        End While

    End Sub

End Module
