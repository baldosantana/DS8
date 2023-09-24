Public Class Form1
    Private Sub btn_CF_Click(sender As Object, e As EventArgs) Handles btn_CF.Click
        txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
    End Sub

    Private Sub btn_FC_Click(sender As Object, e As EventArgs) Handles btn_FC.Click
        txt_C.Text = (Val(txt_F.Text) - 32) / (9 / 5)
    End Sub

    Private Sub txt_C_TextChanged(sender As Object, e As EventArgs) Handles txt_C.TextChanged
        txt_F.Text = Val(txt_C.Text) * 9 / 5 + 32
    End Sub

    Private Sub hsb_Valor_Scroll(sender As Object, e As ScrollEventArgs) Handles hsb_Valor.Scroll
        txt_C.Text = hsb_Valor.Value
    End Sub

    Private Sub vsb_Valor_Scroll(sender As Object, e As ScrollEventArgs) Handles vsb_Valor.Scroll
        txt_C.Text = vsb_Valor.Value
    End Sub
End Class
