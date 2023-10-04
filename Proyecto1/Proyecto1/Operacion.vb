Imports Microsoft.VisualBasic

Public Class Operacion

    Public Function sumar(valor1 As String, valor2 As String, valor3 As String) As Integer
        'Dim res As Integer
        '   res = Val(valor1) + Val(valor2)
        'Return res
        'End Function

        Dim res As Integer

        Select Case valor2
            Case "+"
                res = Val(valor1) + Val(valor3)
            Case "-"
                res = Val(valor1) - Val(valor3)
            Case "*"
                res = Val(valor1) * Val(valor3)
            Case "/"
                If Val(valor2) <> 0 Then
                    res = Val(valor1) / Val(valor3)
                Else
                    Throw New DivideByZeroException("No se puede dividir por cero.")
                End If
            Case Else
                Throw New ArgumentException("Operador no válido. Los operadores válidos son +, -, *, y /.")
        End Select

        Return res
    End Function
End Class
