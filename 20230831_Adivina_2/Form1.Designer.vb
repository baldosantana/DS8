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
        Me.lbl_Computadora = New System.Windows.Forms.Label()
        Me.txt_Computadora = New System.Windows.Forms.TextBox()
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.lbl_Usuario = New System.Windows.Forms.Label()
        Me.txt_Usuario = New System.Windows.Forms.TextBox()
        Me.lbl_Mensaje = New System.Windows.Forms.Label()
        Me.txt_Mensaje = New System.Windows.Forms.TextBox()
        Me.btn_Validar = New System.Windows.Forms.Button()
        Me.lbl_Intentos = New System.Windows.Forms.Label()
        Me.txt_Intentos = New System.Windows.Forms.TextBox()
        Me.txt_Valida = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(275, 27)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(210, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Adivina Número"
        '
        'lbl_Computadora
        '
        Me.lbl_Computadora.AutoSize = True
        Me.lbl_Computadora.Location = New System.Drawing.Point(154, 93)
        Me.lbl_Computadora.Name = "lbl_Computadora"
        Me.lbl_Computadora.Size = New System.Drawing.Size(81, 15)
        Me.lbl_Computadora.TabIndex = 1
        Me.lbl_Computadora.Text = "Computadora"
        '
        'txt_Computadora
        '
        Me.txt_Computadora.Location = New System.Drawing.Point(264, 85)
        Me.txt_Computadora.Name = "txt_Computadora"
        Me.txt_Computadora.Size = New System.Drawing.Size(100, 23)
        Me.txt_Computadora.TabIndex = 2
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(410, 89)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 3
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'lbl_Usuario
        '
        Me.lbl_Usuario.AutoSize = True
        Me.lbl_Usuario.Location = New System.Drawing.Point(162, 142)
        Me.lbl_Usuario.Name = "lbl_Usuario"
        Me.lbl_Usuario.Size = New System.Drawing.Size(47, 15)
        Me.lbl_Usuario.TabIndex = 4
        Me.lbl_Usuario.Text = "Usuario"
        '
        'txt_Usuario
        '
        Me.txt_Usuario.Location = New System.Drawing.Point(264, 132)
        Me.txt_Usuario.Name = "txt_Usuario"
        Me.txt_Usuario.Size = New System.Drawing.Size(100, 23)
        Me.txt_Usuario.TabIndex = 5
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.AutoSize = True
        Me.lbl_Mensaje.Location = New System.Drawing.Point(162, 178)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(51, 15)
        Me.lbl_Mensaje.TabIndex = 6
        Me.lbl_Mensaje.Text = "Mensaje"
        '
        'txt_Mensaje
        '
        Me.txt_Mensaje.Enabled = False
        Me.txt_Mensaje.Location = New System.Drawing.Point(264, 175)
        Me.txt_Mensaje.Name = "txt_Mensaje"
        Me.txt_Mensaje.Size = New System.Drawing.Size(100, 23)
        Me.txt_Mensaje.TabIndex = 7
        '
        'btn_Validar
        '
        Me.btn_Validar.Location = New System.Drawing.Point(410, 138)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Validar.TabIndex = 8
        Me.btn_Validar.Text = "Validar"
        Me.btn_Validar.UseVisualStyleBackColor = True
        '
        'lbl_Intentos
        '
        Me.lbl_Intentos.AutoSize = True
        Me.lbl_Intentos.Location = New System.Drawing.Point(171, 223)
        Me.lbl_Intentos.Name = "lbl_Intentos"
        Me.lbl_Intentos.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Intentos.TabIndex = 9
        Me.lbl_Intentos.Text = "Intentos"
        '
        'txt_Intentos
        '
        Me.txt_Intentos.Enabled = False
        Me.txt_Intentos.Location = New System.Drawing.Point(266, 223)
        Me.txt_Intentos.Name = "txt_Intentos"
        Me.txt_Intentos.Size = New System.Drawing.Size(100, 23)
        Me.txt_Intentos.TabIndex = 10
        '
        'txt_Valida
        '
        Me.txt_Valida.Location = New System.Drawing.Point(519, 86)
        Me.txt_Valida.Name = "txt_Valida"
        Me.txt_Valida.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valida.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_Valida)
        Me.Controls.Add(Me.txt_Intentos)
        Me.Controls.Add(Me.lbl_Intentos)
        Me.Controls.Add(Me.btn_Validar)
        Me.Controls.Add(Me.txt_Mensaje)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Controls.Add(Me.txt_Usuario)
        Me.Controls.Add(Me.lbl_Usuario)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.txt_Computadora)
        Me.Controls.Add(Me.lbl_Computadora)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Computadora As Label
    Friend WithEvents txt_Computadora As TextBox
    Friend WithEvents btn_Iniciar As Button
    Friend WithEvents lbl_Usuario As Label
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents lbl_Mensaje As Label
    Friend WithEvents txt_Mensaje As TextBox
    Friend WithEvents btn_Validar As Button
    Friend WithEvents lbl_Intentos As Label
    Friend WithEvents txt_Intentos As TextBox
    Friend WithEvents txt_Valida As TextBox
End Class
