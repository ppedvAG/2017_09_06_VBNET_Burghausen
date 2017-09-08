Public Class Audio
    Implements IMedia

    Public Function Playmedia() As String Implements IMedia.Playmedia
        Return $"{Me.GetType().Name}: Audio wird gestartet."
    End Function

    Public Function Stopmedia() As String Implements IMedia.Stopmedia
        Return $"{Me.GetType().Name}: Audio wird gestoppt."
    End Function

    Public Function Displaymedia() As String Implements IMedia.Displaymedia
        Return $"{Me.GetType().Name}: Displaymedia() wird nicht unterstützt."
    End Function

    Public Function Whatever() As String
        Return "Der neue Text"
    End Function
End Class
