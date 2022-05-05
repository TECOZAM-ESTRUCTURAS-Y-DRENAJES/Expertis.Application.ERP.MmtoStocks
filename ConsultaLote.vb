Public Class ConsultaLote
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.ExecuteActions.Visible = Janus.Windows.UI.InheritableBoolean.False
        'Me.Export.Visible = Janus.Windows.UI.InheritableBoolean.False

        Grid.AllowEdit = InheritableBoolean.True
        ntxStockDesde.Value = DBNull.Value
        ntxStockHasta.Value = DBNull.Value
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
    Friend WithEvents lblfwiBloqueados As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiUbicacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboBloqueados As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents ntxStockDesde As Solmicro.Expertis.Engine.UI.NumericTextBox
    Public WithEvents ntxStockHasta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents advLote As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advUbicacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Icons As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboBloqueados_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaLote))
        Me.cboBloqueados = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblfwiBloqueados = New Solmicro.Expertis.Engine.UI.Label
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.ntxStockDesde = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiStockDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.ntxStockHasta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblfwiStockHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.advLote = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiLote = New Solmicro.Expertis.Engine.UI.Label
        Me.advUbicacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiUbicacion = New Solmicro.Expertis.Engine.UI.Label
        Me.Icons = New System.Windows.Forms.ImageList(Me.components)
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cboBloqueados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblfwiBloqueados)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipo)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiLote)
        Me.FilterPanel.Controls.Add(Me.lblfwiUbicacion)
        Me.FilterPanel.Controls.Add(Me.cboBloqueados)
        Me.FilterPanel.Controls.Add(Me.advArticulo)
        Me.FilterPanel.Controls.Add(Me.advTipo)
        Me.FilterPanel.Controls.Add(Me.advFamilia)
        Me.FilterPanel.Controls.Add(Me.advAlmacen)
        Me.FilterPanel.Controls.Add(Me.ntxStockDesde)
        Me.FilterPanel.Controls.Add(Me.ntxStockHasta)
        Me.FilterPanel.Controls.Add(Me.advLote)
        Me.FilterPanel.Controls.Add(Me.advUbicacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 317)
        Me.FilterPanel.Size = New System.Drawing.Size(704, 104)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(704, 317)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloAlmacenLote"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.HideColumnsWhenGrouped = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.Hierarchical = True
        Me.Grid.ImageList = Me.Icons
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(704, 317)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmCILote"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
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
        Me.Toolbar.Size = New System.Drawing.Size(316, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(704, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(704, 421)
        '
        'cboBloqueados
        '
        cboBloqueados_DesignTimeLayout.LayoutString = resources.GetString("cboBloqueados_DesignTimeLayout.LayoutString")
        Me.cboBloqueados.DesignTimeLayout = cboBloqueados_DesignTimeLayout
        Me.cboBloqueados.DisabledBackColor = System.Drawing.Color.White
        Me.cboBloqueados.Location = New System.Drawing.Point(616, 72)
        Me.cboBloqueados.Name = "cboBloqueados"
        Me.cboBloqueados.SelectedIndex = -1
        Me.cboBloqueados.SelectedItem = Nothing
        Me.cboBloqueados.Size = New System.Drawing.Size(80, 21)
        Me.cboBloqueados.TabIndex = 17
        '
        'lblfwiBloqueados
        '
        Me.lblfwiBloqueados.Location = New System.Drawing.Point(552, 75)
        Me.lblfwiBloqueados.Name = "lblfwiBloqueados"
        Me.lblfwiBloqueados.Size = New System.Drawing.Size(36, 13)
        Me.lblfwiBloqueados.TabIndex = 16
        Me.lblfwiBloqueados.Tag = "IdRec=13072;"
        Me.lblfwiBloqueados.Text = "Bloq."
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(64, 24)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(112, 23)
        Me.advArticulo.TabIndex = 1
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(7, 24)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 0
        Me.lblfwiArticulo.Tag = "IdRec=4377;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'advTipo
        '
        Me.advTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advTipo.EntityName = "TipoArticulo"
        Me.advTipo.Location = New System.Drawing.Point(240, 24)
        Me.advTipo.Name = "advTipo"
        Me.advTipo.PrimaryDataFields = "IDTipo"
        Me.advTipo.SecondaryDataFields = "IDTipo"
        Me.advTipo.Size = New System.Drawing.Size(112, 23)
        Me.advTipo.TabIndex = 5
        Me.advTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblfwiTipo
        '
        Me.lblfwiTipo.Location = New System.Drawing.Point(184, 24)
        Me.lblfwiTipo.Name = "lblfwiTipo"
        Me.lblfwiTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipo.TabIndex = 4
        Me.lblfwiTipo.Tag = "IdRec=4456;"
        Me.lblfwiTipo.Text = "Tipo"
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(240, 48)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.PrimaryDataFields = "IDFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(112, 23)
        Me.advFamilia.TabIndex = 7
        Me.advFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(184, 50)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 6
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'advAlmacen
        '
        Me.advAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advAlmacen.EntityName = "Almacen"
        Me.advAlmacen.Location = New System.Drawing.Point(64, 48)
        Me.advAlmacen.Name = "advAlmacen"
        Me.advAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advAlmacen.Size = New System.Drawing.Size(112, 23)
        Me.advAlmacen.TabIndex = 3
        Me.advAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(7, 50)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 2
        Me.lblfwiAlmacen.Tag = "IdRec=4390;"
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'ntxStockDesde
        '
        Me.ntxStockDesde.DisabledBackColor = System.Drawing.Color.White
        Me.ntxStockDesde.Location = New System.Drawing.Point(616, 24)
        Me.ntxStockDesde.Name = "ntxStockDesde"
        Me.ntxStockDesde.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntxStockDesde.Size = New System.Drawing.Size(80, 21)
        Me.ntxStockDesde.TabIndex = 13
        '
        'lblfwiStockDesde
        '
        Me.lblfwiStockDesde.Location = New System.Drawing.Point(552, 24)
        Me.lblfwiStockDesde.Name = "lblfwiStockDesde"
        Me.lblfwiStockDesde.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockDesde.TabIndex = 12
        Me.lblfwiStockDesde.Tag = "IdRec=5268;"
        Me.lblfwiStockDesde.Text = "Stock >="
        '
        'ntxStockHasta
        '
        Me.ntxStockHasta.DisabledBackColor = System.Drawing.Color.White
        Me.ntxStockHasta.Location = New System.Drawing.Point(616, 48)
        Me.ntxStockHasta.Name = "ntxStockHasta"
        Me.ntxStockHasta.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntxStockHasta.Size = New System.Drawing.Size(80, 21)
        Me.ntxStockHasta.TabIndex = 15
        '
        'lblfwiStockHasta
        '
        Me.lblfwiStockHasta.Location = New System.Drawing.Point(552, 50)
        Me.lblfwiStockHasta.Name = "lblfwiStockHasta"
        Me.lblfwiStockHasta.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockHasta.TabIndex = 14
        Me.lblfwiStockHasta.Tag = "IdRec=7098;"
        Me.lblfwiStockHasta.Text = "Stock <="
        '
        'advLote
        '
        Me.advLote.DisabledBackColor = System.Drawing.Color.White
        Me.advLote.EntityName = "ArticuloAlmacenLote"
        Me.advLote.Location = New System.Drawing.Point(424, 24)
        Me.advLote.Name = "advLote"
        Me.advLote.PrimaryDataFields = "Lote"
        Me.advLote.SecondaryDataFields = "Lote"
        Me.advLote.Size = New System.Drawing.Size(112, 23)
        Me.advLote.TabIndex = 9
        Me.advLote.ViewName = "tbArticuloAlmacenLote"
        '
        'lblfwiLote
        '
        Me.lblfwiLote.Location = New System.Drawing.Point(360, 24)
        Me.lblfwiLote.Name = "lblfwiLote"
        Me.lblfwiLote.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiLote.TabIndex = 8
        Me.lblfwiLote.Tag = "IdRec=5968;"
        Me.lblfwiLote.Text = "Lote"
        '
        'advUbicacion
        '
        Me.advUbicacion.DisabledBackColor = System.Drawing.Color.White
        Me.advUbicacion.EntityName = "ArticuloAlmacenLote"
        Me.advUbicacion.Location = New System.Drawing.Point(424, 48)
        Me.advUbicacion.Name = "advUbicacion"
        Me.advUbicacion.PrimaryDataFields = "Ubicacion"
        Me.advUbicacion.SecondaryDataFields = "Ubicacion"
        Me.advUbicacion.Size = New System.Drawing.Size(112, 23)
        Me.advUbicacion.TabIndex = 11
        Me.advUbicacion.ViewName = "tbArticuloAlmacenLote"
        '
        'lblfwiUbicacion
        '
        Me.lblfwiUbicacion.Location = New System.Drawing.Point(360, 50)
        Me.lblfwiUbicacion.Name = "lblfwiUbicacion"
        Me.lblfwiUbicacion.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiUbicacion.TabIndex = 10
        Me.lblfwiUbicacion.Tag = "IdRec=7240;"
        Me.lblfwiUbicacion.Text = "Ubicación"
        '
        'Icons
        '
        Me.Icons.ImageStream = CType(resources.GetObject("Icons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Icons.TransparentColor = System.Drawing.Color.Transparent
        Me.Icons.Images.SetKeyName(0, "")
        Me.Icons.Images.SetKeyName(1, "")
        Me.Icons.Images.SetKeyName(2, "")
        '
        'ConsultaLote
        '
        Me.AllowUpdate = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 509)
        Me.EntityName = "ArticuloAlmacenLote"
        Me.KeyField = ""
        Me.Name = "ConsultaLote"
        Me.ViewName = "vFrmCILote"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cboBloqueados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRARTICULO As String = "Abrir Artículo"

    Protected Friend Sub ConsultaLote_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
        e.Filter.Add("Lote", FilterOperator.Equal, advLote.Text, FilterType.String)
        e.Filter.Add("Ubicacion", FilterOperator.Equal, advUbicacion.Text, FilterType.String)
        e.Filter.Add("StockFisico", FilterOperator.GreaterThanOrEqual, ntxStockDesde.Value, FilterType.Numeric)
        e.Filter.Add("StockFisico", FilterOperator.LessThanOrEqual, ntxStockHasta.Value, FilterType.Numeric)
        If cboBloqueados.Value <> enumBoolean.Todos Then
            e.Filter.Add("Bloqueado", FilterOperator.Equal, cboBloqueados.Value = enumBoolean.Si, FilterType.Boolean)
        End If
    End Sub

    Private Sub fwiLote_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advLote.SetPredefinedFilter
        If Len(advArticulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, advArticulo.Text))
        End If
        If Len(advAlmacen.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, advAlmacen.Text))
        End If
    End Sub

    Private Sub fwiUbicacion_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advUbicacion.SetPredefinedFilter
        If Len(advArticulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, advArticulo.Text))
        End If
        If Len(advAlmacen.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, advAlmacen.Text))
        End If
        If Len(advLote.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("Lote", FilterOperator.Equal, advLote.Text))
        End If
    End Sub

    Private Sub fwiFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles advFamilia.SetPredefinedFilter
        If Len(advTipo.Text) Then
            e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, advTipo.Text))
        End If
    End Sub

    Private Sub ConsultaLote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadFormActions()
            LoadEnums()
            SettingDobleUnidad()
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        Dim p As New Parametro
        If Me.Grid.Columns.Contains("StockFisico2") Then Me.Grid.Columns("StockFisico2").Visible = p.GestionDobleUnidad
    End Sub

    Private Sub LoadEnums()
        cboBloqueados.DataSource = New EnumData("enumBoolean")
        cboBloqueados.Value = CInt(enumBoolean.Todos)
        advArticulo.PredefinedFilter = New BooleanFilterItem("GestionStockPorLotes", True)
    End Sub

    Private Sub LoadFormActions()
        Grid.Actions.Add(cnABRIRARTICULO, AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
    End Sub

    Private Sub CargarMantenimientoArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub


    Private Sub ConsultaLote_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        cboBloqueados.Value = CInt(enumBoolean.Todos)
    End Sub

    Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
        Dim hit As GridArea
        With Grid
            hit = .HitTest()
            If hit = GridArea.Cell Then
                Dim p As Point
                p = Grid.PointToClient(Cursor.Position)
                Dim c As GridEXColumn = .ColumnFromPoint(p.X, p.Y)
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Bloqueado"
                            Grid.GetRow.BeginEdit()
                            Grid.GetRow.Cells(c.Key).Value = Not Grid.GetRow.Cells(c.Key).Value
                            Grid.GetRow.EndEdit()
                            Grid.Refresh()
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub Grid_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
        Select Case e.Column.Key
            Case "Observaciones"
                Dim frm As New FormularioTexto
                frm.Texto = Grid.GetRow.Cells("Observaciones").Value & String.Empty
                If frm.ShowDialog() = DialogResult.OK Then
                    If Grid.GetValue("Observaciones") & String.Empty <> frm.Texto Then
                        Grid.SetValue("Observaciones", frm.Texto)
                    End If
                End If
                frm.Dispose()
        End Select
    End Sub

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        e.Cancel = Not (e.Column.Key = "Observaciones")
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.Cells("Bloqueado").Value Then
            e.Row.Cells("Bloqueado").ImageIndex = 0
        Else
            e.Row.Cells("Bloqueado").ImageIndex = -1
        End If
    End Sub

#Region "Informes"
    Private Sub ConsultaLote_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias = "LLDESF" Then
            Dim be As New BE.DataEngine
            e.DataSource = be.RetrieveData("vRptLoteDesfase", , New NumberFilterItem("Cantidad-StockFisico", FilterOperator.NotEqual, 0))
        End If
    End Sub

    Private Sub ConsultaLote_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        If e.Alias = "LLOTE" Then
            Dim f As New CIMntoFilter
            f.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
            f.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
            f.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
            f.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
            f.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
            f.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
            f.Add("Lote", FilterOperator.Equal, advLote.Text, FilterType.String)
            f.Add("Ubicacion", FilterOperator.Equal, advUbicacion.Text, FilterType.String)
            f.Add("StockFisico", FilterOperator.GreaterThanOrEqual, ntxStockDesde.Value, FilterType.Numeric)
            f.Add("StockFisico", FilterOperator.LessThanOrEqual, ntxStockHasta.Value, FilterType.Numeric)
            If cboBloqueados.Value <> enumBoolean.Todos Then
                f.Add("Bloqueado", FilterOperator.Equal, cboBloqueados.Value = enumBoolean.Si, FilterType.Boolean)
            End If
            e.Filter.Add(f.InnerFilter)
        End If
    End Sub
#End Region

End Class
