Module Module1

    Sub Main()

        Dim p = New Picture()
        Dim v = New Video()
        Dim a = New Audio()

        Console.WriteLine()
        Console.WriteLine("Medium 1:")
        UseMedia(p)

        Console.WriteLine()
        Console.WriteLine("Medium 2:")
        UseMedia(v)

        Console.WriteLine()
        Console.WriteLine("Medium 3:")
        UseMedia(a)
        Console.WriteLine(a.Whatever())

        Console.ReadLine()
    End Sub

    Public Sub UseMedia(media As IMedia)
        Console.WriteLine(media.Displaymedia())
        Console.WriteLine(media.Playmedia())
        Console.WriteLine(media.Stopmedia())
    End Sub

End Module
