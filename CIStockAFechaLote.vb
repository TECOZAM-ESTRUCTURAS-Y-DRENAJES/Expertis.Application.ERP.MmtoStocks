Public Class CIStockAFechaLote
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        ntbStock.Value = System.DBNull.Value

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        If Not Me.DesignMode Then
            Me.clbFecha.BindableValue = Today
        End If
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
    Friend WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtLote As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents clbFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents SubFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Familia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Tipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advSubFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ntbStock As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIStockAFechaLote))
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblLote = New Solmicro.Expertis.Engine.UI.Label
        Me.txtLote = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.clbFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.SubFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.Familia = New Solmicro.Expertis.Engine.UI.Label
        Me.Tipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advSubFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ntbStock = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.SubFamilia)
        Me.FilterPanel.Controls.Add(Me.Familia)
        Me.FilterPanel.Controls.Add(Me.Tipo)
        Me.FilterPanel.Controls.Add(Me.advSubFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.clbFecha)
        Me.FilterPanel.Controls.Add(Me.txtLote)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblLote)
        Me.FilterPanel.Controls.Add(Me.lblFecha)
        Me.FilterPanel.Controls.Add(Me.ntbStock)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 141)
        Me.FilterPanel.Size = New System.Drawing.Size(696, 128)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(696, 141)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ArticuloAlmacenLote"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.GroupRowVisualStyle = Janus.Windows.GridEX.GroupRowVisualStyle.Outlook2003
        Me.Grid.Size = New System.Drawing.Size(696, 141)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "viewArticuloAlmacenLote"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(203, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(696, 269)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(696, 269)
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(12, 22)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 0
        Me.lblIDArticulo.Text = "Artículo"
        '
        'advIDArticulo
        '
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(97, 19)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(121, 23)
        Me.advIDArticulo.TabIndex = 1
        '
        'lblIDAlmacen
        '
        Me.lblIDAlmacen.Location = New System.Drawing.Point(12, 54)
        Me.lblIDAlmacen.Name = "lblIDAlmacen"
        Me.lblIDAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblIDAlmacen.TabIndex = 2
        Me.lblIDAlmacen.Text = "Almacén"
        '
        'advIDAlmacen
        '
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.EntityName = "Almacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(97, 54)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(121, 23)
        Me.advIDAlmacen.TabIndex = 3
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(463, 22)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(31, 13)
        Me.lblLote.TabIndex = 6
        Me.lblLote.Text = "Lote"
        '
        'txtLote
        '
        Me.txtLote.DisabledBackColor = System.Drawing.Color.White
        Me.txtLote.Location = New System.Drawing.Point(548, 19)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(121, 21)
        Me.txtLote.TabIndex = 7
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(463, 56)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(44, 13)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha "
        '
        'clbFecha
        '
        Me.clbFecha.DisabledBackColor = System.Drawing.Color.White
        Me.clbFecha.Location = New System.Drawing.Point(548, 54)
        Me.clbFecha.Name = "clbFecha"
        Me.clbFecha.Size = New System.Drawing.Size(121, 21)
        Me.clbFecha.TabIndex = 10
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(320, 88)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(121, 23)
        Me.AdvFamilia.TabIndex = 32
        '
        'SubFamilia
        '
        Me.SubFamilia.Location = New System.Drawing.Point(463, 88)
        Me.SubFamilia.Name = "SubFamilia"
        Me.SubFamilia.Size = New System.Drawing.Size(68, 13)
        Me.SubFamilia.TabIndex = 31
        Me.SubFamilia.Text = "SubFamilia"
        '
        'Familia
        '
        Me.Familia.Location = New System.Drawing.Point(240, 88)
        Me.Familia.Name = "Familia"
        Me.Familia.Size = New System.Drawing.Size(46, 13)
        Me.Familia.TabIndex = 30
        Me.Familia.Text = "Familia"
        '
        'Tipo
        '
        Me.Tipo.Location = New System.Drawing.Point(12, 88)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Size = New System.Drawing.Size(31, 13)
        Me.Tipo.TabIndex = 29
        Me.Tipo.Text = "Tipo"
        '
        'advSubFamilia
        '
        Me.advSubFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advSubFamilia.EntityName = "SubFamilia"
        Me.advSubFamilia.Location = New System.Drawing.Point(548, 88)
        Me.advSubFamilia.Name = "advSubFamilia"
        Me.advSubFamilia.SecondaryDataFields = "IdSubFamilia"
        Me.advSubFamilia.Size = New System.Drawing.Size(121, 23)
        Me.advSubFamilia.TabIndex = 28
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "tipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(97, 88)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IdTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(121, 23)
        Me.AdvTipo.TabIndex = 27
        '
        'ntbStock
        '
        Me.ntbStock.DisabledBackColor = System.Drawing.Color.White
        Me.ntbStock.Location = New System.Drawing.Point(320, 19)
        Me.ntbStock.Name = "ntbStock"
        Me.ntbStock.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.ntbStock.Size = New System.Drawing.Size(121, 21)
        Me.ntbStock.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Stock >"
        '
        'CIStockAFechaLote
        '
        Me.AllowDynamicFilter = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(704, 357)
        Me.EntityName = "ArticuloAlmacenLote"
        Me.Name = "CIStockAFechaLote"
        Me.Text = "CIStockAFechaLote"
        Me.ViewName = "viewArticuloAlmacenLote"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CIStockAFechaLote_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If Me.clbFecha.BindableValue Is Nothing OrElse Me.clbFecha.BindableValue Is System.DBNull.Value Then
            ExpertisApp.GenerateMessage("Es obligatorio introduccir la fecha a calcular el stock.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            e.Filter.Add("IdArticulo", FilterOperator.Equal, Me.advIDArticulo.Text, FilterType.String)
            e.Filter.Add("IdAlmacen", FilterOperator.Equal, Me.advIDAlmacen.Text, FilterType.String)
            e.Filter.Add("Lote", FilterOperator.Equal, Me.txtLote.Text, FilterType.String)
            e.Filter.Add("IdTipo", FilterOperator.Equal, Me.AdvTipo.Text, FilterType.String)
            e.Filter.Add("IdFamilia", FilterOperator.Equal, Me.AdvFamilia.Text, FilterType.String)
            e.Filter.Add("IdSubFamilia", FilterOperator.Equal, Me.advSubFamilia.Text, FilterType.String)
            'e.Filter.Add("StockFisico", FilterOperator.GreaterThanOrEqual, Me.ntbStock.Value, FilterType.Numeric)
            Dim datosStk As New ProcesoStocks.DataGetStockAFechaLote(Me.clbFecha.BindableValue, Me.ntbStock.Value, e.Filter.InnerFilter)
            Me.Grid.DataSource = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataGetStockAFechaLote, DataTable)(AddressOf ProcesoStocks.GetStockAFechaLote, datosStk)
        End If
        Me.RecordsState = RecordsState.Saved
        e.Cancel = True
    End Sub
    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If length(Me.AdvTipo.Text) > 0 Then
            e.Filter.Add("IdTipo", FilterOperator.Equal, Me.AdvTipo.Text)
        End If
    End Sub
    Private Sub advSubFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advSubFamilia.SetPredefinedFilter
        If length(Me.AdvTipo.Text) > 0 Then
            e.Filter.Add("IdTipo", FilterOperator.Equal, Me.AdvTipo.Text)
        End If
        If length(Me.AdvFamilia.Text) > 0 Then
            e.Filter.Add("IdFamilia", FilterOperator.Equal, Me.AdvFamilia.Text)
        End If
    End Sub

    
    Private Sub CIStockAFechaLote_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ntbStock.Value = 0
    End Sub
End Class
