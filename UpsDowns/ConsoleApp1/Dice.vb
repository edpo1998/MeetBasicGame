Public Class Dice
    Private _Dimention As Integer
    Private _currentVal As Integer
    Shared random As New Random
    Public Sub New(ByVal Dimention)
        _Dimention = Dimention
    End Sub

    Public Sub ThrowDice()
        _currentVal = random.Next(1, _Dimention + 1)
        Console.WriteLine("Valor del dado: " + CStr(_currentVal))
    End Sub

End Class
