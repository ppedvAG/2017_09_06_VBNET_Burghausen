﻿Public Class Fahrzeug
    Implements ILackierbar

    Private _farbe As String
    Public Property Farbe As String Implements ILackierbar.Farbe
        Get
            Return _farbe
        End Get
        Set(value As String)
            _farbe = value
        End Set
    End Property


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


    Public Sub Beschleunigen(dV As Integer)
        Geschwindigkeit += dV
    End Sub

    Public Sub Bremsen(dV As Integer)
        Geschwindigkeit -= dV
    End Sub

End Class
