Public Class Form1
    Dim vbtn_Valor(4) As Button

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vbtn_Valor(1) = vbtn_Valor1
        vbtn_Valor(2) = vbtn_Valor2
        vbtn_Valor(3) = vbtn_Valor3
        vbtn_Valor(4) = vbtn_Valor4
    End Sub

    Dim vbtn_oper(4) As Button

    Public Sub New_Oper()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vbtn_oper(1).Text = "+"
        vbtn_oper(2).Text = "-"
        vbtn_oper(3).Text = "*"
        vbtn_oper(4).Text = "/"
    End Sub

    Dim vtxt_Valor(9) As TextBox

    Public Sub New_txt()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        vtxt_Valor(1) = vtxt_Valor1
        vtxt_Valor(2) = vtxt_Valor2
        vtxt_Valor(3) = vtxt_Valor3
        vtxt_Valor(4) = vtxt_Valor4
        vtxt_Valor(5) = vtxt_Valor5
        vtxt_Valor(6) = vtxt_Valor6
        vtxt_Valor(7) = vtxt_Valor7
        vtxt_Valor(8) = vtxt_Valor8
        vtxt_Valor(9) = vtxt_Valor9
    End Sub

    Private Sub DisableOper()

        For i = 1 To 4
            vbtn_oper(i).Enabled = False
        Next
    End Sub

    Private Sub BorrarTodo()

        For i = 1 To 4
            vtxt_Valor(i).Text = ""
        Next
    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles vtxt_Valor8.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles vbtn_Valor3.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_Iniciar.Click
        Dim rnd As New Random()

        For i = 1 To 4
            vbtn_Valor(i).Text = rnd.Next(1, 5)
        Next
        tmr_Contador.Enabled = True
        btn_Iniciar.Enabled = False


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tmr_Contador_Tick(sender As Object, e As EventArgs) Handles tmr_Contador.Tick
        txt_Contador.Text = Val(txt_Contador.Text) + 1
    End Sub

    Private Sub vbtn_Valor1_Click(sender As Object, e As EventArgs) Handles vbtn_Valor1.Click
        vtxt_Valor1.Text = vbtn_Valor1.Text
    End Sub

    Private Sub vbtn_Valor2_Click(sender As Object, e As EventArgs) Handles vbtn_Valor2.Click

    End Sub

    Private Sub vtxt_Valor3_TextChanged(sender As Object, e As EventArgs) Handles vtxt_Valor3.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_BorrarTodo.Click
        BorrarTodo()
    End Sub
End Class
