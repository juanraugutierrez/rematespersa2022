Public Class LotDes

    Public idRem As Integer
    Public Klotes As Integer
    Public total As Double
    Public listlotes As List(Of detLotDesa)
    Public DRemate As remates_mercaderia
    Public nroarticulos As Integer

    Sub New()

    End Sub

    Public Sub registra()
        Dim llote As New loteo
        Dim lotee As lotes

        For Each t As detLotDesa In Me.listlotes
            lotee = New lotes
            lotee.afecto = t.afect
            lotee.id_remate = idRem
            lotee.nro_lote = t.nroLote
            lotee.descripcion = t.descrip.ToUpper()
            lotee.nro_unidades = t.unidades
            lotee.papel = Nothing
            lotee.nrofactura = Nothing
            lotee.fecha_factura = Nothing
            lotee.adjudicatario = Nothing
            lotee.valor_comercial = 0
            lotee.ila = t.ila
            lotee.pasillo = 1
            lotee.id_ejecutivo = 0


            If IsNumeric(t.PrecioMinino) Then
                lotee.precio_minimo = t.PrecioMinino
            Else
                lotee.precio_minimo = 0
            End If

            lotee.precio_minimo = t.PrecioMinino
            lotee.precio_final = 0

            If IsNumeric(t.unidades) Then
                lotee.nro_unidades = t.unidades
            Else
                lotee.nro_unidades = 1
            End If

            lotee.nro_unidades_final = 0
            lotee.garantia = 0
            lotee.mandante = t.mandante
            lotee.sucursal = t.sucursal
            lotee.observaciones = "Carga-Desatendida  -  " & Now.ToShortDateString() & "  " & t.Observaciones
            lotee.pasillo = 1
            lotee.facturado = False
            lotee.liquidado = False
            lotee.desistido = 0
            lotee.ot = t.ot



            llote.carga(lotee)




            lotee = Nothing
        Next

    End Sub

    Sub calculatotales()
        Me.nroarticulos = 0
        Me.total = 0

        For Each t As detLotDesa In Me.listlotes
            Me.nroarticulos += t.unidades
            Me.Klotes += 1
            If IsNumeric(t.PrecioMinino) Then
                Me.total = t.PrecioMinino
            End If
        Next


    End Sub

    Public Sub cargar_detalle_masivo(dtgv As DataGridView)
        Dim deta As detLotDesa
        listlotes = Nothing
        listlotes = New List(Of detLotDesa)
        Dim a As Integer = 0



        For Each t As DataGridViewRow In dtgv.Rows
            deta = Nothing
            deta = New detLotDesa
            Try
                a = ++1

                If Not (IsNothing(t.Cells(1).Value)) Then
                    deta.nroLote = Convert.ToInt32(t.Cells(0).Value)
                    If IsDBNull(Convert.ToString(t.Cells(1).Value)) Then
                        deta.sBLote = ""
                    Else
                        deta.sBLote = Convert.ToString(t.Cells(1).Value).ToUpper()
                    End If


                    deta.descrip = Convert.ToString(t.Cells(2).Value)
                    deta.unidades = Convert.ToInt32(t.Cells(3).Value)

                    If IsDBNull(Convert.ToDouble(t.Cells(4).Value)) Then
                        deta.PrecioMinino = 0
                    Else
                        deta.PrecioMinino = Convert.ToDouble(t.Cells(4).Value)
                    End If

                    If IsDBNull(Convert.ToString(t.Cells(5).Value)) Then
                        deta.Observaciones = ""
                    Else
                        deta.Observaciones = Convert.ToString(t.Cells(5).Value).ToUpper()
                    End If

                    deta.mandante = Convert.ToString(t.Cells(6).Value).ToUpper()
                    If IsDBNull(Convert.ToString(t.Cells(7).Value)) Then
                        deta.sucursal = ""
                    Else
                        deta.sucursal = Convert.ToString(t.Cells(7).Value).ToUpper()
                    End If
                    deta.ila = Convert.ToBoolean(t.Cells(10).Value)
                    deta.ot = Convert.ToString(t.Cells(8).Value).ToUpper()
                    deta.afect = Convert.ToBoolean(t.Cells(9).Value)


                    Me.listlotes.Add(deta)
                End If
            Catch ex As Exception

                MsgBox("Error linea  " & a)

            End Try

        Next




    End Sub


End Class
