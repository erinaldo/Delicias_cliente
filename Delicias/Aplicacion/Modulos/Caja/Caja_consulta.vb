Public Class Caja_consulta
    Public sucursal_id As Integer = 0
    Public sucursal_nombre As String
    Dim DAventa As New Datos.Venta
    Dim DAcaja As New Datos.Caja
    Dim DAusuario As New Datos.Usuario
    Dim inicio As String = "no"
    Dim facturacion_ds_report As New Facturacion_ds_report
    Dim DAterminal As New Datos.Terminal
    Dim ds_terminal As DataSet
    Dim var


    Private Sub buscar_cajas(ByVal var_inicial As String)
        Dim ds_caja As DataSet = DAcaja.Caja_consultar_caja_sucursal(sucursal_id, DateTimePicker_caja_desde.Value, DateTimePicker_caja_hasta.Value, ComboBox_Terminales.SelectedValue)

        If ds_caja.Tables(0).Rows.Count <> 0 Then
            DG_caja.DataSource = ds_caja.Tables(0)
            GroupBox4.Text = "Caja desde : " + DateTimePicker_caja_desde.Text + " hasta el: " + DateTimePicker_caja_hasta.Text + " de " + ComboBox_Terminales.Text
        Else
            GroupBox4.Text = "Registro de Caja"
            DG_caja.DataSource = ""
            If var_inicial <> "load" Then
                MessageBox.Show("no hay registro de caja para el rango de fecha.", "Sistema de Gestión")
            End If
        End If
    End Sub

    Public Sub obtener_terminales()
        ds_terminal = DAterminal.Terminal_obtener_todo(sucursal_id)

        If ds_terminal.Tables(0).Rows.Count <> 0 Then 'la tabla 1 trae la empresa con el inner join de la sucursal
            Dim empresa_id As Integer = 0
            ComboBox_Terminales.DataSource = ds_terminal.Tables(0)
            ComboBox_Terminales.DisplayMember = "Terminales_desc"
            ComboBox_Terminales.ValueMember = "Terminales_id"
        End If
    End Sub

    Private Sub Caja_consulta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim ds_usuario As DataSet = DAusuario.Usuario_obtener_x_sucursal(sucursal_id)
        'If ds_usuario.Tables(0).Rows.Count <> 0 Then
        '    ComboBox_usuarios.DataSource = ds_usuario.Tables(0)
        '    ComboBox_usuarios.DisplayMember = "apellidoynombre"
        '    ComboBox_usuarios.ValueMember = "USU_id"
        'End If
        'inicio = "si" 'esta variable la uso, x q el evento checkedchanged del buton 2 se dispara antes del load

        obtener_terminales()

        Label_suc_2.Text = sucursal_nombre

        buscar_cajas("load") 'llamo a esta rutina asi de entrada me muestre las cajas del dia actual
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        buscar_cajas("busqueda")
    End Sub

    Private Sub aplicar_filtro()


        'Antes Filtraba Por Usuario Ahora Por Terminal
        'If RadioButton1.Checked = True Then
        '    'llamo a la rutina para filtar, tomando como parametros los datos de las fechas desde, hasta
        '    Dim ds_caja As DataSet = DAcaja.Caja_consultar_caja_sucursal_x_usuario(sucursal_id, DateTimePicker_caja_desde.Value, DateTimePicker_caja_hasta.Value, CInt(ComboBox_Terminales.SelectedValue))
        '    If ds_caja.Tables(0).Rows.Count <> 0 Then
        '        DG_caja.DataSource = ds_caja.Tables(0)
        '        GroupBox4.Text = "Ventas desde " + DateTimePicker_caja_desde.Text + " hasta el " + DateTimePicker_caja_hasta.Text
        '    Else
        '        GroupBox4.Text = "Ventas registradas"
        '        DG_caja.DataSource = ""
        '        MsgBox("no hay ventas registradas para el rango de fecha")
        '    End If
        'End If
    End Sub

    Private Sub ComboBox_usuarios_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox_Terminales.SelectedIndexChanged
        aplicar_filtro()

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        'If RadioButton2.Checked = True And inicio = "si" Then
        '    buscar_cajas("busqueda")
        'End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        aplicar_filtro()
    End Sub

    Private Sub Button_siguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_siguiente.Click
        If DG_caja.Rows.Count <> 0 Then
            Caja_Consulta_detalle.Close()
            'tomo valor de la fila seleccionada y recupero de la BD el detalle para mostrarlo en un reporte
            Caja_Consulta_detalle.Label_suc_2.Text = Label_suc_2.Text
            Caja_Consulta_detalle.Label10.Text = Label_suc_2.Text
            Caja_Consulta_detalle.caja_id = CInt(DG_caja.CurrentRow.Cells("Caja_id").Value)
            Caja_Consulta_detalle.Show()
            Me.Hide()
        End If
    End Sub
End Class