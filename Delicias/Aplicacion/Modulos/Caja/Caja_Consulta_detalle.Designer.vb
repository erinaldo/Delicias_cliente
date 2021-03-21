<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Caja_Consulta_detalle
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Lb_fechacierre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_suc_2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ingresos_tarjeta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_montoinicial = New System.Windows.Forms.TextBox()
        Me.LB_fecha = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox_TOTAL = New System.Windows.Forms.TextBox()
        Me.TextBox_egresos_subtotal = New System.Windows.Forms.TextBox()
        Me.DG_caja = New System.Windows.Forms.DataGridView()
        Me.CAJAdetalleidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovintDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApeNom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CierrecajadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Caja_ds = New Aplicacion.Caja_ds()
        Me.TextBox_ingresos_efectivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_categoria = New System.Windows.Forms.ComboBox()
        Me.DG_categoria = New System.Windows.Forms.DataGridView()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResumencategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2_b = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6_b = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LB_fecha_b = New System.Windows.Forms.Label()
        Me.Button_volver = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DG_categoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResumencategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 7)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(1117, 614)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1117, 614)
        Me.TabControl1.TabIndex = 33
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(5)
        Me.TabPage1.Size = New System.Drawing.Size(1109, 585)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Movimientos de la Caja"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button_volver)
        Me.GroupBox1.Controls.Add(Me.Lb_fechacierre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label_suc_2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_tarjeta)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_montoinicial)
        Me.GroupBox1.Controls.Add(Me.LB_fecha)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TextBox_TOTAL)
        Me.GroupBox1.Controls.Add(Me.TextBox_egresos_subtotal)
        Me.GroupBox1.Controls.Add(Me.DG_caja)
        Me.GroupBox1.Controls.Add(Me.TextBox_ingresos_efectivo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(1091, 540)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Lb_fechacierre
        '
        Me.Lb_fechacierre.AutoSize = True
        Me.Lb_fechacierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_fechacierre.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Lb_fechacierre.Location = New System.Drawing.Point(550, 68)
        Me.Lb_fechacierre.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Lb_fechacierre.Name = "Lb_fechacierre"
        Me.Lb_fechacierre.Size = New System.Drawing.Size(0, 15)
        Me.Lb_fechacierre.TabIndex = 255
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(411, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 15)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Fecha Cierre:"
        '
        'Label_suc_2
        '
        Me.Label_suc_2.AutoSize = True
        Me.Label_suc_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_suc_2.ForeColor = System.Drawing.Color.Blue
        Me.Label_suc_2.Location = New System.Drawing.Point(98, 24)
        Me.Label_suc_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_suc_2.Name = "Label_suc_2"
        Me.Label_suc_2.Size = New System.Drawing.Size(79, 20)
        Me.Label_suc_2.TabIndex = 253
        Me.Label_suc_2.Text = "              "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 24)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 252
        Me.Label6.Text = "Sucursal:"
        '
        'TextBox_ingresos_tarjeta
        '
        Me.TextBox_ingresos_tarjeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_ingresos_tarjeta.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_ingresos_tarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ingresos_tarjeta.Location = New System.Drawing.Point(195, 496)
        Me.TextBox_ingresos_tarjeta.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ingresos_tarjeta.Name = "TextBox_ingresos_tarjeta"
        Me.TextBox_ingresos_tarjeta.ReadOnly = True
        Me.TextBox_ingresos_tarjeta.Size = New System.Drawing.Size(173, 23)
        Me.TextBox_ingresos_tarjeta.TabIndex = 251
        Me.TextBox_ingresos_tarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(25, 502)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 17)
        Me.Label9.TabIndex = 250
        Me.Label9.Text = "TOTAL TARJETAS:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(11, 68)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Apertura:"
        '
        'TextBox_montoinicial
        '
        Me.TextBox_montoinicial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_montoinicial.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_montoinicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_montoinicial.Location = New System.Drawing.Point(195, 437)
        Me.TextBox_montoinicial.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_montoinicial.Name = "TextBox_montoinicial"
        Me.TextBox_montoinicial.ReadOnly = True
        Me.TextBox_montoinicial.Size = New System.Drawing.Size(168, 23)
        Me.TextBox_montoinicial.TabIndex = 249
        Me.TextBox_montoinicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_fecha
        '
        Me.LB_fecha.AutoSize = True
        Me.LB_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha.Location = New System.Drawing.Point(171, 68)
        Me.LB_fecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LB_fecha.Name = "LB_fecha"
        Me.LB_fecha.Size = New System.Drawing.Size(69, 15)
        Me.LB_fecha.TabIndex = 1
        Me.LB_fecha.Text = "00/00/2014"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(25, 443)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 17)
        Me.Label11.TabIndex = 248
        Me.Label11.Text = "MONTO INICIAL:"
        '
        'TextBox_TOTAL
        '
        Me.TextBox_TOTAL.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_TOTAL.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_TOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_TOTAL.Location = New System.Drawing.Point(811, 466)
        Me.TextBox_TOTAL.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_TOTAL.Name = "TextBox_TOTAL"
        Me.TextBox_TOTAL.ReadOnly = True
        Me.TextBox_TOTAL.Size = New System.Drawing.Size(244, 31)
        Me.TextBox_TOTAL.TabIndex = 245
        Me.TextBox_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_egresos_subtotal
        '
        Me.TextBox_egresos_subtotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox_egresos_subtotal.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_egresos_subtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_egresos_subtotal.Location = New System.Drawing.Point(561, 437)
        Me.TextBox_egresos_subtotal.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_egresos_subtotal.Name = "TextBox_egresos_subtotal"
        Me.TextBox_egresos_subtotal.ReadOnly = True
        Me.TextBox_egresos_subtotal.Size = New System.Drawing.Size(173, 23)
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
        Me.DG_caja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_caja.BackgroundColor = System.Drawing.Color.White
        Me.DG_caja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_caja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_caja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CAJAdetalleidDataGridViewTextBoxColumn, Me.CAJAIDDataGridViewTextBoxColumn, Me.CAJAdetalledescripcionDataGridViewTextBoxColumn, Me.CAJAdetalleingresoDataGridViewTextBoxColumn, Me.CAJAdetalleegresoDataGridViewTextBoxColumn, Me.CajaTipoMovintDataGridViewTextBoxColumn, Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn, Me.ApeNom})
        Me.DG_caja.DataSource = Me.CierrecajadetalleBindingSource
        Me.DG_caja.Location = New System.Drawing.Point(11, 107)
        Me.DG_caja.Margin = New System.Windows.Forms.Padding(5)
        Me.DG_caja.MultiSelect = False
        Me.DG_caja.Name = "DG_caja"
        Me.DG_caja.ReadOnly = True
        Me.DG_caja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_caja.RowHeadersVisible = False
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_caja.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DG_caja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_caja.Size = New System.Drawing.Size(1071, 299)
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
        '
        'CAJAIDDataGridViewTextBoxColumn
        '
        Me.CAJAIDDataGridViewTextBoxColumn.DataPropertyName = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.HeaderText = "CAJA_ID"
        Me.CAJAIDDataGridViewTextBoxColumn.Name = "CAJAIDDataGridViewTextBoxColumn"
        Me.CAJAIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CAJAIDDataGridViewTextBoxColumn.Visible = False
        '
        'CAJAdetalledescripcionDataGridViewTextBoxColumn
        '
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_descripcion"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.HeaderText = "Concepto"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.Name = "CAJAdetalledescripcionDataGridViewTextBoxColumn"
        Me.CAJAdetalledescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAdetalleingresoDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_ingreso"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.HeaderText = "Importe de Ingreso"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.Name = "CAJAdetalleingresoDataGridViewTextBoxColumn"
        Me.CAJAdetalleingresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CAJAdetalleegresoDataGridViewTextBoxColumn
        '
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.DataPropertyName = "CAJAdetalle_egreso"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.HeaderText = "Importe de Egreso"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.Name = "CAJAdetalleegresoDataGridViewTextBoxColumn"
        Me.CAJAdetalleegresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CajaTipoMovintDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovintDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.HeaderText = "CajaTipoMov_int"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Name = "CajaTipoMovintDataGridViewTextBoxColumn"
        Me.CajaTipoMovintDataGridViewTextBoxColumn.ReadOnly = True
        Me.CajaTipoMovintDataGridViewTextBoxColumn.Visible = False
        '
        'CajaTipoMovdescripcionDataGridViewTextBoxColumn
        '
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.DataPropertyName = "CajaTipoMov_descripcion"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.HeaderText = "Tipo de Movimiento"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.Name = "CajaTipoMovdescripcionDataGridViewTextBoxColumn"
        Me.CajaTipoMovdescripcionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApeNom
        '
        Me.ApeNom.DataPropertyName = "ApeNom"
        Me.ApeNom.HeaderText = "Usuario"
        Me.ApeNom.Name = "ApeNom"
        Me.ApeNom.ReadOnly = True
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
        Me.TextBox_ingresos_efectivo.Location = New System.Drawing.Point(561, 496)
        Me.TextBox_ingresos_efectivo.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox_ingresos_efectivo.Name = "TextBox_ingresos_efectivo"
        Me.TextBox_ingresos_efectivo.ReadOnly = True
        Me.TextBox_ingresos_efectivo.Size = New System.Drawing.Size(172, 23)
        Me.TextBox_ingresos_efectivo.TabIndex = 243
        Me.TextBox_ingresos_efectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(393, 502)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "TOTAL EFECTIVO:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(834, 431)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 26)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "TOTAL NETO:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(393, 440)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 241
        Me.Label7.Text = "TOTAL EGRESOS:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1109, 585)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caja: Resumen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.ComboBox_categoria)
        Me.GroupBox2.Controls.Add(Me.DG_categoria)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2_b)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6_b)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LB_fecha_b)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(1091, 540)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ComboBox_categoria
        '
        Me.ComboBox_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_categoria.FormattingEnabled = True
        Me.ComboBox_categoria.Items.AddRange(New Object() {"Categoría", "Rubro", "Subrubro"})
        Me.ComboBox_categoria.Location = New System.Drawing.Point(128, 102)
        Me.ComboBox_categoria.Name = "ComboBox_categoria"
        Me.ComboBox_categoria.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox_categoria.TabIndex = 259
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
        Me.DG_categoria.Location = New System.Drawing.Point(14, 134)
        Me.DG_categoria.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_categoria.MultiSelect = False
        Me.DG_categoria.Name = "DG_categoria"
        Me.DG_categoria.ReadOnly = True
        Me.DG_categoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_categoria.RowHeadersVisible = False
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_categoria.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DG_categoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_categoria.Size = New System.Drawing.Size(1068, 360)
        Me.DG_categoria.StandardTab = True
        Me.DG_categoria.TabIndex = 258
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(12, 105)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 17)
        Me.Label13.TabIndex = 257
        Me.Label13.Text = "Resumen por:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(550, 68)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 255
        '
        'Label2_b
        '
        Me.Label2_b.AutoSize = True
        Me.Label2_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2_b.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2_b.Location = New System.Drawing.Point(411, 68)
        Me.Label2_b.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2_b.Name = "Label2_b"
        Me.Label2_b.Size = New System.Drawing.Size(80, 15)
        Me.Label2_b.TabIndex = 254
        Me.Label2_b.Text = "Fecha Cierre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(98, 24)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "              "
        '
        'Label6_b
        '
        Me.Label6_b.AutoSize = True
        Me.Label6_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6_b.Location = New System.Drawing.Point(9, 24)
        Me.Label6_b.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6_b.Name = "Label6_b"
        Me.Label6_b.Size = New System.Drawing.Size(75, 20)
        Me.Label6_b.TabIndex = 252
        Me.Label6_b.Text = "Sucursal:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(11, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Fecha Apertura:"
        '
        'LB_fecha_b
        '
        Me.LB_fecha_b.AutoSize = True
        Me.LB_fecha_b.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_fecha_b.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha_b.Location = New System.Drawing.Point(171, 68)
        Me.LB_fecha_b.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LB_fecha_b.Name = "LB_fecha_b"
        Me.LB_fecha_b.Size = New System.Drawing.Size(69, 15)
        Me.LB_fecha_b.TabIndex = 1
        Me.LB_fecha_b.Text = "00/00/2014"
        '
        'Button_volver
        '
        Me.Button_volver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_volver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_volver.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button_volver.Location = New System.Drawing.Point(979, 17)
        Me.Button_volver.Name = "Button_volver"
        Me.Button_volver.Size = New System.Drawing.Size(103, 36)
        Me.Button_volver.TabIndex = 261
        Me.Button_volver.Text = "Volver"
        Me.Button_volver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button_volver, "Volver a consulta de cajas")
        Me.Button_volver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.iniciar
        Me.Button1.Location = New System.Drawing.Point(979, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 36)
        Me.Button1.TabIndex = 262
        Me.Button1.Text = "Volver"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.Button1, "Volver a consulta de cajas")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Caja_Consulta_detalle
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1123, 627)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1128, 664)
        Me.Name = "Caja_Consulta_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Caja"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_caja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierrecajadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Caja_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DG_categoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResumencategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox_ingresos_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox_montoinicial As System.Windows.Forms.TextBox
    Friend WithEvents LB_fecha As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox_TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_egresos_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents DG_caja As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox_ingresos_efectivo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CierrecajadetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Caja_ds As Aplicacion.Caja_ds
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label_suc_2 As System.Windows.Forms.Label
    Friend WithEvents Lb_fechacierre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CAJAdetalleidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalledescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleingresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CAJAdetalleegresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovintDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CajaTipoMovdescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApeNom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2_b As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6_b As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LB_fecha_b As System.Windows.Forms.Label
    Friend WithEvents ComboBox_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents DG_categoria As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResumencategoriaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button_volver As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
