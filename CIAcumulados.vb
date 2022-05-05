Public Class CIAcumulados
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        StockDesde.Value = System.DBNull.Value
        StockHasta.Value = System.DBNull.Value
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
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFUltimoInventario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFUltimoInventario2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiInventariados As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMayorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticuloPorLotes As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMenorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiNSerie As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents fwiInventariados As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents StockDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents fwiArticuloPorLotes As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents StockHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Icons As System.Windows.Forms.ImageList
    Friend WithEvents advIdSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIdFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIdTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIdArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advIdAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiInventariados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIAcumulados))
        Dim fwiArticuloPorLotes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiNSerie_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFUltimoInventario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFUltimoInventario2 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiInventariados = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiStockMayorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiArticuloPorLotes = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiStockMenorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.advIdSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIdFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIdTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.advIdAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.advIdArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.fwiInventariados = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.StockDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.fwiArticuloPorLotes = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.fwiNSerie = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.StockHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.fwiInventariados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiArticuloPorLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fwiNSerie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
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
        Me.FilterPanel.Controls.Add(Me.advIdSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advIdFamilia)
        Me.FilterPanel.Controls.Add(Me.advIdTipo)
        Me.FilterPanel.Controls.Add(Me.FechaDesde)
        Me.FilterPanel.Controls.Add(Me.advIdAlmacen)
        Me.FilterPanel.Controls.Add(Me.advIdArticulo)
        Me.FilterPanel.Controls.Add(Me.FechaHasta)
        Me.FilterPanel.Controls.Add(Me.fwiInventariados)
        Me.FilterPanel.Controls.Add(Me.StockDesde)
        Me.FilterPanel.Controls.Add(Me.fwiArticuloPorLotes)
        Me.FilterPanel.Controls.Add(Me.fwiNSerie)
        Me.FilterPanel.Controls.Add(Me.StockHasta)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 281)
        Me.FilterPanel.Size = New System.Drawing.Size(661, 140)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(661, 281)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "MarcaAuto"
        Me.Grid.PrimaryDataFields = "IDArticulo;IDAlmacen"
        Me.Grid.Size = New System.Drawing.Size(661, 281)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vFrmCIAcumulados"
        '
        'CheckAll
        '
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'UncheckAll
        '
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.[True]
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
        Me.MainPanel.Size = New System.Drawing.Size(661, 421)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(661, 421)
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(11, 57)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 26
        Me.lblTipo.Text = "Tipo"
        '
        'lblfwiNSerie
        '
        Me.lblfwiNSerie.Location = New System.Drawing.Point(475, 109)
        Me.lblfwiNSerie.Name = "lblfwiNSerie"
        Me.lblfwiNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblfwiNSerie.TabIndex = 46
        Me.lblfwiNSerie.Tag = ""
        Me.lblfwiNSerie.Text = "Nº Serie"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(11, 109)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 30
        Me.lblfwiSubfamilia.Tag = ""
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(11, 83)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 28
        Me.lblfwiFamilia.Tag = ""
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiFUltimoInventario
        '
        Me.lblfwiFUltimoInventario.Location = New System.Drawing.Point(234, 83)
        Me.lblfwiFUltimoInventario.Name = "lblfwiFUltimoInventario"
        Me.lblfwiFUltimoInventario.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiFUltimoInventario.TabIndex = 36
        Me.lblfwiFUltimoInventario.Tag = ""
        Me.lblfwiFUltimoInventario.Text = "F. Ult. Inv. >="
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(234, 31)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 32
        Me.lblfwiAlmacen.Tag = ""
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(11, 31)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 24
        Me.lblfwiArticulo.Tag = ""
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiFUltimoInventario2
        '
        Me.lblfwiFUltimoInventario2.Location = New System.Drawing.Point(234, 109)
        Me.lblfwiFUltimoInventario2.Name = "lblfwiFUltimoInventario2"
        Me.lblfwiFUltimoInventario2.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiFUltimoInventario2.TabIndex = 38
        Me.lblfwiFUltimoInventario2.Tag = ""
        Me.lblfwiFUltimoInventario2.Text = "F. Ult. Inv. <="
        '
        'lblfwiInventariados
        '
        Me.lblfwiInventariados.Location = New System.Drawing.Point(234, 57)
        Me.lblfwiInventariados.Name = "lblfwiInventariados"
        Me.lblfwiInventariados.Size = New System.Drawing.Size(86, 13)
        Me.lblfwiInventariados.TabIndex = 34
        Me.lblfwiInventariados.Tag = ""
        Me.lblfwiInventariados.Text = "Inventariados"
        '
        'lblfwiStockMayorQue
        '
        Me.lblfwiStockMayorQue.Location = New System.Drawing.Point(475, 31)
        Me.lblfwiStockMayorQue.Name = "lblfwiStockMayorQue"
        Me.lblfwiStockMayorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMayorQue.TabIndex = 40
        Me.lblfwiStockMayorQue.Tag = ""
        Me.lblfwiStockMayorQue.Text = "Stock >="
        '
        'lblfwiArticuloPorLotes
        '
        Me.lblfwiArticuloPorLotes.Location = New System.Drawing.Point(475, 83)
        Me.lblfwiArticuloPorLotes.Name = "lblfwiArticuloPorLotes"
        Me.lblfwiArticuloPorLotes.Size = New System.Drawing.Size(37, 13)
        Me.lblfwiArticuloPorLotes.TabIndex = 44
        Me.lblfwiArticuloPorLotes.Tag = ""
        Me.lblfwiArticuloPorLotes.Text = "Lotes"
        '
        'lblfwiStockMenorQue
        '
        Me.lblfwiStockMenorQue.Location = New System.Drawing.Point(475, 57)
        Me.lblfwiStockMenorQue.Name = "lblfwiStockMenorQue"
        Me.lblfwiStockMenorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMenorQue.TabIndex = 42
        Me.lblfwiStockMenorQue.Tag = ""
        Me.lblfwiStockMenorQue.Text = "Stock <="
        '
        'advIdSubfamilia
        '
        Me.advIdSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIdSubfamilia.EntityName = "Subfamilia"
        Me.advIdSubfamilia.Location = New System.Drawing.Point(82, 105)
        Me.advIdSubfamilia.Name = "advIdSubfamilia"
        Me.advIdSubfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.advIdSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advIdSubfamilia.Size = New System.Drawing.Size(110, 23)
        Me.advIdSubfamilia.TabIndex = 3
        Me.advIdSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'advIdFamilia
        '
        Me.advIdFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advIdFamilia.EntityName = "Familia"
        Me.advIdFamilia.Location = New System.Drawing.Point(82, 79)
        Me.advIdFamilia.Name = "advIdFamilia"
        Me.advIdFamilia.PrimaryDataFields = "IDFamilia"
        Me.advIdFamilia.SecondaryDataFields = "IDFamilia"
        Me.advIdFamilia.Size = New System.Drawing.Size(110, 23)
        Me.advIdFamilia.TabIndex = 2
        Me.advIdFamilia.ViewName = "tbMaestroFamilia"
        '
        'advIdTipo
        '
        Me.advIdTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advIdTipo.EntityName = "TipoArticulo"
        Me.advIdTipo.Location = New System.Drawing.Point(82, 53)
        Me.advIdTipo.Name = "advIdTipo"
        Me.advIdTipo.PrimaryDataFields = "IDTipo"
        Me.advIdTipo.SecondaryDataFields = "IDTipo"
        Me.advIdTipo.Size = New System.Drawing.Size(110, 23)
        Me.advIdTipo.TabIndex = 1
        Me.advIdTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'FechaDesde
        '
        Me.FechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDesde.Location = New System.Drawing.Point(329, 81)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(104, 21)
        Me.FechaDesde.TabIndex = 6
        '
        'advIdAlmacen
        '
        Me.advIdAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIdAlmacen.EntityName = "Almacen"
        Me.advIdAlmacen.Location = New System.Drawing.Point(329, 27)
        Me.advIdAlmacen.Name = "advIdAlmacen"
        Me.advIdAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advIdAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIdAlmacen.Size = New System.Drawing.Size(104, 23)
        Me.advIdAlmacen.TabIndex = 4
        Me.advIdAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'advIdArticulo
        '
        Me.advIdArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIdArticulo.EntityName = "Articulo"
        Me.advIdArticulo.Location = New System.Drawing.Point(82, 27)
        Me.advIdArticulo.Name = "advIdArticulo"
        Me.advIdArticulo.PrimaryDataFields = "IDArticulo"
        Me.advIdArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIdArticulo.Size = New System.Drawing.Size(110, 23)
        Me.advIdArticulo.TabIndex = 0
        Me.advIdArticulo.ViewName = "tbMaestroArticulo"
        '
        'FechaHasta
        '
        Me.FechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaHasta.Location = New System.Drawing.Point(329, 107)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(104, 21)
        Me.FechaHasta.TabIndex = 7
        '
        'fwiInventariados
        '
        fwiInventariados_DesignTimeLayout.LayoutString = resources.GetString("fwiInventariados_DesignTimeLayout.LayoutString")
        Me.fwiInventariados.DesignTimeLayout = fwiInventariados_DesignTimeLayout
        Me.fwiInventariados.DisabledBackColor = System.Drawing.Color.White
        Me.fwiInventariados.Location = New System.Drawing.Point(329, 55)
        Me.fwiInventariados.Name = "fwiInventariados"
        Me.fwiInventariados.SelectedIndex = -1
        Me.fwiInventariados.SelectedItem = Nothing
        Me.fwiInventariados.Size = New System.Drawing.Size(104, 21)
        Me.fwiInventariados.TabIndex = 5
        '
        'StockDesde
        '
        Me.StockDesde.DisabledBackColor = System.Drawing.Color.White
        Me.StockDesde.Location = New System.Drawing.Point(540, 29)
        Me.StockDesde.Name = "StockDesde"
        Me.StockDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.StockDesde.Size = New System.Drawing.Size(106, 21)
        Me.StockDesde.TabIndex = 8
        '
        'fwiArticuloPorLotes
        '
        fwiArticuloPorLotes_DesignTimeLayout.LayoutString = resources.GetString("fwiArticuloPorLotes_DesignTimeLayout.LayoutString")
        Me.fwiArticuloPorLotes.DesignTimeLayout = fwiArticuloPorLotes_DesignTimeLayout
        Me.fwiArticuloPorLotes.DisabledBackColor = System.Drawing.Color.White
        Me.fwiArticuloPorLotes.Location = New System.Drawing.Point(540, 81)
        Me.fwiArticuloPorLotes.Name = "fwiArticuloPorLotes"
        Me.fwiArticuloPorLotes.SelectedIndex = -1
        Me.fwiArticuloPorLotes.SelectedItem = Nothing
        Me.fwiArticuloPorLotes.Size = New System.Drawing.Size(106, 21)
        Me.fwiArticuloPorLotes.TabIndex = 10
        '
        'fwiNSerie
        '
        fwiNSerie_DesignTimeLayout.LayoutString = resources.GetString("fwiNSerie_DesignTimeLayout.LayoutString")
        Me.fwiNSerie.DesignTimeLayout = fwiNSerie_DesignTimeLayout
        Me.fwiNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.fwiNSerie.Location = New System.Drawing.Point(540, 107)
        Me.fwiNSerie.Name = "fwiNSerie"
        Me.fwiNSerie.SelectedIndex = -1
        Me.fwiNSerie.SelectedItem = Nothing
        Me.fwiNSerie.Size = New System.Drawing.Size(106, 21)
        Me.fwiNSerie.TabIndex = 11
        '
        'StockHasta
        '
        Me.StockHasta.DisabledBackColor = System.Drawing.Color.White
        Me.StockHasta.Location = New System.Drawing.Point(540, 55)
        Me.StockHasta.Name = "StockHasta"
        Me.StockHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.StockHasta.Size = New System.Drawing.Size(106, 21)
        Me.StockHasta.TabIndex = 9
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
        'CIAcumulados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(669, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "MarcaAuto"
        Me.Name = "CIAcumulados"
        Me.Text = "Actualización del Acumulado"
        Me.UseCheck = True
        Me.ViewName = "vFrmCIAcumulados"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.fwiInventariados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiArticuloPorLotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fwiNSerie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mblnStkDobleUnidad As Boolean

