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
        Me.components = New System.ComponentModel.Container()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.lbl_Contador = New System.Windows.Forms.Label()
        Me.txt_Contador = New System.Windows.Forms.TextBox()
        Me.btn_Contar = New System.Windows.Forms.Button()
        Me.tmr_Contador = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Iniciar = New System.Windows.Forms.Button()
        Me.btn_Detener = New System.Windows.Forms.Button()
        Me.btn_Tag = New System.Windows.Forms.Button()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(256, 48)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(84, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Timer"
        '
        'lbl_Contador
        '
        Me.lbl_Contador.AutoSize = True
        Me.lbl_Contador.Location = New System.Drawing.Point(104, 108)
        Me.lbl_Contador.Name = "lbl_Contador"
        Me.lbl_Contador.Size = New System.Drawing.Size(57, 15)
        Me.lbl_Contador.TabIndex = 1
        Me.lbl_Contador.Text = "Contador"
        '
        'txt_Contador
        '
        Me.txt_Contador.Location = New System.Drawing.Point(200, 100)
        Me.txt_Contador.Name = "txt_Contador"
        Me.txt_Contador.Size = New System.Drawing.Size(100, 23)
        Me.txt_Contador.TabIndex = 2
        '
        'btn_Contar
        '
        Me.btn_Contar.Location = New System.Drawing.Point(331, 104)
        Me.btn_Contar.Name = "btn_Contar"
        Me.btn_Contar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Contar.TabIndex = 3
        Me.btn_Contar.Text = "Contar"
        Me.btn_Contar.UseVisualStyleBackColor = True
        '
        'tmr_Contador
        '
        Me.tmr_Contador.Interval = 200
        '
        'btn_Iniciar
        '
        Me.btn_Iniciar.Location = New System.Drawing.Point(331, 146)
        Me.btn_Iniciar.Name = "btn_Iniciar"
        Me.btn_Iniciar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Iniciar.TabIndex = 4
        Me.btn_Iniciar.Text = "Iniciar"
        Me.btn_Iniciar.UseVisualStyleBackColor = True
        '
        'btn_Detener
        '
        Me.btn_Detener.Location = New System.Drawing.Point(331, 188)
        Me.btn_Detener.Name = "btn_Detener"
        Me.btn_Detener.Size = New System.Drawing.Size(75, 23)
        Me.btn_Detener.TabIndex = 5
        Me.btn_Detener.Text = "Detener"
        Me.btn_Detener.UseVisualStyleBackColor = True
        '
        'btn_Tag
        '
        Me.btn_Tag.Location = New System.Drawing.Point(133, 197)
        Me.btn_Tag.Name = "btn_Tag"
        Me.btn_Tag.Size = New System.Drawing.Size(75, 23)
        Me.btn_Tag.TabIndex = 6
        Me.btn_Tag.Text = "Tag"
        Me.btn_Tag.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Location = New System.Drawing.Point(133, 245)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mostrar.TabIndex = 7
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Controls.Add(Me.btn_Tag)
        Me.Controls.Add(Me.btn_Detener)
        Me.Controls.Add(Me.btn_Iniciar)
        Me.Controls.Add(Me.btn_Contar)
        Me.Controls.Add(Me.txt_Contador)
        Me.Controls.Add(Me.lbl_Contador)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Contador As Label
    Friend WithEvents txt_Contador As TextBox
    Friend WithEvents btn_Contar As Button
    Friend WithEvents tmr_Contador As Timer
    Friend WithEvents btn_Iniciar As Button
    Friend WithEvents btn_Detener As Button
    Friend WithEvents btn_Tag As Button
    Friend WithEvents btn_Mostrar As Button
End Class
