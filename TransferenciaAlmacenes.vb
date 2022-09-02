Public Class TransferenciaAlmacenes
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private mblnStkDobleUnidad As Boolean
    Private mAutonumerico As Integer = 1

    Private mMonedaA As MonedaInfo
    Private mMonedaB As MonedaInfo

    Private mLotesOrigen As ERP.CommonClasses.LoteStockableUserDialog
    Private mLotesDestino As ERP.CommonClasses.LoteStockableUserDialog
    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialog
    Private MBlnAdding As Boolean = False

    Private Const mcOrigen As Integer = -1
    Friend WithEvents btExcel As Solmicro.Expertis.Engine.UI.Button
    Private Const mcDestino As Integer = 1

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        '//Toolbar
        Me.Execute.Icon = Engine.UI.Resources.PlayIcon
        '//Grid
        Dim Lineas As New DataTable
        Lineas.Columns.Add("IDArticulo", GetType(String))
        Lineas.Columns.Add("DescArticulo", GetType(String))
        Lineas.Columns.Add("Cantidad", GetType(Double))
        Lineas.Columns.Add("Cantidad2", GetType(Double))
        Lineas.Columns.Add("IDAlmacenOrigen", GetType(String))
        Lineas.Columns.Add("DescAlmacenOrigen", GetType(String))
        Lineas.Columns.Add("StockFisicoOrigen", GetType(Double))
        Lineas.Columns.Add("StockFisicoOrigen2", GetType(Double))
        Lineas.Columns.Add("IDAlmacenDestino", GetType(String))
        Lineas.Columns.Add("DescAlmacenDestino", GetType(String))
        Lineas.Columns.Add("UbicacionDestino", GetType(String))
        Lineas.Columns.Add("StockFisicoDestino", GetType(Double))
        Lineas.Columns.Add("StockFisicoDestino2", GetType(Double))
        Lineas.Columns.Add("PrecioA", GetType(Double))
        Lineas.Columns.Add("PrecioB", GetType(Double))
        Lineas.Columns.Add("Texto", GetType(String))
        Lineas.Columns.Add("Actualizado", GetType(Boolean))
        Lineas.Columns.Add("GestionStockPorLotes", GetType(Boolean))
        Lineas.Columns.Add("NSerieObligatorio", GetType(Boolean))
        Lineas.Columns.Add("CriterioValoracion", GetType(enumtaValoracion))
        Lineas.Columns.Add("RecalcularValoracion", GetType(enumtaValoracionSalidas))
        Lineas.Columns.Add("ID", GetType(Integer))
        'David V 20/02/2022
        Lineas.Columns.Add("FechaDocumento", GetType(Date))
        'David V 20/02/2022

        Grid.DataSource = Lineas
        '//Lotes
        mLotesOrigen = New ERP.CommonClasses.LoteStockableUserDialog
        mLotesOrigen.Text = "TRANSFERENCIA DE SALIDA"
        mLotesOrigen.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mLotesOrigen.DataSchema.IDAlmacen = "IDAlmacenOrigen"
        mLotesOrigen.DataSource = Grid

        mLotesDestino = New ERP.CommonClasses.LoteStockableUserDialog
        mLotesDestino.Text = "TRANSFERENCIA DE ENTRADA"
        mLotesDestino.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
        mLotesDestino.DataSchema.IDAlmacen = "IDAlmacenDestino"
        mLotesDestino.DataSource = Grid

        '//Series
        mSeries = New ERP.CommonClasses.NSerieStockableUserDialog
        mSeries.Text = "TRANSFERENCIAS"
        mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mSeries.DataSchema.IDAlmacen = "IDAlmacenOrigen"
        mSeries.DataSource = Grid
        mSeries.UsarColumnaSeleccion = True
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents Execute As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Toolbar As Janus.Windows.UI.CommandBars.UICommandBar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Execute1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferenciaAlmacenes))
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Toolbar = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.Execute1 = New Janus.Windows.UI.CommandBars.UICommand("Execute")
        Me.Execute = New Janus.Windows.UI.CommandBars.UICommand("Execute")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.btExcel = New Solmicro.Expertis.Engine.UI.Button
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grid
        '
        Me.Grid.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CriterioValoracion", "CriterioValoracion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("RecalcularValoracion", "RecalcularValoracion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("GestionStockPorLotes", "GestionStockPorLotes"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NSerieObligatorio", "NSerieObligatorio")}), "advArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacenOrigen", "ArticuloAlmacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacenOrigen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("StockFisico", "StockFisicoOrigen"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("StockFisico2", "StockFisicoOrigen2")}), "advArticuloAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacenDestino", "Almacen", "IDAlmacen", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescAlmacen", "DescAlmacenDestino")}), "advAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("UbicacionDestino", "AlmacenUbicacion", "IDUbicacion")})
        Me.Grid.AutomaticSort = False
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 28)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(628, 389)
        Me.Grid.TabIndex = 2
        Me.Grid.ViewName = Nothing
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Toolbar})
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Execute})
        Me.UiCommandManager1.ContainerControl = Me
        Me.UiCommandManager1.Id = New System.Guid("502afb55-ac8a-4b57-a7fa-c50298f03605")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'Toolbar
        '
        Me.Toolbar.CommandManager = Me.UiCommandManager1
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Execute1})
        Me.Toolbar.Key = "Toolbar"
        Me.Toolbar.Location = New System.Drawing.Point(0, 0)
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.RowIndex = 0
        Me.Toolbar.Size = New System.Drawing.Size(42, 28)
        Me.Toolbar.Text = "CommandBar1"
        '
        'Execute1
        '
        Me.Execute1.Key = "Execute"
        Me.Execute1.Name = "Execute1"
        '
        'Execute
        '
        Me.Execute.CommandStyle = Janus.Windows.UI.CommandBars.CommandStyle.Image
        Me.Execute.Key = "Execute"
        Me.Execute.Name = "Execute"
        Me.Execute.Text = "Execute"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.Toolbar})
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Controls.Add(Me.Toolbar)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(628, 28)
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        '
        'btExcel
        '
        Me.btExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btExcel.Location = New System.Drawing.Point(0, 394)
        Me.btExcel.Name = "btExcel"
        Me.btExcel.Size = New System.Drawing.Size(628, 23)
        Me.btExcel.TabIndex = 3
        Me.btExcel.Text = "Carga Datos"
        '
        'TransferenciaAlmacenes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(628, 417)
        Me.Controls.Add(Me.btExcel)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "TransferenciaAlmacenes"
        Me.Text = "Transferencia entre almacenes"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TransferenciaAlmacenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim moneda As New Moneda
            mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf moneda.MonedaA, cnMinDate)
            mMonedaB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf moneda.MonedaB, cnMinDate)
            Grid.Columns("PrecioA").Caption = Grid.Columns("PrecioA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("PrecioB").Caption = Grid.Columns("PrecioB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("Cantidad").DefaultValue = 1
            Grid.Columns("StockFisicoOrigen").DefaultValue = 0
            Grid.Columns("StockFisicoDestino").DefaultValue = 0
            Grid.Columns("PrecioA").DefaultValue = 0
            Grid.Columns("PrecioB").DefaultValue = 0
            Grid.Columns("RecalcularValoracion").DefaultValue = enumtaValoracionSalidas.taNoRecalcular
            Grid.Columns("GestionStockPorLotes").DefaultValue = False
            Grid.Columns("NSerieObligatorio").DefaultValue = False
            Grid.Columns("ID").DefaultValue = mAutonumerico
            Grid.Columns("Actualizado").DefaultValue = False
            Grid.Columns("UbicacionDestino").Visible = False
            'David Velasco 20/01/2022
            Grid.Columns("FechaDocumento").DefaultValue = Today
            'Fin
            SettingDobleUnidad()
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad

        If Grid.Columns.Contains("StockFisicoOrigen2") Then
            Grid.Columns("StockFisicoOrigen2").Visible = mblnStkDobleUnidad
            Grid.Columns("StockFisicoOrigen2").Position = Grid.Columns("StockFisicoOrigen").Position + 1
        End If
        If Grid.Columns.Contains("Cantidad2") Then
            Grid.Columns("Cantidad2").Visible = mblnStkDobleUnidad
            Grid.Columns("Cantidad2").Position = Grid.Columns("Cantidad").Position + 1
            If Me.Grid.Columns("Cantidad2").Visible Then
                Me.Grid.Columns("Cantidad2").CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                Me.Grid.Columns("Cantidad2").CellStyle.ForeColor = Color.Red
            End If
        End If
        If Grid.Columns.Contains("StockFisicoDestino2") Then
            Grid.Columns("StockFisicoDestino2").Visible = mblnStkDobleUnidad
            Grid.Columns("StockFisicoDestino2").Position = Grid.Columns("StockFisicoDestino").Position + 1
        End If
    End Sub

    Private Sub Grid_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles Grid.AdvSearchSelectionChanged
        Dim dr As DataRow
        dr = e.Selected.Rows(0)

        Select Case e.Key
            Case "IDArticulo"
                If Length(dr("IDArticulo")) > 0 Then
                    Dim f1 As New Filter
                    'f1.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, dr("IDArticulo")))
                    'f1.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                    'Grid.AdvSearchColumns("IDAlmacenOrigen").Filter = f1

                    'If dr("NSerieObligatorio") Then
                    '    Grid.AdvSearchColumns("IDAlmacenDestino").ViewName = "advArticuloAlmacen"
                    'Else
                    '    Grid.AdvSearchColumns("IDAlmacenDestino").ViewName = "tbMaestroAlmacen"
                    'End If
                    'Dim f2 As New Filter
                    'f2.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
                    'Grid.AdvSearchColumns("IDAlmacenDestino").Filter = f2

                    'If dr("RecalcularValoracion") = enumtaValoracionSalidas.taRecalcular _
                    'OrElse dr("RecalcularValoracion") = enumtaValoracionSalidas.taMantenerPrecio Then
                    If (dr("CriterioValoracion") = enumtaValoracion.taPrecioEstandar) Then

                        Grid.SetValue("PrecioA", dr("PrecioEstandarA"))
                        Grid.SetValue("PrecioB", dr("PrecioEstandarB"))
                    ElseIf dr("CriterioValoracion") = enumtaValoracion.taPrecioUltCompra Then
                        Grid.SetValue("PrecioA", dr("PrecioUltimaCompraA"))
                        Grid.SetValue("PrecioB", dr("PrecioUltimaCompraB"))
                    End If
                    'End If
                End If
            Case "IDAlmacenOrigen"
                Dim precioA As Double = Grid.GetValue("PrecioA")
                Dim precioB As Double = Grid.GetValue("PrecioB")

                'If Grid.GetValue("RecalcularValoracion") = enumtaValoracionSalidas.taRecalcular _
                'OrElse Grid.GetValue("RecalcularValoracion") = enumtaValoracionSalidas.taMantenerPrecio Then
                'ExpertisApp.GenerateMessage(dr("IDArticulo"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'ExpertisApp.GenerateMessage(dr("IDAlmacen"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'ExpertisApp.GenerateMessage(Grid.GetValue("Cantidad"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Dim datosPrecio As New ProcesoStocks.DataPrecioMovimiento(dr("IDArticulo"), dr("IDAlmacen"), cnMinDate, Grid.GetValue("Cantidad"), enumtpmTipoMovimiento.tpmInput)
                Dim precios As Hashtable = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataPrecioMovimiento, Hashtable)(AddressOf ProcesoStocks.PrecioMovimiento, datosPrecio)
                precioA = precios("PrecioA")
                precioB = precios("PrecioB")
                'Al completarse en los movimientos todos los precios nos encontramos con que si no tenemos cierres de inventario siempre vamos a tener los datos de los precios medioa a 0
                'De ahí que apliquemos siempre el precio que corresponde en el momento de la transferencia 
                'Else
                '    Select Case Grid.GetValue("CriterioValoracion")
                '        Case enumtaValoracion.taPrecioFIFOFecha
                '            precioA = dr("PrecioFIFOFechaA")
                '            precioB = dr("PrecioFIFOFechaB")
                '        Case enumtaValoracion.taPrecioFIFOMvto
                '            precioA = dr("PrecioFIFOMvtoA")
                '            precioB = dr("PrecioFIFOMvtoB")
                '        Case enumtaValoracion.taPrecioMedio
                '            precioA = dr("PrecioMedioA")
                '            precioB = dr("PrecioMedioB")
                '    End Select
                'End If

                Grid.SetValue("PrecioA", precioA)
                Grid.SetValue("PrecioB", precioB)
            Case "IDAlmacenDestino"
                If Length(Grid.GetValue("IDArticulo")) > 0 AndAlso Length(e.Selected.Rows(0)("IDAlmacen")) > 0 Then
                    Dim FilAlm As New Filter
                    FilAlm.Add("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo"))
                    FilAlm.Add("IDAlmacen", FilterOperator.Equal, e.Selected.Rows(0)("IDAlmacen"))
                    FilAlm.Add("Activo", FilterOperator.Equal, True)
                    Dim DtArtAlm As DataTable = New BE.DataEngine().Filter("advArticuloAlmacen", FilAlm)
                    If Not DtArtAlm Is Nothing AndAlso DtArtAlm.Rows.Count > 0 Then
                        Grid.SetValue("StockFisicoDestino", DtArtAlm.Rows(0)("StockFisico"))
                        If ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.GetValue("IDArticulo")) Then
                            Grid.SetValue("StockFisicoDestino2", DtArtAlm.Rows(0)("StockFisico2"))
                        End If
                    Else
                        Grid.SetValue("StockFisicoDestino", 0)
                        If ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.GetValue("IDArticulo")) Then
                            Grid.SetValue("StockFisicoDestino2", 0)
                        End If
                    End If
                End If
        End Select
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Try
            If Grid.GetValue("Actualizado") Then
                e.Cancel = True
                If Grid.AdvSearchColumns.Contains(Grid.AdvSearchColumns(e.Column.Key)) Then
                    e.Column.ButtonStyle = ButtonStyle.NoButton
                End If
            Else
                Select Case e.Column.Key
                    Case "IDArticulo"
                        e.Column.ButtonStyle = ButtonStyle.Image
                    Case "IDAlmacenOrigen", "IDAlmacenDestino"
                        If Length(Grid.GetValue("IDArticulo")) = 0 Then
                            e.Cancel = True
                            e.Column.ButtonStyle = ButtonStyle.NoButton
                        Else
                            e.Column.ButtonStyle = ButtonStyle.Image
                        End If
                End Select

                Dim c As GridEXColumn = Grid.Columns("Cantidad")
                If Grid.GetValue("GestionStockPorLotes") And Grid.GetRow.RowType = RowType.Record Then
                    c.ButtonStyle = ButtonStyle.Image
                    c.ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
                    c.ButtonImage = Icons.Images(0)
                    Grid.Columns("UbicacionDestino").ButtonStyle = ButtonStyle.NoButton
                    Grid.Columns("UbicacionDestino").EditType = EditType.NoEdit

                ElseIf Grid.GetValue("NSerieObligatorio") And Grid.GetRow.RowType = RowType.Record Then
                    c.ButtonStyle = ButtonStyle.Image
                    c.ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
                    c.ButtonImage = Icons.Images(1)
                    Grid.Columns("UbicacionDestino").Visible = True
                    If Length(Grid.GetValue("IDAlmacenDestino")) = 0 Then
                        Grid.Columns("UbicacionDestino").ButtonStyle = ButtonStyle.NoButton
                        Grid.Columns("UbicacionDestino").EditType = EditType.TextBox
                    Else
                        Grid.Columns("UbicacionDestino").ButtonStyle = ButtonStyle.Image
                        Grid.Columns("UbicacionDestino").EditType = EditType.TextBox
                    End If
                Else
                    c.ButtonStyle = ButtonStyle.NoButton
                    Grid.Columns("UbicacionDestino").ButtonStyle = ButtonStyle.NoButton
                    Grid.Columns("UbicacionDestino").EditType = EditType.NoEdit
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Try
            Select Case e.Column.Key
                Case "Cantidad", "Cantidad2"
                    If Not IsNumeric(e.Value) Then
                        e.Value = e.InitialValue
                    End If
                    If Grid.GetRow.RowType = RowType.Record Then
                        If Grid.GetValue("GestionStockPorLotes") Then
                            e.Cancel = Not Lotes()
                        ElseIf Grid.GetValue("NSerieObligatorio") Then
                            e.Cancel = Not Series()
                        End If
                    End If

                    Dim datFactor As New Articulo.DataFactorDobleUnidad(Grid.Value("IDArticulo"), (e.Column.Key = "Cantidad"), (e.Column.Key = "Cantidad2"))
                    Dim Factor As Double = ExpertisApp.ExecuteTask(Of Articulo.DataFactorDobleUnidad, Double)(AddressOf Articulo.FactorDobleUnidad, datFactor)
                    If Factor = 0 Then
                        If e.Column.Key = "Cantidad" AndAlso Nz(Grid.Value("Cantidad2"), 0) = 0 Then ExpertisApp.GenerateMessage("Debe indicar la Cantidad de la Segunda Unidad Interna.")
                    ElseIf Factor > 0 Then
                        If e.Column.Key = "Cantidad" Then
                            Grid.SetValue("Cantidad2", e.Value * Factor)
                        ElseIf e.Column.Key = "Cantidad2" Then
                            Grid.SetValue("Cantidad", e.Value * Factor)
                        End If
                    End If
                Case "PrecioA"
                    If Not IsNumeric(e.Value) Then
                        e.Value = 0
                    End If
                    Grid.SetValue("PrecioB", xRound(e.Value * mMonedaA.CambioB, mMonedaB.NDecimalesPrecio))
                Case "PrecioB"
                    If Not IsNumeric(e.Value) Then
                        e.Value = 0
                    End If
                    Grid.SetValue("PrecioA", xRound(e.Value * mMonedaB.CambioA, mMonedaA.NDecimalesPrecio))
                Case "IDArticulo"
                    If Nz(e.Value) <> Nz(e.InitialValue) AndAlso Not IsNothing(e.InitialValue) Then
                        Grid.Value("IDAlmacenOrigen") = Nothing
                        Grid.Value("DescAlmacenOrigen") = Nothing
                        Grid.Value("StockFisicoOrigen") = 0
                        Grid.Value("StockFisicoOrigen2") = 0
                        Grid.Value("PrecioA") = 0
                        Grid.Value("PrecioB") = 0
                    End If
                Case "IDAlmacenOrigen"
                    If Nz(e.Value) <> Nz(e.InitialValue) AndAlso Not IsNothing(e.InitialValue) Then
                        Grid.Value("DescAlmacenOrigen") = Nothing
                        Grid.Value("StockFisicoOrigen") = 0
                        Grid.Value("StockFisicoOrigen2") = 0
                        If Grid.Value("CriterioValoracion") = enumtaValoracion.taPrecioFIFOFecha _
                        Or Grid.Value("CriterioValoracion") = enumtaValoracion.taPrecioFIFOMvto _
                        Or Grid.Value("CriterioValoracion") = enumtaValoracion.taPrecioMedio Then
                            Grid.Value("PrecioA") = 0
                            Grid.Value("PrecioB") = 0
                        End If
                    End If
                Case "IDAlmacenDestino"
                    If Nz(e.Value) <> Nz(e.InitialValue) AndAlso Not IsNothing(e.InitialValue) Then
                        Grid.Value("DescAlmacenDestino") = Nothing
                        Grid.Value("StockFisicoDestino") = 0
                        Grid.Value("StockFisicoDestino2") = 0
                    End If
            End Select
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordAdded
        mAutonumerico += 1
        Grid.Columns("ID").DefaultValue = mAutonumerico
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        Try
            Select Case e.Column.Key
                Case "Cantidad"
                    If Grid.GetValue("GestionStockPorLotes") Then
                        If Grid.DataChanged Then
                            ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Lotes()
                        End If
                    ElseIf Grid.GetValue("NSerieObligatorio") Then
                        If Grid.DataChanged Then
                            ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Series()
                        End If
                    End If
                Case "Texto"
                    FormularioTexto()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            Select Case Grid.Col
                Case Grid.Columns("Cantidad").Position
                    If Grid.GetValue("GestionStockPorLotes") Then
                        If Grid.DataChanged Then
                            ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Lotes()
                        End If
                    ElseIf Grid.GetValue("NSerieObligatorio") Then
                        If Grid.DataChanged Then
                            ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Series()
                        End If
                    End If
                Case Grid.Columns("Texto").Position
                    FormularioTexto()
            End Select
        End If
    End Sub

    Private Function Lotes() As Boolean
        If Grid.GetRow.RowType = RowType.Record Then
            Dim ID As Integer = Grid.GetValue("ID")
            Dim Articulo As String = Nz(Grid.GetValue("IDArticulo"))
            Dim AlmacenOrigen As String = Nz(Grid.GetValue("IDAlmacenOrigen"))
            Dim AlmacenDestino As String = Nz(Grid.GetValue("IDAlmacenDestino"))

            If Len(Articulo) = 0 Then
                ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Len(AlmacenOrigen) = 0 Then
                ExpertisApp.GenerateMessage("El almacén de origen es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Len(AlmacenDestino) = 0 Then
                ExpertisApp.GenerateMessage("El almacén de destino es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim ltCopia As Lote = Nothing
                Dim ltOrigen As Lote = mLotesOrigen.LoteCollection.Item(ID, Articulo, mcOrigen)
                If Not IsNothing(ltOrigen) Then
                    '//si el lote origen ya existe guardamos una copia por si los cambios en el lote de destino se cancelan
                    ltCopia = ltOrigen.Copiar
                End If
                If mLotesOrigen.ShowDialog(ID, Articulo, mcOrigen) = DialogResult.OK Then
                    LoadLote(ID, Articulo, AlmacenDestino, Nz(Grid.GetValue("Cantidad")), Nz(Grid.GetValue("Cantidad2"), Nothing))
                    If mLotesDestino.ShowDialog(ID, Articulo, mcDestino) = DialogResult.OK Then
                        Return True
                    Else
                        If Not IsNothing(ltCopia) Then
                            mLotesOrigen.LoteCollection.RemoveAt(ID, Articulo, mcOrigen)
                            mLotesOrigen.LoteCollection.Add(ltCopia, ID, Articulo, mcOrigen)
                        Else
                            mLotesOrigen.LoteCollection.RemoveAt(ID, Articulo, mcOrigen)
                        End If
                    End If
                End If
            End If
        End If
    End Function

    Protected Overridable Sub LoadLote(ByVal ID As Integer, ByVal IDArticulo As String, ByVal IDAlmacenDestino As String, ByVal CantidadExpedir As Double, ByVal CantidadExpedir2 As Double?)
        Dim ltOrigen As Lote = mLotesOrigen.LoteCollection.Item(ID, IDArticulo, mcOrigen)
        Dim drOrigen As DataRow
        If Not ltOrigen Is Nothing AndAlso Not ltOrigen.DataTable Is Nothing AndAlso ltOrigen.DataTable.Rows.Count > 0 Then
            Dim ltDestino As Lote = mLotesDestino.LoadLote(IDArticulo, IDAlmacenDestino)
            mLotesDestino.LoteCollection.RemoveAt(ID)

            Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, IDArticulo)
            Dim lstLotesOrigen As List(Of DataRow) = (From c In ltOrigen.DataTable Where Not c.IsNull("Cantidad") AndAlso c("Cantidad") <> 0 Select c).ToList

            For Each drOrigen In lstLotesOrigen
                If Not ltDestino.DataTable Is Nothing Then

                    Dim lstLotesDestino As List(Of DataRow) = (From c In ltDestino.DataTable _
                                                               Where Not c.IsNull("Lote") AndAlso c("Lote") = drOrigen("Lote") AndAlso _
                                                                     Not c.IsNull("Ubicacion") AndAlso c("Ubicacion") = drOrigen("Ubicacion") Select c).ToList

                    If Not lstLotesDestino Is Nothing AndAlso lstLotesDestino.Count > 0 Then
                        lstLotesDestino(0)("Cantidad") = drOrigen("Cantidad")
                        If SegundaUnidad Then lstLotesDestino(0)("Cantidad2") = drOrigen("Cantidad2")
                    Else
                        Dim UbicacionPred As String
                        Dim dtUbicacion As DataTable = ExpertisApp.ExecuteTask(Of String, DataTable)(AddressOf AlmacenUbicacion.UbicacionPredeterminada, IDAlmacenDestino)
                        If Not dtUbicacion Is Nothing AndAlso dtUbicacion.Rows.Count > 0 Then
                            UbicacionPred = dtUbicacion.Rows(0)("IDUbicacion")
                        Else
                            UbicacionPred = String.Empty
                        End If

                        Dim lstLotesUbicPred As List(Of DataRow) = (From c In ltDestino.DataTable _
                                                             Where Not c.IsNull("Lote") AndAlso c("Lote") = drOrigen("Lote") AndAlso _
                                                                   Not c.IsNull("Ubicacion") AndAlso c("Ubicacion") = UbicacionPred Select c).ToList
                        If Not lstLotesUbicPred Is Nothing AndAlso lstLotesUbicPred.Count > 0 Then
                            lstLotesUbicPred(0)("Cantidad") = drOrigen("Cantidad")
                            If SegundaUnidad Then lstLotesUbicPred(0)("Cantidad2") = drOrigen("Cantidad2")
                        Else
                            Dim drLinDesglose As DataRow = ltDestino.DataTable.NewRow
                            drLinDesglose("IDArticulo") = IDArticulo
                            drLinDesglose("IDAlmacen") = IDAlmacenDestino
                            drLinDesglose("Lote") = drOrigen("Lote")
                            drLinDesglose("FechaCaducidad") = drOrigen("FechaCaducidad")
                            drLinDesglose("StockFisico") = 0
                            drLinDesglose("Bloqueado") = False
                            drLinDesglose("Ubicacion") = UbicacionPred
                            drLinDesglose("Cantidad") = drOrigen("Cantidad")
                            If SegundaUnidad Then drLinDesglose("Cantidad2") = drOrigen("Cantidad2")

                            ltDestino.DataTable.Rows.Add(drLinDesglose)
                        End If
                    End If
                End If
            Next
            ltDestino.Cantidad = CantidadExpedir
            If SegundaUnidad Then ltDestino.Cantidad2 = CantidadExpedir2
            mLotesDestino.LoteCollection.Add(ltDestino, ID)
        End If
    End Sub

    Private Function Series() As Boolean
        If Grid.GetRow.RowType = RowType.Record Then
            Dim ID As Integer = Grid.GetValue("ID")
            Dim Articulo As String = Nz(Grid.GetValue("IDArticulo"))
            Dim AlmacenOrigen As String = Nz(Grid.GetValue("IDAlmacenOrigen"))
            Dim AlmacenDestino As String = Nz(Grid.GetValue("IDAlmacenDestino"))
            Dim Cantidad As Double = Nz(Grid.GetValue("Cantidad"), 0)

            If Len(Articulo) = 0 Then
                ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Len(AlmacenOrigen) = 0 Then
                ExpertisApp.GenerateMessage("El almacén de origen es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf Len(AlmacenDestino) = 0 Then
                ExpertisApp.GenerateMessage("El almacén de destino es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                '//Con numeros de serie solo hace falta saber cuales son los numeros de serie
                '//a transferir y el almacen de destino. Con esto ya es posible construir la 
                '//informacion para el proceso
                If mSeries.ShowDialog(ID, Articulo) = DialogResult.OK Then
                    Return True
                End If
            End If
        End If
    End Function

    Private Sub FormularioTexto()
        Dim frm As New FormularioTexto
        frm.Texto = Grid.GetValue(Grid.CurrentColumn.Index) & String.Empty
        Dim res As DialogResult
        res = frm.ShowDialog()
        If res = DialogResult.OK Then
            If Grid.GetValue(Grid.CurrentColumn.Index) & String.Empty <> frm.Texto Then
                Grid.SetValue(Grid.CurrentColumn.Index, frm.Texto)
            End If
        End If
        frm.Dispose()
    End Sub

    Private Sub Grid_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.AddingRecord
        Try
            If Not IsValidRecord() Then
                e.Cancel = True
            End If
            If Not MBlnAdding Then ComprobarArticuloKit()
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub ComprobarArticuloKit()
        Dim StrIDArticulo As String = Me.Grid.GetValue("IDArticulo")
        Dim DtArt As DataTable = New Articulo().SelOnPrimaryKey(StrIDArticulo)
        If Not DtArt Is Nothing AndAlso DtArt.Rows.Count > 0 Then
            Dim StrIDTipo As String = DtArt.Rows(0)("IDTipo")
            Dim DtTipo As DataTable = New TipoArticulo().SelOnPrimaryKey(StrIDTipo)
            If Not DtTipo Is Nothing AndAlso DtTipo.Rows.Count > 0 Then
                If DtTipo.Rows(0)("KitVenta") = True Then
                    Dim DtEst As DataTable = New Estructura().Filter(New FilterItem("IDArticulo", FilterOperator.Equal, StrIDArticulo))
                    If Not DtEst Is Nothing AndAlso DtEst.Rows.Count > 0 Then
                        ExpertisApp.GenerateMessage("El artículo es de tipo Kit se añadirán los componentes del kit para la transferencia.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim DtGrid As DataTable = CType(Grid.DataSource, DataTable).Clone
                        For Each Dr As DataRow In DtEst.Select
                            Dim DrArtComp As DataRow = CType(New Articulo().SelOnPrimaryKey(Dr("IDComponente")), DataTable).Rows(0)
                            Dim DrNew As DataRow = DtGrid.NewRow
                            mAutonumerico += 1
                            DrNew("ID") = mAutonumerico
                            DrNew("IDArticulo") = Dr("IDComponente")
                            DrNew("DescArticulo") = DrArtComp("DescArticulo")
                            DrNew("CriterioValoracion") = DrArtComp("CriterioValoracion")
                            DrNew("RecalcularValoracion") = DrArtComp("RecalcularValoracion")
                            DrNew("GestionStockPorLotes") = DrArtComp("GestionStockPorLotes")
                            DrNew("NSerieObligatorio") = DrArtComp("NSerieObligatorio")
                            DrNew("Cantidad") = (Dr("Cantidad") * Grid.GetValue("Cantidad"))

                            Dim FilArtAlm As New Filter
                            FilArtAlm.Add("IDArticulo", FilterOperator.Equal, Dr("IDComponente"))
                            FilArtAlm.Add("IDAlmacen", FilterOperator.Equal, Grid.GetValue("IDAlmacenOrigen"))
                            Dim DrArtAlm As DataRow = CType(New ArticuloAlmacen().Filter(FilArtAlm), DataTable).Rows(0)
                            DrNew("IDAlmacenOrigen") = DrArtAlm("IDAlmacen")
                            DrNew("DescAlmacenOrigen") = Grid.GetValue("DescAlmacenOrigen")
                            DrNew("StockFisicoOrigen") = DrArtAlm("StockFisico")

                            FilArtAlm.Clear()
                            FilArtAlm.Add("IDArticulo", FilterOperator.Equal, Dr("IDComponente"))
                            FilArtAlm.Add("IDAlmacen", FilterOperator.Equal, Grid.GetValue("IDAlmacenDestino"))
                            DrArtAlm = CType(New ArticuloAlmacen().Filter(FilArtAlm), DataTable).Rows(0)
                            DrNew("IDAlmacenDestino") = Grid.GetValue("IDAlmacenDestino")

                            DrNew("DescAlmacenDestino") = Grid.GetValue("DescAlmacenDestino")
                            DrNew("StockFisicoDestino") = DrArtAlm("StockFisico")

                            DrNew("PrecioA") = 0 : DrNew("PrecioB") = 0
                            DrNew("Actualizado") = 0

                            DtGrid.Rows.Add(DrNew)
                        Next
                        MBlnAdding = True
                        For Each Dr As DataRow In CType(Me.Grid.DataSource, DataTable).Select
                            DtGrid.Rows.Add(Dr.ItemArray)
                        Next
                        Grid.DataSource = DtGrid
                        MBlnAdding = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Grid_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.UpdatingRecord
        Try
            If Not IsValidRecord() Then
                e.Cancel = True
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Function IsValidRecord() As Boolean
        If Len(Grid.GetValue("IDArticulo") & String.Empty) = 0 Then
            ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Len(Grid.GetValue("IDAlmacenOrigen") & String.Empty) = 0 Then
            ExpertisApp.GenerateMessage("El almacén de origen es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Len(Grid.GetValue("IDAlmacenDestino") & String.Empty) = 0 Then
            ExpertisApp.GenerateMessage("El almacén de destino es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.GetValue("IDArticulo"))
            If Not IsNumeric(Grid.GetValue("Cantidad")) OrElse (SegundaUnidad AndAlso Not IsNumeric(Grid.GetValue("Cantidad2"))) Then
                ExpertisApp.GenerateMessage("Cantidad no válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Return True
            End If
        End If
    End Function

    Private Sub Grid_DeletingRecords(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Grid.DeletingRecords
        Try
            For Each row As GridEXSelectedItem In Grid.SelectedItems
                Dim ID As Integer = row.GetRow.Cells("ID").Value
                Dim Articulo As String = row.GetRow.Cells("IDArticulo").Value & String.Empty

                mLotesOrigen.LoteCollection.BeginDelete()
                mLotesDestino.LoteCollection.BeginDelete()
                mLotesOrigen.LoteCollection.RemoveAt(ID, Articulo, mcOrigen)
                mLotesDestino.LoteCollection.RemoveAt(ID, Articulo, mcDestino)

                mSeries.SerieCollection.BeginDelete()
                mSeries.SerieCollection.RemoveAt(ID, Articulo)
            Next
        Catch ex As Exception
            mLotesOrigen.LoteCollection.AbortDelete()
            mLotesDestino.LoteCollection.AbortDelete()
            mSeries.SerieCollection.AbortDelete()
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.RecordsDeleted
        mLotesOrigen.LoteCollection.CommitDelete()
        mLotesDestino.LoteCollection.CommitDelete()
        mSeries.SerieCollection.CommitDelete()
    End Sub

    Private Sub GenerarMovimientos(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles Execute.Click
        If Grid.RecordCount > 0 Then
            If Grid.DataChanged Then
                ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                Dim dv As New DataView(dt)
                dv.RowFilter = New BooleanFilterItem("Actualizado", False).Compose(New AdoFilterComposer)
                If dv.Count = 0 Then
                    ExpertisApp.GenerateMessage("No hay líneas para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim N As Integer = ExpertisApp.ExecuteTask(Of Object, Integer)(AddressOf ProcesoStocks.NuevoNumeroMovimiento, Nothing)
                    Dim Detalle(-1) As StockUpdateData
                    For Each row As GridEXRow In Grid.GetRows
                        If Not row.Cells("Actualizado").Value Then

                            Dim ID As Integer = row.Cells("ID").Value
                            Dim Articulo As String = row.Cells("IDArticulo").Value
                            Dim AlmacenOrigen As String = row.Cells("IDAlmacenOrigen").Value
                            Dim AlmacenDestino As String = row.Cells("IDAlmacenDestino").Value
                            Dim cantidad As Double = Nz(row.Cells("Cantidad").Value, 0)
                            Dim precioA As Double = Nz(row.Cells("PrecioA").Value, 0)
                            Dim precioB As Double = Nz(row.Cells("PrecioB").Value, 0)
                            Dim texto As String = Nz(row.Cells("Texto").Value)
                            Dim UbicacionDestino As String = Nz(row.Cells("UbicacionDestino").Value)

                            'David Velasco 20/01/2022
                            Dim FechaDocumento As Date = Nz(row.Cells("FechaDocumento").Value)
                            'David Velasco 20/01/2022


                            Dim aux(-1) As StockUpdateData
                            If row.Cells("GestionStockPorLotes").Value Then
                                Dim lotes(-1) As StockData
                                Dim origen(-1) As StockData
                                Dim destino(-1) As StockData
                                lotes = mLotesOrigen.LoteCollection.GetStockData(ID, Articulo, mcOrigen)
                                If Not lotes Is Nothing AndAlso lotes.Length > 0 Then
                                    Dim blnEjecutarTrans As Boolean = True
                                    For Each o As StockData In lotes
                                        If o.Cantidad > 0 Then
                                            o.TipoMovimiento = enumTipoMovimiento.tmSalTransferencia
                                            o.PrecioA = precioA
                                            o.PrecioB = precioB
                                            o.Texto = texto
                                            'David Vel 20/01/2022
                                            o.FechaDocumento = FechaDocumento
                                            'David Vel 20/01/2022
                                            ReDim Preserve origen(origen.Length)
                                            origen(origen.Length - 1) = o
                                        ElseIf o.Cantidad < 0 Then
                                            ExpertisApp.GenerateMessage("No se puede generar una transferencia con lotes en negativo para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Information, Articulo, AlmacenOrigen)
                                            blnEjecutarTrans = False
                                        End If
                                    Next
                                    lotes = mLotesDestino.LoteCollection.GetStockData(ID, Articulo, mcDestino)
                                    If Not lotes Is Nothing AndAlso lotes.Length > 0 Then
                                        For Each d As StockData In lotes
                                            If d.Cantidad > 0 Then
                                                d.TipoMovimiento = enumTipoMovimiento.tmEntTransferencia
                                                d.PrecioA = precioA
                                                d.PrecioB = precioB
                                                d.Texto = texto

                                                'David Vel 20/01/2022
                                                d.FechaDocumento = FechaDocumento
                                                'David Vel 20/01/2022

                                                ReDim Preserve destino(destino.Length)
                                                destino(destino.Length - 1) = d
                                            ElseIf d.Cantidad < 0 Then
                                                ExpertisApp.GenerateMessage("No se puede generar una transferencia con lotes en negativo para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Information, Articulo, AlmacenDestino)
                                                blnEjecutarTrans = False
                                            End If
                                        Next
                                    Else
                                        ExpertisApp.GenerateMessage("El lote es obligatorio para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenDestino)
                                    End If
                                    If blnEjecutarTrans Then
                                        Dim datosTransferencia As New ProcesoStocks.DataTransferenciaDesgloseLote(N, origen, destino)
                                        aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferenciaDesgloseLote, StockUpdateData())(AddressOf ProcesoStocks.TransferenciaDesgloseLote, datosTransferencia)
                                    End If
                                Else
                                    ExpertisApp.GenerateMessage("El lote es obligatorio para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                                End If
                            ElseIf row.Cells("NSerieObligatorio").Value Then
                                Dim origen(-1) As StockData
                                Dim destino(-1) As StockData
                                origen = mSeries.SerieCollection.SeriesSeleccionadasFormatoStockData(ID, Articulo)
                                If Not origen Is Nothing AndAlso origen.Length > 0 Then
                                    For Each o As StockData In origen
                                        o.TipoMovimiento = enumTipoMovimiento.tmSalTransferencia
                                        o.Texto = texto
                                        o.PrecioA = precioA
                                        o.PrecioB = precioB
                                        Dim d As New StockData(o.Articulo, AlmacenDestino, o.NSerie, o.Activo, o.EstadoNSerie, o.Operario, o.FechaDocumento, enumTipoMovimiento.tmEntTransferencia, precioA, precioB)
                                        d.Texto = o.Texto
                                        If Length(AlmacenDestino) > 0 AndAlso Length(UbicacionDestino) = 0 Then
                                            Dim f As New Filter
                                            f.Add(New StringFilterItem("IDAlmacen", AlmacenDestino))
                                            f.Add(New BooleanFilterItem("Predeterminada", True))
                                            Dim dtUbicacionDestino As DataTable = New AlmacenUbicacion().Filter(f)
                                            If dtUbicacionDestino.Rows.Count > 0 Then d.Ubicacion = dtUbicacionDestino.Rows(0)("IDUbicacion") & String.Empty
                                        Else
                                            d.Ubicacion = UbicacionDestino
                                        End If
                                        StockDataManager.Copy(d, destino)
                                    Next
                                    Dim datosTransferencia As New ProcesoStocks.DataTransferenciaDesgloseLote(N, origen, destino)
                                    aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferenciaDesgloseLote, StockUpdateData())(AddressOf ProcesoStocks.TransferenciaDesgloseLote, datosTransferencia)
                                Else
                                    ExpertisApp.GenerateMessage("No se han especificado los números de serie para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                                End If
                            Else
                                Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Articulo)
                                Dim origen As New StockData(Articulo, AlmacenOrigen, cantidad, precioA, precioB, FechaDocumento, enumTipoMovimiento.tmSalTransferencia)
                                If SegundaUnidad Then
                                    If Length(row.Cells("Cantidad2").Value) > 0 Then
                                        origen.Cantidad2 = Nz(row.Cells("Cantidad2").Value, 0)
                                    Else
                                        ExpertisApp.GenerateMessage("No se ha especificado la Cantidad de la Segunda unidad para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                                    End If
                                End If
                                origen.Texto = texto
                                Dim destino As New StockData(Articulo, AlmacenDestino, cantidad, 0, 0, FechaDocumento, enumTipoMovimiento.tmEntTransferencia)
                                If SegundaUnidad Then
                                    If Length(row.Cells("Cantidad2").Value) > 0 Then
                                        destino.Cantidad2 = Nz(row.Cells("Cantidad2").Value, 0)
                                    Else
                                        ExpertisApp.GenerateMessage("No se ha especificado la Cantidad de la Segunda unidad para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                                    End If
                                End If
                                destino.Texto = texto
                                Dim datosTransferencia As New ProcesoStocks.DataTransferencia(N, origen, destino)
                                aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferencia, StockUpdateData())(AddressOf ProcesoStocks.Transferencia, datosTransferencia)
                            End If
                            If aux.Length > 0 Then
                                StockDataManager.Copy(aux, Detalle)
                                If EstaActualizado(aux) Then
                                    row.BeginEdit()
                                    row.Cells("Actualizado").Value = True
                                    Try
                                        row.EndEdit()
                                    Catch ex As Exception

                                    End Try

                                End If
                            End If
                        End If
                    Next

                    If Not Detalle Is Nothing AndAlso Detalle.Length > 0 Then
                        Dim frm As New DetalleActualizacionStock
                        frm.DataSource = Detalle
                        frm.ShowDialog()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function EstaActualizado(ByVal updateData() As StockUpdateData) As Boolean
        '//Comprueba si todos las transferencias se han actualizado con exito
        If Not updateData Is Nothing AndAlso updateData.Length > 0 Then
            For Each item As StockUpdateData In updateData
                If Not (item.Estado = EstadoStock.Actualizado) Then
                    Return False
                End If
            Next
            Return True
        End If
    End Function

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.Cells("Actualizado").Value Then
            e.Row.RowStyle = Grid.FormatStyles("LineaActualizada")
        End If
    End Sub

    'Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
    '    If e.Key = "IDAlmacenDestino" Then
    '        If Grid.Value("NSerieObligatorio") Then
    '            If length(Grid.Value("IDArticulo")) > 0 Then
    '                e.Filter.Add(New StringFilterItem("IDArticulo", Grid.Value("IDArticulo")))
    '                'e.Filter.Add(New NumberFilterItem("StockFisico", FilterOperator.GreaterThan, 0))
    '            Else
    '                e.Filter.Add(New IsNullFilterItem("IDArticulo"))
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub Grid_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        Select Case e.Column.Key
            Case "cantidad"
                If Grid.GetValue("RecalcularValoracion") = enumtaValoracionSalidas.taRecalcular _
                OrElse Grid.GetValue("RecalcularValoracion") = enumtaValoracionSalidas.taMantenerPrecio Then
                    Dim datosPrecio As New ProcesoStocks.DataPrecioMovimiento(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacenOrigen"), cnMinDate, Grid.GetValue("Cantidad"), enumtpmTipoMovimiento.tpmInput)
                    Dim precios As Hashtable = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataPrecioMovimiento, Hashtable)(AddressOf ProcesoStocks.PrecioMovimiento, datosPrecio)
                    Grid.SetValue("PrecioA", precios("PrecioA"))
                    Grid.SetValue("PrecioB", precios("PrecioB"))
                End If
        End Select
    End Sub

    Private Sub Grid_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles Grid.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "IDAlmacenOrigen"
                If Length(Grid.GetValue("IDArticulo")) > 0 Then e.Filter.Add("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo"))
                e.Filter.Add("Activo", FilterOperator.Equal, True)
                e.ForcePredefinedFilter = True
            Case "IDAlmacenDestino"
                e.Filter.Add("Activo", FilterOperator.Equal, True)
                e.ForcePredefinedFilter = True
            Case "UbicacionDestino"
                If Length(Grid.GetValue("IDAlmacenDestino")) > 0 Then e.Filter.Add("IDAlmacen", FilterOperator.Equal, Grid.GetValue("IDAlmacenDestino"))
                e.ForcePredefinedFilter = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show("Hola")
    End Sub


    Private Sub btExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btExcel.Click
        Dim ruta As String = ""
        Dim hoja As String = 1
        Dim rango As String = ""

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim control As Integer = 0
                Try
                    ruta = openFD.FileName
                    hoja = "Hoja1"
                    rango = "A1:E500"
                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)

                    'Recorro la tabla y compruebo el stock en el almacén origen del articulo y la cantidad que sale y si es menor lo notifica
                    Dim i As Integer = 0

                    For Each filas As DataRow In dt.Rows
                        Dim tbstockalmc As New DataTable
                        Dim filtro As New Filter

                        filtro.Add("IDArticulo", FilterOperator.Equal, dt.Rows(i)("IDArticulo").ToString)
                        filtro.Add("IDAlmacen", FilterOperator.Equal, dt.Rows(i)("IDAlmacenOrigen").ToString)
                        tbstockalmc = New BE.DataEngine().Filter("tbMaestroArticuloAlmacen", filtro)

                        'If tbstockalmc.Rows.Count = 0 Or tbstockalmc.Rows(0)("StockFisico") <= dt.Rows(i)("Cantidad") Then
                        If tbstockalmc.Rows.Count = 0 Then
                            ExpertisApp.GenerateMessage("No hay stock suficiente del articulo " & dt.Rows(i)("IDArticulo") & " para generar el movimiento.")
                            Exit Sub
                        Else
                            If tbstockalmc.Rows(0)("StockFisico") < dt.Rows(i)("Cantidad") Then
                                ExpertisApp.GenerateMessage("No hay stock suficiente del articulo " & dt.Rows(i)("IDArticulo") & " para generar el movimiento.")
                                Exit Sub
                            End If
                        End If
                        i += 1
                    Next

                    Dim dt2 As New DataTable
                    dt2.Columns.Add("IDArticulo")
                    dt2.Columns.Add("DescArticulo")
                    dt2.Columns.Add("IDAlmacenOrigen")
                    dt2.Columns.Add("DescAlmacenOrigen")
                    dt2.Columns.Add("StockFisicoOrigen")
                    dt2.Columns.Add("Cantidad")
                    dt2.Columns.Add("IDAlmacenDestino")
                    dt2.Columns.Add("DescAlmacenDestino")
                    dt2.Columns.Add("StockFisicoDestino")
                    dt2.Columns.Add("Actualizado")
                    dt2.Columns.Add("FechaDocumento")

                    Dim dr2 As DataRow
                    For Each dr As DataRow In dt.Rows
                        'MessageBox.Show(dr(0) & " , " & dr(2) & " , " & dr(7))
                        If IsDBNull(dr(0)) Then
                        Else
                            If IsDBNull(dr(4)) = False Then
                                dr2 = dt2.NewRow
                                dr2("IDArticulo") = dr(0)
                                'Segun el IDArticulo saco la Desc
                                Dim tbart As New DataTable
                                Dim filtro1 As New Filter

                                filtro1.Add("IDArticulo", FilterOperator.Equal, dr(0).ToString)
                                tbart = New BE.DataEngine().Filter("tbMaestroArticulo", filtro1)
                                dr2("DescArticulo") = tbart.Rows(0)("DescArticulo")

                                dr2("IDAlmacenOrigen") = dr(1)
                                'Según el IDAlmacen saco la descripcion
                                Dim tbalm As New DataTable
                                Dim filtro2 As New Filter

                                filtro2.Add("IDAlmacen", FilterOperator.Equal, dr(1))
                                tbalm = New BE.DataEngine().Filter("tbMaestroAlmacen", filtro2)
                                dr2("DescAlmacenOrigen") = tbalm.Rows(0)("DescAlmacen")
                                'Saco el Stock Fisico del articulo en el almacen origen
                                Try
                                    Dim tbstockalmc As New DataTable
                                    Dim filtro As New Filter
                                    filtro.Add("IDArticulo", FilterOperator.Equal, dr2("IDArticulo"))
                                    filtro.Add("IDAlmacen", FilterOperator.Equal, dr2("IDAlmacenOrigen"))
                                    tbstockalmc = New BE.DataEngine().Filter("tbMaestroArticuloAlmacen", filtro)
                                    dr2("StockFisicoOrigen") = tbstockalmc.Rows(0)("StockFisico")
                                Catch ex As Exception
                                    dr2("StockFisicoOrigen") = 0
                                End Try
                               

                                dr2("Cantidad") = dr(2)
                                dr2("IDAlmacenDestino") = dr(3)
                                'Según el IDAlmacen saco la descripcion
                                Dim tbalm2 As New DataTable
                                Dim filtro22 As New Filter

                                filtro22.Add("IDAlmacen", FilterOperator.Equal, dr(3))
                                tbalm2 = New BE.DataEngine().Filter("tbMaestroAlmacen", filtro22)
                                dr2("DescAlmacenDestino") = tbalm2.Rows(0)("DescAlmacen")
                                'Saco el Stock Fisico del articulo en el almacen destino
                                Try
                                    Dim tbstockalmcdest As New DataTable
                                    Dim filtrodest As New Filter
                                    filtrodest.Add("IDArticulo", FilterOperator.Equal, dr2("IDArticulo"))
                                    filtrodest.Add("IDAlmacen", FilterOperator.Equal, dr2("IDAlmacenDestino"))
                                    tbstockalmcdest = New BE.DataEngine().Filter("tbMaestroArticuloAlmacen", filtrodest)
                                    dr2("StockFisicoDestino") = tbstockalmcdest.Rows(0)("StockFisico")
                                Catch ex As Exception
                                    dr2("StockFisicoDestino") = 0
                                End Try

                                dr2("Actualizado") = 0
                                dr2("FechaDocumento") = dr(4)
                                dt2.Rows.Add(dr2)
                                control = control + 1
                            End If
                        End If
                    Next

                    Grid.DataSource = dt2
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)

                    MessageBox.Show("Error. No hay más datos que añadir. ")
                End Try
            End If
        End With
    End Sub
    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt



    End Function
End Class
