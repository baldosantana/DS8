<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lst_Valor = New System.Windows.Forms.ListBox()
        Me.btn_Cargar = New System.Windows.Forms.Button()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.btn_Listar2 = New System.Windows.Forms.Button()
        Me.txt_Largo = New System.Windows.Forms.TextBox()
        Me.btn_Largo = New System.Windows.Forms.Button()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.lbl_Matriz = New System.Windows.Forms.Label()
        Me.btn_CargarM = New System.Windows.Forms.Button()
        Me.btn_ListarM = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(268, 39)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(92, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Vector"
        '
        'lst_Valor
        '
        Me.lst_Valor.FormattingEnabled = True
        Me.lst_Valor.ItemHeight = 15
        Me.lst_Valor.Location = New System.Drawing.Point(105, 111)
        Me.lst_Valor.Name = "lst_Valor"
        Me.lst_Valor.Size = New System.Drawing.Size(120, 169)
        Me.lst_Valor.TabIndex = 1
        '
        'btn_Cargar
        '
        Me.btn_Cargar.Location = New System.Drawing.Point(255, 111)
        Me.btn_Cargar.Name = "btn_Cargar"
        Me.btn_Cargar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Cargar.TabIndex = 2
        Me.btn_Cargar.Text = "Cargar"
        Me.btn_Cargar.UseVisualStyleBackColor = True
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(259, 155)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 3
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'btn_Listar2
        '
        Me.btn_Listar2.Location = New System.Drawing.Point(360, 155)
        Me.btn_Listar2.Name = "btn_Listar2"
        Me.btn_Listar2.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar2.TabIndex = 4
        Me.btn_Listar2.Text = "Listar2"
        Me.btn_Listar2.UseVisualStyleBackColor = True
        '
        'txt_Largo
        '
        Me.txt_Largo.Location = New System.Drawing.Point(364, 112)
        Me.txt_Largo.Name = "txt_Largo"
        Me.txt_Largo.Size = New System.Drawing.Size(100, 23)
        Me.txt_Largo.TabIndex = 5
        '
        'btn_Largo
        '
        Me.btn_Largo.Location = New System.Drawing.Point(483, 111)
        Me.btn_Largo.Name = "btn_Largo"
        Me.btn_Largo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Largo.TabIndex = 6
        Me.btn_Largo.Text = "Largo"
        Me.btn_Largo.UseVisualStyleBackColor = True
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Location = New System.Drawing.Point(133, 83)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Limpiar.TabIndex = 7
        Me.btn_Limpiar.Text = "Limpiar"
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'lbl_Matriz
        '
        Me.lbl_Matriz.AutoSize = True
        Me.lbl_Matriz.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Matriz.Location = New System.Drawing.Point(279, 194)
        Me.lbl_Matriz.Name = "lbl_Matriz"
        Me.lbl_Matriz.Size = New System.Drawing.Size(92, 37)
        Me.lbl_Matriz.TabIndex = 8
        Me.lbl_Matriz.Text = "Matriz"
        '
        'btn_CargarM
        '
        Me.btn_CargarM.Location = New System.Drawing.Point(263, 245)
        Me.btn_CargarM.Name = "btn_CargarM"
        Me.btn_CargarM.Size = New System.Drawing.Size(75, 23)
        Me.btn_CargarM.TabIndex = 9
        Me.btn_CargarM.Text = "CargarM"
        Me.btn_CargarM.UseVisualStyleBackColor = True
        '
        'btn_ListarM
        '
        Me.btn_ListarM.Location = New System.Drawing.Point(360, 245)
        Me.btn_ListarM.Name = "btn_ListarM"
        Me.btn_ListarM.Size = New System.Drawing.Size(75, 23)
        Me.btn_ListarM.TabIndex = 10
        Me.btn_ListarM.Text = "ListarM"
        Me.btn_ListarM.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_ListarM)
        Me.Controls.Add(Me.btn_CargarM)
        Me.Controls.Add(Me.lbl_Matriz)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.btn_Largo)
        Me.Controls.Add(Me.txt_Largo)
        Me.Controls.Add(Me.btn_Listar2)
        Me.Controls.Add(Me.btn_Listar)
        Me.Controls.Add(Me.btn_Cargar)
        Me.Controls.Add(Me.lst_Valor)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lst_Valor As ListBox
    Friend WithEvents btn_Cargar As Button
    Friend WithEvents btn_Listar As Button
    Friend WithEvents btn_Listar2 As Button
    Friend WithEvents txt_Largo As TextBox
    Friend WithEvents btn_Largo As Button
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents lbl_Matriz As Label
    Friend WithEvents btn_CargarM As Button
    Friend WithEvents btn_ListarM As Button
End Class
