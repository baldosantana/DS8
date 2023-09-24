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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_C = New System.Windows.Forms.Label()
        Me.txt_C = New System.Windows.Forms.TextBox()
        Me.lbl_F = New System.Windows.Forms.Label()
        Me.txt_F = New System.Windows.Forms.TextBox()
        Me.btn_CF = New System.Windows.Forms.Button()
        Me.btn_FC = New System.Windows.Forms.Button()
        Me.rb_C = New System.Windows.Forms.RadioButton()
        Me.rb_F = New System.Windows.Forms.RadioButton()
        Me.btn_Calcular = New System.Windows.Forms.Button()
        Me.hsb_Valor = New System.Windows.Forms.HScrollBar()
        Me.vsb_Valor = New System.Windows.Forms.VScrollBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Convertir Temperatura"
        '
        'lbl_C
        '
        Me.lbl_C.AutoSize = True
        Me.lbl_C.Location = New System.Drawing.Point(159, 83)
        Me.lbl_C.Name = "lbl_C"
        Me.lbl_C.Size = New System.Drawing.Size(20, 15)
        Me.lbl_C.TabIndex = 1
        Me.lbl_C.Text = "°C"
        '
        'txt_C
        '
        Me.txt_C.Location = New System.Drawing.Point(218, 76)
        Me.txt_C.Name = "txt_C"
        Me.txt_C.Size = New System.Drawing.Size(100, 23)
        Me.txt_C.TabIndex = 2
        '
        'lbl_F
        '
        Me.lbl_F.AutoSize = True
        Me.lbl_F.Location = New System.Drawing.Point(164, 133)
        Me.lbl_F.Name = "lbl_F"
        Me.lbl_F.Size = New System.Drawing.Size(18, 15)
        Me.lbl_F.TabIndex = 3
        Me.lbl_F.Text = "°F"
        '
        'txt_F
        '
        Me.txt_F.Location = New System.Drawing.Point(218, 125)
        Me.txt_F.Name = "txt_F"
        Me.txt_F.Size = New System.Drawing.Size(100, 23)
        Me.txt_F.TabIndex = 4
        '
        'btn_CF
        '
        Me.btn_CF.Location = New System.Drawing.Point(389, 75)
        Me.btn_CF.Name = "btn_CF"
        Me.btn_CF.Size = New System.Drawing.Size(75, 23)
        Me.btn_CF.TabIndex = 5
        Me.btn_CF.Text = "°C a °F"
        Me.btn_CF.UseVisualStyleBackColor = True
        '
        'btn_FC
        '
        Me.btn_FC.Location = New System.Drawing.Point(389, 124)
        Me.btn_FC.Name = "btn_FC"
        Me.btn_FC.Size = New System.Drawing.Size(75, 23)
        Me.btn_FC.TabIndex = 6
        Me.btn_FC.Text = "°F a °C"
        Me.btn_FC.UseVisualStyleBackColor = True
        '
        'rb_C
        '
        Me.rb_C.AutoSize = True
        Me.rb_C.Checked = True
        Me.rb_C.Location = New System.Drawing.Point(104, 83)
        Me.rb_C.Name = "rb_C"
        Me.rb_C.Size = New System.Drawing.Size(38, 19)
        Me.rb_C.TabIndex = 7
        Me.rb_C.TabStop = True
        Me.rb_C.Text = "°C"
        Me.rb_C.UseVisualStyleBackColor = True
        '
        'rb_F
        '
        Me.rb_F.AutoSize = True
        Me.rb_F.Location = New System.Drawing.Point(106, 131)
        Me.rb_F.Name = "rb_F"
        Me.rb_F.Size = New System.Drawing.Size(36, 19)
        Me.rb_F.TabIndex = 8
        Me.rb_F.TabStop = True
        Me.rb_F.Text = "°F"
        Me.rb_F.UseVisualStyleBackColor = True
        '
        'btn_Calcular
        '
        Me.btn_Calcular.Location = New System.Drawing.Point(221, 188)
        Me.btn_Calcular.Name = "btn_Calcular"
        Me.btn_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.btn_Calcular.TabIndex = 9
        Me.btn_Calcular.Text = "Calcular"
        Me.btn_Calcular.UseVisualStyleBackColor = True
        '
        'hsb_Valor
        '
        Me.hsb_Valor.LargeChange = 1
        Me.hsb_Valor.Location = New System.Drawing.Point(95, 248)
        Me.hsb_Valor.Name = "hsb_Valor"
        Me.hsb_Valor.Size = New System.Drawing.Size(307, 34)
        Me.hsb_Valor.TabIndex = 10
        '
        'vsb_Valor
        '
        Me.vsb_Valor.LargeChange = 1
        Me.vsb_Valor.Location = New System.Drawing.Point(537, 75)
        Me.vsb_Valor.Maximum = 0
        Me.vsb_Valor.Minimum = -100
        Me.vsb_Valor.Name = "vsb_Valor"
        Me.vsb_Valor.Size = New System.Drawing.Size(17, 206)
        Me.vsb_Valor.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(573, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.vsb_Valor)
        Me.Controls.Add(Me.hsb_Valor)
        Me.Controls.Add(Me.btn_Calcular)
        Me.Controls.Add(Me.rb_F)
        Me.Controls.Add(Me.rb_C)
        Me.Controls.Add(Me.btn_FC)
        Me.Controls.Add(Me.btn_CF)
        Me.Controls.Add(Me.txt_F)
        Me.Controls.Add(Me.lbl_F)
        Me.Controls.Add(Me.txt_C)
        Me.Controls.Add(Me.lbl_C)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_C As Label
    Friend WithEvents txt_C As TextBox
    Friend WithEvents lbl_F As Label
    Friend WithEvents txt_F As TextBox
    Friend WithEvents btn_CF As Button
    Friend WithEvents btn_FC As Button
    Friend WithEvents rb_C As RadioButton
    Friend WithEvents rb_F As RadioButton
    Friend WithEvents btn_Calcular As Button
    Friend WithEvents hsb_Valor As HScrollBar
    Friend WithEvents vsb_Valor As VScrollBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
