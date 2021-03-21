Public Class Ajuste_masivo_b
    Dim DAVentas As New Datos.Venta
    Dim ds_PROD As DataSet
    Public sucursal_id As Integer 'me lo envia el otro formulario

    'Dim Prod_ds As New Producto_ds

    Private Sub Ajuste_masivo_b_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub recuperar_productos()
        'ds_PROD.Tables.Clear()
        ds_PROD = DAVentas.Producto_obtenertodo_para_ajuste

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ajuste_masivo_a.Show()

        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Está seguro de aplicar el ajuste?", "Sistema de Gestion.", MessageBoxButtons.OKCancel)
        If result = DialogResult.OK Then
            If RB_porcentaje.Checked = True Then
                If txt_desc_porc.Text <> CDec(0) Then
                    msj_espere.procedencia = "Ajuste_masivo_b_guardar"
                    msj_espere.Show()
                Else
                    MessageBox.Show("Modifique el valor del Porcentaje a aplicar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            If RB_pesos.Checked = True Then
                If txt_desc_pesos.Text <> CDec(0) Then
                    msj_espere.procedencia = "Ajuste_masivo_b_guardar"
                    msj_espere.Show()
                Else
                    MessageBox.Show("Modifique el valor en pesos a aplicar.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
        




    End Sub

#Region "guardar_opcion_porcentaje"
    Private Sub guardar_todos_precio_aplico_porcentaje()

        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////
                Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta_May")
                Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta")

                'calculo porcentajes
                Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_mayorista = precio_mayorista + porcentaje_mayorista
                    precio_minorista = precio_minorista + porcentaje_minorista
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_mayorista = precio_mayorista - porcentaje_mayorista
                    precio_minorista = precio_minorista - porcentaje_minorista
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista
                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista
                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista
                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista
                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista
                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista
                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While


        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                        Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                        'calculo porcentajes
                        Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                        Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_mayorista = precio_mayorista + porcentaje_mayorista
                            precio_minorista = precio_minorista + porcentaje_minorista
                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_mayorista = precio_mayorista - porcentaje_mayorista
                            precio_minorista = precio_minorista - porcentaje_minorista
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)

                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
        End If


    End Sub

    Private Sub guardar_solo_mayorista_aplico_porcentaje()
        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////
                Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta_May")

                'calculo porcentajes
                Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_mayorista = precio_mayorista + porcentaje_mayorista
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_mayorista = precio_mayorista - porcentaje_mayorista
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")

                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista

                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                            'calculo porcentajes
                            Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + porcentaje_mayorista

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - porcentaje_mayorista

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista

                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    'calculo porcentajes
                                    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + porcentaje_mayorista

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - porcentaje_mayorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")

                        'calculo porcentajes
                        Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_mayorista = precio_mayorista + porcentaje_mayorista

                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_mayorista = precio_mayorista - porcentaje_mayorista
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)

                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
        End If

    End Sub

    Private Sub guardar_solo_minorista_aplico_porcentaje()

        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////

                Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta")

                'calculo porcentajes
                Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_minorista = precio_minorista + porcentaje_minorista
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_minorista = precio_minorista - porcentaje_minorista
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////

                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes

                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.

                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.

                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_minorista = precio_minorista + porcentaje_minorista
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_minorista = precio_minorista - porcentaje_minorista
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + porcentaje_minorista
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - porcentaje_minorista
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                        'calculo porcentajes
                        Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_minorista = precio_minorista + porcentaje_minorista

                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_minorista = precio_minorista - porcentaje_minorista
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_minorista)
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While

        End If

    End Sub

#End Region

