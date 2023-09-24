Public Class Form1
    Private Sub btn_Sumar_Click(sender As Object, e As EventArgs) Handles btn_Sumar.Click
        txt_Resultado.Text = Val(txt_Num1.Text) + Val(txt_Num2.Text)
    End Sub
End Class
