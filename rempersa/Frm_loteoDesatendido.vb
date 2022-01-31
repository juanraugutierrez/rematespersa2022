Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic



Public Class Frm_loteoDesatendido
    Inherits Form
    Dim remele As remates_mercaderia
    Private Shared frmInstance As Frm_loteoDesatendido = Nothing
    Public lto As LotDes

    Public Shared Function Instance() As Form
        If frmInstance Is Nothing OrElse frmInstance.IsDisposed = True Then
            frmInstance = New Frm_loteoDesatendido
        End If
        frmInstance.BringToFront()
        Return frmInstance
    End Function
    Dim reso As New resolucion
    Private Sub Frm_detalleVtaDirecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'reso.ajustarResolucion(Me)
        Me.DtgDetalle.Enabled = False
        BtnCargar.Enabled = False



        Try
            'Me.WindowState = FormWindowState.Normal
            ''Dim x As Integer
            'Dim y As Integer
            'x = Screen.PrimaryScreen.WorkingArea.Width / 2 - 500
            'y = Screen.PrimaryScreen.WorkingArea.Height / 2 - 350
            'Me.Location = New Point(x, y)
            Me.Cmb_remate.DataSource = (From re In contex.remates_mercaderia Order By re.id_remate Descending Select re).ToList()
            Me.Cmb_remate.DisplayMember = "codigo_remate"
            Me.Cmb_remate.ValueMember = "fecha_remate"
        Catch
        End Try



    End Sub

    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click

        Dim nro_loteF, discr As Integer
        Me.Cursor = Cursors.WaitCursor
        nro_loteF = (From l In contex.lotes Where l.id_remate = lto.idRem Select l.nro_lote).Max()
        discr = (From ll In lto.listlotes Select ll.nroLote).Min()
        If nro_loteF > discr Then
            Me.Cursor = Cursors.Default
            MsgBox("Error en el nro de lote. Corrija he intente na nueva carga", vbCritical, "Carga de lotes")
            Me.Cursor = Cursors.WaitCursor
            lto.listlotes = Nothing
            DtgDetalle.DataSource = Nothing
            DtgDetalle.Refresh()
            Me.Cursor = Cursors.Default

            Exit Sub
        End If
        lto.registra()
        Me.Cursor = Cursors.Default
        MsgBox("CARGA TERMINADA", vbCritical, "Carga de lotes")
        Me.DtgDetalle.DataSource = Nothing
        Frm_detalleVtaDirecta_Load(Me, e)
        contex.ExecuteStoreCommand("exec totales_remates {0}", lto.idRem)
        contex.SaveChanges()







    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub DtgDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtgDetalle.CellContentClick

    End Sub

    Private Sub BtnImportar_Click(sender As Object, e As EventArgs) Handles BtnImportar.Click
        Dim file As New OpenFileDialog
        Dim xsheet As String = String.Empty
        Dim ancho As Integer = 0

        lto = Nothing
        lto = New LotDes()



        With file
            .Filter = "Excel Worksheets|*.xl*"
            .Title = "Abrir Archivo"
            .ShowDialog()
        End With

        If file.FileName.ToString <> "" Then
            Dim excelfile As String = file.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDb.OleDbConnection

            xsheet = InputBox("Ingrese el nombre de la hoja", "Importacion", "")
            xsheet = String.Concat("[", xsheet, "$]")

            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties = 'Excel 8.0';Data Source=" + excelfile + ";")



            ' "Provider= Microsoft.ACE.OLEDB.12.0;" &
            '"Data Source= " & excelfile & ";" &
            '"Extended Properties = 'Excel 8.00 Xml;HDR=Yes'")
            Try
                Me.Cursor = Cursors.WaitCursor

                da = New OleDbDataAdapter("SELECT  * FROM  " & xsheet, conn)
                conn.Open()
                da.Fill(ds, "misdatos")
                dt = ds.Tables("misdatos")
                DtgDetalle.DataSource = ds
                DtgDetalle.DataMember = "misdatos"
                DtgDetalle.RowHeadersVisible = False

                Try

                    For Each oFila As DataRow In dt.Rows
                        If IsDBNull(oFila.Item(1)) Then
                            oFila.Item(1) = ""
                        End If
                        If IsDBNull(oFila.Item(3)) Then
                            oFila.Item(3) = 0
                        End If

                        If IsDBNull(oFila.Item(4)) Then
                            oFila.Item(4) = 0
                        End If
                        If IsDBNull(oFila.Item(7)) Then
                            oFila.Item(7) = ""
                        End If

                        If IsDBNull(oFila.Item(9)) Then
                            oFila.Item(9) = 1
                        End If
                        If IsDBNull(oFila.Item(10)) Then
                            oFila.Item(10) = 0
                        End If
                    Next
                Catch ex As Exception

                End Try



                ancho = DtgDetalle.Width

                With Me.DtgDetalle
                    .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                    .Columns(0).Width = ancho * 0.04
                    .Columns(1).Width = ancho * 0.04
                    .Columns(2).Width = ancho * 0.25
                    .Columns(3).Width = ancho * 0.05
                    .Columns(4).Width = ancho * 0.05
                    .Columns(5).Width = ancho * 0.22
                    .Columns(6).Width = ancho * 0.18
                    .Columns(7).Width = ancho * 0.05
                    .Columns(8).Width = ancho * 0.2
                    .Columns(9).Width = ancho * 0.01
                    .Columns(10).Width = ancho * 0.01



                    .Columns(0).HeaderText = "Nº Lote"
                    .Columns(1).HeaderText = "Sub Lote"
                    .Columns(2).HeaderText = "Descripcion"
                    .Columns(3).HeaderText = "Unidades"
                    .Columns(4).HeaderText = "Precio Precio Minimo"
                    .Columns(5).HeaderText = "Observaciones"
                    .Columns(6).HeaderText = "Mandante"
                    .Columns(7).HeaderText = "Sucursal"
                    .Columns(8).HeaderText = "ot"
                    .Columns(9).HeaderText = "Afecto"
                    .Columns(10).HeaderText = "Ila"


                End With



            Catch ex As Exception
                MsgBox("Ingrese un nombre valido de hoja de datos", vbCritical, "Error al cargar los datos")
                Me.GroupBox4.Enabled = False
                Me.DtgDetalle.DataSource = Nothing
                Me.Cursor = Cursors.Default
                Exit Sub
            Finally
                conn.Close()

            End Try


            lto.cargar_detalle_masivo(Me.DtgDetalle)
            lto.calculatotales()

            Me.TxtReg.Text = Format(lto.Klotes, " #,##0")
            Me.TxtUnid.Text = Format(lto.nroarticulos, " #,##0")
            Me.TxtNeto.Text = Format(lto.total, "$ #,##0")
            Me.GroupBox4.Enabled = True
        Else
            Me.GroupBox4.Enabled = False
            Me.DtgDetalle.DataSource = Nothing

        End If
        MsgBox("Lectura de los datos terminada", vbCritical, "Carga de lotes")
        Me.Cursor = Cursors.Default
        DtgDetalle.ScrollBars = ScrollBars.Vertical
        DtgDetalle.Refresh()

    End Sub

    Private Sub BtnImportar_DragEnter(sender As Object, e As DragEventArgs) Handles BtnImportar.DragEnter

    End Sub

    Private Sub Cmb_remate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_remate.SelectedIndexChanged
        Try
            lto.idRem = Nothing
            remele = Nothing
            remele = New remates_mercaderia
            Txt_fecha.Text = Cmb_remate.SelectedValue
            remele = Cmb_remate.SelectedItem
            'cargalote(remele.id_remate)
            'Me.Txt_detalle_especie.Focus()
            'Lbl_nlote.Text = llote.numlote(remele.id_remate)
            'Lbl_nlote.Text = (From c In contex.lotes Where c.id_remate = Cmb_remate.SelectedItem Select CInt(c.nro_lote)).Max()
            lto.idRem = remele.id_remate
            Me.BtnCargar.Enabled = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
