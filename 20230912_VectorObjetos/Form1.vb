Public Class Form1
    Dim vtxt_Valor(4) As TextBox

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vtxt_Valor(1) = txt_Valor1
        vtxt_Valor(2) = txt_Valor2
        vtxt_Valor(3) = txt_Valor3
        vtxt_Valor(4) = txt_Valor4
    End Sub

    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        txt_Valor1.Text = "Hola 1"
        txt_Valor2.Text = "Hola 2"
        txt_Valor3.Text = "Hola 3"
        txt_Valor4.Text = "Hola 4"
    End Sub

    Private Sub btn_Vector_Click(sender As Object, e As EventArgs) Handles btn_Vector.Click
        For i = 1 To 4
            vtxt_Valor(i).Text = "Vector " + i.ToString()
        Next
    End Sub

    Private Sub btn_CargarInd_Click(sender As Object, e As EventArgs) Handles btn_CargarInd.Click
        vtxt_Valor(CInt(txt_Indice.Text)).Text = "Indice " + txt_Indice.Text
    End Sub

    Private Sub btn_1x1_Click(sender As Object, e As EventArgs) Handles btn_1x1.Click
        vtxt_Valor(CInt(txt_Indice.Text)).Text = "Indice " + txt_Indice.Text
        txt_Indice.Text = Val(txt_Indice.Text) + 1
        If txt_Indice.Text > "4" Then
            txt_Indice.Text = "1"
        End If
    End Sub
End Class
