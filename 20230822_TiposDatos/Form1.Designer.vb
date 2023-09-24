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
        Me.lbl_Integer = New System.Windows.Forms.Label()
        Me.txt_integer = New System.Windows.Forms.TextBox()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.lbl_Long = New System.Windows.Forms.Label()
        Me.txt_Long = New System.Windows.Forms.TextBox()
        Me.lbl_Double = New System.Windows.Forms.Label()
        Me.txt_Double = New System.Windows.Forms.TextBox()
        Me.lbl_Decimal = New System.Windows.Forms.Label()
        Me.txt_Decimal = New System.Windows.Forms.TextBox()
        Me.lbl_String = New System.Windows.Forms.Label()
        Me.txt_String = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(232, 25)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(194, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Tipos de Datos"
        '
        'lbl_Integer
        '
        Me.lbl_Integer.AutoSize = True
        Me.lbl_Integer.Location = New System.Drawing.Point(103, 102)
        Me.lbl_Integer.Name = "lbl_Integer"
        Me.lbl_Integer.Size = New System.Drawing.Size(44, 15)
        Me.lbl_Integer.TabIndex = 1
        Me.lbl_Integer.Text = "Integer"
        '
        'txt_integer
        '
        Me.txt_integer.Location = New System.Drawing.Point(204, 94)
        Me.txt_integer.Name = "txt_integer"
        Me.txt_integer.Size = New System.Drawing.Size(100, 23)
        Me.txt_integer.TabIndex = 2
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Location = New System.Drawing.Point(378, 93)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Mostrar.TabIndex = 3
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Long
        '
        Me.lbl_Long.AutoSize = True
        Me.lbl_Long.Location = New System.Drawing.Point(106, 143)
        Me.lbl_Long.Name = "lbl_Long"
        Me.lbl_Long.Size = New System.Drawing.Size(34, 15)
        Me.lbl_Long.TabIndex = 4
        Me.lbl_Long.Text = "Long"
        '
        'txt_Long
        '
        Me.txt_Long.Location = New System.Drawing.Point(204, 143)
        Me.txt_Long.Name = "txt_Long"
        Me.txt_Long.Size = New System.Drawing.Size(100, 23)
        Me.txt_Long.TabIndex = 5
        '
        'lbl_Double
        '
        Me.lbl_Double.AutoSize = True
        Me.lbl_Double.Location = New System.Drawing.Point(106, 204)
        Me.lbl_Double.Name = "lbl_Double"
        Me.lbl_Double.Size = New System.Drawing.Size(45, 15)
        Me.lbl_Double.TabIndex = 6
        Me.lbl_Double.Text = "Double"
        '
        'txt_Double
        '
        Me.txt_Double.Location = New System.Drawing.Point(204, 196)
        Me.txt_Double.Name = "txt_Double"
        Me.txt_Double.Size = New System.Drawing.Size(100, 23)
        Me.txt_Double.TabIndex = 7
        '
        'lbl_Decimal
        '
        Me.lbl_Decimal.AutoSize = True
        Me.lbl_Decimal.Location = New System.Drawing.Point(106, 244)
        Me.lbl_Decimal.Name = "lbl_Decimal"
        Me.lbl_Decimal.Size = New System.Drawing.Size(50, 15)
        Me.lbl_Decimal.TabIndex = 8
        Me.lbl_Decimal.Text = "Decimal"
        '
        'txt_Decimal
        '
        Me.txt_Decimal.Location = New System.Drawing.Point(204, 241)
        Me.txt_Decimal.Name = "txt_Decimal"
        Me.txt_Decimal.Size = New System.Drawing.Size(100, 23)
        Me.txt_Decimal.TabIndex = 9
        '
        'lbl_String
        '
        Me.lbl_String.AutoSize = True
        Me.lbl_String.Location = New System.Drawing.Point(106, 290)
        Me.lbl_String.Name = "lbl_String"
        Me.lbl_String.Size = New System.Drawing.Size(38, 15)
        Me.lbl_String.TabIndex = 10
        Me.lbl_String.Text = "String"
        '
        'txt_String
        '
        Me.txt_String.Location = New System.Drawing.Point(204, 287)
        Me.txt_String.Name = "txt_String"
        Me.txt_String.Size = New System.Drawing.Size(100, 23)
        Me.txt_String.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_String)
        Me.Controls.Add(Me.lbl_String)
        Me.Controls.Add(Me.txt_Decimal)
        Me.Controls.Add(Me.lbl_Decimal)
        Me.Controls.Add(Me.txt_Double)
        Me.Controls.Add(Me.lbl_Double)
        Me.Controls.Add(Me.txt_Long)
        Me.Controls.Add(Me.lbl_Long)
        Me.Controls.Add(Me.btn_Mostrar)
        Me.Controls.Add(Me.txt_integer)
        Me.Controls.Add(Me.lbl_Integer)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents lbl_Integer As Label
    Friend WithEvents txt_integer As TextBox
    Friend WithEvents btn_Mostrar As Button
    Friend WithEvents lbl_Long As Label
    Friend WithEvents txt_Long As TextBox
    Friend WithEvents lbl_Double As Label
    Friend WithEvents txt_Double As TextBox
    Friend WithEvents lbl_Decimal As Label
    Friend WithEvents txt_Decimal As TextBox
    Friend WithEvents lbl_String As Label
    Friend WithEvents txt_String As TextBox
End Class
