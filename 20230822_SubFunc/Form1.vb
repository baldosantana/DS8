Public Class Form1
    Private Sub btn_Sub01_Click(sender As Object, e As EventArgs) Handles btn_Sub01.Click
        Sub01()
    End Sub

    Private Sub Sub01()
        txt_Valor.Text = "Sub 01"
    End Sub

    Private Sub btn_SubPar_Click(sender As Object, e As EventArgs) Handles btn_SubPar.Click
        Sub01("Sub02 con Parametros")
    End Sub

    Private Sub Sub01(texto As String)
        txt_Valor.Text = texto
    End Sub

    Private Sub btn_Func01_Click(sender As Object, e As EventArgs) Handles btn_Func01.Click
        txt_Valor.Text = Func01()
    End Sub
    Private Function Func01() As String
        Dim cadena As String
        cadena = "Funcion 01"
        Return cadena
    End Function

    Private Sub btn_FunPar_Click(sender As Object, e As EventArgs) Handles btn_FunPar.Click
        txt_Valor.Text = Func02(2)
    End Sub
    Private Function Func02(num As Integer) As String
        Dim color As String
        If num = 1 Then
            color = "rojo"
        End If
        If num = 2 Then
            color = "verde"
        End If
        Return color
    End Function
End Class
