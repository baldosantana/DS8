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
        Me.txt_Num1 = New System.Windows.Forms.TextBox()
        Me.lbl_Num2 = New System.Windows.Forms.Label()
        Me.txt_Num2 = New System.Windows.Forms.TextBox()
        Me.lbl_Res = New System.Windows.Forms.Label()
        Me.txt_Res = New System.Windows.Forms.TextBox()
        Me.btn_Sumar = New System.Windows.Forms.Button()
        Me.btn_Restar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(294, 36)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(91, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Clases"
        '
        'lbl_Num1
        '
        Me.lbl_Num1.AutoSize = True
        Me.lbl_Num1.Location = New System.Drawing.Point(86, 123)
        Me.lbl_Num1.Name = "lbl_Num1"
        Me.lbl_Num1.Size = New System.Drawing.Size(40, 15)
        Me.lbl_Num1.TabIndex = 1
        Me.lbl_Num1.Text = "Num1"
        '
        'txt_Num1
        '
        Me.txt_Num1.Location = New System.Drawing.Point(168, 115)
        Me.txt_Num1.Name = "txt_Num1"
        Me.txt_Num1.Size = New System.Drawing.Size(100, 23)
        Me.txt_Num1.TabIndex = 2
        '
        'lbl_Num2
        '
        Me.lbl_Num2.AutoSize = True
        Me.lbl_Num2.Location = New System.Drawing.Point(86, 168)
        Me.lbl_Num2.Name = "lbl_Num2"
        Me.lbl_Num2.Size = New System.Drawing.Size(40, 15)
        Me.lbl_Num2.TabIndex = 3
        Me.lbl_Num2.Text = "Num2"
        '
        'txt_Num2
        '
        Me.txt_Num2.Location = New System.Drawing.Point(168, 160)
        Me.txt_Num2.Name = "txt_Num2"
        Me.txt_Num2.Size = New System.Drawing.Size(100, 23)
        Me.txt_Num2.TabIndex = 4
        '
        'lbl_Res
        '
        Me.lbl_Res.AutoSize = True
        Me.lbl_Res.Location = New System.Drawing.Point(86, 210)
        Me.lbl_Res.Name = "lbl_Res"
        Me.lbl_Res.Size = New System.Drawing.Size(25, 15)
        Me.lbl_Res.TabIndex = 5
        Me.lbl_Res.Text = "Res"
        '
        'txt_Res
        '
        Me.txt_Res.Location = New System.Drawing.Point(168, 207)
        Me.txt_Res.Name = "txt_Res"
        Me.txt_Res.Size = New System.Drawing.Size(100, 23)
        Me.txt_Res.TabIndex = 6
        '
        'btn_Sumar
        '
        Me.btn_Sumar.Location = New System.Drawing.Point(167, 260)
        Me.btn_Sumar.Name = "btn_Sumar"
        Me.btn_Sumar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sumar.TabIndex = 7
        Me.btn_Sumar.Text = "Sumar"
        Me.btn_Sumar.UseVisualStyleBackColor = True
        '
        'btn_Restar
        '
        Me.btn_Restar.Location = New System.Drawing.Point(270, 260)
        Me.btn_Restar.Name = "btn_Restar"
        Me.btn_Restar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Restar.TabIndex = 8
        Me.btn_Restar.Text = "Restar"
        Me.btn_Restar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Restar)
        Me.Controls.Add(Me.btn_Sumar)
        Me.Controls.Add(Me.txt_Res)
        Me.Controls.Add(Me.lbl_Res)
        Me.Controls.Add(Me.txt_Num2)
        Me.Controls.Add(Me.lbl_Num2)
        Me.Controls.Add(Me.txt_Num1)
        Me.Controls.Add(Me.lbl_Num1)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Num1 As Label
    Friend WithEvents txt_Num1 As TextBox
    Friend WithEvents lbl_Num2 As Label
    Friend WithEvents txt_Num2 As TextBox
    Friend WithEvents lbl_Res As Label
    Friend WithEvents txt_Res As TextBox
    Friend WithEvents btn_Sumar As Button
    Friend WithEvents btn_Restar As Button
End Class
