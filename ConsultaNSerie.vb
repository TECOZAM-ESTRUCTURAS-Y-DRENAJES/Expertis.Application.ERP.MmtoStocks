Public Class ConsultaNSerie
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
    Friend WithEvents LblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvNSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaNSerie))
        Me.LblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.LblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvNSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
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
        Me.FilterPanel.Controls.Add(Me.LblArticulo)
        Me.FilterPanel.Controls.Add(Me.LblTipo)
        Me.FilterPanel.Controls.Add(Me.LblFamilia)
        Me.FilterPanel.Controls.Add(Me.LblAlmacen)
        Me.FilterPanel.Controls.Add(Me.LblNSerie)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacen)
        Me.FilterPanel.Controls.Add(Me.AdvNSerie)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 269)
        Me.FilterPanel.Size = New System.Drawing.Size(712, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(712, 269)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloNSerie"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Size = New System.Drawing.Size(712, 269)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vfrmCIMntoNSerie"
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
        Me.MainPanel.Size = New System.Drawing.Size(712, 349)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(712, 349)
        '
        'LblArticulo
        '
        Me.LblArticulo.Location = New System.Drawing.Point(8, 24)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.LblArticulo.TabIndex = 18
        Me.LblArticulo.Tag = "IdRec=4377;"
        Me.LblArticulo.Text = "Artículo"
        Me.LblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTipo
        '
        Me.LblTipo.Location = New System.Drawing.Point(280, 24)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 22
        Me.LblTipo.Tag = "IdRec=4456;"
        Me.LblTipo.Text = "Tipo"
        Me.LblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFamilia
        '
        Me.LblFamilia.Location = New System.Drawing.Point(280, 48)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.LblFamilia.TabIndex = 24
        Me.LblFamilia.Tag = "IdRec=4454;"
        Me.LblFamilia.Text = "Familia"
        Me.LblFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Location = New System.Drawing.Point(8, 48)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.LblAlmacen.TabIndex = 20
        Me.LblAlmacen.Tag = "IdRec=4390;"
        Me.LblAlmacen.Text = "Almacén"
        Me.LblAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNSerie
        '
        Me.LblNSerie.Location = New System.Drawing.Point(536, 24)
        Me.LblNSerie.Name = "LblNSerie"
        Me.LblNSerie.Size = New System.Drawing.Size(45, 13)
        Me.LblNSerie.TabIndex = 26
        Me.LblNSerie.Tag = "IdRec=5968;"
        Me.LblNSerie.Text = "NSerie"
        Me.LblNSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(72, 24)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(112, 23)
        Me.AdvArticulo.TabIndex = 0
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(336, 24)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(112, 23)
        Me.AdvTipo.TabIndex = 2
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(336, 48)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(112, 23)
        Me.AdvFamilia.TabIndex = 3
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(72, 48)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(112, 23)
        Me.AdvAlmacen.TabIndex = 1
        '
        'AdvNSerie
        '
        Me.AdvNSerie.DisabledBackColor = System.Drawing.Color.White
        Me.AdvNSerie.EntityName = "ArticuloNSerie"
        Me.AdvNSerie.Location = New System.Drawing.Point(592, 24)
        Me.AdvNSerie.Name = "AdvNSerie"
        Me.AdvNSerie.SecondaryDataFields = "NSerie"
        Me.AdvNSerie.Size = New System.Drawing.Size(112, 23)
        Me.AdvNSerie.TabIndex = 4
        '
        'ConsultaNSerie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 437)
        Me.EntityName = "ArticuloNSerie"
        Me.Name = "ConsultaNSerie"
        Me.Text = "ConsultaNSerie"
        Me.ViewName = "vfrmCIMntoNSerie"
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


#Region "Funciones/Procesos Privados"

    Private Sub AplicarFiltros(ByRef e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Text, FilterType.String)
        e.Filter.Add("NSerie", FilterOperator.Equal, AdvNSerie.Text, FilterType.String)
    End Sub

#End Region

#Region "Eventos ConsultaNSerie"

#Region "Eventos Formulario"

    Private Sub ConsultaNSerie_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AdvArticulo.PredefinedFilter = New BooleanFilterItem("NSerieObligatorio", True)
    End Sub

    Private Sub ConsultaNSerie_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        AplicarFiltros(e)
    End Sub

#End Region

#Region "Eventos DataGrid"

    'Private Sub Grid_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.Click
    '    With Grid
    '        Dim hit As GridArea = .HitTest()
    '        If hit = GridArea.Cell Then
    '            Dim p As Point = Grid.PointToClient(Cursor.Position)
    '            Dim c As GridEXColumn = .ColumnFromPoint(p.X, p.Y)
    '            If Not IsNothing(c) Then
    '                Select Case c.Key
    '                    Case "Bloqueado"
    '                        Grid.GetRow.BeginEdit()
    '                        Grid.GetRow.Cells(c.Key).Value = Not Grid.GetRow.Cells(c.Key).Value
    '                        Grid.GetRow.EndEdit()
    '                        Grid.Refresh()
    '                End Select
    '            End If
    '        End If
    '    End With
    'End Sub

    'Private Sub Grid_Click(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnButtonClick
    '    If e.Column.Key = "Observaciones" Then
    '        Dim frm As New FormularioTexto
    '        frm.Texto = Grid.GetRow.Cells("Observaciones").Value & String.Empty
    '        If frm.ShowDialog() = DialogResult.OK Then
    '            If Grid.GetValue("Observaciones") & String.Empty <> frm.Texto Then
    '                Grid.SetValue("Observaciones", frm.Texto)
    '            End If
    '        End If
    '        frm.Dispose()
    '    End If
    'End Sub

    'Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
    '    e.Cancel = Not (e.Column.Key = "Observaciones")
    'End Sub

#End Region

#Region "Eventos AdvSearch"

    Private Sub AdvNSerie_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvNSerie.SetPredefinedFilter
        If Len(AdvArticulo.Text) > 0 Then e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
        If Len(AdvAlmacen.Text) > 0 Then e.Filter.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Text, FilterType.String)
    End Sub

    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If Len(AdvTipo.Text) Then e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, AdvTipo.Text))
    End Sub

#End Region

    '#Region "Informes"

    '    Private Sub ConsultaLote_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
    '        If e.Alias = "LLDESF" Then
    '            Dim be As New be.DataEngine
    '            e.DataSource = be.RetrieveData("vRptLoteDesfase", , New NumberFilterItem("Cantidad-StockFisico", FilterOperator.NotEqual, 0))
    '        End If
    '    End Sub

    '    Private Sub ConsultaLote_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
    '        If e.Alias = "LLOTE" Then
    '            Dim f As New CIMntoFilter
    '            f.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
    '            f.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Text, FilterType.String)
    '            f.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
    '            f.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
    '            f.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
    '            f.Add("IDAlmacen", FilterOperator.Equal, AdvAlmacen.Text, FilterType.String)
    '            e.Filter.Add(f.InnerFilter)
    '        End If
    '    End Sub
    '#End Region

#End Region

End Class