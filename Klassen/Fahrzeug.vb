Public Class Fahrzeug

    'Public Sub New()

    'End Sub
    Public Sub New(baujahr As Integer)
        Me.Baujahr = baujahr
    End Sub
    Public Sub New(farbe As String)
        Me.Farbe = farbe
    End Sub
    Public Sub New(baujahr As Integer, farbe As String)
        Me.New(baujahr)
        Me.Farbe = farbe
    End Sub
    Public Sub New(baujahr As Integer, farbe As String, leistung As Integer)
        Me.New(baujahr, farbe)
        Me.Leistung = leistung
    End Sub

    'Im Feld sind die Daten gepeichert.
    Private _geschwindigkeit As Integer       'Feld
    'Das Property regelt den Zugriff auf das dahinterliegende Feld.
    Public Property Geschwindigkeit As Integer    ' Property
        Get
            Return _geschwindigkeit
        End Get
        Set(value As Integer)
            If value > 200 Then
                value = 200
            ElseIf value < 0 Then
                value = 0
            End If

            _geschwindigkeit = value
        End Set
    End Property

    Private _farbe As String
    Public Property Farbe As String
        Get
            Return _farbe
        End Get
        Set(value As String)
            Select Case (value)
                Case "Rot", "Blau", "Gelb", "Grün"
                    _farbe = value
                Case Else
                    _farbe = "Ungültige Farbe"
            End Select
        End Set
    End Property

    Private _baujahr As Integer
    Public Property Baujahr As Integer
        Get
            Return _baujahr
        End Get
        Set(value As Integer)
            If value >= 1886 AndAlso value <= Date.Now.Year Then
                _baujahr = value
            End If
        End Set
    End Property

    Private _leistung As Integer
    Public Property Leistung As Integer
        Get
            Return _leistung
        End Get
        Set(value As Integer)
            _leistung = value
        End Set
    End Property

#Region "Datenkapselung in Java"
    'Public Sub SetGeschwindigkeit(geschwindigkeit As Integer)

    '    If geschwindigkeit > 200 Then
    '        geschwindigkeit = 200
    '    End If

    '    _geschwindigkeit = geschwindigkeit
    'End Sub
    'Public Function GetGeschwingikeit() As Integer
    '    Return _geschwindigkeit
    'End Function
#End Region

    ' Methoden überladen

    ''' <summary>
    ''' Beschleunigt das Fahrzeug um 10.
    ''' </summary>
    Public Sub Beschleunigen()
        Beschleunigen(10)
    End Sub
    ''' <summary>
    ''' Beschleunigt das Fahrzeug um den übergebenen Wert.
    ''' </summary>
    ''' <param name="dV">Die Geschwindigkeitsänderung</param>
    Public Sub Beschleunigen(dV As Integer)
        Geschwindigkeit += dV
    End Sub
    Public Sub Beschleunigen(faktor As Double)
        Geschwindigkeit = CInt(Geschwindigkeit * faktor)
    End Sub
    Public Sub Beschleunigen(dv As Integer, text As String)

    End Sub
    Public Sub Beschleunigen(text As String, dv As Integer)

    End Sub

    Public Sub Bremsen(dV As Integer)
        Geschwindigkeit -= dV
    End Sub

End Class
