Public Class ConsultaTodosMovimientos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Private Sub ConsultaTodosMovimientos_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, Articulo.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, Almacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, TipoArticulo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, Subfamilia.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, IDObra.Value, FilterType.Numeric)
        e.Filter.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, FechaDocumentoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaDocumento", FilterOperator.LessThanOrEqual, FechaDocumentoHasta.Value, FilterType.DateTime)
        e.Filter.Add("Documento", FilterOperator.Equal, Documento.Text, FilterType.String)
        e.Filter.Add("IDTipoMovimiento", FilterOperator.Equal, TipoMovimiento.Value, FilterType.Numeric)


    End Sub

    Private Sub ConsultaTodosMovimientos_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim Fecha1 As Date
        Dim Fecha2 As Date
        Dim Familia As String
        Dim obra As String
        ' Dim vAnio As Integer
        Dim cancel As Boolean
        If e.Alias = "INFENCOFRADO" Then
            'Abrir Informe de Beneficio2 - informe transferencias encofrado

            Dim frm As New frmInformeFechaEncofrado
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text
            Familia = AdvFamilia.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio2(CDate(Fecha1), CDate(Fecha2), Familia)

            e.Cancel = True
        ElseIf e.Alias = "INFENCOTODOS" Then
            Dim frm As New frmInformeFechaEncofrado
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text
            Familia = AdvFamilia.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio4(CDate(Fecha1), CDate(Fecha2), Familia)

            e.Cancel = True
        End If
    End Sub
    Private Sub GenerarInformeBeneficio2(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        Dim rp As New Report("INFENCOFRADO")
        Dim filtro As New Filter
        Dim laborables As String
        'Dim e As Engine.UI.ReportDesignObjectsEventArgs
        laborables = Dias_naturales(Fecha1, Fecha2)
        'filtro.Add("Nobra", FilterOperator.Equal, obra)
        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.
        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)


        'filtro.Add("idfamilia", FilterOperator.Equal, "3010")
        rp.DataSource = New BE.DataEngine().Filter("vFrmTransferenciasEncofrados2E4_1", filtro)

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia
            'familia = "3010"

            Dim strSelect As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect &= "FROM tbhistoricomovimientoE4 "
            strSelect &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            strSelect &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1') AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect &= "ORDER BY dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.IDArticulo "
            'MsgBox(strSelect)

            Dim strSelect2 As String = "SELECT * FROM vFrmCIMovimientosE4_1 where FechaDocumento <'" & Fecha1 & "' AND IDFamilia='" & familia & "' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') order by IDLineaMovimiento desc"

            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInformeBeneficio3(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        Dim rp As New Report("INFENCOFRADO2")
        Dim filtro As New Filter
        Dim laborables As String
        'Dim e As Engine.UI.ReportDesignObjectsEventArgs
        laborables = Dias_naturales(Fecha1, Fecha2)
        'filtro.Add("Nobra", FilterOperator.Equal, obra)
        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.
        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)
        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        'filtro.Add("idfamilia", FilterOperator.Equal, familia)
        'filtro.Add("idfamilia", FilterOperator.Equal, "0210")
        rp.DataSource = New BE.DataEngine().Filter("vFrmTransferenciasEncofrados2_1", filtro)
        Dim dt As New DataTable
        Dim dt2 As New DataTable
        'dt = New BE.DataEngine().Filter("vFrmTransferenciasEncofrados2_1", filtro)


        'COPIO la tabla con los filtros de familia. Si es igual a familia o a 0210
        'Dim cont As Integer = 0
        'For i As Integer = 0 To dt.Columns.Count - 1
        '    dt2.Columns.Add(dt.Columns(i).ColumnName)
        'Next
        'For Each dr As DataRow In dt.Rows
        '    If dt.Rows(cont)("IDFamilia") = familia Or dt.Rows(cont)("IDFamilia") = "0210" Then
        '        dt2.Rows.Add(dt.Rows(cont).ItemArray)
        '    End If
        '    cont += 1
        'Next
        'rp.DataSource = dt2


        'Dim Dt As DataTable = AdminData.Execute("exec sp_TransferenciasEncofrado '0210'")
        'rp.DataSource = New BE.DataEngine().Filter(Dt, filtro)
        'rp.DataSource = New BE.DataEngine().Filter("exec sp_TransferenciasEncofrado '0210' ", filtro)
        For Each drfam As DataRow In dtFam.Rows
            rp.Formulas("Familia").Text = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            'rp.Formulas("Familia").Text = dFamilia
            familia = "0210"
            Dim strSelect As String = "SELECT dbo.tbHistoricoMovimientoExp4.IDLineaMovimiento, dbo.tbHistoricoMovimientoExp4.IDMovimiento, "
            strSelect &= "dbo.tbMaestroTipoMovimientoExp4.CodTipoMovimiento, dbo.tbHistoricoMovimientoExp4.IDArticulo, dbo.tbMaestroArticuloExp4.DescArticulo, "
            strSelect &= "dbo.tbHistoricoMovimientoExp4.Cantidad, dbo.tbHistoricoMovimientoExp4.IDAlmacen, dbo.tbHistoricoMovimientoExp4.Lote, dbo.tbHistoricoMovimientoExp4.Ubicacion, "
            strSelect &= "dbo.tbHistoricoMovimientoExp4.FechaDocumento, dbo.tbHistoricoMovimientoExp4.Acumulado, dbo.tbHistoricoMovimientoExp4.FechaMovimiento, "
            strSelect &= "dbo.tbHistoricoMovimientoExp4.PrecioA, dbo.tbHistoricoMovimientoExp4.PrecioB, dbo.tbMaestroArticuloExp4.IDTipo, dbo.tbMaestroArticuloExp4.IDFamilia, "
            strSelect &= "dbo.tbMaestroArticuloExp4.IDSubfamilia, dbo.tbHistoricoMovimientoExp4.IDTipoMovimiento, dbo.tbHistoricoMovimientoExp4.Documento, "
            strSelect &= "dbo.tbMaestroArticuloExp4.NSerieObligatorio, dbo.tbHistoricoMovimientoExp4.IDObra, dbo.tbObraCabeceraExp4.NObra, dbo.tbMaestroArticuloExp4.ValorReposicionA, "
            strSelect &= "dbo.tbMaestroArticuloExp4.PrecioEstandarA "
            strSelect &= "FROM dbo.tbObraCabeceraExp4 RIGHT OUTER JOIN "
            strSelect &= "dbo.tbMaestroTipoMovimientoExp4 INNER JOIN "
            strSelect &= "dbo.tbHistoricoMovimientoExp4 ON dbo.tbMaestroTipoMovimientoExp4.IDTipoMovimiento = dbo.tbHistoricoMovimientoExp4.IDTipoMovimiento ON "
            strSelect &= "dbo.tbObraCabeceraExp4.IDObra = dbo.tbHistoricoMovimientoExp4.IDObra LEFT OUTER JOIN "
            strSelect &= "dbo.tbMaestroArticuloExp4 ON dbo.tbHistoricoMovimientoExp4.IDArticulo = dbo.tbMaestroArticuloExp4.IDArticulo INNER JOIN "
            strSelect &= "dbo.tbMaestroAlmacenExp4 ON dbo.tbHistoricoMovimientoExp4.IDAlmacen = dbo.tbMaestroAlmacenExp4.IDAlmacen INNER JOIN "
            strSelect &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect &= "FROM tbhistoricomovimientoExp4 "
            strSelect &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoExp4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect &= "dbo.tbHistoricoMovimientoExp4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoExp4.FechaDocumento "
            strSelect &= "WHERE (dbo.tbMaestroTipoMovimientoExp4.CodTipoMovimiento = 'T+' OR "
            strSelect &= "dbo.tbMaestroTipoMovimientoExp4.CodTipoMovimiento = 'T-') AND (dbo.tbMaestroAlmacenExp4.Activo = 1) AND (dbo.tbMaestroArticuloExp4.IDFamilia = '" & familia & "') "
            strSelect &= "ORDER BY dbo.tbHistoricoMovimientoExp4.IDAlmacen, dbo.tbHistoricoMovimientoExp4.IDArticulo "
            MsgBox(strSelect)


            rp.Subreports("acumuladoMesAnt").DataSource = arti.DevuelveTabla2(strSelect)
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Dias_naturales(ByVal Fecha1 As Object, ByVal Fecha2 As Object) As Integer
        ' No descuenta los Dias Festivos.
        Dim WholeWeeks As Object
        Dim DateCnt As Object
        Dim EndDays As Integer

        Fecha1 = DateValue(Fecha1)
        Fecha2 = DateValue(Fecha2)
        WholeWeeks = DateDiff("w", Fecha1, Fecha2)
        DateCnt = DateAdd("ww", WholeWeeks, Fecha1)
        EndDays = 0
        Do While DateCnt < Fecha2
            'If Format(DateCnt, "ddd") <> "Sun" And _
            'Format(DateCnt, "ddd") <> "Sat" Then
            EndDays = EndDays + 1
            'End If
            DateCnt = DateAdd("d", 1, DateCnt)
        Loop
        Dias_naturales = WholeWeeks * 5 + EndDays
    End Function

    Private Sub GenerarInformeBeneficio4(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCOTODOS
        Dim rp As New Report("INFENCOTODOS")
        Dim filtro As New Filter
        Dim laborables As String

        'Saco los disas laboranles

        laborables = Dias_naturales(Fecha1, Fecha2)
        'filtro.Add("Nobra", FilterOperator.Equal, obra)
        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.
        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Business.Negocio.Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)
        filtro.Add("Activo", FilterOperator.Equal, 1)


        'filtro.Add("idfamilia", FilterOperator.Equal, "3010")
        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <'" & Fecha2 & "' AND Activo= 1 AND IDFamilia='" & idfamilia & "'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)
        'rp.DataSource = New BE.DataEngine().Filter("vFrmTransferenciasEncofrados2E4_1", filtro)
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia
            'familia = "3010"

            'Dim strSelect As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            'strSelect &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            'strSelect &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            'strSelect &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            'strSelect &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            'strSelect &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            'strSelect &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            'strSelect &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            'strSelect &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            'strSelect &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            'strSelect &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            'strSelect &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            'strSelect &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            'strSelect &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            'strSelect &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            'strSelect &= "FROM tbhistoricomovimientoE4 "
            'strSelect &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            'strSelect &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            'strSelect &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            'strSelect &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            'strSelect &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1') AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            'strSelect &= "ORDER BY dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.IDArticulo "
            'MsgBox(strSelect)
            'Dim al As String
            'al = "011"
            Dim strSelect2 As String = "SELECT * FROM vFrmCIMovimientosE4_1 where FechaDocumento <'" & Fecha1 & "' AND Activo= 1 AND PrecioEstandarA!=0 AND IDFamilia='" & familia & "' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') order by IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class