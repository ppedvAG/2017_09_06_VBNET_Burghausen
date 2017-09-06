Option Strict On

Module Module1

    Sub Main()
        Console.WriteLine("Hallo VB")

        Dim _byte As Byte   '0...255
        Dim a As Short      'int16
        Dim b As Integer    'int32
        Dim c As Long       'int64

        Dim s As Single     'float
        Dim d As Double
        Dim dec As Decimal  'wird intern im Decimalsystem berechnet

        Dim bedingung As Boolean    'True oder False
        Dim textZeichen As Char = CChar("a")   'ein einzelnes Textzeichen
        Dim eingabe As String
        eingabe = Console.ReadLine()

        ' Mathematische Operatoren
        b = 4 + 6
        b = 4 - 6
        b = 4 * 6
        b = CInt(13 / 5)      'in VB -> 3 'in C# -> 2
        b = 13 \ 5      'in VB -> 2
        b = 14 Mod 5    '4 -> Rest der ganzahligen Division

        ' Vergleichsoperatoren
        bedingung = 6 > 7
        bedingung = 6 >= 7
        bedingung = 6 < 7
        bedingung = 6 <= 7
        bedingung = 7 = 7           'in C# ==
        bedingung = 7 <> 4          'in C# !=
        bedingung = Not bedingung   'in C# !bedingung

        ' Verküpfungsoperatoren
        bedingung = 5 < 7 And 8 > 6     'in C# &
        bedingung = 5 < 7 Or 8 > 6      'in C# |

        bedingung = 5 < 7 AndAlso 8 > 6      'in C# &&
        bedingung = 5 < 7 OrElse 8 > 6       'in C# ||

        bedingung = 5 < 7 Xor 8 > 6      'in C# ^

        Dim zahl As Integer = CInt("78")
        zahl = Integer.Parse("4")

        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module
