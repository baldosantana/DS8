Public Class Form1
    Private Sub btn_Contar_Click(sender As Object, e As EventArgs) Handles btn_Contar.Click
        txt_Contador.Text = Val(txt_Contador.Text) + 1
        btn_Tag.Tag = "Hola"
        'btn_Tag.Text = "Hola"
    End Sub

    Private Sub btn_Iniciar_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        tmr_Contador.Enabled = True

    End Sub

    Private Sub tmr_Contador_Tick(sender As Object, e As EventArgs) Handles tmr_Contador.Tick
        txt_Contador.Text = Val(txt_Contador.Text) + 1
    End Sub

    Private Sub btn_Detener_Click(sender As Object, e As EventArgs) Handles btn_Detener.Click
        tmr_Contador.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(sender As Object, e As EventArgs) Handles btn_Mostrar.Click
        'txt_Contador.Text = btn_Tag.Text
        txt_Contador.Text = btn_Tag.Tag

    End Sub
End Class
