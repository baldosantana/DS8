Public Class Form1
    Private Sub btn_Sumar_Click(sender As Object, e As EventArgs) Handles btn_Sumar.Click
        Dim oOperacion As New Operacion()
        txt_Res.Text = oOperacion.sumar(txt_Num1.Text, txt_Num2.Text)
    End Sub

    Private Sub btn_Restar_Click(sender As Object, e As EventArgs) Handles btn_Restar.Click
        Dim oOperacion As New Operacion()
        txt_Res.Text = oOperacion.restar(txt_Num1.Text, txt_Num2.Text)
    End Sub
End Class
