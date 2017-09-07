Option Strict On

Module Module1

    Public Sub Main()
        'OptionaleParameter("Hallo")
        'OptionaleParameter("Hallo", 10)
        'OptionaleParameter("Hallo", 12)
        'OptionaleParameter("Hallo", 12.4, 9)

        'Dim t1 = "Hallo"
        'Dim t2 = "Welt"

        'Console.WriteLine("Vor dem Vertauschen:")
        'Console.WriteLine(t1)
        'Console.WriteLine(t2)

        'SwapText(t1, t2)

        'Console.WriteLine("Nach dem Vertauschen:")
        'Console.WriteLine(t1)
        'Console.WriteLine(t2)

        For i = 0 To 100
            If IsPrime(i) Then
                Console.WriteLine(i)
            End If
        Next

        Console.ReadLine()
    End Sub

    Public Function Addieren(ByVal zahl1 As Integer, ByVal zahl2 As Integer) As Integer
        Console.WriteLine(zahl1)
        Return zahl1 + zahl2
    End Function
    Public Sub OptionaleParameter(text As String, Optional wert As Double = 10.4567, Optional zahl As Integer = 5)

        Console.WriteLine(wert)
        Console.WriteLine(zahl)
        Console.WriteLine()

    End Sub

    Public Sub ReferenzParameter(ByRef zahl As Integer)
        zahl += 90
    End Sub

    Public Sub SwapText(ByRef text1 As String, ByRef text2 As String)
        Dim temp = text1
        text1 = text2
        text2 = temp
    End Sub

    Public Function IsPrime(ByVal value As Integer) As Boolean
        If value < 2 Then
            Return False
        End If

        For index = 2 To (value / 2) + 1 Step 1
            If value Mod index = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

End Module
