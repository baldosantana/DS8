Public Class Operacion
    Public Function sumar(valor1 As String, valor2 As String) As Integer
        Dim res As Integer
        res = Val(valor1) + Val(valor2)
        Return res
    End Function

    Public Function restar(valor1 As String, valor2 As String) As Integer
        Dim res As Integer
        res = Val(valor1) - Val(valor2)
        Return res
    End Function
End Class
