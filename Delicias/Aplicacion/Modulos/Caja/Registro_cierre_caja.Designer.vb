<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_cierre_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_cierre_caja))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_ingresos_tarjeta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_montoinicial = New System.Windows.Forms.TextBox()
        Me.LB_fecha = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label_usuario = New System.Windows.Forms.Label()
        Me.TextBox_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label_sucursal = New System.Windows.Forms.Label()
        Me.TextBox_egresos_subtotal = New System.Windows.Forms.TextBox()
        Me.DG_caja = New System.Windows.Forms.DataGridView()
        Me.CAJAdetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleegreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CierrecajadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.TextBox_ingresos_efectivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_categoria = New System.Windows.Forms.ComboBox()
        Me.DG_categoria = New System.Windows.Forms.DataGridView()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResumencategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label_sucursal_b = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_usuario_b = New System.Windows.Forms.Label()
        Me.LB_fecha_b = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumencategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_tarjeta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_montoinicial)
        Me.GroupBox1.Controls.Add(Me.LB_fecha)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label_usuario)
        Me.GroupBox1.Controls.Add(Me.TextBox_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Label_sucursal)
        Me.GroupBox1.Controls.Add(Me.TextBox_egresos_subtotal)
        Me.GroupBox1.Controls.Add(Me.DG_caja)
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_efectivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1126, 494)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox_ingresos_tarjeta
        '
        Me.TextBox_ingresos_tarjeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_ingresos_tarjeta.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ingresos_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ingresos_tarjeta.Location = New System.Drawing.Point(175, 441)
        Me.TextBox_ingresos_tarjeta.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ingresos_tarjeta.Name = "TextBox_ingresos_tarjeta"
        Me.TextBox_ingresos_tarjeta.ReadOnly = True
        Me.TextBox_ingresos_tarjeta.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_ingresos_tarjeta.TabIndex = 251
        Me.TextBox_ingresos_tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(5, 447)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 17)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "TOTAL TARJETAS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(8, 61)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Apertura:"
        '
        'TextBox_montoinicial
        '
        Me.TextBox_montoinicial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_montoinicial.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_montoinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_montoinicial.Location = New System.Drawing.Point(175, 382)
        Me.TextBox_montoinicial.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_montoinicial.Name = "TextBox_montoinicial"
        Me.TextBox_montoinicial.ReadOnly = True
        Me.TextBox_montoinicial.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_montoinicial.TabIndex = 249
        Me.TextBox_montoinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_fecha
        '
        Me.LB_fecha.AutoSize = True
        Me.LB_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LB_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha.Location = New System.Drawing.Point(176, 61)
        Me.LB_fecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_fecha.Name = "LB_fecha"
        Me.LB_fecha.Size = New System.Drawing.Size(99, 20)
        Me.LB_fecha.TabIndex = 1
        Me.LB_fecha.Text = "00/00/2014"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(5, 388)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 17)
        Me.Label11.TabIndex = 248
        Me.Label11.Text = "MONTO INICIAL:"
        '
        'Label_usuario
        '
        Me.Label_usuario.AutoSize = True
        Me.Label_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_usuario.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_usuario.Location = New System.Drawing.Point(508, 61)
        Me.Label_usuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_usuario.Name = "Label_usuario"
        Me.Label_usuario.Size = New System.Drawing.Size(76, 20)
        Me.Label_usuario.TabIndex = 246
        Me.Label_usuario.Text = "Usuario:"
        '
        'TextBox_TOTAL
        '
        Me.TextBox_TOTAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_TOTAL.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TOTAL.Location = New System.Drawing.Point(832, 411)
        Me.TextBox_TOTAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_TOTAL.Name = "TextBox_TOTAL"
        Me.TextBox_TOTAL.ReadOnly = True
        Me.TextBox_TOTAL.Size = New System.Drawing.Size(239, 31)
        Me.TextBox_TOTAL.TabIndex = 245
        Me.TextBox_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_sucursal
        '
        Me.Label_sucursal.AutoSize = True
        Me.Label_sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_sucursal.ForeColor = System.Drawing.Color.Blue
        Me.Label_sucursal.Location = New System.Drawing.Point(8, 19)
        Me.Label_sucursal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_sucursal.Name = "Label_sucursal"
        Me.Label_sucursal.Size = New System.Drawing.Size(84, 20)
        Me.Label_sucursal.TabIndex = 247
        Me.Label_sucursal.Text = "Sucursal:"
        '
        'TextBox_egresos_subtotal
        '
        Me.TextBox_egresos_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_egresos_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_egresos_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_egresos_subtotal.Location = New System.Drawing.Point(541, 382)
        Me.TextBox_egresos_subtotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_egresos_subtotal.Name = "TextBox_egresos_subtotal"
        Me.TextBox_egresos_subtotal.ReadOnly = True
        Me.TextBox_egresos_subtotal.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_egresos_subtotal.TabIndex = 244
        Me.TextBox_egresos_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DG_caja
        '
        Me.DG_caja.AllowUserToAddRows = False
        Me.DG_caja.AllowUserToDeleteRows = False
        Me.DG_caja.AllowUserToResizeRows = False
        Me.DG_caja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_caja.AutoGenerateColumns = False
        Me.DG_caja.BackgroundColor = System.Drawing.Color.White
        Me.DG_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAJAdetalleidDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.CAJAdetalledescripcionDataGridViewTextBoxColumn, Me.CAJAdetalleingreso, Me.CAJAdetalleegreso, Me.CajaTipoMovintDataGridViewTextBoxColumn, Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn})
        Me.DG_caja.DataSource = Me.CierrecajadetalleBindingSource
        Me.DG_caja.Location = New System.Drawing.Point(11, 107)
        Me.DG_caja.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_caja.MultiSelect = False
        Me.DG_caja.Name = "DG_caja"
        Me.DG_caja.ReadOnly = True
        Me.DG_caja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_caja.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_caja.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_caja.Size = New System.Drawing.Size(1108, 265)
        Me.DG_caja.StandardTab = True
        Me.DG_caja.TabIndex = 240
        '
        'CAJAdetalleidDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleidDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.HeaderText = "CAJAdetalle_id"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Name = "CAJAdetalleidDataGridViewTextBoxColumn"
        Me.CAJAdetalleidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Visible = False
        Me.CAJAdetalleidDataGridViewTextBoxColumn.Width = 89
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAIDDataGridViewTextBoxColumn.Visible = False
        Me.CAJAIDDataGridViewTextBoxColumn.Width = 125
        '
        'CAJAdetalledescripcionDataGridViewTextBoxColumn
        '
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Name = "CAJAdetalledescripcionDataGridViewTextBoxColumn"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Width = 500
        '
        'CAJAdetalleingreso
        '
        Me.CAJAdetalleingreso.DataPropertyName = "CAJAdetalle_ingreso"
        Me.CAJAdetalleingreso.HeaderText = "Importe de Ingreso"
        Me.CAJAdetalleingreso.Name = "CAJAdetalleingreso"
        Me.CAJAdetalleingreso.ReadOnly = True
        Me.CAJAdetalleingreso.Width = 200
        '
        'CAJAdetalleegreso
        '
        Me.CAJAdetalleegreso.DataPropertyName = "CAJAdetalle_egreso"
        Me.CAJAdetalleegreso.HeaderText = "Importe de Egreso"
        Me.CAJAdetalleegreso.Name = "CAJAdetalleegreso"
        Me.CAJAdetalleegreso.ReadOnly = True
        Me.CAJAdetalleegreso.Width = 200
        '
        'CajaTipoMovintDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovintDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.HeaderText = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Name = "CajaTipoMovintDataGridViewTextBoxColumn"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.ReadOnly = True
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Visible = False
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Width = 90
        '
        'CajaTipoMovdescripcionDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_descripcion"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo Movimiento"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.Name = "CajaTipoMovdescripcionDataGridViewTextBoxColumn"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CierrecajadetalleBindingSource
        '
        Me.CierrecajadetalleBindingSource.DataMember = "Cierre_caja_detalle"
        Me.CierrecajadetalleBindingSource.DataSource = Me.Caja_ds
        '
        'Caja_ds
        '
        Me.Caja_ds.DataSetName = "Caja_ds"
        Me.Caja_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox_ingresos_efectivo
        '
        Me.TextBox_ingresos_efectivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_ingresos_efectivo.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ingresos_efectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ingresos_efectivo.Location = New System.Drawing.Point(541, 441)
        Me.TextBox_ingresos_efectivo.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ingresos_efectivo.Name = "TextBox_ingresos_efectivo"
        Me.TextBox_ingresos_efectivo.ReadOnly = True
        Me.TextBox_ingresos_efectivo.Size = New System.Drawing.Size(175, 23)
        Me.TextBox_ingresos_efectivo.TabIndex = 243
        Me.TextBox_ingresos_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(373, 447)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "TOTAL EFECTIVO:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(855, 376)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 25)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "TOTAL NETO:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(373, 385)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "TOTAL EGRESOS:"
        '
        'BO_guardar
        '
        Me.BO_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BO_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(995, 506)
        Me.BO_guardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(137, 49)
        Me.BO_guardar.TabIndex = 30
        Me.BO_guardar.Text = "Confirmar"
        Me.BO_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Confirmar cierre de caja")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(808, 531)
        Me.BO_Eliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(53, 49)
        Me.BO_Eliminar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Volver")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        Me.BO_Eliminar.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(16, 15)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1155, 629)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.BO_guardar)
        Me.TabPage1.Controls.Add(Me.BO_Eliminar)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1147, 600)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Caja: Registro de Cierre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1147, 600)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caja: Resumen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ComboBox_categoria)
        Me.GroupBox2.Controls.Add(Me.DG_categoria)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label_sucursal_b)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label_usuario_b)
        Me.GroupBox2.Controls.Add(Me.LB_fecha_b)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1135, 583)
        Me.GroupBox2.TabIndex = 252
        Me.GroupBox2.TabStop = False
        '
        'ComboBox_categoria
        '
        Me.ComboBox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_categoria.FormattingEnabled = True
        Me.ComboBox_categoria.Items.AddRange(New Object() {"Categoría", "Rubro", "Subrubro"})
        Me.ComboBox_categoria.Location = New System.Drawing.Point(126, 95)
        Me.ComboBox_categoria.Name = "ComboBox_categoria"
        Me.ComboBox_categoria.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_categoria.TabIndex = 256
        '
        'DG_categoria
        '
        Me.DG_categoria.AllowUserToAddRows = False
        Me.DG_categoria.AllowUserToDeleteRows = False
        Me.DG_categoria.AllowUserToResizeRows = False
        Me.DG_categoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_categoria.AutoGenerateColumns = False
        Me.DG_categoria.BackgroundColor = System.Drawing.Color.White
        Me.DG_categoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_categoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripcionDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DG_categoria.DataSource = Me.ResumencategoriaBindingSource
        Me.DG_categoria.Location = New System.Drawing.Point(12, 127)
        Me.DG_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_categoria.MultiSelect = False
        Me.DG_categoria.Name = "DG_categoria"
        Me.DG_categoria.ReadOnly = True
        Me.DG_categoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_categoria.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_categoria.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_categoria.Size = New System.Drawing.Size(1109, 360)
        Me.DG_categoria.StandardTab = True
        Me.DG_categoria.TabIndex = 255
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total ($)"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ResumencategoriaBindingSource
        '
        Me.ResumencategoriaBindingSource.DataMember = "Resumen_categoria"
        Me.ResumencategoriaBindingSource.DataSource = Me.Caja_ds
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(10, 98)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 17)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "Resumen por:"
        '
        'Label_sucursal_b
        '
        Me.Label_sucursal_b.AutoSize = True
        Me.Label_sucursal_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_sucursal_b.ForeColor = System.Drawing.Color.Blue
        Me.Label_sucursal_b.Location = New System.Drawing.Point(8, 19)
        Me.Label_sucursal_b.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_sucursal_b.Name = "Label_sucursal_b"
        Me.Label_sucursal_b.Size = New System.Drawing.Size(84, 20)
        Me.Label_sucursal_b.TabIndex = 251
        Me.Label_sucursal_b.Text = "Sucursal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(8, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 249
        Me.Label2.Text = "Fecha Apertura:"
        '
        'Label_usuario_b
        '
        Me.Label_usuario_b.AutoSize = True
        Me.Label_usuario_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label_usuario_b.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label_usuario_b.Location = New System.Drawing.Point(507, 61)
        Me.Label_usuario_b.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_usuario_b.Name = "Label_usuario_b"
        Me.Label_usuario_b.Size = New System.Drawing.Size(76, 20)
        Me.Label_usuario_b.TabIndex = 250
        Me.Label_usuario_b.Text = "Usuario:"
        '
        'LB_fecha_b
        '
        Me.LB_fecha_b.AutoSize = True
        Me.LB_fecha_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LB_fecha_b.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha_b.Location = New System.Drawing.Point(176, 61)
        Me.LB_fecha_b.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_fecha_b.Name = "LB_fecha_b"
        Me.LB_fecha_b.Size = New System.Drawing.Size(99, 20)
        Me.LB_fecha_b.TabIndex = 248
        Me.LB_fecha_b.Text = "00/00/2014"
        '
        'Registro_cierre_caja
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1175, 648)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1191, 687)
        Me.Name = "Registro_cierre_caja"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de cierre de caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumencategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LB_fecha As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DG_caja As System.Windows.Forms.DataGridView
    Friend WithEvents CierrecajadetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label_sucursal As System.Windows.Forms.Label
    Friend WithEvents Label_usuario As System.Windows.Forms.Label
    Friend WithEvents TextBox_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_egresos_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ingresos_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_montoinicial As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_ingresos_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CAJAdetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalledescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleegreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label_sucursal_b As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label_usuario_b As System.Windows.Forms.Label
    Friend WithEvents LB_fecha_b As System.Windows.Forms.Label
    Friend WithEvents DG_categoria As System.Windows.Forms.DataGridView
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ResumencategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
