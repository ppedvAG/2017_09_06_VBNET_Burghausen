Public Class Cabrio
    Inherits PKW

    Public Sub New(sitzplätze As Integer)
        MyBase.New(sitzplätze)
    End Sub

    Private _dachart As String
    Public Property Dachart As String
        Get
            Return _dachart
        End Get
        Set(value As String)
            _dachart = value
        End Set
    End Property
End Class
