Public Class Form1
    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        Dim entero As Integer ' = 384  '4 bytes
        Dim largo As Long = 342838.4323432  '8 bytes
        Dim doble As Double = 342.353  ' 8 bytes
        Dim dec As Decimal = 3423532.452343 ' 16 bytes
        Dim cadena As String = "hola mundo"

        'entero = 923.82583

        txt_integer.Text = entero
        txt_Long.Text = largo
        txt_Double.Text = doble
        txt_Decimal.Text = dec

        txt_String.Text = cadena




    End Sub
End Class
