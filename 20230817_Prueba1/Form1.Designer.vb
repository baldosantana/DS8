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
        Me.lbl_Num1 = New System.Windows.Forms.Label()
        Me.lbl_Num2 = New System.Windows.Forms.Label()
        Me.txt_Num1 = New System.Windows.Forms.TextBox()
        Me.txt_Num2 = New System.Windows.Forms.TextBox()
        Me.lbl_res = New System.Windows.Forms.Label()
        Me.txt_Resultado = New System.Windows.Forms.TextBox()
        Me.btn_Sumar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(240, 20)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(196, 45)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Calculadora"
        '
        'lbl_Num1
        '
        Me.lbl_Num1.AutoSize = True
        Me.lbl_Num1.Location = New System.Drawing.Point(121, 128)
        Me.lbl_Num1.Name = "lbl_Num1"
        Me.lbl_Num1.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Num1.TabIndex = 1
        Me.lbl_Num1.Text = "Numero 1"
        '
        'lbl_Num2
        '
        Me.lbl_Num2.AutoSize = True
        Me.lbl_Num2.Location = New System.Drawing.Point(121, 178)
        Me.lbl_Num2.Name = "lbl_Num2"
        Me.lbl_Num2.Size = New System.Drawing.Size(60, 15)
        Me.lbl_Num2.TabIndex = 2
        Me.lbl_Num2.Text = "Numero 2"
        '
        'txt_Num1
        '
        Me.txt_Num1.Location = New System.Drawing.Point(227, 120)
        Me.txt_Num1.Name = "txt_Num1"
        Me.txt_Num1.Size = New System.Drawing.Size(100, 23)
        Me.txt_Num1.TabIndex = 3
        '
        'txt_Num2
        '
        Me.txt_Num2.Location = New System.Drawing.Point(227, 170)
        Me.txt_Num2.Name = "txt_Num2"
        Me.txt_Num2.Size = New System.Drawing.Size(100, 23)
        Me.txt_Num2.TabIndex = 4
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.Location = New System.Drawing.Point(121, 225)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(59, 15)
        Me.lbl_res.TabIndex = 5
        Me.lbl_res.Text = "Resultado"
        '
        'txt_Resultado
        '
        Me.txt_Resultado.Location = New System.Drawing.Point(227, 225)
        Me.txt_Resultado.Name = "txt_Resultado"
        Me.txt_Resultado.Size = New System.Drawing.Size(100, 23)
        Me.txt_Resultado.TabIndex = 6
        '
        'btn_Sumar
        '
        Me.btn_Sumar.Location = New System.Drawing.Point(227, 294)
        Me.btn_Sumar.Name = "btn_Sumar"
        Me.btn_Sumar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sumar.TabIndex = 7
        Me.btn_Sumar.Text = "Sumar"
        Me.btn_Sumar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Sumar)
        Me.Controls.Add(Me.txt_Resultado)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.txt_Num2)
        Me.Controls.Add(Me.txt_Num1)
        Me.Controls.Add(Me.lbl_Num2)
        Me.Controls.Add(Me.lbl_Num1)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Num1 As Label
    Friend WithEvents lbl_Num2 As Label
    Friend WithEvents txt_Num1 As TextBox
    Friend WithEvents txt_Num2 As TextBox
    Friend WithEvents lbl_res As Label
    Friend WithEvents txt_Resultado As TextBox
    Friend WithEvents btn_Sumar As Button
End Class
