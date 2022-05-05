Public Class Inventarios
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Private cnCONTABILIZAR_INVENTARIO As String = "Contabilizar Ultimo Inventario"
    'Private cnDESCONTABILIZAR_INVENTARIO As String = "Descontabilizar Ultimo Inventario"

    Private mblnInventarioPermanente As Boolean
    Private mTipoInventario As TipoInventario '//Primer o último movimiento del día

    Private mblnStkDobleUnidad As Boolean
    Private mLotes As ERP.CommonClasses.LoteStockableUserDialog
    Friend WithEvents advIDArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialog

    Private Const EXCEL_COL_IDArticulo As String = "Artículo"
    Private Const EXCEL_COL_Descripcion As String = "Descripción"
    Private Const EXCEL_COL_IDAlmacen As String = "Almacén"
    Private Const EXCEL_COL_Lote As String = "Lote"
    Private Const EXCEL_COL_Ubicacion As String = "Ubicación"
    Private Const EXCEL_COL_StockFisico As String = "Stock Físico"
    Private Const EXCEL_COL_StockLoteUbicacion As String = "Stock Lote-Ubicación UD1"
    Private Const EXCEL_COL_StockLoteUbicacion2 As String = "Stock Lote-Ubicación UD2"
    Private Const EXCEL_COL_FechaCaducidad As String = "Fecha Caducidad"
    Private Const EXCEL_COL_NuevoStockUD1 As String = "Nuevo Stock UD1"
    Private Const EXCEL_COL_NuevoStockUD2 As String = "Nuevo Stock UD2"
    Private Const EXCEL_COL_NuevaFechaCaducidad As String = "Nueva Fecha Caducidad"

    Private dtDatosExcel As DataTable
    Private mblnImportandoExcel As Boolean = False

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        mLotes = New ERP.CommonClasses.LoteStockableUserDialog
        mLotes.Text = "INVENTARIO"
        mLotes.DataSource = Grid
        mLotes.ProponerCantidades = True

        mSeries = New ERP.CommonClasses.NSerieStockableUserDialog
        mSeries.Text = "INVENTARIO"
        mSeries.DataSource = Grid
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
    Friend WithEvents fwiNSerie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFUltimoInventario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFUltimoInventario2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiInventariados As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiInventariados As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMayorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiArticuloPorLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblfwiArticuloPorLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMenorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TopPanel As System.Windows.Forms.Panel
    Friend WithEvents lblfwiFInventario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents StockDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents StockHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FechaInventario As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventarios))
        Dim fwiInventariados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiArticuloPorLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.fwiNSerie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFUltimoInventario = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.FechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblfwiFUltimoInventario2 = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiInventariados = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiInventariados = New Solmicro.Expertis.Engine.UI.Label
        Me.StockDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiStockMayorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiArticuloPorLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiArticuloPorLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.StockHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiStockMenorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.TopPanel = New System.Windows.Forms.Panel
        Me.lblfwiFInventario = New Solmicro.Expertis.Engine.UI.Label
        Me.FechaInventario = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.fwiNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiInventariados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiArticuloPorLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advIDArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblTipo)
        Me.FilterPanel.Controls.Add(Me.lblfwiNSerie)
        Me.FilterPanel.Controls.Add(Me.lblfwiSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiFUltimoInventario)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiFUltimoInventario2)
        Me.FilterPanel.Controls.Add(Me.lblfwiInventariados)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMayorQue)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMenorQue)
        Me.FilterPanel.Controls.Add(Me.fwiNSerie)
        Me.FilterPanel.Controls.Add(Me.fwiSubfamilia)
        Me.FilterPanel.Controls.Add(Me.fwiFamilia)
        Me.FilterPanel.Controls.Add(Me.fwiTipo)
        Me.FilterPanel.Controls.Add(Me.FechaDesde)
        Me.FilterPanel.Controls.Add(Me.fwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.fwiArticulo)
        Me.FilterPanel.Controls.Add(Me.FechaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiInventariados)
        Me.FilterPanel.Controls.Add(Me.StockDesde)
        Me.FilterPanel.Controls.Add(Me.fwiArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.StockHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 301)
        Me.FilterPanel.Size = New System.Drawing.Size(784, 120)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.TopPanel)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(784, 301)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.TopPanel, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("Cantidad", "Stock", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, ""), New Solmicro.Expertis.Engine.UI.CheckField("Cantidad2", "Stock 2Ud.", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.Icons
        Me.Grid.KeyField = "IDArticulo;IDAlmacen"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.PrimaryDataFields = "IDArticulo;IDAlmacen"
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = "IDArticulo;IDAlmacen"
        Me.Grid.Size = New System.Drawing.Size(784, 269)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vFrmCIInventario"
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
        Me.MainPanel.Size = New System.Drawing.Size(784, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(784, 421)
        '
        'fwiNSerie
        '
        fwiNSerie_DesignTimeLayout.LayoutString = resources.GetString("fwiNSerie_DesignTimeLayout.LayoutString")
        Me.fwiNSerie.DesignTimeLayout = fwiNSerie_DesignTimeLayout
        Me.fwiNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNSerie.Location = New System.Drawing.Point(497, 94)
        Me.fwiNSerie.Name = "fwiNSerie"
        Me.fwiNSerie.SelectedIndex = -1
        Me.fwiNSerie.SelectedItem = Nothing
        Me.fwiNSerie.Size = New System.Drawing.Size(99, 21)
        Me.fwiNSerie.TabIndex = 9
        '
        'lblfwiNSerie
        '
        Me.lblfwiNSerie.Location = New System.Drawing.Point(406, 98)
        Me.lblfwiNSerie.Name = "lblfwiNSerie"
        Me.lblfwiNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiNSerie.TabIndex = 16
        Me.lblfwiNSerie.Tag = ""
        Me.lblfwiNSerie.Text = "Nº Serie"
        '
        'fwiSubfamilia
        '
        Me.fwiSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiSubfamilia.EntityName = "Subfamilia"
        Me.fwiSubfamilia.Location = New System.Drawing.Point(287, 70)
        Me.fwiSubfamilia.Name = "fwiSubfamilia"
        Me.fwiSubfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.fwiSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.fwiSubfamilia.Size = New System.Drawing.Size(109, 23)
        Me.fwiSubfamilia.TabIndex = 5
        Me.fwiSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(217, 75)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 8
        Me.lblfwiSubfamilia.Tag = ""
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'fwiFamilia
        '
        Me.fwiFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFamilia.EntityName = "Familia"
        Me.fwiFamilia.Location = New System.Drawing.Point(287, 46)
        Me.fwiFamilia.Name = "fwiFamilia"
        Me.fwiFamilia.PrimaryDataFields = "IDFamilia"
        Me.fwiFamilia.SecondaryDataFields = "IDFamilia"
        Me.fwiFamilia.Size = New System.Drawing.Size(109, 23)
        Me.fwiFamilia.TabIndex = 4
        Me.fwiFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(217, 51)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 6
        Me.lblfwiFamilia.Tag = ""
        Me.lblfwiFamilia.Text = "Familia"
        '
        'fwiTipo
        '
        Me.fwiTipo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipo.EntityName = "TipoArticulo"
        Me.fwiTipo.Location = New System.Drawing.Point(287, 22)
        Me.fwiTipo.Name = "fwiTipo"
        Me.fwiTipo.PrimaryDataFields = "IDTipo"
        Me.fwiTipo.SecondaryDataFields = "IDTipo"
        Me.fwiTipo.Size = New System.Drawing.Size(109, 23)
        Me.fwiTipo.TabIndex = 3
        Me.fwiTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'FechaDesde
        '
        Me.FechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDesde.Location = New System.Drawing.Point(497, 22)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(99, 21)
        Me.FechaDesde.TabIndex = 6
        '
        'lblfwiFUltimoInventario
        '
        Me.lblfwiFUltimoInventario.Location = New System.Drawing.Point(406, 26)
        Me.lblfwiFUltimoInventario.Name = "lblfwiFUltimoInventario"
        Me.lblfwiFUltimoInventario.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiFUltimoInventario.TabIndex = 10
        Me.lblfwiFUltimoInventario.Tag = ""
        Me.lblfwiFUltimoInventario.Text = "F. Ult. Inv. >="
        '
        'fwiAlmacen
        '
        Me.fwiAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAlmacen.EntityName = "Almacen"
        Me.fwiAlmacen.Location = New System.Drawing.Point(98, 46)
        Me.fwiAlmacen.Name = "fwiAlmacen"
        Me.fwiAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.Size = New System.Drawing.Size(109, 23)
        Me.fwiAlmacen.TabIndex = 1
        Me.fwiAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(7, 50)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 2
        Me.lblfwiAlmacen.Tag = ""
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'fwiArticulo
        '
        Me.fwiArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiArticulo.EntityName = "Articulo"
        Me.fwiArticulo.Location = New System.Drawing.Point(98, 22)
        Me.fwiArticulo.Name = "fwiArticulo"
        Me.fwiArticulo.PrimaryDataFields = "IDArticulo"
        Me.fwiArticulo.SecondaryDataFields = "IDArticulo"
        Me.fwiArticulo.Size = New System.Drawing.Size(109, 23)
        Me.fwiArticulo.TabIndex = 0
        Me.fwiArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(7, 26)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 0
        Me.lblfwiArticulo.Tag = ""
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'FechaHasta
        '
        Me.FechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaHasta.Location = New System.Drawing.Point(497, 46)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(99, 21)
        Me.FechaHasta.TabIndex = 7
        '
        'lblfwiFUltimoInventario2
        '
        Me.lblfwiFUltimoInventario2.Location = New System.Drawing.Point(406, 50)
        Me.lblfwiFUltimoInventario2.Name = "lblfwiFUltimoInventario2"
        Me.lblfwiFUltimoInventario2.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiFUltimoInventario2.TabIndex = 12
        Me.lblfwiFUltimoInventario2.Tag = ""
        Me.lblfwiFUltimoInventario2.Text = "F. Ult. Inv. <="
        '
        'fwiInventariados
        '
        fwiInventariados_DesignTimeLayout.LayoutString = resources.GetString("fwiInventariados_DesignTimeLayout.LayoutString")
        Me.fwiInventariados.DesignTimeLayout = fwiInventariados_DesignTimeLayout
        Me.fwiInventariados.DisabledBackColor = System.Drawing.Color.White
        Me.fwiInventariados.Location = New System.Drawing.Point(696, 70)
        Me.fwiInventariados.Name = "fwiInventariados"
        Me.fwiInventariados.SelectedIndex = -1
        Me.fwiInventariados.SelectedItem = Nothing
        Me.fwiInventariados.Size = New System.Drawing.Size(79, 21)
        Me.fwiInventariados.TabIndex = 12
        '
        'lblfwiInventariados
        '
        Me.lblfwiInventariados.Location = New System.Drawing.Point(608, 74)
        Me.lblfwiInventariados.Name = "lblfwiInventariados"
        Me.lblfwiInventariados.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiInventariados.TabIndex = 22
        Me.lblfwiInventariados.Tag = ""
        Me.lblfwiInventariados.Text = "Inventariados"
        '
        'StockDesde
        '
        Me.StockDesde.DisabledBackColor = System.Drawing.Color.White
        Me.StockDesde.Location = New System.Drawing.Point(696, 22)
        Me.StockDesde.Name = "StockDesde"
        Me.StockDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.StockDesde.Size = New System.Drawing.Size(79, 21)
        Me.StockDesde.TabIndex = 10
        '
        'lblfwiStockMayorQue
        '
        Me.lblfwiStockMayorQue.Location = New System.Drawing.Point(608, 26)
        Me.lblfwiStockMayorQue.Name = "lblfwiStockMayorQue"
        Me.lblfwiStockMayorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMayorQue.TabIndex = 18
        Me.lblfwiStockMayorQue.Tag = ""
        Me.lblfwiStockMayorQue.Text = "Stock >="
        '
        'fwiArticuloPorLotes
        '
        fwiArticuloPorLotes_DesignTimeLayout.LayoutString = resources.GetString("fwiArticuloPorLotes_DesignTimeLayout.LayoutString")
        Me.fwiArticuloPorLotes.DesignTimeLayout = fwiArticuloPorLotes_DesignTimeLayout
        Me.fwiArticuloPorLotes.DisabledBackColor = System.Drawing.Color.White
        Me.fwiArticuloPorLotes.Location = New System.Drawing.Point(497, 70)
        Me.fwiArticuloPorLotes.Name = "fwiArticuloPorLotes"
        Me.fwiArticuloPorLotes.SelectedIndex = -1
        Me.fwiArticuloPorLotes.SelectedItem = Nothing
        Me.fwiArticuloPorLotes.Size = New System.Drawing.Size(99, 21)
        Me.fwiArticuloPorLotes.TabIndex = 8
        '
        'lblfwiArticuloPorLotes
        '
        Me.lblfwiArticuloPorLotes.Location = New System.Drawing.Point(406, 74)
        Me.lblfwiArticuloPorLotes.Name = "lblfwiArticuloPorLotes"
        Me.lblfwiArticuloPorLotes.Size = New System.Drawing.Size(37, 13)
        Me.lblfwiArticuloPorLotes.TabIndex = 14
        Me.lblfwiArticuloPorLotes.Tag = ""
        Me.lblfwiArticuloPorLotes.Text = "Lotes"
        '
        'StockHasta
        '
        Me.StockHasta.DisabledBackColor = System.Drawing.Color.White
        Me.StockHasta.Location = New System.Drawing.Point(696, 46)
        Me.StockHasta.Name = "StockHasta"
        Me.StockHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.StockHasta.Size = New System.Drawing.Size(79, 21)
        Me.StockHasta.TabIndex = 11
        '
        'lblfwiStockMenorQue
        '
        Me.lblfwiStockMenorQue.Location = New System.Drawing.Point(608, 50)
        Me.lblfwiStockMenorQue.Name = "lblfwiStockMenorQue"
        Me.lblfwiStockMenorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMenorQue.TabIndex = 20
        Me.lblfwiStockMenorQue.Tag = ""
        Me.lblfwiStockMenorQue.Text = "Stock <="
        '
        'TopPanel
        '
        Me.TopPanel.Controls.Add(Me.lblfwiFInventario)
        Me.TopPanel.Controls.Add(Me.FechaInventario)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(784, 32)
        Me.TopPanel.TabIndex = 1
        '
        'lblfwiFInventario
        '
        Me.lblfwiFInventario.Location = New System.Drawing.Point(20, 8)
        Me.lblfwiFInventario.Name = "lblfwiFInventario"
        Me.lblfwiFInventario.Size = New System.Drawing.Size(103, 13)
        Me.lblfwiFInventario.TabIndex = 0
        Me.lblfwiFInventario.Tag = "IdRec=5252;"
        Me.lblfwiFInventario.Text = "Fecha Inventario"
        '
        'FechaInventario
        '
        Me.FechaInventario.DisabledBackColor = System.Drawing.Color.White
        Me.FechaInventario.Location = New System.Drawing.Point(128, 6)
        Me.FechaInventario.Name = "FechaInventario"
        Me.FechaInventario.Size = New System.Drawing.Size(120, 21)
        Me.FechaInventario.TabIndex = 1
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
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(217, 27)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 4
        Me.lblTipo.Text = "Tipo"
        '
        'advIDArticuloPadre
        '
        Me.advIDArticuloPadre.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloPadre.EntityName = "Articulo"
        Me.advIDArticuloPadre.Location = New System.Drawing.Point(98, 70)
        Me.advIDArticuloPadre.Name = "advIDArticuloPadre"
        Me.advIDArticuloPadre.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloPadre.Size = New System.Drawing.Size(109, 23)
        Me.advIDArticuloPadre.TabIndex = 2
        Me.advIDArticuloPadre.ViewName = "tbMaestroArticulo"
        '
        'lblArticuloPadre
        '
        Me.lblArticuloPadre.Location = New System.Drawing.Point(7, 74)
        Me.lblArticuloPadre.Name = "lblArticuloPadre"
        Me.lblArticuloPadre.Size = New System.Drawing.Size(87, 13)
        Me.lblArticuloPadre.TabIndex = 33
        Me.lblArticuloPadre.Tag = ""
        Me.lblArticuloPadre.Text = "Artículo Padre"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Inventarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("Cantidad", "Stock", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, ""), New Solmicro.Expertis.Engine.UI.CheckField("Cantidad2", "Stock 2Ud.", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "")})
        Me.ClientSize = New System.Drawing.Size(792, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "IDArticulo;IDAlmacen"
        Me.Name = "Inventarios"
        Me.Text = "Inventario"
        Me.UseCheck = True
        Me.ViewName = "vFrmCIInventario"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.fwiNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiInventariados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiArticuloPorLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function ComprobarArticuloNSerie(ByVal IDArticulo As String, ByVal IDAlmacen As String, ByVal Fecha As Date) As Boolean
        Dim bLimpio As Boolean
        Dim ff As New Filter
        bLimpio = True
        Dim clsp As New Parametro
        Dim Valor As Integer = clsp.TipoInventario
        Dim OC As New BE.DataEngine
        ff.Add("IDArticulo", FilterOperator.Equal, IDArticulo)
        ff.Add("IDAlmacen", FilterOperator.Equal, IDAlmacen)
        If Valor = 0 Then
            ff.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Fecha)
        ElseIf Valor = 1 Then
            ff.Add("FechaDocumento", FilterOperator.GreaterThan, Fecha)
        End If
        Dim dtAAL As DataTable = OC.Filter("tbHistoricoMovimiento", ff)
        If Not IsNothing(dtAAL) AndAlso dtAAL.Rows.Count > 0 Then
            bLimpio = False
        Else
            bLimpio = True
        End If
        Return bLimpio
    End Function

    Private Sub Inventarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadFormActions()
            LoadGridActions()
            LoadEnums()
            SettingSegundaUnidad()
        End If
        'pend: lo siguiente no deberia tener que programarse
        StockDesde.Value = Nothing
        StockHasta.Value = Nothing
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mblnInventarioPermanente = p.GestionInventarioPermanente
        mTipoInventario = p.TipoInventario
        Grid.Columns("Contabilizado").Visible = mblnInventarioPermanente
    End Sub

    Private Sub SettingSegundaUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad
        If Me.Grid.Columns.Contains("Cantidad2") Then
            Me.Grid.Columns("Cantidad2").Visible = mblnStkDobleUnidad
            If Me.Grid.Columns("Cantidad2").Visible Then
                Me.Grid.Columns("Cantidad2").CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                Me.Grid.Columns("Cantidad2").CellStyle.ForeColor = Color.Red
            End If
        End If

        If Me.Grid.Columns.Contains("IDUDInterna2") Then
            Me.Grid.Columns("IDUDInterna2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("IDUDInterna2").Position = Me.Grid.Columns("IDUDInterna").Position + 1
        End If
        If Me.Grid.Columns.Contains("StockFisico2") Then
            Me.Grid.Columns("StockFisico2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("StockFisico2").Position = Me.Grid.Columns("StockFisico").Position + 1
        End If
    End Sub

    Private Sub LoadFormActions()
        Me.FormActions.Add("Actualizar Stock", AddressOf AccionActualizarStock)
        Me.FormActions.Add("Inicializar Inventariados", AddressOf AccionInicializarInventariados)
        Me.FormActions.Add("Generar Fichero Excel", AddressOf GenerarFicheroExcel)
        Me.FormActions.Add("Importar Fichero Excel", AddressOf ImportarFicheroExcel)
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Ver Articulo", AddressOf AccionGridVerArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
    End Sub

    Private Sub AccionGridVerArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub

    Private Sub LoadEnums()
        fwiInventariados.DataSource = New EnumData("enumBoolean")
        fwiArticuloPorLotes.DataSource = New EnumData("enumBoolean")
        fwiNSerie.DataSource = New EnumData("enumBoolean")

        fwiInventariados.Value = CInt(enumBoolean.Todos)
        fwiArticuloPorLotes.Value = CInt(enumBoolean.Todos)
        fwiNSerie.Value = CInt(enumBoolean.Todos)

        If mblnInventarioPermanente Then EnumData.PopulateValueList("enumContabilizado", Grid.Columns("Contabilizado"))
    End Sub

    Private Sub AccionActualizarStock()
        If Me.CheckedRecordsCount = 0 Then
            ExpertisApp.GenerateMessage("No hay líneas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not IsDate(FechaInventario.Value) Then
                ExpertisApp.GenerateMessage("La fecha de inventario no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ElseIf FechaInventario.Value > Today Then
                ExpertisApp.GenerateMessage("La fecha de inventario es superior a la fecha actual.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim stkUDErroresPrevios(-1) As StockUpdateData
                Dim LineasSeleccionadas As Integer
                Dim dt As DataTable
                dt = Me.CheckedRecords
                If Not IsNothing(dt) AndAlso dt.Rows.Count Then
                    Dim FaltaSegundaUnidad As Boolean
                    LineasSeleccionadas = dt.Rows.Count
                    Dim data(-1) As StockData
                    Dim HayCantidadCero As Boolean
                    Dim NoCantidad As Boolean
                    For Each selectedRow As DataRow In dt.Rows
                        If Length(selectedRow("Cantidad")) > 0 Then
                            'Comprobar q por cada articulo de tipo bodega no tenga movimientos despues de la fecha introducida
                            If ComprobarArticuloBodega(selectedRow("IDArticulo"), selectedRow("IDAlmacen"), FechaInventario.Value) Then
                                Dim cantidad As Double = Nz(selectedRow("Cantidad"), 0)
                                If Not HayCantidadCero Then
                                    HayCantidadCero = (cantidad = 0)
                                End If

                                Dim desglose() As StockData = Nothing
                                If selectedRow("GestionStockPorLotes") Then
                                    desglose = mLotes.LoteCollection.GetStockData(selectedRow("IDArticulo"), selectedRow("IDAlmacen"))
                                ElseIf selectedRow("NSerieObligatorio") Then
                                    desglose = mSeries.SerieCollection.GetStockData(selectedRow("IDArticulo"), selectedRow("IDAlmacen"))
                                End If
                                If Not desglose Is Nothing Then
                                    For Each sd As StockData In desglose
                                        sd.FechaDocumento = FechaInventario.Value
                                        sd.TipoMovimiento = enumTipoMovimiento.tmInventario
                                        ReDim Preserve data(UBound(data) + 1)
                                        data(UBound(data)) = sd
                                    Next
                                Else
                                    Dim SegundaUnidad As Boolean
                                    If mblnStkDobleUnidad Then
                                        SegundaUnidad = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, selectedRow("IDArticulo"))
                                    End If

                                    Dim stkData As New StockData(selectedRow("IDArticulo"), selectedRow("IDAlmacen"), cantidad, 0, 0, FechaInventario.Value, enumTipoMovimiento.tmInventario)
                                    If SegundaUnidad AndAlso Length(selectedRow("Cantidad2")) = 0 Then
                                        FaltaSegundaUnidad = True
                                    ElseIf SegundaUnidad AndAlso Length(selectedRow("Cantidad2")) > 0 Then
                                        stkData.Cantidad2 = CDbl(selectedRow("Cantidad2"))
                                    End If

                                    If Not SegundaUnidad OrElse (SegundaUnidad AndAlso Length(selectedRow("Cantidad2")) > 0) Then
                                        ReDim Preserve data(UBound(data) + 1)
                                        data(UBound(data)) = stkData
                                    End If
                                End If
                            Else
                                Dim Msg As String = ExpertisApp.Traslate("El Artículo {0} de Bodega tiene movimientos posteriores al Inventario.", Quoted(selectedRow("IDArticulo")))

                                Dim stkUD As New StockUpdateData()
                                stkUD.StockData = New StockData
                                stkUD.StockData.Articulo = selectedRow("IDArticulo")
                                stkUD.StockData.Almacen = selectedRow("IDAlmacen")
                                stkUD.Estado = EstadoStock.NoActualizado
                                stkUD.Detalle = Msg

                                ReDim Preserve stkUDErroresPrevios(stkUDErroresPrevios.Length)
                                stkUDErroresPrevios(stkUDErroresPrevios.Length - 1) = stkUD
                            End If
                        Else
                            NoCantidad = True
                        End If
                    Next

                    If NoCantidad Then
                        ExpertisApp.GenerateMessage("Debe indicarse la Cantidad a inventariar en todos los Artículos seleccionados. Revise sus datos.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        If data.Length = 0 Then
                            ExpertisApp.GenerateMessage("No hay datos para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            Dim Cancel As Boolean
                            If HayCantidadCero Then
                                Cancel = (ExpertisApp.GenerateMessage("Uno o varios de los artículos seleccionados se va a actualizar con stock cero.|¿Continuar con la actualización?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, vbNewLine) = DialogResult.Cancel)
                            End If

                            If FaltaSegundaUnidad Then
                                ExpertisApp.GenerateMessage("Se han seleccionado Artículos con Gestión de Stock con Unidad doble, la cuál no se ha especificado. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Cancel = True
                            End If

                            If Not Cancel Then
                                Dim datInv As New DataTratarStocks(data)
                                Dim updateData As StockUpdateData() = ExpertisApp.ExecuteTask(Of DataTratarStocks, StockUpdateData())(AddressOf ProcesoStocks.InventarioMasivo, datInv)

                                Dim Errores(-1) As StockUpdateData
                                If Not updateData Is Nothing AndAlso updateData.Length > 0 Then
                                    For Each upd As StockUpdateData In updateData
                                        If upd.Estado = EstadoStock.NoActualizado Then
                                            ReDim Preserve Errores(Errores.Length)
                                            Errores(Errores.Length - 1) = upd
                                        End If
                                    Next
                                End If
                                If Errores.Length > 0 AndAlso updateData.Length <> Errores.Length Then
                                    If ExpertisApp.GenerateMessage("Se han producido errores en el Inventario. ¿Quiere ver sólo los registros erróneos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                                        updateData = Errores
                                    End If
                                End If

                                If stkUDErroresPrevios.Count > 0 Then
                                    For Each upd As StockUpdateData In stkUDErroresPrevios
                                        ReDim Preserve Errores(Errores.Length)
                                        Errores(Errores.Length - 1) = upd
                                    Next
                                    ReDim stkUDErroresPrevios(-1)
                                    Dim frmError As New DetalleActualizacionStock
                                    frmError.DataSource = Errores
                                    frmError.ShowDialog()
                                End If

                                Dim frm As New DetalleActualizacionStock
                                frm.DataSource = updateData
                                frm.ShowDialog()

                                Me.UnCheckAllRecords()
                                Me.Grid.CheckedRecords.Rows.Clear()
                                Me.RetrieveData()
                            End If
                        End If
                    End If
                End If

                If stkUDErroresPrevios.Count > 0 Then
                    Dim frm As New DetalleActualizacionStock
                    frm.DataSource = stkUDErroresPrevios
                    frm.ShowDialog()
                    ReDim stkUDErroresPrevios(-1)
                End If
            End If
        End If
        mLotes.LoteCollection.Clear()
    End Sub

    Private Function ComprobarArticuloBodega(ByVal IDArticulo As String, ByVal IDAlmacen As String, ByVal Fecha As Date) As Boolean
        Dim bLimpio As Boolean = True
        If ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf BdgVino.EsArticuloVino, IDArticulo) Then
            Dim f As New Filter
            Dim OC As New BE.DataEngine
            f.Add("IDArticulo", FilterOperator.Equal, IDArticulo)
            f.Add("IDAlmacen", FilterOperator.Equal, IDAlmacen)
            f.Add("IDTipoMovimiento", FilterOperator.NotEqual, enumTipoMovimiento.tmCorreccion)
            If mTipoInventario = TipoInventario.PrimerMovimiento Then
                Dim f2 As New Filter(FilterUnionOperator.Or)
                Dim f3 As New Filter
                f3.Add("FechaDocumento", FilterOperator.Equal, Fecha)
                f3.Add("IDTipoMovimiento", FilterOperator.NotEqual, enumTipoMovimiento.tmInventario)
                f2.Add(f3)
                f2.Add("FechaDocumento", FilterOperator.GreaterThan, Fecha)
                f.Add(f2)
            ElseIf mTipoInventario = TipoInventario.UltimoMovimiento Then
                f.Add("FechaDocumento", FilterOperator.GreaterThan, Fecha)
            End If
            Dim dtMovimientos As DataTable = OC.Filter("tbHistoricoMovimiento", f, "TOP 1 1")
            If Not IsNothing(dtMovimientos) AndAlso dtMovimientos.Rows.Count > 0 Then
                bLimpio = False
            Else
                bLimpio = True
            End If
        End If
        Return bLimpio
    End Function

    Private Sub AccionInicializarInventariados()
        If ExpertisApp.GenerateMessage("Se va a actualizar el campo Inventariado. Esta acción pondrá todos los artículos de la Base de Datos como no inventariados. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            ExpertisApp.ExecuteTask(Of Object)(AddressOf ProcesoStocks.InicializarInventariados, Nothing)
            Me.RetrieveData()
            ExpertisApp.GenerateMessage("Proceso terminado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub GenerarFicheroExcel()
        If Me.Grid.RecordCount = 0 Then
            ExpertisApp.GenerateMessage("No hay datos para exportar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Me.Cursor = Cursors.WaitCursor

            Dim dtDatos As DataTable = Me.Grid.DataSource

            Dim appExcel As New Excel.Application
            Dim libroExcel As Excel.Workbook = appExcel.Workbooks.Add
            Dim hojaExcel As Excel.Worksheet = libroExcel.Worksheets(1)

            hojaExcel.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape

            hojaExcel.Range("A1").Value = EXCEL_COL_IDArticulo
            hojaExcel.Range("B1").Value = EXCEL_COL_Descripcion
            hojaExcel.Range("C1").Value = EXCEL_COL_IDAlmacen
            hojaExcel.Range("D1").Value = EXCEL_COL_StockFisico
            hojaExcel.Range("E1").Value = EXCEL_COL_Lote
            hojaExcel.Range("F1").Value = EXCEL_COL_Ubicacion
            hojaExcel.Range("G1").Value = EXCEL_COL_StockLoteUbicacion
            hojaExcel.Range("H1").Value = EXCEL_COL_StockLoteUbicacion2
            hojaExcel.Range("I1").Value = EXCEL_COL_FechaCaducidad
            hojaExcel.Range("J1").Value = EXCEL_COL_NuevoStockUD1
            hojaExcel.Range("K1").Value = EXCEL_COL_NuevoStockUD2
            hojaExcel.Range("L1").Value = EXCEL_COL_NuevaFechaCaducidad
            hojaExcel.Range("A1:L1").BorderAround(Excel.XlLineStyle.xlContinuous)

            Dim rowCount As Integer = 2
            hojaExcel.Range("A:A").NumberFormat = "@"
            hojaExcel.Range("A:A").ColumnWidth = 15
            hojaExcel.Range("B:B").NumberFormat = "@"
            hojaExcel.Range("B:B").ColumnWidth = 40
            hojaExcel.Range("C:C").NumberFormat = "@"
            hojaExcel.Range("E:E").NumberFormat = "@"
            hojaExcel.Range("F:F").NumberFormat = "@"
            For Each row As DataRow In dtDatos.Rows
                Dim initRow As Integer = rowCount
                If row("GestionStockPorLotes") Then
                    Dim fLotes As New Filter
                    fLotes.Add("IDArticulo", FilterOperator.Equal, row("IDArticulo"))
                    fLotes.Add("IDAlmacen", FilterOperator.Equal, row("IDAlmacen"))
                    fLotes.Add("StockFisico", FilterOperator.GreaterThan, 0)
                    Dim dtLotes As DataTable = New ArticuloAlmacenLote().Filter(fLotes)
                    If Not dtLotes Is Nothing AndAlso dtLotes.Rows.Count > 0 Then
                        For Each rowLote As DataRow In dtLotes.Rows
                            hojaExcel.Range("A" & rowCount).Value = row("IDArticulo")
                            hojaExcel.Range("B" & rowCount).Value = row("DescArticulo")
                            hojaExcel.Range("C" & rowCount).Value = row("IDAlmacen")
                            If rowCount = initRow Then hojaExcel.Range("D" & rowCount).Value = row("StockFisico")
                            hojaExcel.Range("E" & rowCount).Value = rowLote("Lote")
                            hojaExcel.Range("F" & rowCount).Value = rowLote("Ubicacion")
                            hojaExcel.Range("G" & rowCount).Value = rowLote("StockFisico")
                            hojaExcel.Range("H" & rowCount).Value = rowLote("StockFisico2")
                            hojaExcel.Range("I" & rowCount).Value = rowLote("FechaCaducidad")
                            rowCount += 1
                        Next
                    Else
                        hojaExcel.Range("A" & rowCount).Value = row("IDArticulo")
                        hojaExcel.Range("B" & rowCount).Value = row("DescArticulo")
                        hojaExcel.Range("C" & rowCount).Value = row("IDAlmacen")
                        hojaExcel.Range("D" & rowCount).Value = row("StockFisico")
                        rowCount += 1
                    End If
                Else
                    hojaExcel.Range("A" & rowCount).Value = row("IDArticulo")
                    hojaExcel.Range("B" & rowCount).Value = row("DescArticulo")
                    hojaExcel.Range("C" & rowCount).Value = row("IDAlmacen")
                    hojaExcel.Range("D" & rowCount).Value = row("StockFisico")
                    rowCount += 1
                End If
                hojaExcel.Range("A" & initRow & ":L" & rowCount - 1).BorderAround(Excel.XlLineStyle.xlContinuous)
            Next
            hojaExcel.Range("L1:L" & rowCount - 1).BorderAround(Excel.XlLineStyle.xlContinuous)

            appExcel.Visible = True
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ImportarFicheroExcel()
        Dim FileName As String
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            FileName = OpenFileDialog1.FileName
        Else
            FileName = String.Empty
        End If
        If Length(FileName) > 0 Then
            Me.Cursor = Cursors.WaitCursor

            Dim constr As String = String.Empty
            Dim FlInfo As New IO.FileInfo(FileName)
            If FlInfo.Extension = ".xls" Then
                constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & FileName & ";Extended Properties=Excel 8.0;"
            ElseIf FlInfo.Extension = ".xlsx" Then
                constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FileName & ";Extended Properties=Excel 12.0 Xml;"
            End If

            Dim Conn As New OleDbConnection(constr)
            Conn.Open()

            Dim dtHojasExcel As DataTable = Conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
            If Not dtHojasExcel Is Nothing AndAlso dtHojasExcel.Rows.Count > 0 Then
                Dim objCmdSelect As New OleDbCommand("SELECT * FROM [" & dtHojasExcel.Rows(0)("TABLE_NAME") & "]", Conn)

                Dim objAdapter As New OleDbDataAdapter
                Dim objDataSet As New DataSet
                objAdapter.SelectCommand = objCmdSelect
                objAdapter.Fill(objDataSet)

                Dim fArticulos As New Filter(FilterUnionOperator.Or)
                If Not objDataSet Is Nothing AndAlso Not objDataSet.Tables Is Nothing Then
                    dtDatosExcel = objDataSet.Tables(0)

                    Dim lstArticulos As List(Of String) = (From c In dtDatosExcel Where Not c.IsNull(EXCEL_COL_IDArticulo) _
                                                                    Select CStr(c(EXCEL_COL_IDArticulo)) Distinct).ToList()

                    For Each strArticulo As String In lstArticulos
                        If Length(strArticulo) > 0 Then
                            fArticulos.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, strArticulo))
                        End If
                    Next
                    mblnImportandoExcel = True
                    Conn.Close()
                    Me.Grid.UnCheckAllRecords()
                    Me.Execute(fArticulos)
                Else
                    ExpertisApp.GenerateMessage("El excel no tiene datos para importar.", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Inventarios_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, fwiArticulo.Text, FilterType.String)
        e.Filter.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, fwiAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, fwiTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, fwiFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, fwiSubfamilia.Text, FilterType.String)
        e.Filter.Add("FechaUltimoInventario", FilterOperator.GreaterThanOrEqual, FechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaUltimoInventario", FilterOperator.LessThanOrEqual, FechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("StockFisico", FilterOperator.GreaterThanOrEqual, StockDesde.Value, FilterType.Numeric)
        e.Filter.Add("StockFisico", FilterOperator.LessThanOrEqual, StockHasta.Value, FilterType.Numeric)

        If fwiInventariados.Value <> enumBoolean.Todos Then
            e.Filter.Add("Inventariado", FilterOperator.Equal, fwiInventariados.Value = enumBoolean.Si, FilterType.Boolean)
        End If
        If fwiArticuloPorLotes.Value <> enumBoolean.Todos Then
            e.Filter.Add("GestionStockPorLotes", FilterOperator.Equal, fwiArticuloPorLotes.Value = enumBoolean.Si, FilterType.Boolean)
        End If
        If fwiNSerie.Value <> enumBoolean.Todos Then
            e.Filter.Add("NSerieObligatorio", FilterOperator.Equal, fwiNSerie.Value = enumBoolean.Si, FilterType.Boolean)
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.Record Then
            Dim stock As Double = e.Row.Cells("StockFisico").Value
            If stock <= 0 Then
                e.Row.Cells("StockFisico").FormatStyle = Grid.FormatStyles("StockFisicoNegativo")
            End If
            If e.Row.Cells("Inventariado").Value Then
                e.Row.Cells("Inventariado").Image = Icons.Images(3)
            End If
        End If
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        If e.Column.Key = "Cantidad" Then
            Dim cantidad As Double
            If IsNumeric(Grid.GetValue("Cantidad")) Then
                cantidad = Grid.GetValue("Cantidad")
            End If
            If cantidad < 0 Then
                ExpertisApp.GenerateMessage("La cantidad de inventario no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Grid.GetValue("GestionStockPorLotes") Then
                    mLotes.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"))
                ElseIf Grid.GetValue("NSerieObligatorio") Then
                    Dim Fecha As Date
                    If Length(FechaInventario.Value) <= 0 Then Fecha = cnMinDate Else Fecha = FechaInventario.Value
                    If ComprobarArticuloNSerie(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"), Fecha) Then
                        mSeries.UsarColumnaSeleccion = True
                        mSeries.ModoAjusteInventario = True
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                        mSeries.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"))
                    Else : ExpertisApp.GenerateMessage("No se puede inventariar un artículo con gestión de números de serie que tenga movimientos posteriores a la fecha del inventario.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            If Grid.Col = Grid.Columns("Cantidad").Position Then
                Dim cantidad As Double
                If IsNumeric(Grid.GetValue("Cantidad")) Then
                    cantidad = Grid.GetValue("Cantidad")
                End If
                If cantidad < 0 Then
                    ExpertisApp.GenerateMessage("La cantidad de inventario no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If Grid.GetValue("GestionStockPorLotes") Then
                        mLotes.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"))
                    ElseIf Grid.GetValue("NSerieObligatorio") Then
                        Dim Fecha As Date
                        If Length(FechaInventario.Value) <= 0 Then Fecha = cnMinDate Else Fecha = FechaInventario.Value
                        If ComprobarArticuloNSerie(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"), Fecha) Then
                            mSeries.UsarColumnaSeleccion = True
                            mSeries.ModoAjusteInventario = True
                            mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                            mSeries.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"))
                        Else : ExpertisApp.GenerateMessage("No se puede inventariar un artículo con gestión de números de serie que tenga movimientos posteriores a la fecha del inventario.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Inventarios_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        fwiInventariados.Value = CInt(enumBoolean.Todos)
        fwiArticuloPorLotes.Value = CInt(enumBoolean.Todos)
        fwiNSerie.Value = CInt(enumBoolean.Todos)
    End Sub

    Private Sub fwiFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles fwiFamilia.SetPredefinedFilter
        If Len(fwiTipo.Text) Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, fwiTipo.Text))
        End If
    End Sub

    Private Sub fwiSubfamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles fwiSubfamilia.SetPredefinedFilter
        If Len(fwiTipo.Text) Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, fwiTipo.Text))
        End If
        If Len(fwiFamilia.Text) Then
            e.Filter.Add(New StringFilterItem("IDFamilia", FilterOperator.Equal, fwiFamilia.Text))
        End If
    End Sub

    Private Sub fwiSubfamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiSubfamilia.SelectionChanged
        If e.Selected.Rows.Count Then
            fwiTipo.Text = e.Selected.Rows(0)("IDTipo")
            fwiFamilia.Text = e.Selected.Rows(0)("IDFamilia")
            fwiSubfamilia.Text = e.Selected.Rows(0)("IDSubFamilia")
        End If
    End Sub

    Private Sub fwiFamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles fwiFamilia.SelectionChanged
        If e.Selected.Rows.Count Then
            fwiTipo.Text = e.Selected.Rows(0)("IDTipo")
        End If
    End Sub

    Private Sub fwiTipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiTipo.TextChanged
        fwiFamilia.Text = Nothing
        fwiSubfamilia.Text = Nothing
    End Sub

    Private Sub fwiFamilia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiFamilia.TextChanged
        fwiSubfamilia.Text = Nothing
    End Sub

    Private Sub Inventarios_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.UnChecked Then
            If e.RowData("GestionStockPorLotes") Then
                mLotes.LoteCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacen"))
            ElseIf e.RowData("NSerieObligatorio") Then
                mSeries.SerieCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacen"))
            End If
        End If

        If mblnStkDobleUnidad AndAlso e.CheckState = CheckStates.Checked AndAlso Length(Grid.GetValue("Cantidad2")) = 0 Then
            ValidarDobleUnidad(e.RowData, "Cantidad2")
            'ElseIf mblnStkDobleUnidad AndAlso e.CheckState = CheckStates.Checked AndAlso Length(Grid.GetValue("Cantidad2")) > 0 Then
            '    AplicarCambioSegundaUnidad(True, String.Empty)
        End If
    End Sub

    Private Function ValidarDobleUnidad(ByVal data As DataRow, ByVal Field2Ud As String, Optional ByVal Msg As Boolean = True) As Boolean
        ValidarDobleUnidad = True
        If data("GestionStock") AndAlso Not data("NSerieObligatorio") Then
            If data.Table.Columns.Contains("IDUdInterna2") AndAlso Length(data("IDUdInterna2")) > 0 Then
                If data("IDUdInterna") = data("IDUdInterna2") Then
                    '//Si tenemos la misma unidad interna, la cantidad será la misma
                    data(Field2Ud) = Nz(data("Cantidad"), 0)
                ElseIf data("IDUdInterna") <> data("IDUdInterna2") Then
                    '//Si la unidad interna es distinta, aplicaremos el Factor Correspondiente, is lo tenemos. 
                    Dim datFactor As New ArticuloUnidadAB.DatosFactorConversion(data("IDArticulo"), data("IDUDInterna"), data("IDUDInterna2"), False)
                    Dim Factor As Double = ExpertisApp.ExecuteTask(Of ArticuloUnidadAB.DatosFactorConversion, Double)(AddressOf ArticuloUnidadAB.FactorDeConversion, datFactor)
                    If Factor <> 0 Then
                        data(Field2Ud) = Nz(data("Cantidad"), 0) * Factor
                    End If
                End If
                If Nz(data(Field2Ud), 0) = 0 Then
                    If Msg Then ExpertisApp.GenerateMessage("Debe indicar la Cantidad de la Segunda Unidad Interna.")
                    ValidarDobleUnidad = False
                End If
            End If
        End If
    End Function

    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Try
            If e.Column.Key = "Cantidad" Then
                If Not IsNumeric(e.Value) Then
                    e.Value = e.InitialValue
                Else
                    If e.Value < 0 Then
                        e.Cancel = True
                        ExpertisApp.GenerateMessage("La cantidad de inventario no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        Dim articulo As String = Grid.GetValue("IDArticulo")
                        Dim almacen As String = Grid.GetValue("IDAlmacen")
                        If Grid.GetValue("GestionStockPorLotes") Then
                            If Not (mLotes.ShowDialog(articulo, almacen) = DialogResult.OK) Then
                                Dim desglose(-1) As StockData
                                desglose = mLotes.LoteCollection.GetStockData(articulo, almacen)
                                Dim CantDesglose As Decimal = 0
                                If desglose.Length > 0 Then
                                    For Each sd As StockData In desglose
                                        CantDesglose += sd.Cantidad
                                    Next
                                End If
                                e.Cancel = CantDesglose <> CDec(Nz(Grid.GetValue("Cantidad"), 0))
                            End If
                        ElseIf Grid.GetValue("NSerieObligatorio") Then
                            Dim Fecha As Date
                            If Length(FechaInventario.Value) <= 0 Then Fecha = cnMinDate Else Fecha = FechaInventario.Value
                            If ComprobarArticuloNSerie(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen"), Fecha) Then
                                mSeries.UsarColumnaSeleccion = True
                                mSeries.ModoAjusteInventario = True
                                mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                                If Not (mSeries.ShowDialog(articulo, almacen) = DialogResult.OK) Then
                                    Dim desglose(-1) As StockData
                                    desglose = mSeries.SerieCollection.GetStockData(articulo, almacen)
                                    Dim CantDesglose As Decimal = 0
                                    If desglose.Length > 0 Then
                                        For Each sd As StockData In desglose
                                            CantDesglose += sd.Cantidad
                                        Next
                                    End If
                                    e.Cancel = CantDesglose <> CDec(Nz(Grid.GetValue("Cantidad"), 0))
                                End If
                            Else : ExpertisApp.GenerateMessage("No se puede inventariar un artículo con gestión de números de serie que tenga movimientos posteriores a la fecha del inventario.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                e.Cancel = True
                            End If
                            'Else
                            'If mblnStkDobleUnidad Then
                            '    Grid.GetRow(Grid.Row).DataRow("Cantidad") = e.Value
                            '    ValidarDobleUnidad(CType(Grid.GetRow(Grid.Row).DataRow, DataRowView).Row, "Cantidad2")
                            '    Grid.Refetch()
                            'End If
                            End If
                    End If
                End If
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Try
            Dim c As GridEXColumn = Grid.Columns("Cantidad")
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

            Select Case e.Column.Key
                Case "Contabilizado"
                    e.Cancel = True
            End Select
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub

    Private Sub Grid_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.CellUpdated
        If e.Column.Key = "Cantidad" OrElse e.Column.Key = "Cantidad2" Then
            AplicarCambioSegundaUnidad(False, e.Column.Key)
        End If
    End Sub

    Private Sub AplicarCambioSegundaUnidad(ByVal Checking As Boolean, ByVal ColumnName As String)
        If mblnStkDobleUnidad AndAlso Grid.Value("GestionStock") AndAlso Not Grid.Value("NSerieObligatorio") Then
            If Grid.DataSource.Columns.Contains("IDUdInterna2") AndAlso Length(Grid.Value("IDUdInterna2")) > 0 Then
       
                If Length(Grid.Value("Cantidad2")) > 0 AndAlso (ColumnName = "Cantidad2") Then
                    If Not Checking Then
                        If Grid.Value("IDUdInterna") = Grid.Value("IDUdInterna2") Then
                            '//Si tenemos la misma unidad interna, la cantidad será la misma
                            Grid.Value("Cantidad2") = Grid.Value("Cantidad")
                        ElseIf Grid.Value("IDUdInterna") <> Grid.Value("IDUdInterna2") Then
                            '//Si la unidad interna es distinta, aplicaremos el Factor Correspondiente, si lo tenemos. 
                            Dim datFactor As New Articulo.DataFactorDobleUnidad(Grid.Value("IDArticulo"), (ColumnName = "Cantidad"), (ColumnName = "Cantidad2"), Grid.Value("IDUDInterna"))
                            Dim Factor As Double = ExpertisApp.ExecuteTask(Of Articulo.DataFactorDobleUnidad, Double)(AddressOf Articulo.FactorDobleUnidad, datFactor)
                            If Factor <> 0 Then
                                If datFactor.CambioIDUDInterna Then
                                    Grid.Value("Cantidad2") = Grid.Value("Cantidad") * Factor
                                ElseIf datFactor.CambioIDUDInterna2 Then
                                    Grid.Value("Cantidad") = Grid.Value("Cantidad2") * Factor
                                End If
                            Else
                                If (ColumnName <> "Cantidad2") Then Grid.Value("Cantidad2") = System.DBNull.Value
                            End If
                        End If
                        If Nz(Grid.Value("Cantidad2"), 0) = 0 AndAlso (Checking OrElse ColumnName = "Cantidad") Then
                            ExpertisApp.GenerateMessage("Debe indicar la Cantidad de la Segunda Unidad Interna.")
                        End If
                    End If
                ElseIf Length(Grid.Value("Cantidad2")) = 0 Then
                    If Grid.Value("IDUdInterna") = Grid.Value("IDUdInterna2") Then
                        '//Si tenemos la misma unidad interna, la cantidad será la misma
                        Grid.Value("Cantidad2") = Grid.Value("Cantidad")
                    ElseIf Grid.Value("IDUdInterna") <> Grid.Value("IDUdInterna2") Then
                        '//Si la unidad interna es distinta, aplicaremos el Factor Correspondiente, si lo tenemos. 
                        Dim datFactor As New Articulo.DataFactorDobleUnidad(Grid.Value("IDArticulo"), (ColumnName = "Cantidad"), (ColumnName = "Cantidad2"), Grid.Value("IDUDInterna"))
                        Dim Factor As Double = ExpertisApp.ExecuteTask(Of Articulo.DataFactorDobleUnidad, Double)(AddressOf Articulo.FactorDobleUnidad, datFactor)
                        If Factor <> 0 Then
                            If datFactor.CambioIDUDInterna Then
                                Grid.Value("Cantidad2") = Grid.Value("Cantidad") * Factor
                            ElseIf datFactor.CambioIDUDInterna2 Then
                                Grid.Value("Cantidad") = Grid.Value("Cantidad2") * Factor
                            End If
                        End If
                    End If
                    If Nz(Grid.Value("Cantidad2"), 0) = 0 AndAlso (Checking OrElse ColumnName = "Cantidad") Then
                        ExpertisApp.GenerateMessage("Debe indicar la Cantidad de la Segunda Unidad Interna.")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Inventarios_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles Me.QueryExecuted
        If mblnImportandoExcel Then
            Dim Errores(-1) As ClassErrors
            Me.Cursor = Cursors.WaitCursor
            For Each row As GridEXRow In Me.Grid.GetDataRows
                If row.RowType = RowType.Record Then

                    row.BeginEdit()
                    Dim IDArticulo As String = row.Cells("IDArticulo").Value
                    Dim IDAlmacen As String = row.Cells("IDAlmacen").Value
                    Dim drExcel() As DataRow = dtDatosExcel.Select(EXCEL_COL_IDArticulo & "=" & Quoted(IDArticulo) & " AND " & EXCEL_COL_IDAlmacen & "=" & Quoted(IDAlmacen))
                    If drExcel.Length > 0 Then

                        Dim SegundaUnidad As Boolean = False
                        Dim Factor As Double
                        If mblnStkDobleUnidad Then
                            SegundaUnidad = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, IDArticulo)
                            'Dim datFactor As New Articulo.DataFactorDobleUnidad(IDArticulo, True, False, row.Cells("IDUDInterna").Value)
                            'Factor = ExpertisApp.ExecuteTask(Of Articulo.DataFactorDobleUnidad, Double)(AddressOf Articulo.FactorDobleUnidad, datFactor)
                            If SegundaUnidad Then
                                Dim StDatos As New ArticuloUnidadAB.DatosFactorConversion
                                StDatos.IDArticulo = IDArticulo
                                StDatos.IDUdMedidaA = row.Cells("IDUDInterna").Value
                                StDatos.IDUdMedidaB = row.Cells("IDUDInterna2").Value
                                StDatos.UnoSiNoExiste = True
                                Factor = ExpertisApp.ExecuteTask(Of ArticuloUnidadAB.DatosFactorConversion, Double)(AddressOf ArticuloUnidadAB.FactorDeConversion, StDatos)
                            End If
                        End If

                        If row.Cells("GestionStockPorLotes").Value Then
                            Dim mLote As Lote = mLotes.LoadLote(IDArticulo, IDAlmacen)
                            Dim sumCantidad As Double = -1
                            Dim sumCantidad2 As Double = -1

                            For Each drLoteExcel As DataRow In drExcel
                                If Length(drLoteExcel(EXCEL_COL_NuevoStockUD1)) > 0 Then
                                    If drLoteExcel(EXCEL_COL_NuevoStockUD1) >= 0 Then
                                        If Length(drLoteExcel(EXCEL_COL_Lote)) > 0 AndAlso Length(drLoteExcel(EXCEL_COL_Ubicacion)) > 0 Then
                                            Dim drLote As DataRow
                                            Dim drLotes() As DataRow = mLote.DataTable.Select("Lote=" & Quoted(drLoteExcel(EXCEL_COL_Lote)) & " AND Ubicacion=" & Quoted(drLoteExcel(EXCEL_COL_Ubicacion)))
                                            If drLotes.Length > 0 Then
                                                drLote = drLotes(0)
                                                drLote("Cantidad") = drLoteExcel(EXCEL_COL_NuevoStockUD1)
                                                If SegundaUnidad Then
                                                    If Length(drLoteExcel(EXCEL_COL_NuevoStockUD2)) > 0 Then
                                                        drLote("Cantidad2") = drLoteExcel(EXCEL_COL_NuevoStockUD2)
                                                    Else
                                                        drLote("Cantidad2") = drLoteExcel(EXCEL_COL_NuevoStockUD2) * Factor
                                                    End If
                                                End If
                                                drLote("FechaCaducidad") = drLoteExcel(EXCEL_COL_NuevaFechaCaducidad)
                                            Else
                                                drLote = mLote.DataTable.NewRow
                                                drLote("IDArticulo") = IDArticulo
                                                drLote("IDAlmacen") = IDAlmacen
                                                drLote("Lote") = drLoteExcel(EXCEL_COL_Lote)
                                                drLote("Ubicacion") = drLoteExcel(EXCEL_COL_Ubicacion)
                                                drLote("Cantidad") = drLoteExcel(EXCEL_COL_NuevoStockUD1)
                                                drLote("StockFisico") = 0
                                                If SegundaUnidad Then
                                                    drLote("StockFisico2") = 0
                                                    If Length(drLoteExcel(EXCEL_COL_NuevoStockUD2)) > 0 Then
                                                        drLote("Cantidad2") = drLoteExcel(EXCEL_COL_NuevoStockUD2)
                                                    Else
                                                        drLote("Cantidad2") = drLoteExcel(EXCEL_COL_NuevoStockUD2) * Factor
                                                    End If
                                                End If
                                                drLote("FechaCaducidad") = drLoteExcel(EXCEL_COL_NuevaFechaCaducidad)
                                                mLote.DataTable.Rows.Add(drLote)
                                            End If

                                            If sumCantidad = -1 Then
                                                sumCantidad = drLoteExcel(EXCEL_COL_NuevoStockUD1)
                                            Else
                                                sumCantidad += drLoteExcel(EXCEL_COL_NuevoStockUD1)
                                            End If
                                            If sumCantidad2 = -1 Then
                                                sumCantidad2 = drLoteExcel(EXCEL_COL_NuevoStockUD2)
                                            Else
                                                sumCantidad2 += drLoteExcel(EXCEL_COL_NuevoStockUD2)
                                            End If

                                        Else
                                            ReDim Preserve Errores(Errores.Length)
                                            Errores(Errores.Length - 1) = New ClassErrors("Art:" & IDArticulo & " Alm:" & IDAlmacen, ExpertisApp.Traslate("El Artículo {0} lleva gestión por Lotes, pero no se han indicado el Lote y/o Ubicación  para el Almacén {1}.", Quoted(IDArticulo), Quoted(IDAlmacen)))
                                        End If
                                    Else
                                        ReDim Preserve Errores(Errores.Length)
                                        Errores(Errores.Length - 1) = New ClassErrors("Art:" & IDArticulo & " Alm:" & IDAlmacen, ExpertisApp.Traslate("El Artículo {0} lleva gestión por Lotes. No se pueden indicar lotes con stock negativo. Lote {1}.", Quoted(IDArticulo), Quoted(drLoteExcel(EXCEL_COL_Lote))))
                                    End If
                                End If
                            Next
                            mLote.DataTable.AcceptChanges()
                            If Not mLotes.LoteCollection.Item(IDArticulo, IDAlmacen) Is Nothing Then mLotes.LoteCollection.RemoveAt(IDArticulo, IDAlmacen)
                            mLotes.LoteCollection.Add(mLote, IDArticulo, IDAlmacen)
                            mLotes.LoteCollection.Item(IDArticulo, IDAlmacen).DataTable = mLote.DataTable
                            If sumCantidad >= 0 Then
                                row.Cells("Cantidad").Value = sumCantidad
                                If SegundaUnidad Then row.Cells("Cantidad2").Value = sumCantidad2
                                Me.CheckRecord(row)
                            End If
                        Else
                            If Length(drExcel(0)(EXCEL_COL_NuevoStockUD1)) > 0 Then
                                row.Cells("Cantidad").Value = drExcel(0)(EXCEL_COL_NuevoStockUD1)
                                If SegundaUnidad Then row.Cells("Cantidad2").Value = drExcel(0)(EXCEL_COL_NuevoStockUD2)
                                Me.CheckRecord(row)
                            End If
                        End If
                        row.EndEdit()
                    End If
                End If

            Next
            mblnImportandoExcel = False
            Me.Cursor = Cursors.Default

            If Not Errores Is Nothing AndAlso Errores.Length > 0 Then
                Dim frm As New CommonClasses.frmMostrarErrores
                frm.Errores = Errores
                frm.ShowDialog()
            End If
        End If


    End Sub

    Private Sub fwiArticulo_NotInList(ByVal sender As Object, ByVal e As Engine.UI.NotInListEventArgs) Handles fwiArticulo.NotInList
        e.Cancel = True
        e.Handled = True
        Dim DatArt As AlbaranVentaLinea.DataBuscarArt = ExpertisApp.ExecuteTask(Of String, AlbaranVentaLinea.DataBuscarArt)(AddressOf AlbaranVentaLinea.BuscarArticulo, e.Value)
        If Not DatArt Is Nothing AndAlso Length(DatArt.IDArticulo) > 0 Then
            Me.fwiArticulo.Value = DatArt.IDArticulo
            Me.fwiArticulo.Text = DatArt.IDArticulo
        End If
    End Sub

End Class
