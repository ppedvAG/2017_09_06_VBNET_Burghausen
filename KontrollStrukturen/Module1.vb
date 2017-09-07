Option Strict On

Module Module1

    Sub Main()

        Dim input = CInt(Console.ReadLine())
#Region "If - ElseIf - Else"
        'If input > 10 AndAlso input < 100 Then
        '    Console.WriteLine("Die Eingabe war gößer 10 und kleiner 100.")

        'ElseIf input = 10 Then
        '    Console.WriteLine("Die Eingabe genau 10.")

        'ElseIf input > 10 Then
        '    Console.WriteLine("Die Eingabe war größer 10.")

        'Else
        '    Console.WriteLine("Die Eingabe war nicht größer 10.")

        'End If
#End Region

#Region "Switch"

        'Select Case (input)
        '    Case 5
        '        Console.WriteLine("Es war 5")

        '    Case 12
        '        Console.WriteLine("Der Wert war 12.")

        '    Case > 100
        '        Console.WriteLine("Der Wert war > 100.")

        '    Case 1 To 10
        '        Console.WriteLine("1...10")

        '    Case 11, 13, 15, 17, 19
        '        Console.WriteLine("11, 13, 15, 17 oder 19")

        '    Case Else
        '        Console.WriteLine("War halt nichts passendes dabei.")
        'End Select

#End Region

#Region "While"

        'While input < 100
        '    Console.WriteLine(input)
        '    input += 1
        'End While

#End Region

#Region "Do While"

        'Do
        '    Console.WriteLine(input)
        '    input += 1
        'Loop While input < 100

#End Region

        For i = 0 To 100 Step 5                 'for(int i = 0; i < 100; i++)
            Console.WriteLine(i)                '{.... 
        Next                                    '}

        For i = 100 To 0 Step -1
            Console.WriteLine(i)
        Next

        Console.ReadKey()
    End Sub

End Module