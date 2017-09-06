Module Module1

    Sub Main()

#Region "Übung 1"
        'Dim input = CInt(Console.ReadLine())

        'If input >= 7 Then
        '    Console.WriteLine("Der Test ist Bestanden!")

        'ElseIf input < 7 Then
        '    Console.WriteLine("Der Test ist leider nicht Bestanden!")

        'End If
#End Region

#Region "Übung 2"

        'While True
        '    Dim input = CInt(Console.ReadLine())

        '    If input = -1 Then Exit While

        '    If input >= 7 AndAlso input <= 10 Then
        '        Console.WriteLine("Test bestanden!")
        '    ElseIf input >= 0 AndAlso input <= 6 Then
        '        Console.WriteLine("Test nicht bestanden!")
        '    Else
        '        Console.WriteLine("Ungültige Eingabe!")
        '    End If

        'End While

#End Region

#Region "Übung 3"

        While True

            Dim input = CInt(Console.ReadLine())

            Select Case (input)
                Case -1 : Exit While

                Case 0 To 6 : Console.WriteLine("Nicht genügend Punkte")
                Case 7 : Console.WriteLine("Ausreichend")
                Case 8 : Console.WriteLine("Befriedigend")
                Case 9 : Console.WriteLine("Gut")
                Case 10 : Console.WriteLine("Sehr Gut")

                Case Else : Console.WriteLine("Ungültige Eingabe")
            End Select
        End While

#End Region

    End Sub

End Module
