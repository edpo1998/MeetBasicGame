Public Class Configuration
    Private _Level As Integer = 0
    Private _Players As Integer = 0
    Private _NoUps As Integer = 0
    Private _NoDowns As Integer = 0

    Private Sub Constructor()
        _Level = 0
        _Players = 0
        _NoUps = 0
        _NoDowns = 0
    End Sub

    Public Function Verify() As Boolean
        If _Level = 0 Or _Players Or _NoUps Or _NoDowns Then
            Console.WriteLine("Faltan parametros de Configuracion!!")
            Return False
        End If
        Return True
    End Function

    Public Property Level As Integer
        Get
            Return _Level
        End Get
        Set(value As Integer)
            _Level = Level
        End Set
    End Property

    Public Property Players As Integer
        Get
            Return _Players
        End Get
        Set(value As Integer)
            _Players = Players
        End Set
    End Property

    Public Property NoUps As Integer
        Get
            Return _NoUps
        End Get
        Set(value As Integer)
            _NoUps = NoUps
        End Set
    End Property

    Public Property NoDowns As Integer
        Get
            Return _NoDowns
        End Get
        Set(value As Integer)
            _NoDowns = NoDowns
        End Set
    End Property


End Class
