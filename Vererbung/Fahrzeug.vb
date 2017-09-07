Option Strict On

Public Class Fahrzeug
    Private _geschwindigkeit As Integer
    Public Property Geschwindigkeit As Integer
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

    Public Sub Beschleunigen(dV As Integer)
        Geschwindigkeit += dV
    End Sub

    Public Sub Bremsen(dV As Integer)
        Geschwindigkeit -= dV
    End Sub
End Class
