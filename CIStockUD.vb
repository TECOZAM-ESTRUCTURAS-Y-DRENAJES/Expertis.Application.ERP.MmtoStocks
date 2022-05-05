Public Class CIStockUD
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents LblArticuloDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblSubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTotalCantidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents NtbTotalCantidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents LblUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvUnidad As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIStockUD))
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblArticuloDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblSubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbTotalCantidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblTotalCantidad = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.LblUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvUnidad = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.LblAlmacen)
        Me.FilterPanel.Controls.Add(Me.LblSubFamilia)
        Me.FilterPanel.Controls.Add(Me.LblFamilia)
        Me.FilterPanel.Controls.Add(Me.LblTipo)
        Me.FilterPanel.Controls.Add(Me.LblArticuloDesde)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacen)
        Me.FilterPanel.Controls.Add(Me.AdvSubFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 341)
        Me.FilterPanel.Size = New System.Drawing.Size(688, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Controls.Add(Me.Frame1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(688, 341)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Frame1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = ""
        Me.Grid.KeyField = "IDArticulo"
        Me.Grid.Location = New System.Drawing.Point(0, 32)
        Me.Grid.Size = New System.Drawing.Size(688, 261)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = ""
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
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
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
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.DisplayField = "IDArticulo"
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(88, 24)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(112, 23)
        Me.AdvArticulo.TabIndex = 0
        '
        'LblArticuloDesde
        '
        Me.LblArticuloDesde.Location = New System.Drawing.Point(8, 24)
        Me.LblArticuloDesde.Name = "LblArticuloDesde"
        Me.LblArticuloDesde.Size = New System.Drawing.Size(50, 13)
        Me.LblArticuloDesde.TabIndex = 1
        Me.LblArticuloDesde.Text = "Artículo"
        Me.LblArticuloDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipo
        '
        Me.LblTipo.Location = New System.Drawing.Point(8, 48)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 5
        Me.LblTipo.Text = "Tipo"
        Me.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.DisplayField = "IDTipo"
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(88, 48)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(112, 23)
        Me.AdvTipo.TabIndex = 2
        '
        'LblFamilia
        '
        Me.LblFamilia.Location = New System.Drawing.Point(256, 24)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.LblFamilia.TabIndex = 7
        Me.LblFamilia.Text = "Familia"
        Me.LblFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.DisplayField = "IDFamilia"
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(336, 24)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(112, 23)
        Me.AdvFamilia.TabIndex = 3
        '
        'LblSubFamilia
        '
        Me.LblSubFamilia.Location = New System.Drawing.Point(256, 48)
        Me.LblSubFamilia.Name = "LblSubFamilia"
        Me.LblSubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.LblSubFamilia.TabIndex = 9
        Me.LblSubFamilia.Text = "SubFamilia"
        Me.LblSubFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvSubFamilia
        '
        Me.AdvSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubFamilia.DisplayField = "IDSubFamilia"
        Me.AdvSubFamilia.EntityName = "SubFamilia"
        Me.AdvSubFamilia.Location = New System.Drawing.Point(336, 48)
        Me.AdvSubFamilia.Name = "AdvSubFamilia"
        Me.AdvSubFamilia.SecondaryDataFields = "IDSubFamilia"
        Me.AdvSubFamilia.Size = New System.Drawing.Size(112, 23)
        Me.AdvSubFamilia.TabIndex = 4
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Location = New System.Drawing.Point(504, 24)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.LblAlmacen.TabIndex = 11
        Me.LblAlmacen.Text = "Almacén"
        Me.LblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.DisplayField = "IDAlmacen"
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(568, 24)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(112, 23)
        Me.AdvAlmacen.TabIndex = 5
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.NtbTotalCantidad)
        Me.Frame1.Controls.Add(Me.LblTotalCantidad)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Frame1.Location = New System.Drawing.Point(0, 293)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(688, 48)
        Me.Frame1.TabIndex = 14
        Me.Frame1.TabStop = False
        '
        'NtbTotalCantidad
        '
        Me.NtbTotalCantidad.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalCantidad.Enabled = False
        Me.NtbTotalCantidad.Location = New System.Drawing.Point(552, 16)
        Me.NtbTotalCantidad.Name = "NtbTotalCantidad"
        Me.NtbTotalCantidad.Size = New System.Drawing.Size(128, 21)
        Me.NtbTotalCantidad.TabIndex = 1
        '
        'LblTotalCantidad
        '
        Me.LblTotalCantidad.Location = New System.Drawing.Point(456, 16)
        Me.LblTotalCantidad.Name = "LblTotalCantidad"
        Me.LblTotalCantidad.Size = New System.Drawing.Size(89, 13)
        Me.LblTotalCantidad.TabIndex = 0
        Me.LblTotalCantidad.Text = "Total Cantidad"
        Me.LblTotalCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblUnidad)
        Me.Panel1.Controls.Add(Me.AdvUnidad)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 32)
        Me.Panel1.TabIndex = 0
        '
        'LblUnidad
        '
        Me.LblUnidad.Location = New System.Drawing.Point(24, 11)
        Me.LblUnidad.Name = "LblUnidad"
        Me.LblUnidad.Size = New System.Drawing.Size(46, 13)
        Me.LblUnidad.TabIndex = 15
        Me.LblUnidad.Text = "Unidad"
        Me.LblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvUnidad
        '
        Me.AdvUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.AdvUnidad.DisplayField = "IDUdMedida"
        Me.AdvUnidad.EntityName = "UDMedida"
        Me.AdvUnidad.Location = New System.Drawing.Point(88, 6)
        Me.AdvUnidad.Name = "AdvUnidad"
        Me.AdvUnidad.SecondaryDataFields = "IDUdMedida"
        Me.AdvUnidad.Size = New System.Drawing.Size(112, 23)
        Me.AdvUnidad.TabIndex = 14
        '
        'CIStockUD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.EntityName = ""
        Me.KeyField = "IDArticulo"
        Me.Name = "CIStockUD"
        Me.ViewName = ""
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Funciones Privadas"

    Private Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        If Length(AdvUnidad.Value) > 0 Then
            e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Value, FilterType.String)
            e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Value, FilterType.String)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Value, FilterType.String)
            e.Filter.Add("IDSubFamilia", FilterOperator.Equal, AdvSubFamilia.Value, FilterType.String)
            e.Filter.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Value, FilterType.String)
            e.Filter.Add("IDUdMedida", FilterOperator.Equal, AdvUnidad.Value, FilterType.String)
            'TODO
            Dim DtGrid As DataTable = ExpertisApp.ExecuteTask(Of Filter, DataTable)(AddressOf UdMedida.CargarMedidasAB, e.Filter.InnerFilter)

            If Not DtGrid Is Nothing AndAlso DtGrid.Rows.Count > 0 Then
                Me.BindEditEvents(DtGrid)
                Grid.DataSource = DtGrid
            Else
                Grid.DataSource = Nothing
                CalcularImportes()
            End If
        Else
            ExpertisApp.GenerateMessage("Es necesario filtrar por una Unidad.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Grid.DataSource = Nothing
            CalcularImportes()
        End If
    End Sub

    Private Sub CalcularImportes()
        If Grid.RowCount > 0 Then
            NtbTotalCantidad.Value = Grid.GetTotal(Grid.Columns("StockFisicoU"), Janus.Windows.GridEX.AggregateFunction.Sum)
        Else
            NtbTotalCantidad.Value = 0
        End If
    End Sub

#End Region

#Region "Eventos CIStockUD"

    Private Sub CIStockUD_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
    End Sub

    Private Sub CIStockUD_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        CalcularImportes()
    End Sub

    Private Sub CIStockUD_SetReportExportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
    End Sub

#End Region

End Class