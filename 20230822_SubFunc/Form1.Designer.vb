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
        Me.txt_Valor = New System.Windows.Forms.TextBox()
        Me.btn_Sub01 = New System.Windows.Forms.Button()
        Me.btn_SubPar = New System.Windows.Forms.Button()
        Me.btn_Func01 = New System.Windows.Forms.Button()
        Me.btn_FunPar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_Titulo.Location = New System.Drawing.Point(240, 23)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(207, 37)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "Sub y Funciones"
        '
        'txt_Valor
        '
        Me.txt_Valor.Location = New System.Drawing.Point(240, 83)
        Me.txt_Valor.Name = "txt_Valor"
        Me.txt_Valor.Size = New System.Drawing.Size(100, 23)
        Me.txt_Valor.TabIndex = 1
        '
        'btn_Sub01
        '
        Me.btn_Sub01.Location = New System.Drawing.Point(159, 139)
        Me.btn_Sub01.Name = "btn_Sub01"
        Me.btn_Sub01.Size = New System.Drawing.Size(75, 23)
        Me.btn_Sub01.TabIndex = 2
        Me.btn_Sub01.Text = "Sub01"
        Me.btn_Sub01.UseVisualStyleBackColor = True
        '
        'btn_SubPar
        '
        Me.btn_SubPar.Location = New System.Drawing.Point(333, 139)
        Me.btn_SubPar.Name = "btn_SubPar"
        Me.btn_SubPar.Size = New System.Drawing.Size(75, 23)
        Me.btn_SubPar.TabIndex = 3
        Me.btn_SubPar.Text = "Sub Par"
        Me.btn_SubPar.UseVisualStyleBackColor = True
        '
        'btn_Func01
        '
        Me.btn_Func01.Location = New System.Drawing.Point(165, 201)
        Me.btn_Func01.Name = "btn_Func01"
        Me.btn_Func01.Size = New System.Drawing.Size(75, 23)
        Me.btn_Func01.TabIndex = 4
        Me.btn_Func01.Text = "Funcion"
        Me.btn_Func01.UseVisualStyleBackColor = True
        '
        'btn_FunPar
        '
        Me.btn_FunPar.Location = New System.Drawing.Point(327, 203)
        Me.btn_FunPar.Name = "btn_FunPar"
        Me.btn_FunPar.Size = New System.Drawing.Size(75, 23)
        Me.btn_FunPar.TabIndex = 5
        Me.btn_FunPar.Text = "Func Par"
        Me.btn_FunPar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_FunPar)
        Me.Controls.Add(Me.btn_Func01)
        Me.Controls.Add(Me.btn_SubPar)
        Me.Controls.Add(Me.btn_Sub01)
        Me.Controls.Add(Me.txt_Valor)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titulo As Label
    Friend WithEvents txt_Valor As TextBox
    Friend WithEvents btn_Sub01 As Button
    Friend WithEvents btn_SubPar As Button
    Friend WithEvents btn_Func01 As Button
    Friend WithEvents btn_FunPar As Button
End Class
