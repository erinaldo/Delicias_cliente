Public Class Ajuste_precios

    Public prod_codinterno As Integer 'me lo envia el form producto_modificar
    Dim daVenta As New Datos.Venta

    Dim valicacion As New Aplicacion.Validaciones
    Private Sub recuperar_info()
        Dim ds_producto As DataSet = daVenta.Producto_ajuste_recuperar_info(prod_codinterno)
        'ahora lo cargo en el gridvie

        txt_codigo.Text = prod_codinterno
        txt_descripcion.Text = ds_producto.Tables(0).Rows(0).Item("prod_descripcion")
        txt_repo.Text = ds_producto.Tables(0).Rows(0).Item("prod_ptorepo")

        DataGridView1.DataSource = ds_producto.Tables(0)

    End Sub



    Private Sub Ajuste_precios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        recuperar_info()
    End Sub

    Private Sub txt_repo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_repo.KeyPress
        valicacion.Restricciones_textbox(e, "Entero", txt_repo)
    End Sub

    Private Sub txt_repo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_repo.LostFocus
        If txt_repo.Text = "" Then
            txt_repo.Text = CInt(0)
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro de aplicar el ajuste?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            'FALA LA VALIDACION QUE LA GRILLA NO TENGO VACIOS, EN NINGUNA DE LAS FILAS EDITABLES
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                Dim precio_vta As Decimal = CDec(DataGridView1.Rows(i).Cells("PreciominoristaDataGridViewTextBoxColumn").Value)
                Dim precio_vta_may As Decimal = CDec(DataGridView1.Rows(i).Cells("PreciomayoristaDataGridViewTextBoxColumn").Value)
                Dim stock As Decimal = CDec(DataGridView1.Rows(i).Cells("ProdxSucstockDataGridViewTextBoxColumn").Value)
                Dim ProdxSuc_ID As Integer = DataGridView1.Rows(i).Cells("ProdxSuc_ID").Value
                daVenta.Producto_ajuste_individual(prod_codinterno, precio_vta, precio_vta_may, stock, ProdxSuc_ID, CInt(txt_repo.Text))
                i = i + 1
            End While

            MessageBox.Show("Los datos se actualizaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Producto_modificar.Close() 'lo cierro x que esta hide
            Producto_modificar.Show()
            Me.Close()
            'aqui capaz q tengo q actualizar el form Producto_modificar
        End If
    End Sub

    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If (DataGridView1.CurrentCell.ColumnIndex = 2) Or (DataGridView1.CurrentCell.ColumnIndex = 3) Or (DataGridView1.CurrentCell.ColumnIndex = 4) Then
            If (DataGridView1.CurrentCell.Value Is DBNull.Value) Then
                DataGridView1.CurrentCell.Value = (Math.Round(CDec(0), 2).ToString("N2"))
            Else
                DataGridView1.CurrentCell.Value = (Math.Round(CDec(DataGridView1.CurrentCell.Value), 2).ToString("N2"))
            End If


        End If
    End Sub

    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DataGridView1.EditingControlShowing
        Dim validar As TextBox = CType(e.Control, TextBox)
        'agregar el controlador de eventos para el keypress
        AddHandler validar.KeyPress, AddressOf validar_Keypress
    End Sub
    Private Sub validar_Keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim columna As Integer = DataGridView1.CurrentCell.ColumnIndex
        e.Handled = True 'primero bloqueo el ingreso

        If (columna = 2) Or (columna = 3) Or (columna = 4) Then
            'si es precio vta, mayorista o stock solo dejo ingresar numeros y la coma para el decimal
            Dim caracter As Char = e.KeyChar
            '        'referencia a la celda
            Dim txt As TextBox = CType(sender, TextBox)
            'aqui pongo el codigo para remplazar el punto por una coma
            If txt.ToString() = "." Then
                txt.Text = ","
            End If
            If caracter.ToString() = "." Then
                caracter = ","
            End If
            'comprobar si el caracter es un número o el retroceso, si el caracter es un separador decimal y que no contiene ya el separador
            If (Char.IsNumber(caracter)) Or (caracter = ChrW(Keys.Back)) Or (caracter = ",") And (txt.Text.Contains(",") = False) Then
                e.KeyChar = caracter
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        'volver a gridview de productos
        Producto_modificar.Show()


    End Sub
End Class