#Region "guardar_opcion_pesos"
    Private Sub guardar_todos_precio()

        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////
                Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta_May")
                Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta")

                ''calculo porcentajes
                'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                    precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                    precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While


        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                        Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                        'calculo porcentajes
                        'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100
                        'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                            precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                            precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio(prod_id, precio_minorista, precio_mayorista)

                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
        End If


    End Sub

    Private Sub guardar_solo_mayorista()
        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////
                Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta_May")

                'calculo porcentajes
                'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")

                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                                    'calculo porcentajes
                                    '    Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)

                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                            'calculo porcentajes
                            'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)

                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")


                                    'calculo porcentajes
                                    'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)

                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")
                                    'calculo porcentajes
                                    'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_mayorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta_May")

                        'calculo porcentajes
                        'Dim porcentaje_mayorista As Decimal = (precio_mayorista * CDec(txt_desc_porc.Text)) / 100

                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_mayorista = precio_mayorista + CDec(txt_desc_pesos.Text)

                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_mayorista = precio_mayorista - CDec(txt_desc_pesos.Text)
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_mayorista)

                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
        End If

    End Sub

    Private Sub guardar_solo_minorista()

        'tengo que ver en el formulario Ajuste_masivo_a a donde aplico los cambios
        If Ajuste_masivo_a.RB_TODOS.Checked = True Then
            'recorro y aplico los cambios
            Dim i As Integer = 0
            While i < ds_PROD.Tables(0).Rows.Count
                '//////////////////////////hago el calculo//////////////////////////////////

                Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(i).Item("prod_precio_vta")

                'calculo porcentajes
                'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                If rb_aumento.Checked = True Then
                    'ahora lo sumo.
                    precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                End If
                If rb_descuento.Checked = True Then
                    'ahora lo resto.
                    precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                End If

                'ahora guardo nuevos precios en bd.
                Dim prod_id As Integer = ds_PROD.Tables(0).Rows(i).Item("prod_id")

                DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_CATEGORIAS.Checked = True Then
            'recorro y busco aquellos productos que coincidan en nrocat y idcat 
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prod_idcat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim prod_nrocat As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat")


                If prod_nrocat = 3 Then 'es un subrubro, asi q busco directamente los productos en ds_PROD
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////

                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.

                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.

                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While
                End If
                If prod_nrocat = 2 Then 'es un rubro pero ademas tengo q buscar todos los subrubros para actualizarlos
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat2_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                If prod_nrocat = 1 Then 'es categoria, por lo tanto tengo que actualizar tambien rubro y subrubro
                    Dim j As Integer = 0
                    While j < ds_PROD.Tables(0).Rows.Count
                        If (prod_idcat = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (prod_nrocat = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                            '//////////////////////////hago el calculo//////////////////////////////////
                            Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                            'calculo porcentajes
                            'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                            If rb_aumento.Checked = True Then
                                'ahora lo sumo.
                                precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                            End If
                            If rb_descuento.Checked = True Then
                                'ahora lo resto.
                                precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                            End If

                            'ahora guardo nuevos precios en bd.
                            Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                            DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                        End If
                        j = j + 1
                    End While

                    Dim k As Integer = 0
                    'ahora recorro la tabla 1 de las categorias para recuperar cada rubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(1).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat_id") Then
                            Dim id_rubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(1).Rows(k).Item("cat2_id")
                            Dim nro_rubro As Integer = 2
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While

                    k = 0
                    'ahora recorro la tabla 2 de las categorias para recuperar cada subrubro y de esa forma actualizar los productos q pertenezcan a esa
                    While k < Ajuste_masivo_a.ds_categoria.Tables(2).Rows.Count
                        If prod_idcat = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat_id") Then
                            Dim id_subrubro As Integer = Ajuste_masivo_a.ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                            Dim nro_rubro As Integer = 3
                            j = 0
                            While j < ds_PROD.Tables(0).Rows.Count
                                If (id_subrubro = ds_PROD.Tables(0).Rows(j).Item("prod_idcat")) And (nro_rubro = ds_PROD.Tables(0).Rows(j).Item("prod_nrocat")) Then
                                    '//////////////////////////hago el calculo//////////////////////////////////
                                    Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                                    'calculo porcentajes
                                    'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100
                                    If rb_aumento.Checked = True Then
                                        'ahora lo sumo.
                                        precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)
                                    End If
                                    If rb_descuento.Checked = True Then
                                        'ahora lo resto.
                                        precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                                    End If

                                    'ahora guardo nuevos precios en bd.
                                    Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                                    DAVentas.Producto_ajuste_precio_minorista(prod_id, precio_minorista)
                                End If
                                j = j + 1
                            End While
                        End If
                        k = k + 1
                    End While
                End If
                i = i + 1
            End While
        End If
        If Ajuste_masivo_a.RB_PROVEEDOR.Checked = True Then
            'recorro y busco aquellos productos que coincida con el proveedor, es decir el campo prov_id
            Dim i As Integer = 0
            While i < Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                Dim prov_id As Integer = Ajuste_masivo_a.Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo")
                Dim j As Integer = 0
                While j < ds_PROD.Tables(0).Rows.Count
                    If prov_id = ds_PROD.Tables(0).Rows(j).Item("Prov_id") Then
                        '//////////////////////////hago el calculo//////////////////////////////////
                        Dim precio_minorista As Decimal = ds_PROD.Tables(0).Rows(j).Item("prod_precio_vta")

                        'calculo porcentajes
                        'Dim porcentaje_minorista As Decimal = (precio_minorista * CDec(txt_desc_porc.Text)) / 100

                        If rb_aumento.Checked = True Then
                            'ahora lo sumo.
                            precio_minorista = precio_minorista + CDec(txt_desc_pesos.Text)

                        End If
                        If rb_descuento.Checked = True Then
                            'ahora lo resto.
                            precio_minorista = precio_minorista - CDec(txt_desc_pesos.Text)
                        End If

                        'ahora guardo nuevos precios en bd.
                        Dim prod_id As Integer = ds_PROD.Tables(0).Rows(j).Item("prod_id")

                        DAVentas.Producto_ajuste_precio_mayorista(prod_id, precio_minorista)
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While

        End If

    End Sub

#End Region

    Public Sub guardar()
        recuperar_productos()
        'hay que contemplar varios puntos:
        If rb_todos_precio.Checked = True Then

            If RB_porcentaje.Checked = True Then
                guardar_todos_precio_aplico_porcentaje()
            Else
                'es pesos
                guardar_todos_precio()
            End If

        End If
        If rb_mayorista_precio.Checked = True Then
            If RB_porcentaje.Checked = True Then
                guardar_solo_mayorista()
            Else
                guardar_solo_mayorista_aplico_porcentaje()
            End If
        End If
        If rb_minorista_precio.Checked = True Then
            If RB_porcentaje.Checked = True Then
                guardar_solo_minorista()
            Else
                guardar_solo_minorista_aplico_porcentaje()
            End If
        End If
        msj_espere.Close()
        MessageBox.Show("Los datos se guardaron correctamente.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()



    End Sub




    Private Sub txt_desc_porc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_desc_porc.KeyPress
        'si toco asterisco me toma el total
        'If e.KeyChar.ToString = "*" Then
        '    tx_parcial.Text = tx_total.Text
        'End If
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.txt_desc_porc.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub txt_desc_porc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_desc_porc.LostFocus
        If txt_desc_porc.Text = "" Then
            txt_desc_porc.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            txt_desc_porc.Text = (Math.Round(CDec(txt_desc_porc.Text), 2).ToString("N2"))
        End If
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Ajuste_masivo_a.Close()
        Me.Close()
    End Sub

    Private Sub txt_desc_pesos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_desc_pesos.KeyPress
        'si toco asterisco me toma el total
        'If e.KeyChar.ToString = "*" Then
        '    tx_parcial.Text = tx_total.Text
        'End If
        'aqui pongo el codigo para remplazar el punto por una coma
        If e.KeyChar.ToString() = "." Then
            e.KeyChar = ","
        End If
        'a continuacion el codigo para impedir el ingreso de dos comas o letras
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            If Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                If e.KeyChar = "," And Not Me.txt_desc_pesos.Text.IndexOf(",") Then
                    e.Handled = True
                Else
                    If e.KeyChar = "," Then
                        e.Handled = False
                    Else
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_desc_pesos_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_desc_pesos.LostFocus
        If txt_desc_pesos.Text = "" Then
            txt_desc_pesos.Text = (Math.Round(CDec(0), 2).ToString("N2"))
        Else
            txt_desc_pesos.Text = (Math.Round(CDec(txt_desc_pesos.Text), 2).ToString("N2"))
        End If
    End Sub
End Class