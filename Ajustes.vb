Public Class Ajustes
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mblnInventarioPermanente As Boolean

    Private mblnStkDobleUnidad As Boolean
    Private mLotes As ERP.CommonClasses.LoteStockableUserDialog
    Friend WithEvents advIDArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialog

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        mLotes = New ERP.CommonClasses.LoteStockableUserDialog
        mLotes.Text = "AJUSTES"
        mLotes.DataSource = Grid
        mLotes.ProponerCantidades = True
        mLotes.AsignarStockFisicoCero = True

        mSeries = New ERP.CommonClasses.NSerieStockableUserDialog
        mSeries.Text = "AJUSTES"
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
    Friend WithEvents FechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents StockDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents StockHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ajustes))
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
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
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
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(784, 301)
        '
        'Grid
        '
        Me.Grid.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("Cantidad", "Stock", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, ""), New Solmicro.Expertis.Engine.UI.CheckField("Cantidad2", "Stock 2Ud.", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "")})
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.ImageList = Me.Icons
        Me.Grid.KeyField = "MarcaAuto"
        Me.Grid.PrimaryDataFields = "IDArticulo;IDAlmacen"
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = "IDArticulo;IDAlmacen"
        Me.Grid.Size = New System.Drawing.Size(784, 301)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vFrmCIAjuste"
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
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(217, 74)
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
        Me.lblfwiFUltimoInventario.Size = New System.Drawing.Size(80, 13)
        Me.lblfwiFUltimoInventario.TabIndex = 10
        Me.lblfwiFUltimoInventario.Tag = ""
        Me.lblfwiFUltimoInventario.Text = "F. Ult. Aj. >="
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
        Me.lblfwiArticulo.Location = New System.Drawing.Point(7, 27)
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
        Me.lblfwiFUltimoInventario2.Size = New System.Drawing.Size(80, 13)
        Me.lblfwiFUltimoInventario2.TabIndex = 12
        Me.lblfwiFUltimoInventario2.Tag = ""
        Me.lblfwiFUltimoInventario2.Text = "F. Ult. Aj. <="
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
        Me.fwiInventariados.Size = New System.Drawing.Size(80, 21)
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
        Me.lblArticuloPadre.Location = New System.Drawing.Point(7, 75)
        Me.lblArticuloPadre.Name = "lblArticuloPadre"
        Me.lblArticuloPadre.Size = New System.Drawing.Size(87, 13)
        Me.lblArticuloPadre.TabIndex = 31
        Me.lblArticuloPadre.Tag = ""
        Me.lblArticuloPadre.Text = "Artículo Padre"
        '
        'Ajustes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CheckFields = New Solmicro.Expertis.Engine.UI.CheckFields(New Solmicro.Expertis.Engine.UI.CheckField() {New Solmicro.Expertis.Engine.UI.CheckField("Cantidad", "Stock", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, ""), New Solmicro.Expertis.Engine.UI.CheckField("Cantidad2", "Stock 2Ud.", Solmicro.Expertis.Engine.UI.CheckFieldType.Numeric, "")})
        Me.ClientSize = New System.Drawing.Size(792, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "MarcaAuto"
        Me.Name = "Ajustes"
        Me.ShowInTaskbar = True
        Me.Text = "Ajustes"
        Me.UseCheck = True
        Me.ViewName = "vFrmCIAjuste"
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub Ajustes_CheckingRecord(ByVal sender As Object, ByVal e As Engine.UI.CheckingEventArgs) Handles Me.CheckingRecord
    '    If Length(Grid.Value("IDArticulo")) > 0 Then
    '        Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.Value("IDArticulo"))
    '        If SegundaUnidad Then
    '            Grid.Value("Cantidad2") = Grid.Value("StockFisico2")
    '        End If
    '    End If
    'End Sub

    Private Sub Ajustes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadEnums()
            LoadGridActions()
            LoadFormActions()
            SettingSegundaUnidad()
        End If

        'pend: lo siguiente no deberia tener que programarse
        StockDesde.Value = Nothing
        StockHasta.Value = Nothing
    End Sub


    Private Sub LoadERPData()
        mblnInventarioPermanente = New Parametro().GestionInventarioPermanente
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

    Private Sub LoadEnums()
        fwiInventariados.DataSource = New EnumData("enumBoolean")
        fwiArticuloPorLotes.DataSource = New EnumData("enumBoolean")
        fwiNSerie.DataSource = New EnumData("enumBoolean")

        fwiInventariados.Value = CInt(enumBoolean.Todos)
        fwiArticuloPorLotes.Value = CInt(enumBoolean.Todos)
        fwiNSerie.Value = CInt(enumBoolean.Todos)

        If mblnInventarioPermanente Then EnumData.PopulateValueList("enumContabilizado", Grid.Columns("Contabilizado"))
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Ver Articulo", AddressOf AccionGridVerArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
    End Sub

    Private Sub LoadFormActions()
        Me.FormActions.Add("Actualizar Stock", AddressOf AccionActualizarStock)
    End Sub



    Private Sub AccionGridVerArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub

    Private Sub AccionActualizarStock()
        If Me.CheckedRecordsCount = 0 Then
            ExpertisApp.GenerateMessage("No hay líneas seleccionadas.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim dt As DataTable = Me.CheckedRecords
            If Not IsNothing(dt) AndAlso dt.Rows.Count Then
                Dim FaltaSegundaUnidad As Boolean
                Dim LineasSeleccionadas As Integer = dt.Rows.Count
                Dim data(-1) As StockData
                Dim HayCantidadCero As Boolean
                Dim HayInventariados As Boolean
                Dim HayInventariadosEnMismaFecha As Boolean
                For Each selectedRow As DataRow In dt.Select(Nothing, "IDArticulo,IDAlmacen")
                    Dim cantidad As Double = Nz(selectedRow("Cantidad"), 0)
                    If Not HayCantidadCero Then
                        HayCantidadCero = (cantidad = 0)
                    End If
                    If Not HayInventariados Then
                        HayInventariados = selectedRow("Inventariado")
                    End If
                    If Length(selectedRow("FechaUltimoInventario")) > 0 AndAlso selectedRow("Inventariado") AndAlso Not HayInventariadosEnMismaFecha Then
                        If selectedRow("FechaUltimoInventario") = Today() Then HayInventariadosEnMismaFecha = True
                    End If
                    Dim desglose() As StockData = Nothing
                    If selectedRow("GestionStockPorLotes") Then
                        desglose = mLotes.LoteCollection.GetStockData(selectedRow("IDArticulo"), selectedRow("IDAlmacen"))
                    ElseIf selectedRow("NSerieObligatorio") Then
                        desglose = mSeries.SerieCollection.GetStockData(selectedRow("IDArticulo"), selectedRow("IDAlmacen"))
                    End If
                    If Not desglose Is Nothing Then
                        For Each sd As StockData In desglose
                            ReDim Preserve data(UBound(data) + 1)
                            data(UBound(data)) = sd
                        Next
                    Else

                        Dim SegundaUnidad As Boolean
                        If mblnStkDobleUnidad Then
                            SegundaUnidad = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, selectedRow("IDArticulo"))
                        End If

                        Dim stkData As New StockData
                        stkData.Articulo = selectedRow("IDArticulo")
                        stkData.Almacen = selectedRow("IDAlmacen")
                        stkData.Cantidad = cantidad
                        'ReDim Preserve data(UBound(data) + 1)
                        'data(UBound(data)) = stkData
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

                Next

                If data.Length = 0 Then
                    If FaltaSegundaUnidad Then
                        ExpertisApp.GenerateMessage("Se han seleccionado Artículos con Gestión de Stock con Unidad doble, la cuál no se ha especificado. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("No hay datos para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Dim Cancel As Boolean
                    If HayCantidadCero Then
                        Cancel = (ExpertisApp.GenerateMessage("Uno o varios de los artículos seleccionados se va a actualizar con stock cero.|¿Continuar con la actualización?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, vbNewLine) = DialogResult.Cancel)
                    End If

                    If HayInventariadosEnMismaFecha And Not Cancel Then
                        ExpertisApp.GenerateMessage("Uno o varios de los artículos seleccionados está inventariado en la misma fecha en la que se va a hacer el ajuste. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Cancel = True
                    End If

                    If HayInventariados And Not Cancel Then
                        Cancel = (ExpertisApp.GenerateMessage("Uno o varios de los artículos seleccionados ya está inventariado.|¿Desea continuar de todos modos?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, vbNewLine) = DialogResult.Cancel)
                    End If

                    If FaltaSegundaUnidad And Not Cancel Then
                        ExpertisApp.GenerateMessage("Se han seleccionado Artículos con Gestión de Stock con Unidad doble, la cuál no se ha especificado. Se cancelará el proceso.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Cancel = True
                    End If

                    If Not Cancel Then
                        Dim datAjte As New DataTratarStocks(data)
                        Dim updateData As StockUpdateData() = ExpertisApp.ExecuteTask(Of DataTratarStocks, StockUpdateData())(AddressOf ProcesoStocks.AjusteMasivo, datAjte)

                        Dim frm As New DetalleActualizacionStock
                        frm.DataSource = updateData
                        frm.ShowDialog()

                        DesmarcarLineasActualizadas(updateData)
                        Me.RetrieveData()
                        mSeries.SerieCollection.Clear()
                    End If
                End If

            End If
        End If

    End Sub

    Private Sub DesmarcarLineasActualizadas(ByVal updatedData As StockUpdateData())
        For Each data As StockUpdateData In updatedData
            If data.Estado = EstadoStock.Actualizado Or data.Estado = EstadoStock.SinGestion Then
                For Each row As GridEXRow In Grid.GetCheckedRows()
                    If row.Cells("IDArticulo").Value = data.StockData.Articulo And row.Cells("IDAlmacen").Value = data.StockData.Almacen Then
                        Grid.UnCheckRecord(row)
                    End If
                Next
            End If
        Next
    End Sub

    Protected Friend Sub Ajustes_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, fwiArticulo.Text, FilterType.String)
        e.Filter.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, fwiAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, fwiTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, fwiFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, fwiSubfamilia.Text, FilterType.String)
        e.Filter.Add("FechaUltimoAjuste", FilterOperator.GreaterThanOrEqual, FechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaUltimoAjuste", FilterOperator.LessThanOrEqual, FechaHasta.Value, FilterType.DateTime)
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
                    mSeries.UsarColumnaSeleccion = True
                    mSeries.ModoAjusteInventario = True
                    mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                    If mSeries.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen")) = DialogResult.OK Then
                        Grid.CheckRecord()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Grid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Grid.KeyDown
        If e.KeyCode = Keys.F4 And Not e.Shift Then
            Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.GetValue("IDArticulo"))
            If ((Not SegundaUnidad AndAlso Grid.Col = Grid.Columns("Cantidad").Position)) OrElse (SegundaUnidad AndAlso Grid.Col = Grid.Columns("Cantidad2").Position) Then
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
                        mSeries.UsarColumnaSeleccion = True
                        mSeries.ModoAjusteInventario = True
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                        If mSeries.ShowDialog(Grid.GetValue("IDArticulo"), Grid.GetValue("IDAlmacen")) = DialogResult.OK Then
                            Grid.CheckRecord()
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

    Private Sub Ajustes_RecordChecked(ByVal sender As Object, ByVal e As Engine.UI.CheckedEventArgs) Handles MyBase.RecordChecked
        If e.CheckState = CheckStates.UnChecked Then
            If e.RowData("GestionStockPorLotes") Then
                mLotes.LoteCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacen"))
            ElseIf e.RowData("NSerieObligatorio") Then
                mSeries.SerieCollection.RemoveAt(e.RowData("IDArticulo"), e.RowData("IDAlmacen"))
            End If
        End If
        If mblnStkDobleUnidad AndAlso e.CheckState = CheckStates.Checked AndAlso Length(Grid.GetValue("Cantidad2")) = 0 Then
            ValidarDobleUnidad(e.RowData, "Cantidad2")
            'ElseIf mblnStkDobleUnidad AndAlso e.CheckState = CheckStates.Checked AndAlso Length(Grid.GetValue("QInterna2")) > 0 Then
            '    AplicarCambioSegundaUnidad(True, String.Empty)
        End If
    End Sub

    Private Function ValidarDobleUnidad(ByVal data As DataRow, ByVal Field2Ud As String, Optional ByVal Msg As Boolean = True) As Boolean
        ValidarDobleUnidad = True
        If data("GestionStock") AndAlso Not data("GestionStockPorLotes") AndAlso Not data("NSerieObligatorio") Then
            If data.Table.Columns.Contains("IDUdInterna2") AndAlso Length(data("IDUdInterna2")) > 0 Then
                If data("IDUdInterna") = data("IDUdInterna2") Then
                    '//Si tenemos la misma unidad interna, la cantidad será la misma
                    data(Field2Ud) = data("Cantidad")
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

    Private Sub AplicarCambioSegundaUnidad(ByVal Checking As Boolean, ByVal ColumnName As String)
        If mblnStkDobleUnidad AndAlso Grid.Value("GestionStock") AndAlso Not Grid.Value("GestionStockPorLotes") AndAlso Not Grid.Value("NSerieObligatorio") Then
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
                        'End If
                    End If
                ElseIf Length(Grid.Value("Cantidad2")) = 0 Then
                    If Grid.Value("IDUdInterna") = Grid.Value("IDUdInterna2") Then
                        '//Si tenemos la misma unidad interna, la cantidad será la misma
                        Grid.Value("Cantidad2") = Grid.Value("Cantidad")
                    ElseIf Grid.Value("IDUdInterna") <> Grid.Value("IDUdInterna2") Then
                        '//Si la unidad interna es distinta, aplicaremos el Factor Correspondiente, si lo tenemos. 
                        'Dim datFactor As New ArticuloUnidadAB.DatosFactorConversion(Grid.Value("IDArticulo"), Grid.Value("IDUDInterna"), Grid.Value("IDUDInterna2"), False)
                        'Dim Factor As Double = ExpertisApp.ExecuteTask(Of ArticuloUnidadAB.DatosFactorConversion, Double)(AddressOf ArticuloUnidadAB.FactorDeConversion, datFactor)
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


    Private Sub Grid_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        Try
            Dim SegundaUnidad As Boolean = ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, Grid.GetValue("IDArticulo"))
            If (Not SegundaUnidad AndAlso e.Column.Key = "Cantidad") OrElse (SegundaUnidad AndAlso e.Column.Key = "Cantidad2") Then
                If Not IsNumeric(e.Value) Then
                    e.Value = e.InitialValue
                End If
                If e.Value < 0 Then
                    'Si se quisiera controlar stock negativo iria aqui el codigo.

                    e.Cancel = True
                    ExpertisApp.GenerateMessage("La cantidad de ajuste no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim articulo As String = Grid.GetValue("IDArticulo")
                    Dim almacen As String = Grid.GetValue("IDAlmacen")
                    If Grid.GetValue("GestionStockPorLotes") Then
                        e.Cancel = Not (mLotes.ShowDialog(articulo, almacen) = DialogResult.OK)
                    ElseIf Grid.GetValue("NSerieObligatorio") Then
                        mSeries.UsarColumnaSeleccion = True
                        mSeries.ModoAjusteInventario = True
                        mSeries.ModoRecuentoSalidas = [Shared].ModoRecuentoSalidas.Seleccionados
                        e.Cancel = Not (mSeries.ShowDialog(articulo, almacen) = DialogResult.OK)
                        Grid.CheckRecord()
                        'Else
                        '    If mblnStkDobleUnidad Then
                        '        Grid.GetRow(Grid.Row).DataRow("Cantidad") = e.Value
                        '        ValidarDobleUnidad(CType(Grid.GetRow(Grid.Row).DataRow, DataRowView).Row, "Cantidad2")
                        '        Grid.Refetch()
                        '    End If
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
   
End Class
