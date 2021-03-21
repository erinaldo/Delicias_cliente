Public Class Ajuste_masivo_a
    Dim daproveedor As New Datos.Proveedor
    Dim dacategoria As New Datos.Categoria
    Dim ds_proveedor As DataSet = daproveedor.Proveedor_obtener_todo
    Public ds_categoria As DataSet = dacategoria.Categoria_obtener_niveles

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RB_TODOS.Checked = False Then
            If DG_Producto.Rows.Count <> 0 Then
                Me.Hide()
                Ajuste_masivo_b.Close()

                Ajuste_masivo_b.Show()
            Else
                MessageBox.Show("Error, para continuar debe ingresar al menus un item en el listado de artículos.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            Me.Hide()
            Ajuste_masivo_b.Close()

            Ajuste_masivo_b.Show()
        End If

    End Sub

    Private Sub Ajuste_masivo_a_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub RB_PROVEEDOR_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_PROVEEDOR.CheckedChanged
        TreeView1.Nodes.Clear()
        Ds_ajuste_masivo.Tables("aux_categorias").Rows.Clear() 'siempre borro x las dudas

        If RB_PROVEEDOR.Checked = True Then
            'PONGO EN EL TREEVIEW LOS PROVEEDORES
            Dim i As Integer = 0
            While i < ds_proveedor.Tables(0).Rows.Count

                TreeView1.Nodes.Add(ds_proveedor.Tables(0).Rows(i).Item("Prov_nombre"))
                Dim indice As Integer = TreeView1.Nodes.Count - 1
                TreeView1.Nodes(indice).Tag = ds_proveedor.Tables(0).Rows(i).Item("Prov_id")
                i = i + 1
            End While
            'selecciono el primer nodo
            TreeView1.SelectedNode = TreeView1.Nodes(0)
        End If

        
    End Sub

    Private Sub RB_CATEGORIAS_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_CATEGORIAS.CheckedChanged
        TreeView1.Nodes.Clear()
        Ds_ajuste_masivo.Tables("aux_categorias").Rows.Clear() 'siempre borro x las dudas

        If RB_CATEGORIAS.Checked = True Then
            'pongo en el treeview las categorias
            Dim i As Integer = 0
            While i < ds_categoria.Tables(0).Rows.Count
                TreeView1.Nodes.Add(ds_categoria.Tables(0).Rows(i).Item("cat1_nom"))
                Dim indice As Integer = TreeView1.Nodes.Count - 1

                'TreeView1.Nodes(indice).Tag = ds_categoria.Tables(0).Rows(i).Item("cat_id")
                Dim fila_aux As DataRow = Ds_ajuste_masivo.Tables("aux_categorias").NewRow
                fila_aux("idcat") = ds_categoria.Tables(0).Rows(i).Item("cat_id")
                fila_aux("nrocat") = 1
                Ds_ajuste_masivo.Tables("aux_categorias").Rows.Add(fila_aux)

                TreeView1.Nodes(indice).Tag = CInt(Ds_ajuste_masivo.Tables("aux_categorias").Rows.Count - 1)


                'prod_idcat()
                'prod_nrocat() 1, 2 y 3 eso me da los niveles


                'ahora veo si tiene rubros
                Dim j As Integer = 0
                While j < ds_categoria.Tables(1).Rows.Count
                    If ds_categoria.Tables(1).Rows(j).Item("cat_id") = ds_categoria.Tables(0).Rows(i).Item("cat_id") Then
                        'lo agrego como hijo del nodo recien agregado
                        TreeView1.Nodes(indice).Nodes.Add(ds_categoria.Tables(1).Rows(j).Item("cat2_nom"))
                        Dim indice_rubro As Integer = TreeView1.Nodes(indice).Nodes.Count - 1
                        'TreeView1.Nodes(indice).Nodes(indice_rubro).Tag = ds_categoria.Tables(1).Rows(j).Item("cat2_id")

                        Dim fila_aux2 As DataRow = Ds_ajuste_masivo.Tables("aux_categorias").NewRow
                        fila_aux2("idcat") = ds_categoria.Tables(1).Rows(j).Item("cat2_id")
                        fila_aux2("nrocat") = 2
                        Ds_ajuste_masivo.Tables("aux_categorias").Rows.Add(fila_aux2)
                        TreeView1.Nodes(indice).Nodes(indice_rubro).Tag = CInt(Ds_ajuste_masivo.Tables("aux_categorias").Rows.Count - 1)

                        'ahora veo si tiene subrubros
                        Dim k As Integer = 0
                        While k < ds_categoria.Tables(2).Rows.Count
                            If ds_categoria.Tables(2).Rows(k).Item("cat2_id") = ds_categoria.Tables(1).Rows(j).Item("cat2_id") Then
                                'lo agrego como hijo del nodo recien agregado (rubro)
                                TreeView1.Nodes(indice).Nodes(indice_rubro).Nodes.Add(ds_categoria.Tables(2).Rows(k).Item("cat3_nom"))
                                Dim indice_subrubro As Integer = TreeView1.Nodes(indice).Nodes(indice_rubro).Nodes.Count - 1
                                'TreeView1.Nodes(indice).Nodes(indice_rubro).Nodes(indice_subrubro).Tag = ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                                Dim fila_aux3 As DataRow = Ds_ajuste_masivo.Tables("aux_categorias").NewRow
                                fila_aux3("idcat") = ds_categoria.Tables(2).Rows(k).Item("cat3_id")
                                fila_aux3("nrocat") = 3
                                Ds_ajuste_masivo.Tables("aux_categorias").Rows.Add(fila_aux3)
                                TreeView1.Nodes(indice).Nodes(indice_rubro).Nodes(indice_subrubro).Tag = CInt(Ds_ajuste_masivo.Tables("aux_categorias").Rows.Count - 1)

                            End If
                            k = k + 1
                        End While
                    End If
                    j = j + 1
                End While
                i = i + 1
            End While
            'selecciono el primer nodo
            TreeView1.SelectedNode = TreeView1.Nodes(0)
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If DG_Producto.Rows.Count <> 0 Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
        End If
        If RB_PROVEEDOR.Checked = True And TreeView1.Nodes.Count <> 0 Then
            'antes de agregar valido que no esté en el gridview
            Dim i As Integer = 0
            Dim existe As String = "no"
            While i < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                If TreeView1.SelectedNode.Tag.ToString = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo").ToString Then
                    existe = "si"
                    Exit While
                End If
                i = i + 1
            End While
            If existe = "no" Then
                'ahora agrego selección.
                Dim fila As DataRow = Ds_ajuste_masivo.Tables("Articulos_agregados").NewRow
                fila("Condicion") = "Proveedor"
                fila("Descripción") = TreeView1.SelectedNode.Text
                fila("ID_masivo") = TreeView1.SelectedNode.Tag
                Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Add(fila)
                GroupBox2.Enabled = False
            Else
                MessageBox.Show("El proveedor ya fue agregado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If

        If RB_CATEGORIAS.Checked = True Then
            'primero recupero idcat y nrocat de la tabla aux_categorias
            Dim idcat As Integer = 0
            Dim nrocat As Integer = 0
            Try
                If Ds_ajuste_masivo.Tables("aux_categorias").Rows.Count <> 0 Then
                    Dim indice As Integer = CInt(TreeView1.SelectedNode.Tag)
                    idcat = Ds_ajuste_masivo.Tables("aux_categorias").Rows(indice).Item("idcat")
                    nrocat = Ds_ajuste_masivo.Tables("aux_categorias").Rows(indice).Item("nrocat")
                End If

                'antes de agregar valido que no esté en el gridview
                Dim i As Integer = 0
                Dim existe As String = "no"
                While i < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                    If (idcat.ToString = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_masivo").ToString) And (nrocat.ToString = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(i).Item("ID_nrocat").ToString) Then
                        existe = "si"
                        Exit While
                    End If
                    i = i + 1
                End While
                
                If existe = "no" Then
                    'sigo validando, si el item que intento agregar ya tiene un nodo padre cargado no puedo agregarlo. ' y si hay nodos hijos debo quitar los hijos.
                    Dim valido As String = "si"
                    Dim motivo As String = ""
                    Dim nombre_categoria As String = ""
                    Dim nombre_rubro As String = ""
                    Dim nombre_subrubro As String = ""
                    Select Case nrocat
                        Case 1
                            'me fijo si hay rubros y subrubros agregados ya
                            Dim rb As Integer = 0
                            While rb < ds_categoria.Tables(1).Rows.Count
                                If idcat = ds_categoria.Tables(1).Rows(rb).Item("cat_id") Then
                                    Dim cat2_id As Integer = ds_categoria.Tables(1).Rows(rb).Item("cat2_id")
                                    'me fijo si esta en el gridview.
                                    Dim d As Integer = 0
                                    While d < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat2_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_nrocat") = 2) Then
                                            valido = "no"
                                            motivo = "existe rubro"
                                            Exit While
                                        End If
                                        d = d + 1
                                    End While
                                End If
                                rb = rb + 1
                                If valido = "no" Then
                                    Exit While
                                End If
                            End While

                            Dim srb As Integer = 0
                            While srb < ds_categoria.Tables(2).Rows.Count
                                If idcat = ds_categoria.Tables(2).Rows(srb).Item("cat_id") Then
                                    Dim cat3_id As Integer = ds_categoria.Tables(2).Rows(srb).Item("cat3_id")
                                    'me fijo si esta en el gridview.
                                    Dim d As Integer = 0
                                    While d < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat3_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_nrocat") = 3) Then
                                            valido = "no"
                                            If motivo = "existe rubro" Then
                                                motivo = "exite rubro y subrubro"
                                            Else
                                                motivo = "existe subrubro"
                                            End If
                                            Exit While
                                        End If
                                        d = d + 1
                                    End While

                                End If
                                If valido = "no" Then
                                    Exit While
                                End If
                                srb = srb + 1
                            End While
                        Case 2
                            'me fijo si y esta la categoria ingresada o bien si tiene un subrubro ya ingresado
                            'me fijo si hay rubros y subrubros agregados ya
                            Dim rb As Integer = 0
                            While rb < ds_categoria.Tables(1).Rows.Count
                                If idcat = ds_categoria.Tables(1).Rows(rb).Item("cat2_id") Then 'rubro
                                    Dim cat1_id As Integer = ds_categoria.Tables(1).Rows(rb).Item("cat_id") 'categoria
                                    nombre_categoria = ds_categoria.Tables(1).Rows(rb).Item("cat1_nom")
                                    'me fijo si esta en el gridview.
                                    Dim d As Integer = 0
                                    While d < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat1_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_nrocat") = 1) Then
                                            valido = "no"
                                            motivo = "existe categoria" 'existe nodo padre en grilla
                                            Exit While
                                        End If
                                        d = d + 1
                                    End While
                                End If
                                rb = rb + 1
                                If valido = "no" Then
                                    Exit While
                                End If
                            End While

                            Dim srb As Integer = 0
                            While srb < ds_categoria.Tables(2).Rows.Count
                                If idcat = ds_categoria.Tables(2).Rows(srb).Item("cat2_id") Then 'rubro
                                    Dim cat3_id As Integer = ds_categoria.Tables(2).Rows(srb).Item("cat3_id") 'subrubro
                                    'me fijo si esta en el gridview.
                                    Dim d As Integer = 0
                                    While d < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat3_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_nrocat") = 3) Then
                                            valido = "no"
                                            If motivo = "existe categoria" Then
                                                motivo = "exite categoria y subrubro"
                                            Else
                                                motivo = "existe subrubro"
                                            End If
                                            Exit While
                                        End If
                                        d = d + 1
                                    End While

                                End If
                                If valido = "no" Then
                                    Exit While
                                End If
                                srb = srb + 1
                            End While
                        Case 3
                            Dim srb As Integer = 0
                            While srb < ds_categoria.Tables(2).Rows.Count
                                If idcat = ds_categoria.Tables(2).Rows(srb).Item("cat3_id") Then 'subrubro
                                    Dim cat2_id As Integer = ds_categoria.Tables(2).Rows(srb).Item("cat2_id") 'subrubro
                                    nombre_rubro = ds_categoria.Tables(2).Rows(srb).Item("cat2_nom")
                                    nombre_categoria = ds_categoria.Tables(2).Rows(srb).Item("cat1_nom")
                                    'me fijo si esta en el gridview el rubro.
                                    Dim d As Integer = 0
                                    While d < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat2_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(d).Item("ID_nrocat") = 2) Then
                                            valido = "no"
                                            motivo = "existe rubro" 'existe nodo padre en grilla
                                            Exit While
                                        End If
                                        d = d + 1
                                    End While
                                    Dim cat1_id As Integer = ds_categoria.Tables(2).Rows(srb).Item("cat_id") 'categoria
                                    Dim ii As Integer = 0
                                    While ii < Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Count
                                        If (cat1_id = Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(ii).Item("ID_masivo")) And (Ds_ajuste_masivo.Tables("Articulos_agregados").Rows(ii).Item("ID_nrocat") = 1) Then
                                            valido = "no"
                                            If motivo = "existe rubro" Then
                                                motivo = "exite categoria y subrubro"
                                            Else
                                                motivo = "existe categoria"
                                            End If
                                            Exit While
                                        End If
                                        ii = ii + 1
                                    End While
                                End If
                                If valido = "no" Then
                                    Exit While
                                End If
                                srb = srb + 1
                            End While
                    End Select
                    If valido = "si" Then
                        'ahora agrego selección.
                        Dim fila As DataRow = Ds_ajuste_masivo.Tables("Articulos_agregados").NewRow
                        Select Case nrocat
                            Case 1
                                fila("Condicion") = "Categoría"
                                fila("Descripción") = TreeView1.SelectedNode.Text
                            Case 2
                                fila("Condicion") = "Rubro"
                                fila("Descripción") = nombre_categoria + "/ " + TreeView1.SelectedNode.Text
                            Case 3
                                fila("Condicion") = "Subrubro"
                                fila("Descripción") = nombre_categoria + "/ " + nombre_rubro + "/ " + TreeView1.SelectedNode.Text
                        End Select
                        'fila("Descripción") = TreeView1.SelectedNode.Text
                        fila("ID_masivo") = idcat
                        fila("ID_nrocat") = nrocat
                        Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Add(fila)
                        GroupBox2.Enabled = False
                    Else
                        MessageBox.Show("Error, Ya exiten items vinculados a esta sección. Puede modificar la lista de artículos agregados.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                Else
                    MessageBox.Show("Error, El item ya fue agregado.", "Sistema de Gestión.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception

        End Try
        End If

    End Sub

    Private Sub DG_Producto_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_Producto.CellClick
        Dim celda_actual = e.ColumnIndex

        'If celda_actual = 0 Then 'la 0 es la que tiene el check
        Dim fila As Integer = DG_Producto.CurrentRow.Index
        Dim i As Integer = 0
        While i < DG_Producto.Rows.Count
            If i <> fila Then
                DG_Producto.Rows(i).Cells("Column1").Value = False
            End If
            i = i + 1
        End While
        DG_Producto.Rows(fila).Cells("Column1").Value = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If DG_Producto.Rows.Count <> 0 Then
            Dim i As Integer = 0
            While i < DG_Producto.Rows.Count
                If DG_Producto.Rows(i).Cells("Column1").Value = True Then 'el value en true significa que esta checkeado para eliminar
                    DG_Producto.Rows.RemoveAt(i)
                    Exit While 'como voy a borrar de a uno. pongo este exit.
                Else
                    i = i + 1
                End If
            End While
        Else

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Ds_ajuste_masivo.Tables("Articulos_agregados").Rows.Clear()
        GroupBox2.Enabled = True
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()

    End Sub
End Class