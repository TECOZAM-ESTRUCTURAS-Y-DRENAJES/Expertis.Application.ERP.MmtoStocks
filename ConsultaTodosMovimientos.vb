﻿Imports Solmicro.Expertis.Business
Imports System.Data.SqlClient

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
        Dim Tipo As String
        Dim obra As String

        If e.Alias = "INFENCOSUBFAM" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value
            'Familia = AdvFamilia.Text

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamilia(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeBeneficio10(CDate(Fecha1), CDate(Fecha2), Familia)

            'e.Cancel = True
            GeneraInforme("INFENCOSUBFAM", e)

        ElseIf e.Alias = "INFENCORESUB" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value
            'Familia = AdvFamilia.Text

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeBeneficio10Resumen(CDate(Fecha1), CDate(Fecha2), Familia)

            'e.Cancel = True
            GeneraInforme("INFENCORESUB", e)

        ElseIf e.Alias = "COSTESFAMILIA" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value
            'Familia = AdvFamilia.Text

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeBeneficio20(CDate(Fecha1), CDate(Fecha2), Familia)

            'e.Cancel = True
            GeneraInforme("COSTESFAMILIA", e)

        ElseIf e.Alias = "COSTES3017" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value
            'Familia = AdvFamilia.Text

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeCostes3017(CDate(Fecha1), CDate(Fecha2), Familia)

            'e.Cancel = True
            ''Pruebas de solución de problemas
            ''19/01/2023
            GeneraInforme("COSTES3017", e)

        ElseIf e.Alias = "COSTESESCALERAS" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeCostesEscaleras(CDate(Fecha1), CDate(Fecha2))

            'e.Cancel = True
            Dim result As DialogResult = MessageBox.Show("¿Quieres sacar el resumen de las escaleras?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim condicionEscaleras As String = "AND (IDArticulo='0000000340' OR IDArticulo='2127711' OR IDArticulo='0000000754' OR IDArticulo='0000000417')"
            If result = DialogResult.Yes Then
                GeneraInforme("COSTESCRES", e, condicionEscaleras)
            Else
                GeneraInforme("COSTESESCALERAS", e, condicionEscaleras)
            End If

        ElseIf e.Alias = "COSTES3027" Then
            'Dim frm As New frmInformeFechaEncofrado
            'frm.ShowDialog()
            'Fecha1 = frm.FechaDesde.Value
            'Fecha2 = frm.FechaHasta.Value
            'Familia = AdvFamilia.Text

            'If frm.blEstado = True Then
            '    MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    e.Cancel = True
            '    Exit Sub
            'End If
            ''GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            'GenerarInformeCostes3027(CDate(Fecha1), CDate(Fecha2), Familia)

            'e.Cancel = True
            ''Pruebas de solución de problemas
            ''19/01/2023
            Dim result As DialogResult = MessageBox.Show("¿Quieres sacar el resumen de los utiles?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim condicion3027 As String = "AND (Alias='UDC-015' OR Alias='UDC-018' OR Alias='UDC-019')"
            If result = DialogResult.Yes Then
                GeneraInforme("COSTES3027Resumen", e, condicion3027)
            Else
                GeneraInforme("COSTES3027", e, condicion3027)
            End If

        ElseIf e.Alias = "INFTIPO30F" Then
            Dim frm As New frmInformeFechaEncofrado
            frm.ShowDialog()
            Fecha1 = frm.FechaDesde.Value
            Fecha2 = frm.FechaHasta.Value
            Familia = AdvFamilia.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficioPorSubFamiliaResumen(CDate(Fecha1), CDate(Fecha2), Familia)
            GenerarInformeCostes3017Fixing(CDate(Fecha1), CDate(Fecha2), Familia)

            e.Cancel = True
        ElseIf e.Alias = "MOVOBRAFECHA" Then
            MsgBox("Seleccione tipo(30), familia y obra")
            Dim frm As New frmInformeFechaEncofrado
            frm.ShowDialog()
            Fecha1 = frm.FechaDesde.Value
            Fecha2 = frm.FechaHasta.Value
            Familia = AdvFamilia.Text
            Tipo = TipoArticulo.Text

            obra = Almacen.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarInformeMovimientos("MOVOBRAFECHA", CDate(Fecha1), CDate(Fecha2), Familia, obra, Tipo)

            e.Cancel = True
        ElseIf e.Alias = "MOVFERR" Then
            Dim frm As New frmInformeFechaFamilia
            frm.ShowDialog()

            Familia = frm.cbFamilia.Text
            obra = frm.AdvAlmacen.Value
            Dim valorado As Boolean
            valorado = frm.cbValorado.Checked

            Dim sql As String
            Dim tabla As New DataTable
            Dim arti As New Business.Negocio.Articulo
            'Si es Ferreteria
            If Familia = 2001 Then
                sql = "select CodTipoMovimiento, IDArticulo, DescArticulo, Cantidad, IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientosE4 where (IDFamilia='2001' OR IDFamilia='0201') AND IDAlmacen='" & obra & "' AND FechaDocumento<'01/01/2022' "
                sql &= "UNION ALL "
                sql &= "select CodTipoMovimiento, IDArticulo, DescArticulo, Abs(Cantidad), IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientos "
                sql &= "where (IDFamilia='2001' OR IDFamilia='0201') AND (IDAlmacen='" & obra & "' OR NObra='alq-" & obra & "') AND FechaDocumento <'16/06/2022' "
                sql &= "UNION ALL "
                sql &= "select CodTipoMovimiento, IDArticulo, DescArticulo, Cantidad, IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientos "
                sql &= "where (IDFamilia='2001' OR IDFamilia='0201') AND (IDAlmacen='" & obra & "' OR NObra='alq-" & obra & "') AND FechaDocumento >='16/06/2022' AND CodTipoMovimiento!='S1'  order by FechaDocumento"

                tabla = arti.DevuelveTabla2(sql)
                'Si es Madera
            Else
                sql = "select CodTipoMovimiento, IDArticulo, DescArticulo, Cantidad, IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientosE4 where (IDFamilia='2002' OR IDFamilia='0202') AND IDAlmacen='" & obra & "' AND FechaDocumento<'01/01/2022' "
                sql &= "UNION ALL "
                sql &= "select CodTipoMovimiento, IDArticulo, DescArticulo, Abs(Cantidad), IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientos "
                sql &= "where (IDFamilia='2002' OR IDFamilia='0202') AND (IDAlmacen='" & obra & "' OR NObra='alq-" & obra & "') AND FechaDocumento <'16/06/2022' "
                sql &= "UNION ALL "
                sql &= "select CodTipoMovimiento, IDArticulo, DescArticulo, Cantidad, IDAlmacen, Documento, FechaDocumento, IDTipo, IDFamilia, ValorReposicionA, PrecioEstandarA, IDUdInterna "
                sql &= "from xtecozam50r2..vFrmCIMovimientos "
                sql &= "where (IDFamilia='2002' OR IDFamilia='0202') AND (IDAlmacen='" & obra & "' OR NObra='alq-" & obra & "') AND FechaDocumento >='16/06/2022' AND CodTipoMovimiento!='S1'  order by FechaDocumento"

                tabla = arti.DevuelveTabla2(sql)
            End If

            Dim rp As New Report("MOVFERR")
            rp.Formulas("Obra").Text = obra
            rp.DataSource = tabla
            ExpertisApp.OpenReport(rp)
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
        Dim rp As New Report("IBISPRUEBA")
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
        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <'" & Fecha2 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' "
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

            'Dim strSelect2 As String = "SELECT * FROM vFrmCIMovimientosE4_1 where FechaDocumento <'" & Fecha1 & "' AND Activo= 1 AND PrecioEstandarA!=0 AND IDFamilia='" & familia & "' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') order by IDLineaMovimiento desc"
            'Dim strSelect2 As String = "SELECT  Max(FechaDocumento) as fecha , IDArticulo, IDAlmacen FROM vFrmCIMovimientosE4_1 where FechaDocumento <'01/04/22' AND Activo= 1  AND PrecioEstandarA!=0 AND IDFamilia='3010' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') group by IDArticulo, IDAlmacen"

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo "


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInformeBeneficio5(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
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

    Private Sub GenerarInformeBeneficioPorSubFamilia(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCOSUBFAM
        Dim rp As New Report("INFENCOSUBFAM")
        Dim filtro As New Filter
        Dim laborables As String

        'Saco los disas laboranles

        laborables = Dias_naturales(Fecha1, Fecha2)

        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Business.Negocio.Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)

        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)
        filtro.Add("Activo", FilterOperator.Equal, 1)

        Dim almace As String
        almace = "012"
        Dim almace2 As String
        almace2 = "DP19"
        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <'" & Fecha2 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)
        'Recorro tabla y pongo en IDSubfamilia la agrupación
        'Elemento, viga, tornillo, puntal, otros
        For Each dr As DataRow In tabla3.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If

        Next
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia
            Dim strSelect2 As String = "SELECT * FROM vFrmCIMovimientosE4_1 where FechaDocumento <'" & Fecha1 & "' AND Activo= 1 AND PrecioEstandarA!=0 AND IDFamilia='" & familia & "' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') order by IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            For Each dr As DataRow In tabla.Rows
                If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                    dr("IDSubfamilia") = "ELEMENTO MARCO"
                ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                    dr("IDSubfamilia") = "MARCO-TEC"
                ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                    dr("IDSubfamilia") = "MEDIO MOLDE"
                ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                    dr("IDSubfamilia") = "ORMA"
                ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                    dr("IDSubfamilia") = "VIGA"
                ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                    dr("IDSubfamilia") = "PUNTAL"
                ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                    dr("IDSubfamilia") = "TABICA"
                ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                    dr("IDSubfamilia") = "TORNILLO"
                ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Then
                    dr("IDSubfamilia") = "SOPORTES BARANDILLA"
                ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                    dr("IDSubfamilia") = "SOPORTE CONSOLA"
                Else
                    dr("IDSubfamilia") = "OTROS"
                End If

            Next
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerarInformeBeneficioPorSubFamiliaResumen(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCORESUB
        Dim rp As New Report("INFENCORESUB")
        Dim filtro As New Filter
        Dim laborables As String

        'Saco los disas laboranles

        laborables = Dias_naturales(Fecha1, Fecha2)

        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Business.Negocio.Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)

        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)
        filtro.Add("Activo", FilterOperator.Equal, 1)

        Dim almace As String
        almace = "012"
        Dim almace2 As String
        almace2 = "DP19"
        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <'" & Fecha2 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)
        'Recorro tabla y pongo en IDSubfamilia la agrupación
        'Elemento, viga, tornillo, puntal, otros
        For Each dr As DataRow In tabla3.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If

        Next

        LimpiaAcumuladoNegativo(tabla3)
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia
            Dim strSelect2 As String = "SELECT * FROM vFrmCIMovimientosE4_1 where FechaDocumento <'" & Fecha1 & "' AND Activo= 1 AND PrecioEstandarA!=0 AND IDFamilia='" & familia & "' AND (CodTipoMovimiento='T-' OR CodTipoMovimiento='T+' OR CodTipoMovimiento='S1') order by IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            For Each dr As DataRow In tabla.Rows
                If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                    dr("IDSubfamilia") = "ELEMENTO MARCO"
                ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                    dr("IDSubfamilia") = "MARCO-TEC"
                ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                    dr("IDSubfamilia") = "MEDIO MOLDE"
                ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                    dr("IDSubfamilia") = "ORMA"
                ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                    dr("IDSubfamilia") = "VIGA"
                ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                    dr("IDSubfamilia") = "PUNTAL"
                ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                    dr("IDSubfamilia") = "TABICA"
                ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                    dr("IDSubfamilia") = "TORNILLO"
                ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Then
                    dr("IDSubfamilia") = "SOPORTES BARANDILLA"
                ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                    dr("IDSubfamilia") = "SOPORTE CONSOLA"
                Else
                    dr("IDSubfamilia") = "OTROS"
                End If


            Next
            LimpiaAcumuladoNegativo(tabla)
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerarInformeMovimientos(ByVal sInforme As String, ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String, ByVal obra As String, ByVal tipo As String)
        Dim respuesta As DialogResult = MessageBox.Show("¿Quieres generar el informe resumido?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            sInforme = "MOVOBRAFECHRESUMEN"
        End If

        Dim rp As New Report(sInforme)
        Dim filtro As New Filter
        Dim dt As New DataTable

        filtro.Add("IDAlmacen", FilterOperator.Equal, obra)
        filtro.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        If (idfamilia.Length.ToString <> 0) Then
            filtro.Add("IDFamilia", FilterOperator.Equal, idfamilia)
        End If
        filtro.Add("CodTipoMovimiento", FilterOperator.NotEqual, "C")
        If sInforme = "MOVOBRAFECHRESUMEN" Then
            rp.DataSource = New BE.DataEngine().Filter("vFrmCIMovimientosE4_1", filtro, , "FechaDocumento desc")
            respuesta = MessageBox.Show("¿Quieres generar también los registros que tuvieran 0?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.Yes Then
                rp.Formulas("Acumulado0").Text = 1
            Else
                rp.Formulas("Acumulado0").Text = 0
            End If
        Else
            rp.DataSource = New BE.DataEngine().Filter("vFrmCIMovimientosE4_1", filtro)

        End If
        rp.Formulas("fecha1").Text = Fecha1
        rp.Formulas("fecha2").Text = Fecha2
        rp.Formulas("IDFamilia").Text = idfamilia
        ExpertisApp.OpenReport(rp)
    End Sub

    'LOS INFORMES ACTUALES Y DEFINITIVOS
    'David Velasco 16/06/2022

    Private Sub GenerarInformeBeneficio10(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCOTODOS
        Dim rp As New Report("INFENCOSUBFAM")
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

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and FechaDocumento <>'" & Fecha1 & "' AND IDArticulo!='0000000213' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        For Each dr As DataRow In tabla3.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If

        Next

        'DAVID VELASCO 13/05/24 LIMPIEZA ACUMULADO NEGATIVO
        LimpiaAcumuladoNegativo(tabla3)

        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            For Each dr As DataRow In tabla.Rows
                If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                    dr("IDSubfamilia") = "ELEMENTO MARCO"
                ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                    dr("IDSubfamilia") = "MARCO-TEC"
                ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                    dr("IDSubfamilia") = "MEDIO MOLDE"
                ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                    dr("IDSubfamilia") = "ORMA"
                ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                    dr("IDSubfamilia") = "VIGA"
                ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                    dr("IDSubfamilia") = "PUNTAL"
                ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                    dr("IDSubfamilia") = "TABICA"
                ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                    dr("IDSubfamilia") = "TORNILLO"
                ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                    dr("IDSubfamilia") = "SOPORTES BARANDILLA"
                ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                    dr("IDSubfamilia") = "SOPORTE CONSOLA"
                Else
                    dr("IDSubfamilia") = "OTROS"
                End If

            Next

            LimpiaAcumuladoNegativo(tabla)

            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LimpiaAcumuladoNegativo(ByRef dt As DataTable)
        For Each dr As DataRow In dt.Rows
            If dr("Acumulado") < 0 Then
                dr("Acumulado") = 0
            End If
        Next
    End Sub
    Private Sub GenerarInformeBeneficio20(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCOTODOS
        Dim rp As New Report("COSTESFAMILIA")
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

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and fechaDocumento<>'" & Fecha1 & "' AND IDArticulo!='0000000213' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)


        For Each dr As DataRow In tabla3.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If

        Next

        LimpiaAcumuladoNegativo(tabla3)
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            For Each dr As DataRow In tabla.Rows
                If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                    dr("IDSubfamilia") = "ELEMENTO MARCO"
                ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                    dr("IDSubfamilia") = "MARCO-TEC"
                ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                    dr("IDSubfamilia") = "MEDIO MOLDE"
                ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                    dr("IDSubfamilia") = "ORMA"
                ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                    dr("IDSubfamilia") = "VIGA"
                ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                    dr("IDSubfamilia") = "PUNTAL"
                ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                    dr("IDSubfamilia") = "TABICA"
                ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                    dr("IDSubfamilia") = "TORNILLO"
                ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                    dr("IDSubfamilia") = "SOPORTES BARANDILLA"
                ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                    dr("IDSubfamilia") = "SOPORTE CONSOLA"
                Else
                    dr("IDSubfamilia") = "OTROS"
                End If

            Next

            LimpiaAcumuladoNegativo(tabla)

            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInformeBeneficio10Resumen(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCORESUB
        Dim rp As New Report("INFENCORESUB")
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

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and fechaDocumento<>'" & Fecha1 & "'  AND IDArticulo!='0000000213' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "'and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        For Each dr As DataRow In tabla3.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If

        Next
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)
            For Each dr As DataRow In tabla.Rows
                If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                    dr("IDSubfamilia") = "ELEMENTO MARCO"
                ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                    dr("IDSubfamilia") = "MARCO-TEC"
                ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                    dr("IDSubfamilia") = "MEDIO MOLDE"
                ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                    dr("IDSubfamilia") = "ORMA"
                ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                    dr("IDSubfamilia") = "VIGA"
                ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                    dr("IDSubfamilia") = "PUNTAL"
                ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                    dr("IDSubfamilia") = "TABICA"
                ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                    dr("IDSubfamilia") = "TORNILLO"
                ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                    dr("IDSubfamilia") = "SOPORTES BARANDILLA"
                ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                    dr("IDSubfamilia") = "SOPORTE CONSOLA"
                Else
                    dr("IDSubfamilia") = "OTROS"
                End If

            Next
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInformeCostes3017(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        'Creo instancia del informe con Alias: INFENCOTODOS
        Dim rp As New Report("COSTES3017")
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

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and fechaDocumento<>'" & Fecha1 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        LimpiaAcumuladoNegativo(tabla3)
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"

            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)

            LimpiaAcumuladoNegativo(tabla)

            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GenerarInformeCostesEscaleras(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Dim result As DialogResult = MessageBox.Show("¿Quieres sacar el resumen de las escaleras?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim rp As Report
        If result = DialogResult.Yes Then
            rp = New Report("COSTESCRES")
        Else
            rp = New Report("COSTESESCALERAS")
        End If

        Dim filtro As New Filter
        Dim laborables As String

        laborables = Dias_naturales(Fecha1, Fecha2)
        'filtro.Add("Nobra", FilterOperator.Equal, obra)
        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.
        Dim arti As New Business.Negocio.Articulo

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("Activo", FilterOperator.Equal, 1)

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and fechaDocumento<>'" & Fecha1 & "' AND PrecioEstandarA!=0 AND Activo= 1 and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951' and (IDArticulo='0000000340' or IDArticulo='2127711' or IDArticulo='0000000754' or IDArticulo='0000000417')"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        LimpiaAcumuladoNegativo(tabla3)
        rp.DataSource = tabla3

        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1)"
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1)"
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"


            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)

            LimpiaAcumuladoNegativo(tabla)

            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub GenerarInformeCostes3027(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        Dim result As DialogResult = MessageBox.Show("¿Quieres sacar el resumen de los utiles?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim rp As Report
        If result = DialogResult.Yes Then
            rp = New Report("COSTES3027Resumen")
        Else
            rp = New Report("COSTES3027")
        End If

        Dim filtro As New Filter
        Dim laborables As String

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

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' and fechaDocumento<>'" & Fecha1 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951' and (Alias='UDC-015' Or Alias='UDC-018' Or Alias='UDC-019')"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        LimpiaAcumuladoNegativo(tabla3)
        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"

            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)

            LimpiaAcumuladoNegativo(tabla)
            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    'David Velasco Herrero 19/01/23 Solución error suma subinforme
    Private Sub GenerarInformeCostes3017fixing(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        Dim rp As New Report("COSTES3017")
        Dim filtro As New Filter
        Dim laborables As String

        'Saco los disas laboranles

        laborables = Dias_naturales(Fecha1, Fecha2)

        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Business.Negocio.Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)

        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)
        filtro.Add("Activo", FilterOperator.Equal, 1)

        Dim strSelect3 As String = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1 where FechaDocumento <='" & Fecha2 & "' AND FechaDocumento >'" & Fecha1 & "' AND PrecioEstandarA!=0 AND Activo= 1 AND IDFamilia='" & idfamilia & "' and CodTipoMovimiento<>'C' AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'"
        Dim tabla3 As New DataTable
        tabla3 = arti.DevuelveTabla2(strSelect3)

        rp.DataSource = tabla3

        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect2 As String = "SELECT dbo.tbHistoricoMovimientoE4.IDLineaMovimiento, dbo.tbHistoricoMovimientoE4.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento, dbo.tbHistoricoMovimientoE4.IDArticulo, dbo.tbMaestroArticuloE4.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.Cantidad, dbo.tbHistoricoMovimientoE4.IDAlmacen, dbo.tbHistoricoMovimientoE4.Lote, dbo.tbHistoricoMovimientoE4.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.FechaDocumento, dbo.tbHistoricoMovimientoE4.Acumulado, dbo.tbHistoricoMovimientoE4.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.PrecioA, dbo.tbHistoricoMovimientoE4.PrecioB, dbo.tbMaestroArticuloE4.IDTipo, dbo.tbMaestroArticuloE4.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.IDSubfamilia, dbo.tbHistoricoMovimientoE4.IDTipoMovimiento, dbo.tbHistoricoMovimientoE4.Documento, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.NSerieObligatorio, dbo.tbHistoricoMovimientoE4.IDObra, dbo.tbObraCabeceraE4.NObra, dbo.tbMaestroArticuloE4.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticuloE4.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabeceraE4 RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4 INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4 ON dbo.tbMaestroTipoMovimientoE4.IDTipoMovimiento = dbo.tbHistoricoMovimientoE4.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabeceraE4.IDObra = dbo.tbHistoricoMovimientoE4.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticuloE4 ON dbo.tbHistoricoMovimientoE4.IDArticulo = dbo.tbMaestroArticuloE4.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacenE4 ON dbo.tbHistoricoMovimientoE4.IDAlmacen = dbo.tbMaestroAlmacenE4.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimientoE4 "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimientoE4.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimientoE4.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimientoE4.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimientoE4.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacenE4.Activo = 1) AND (dbo.tbMaestroArticuloE4.IDFamilia = '" & familia & "') "
            strSelect2 &= "UNION ALL "
            strSelect2 &= "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <='" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E3' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'E1' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S1' OR dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'S7') AND PrecioEstandarA!=0 AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect2 &= "ORDER BY IDAlmacen, IDArticulo, FechaDocumento desc, IDLineaMovimiento desc"

            Dim tabla As New DataTable
            tabla = arti.DevuelveTabla2(strSelect2)

            rp.Subreports("acumuladoMesAnt").DataSource = tabla
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    ' 21/05/2024 - dfernandez
    Public Function EjecutarConsulta(ByVal consulta As String) As DataTable

        Dim dt As New DataTable()
        Dim myConn As New SqlConnection
        myConn = New SqlConnection("Data Source=stecodesarr;Initial Catalog=xTecozam50R2;User ID=sa;Password=180M296;")
        Dim myCmd As SqlCommand

        myCmd = New SqlCommand(consulta, myConn)

        Dim adp As New SqlDataAdapter(myCmd)

        adp.Fill(dt)

        myConn.Close()

        Return dt
    End Function

    ' 21/05/2024 - dfernandez
    Public Sub AñadeSubfamilias(ByVal dt As DataTable)

        For Each dr As DataRow In dt.Rows
            If dr("DescArticulo").ToString.Contains("ELEMENTO") Or dr("DescArticulo").ToString.Contains("ESQUINA") Then
                dr("IDSubfamilia") = "ELEMENTO MARCO"
            ElseIf dr("DescArticulo").ToString.Contains("MARCO-TEC") Then
                dr("IDSubfamilia") = "MARCO-TEC"
            ElseIf dr("DescArticulo").ToString.Contains("MEDIO MOLDE") Or dr("DescArticulo").ToString.Contains("ZUNCHO") Then
                dr("IDSubfamilia") = "MEDIO MOLDE"
            ElseIf dr("DescArticulo").ToString.Contains("PANEL") Then
                dr("IDSubfamilia") = "ORMA"
            ElseIf dr("DescArticulo").ToString.Contains("VIGA") Or dr("DescArticulo").ToString.Contains("RIPADO") Then
                dr("IDSubfamilia") = "VIGA"
            ElseIf dr("DescArticulo").ToString.Contains("PUNTAL") Or dr("DescArticulo").ToString.Contains("+") Then
                dr("IDSubfamilia") = "PUNTAL"
            ElseIf dr("DescArticulo").ToString.Contains("TABICA") Then
                dr("IDSubfamilia") = "TABICA"
            ElseIf dr("DescArticulo").ToString.Contains("TORNILLO") Then
                dr("IDSubfamilia") = "TORNILLO"
            ElseIf dr("DescArticulo").ToString.Contains("BARANDILLA") Or dr("DescArticulo").ToString = "CABEZAL FRONTAL ORMA" Then
                dr("IDSubfamilia") = "SOPORTES BARANDILLA"
            ElseIf dr("DescArticulo").ToString.Contains("SOPORTE CONSOLA") Then
                dr("IDSubfamilia") = "SOPORTE CONSOLA"
            Else
                dr("IDSubfamilia") = "OTROS"
            End If
        Next
    End Sub

    ' 21/05/2024 - dfernandez
    Public Sub GeneraInforme(ByVal informe As String, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs, Optional ByVal condiciones As String = "")
        Dim rp As New Report(informe)
        Dim m As New Negocio.Articulo
        Dim Fecha1 As Date : Dim Fecha2 As Date : Dim familia As String

        Dim frm As New frmInformeFechasFamilia
        frm.EstablecerModoPorInforme(informe)
        frm.ShowDialog()

        If frm.blEstado = True Then
            MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
            Exit Sub
        End If

        Fecha1 = frm.cFechaDesde.Value
        Fecha2 = frm.cFechaHasta.Value
        familia = frm.advFamilia.Value

        Dim laborables As String = Dias_naturales(Fecha1, Fecha2)

        Dim dFamilia As String
        Dim dtFam As DataTable = m.DevuelveTabla(familia)
        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next

        Dim consultaAnterior As String
        consultaAnterior = "WITH TMP AS (" & vbCrLf
        consultaAnterior &= "SELECT *, ROW_NUMBER() OVER(PARTITION BY IDArticulo,IDAlmacen ORDER BY FechaDocumento DESC, IDLineaMovimiento DESC) as rn" & vbCrLf
        consultaAnterior &= "FROM vFrmCIMovimientosE4_1" & vbCrLf
        consultaAnterior &= "WHERE FechaDocumento < '" & Fecha1 & "'" & vbCrLf
        If Not String.IsNullOrEmpty(familia) Then
            consultaAnterior &= "AND IDFamilia = '" & familia & "'" & vbCrLf
        End If
        consultaAnterior &= "AND Activo = 1 AND CodTipoMovimiento <> 'C' AND PrecioEstandarA!=0)" & vbCrLf
        consultaAnterior &= "SELECT * FROM TMP" & vbCrLf
        consultaAnterior &= "WHERE rn = 1" & vbCrLf

        Dim consulta As String
        consulta = "SELECT * FROM vFrmTransferenciasEncofrados2E4_1" & vbCrLf
        consulta &= "WHERE Activo = 1 AND FechaDocumento<='" & Fecha2 & "'" & vbCrLf
        If Not String.IsNullOrEmpty(familia) Then
            consulta &= "AND IDFamilia = '" & familia & "'" & vbCrLf
        End If
        If Not String.IsNullOrEmpty(condiciones) Then
            consulta &= condiciones & vbCrLf
        End If
        consulta &= "AND IDArticulo!='0000000213' AND CodTipoMovimiento <> 'C' AND PrecioEstandarA!=0 AND IDMovimiento<>'5968' and IDMovimiento<>'5967' and IDMovimiento<>'5956' and IDMovimiento<>'5961' and IDMovimiento<>'5951'" & vbCrLf
        consulta &= "ORDER BY FechaDocumento DESC"

        Dim dtAnterior As DataTable
        Dim dtConsulta As DataTable

        dtAnterior = EjecutarConsulta(consultaAnterior)
        dtConsulta = EjecutarConsulta(consulta)
        AñadeSubfamilias(dtAnterior)
        AñadeSubfamilias(dtConsulta)
        LimpiaAcumuladoNegativo(dtAnterior)
        LimpiaAcumuladoNegativo(dtConsulta)

        rp.DataSource = dtConsulta
        rp.Formulas("laborables").Text = laborables
        rp.Formulas("fecha1").Text = Fecha1
        rp.Formulas("fecha2").Text = Fecha2
        rp.Formulas("Familia").Text = dFamilia

        rp.Subreports("acumuladoMesAnt").DataSource = dtAnterior
        rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

        ExpertisApp.OpenReport(rp)
        e.Cancel = True
    End Sub
End Class