#Region "Atributos"

    Private Enum LeerGridMensajes
        Ok = 0
        FechasVacias = 1
    End Enum

#End Region

#Region "Acciones"

    'Private Sub ActualizarAcumulados()
    '    Dim dtMarcados As DataTable
    '    Dim Stock As New Stock
    '    Dim blnActualizar As Boolean
    '    If length(cbOperacion.Value) = 0 Then
    '        ExpertisApp.GenerateMessage("Debe elegir un tipo de operacion.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)
    '        Exit Sub
    '    Else
    '        If Grid.CheckedRecordsCount > 0 Then
    '            dtMarcados = Me.CheckedRecords
    '            blnActualizar = TratarMensajes(LeerGrid(dtMarcados))
    '            If blnActualizar Then
    '                Me.Cursor = Cursors.WaitCursor
    '                '''Stock.RecalcularAcumulado(dtMarcados, cbOperacion.Value)
    '                Me.Cursor = Cursors.Default
    '                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title) 'Proceso finalizado correctamente
    '                QuitarMarcas()
    '            Else
    '                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information, ExpertisApp.Title)  'Proceso cancelado
    '            End If
    '        Else
    '            ExpertisApp.GenerateMessage("No se han seleccionado líneas.", MessageBoxButtons.OK, MessageBoxIcon.Error, ExpertisApp.Title) 'No se han seleccionado líneas."
    '        End If
    '    End If
    'End Sub

