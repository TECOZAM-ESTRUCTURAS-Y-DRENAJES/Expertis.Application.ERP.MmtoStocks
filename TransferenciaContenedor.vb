Public Class TransferenciaContenedor
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mLotesOrigen As ERP.CommonClasses.LoteStockableUserDialog
    Private mLotesDestino As ERP.CommonClasses.LoteStockableUserDialog
    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialog

    Private Const mcOrigen As Integer = -1
    Private Const mcDestino As Integer = 1

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        '//Lotes
        mLotesOrigen = New ERP.CommonClasses.LoteStockableUserDialog
        mLotesOrigen.Text = "TRANSFERENCIA DE SALIDA"
        mLotesOrigen.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mLotesOrigen.DataSchema.IDAlmacen = "IDAlmacenContenedor"
        mLotesOrigen.DataSchema.Cantidad = "CantidadMarca1"
        mLotesOrigen.DataSource = Grid

        mLotesDestino = New ERP.CommonClasses.LoteStockableUserDialog
        mLotesDestino.Text = "TRANSFERENCIA DE ENTRADA"
        mLotesDestino.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
        mLotesDestino.DataSchema.IDAlmacen = "IDAlmacenPredeterminado"
        mLotesDestino.DataSchema.Cantidad = "CantidadMarca1"
        mLotesDestino.DataSource = Grid

        '//Series
        mSeries = New ERP.CommonClasses.NSerieStockableUserDialog
        mSeries.Text = "TRANSFERENCIAS"
        mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
        mSeries.DataSchema.IDAlmacen = "IDAlmacenContenedor"
        mSeries.DataSchema.Cantidad = "CantidadMarca1"
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
    Friend WithEvents LblContenedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblAlmacenCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlmacenCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblAlmacenPredeterminado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlmPred As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblGestionLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbGestionLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim CmbGestionLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransferenciaContenedor))
        Me.LblContenedor = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblAlmacenCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacenCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblAlmacenPredeterminado = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmPred = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblGestionLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbGestionLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.CmbGestionLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.CmbGestionLotes)
        Me.FilterPanel.Controls.Add(Me.LblGestionLotes)
        Me.FilterPanel.Controls.Add(Me.AdvAlmPred)
        Me.FilterPanel.Controls.Add(Me.LblAlmacenPredeterminado)
        Me.FilterPanel.Controls.Add(Me.AdvCliente)
        Me.FilterPanel.Controls.Add(Me.LblCliente)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacenCliente)
        Me.FilterPanel.Controls.Add(Me.LblAlmacenCliente)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Controls.Add(Me.LblContenedor)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 341)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 341)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "StockFisico")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "Articulo;Almacen"
        Me.Grid.Size = New System.Drawing.Size(688, 341)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vCTLCITransferenciaContenedor"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(320, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(688, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(688, 421)
        '
        'LblContenedor
        '
        Me.LblContenedor.Location = New System.Drawing.Point(8, 24)
        Me.LblContenedor.Name = "LblContenedor"
        Me.LblContenedor.Size = New System.Drawing.Size(74, 13)
        Me.LblContenedor.TabIndex = 14
        Me.LblContenedor.Text = "Contenedor"
        Me.LblContenedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(120, 24)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(96, 23)
        Me.AdvArticulo.TabIndex = 0
        '
        'LblAlmacenCliente
        '
        Me.LblAlmacenCliente.Location = New System.Drawing.Point(280, 24)
        Me.LblAlmacenCliente.Name = "LblAlmacenCliente"
        Me.LblAlmacenCliente.Size = New System.Drawing.Size(100, 13)
        Me.LblAlmacenCliente.TabIndex = 16
        Me.LblAlmacenCliente.Text = "Almacén Cliente"
        Me.LblAlmacenCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvAlmacenCliente
        '
        Me.AdvAlmacenCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacenCliente.EntityName = "Almacen"
        Me.AdvAlmacenCliente.Location = New System.Drawing.Point(384, 24)
        Me.AdvAlmacenCliente.Name = "AdvAlmacenCliente"
        Me.AdvAlmacenCliente.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacenCliente.Size = New System.Drawing.Size(96, 23)
        Me.AdvAlmacenCliente.TabIndex = 2
        '
        'LblCliente
        '
        Me.LblCliente.Location = New System.Drawing.Point(528, 24)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(47, 13)
        Me.LblCliente.TabIndex = 18
        Me.LblCliente.Text = "Cliente"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvCliente
        '
        Me.AdvCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvCliente.EntityName = "Cliente"
        Me.AdvCliente.Location = New System.Drawing.Point(584, 24)
        Me.AdvCliente.Name = "AdvCliente"
        Me.AdvCliente.SecondaryDataFields = "IDCliente"
        Me.AdvCliente.Size = New System.Drawing.Size(96, 23)
        Me.AdvCliente.TabIndex = 4
        '
        'LblAlmacenPredeterminado
        '
        Me.LblAlmacenPredeterminado.Location = New System.Drawing.Point(280, 48)
        Me.LblAlmacenPredeterminado.Name = "LblAlmacenPredeterminado"
        Me.LblAlmacenPredeterminado.Size = New System.Drawing.Size(90, 13)
        Me.LblAlmacenPredeterminado.TabIndex = 20
        Me.LblAlmacenPredeterminado.Text = "Almacén Pred."
        Me.LblAlmacenPredeterminado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvAlmPred
        '
        Me.AdvAlmPred.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmPred.EntityName = "Almacen"
        Me.AdvAlmPred.Location = New System.Drawing.Point(384, 48)
        Me.AdvAlmPred.Name = "AdvAlmPred"
        Me.AdvAlmPred.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmPred.Size = New System.Drawing.Size(96, 23)
        Me.AdvAlmPred.TabIndex = 3
        '
        'LblGestionLotes
        '
        Me.LblGestionLotes.Location = New System.Drawing.Point(8, 48)
        Me.LblGestionLotes.Name = "LblGestionLotes"
        Me.LblGestionLotes.Size = New System.Drawing.Size(107, 13)
        Me.LblGestionLotes.TabIndex = 22
        Me.LblGestionLotes.Text = "Gestión por Lotes"
        '
        'CmbGestionLotes
        '
        CmbGestionLotes_DesignTimeLayout.LayoutString = resources.GetString("CmbGestionLotes_DesignTimeLayout.LayoutString")
        Me.CmbGestionLotes.DesignTimeLayout = CmbGestionLotes_DesignTimeLayout
        Me.CmbGestionLotes.DisabledBackColor = System.Drawing.Color.White
        Me.CmbGestionLotes.DisplayMember = "Text"
        Me.CmbGestionLotes.Location = New System.Drawing.Point(120, 48)
        Me.CmbGestionLotes.Name = "CmbGestionLotes"
        Me.CmbGestionLotes.SelectedIndex = -1
        Me.CmbGestionLotes.SelectedItem = Nothing
        Me.CmbGestionLotes.Size = New System.Drawing.Size(96, 21)
        Me.CmbGestionLotes.TabIndex = 1
        Me.CmbGestionLotes.ValueMember = "Value"
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        Me.Icons.Images.SetKeyName(2, "")
        Me.Icons.Images.SetKeyName(3, "")
        '
        'TransferenciaContenedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("CantidadMarca1", "Cantidad", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "StockFisico")})
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "Articulo;Almacen"
        Me.Name = "TransferenciaContenedor"
        Me.UseCheck = True
        Me.ViewName = "vCTLCITransferenciaContenedor"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.CmbGestionLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Funciones Privadas"

    Private Sub LoadEnums()
        CmbGestionLotes.DataSource = EnumData.EnumView("enumBoolean")
        CmbGestionLotes.Value = CInt(enumBoolean.Todos)
    End Sub

    Private Sub LoadFormActions()
        Me.FormActions.Add("Realizar Transferencia", AddressOf GenerarMovimientos)
    End Sub

    Private Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        Me.UnCheckAllRecords()
        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Value, FilterType.String)
        e.Filter.Add("IDAlmacenContenedor", FilterOperator.Equal, Me.AdvAlmacenCliente.Value, FilterType.String)
        e.Filter.Add("IDAlmacenPredeterminado", FilterOperator.Equal, Me.AdvAlmPred.Value, FilterType.String)
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvCliente.Value, FilterType.String)
        If CmbGestionLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add(New BooleanFilterItem("GestionStockPorLotes", CmbGestionLotes.Value))
        End If
    End Sub

    Private Function Lotes() As Boolean
        If Grid.GetRow.RowType = RowType.Record Then
            Dim ID As String = Grid.GetValue("MarcaAuto")
            Dim Articulo As String = Nz(Grid.GetValue("IDArticulo"))
            Dim AlmacenOrigen As String = Nz(Grid.GetValue("IDAlmacenContenedor"))
            Dim AlmacenDestino As String = Nz(Grid.GetValue("IDAlmacenPredeterminado"))

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

    Private Function Series() As Boolean
        If Grid.GetRow.RowType = RowType.Record Then
            Dim ID As Integer = Grid.GetValue("MarcaAuto")
            Dim Articulo As String = Nz(Grid.GetValue("IDArticulo"))
            Dim AlmacenOrigen As String = Nz(Grid.GetValue("IDAlmacenContenedor"))
            Dim AlmacenDestino As String = Nz(Grid.GetValue("IDAlmacenPredeterminado"))
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

    Private Sub GenerarMovimientos()
        Dim DrChecks() As DataRow = CType(Grid.DataSource, DataTable).Select("Expertis.CheckValue = 1")
        If DrChecks.Length > 0 Then
            Dim DtGrid As DataTable = CType(Grid.DataSource, DataTable).Clone
            For Each Dr As DataRow In DrChecks
                DtGrid.ImportRow(Dr)
            Next
            DtGrid.AcceptChanges()

            If Grid.DataChanged Then
                ExpertisApp.GenerateMessage("Existen actualizaciones pendientes.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Dim dt As DataTable = CType(Grid.DataSource, DataTable)
                Dim dt As DataTable = Grid.CheckedRecords
                Dim N As Integer = ExpertisApp.ExecuteTask(Of Object, Integer)(AddressOf ProcesoStocks.NuevoNumeroMovimiento, Nothing)

                Dim Detalle(-1) As StockUpdateData
                Dim AlmacenDestinoVacio As String = ""
                For Each dr As DataRow In DtGrid.Select
                    Dim ID As String = dr("MarcaAuto")
                    Dim Articulo As String = dr("IDArticulo")
                    Dim AlmacenOrigen As String = dr("IDAlmacenContenedor")
                    'Dim AlmacenDestino As String = Dr("IDAlmacenPredeterminado") & String.Empty

                    Dim cantidad As Double = Nz(dr("CantidadMarca1"), 0)
                    If Length(dr("IDAlmacenPredeterminado")) > 0 Then
                        Dim aux(-1) As StockUpdateData
                        If dr("GestionStockPorLotes") Then
                            Dim lotes(-1) As StockData
                            Dim origen(-1) As StockData
                            Dim destino(-1) As StockData
                            lotes = mLotesOrigen.LoteCollection.GetStockData(ID, Articulo, mcOrigen)
                            If Not lotes Is Nothing AndAlso lotes.Length > 0 Then
                                For Each o As StockData In lotes
                                    If o.Cantidad > 0 Then
                                        o.TipoMovimiento = enumTipoMovimiento.tmSalTransferencia
                                        ReDim Preserve origen(origen.Length)
                                        origen(origen.Length - 1) = o
                                    End If
                                Next
                                lotes = mLotesDestino.LoteCollection.GetStockData(ID, Articulo, mcDestino)
                                If Not lotes Is Nothing AndAlso lotes.Length > 0 Then
                                    For Each d As StockData In lotes
                                        If d.Cantidad > 0 Then
                                            d.TipoMovimiento = enumTipoMovimiento.tmEntTransferencia
                                            ReDim Preserve destino(destino.Length)
                                            destino(destino.Length - 1) = d
                                        End If
                                    Next
                                Else
                                    ExpertisApp.GenerateMessage("El lote es obligatorio para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, dr("IDAlmacenPredeterminado"))
                                End If
                                Dim datosTransferencia As New ProcesoStocks.DataTransferenciaDesgloseLote(N, origen, destino)
                                aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferenciaDesgloseLote, StockUpdateData())(AddressOf ProcesoStocks.TransferenciaDesgloseLote, datosTransferencia)
                            Else
                                ExpertisApp.GenerateMessage("El lote es obligatorio para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                            End If
                        ElseIf dr("NSerieObligatorio") Then
                            Dim origen(-1) As StockData
                            Dim destino(-1) As StockData
                            origen = mSeries.SerieCollection.SeriesSeleccionadasFormatoStockData(ID, Articulo)
                            If Not origen Is Nothing AndAlso origen.Length > 0 Then
                                For Each o As StockData In origen
                                    o.TipoMovimiento = enumTipoMovimiento.tmSalTransferencia
                                    Dim d As New StockData(o.Articulo, dr("IDAlmacenPredeterminado"), o.NSerie, o.Activo, o.EstadoNSerie, o.Operario, o.FechaDocumento, enumTipoMovimiento.tmEntTransferencia)
                                    d.Texto = o.Texto
                                    StockDataManager.Copy(d, destino)
                                Next
                                Dim datosTransferencia As New ProcesoStocks.DataTransferenciaDesgloseLote(N, origen, destino)
                                aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferenciaDesgloseLote, StockUpdateData())(AddressOf ProcesoStocks.TransferenciaDesgloseLote, datosTransferencia)
                            Else
                                ExpertisApp.GenerateMessage("No se han especificado los números de serie para el artículo | en el almacén |.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, Articulo, AlmacenOrigen)
                            End If
                        Else
                            Dim origen As New StockData(Articulo, AlmacenOrigen, cantidad, 0, 0, Today, enumTipoMovimiento.tmSalTransferencia)
                            Dim destino As New StockData(Articulo, dr("IDAlmacenPredeterminado"), cantidad, 0, 0, Today, enumTipoMovimiento.tmEntTransferencia)
                            Dim datosTransferencia As New ProcesoStocks.DataTransferencia(N, origen, destino)
                            aux = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataTransferencia, StockUpdateData())(AddressOf ProcesoStocks.Transferencia, datosTransferencia)
                        End If
                        If aux.Length > 0 Then StockDataManager.Copy(aux, Detalle)
                    Else
                        If Length(AlmacenDestinoVacio) > 0 Then AlmacenDestinoVacio = AlmacenDestinoVacio & ","
                        AlmacenDestinoVacio = AlmacenDestinoVacio & dr("IDArticulo")
                    End If
                Next
                If Not Detalle Is Nothing AndAlso Detalle.Length > 0 Then
                    Dim frm As New DetalleActualizacionStock
                    frm.DataSource = Detalle
                    frm.ShowDialog()
                End If
                If Length(AlmacenDestinoVacio) > 0 Then
                    ExpertisApp.GenerateMessage("Los siguientes artículos no tienen un almacén predetermindado: ||", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, vbNewLine, AlmacenDestinoVacio)
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna linea del Grid.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Me.UnCheckAllRecords()
        Me.Execute()
    End Sub

#End Region

#Region "Eventos Transferencia Contenedor"

#Region "Eventos Formulario"

    Private Sub TransferenciaContenedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEnums()
        LoadFormActions()
    End Sub

    Private Sub TransferenciaContenedor_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
    End Sub

    Private Sub TransferenciaContenedor_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        CmbGestionLotes.Value = CInt(enumBoolean.Todos)
    End Sub

    Private Sub TransferenciaContenedor_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.UnChecked Then
            If e.RowData("GestionStockPorLotes") Then
                mLotesOrigen.LoteCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacenContenedor"))
            ElseIf e.RowData("NSerieObligatorio") Then
                mSeries.SerieCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacenContenedor"))
            End If
        End If
    End Sub

#End Region

#Region "Eventos DataGrid"

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        e.Row.Cells("ArticuloContenedor").Text = e.Row.Cells("IDArticulo").Value & " - " & e.Row.Cells("DescArticulo").Value
        e.Row.Cells("Destino").Text = e.Row.Cells("IDAlmacenPredeterminado").Value & " - " & e.Row.Cells("DescAlmacenPredeterminado").Value
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Dim c As GridEXColumn = Grid.Columns("CantidadMarca1")
        If Grid.GetValue("GestionStockPorLotes") Then
            c.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
            c.ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
            c.ButtonStyle = ButtonStyle.Image
            c.ButtonImage = Icons.Images(0)
        ElseIf Grid.GetValue("NSerieObligatorio") Then
            c.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
            c.ButtonDisplayMode = CellButtonDisplayMode.CurrentRow
            c.ButtonStyle = ButtonStyle.Image
            c.ButtonImage = Icons.Images(1)
        Else
            c.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
        End If
    End Sub

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        If e.Column.Key = "CantidadMarca1" Then
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
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        If e.Column.Key = "CantidadMarca1" Then
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
        End If
    End Sub

#End Region

#End Region

End Class