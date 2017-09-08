Public Class Video
    Implements IMedia

    Public Function Playmedia() As String Implements IMedia.Playmedia
        Return $"{Me.GetType().Name}: Video wird gestartet."
    End Function

    Public Function Stopmedia() As String Implements IMedia.Stopmedia
        Return $"{Me.GetType().Name}: Bild wird ausgeblendet."
    End Function

    Public Function Displaymedia() As String Implements IMedia.Displaymedia
        Return $"{Me.GetType().Name}: Video wird angezeigt."
    End Function
End Class
