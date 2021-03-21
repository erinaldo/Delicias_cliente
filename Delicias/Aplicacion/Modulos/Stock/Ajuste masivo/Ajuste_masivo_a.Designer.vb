<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ajuste_masivo_a
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ArticulosagregadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ds_ajuste_masivo = New Aplicacion.Ds_ajuste_masivo()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Categorias_DS = New Aplicacion.Categorias_DS()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_Producto = New System.Windows.Forms.DataGridView()
        Me.CondicionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDmasivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_nrocat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RB_PROVEEDOR = New System.Windows.Forms.RadioButton()
        Me.RB_CATEGORIAS = New System.Windows.Forms.RadioButton()
        Me.RB_TODOS = New System.Windows.Forms.RadioButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ArticulosagregadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ds_ajuste_masivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1030, 490)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'ArticulosagregadosBindingSource
        '
        Me.ArticulosagregadosBindingSource.DataMember = "Articulos_agregados"
        Me.ArticulosagregadosBindingSource.DataSource = Me.Ds_ajuste_masivo
        '
        'Ds_ajuste_masivo
        '
        Me.Ds_ajuste_masivo.DataSetName = "Ds_ajuste_masivo"
        Me.Ds_ajuste_masivo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Gray
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.TreeView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 273)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.Green
        Me.Button4.Location = New System.Drawing.Point(233, 231)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 30)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Agregar (+)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.SystemColors.Info
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TreeView1.Location = New System.Drawing.Point(6, 16)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(339, 209)
        Me.TreeView1.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(913, 451)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 30)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(708, 451)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "< Atras"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(810, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 30)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Siguiente >"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Categorias_DS
        '
        Me.Categorias_DS.DataSetName = "Categorias_DS"
        Me.Categorias_DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.GroupBox1.Controls.Add(Me.DG_Producto)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(369, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 426)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulos agregados:"
        '
        'DG_Producto
        '
        Me.DG_Producto.AllowUserToAddRows = False
        Me.DG_Producto.AllowUserToDeleteRows = False
        Me.DG_Producto.AllowUserToResizeRows = False
        Me.DG_Producto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Producto.AutoGenerateColumns = False
        Me.DG_Producto.BackgroundColor = System.Drawing.Color.White
        Me.DG_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Producto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CondicionDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.IDmasivoDataGridViewTextBoxColumn, Me.ID_nrocat, Me.Column1})
        Me.DG_Producto.DataSource = Me.ArticulosagregadosBindingSource
        Me.DG_Producto.Location = New System.Drawing.Point(7, 22)
        Me.DG_Producto.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Producto.MultiSelect = False
        Me.DG_Producto.Name = "DG_Producto"
        Me.DG_Producto.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Producto.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Producto.Size = New System.Drawing.Size(635, 355)
        Me.DG_Producto.StandardTab = True
        Me.DG_Producto.TabIndex = 11
        '
        'CondicionDataGridViewTextBoxColumn
        '
        Me.CondicionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CondicionDataGridViewTextBoxColumn.DataPropertyName = "Condicion"
        Me.CondicionDataGridViewTextBoxColumn.HeaderText = "Condición"
        Me.CondicionDataGridViewTextBoxColumn.Name = "CondicionDataGridViewTextBoxColumn"
        Me.CondicionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDmasivoDataGridViewTextBoxColumn
        '
        Me.IDmasivoDataGridViewTextBoxColumn.DataPropertyName = "ID_masivo"
        Me.IDmasivoDataGridViewTextBoxColumn.HeaderText = "ID_masivo"
        Me.IDmasivoDataGridViewTextBoxColumn.Name = "IDmasivoDataGridViewTextBoxColumn"
        Me.IDmasivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDmasivoDataGridViewTextBoxColumn.Visible = False
        '
        'ID_nrocat
        '
        Me.ID_nrocat.DataPropertyName = "ID_nrocat"
        Me.ID_nrocat.HeaderText = "ID_nrocat"
        Me.ID_nrocat.Name = "ID_nrocat"
        Me.ID_nrocat.ReadOnly = True
        Me.ID_nrocat.Visible = False
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.FillWeight = 177.665!
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 50
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button5.ForeColor = System.Drawing.Color.Red
        Me.Button5.Location = New System.Drawing.Point(544, 384)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(82, 30)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Quitar (-)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.GroupBox2.Controls.Add(Me.RB_PROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.RB_CATEGORIAS)
        Me.GroupBox2.Controls.Add(Me.RB_TODOS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 147)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccione los articulos a los cuales aplicará cambios"
        '
        'RB_PROVEEDOR
        '
        Me.RB_PROVEEDOR.AutoSize = True
        Me.RB_PROVEEDOR.BackColor = System.Drawing.Color.Transparent
        Me.RB_PROVEEDOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RB_PROVEEDOR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RB_PROVEEDOR.Location = New System.Drawing.Point(51, 104)
        Me.RB_PROVEEDOR.Name = "RB_PROVEEDOR"
        Me.RB_PROVEEDOR.Size = New System.Drawing.Size(99, 20)
        Me.RB_PROVEEDOR.TabIndex = 2
        Me.RB_PROVEEDOR.Text = "Proveedor"
        Me.RB_PROVEEDOR.UseVisualStyleBackColor = False
        '
        'RB_CATEGORIAS
        '
        Me.RB_CATEGORIAS.AutoSize = True
        Me.RB_CATEGORIAS.BackColor = System.Drawing.Color.Transparent
        Me.RB_CATEGORIAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RB_CATEGORIAS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RB_CATEGORIAS.Location = New System.Drawing.Point(51, 72)
        Me.RB_CATEGORIAS.Name = "RB_CATEGORIAS"
        Me.RB_CATEGORIAS.Size = New System.Drawing.Size(102, 20)
        Me.RB_CATEGORIAS.TabIndex = 1
        Me.RB_CATEGORIAS.Text = "Categorias"
        Me.RB_CATEGORIAS.UseVisualStyleBackColor = False
        '
        'RB_TODOS
        '
        Me.RB_TODOS.AutoSize = True
        Me.RB_TODOS.BackColor = System.Drawing.Color.Transparent
        Me.RB_TODOS.Checked = True
        Me.RB_TODOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RB_TODOS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RB_TODOS.Location = New System.Drawing.Point(51, 38)
        Me.RB_TODOS.Name = "RB_TODOS"
        Me.RB_TODOS.Size = New System.Drawing.Size(71, 20)
        Me.RB_TODOS.TabIndex = 0
        Me.RB_TODOS.TabStop = True
        Me.RB_TODOS.Text = "Todos"
        Me.RB_TODOS.UseVisualStyleBackColor = False
        '
        'Ajuste_masivo_a
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1033, 500)
        Me.Controls.Add(Me.GroupBox4)
        Me.Name = "Ajuste_masivo_a"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJUSTE MASIVO DE PRECIOS"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.ArticulosagregadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ds_ajuste_masivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.Categorias_DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DG_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ArticulosagregadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Ds_ajuste_masivo As Aplicacion.Ds_ajuste_masivo
    Friend WithEvents Categorias_DS As Aplicacion.Categorias_DS
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DG_Producto As System.Windows.Forms.DataGridView
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_PROVEEDOR As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CATEGORIAS As System.Windows.Forms.RadioButton
    Friend WithEvents RB_TODOS As System.Windows.Forms.RadioButton
    Friend WithEvents CondicionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDmasivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_nrocat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