#End Region

#Region "Respuesta a eventos"

#Region "Respuesta a eventos: Formulario"

    Private Sub CIAcumulados_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advIdArticulo.Value, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advIdTipo.Value, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advIdFamilia.Value, FilterType.String)
        e.Filter.Add("IDSubFamilia", FilterOperator.Equal, advIdSubfamilia.Value, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIdAlmacen.Text, FilterType.String)
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

    Private Sub CIAcumulados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadToolbarActions()
            LoadDiseño()
            SettingDobleUnidad()
            'LoadEnums()
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad

        If Me.Grid.Columns.Contains("IDUDInterna2") Then
            Me.Grid.Columns("IDUDInterna2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("IDUDInterna2").Position = Me.Grid.Columns("IDUDInterna").Position + 1
        End If

        If Me.Grid.Columns.Contains("StockFisico2") Then
            Me.Grid.Columns("StockFisico2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("StockFisico2").Position = Me.Grid.Columns("StockFisico").Position + 1
        End If
    End Sub

    'Private Sub CIAcumulados_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
    '    cbOperacion.Value = Nothing
    '    fwiInventariados.Value = CInt(enumBoolean.Todos)
    '    fwiArticuloPorLotes.Value = CInt(enumBoolean.Todos)
    '    fwiNSerie.Value = CInt(enumBoolean.Todos)
    'End Sub

#End Region

#Region "Respuesta a eventos: Busquedas Avanzadas"

    Private Sub advIDFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIdFamilia.SetPredefinedFilter
        If Length(advIdTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, advIdTipo.Text, FilterType.String)
        End If
    End Sub

    Private Sub advIdSubFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIdSubfamilia.SetPredefinedFilter
        If Length(advIdTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, advIdTipo.Text, FilterType.String)
        End If
        If Length(advIdFamilia.Text) > 0 Then
            e.Filter.Add("IDFamilia", FilterOperator.Equal, advIdFamilia.Text, FilterType.String)
        End If
    End Sub

    Private Sub advIdFamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIdFamilia.SelectionChanged
        If e.Selected.Rows.Count Then
            advIdTipo.Text = e.Selected.Rows(0)("IDTipo")
        End If
    End Sub

    Private Sub advIdSubfamilia_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advIdSubfamilia.SelectionChanged
        If e.Selected.Rows.Count Then
            advIdTipo.Text = e.Selected.Rows(0)("IDTipo")
            advIdFamilia.Text = e.Selected.Rows(0)("IDFamilia")
        End If
    End Sub

    Private Sub advIdTipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIdTipo.TextChanged
        advIdFamilia.Text = Nothing
        advIdSubfamilia.Text = Nothing
    End Sub

    Private Sub advIdFamilia_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles advIdFamilia.TextChanged
        advIdSubfamilia.Text = Nothing
    End Sub
#End Region

#End Region

#Region "Grid"

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

#End Region

#Region "Procedimientos y funciones de ayuda"

    Private Sub LoadToolbarActions()
        'Me.FormActions.Add("Actualizar el Acumulado", New ActionProcedure(AddressOf ActualizarAcumulados))
    End Sub

    Private Sub LoadDiseño()
        Me.Grid.FrozenColumns = 3
    End Sub

    Private Function TratarMensajes(ByVal TipoMensaje As LeerGridMensajes) As Boolean
        Dim strMessage As String = ""
        Select Case TipoMensaje
            Case LeerGridMensajes.FechasVacias
                strMessage = "Hay líneas que no tienen Fecha Último Inventario. Estas líneas no serán incluídas en el proceso de actualización. ¿Desea continuar?"
            Case LeerGridMensajes.Ok
                strMessage = "Se va a proceder a la actualización de los artículos seleccionados. ¿Desea continuar?."
        End Select
        Return ExpertisApp.GenerateMessage(strMessage, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Private Sub QuitarMarcas()
        Me.UnCheckAllRecords()
        Me.DeleteServerChecks()
        Me.Execute()
    End Sub

    'Private Function LeerGrid(ByVal dt As DataTable) As LeerGridMensajes
    '    'If cbOperacion.Value = enumRecalcularAcumulado.RecalcularAcumuladoDesdeUltimoInventario Then
    '    '    For Each dr As DataRow In dt.Select
    '    '        If IsDBNull(dr("FechaUltimoInventario")) Then 'OrElse dr("Inventariado") = 0 Then
    '    '            Return (LeerGridMensajes.FechasVacias)
    '    '        End If
    '    '    Next
    '    'End If
    '    'Return LeerGridMensajes.Ok
    'End Function

    'Private Sub LoadEnums()
    '    Me.cbOperacion.DataSource = New EnumData("enumRecalcularAcumulado")

    '    fwiInventariados.DataSource = New EnumData("enumBoolean")
    '    fwiArticuloPorLotes.DataSource = New EnumData("enumBoolean")
    '    fwiNSerie.DataSource = New EnumData("enumBoolean")

    '    fwiInventariados.Value = CInt(enumBoolean.Todos)
    '    fwiArticuloPorLotes.Value = CInt(enumBoolean.Todos)
    '    fwiNSerie.Value = CInt(enumBoolean.Todos)
    'End Sub

#End Region

End Class
