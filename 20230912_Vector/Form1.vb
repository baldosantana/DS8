Public Class Form1
    Dim vector(10) As String
    Dim matriz(3, 3) As String
    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        For i = 0 To 10
            vector(i) = i
        Next
    End Sub

    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        For i = 0 To 10
            lst_Valor.Items.Add(vector(i))
        Next
    End Sub

    Private Sub btn_Listar2_Click(sender As Object, e As EventArgs) Handles btn_Listar2.Click
        For i = 0 To vector.Length() - 1
            lst_Valor.Items.Add(vector(i))
        Next
    End Sub

    Private Sub btn_Largo_Click(sender As Object, e As EventArgs) Handles btn_Largo.Click
        txt_Largo.Text = vector.Length()
    End Sub

    Private Sub btn_Limpiar_Click(sender As Object, e As EventArgs) Handles btn_Limpiar.Click
        lst_Valor.Items.Clear()
    End Sub

    Private Sub btn_CargarM_Click(sender As Object, e As EventArgs) Handles btn_CargarM.Click
        For i = 0 To 3
            For j = 0 To 3
                matriz(i, j) = i.ToString + "," + j.ToString()
            Next
        Next
    End Sub

    Private Sub btn_ListarM_Click(sender As Object, e As EventArgs) Handles btn_ListarM.Click
        For i = 0 To 3
            For j = 0 To 3
                lst_Valor.Items.Add(matriz(i, j))
            Next
        Next
    End Sub
End Class
