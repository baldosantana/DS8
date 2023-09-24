Public Class Form1
    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        Dim rnd As New Random()
        txt_Computadora.Text = rnd.Next(1, 101)
    End Sub

    Private Sub btn_Validar_Click(sender As Object, e As EventArgs) Handles btn_Validar.Click
        If txt_Usuario.Text > txt_Computadora.Text Then
            txt_Mensaje.Text = "Muy Alto"
        ElseIf txt_Usuario.Text < txt_Computadora.Text Then
            txt_Mensaje.Text = "Muy Bajo"
        Else
            txt_Mensaje.Text = "Correcto"
        End If
        txt_Intentos.Text = Val(txt_Intentos.Text) + 1
    End Sub
End Class
