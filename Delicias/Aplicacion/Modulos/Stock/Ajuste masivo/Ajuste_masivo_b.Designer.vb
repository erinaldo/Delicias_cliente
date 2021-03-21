<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_masivo_b
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_desc_porc = New System.Windows.Forms.TextBox()
        Me.rb_descuento = New System.Windows.Forms.RadioButton()
        Me.rb_aumento = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rb_minorista_precio = New System.Windows.Forms.RadioButton()
        Me.rb_mayorista_precio = New System.Windows.Forms.RadioButton()
        Me.rb_todos_precio = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_desc_pesos = New System.Windows.Forms.TextBox()
        Me.RB_porcentaje = New System.Windows.Forms.RadioButton()
        Me.RB_pesos = New System.Windows.Forms.RadioButton()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.GroupBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Controls.Add(Me.rb_descuento)
        Me.GroupBox6.Controls.Add(Me.rb_aumento)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox6.Location = New System.Drawing.Point(332, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(306, 226)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipo de actualización porcentual:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.RB_pesos)
        Me.GroupBox7.Controls.Add(Me.txt_desc_pesos)
        Me.GroupBox7.Controls.Add(Me.RB_porcentaje)
        Me.GroupBox7.Controls.Add(Me.txt_desc_porc)
        Me.GroupBox7.Location = New System.Drawing.Point(70, 105)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(198, 112)
        Me.GroupBox7.TabIndex = 7
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Porcentaje a aplicar:"
        '
        'txt_desc_porc
        '
        Me.txt_desc_porc.BackColor = System.Drawing.SystemColors.Info
        Me.txt_desc_porc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_desc_porc.Location = New System.Drawing.Point(59, 29)
        Me.txt_desc_porc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_desc_porc.Name = "txt_desc_porc"
        Me.txt_desc_porc.Size = New System.Drawing.Size(125, 30)
        Me.txt_desc_porc.TabIndex = 14
        Me.txt_desc_porc.Text = "0"
        Me.txt_desc_porc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rb_descuento
        '
        Me.rb_descuento.AutoSize = True
        Me.rb_descuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_descuento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_descuento.Location = New System.Drawing.Point(36, 79)
        Me.rb_descuento.Name = "rb_descuento"
        Me.rb_descuento.Size = New System.Drawing.Size(100, 20)
        Me.rb_descuento.TabIndex = 7
        Me.rb_descuento.Text = "Descuento"
        Me.rb_descuento.UseVisualStyleBackColor = True
        '
        'rb_aumento
        '
        Me.rb_aumento.AutoSize = True
        Me.rb_aumento.Checked = True
        Me.rb_aumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_aumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rb_aumento.Location = New System.Drawing.Point(36, 45)
        Me.rb_aumento.Name = "rb_aumento"
        Me.rb_aumento.Size = New System.Drawing.Size(86, 20)
        Me.rb_aumento.TabIndex = 1
        Me.rb_aumento.TabStop = True
        Me.rb_aumento.Text = "Aumento"
        Me.rb_aumento.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.GroupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox5.Controls.Add(Me.rb_minorista_precio)
        Me.GroupBox5.Controls.Add(Me.rb_mayorista_precio)
        Me.GroupBox5.Controls.Add(Me.rb_todos_precio)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 226)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Seleccione lista de precios"
        '
        'rb_minorista_precio
        '
        Me.rb_minorista_precio.AutoSize = True
        Me.rb_minorista_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_minorista_precio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rb_minorista_precio.Location = New System.Drawing.Point(51, 155)
        Me.rb_minorista_precio.Name = "rb_minorista_precio"
        Me.rb_minorista_precio.Size = New System.Drawing.Size(138, 20)
        Me.rb_minorista_precio.TabIndex = 2
        Me.rb_minorista_precio.Text = "Precio Minorista"
        Me.rb_minorista_precio.UseVisualStyleBackColor = True
        '
        'rb_mayorista_precio
        '
        Me.rb_mayorista_precio.AutoSize = True
        Me.rb_mayorista_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_mayorista_precio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rb_mayorista_precio.Location = New System.Drawing.Point(51, 99)
        Me.rb_mayorista_precio.Name = "rb_mayorista_precio"
        Me.rb_mayorista_precio.Size = New System.Drawing.Size(143, 20)
        Me.rb_mayorista_precio.TabIndex = 1
        Me.rb_mayorista_precio.Text = "Precio Mayorista"
        Me.rb_mayorista_precio.UseVisualStyleBackColor = True
        '
        'rb_todos_precio
        '
        Me.rb_todos_precio.AutoSize = True
        Me.rb_todos_precio.Checked = True
        Me.rb_todos_precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.rb_todos_precio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rb_todos_precio.Location = New System.Drawing.Point(51, 45)
        Me.rb_todos_precio.Name = "rb_todos_precio"
        Me.rb_todos_precio.Size = New System.Drawing.Size(71, 20)
        Me.rb_todos_precio.TabIndex = 0
        Me.rb_todos_precio.TabStop = True
        Me.rb_todos_precio.Text = "Todos"
        Me.rb_todos_precio.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(375, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 30)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(170, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 30)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "< Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(272, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_desc_pesos
        '
        Me.txt_desc_pesos.BackColor = System.Drawing.SystemColors.Info
        Me.txt_desc_pesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txt_desc_pesos.Location = New System.Drawing.Point(59, 74)
        Me.txt_desc_pesos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_desc_pesos.Name = "txt_desc_pesos"
        Me.txt_desc_pesos.Size = New System.Drawing.Size(125, 30)
        Me.txt_desc_pesos.TabIndex = 17
        Me.txt_desc_pesos.Text = "0"
        Me.txt_desc_pesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RB_porcentaje
        '
        Me.RB_porcentaje.AutoSize = True
        Me.RB_porcentaje.Checked = True
        Me.RB_porcentaje.Location = New System.Drawing.Point(15, 37)
        Me.RB_porcentaje.Name = "RB_porcentaje"
        Me.RB_porcentaje.Size = New System.Drawing.Size(38, 20)
        Me.RB_porcentaje.TabIndex = 8
        Me.RB_porcentaje.TabStop = True
        Me.RB_porcentaje.Text = "%"
        Me.RB_porcentaje.UseVisualStyleBackColor = True
        '
        'RB_pesos
        '
        Me.RB_pesos.AutoSize = True
        Me.RB_pesos.Location = New System.Drawing.Point(15, 82)
        Me.RB_pesos.Name = "RB_pesos"
        Me.RB_pesos.Size = New System.Drawing.Size(33, 20)
        Me.RB_pesos.TabIndex = 9
        Me.RB_pesos.Text = "$"
        Me.RB_pesos.UseVisualStyleBackColor = True
        '
        'Ajuste_masivo_b
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(647, 279)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Ajuste_masivo_b"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJUSTE MASIVO DE PRECIOS"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_desc_porc As System.Windows.Forms.TextBox
    Friend WithEvents rb_descuento As System.Windows.Forms.RadioButton
    Friend WithEvents rb_aumento As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_minorista_precio As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mayorista_precio As System.Windows.Forms.RadioButton
    Friend WithEvents rb_todos_precio As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_desc_pesos As System.Windows.Forms.TextBox
    Friend WithEvents RB_pesos As System.Windows.Forms.RadioButton
    Friend WithEvents RB_porcentaje As System.Windows.Forms.RadioButton
End Class
