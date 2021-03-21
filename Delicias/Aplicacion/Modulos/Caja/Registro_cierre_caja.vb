Public Class Registro_cierre_caja
    Dim DAcaja As New Datos.Caja
    Dim APcaja As New Aplicacion.Caja
    Public Caja_id As Integer
    Dim listo = "no"
    Dim ds_productos As DataSet 'lo uso en el private sub recuperar_prod_categoria

    Private Sub recuperar_prod_categoria()
        If listo = "si" Then

            Select Case ComboBox_categoria.Text
                Case "Categoría"
                    Caja_ds.Tables("Resumen_categoria").Rows.Clear()
                    If ds_productos.Tables(0).Rows.Count <> 0 And (ds_productos.Tables(1).Rows.Count <> 0) Then
                        Dim h As Integer = 0
                        While h < ds_productos.Tables(1).Rows.Count 'tabla categorias
                            Dim categoria_desc As String = ds_productos.Tables(1).Rows(h).Item("Categoria_nombre")
                            Dim contador_productos As Integer = 0
                            Dim total As Decimal = 0
                            Dim id_categorias As Integer = CInt(ds_productos.Tables(1).Rows(h).Item("Categoria_cat_id")) 'ESTE ES EL ID DE CADA CATEGORIA, PARA BUSCAR Y VER SI HAY PRODUCTOS VENDIDOS AHI
                            Dim i As Integer = 0
                            While i < ds_productos.Tables(0).Rows.Count
                                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_nrocat"))
                                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_idcat"))
                                If nrocat = 1 Then
                                    'busco en categoria
                                    If id_categorias = idcat Then
                                        total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                        contador_productos = contador_productos + 1
                                    End If
                                End If
                                If nrocat = 2 Then
                                    'busco en rubro
                                    Dim j As Integer = 0
                                    While j < ds_productos.Tables(2).Rows.Count
                                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                            If id_categorias = ds_productos.Tables(2).Rows(j).Item("Categoria_cat_id") Then
                                                total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                                contador_productos = contador_productos + 1
                                                j = ds_productos.Tables(2).Rows.Count
                                            End If
                                        End If
                                        j = j + 1
                                    End While
                                End If
                                If nrocat = 3 Then
                                    'busco en subrubro then
                                    Dim j As Integer = 0
                                    While j < ds_productos.Tables(3).Rows.Count
                                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                            If id_categorias = ds_productos.Tables(3).Rows(j).Item("Categoria_cat_id") Then
                                                total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                                contador_productos = contador_productos + 1
                                                j = ds_productos.Tables(3).Rows.Count
                                            End If
                                        End If
                                        j = j + 1
                                    End While
                                End If
                                i = i + 1
                            End While
                            If contador_productos <> 0 Then
                                'entonces lo ingreso al producto en la grilla
                                Dim row As DataRow = Caja_ds.Tables("Resumen_categoria").NewRow
                                row("Descripcion") = categoria_desc
                                row("Total") = CDec(total)
                                Caja_ds.Tables("Resumen_categoria").Rows.Add(row)
                            End If
                            h = h + 1
                        End While
                    End If
                Case "Rubro"
                    Caja_ds.Tables("Resumen_categoria").Rows.Clear()
                    If ds_productos.Tables(0).Rows.Count <> 0 And (ds_productos.Tables(2).Rows.Count <> 0) Then
                        Dim h As Integer = 0
                        While h < ds_productos.Tables(2).Rows.Count 'tabla categorias
                            Dim rubro_desc As String = ds_productos.Tables(2).Rows(h).Item("Rubro_nombre")
                            Dim categoria_desc As String = ds_productos.Tables(2).Rows(h).Item("Categoria_nombre")
                            Dim contador_productos As Integer = 0
                            Dim total As Decimal = 0

                            Dim id_rubro As Integer = CInt(ds_productos.Tables(2).Rows(h).Item("Rubro_cat2_id"))
                            Dim i As Integer = 0
                            While i < ds_productos.Tables(0).Rows.Count
                                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_nrocat"))
                                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_idcat"))
                                If nrocat = 1 Then
                                    'no lo pongo
                                End If
                                If nrocat = 2 Then
                                    'busco en rubro
                                    Dim j As Integer = 0
                                    While j < ds_productos.Tables(2).Rows.Count
                                        If idcat = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                            If id_rubro = ds_productos.Tables(2).Rows(j).Item("Rubro_cat2_id") Then
                                                total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                                contador_productos = contador_productos + 1

                                                j = ds_productos.Tables(2).Rows.Count
                                            End If
                                        End If
                                        j = j + 1
                                    End While
                                End If
                                If nrocat = 3 Then
                                    'busco en subrubro then
                                    Dim j As Integer = 0
                                    While j < ds_productos.Tables(3).Rows.Count
                                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                            If id_rubro = ds_productos.Tables(3).Rows(j).Item("Rubro_cat2_id") Then
                                                total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                                contador_productos = contador_productos + 1
                                                j = ds_productos.Tables(3).Rows.Count
                                            End If
                                        End If
                                        j = j + 1
                                    End While
                                End If
                                i = i + 1
                            End While



                            If contador_productos <> 0 Then
                                'entonces lo ingreso al producto en la grilla
                                Dim row As DataRow = Caja_ds.Tables("Resumen_categoria").NewRow
                                row("Descripcion") = categoria_desc + "/" + rubro_desc
                                row("Total") = CDec(total)
                                Caja_ds.Tables("Resumen_categoria").Rows.Add(row)
                            End If
                            h = h + 1
                        End While
                    End If

                Case "Subrubro"
                    Caja_ds.Tables("Resumen_categoria").Rows.Clear()
                    If (ds_productos.Tables(0).Rows.Count <> 0) And (ds_productos.Tables(3).Rows.Count <> 0) Then
                        Dim h As Integer = 0
                        While h < ds_productos.Tables(3).Rows.Count 'tabla categorias
                            Dim rubro_desc As String = ds_productos.Tables(3).Rows(h).Item("Rubro_nombre")
                            Dim categoria_desc As String = ds_productos.Tables(3).Rows(h).Item("Categoria_nombre")
                            Dim subrubro_desc As String = ds_productos.Tables(3).Rows(h).Item("Subrubro_cat3_nombre")
                            Dim contador_productos As Integer = 0
                            Dim total As Decimal = 0
                            Dim id_subrubro As Integer = CInt(ds_productos.Tables(3).Rows(h).Item("Subrubro_cat3_id"))


                            Dim i As Integer = 0
                            While i < ds_productos.Tables(0).Rows.Count
                                Dim nrocat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_nrocat"))
                                Dim idcat As Integer = CInt(ds_productos.Tables(0).Rows(i).Item("prod_idcat"))
                                If nrocat = 1 Then
                                    'no lo pongo
                                End If
                                If nrocat = 2 Then
                                    'busco en rubro
                                End If
                                If nrocat = 3 Then
                                    'busco en subrubro then
                                    Dim j As Integer = 0
                                    While j < ds_productos.Tables(3).Rows.Count
                                        If idcat = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                            If id_subrubro = ds_productos.Tables(3).Rows(j).Item("Subrubro_cat3_id") Then
                                                total = total + ds_productos.Tables(0).Rows(i).Item("ventaprod_subtotal")
                                                contador_productos = contador_productos + 1
                                                j = ds_productos.Tables(3).Rows.Count
                                            End If
                                        End If
                                        j = j + 1
                                    End While
                                End If
                                i = i + 1
                            End While


                            If contador_productos <> 0 Then
                                'entonces lo ingreso al producto en la grilla
                                Dim row As DataRow = Caja_ds.Tables("Resumen_categoria").NewRow
                                row("Descripcion") = categoria_desc + "/" + rubro_desc
                                row("Total") = CDec(total)
                                Caja_ds.Tables("Resumen_categoria").Rows.Add(row)
                            End If
                            h = h + 1
                        End While
                    End If


            End Select
        End If
        


    End Sub




    Private Sub Registro_cierre_caja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        ComboBox_categoria.Text = "Categoría"

        ds_productos = DAcaja.Caja_obtener_productos_facturados_X_categoria(Inicio.CAJA_id)

        '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        Dim sucursal_id As Integer = Inicio.suc_id 'yo se q esta sucursal tiene la caja abierta...x la validacion del form del q vengo
        Dim usuario_id As Integer = Inicio.USU_id
        'voy a cargar en la grilla el detalle de la caja
        Dim ds_caja As DataSet = DAcaja.Caja_obtener_detalle(usuario_id, sucursal_id, US_administrador.TurnoUsuario_id, Inicio.CAJA_id)

        '///////choco 17-12-2019 ahora busco caja por caja_id ...

        '/////////////////////////////////////////////////

        If ds_caja.Tables(0).Rows.Count <> 0 Then
            TextBox_montoinicial.Text = CDec(ds_caja.Tables(0).Rows(0).Item("CAJA_montoinicial"))
            Label_usuario.Text = "Usuario: " + ds_caja.Tables(0).Rows(0).Item("Usuario")
            Label_usuario_b.Text = "Usuario: " + ds_caja.Tables(0).Rows(0).Item("Usuario")

            Label_sucursal.Text = "Sucursal: " + ds_caja.Tables(0).Rows(0).Item("Sucursal")
            Label_sucursal_b.Text = "Sucursal: " + ds_caja.Tables(0).Rows(0).Item("Sucursal")
            TextBox_ingresos_efectivo.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresosefectivo")
            TextBox_ingresos_tarjeta.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoingresostarjeta")
            TextBox_egresos_subtotal.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoegresos")
            TextBox_TOTAL.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_montoneto")
            LB_fecha.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_apertura")
            LB_fecha_b.Text = ds_caja.Tables(0).Rows(0).Item("CAJA_apertura")

            Caja_id = ds_caja.Tables(0).Rows(0).Item("Caja_id")
            If ds_caja.Tables(1).Rows.Count <> 0 Then
                DG_caja.DataSource = ds_caja.Tables(1)
                ''sumamos los ingresos
                'Dim i As Integer = 0
                'Dim ingresos As Decimal = 0
                'Dim egresos As Decimal = 0
                'While i < DG_caja.Rows.Count
                '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Ingreso" Then
                '        ingresos = ingresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleingreso").Value)
                '    End If
                '    If DG_caja.Rows(i).Cells("CajaTipoMovdescripcionDataGridViewTextBoxColumn").Value = "Egreso" Then
                '        egresos = egresos + CDec(DG_caja.Rows(i).Cells("CAJAdetalleegreso").Value)
                '    End If
                '    i = i + 1
                'End While
                ''ahora saco la diferencia
                'Dim total As Decimal = CDec(TextBox_montoinicial.Text) + ingresos - egresos
                'TextBox_ingresos_subtotal.Text = ingresos
                'TextBox_egresos_subtotal.Text = egresos
            End If
        Else
            Me.Close()
            MessageBox.Show("No puede ingresar con este usuario", "Sistema de Gestión")
        End If
        listo = "si"
        recuperar_prod_categoria() 'esto es para ver en la otra pestaña las ventas organizadas por categoria
    End Sub


    Private Sub BO_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_guardar.Click
        'tx_parcial.Text = CDec(tx_parcial.Text)
        'DAcaja.Caja_cierre(Inicio.USU_id, Now, Caja_id)
        'MessageBox.Show("Caja Cerrada correctamente", "Sistema de Gestion.")
        'APcaja.Caja_Validar()
        Me.Close()
        Corte_caja.Show()

    End Sub

    Private Sub BO_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BO_Eliminar.Click
        Registro_inicio_cierre.Show()
        Me.Close()
    End Sub

  
    Private Sub ComboBox_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox_categoria.SelectedIndexChanged
        recuperar_prod_categoria()
    End Sub
End Class