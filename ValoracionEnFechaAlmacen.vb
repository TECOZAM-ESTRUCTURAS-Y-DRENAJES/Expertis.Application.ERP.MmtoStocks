Imports System.Collections.Generic

Public Class ValoracionEnFechaAlmacen
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.UiCommandManager1.CommandBars(0).Commands("ExecuteActions").Visible = Janus.Windows.UI.InheritableBoolean.False
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
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblStockMenor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblStockMayor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblFechaCalculo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ClbFechaCalculo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents NtbStockMayor As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NtbStockMenor As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmFecha As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboActivo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvUDValoracion As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents lblcboEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cboEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents LblTipo As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValoracionEnFechaAlmacen))
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.LblStockMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.LblStockMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFechaCalculo = New Solmicro.Expertis.Engine.UI.Label
        Me.ClbFechaCalculo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.NtbStockMayor = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NtbStockMenor = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.LblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmFecha = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvUDValoracion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.cboActivo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblcboEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cboEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.FrmFecha.SuspendLayout()
        CType(Me.cboActivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblcboEstado)
        Me.FilterPanel.Controls.Add(Me.cboEstado)
        Me.FilterPanel.Controls.Add(Me.lblActivo)
        Me.FilterPanel.Controls.Add(Me.cboActivo)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.AdvTipo)
        Me.FilterPanel.Controls.Add(Me.LblFamilia)
        Me.FilterPanel.Controls.Add(Me.LblTipo)
        Me.FilterPanel.Controls.Add(Me.NtbStockMenor)
        Me.FilterPanel.Controls.Add(Me.NtbStockMayor)
        Me.FilterPanel.Controls.Add(Me.LblArticulo)
        Me.FilterPanel.Controls.Add(Me.LblStockMayor)
        Me.FilterPanel.Controls.Add(Me.LblAlmacen)
        Me.FilterPanel.Controls.Add(Me.LblStockMenor)
        Me.FilterPanel.Controls.Add(Me.AdvArticulo)
        Me.FilterPanel.Controls.Add(Me.AdvAlmacen)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 308)
        Me.FilterPanel.Size = New System.Drawing.Size(712, 113)
        Me.FilterPanel.TabIndex = 1
        Me.FilterPanel.Text = "Criterios de Consulta"
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.FrmFecha)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(712, 308)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.FrmFecha, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "HistoricoMovimiento"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.KeyField = "IDLineaMovimiento"
        Me.Grid.Location = New System.Drawing.Point(0, 51)
        Me.Grid.Size = New System.Drawing.Size(712, 257)
        Me.Grid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmCIValoracionAlmacenFecha"
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'Toolbar
        '
        Me.Toolbar.Location = New System.Drawing.Point(49, 0)
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(712, 421)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(712, 421)
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(98, 23)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(124, 23)
        Me.AdvArticulo.TabIndex = 0
        '
        'LblArticulo
        '
        Me.LblArticulo.Location = New System.Drawing.Point(8, 28)
        Me.LblArticulo.Name = "LblArticulo"
        Me.LblArticulo.Size = New System.Drawing.Size(50, 13)
        Me.LblArticulo.TabIndex = 0
        Me.LblArticulo.Tag = "IdRec=4430;"
        Me.LblArticulo.Text = "Artículo"
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(338, 23)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(124, 23)
        Me.AdvAlmacen.TabIndex = 3
        '
        'LblAlmacen
        '
        Me.LblAlmacen.Location = New System.Drawing.Point(248, 28)
        Me.LblAlmacen.Name = "LblAlmacen"
        Me.LblAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.LblAlmacen.TabIndex = 2
        Me.LblAlmacen.Tag = "IdRec=4408;"
        Me.LblAlmacen.Text = "Almacén"
        '
        'LblStockMenor
        '
        Me.LblStockMenor.Location = New System.Drawing.Point(516, 56)
        Me.LblStockMenor.Name = "LblStockMenor"
        Me.LblStockMenor.Size = New System.Drawing.Size(61, 13)
        Me.LblStockMenor.TabIndex = 10
        Me.LblStockMenor.Tag = "IdRec=8417;"
        Me.LblStockMenor.Text = "Stock <="
        '
        'LblStockMayor
        '
        Me.LblStockMayor.Location = New System.Drawing.Point(516, 28)
        Me.LblStockMayor.Name = "LblStockMayor"
        Me.LblStockMayor.Size = New System.Drawing.Size(61, 13)
        Me.LblStockMayor.TabIndex = 8
        Me.LblStockMayor.Tag = "IdRec=8418;"
        Me.LblStockMayor.Text = "Stock >="
        '
        'LblFechaCalculo
        '
        Me.LblFechaCalculo.Location = New System.Drawing.Point(8, 27)
        Me.LblFechaCalculo.Name = "LblFechaCalculo"
        Me.LblFechaCalculo.Size = New System.Drawing.Size(86, 13)
        Me.LblFechaCalculo.TabIndex = 11
        Me.LblFechaCalculo.Text = "Fecha Cálculo"
        '
        'ClbFechaCalculo
        '
        Me.ClbFechaCalculo.DisabledBackColor = System.Drawing.Color.White
        Me.ClbFechaCalculo.Location = New System.Drawing.Point(98, 22)
        Me.ClbFechaCalculo.Name = "ClbFechaCalculo"
        Me.ClbFechaCalculo.Size = New System.Drawing.Size(124, 21)
        Me.ClbFechaCalculo.TabIndex = 0
        '
        'NtbStockMayor
        '
        Me.NtbStockMayor.DisabledBackColor = System.Drawing.Color.White
        Me.NtbStockMayor.Location = New System.Drawing.Point(583, 24)
        Me.NtbStockMayor.Name = "NtbStockMayor"
        Me.NtbStockMayor.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbStockMayor.Size = New System.Drawing.Size(108, 21)
        Me.NtbStockMayor.TabIndex = 6
        '
        'NtbStockMenor
        '
        Me.NtbStockMenor.DisabledBackColor = System.Drawing.Color.White
        Me.NtbStockMenor.Location = New System.Drawing.Point(583, 52)
        Me.NtbStockMenor.Name = "NtbStockMenor"
        Me.NtbStockMenor.NullBehavior = Janus.Windows.GridEX.NumericEditNullBehavior.AllowNull
        Me.NtbStockMenor.Size = New System.Drawing.Size(108, 21)
        Me.NtbStockMenor.TabIndex = 7
        '
        'LblTipo
        '
        Me.LblTipo.Location = New System.Drawing.Point(8, 56)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(31, 13)
        Me.LblTipo.TabIndex = 16
        Me.LblTipo.Text = "Tipo"
        '
        'LblFamilia
        '
        Me.LblFamilia.Location = New System.Drawing.Point(8, 86)
        Me.LblFamilia.Name = "LblFamilia"
        Me.LblFamilia.Size = New System.Drawing.Size(46, 13)
        Me.LblFamilia.TabIndex = 17
        Me.LblFamilia.Text = "Familia"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(98, 52)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(124, 23)
        Me.AdvTipo.TabIndex = 1
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(98, 81)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(124, 23)
        Me.AdvFamilia.TabIndex = 2
        '
        'FrmFecha
        '
        Me.FrmFecha.Controls.Add(Me.Label1)
        Me.FrmFecha.Controls.Add(Me.AdvUDValoracion)
        Me.FrmFecha.Controls.Add(Me.LblFechaCalculo)
        Me.FrmFecha.Controls.Add(Me.ClbFechaCalculo)
        Me.FrmFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmFecha.Location = New System.Drawing.Point(0, 0)
        Me.FrmFecha.Name = "FrmFecha"
        Me.FrmFecha.Size = New System.Drawing.Size(712, 51)
        Me.FrmFecha.TabIndex = 1
        Me.FrmFecha.TabStop = False
        Me.FrmFecha.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(249, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Tag = ""
        Me.Label1.Text = "Ud. Valoración"
        '
        'AdvUDValoracion
        '
        Me.AdvUDValoracion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvUDValoracion.EntityName = "UdMedida"
        Me.AdvUDValoracion.Location = New System.Drawing.Point(339, 22)
        Me.AdvUDValoracion.Name = "AdvUDValoracion"
        Me.AdvUDValoracion.SecondaryDataFields = "IDUdMedida"
        Me.AdvUDValoracion.Size = New System.Drawing.Size(124, 23)
        Me.AdvUDValoracion.TabIndex = 1
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(248, 85)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 96
        Me.lblActivo.Tag = ""
        Me.lblActivo.Text = "Activo"
        '
        'cboActivo
        '
        cboActivo_DesignTimeLayout.LayoutString = resources.GetString("cboActivo_DesignTimeLayout.LayoutString")
        Me.cboActivo.DesignTimeLayout = cboActivo_DesignTimeLayout
        Me.cboActivo.DisabledBackColor = System.Drawing.Color.White
        Me.cboActivo.Location = New System.Drawing.Point(338, 81)
        Me.cboActivo.Name = "cboActivo"
        Me.cboActivo.SelectedIndex = -1
        Me.cboActivo.SelectedItem = Nothing
        Me.cboActivo.Size = New System.Drawing.Size(124, 21)
        Me.cboActivo.TabIndex = 5
        '
        'lblcboEstado
        '
        Me.lblcboEstado.Location = New System.Drawing.Point(248, 56)
        Me.lblcboEstado.Name = "lblcboEstado"
        Me.lblcboEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblcboEstado.TabIndex = 160
        Me.lblcboEstado.Tag = ""
        Me.lblcboEstado.Text = "Estado"
        '
        'cboEstado
        '
        cboEstado_DesignTimeLayout.LayoutString = resources.GetString("cboEstado_DesignTimeLayout.LayoutString")
        Me.cboEstado.DesignTimeLayout = cboEstado_DesignTimeLayout
        Me.cboEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cboEstado.DisplayMember = "IDEstado"
        Me.cboEstado.EntityName = "ArticuloEstado"
        Me.cboEstado.Location = New System.Drawing.Point(338, 52)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.SecondaryDataFields = "IDEstado"
        Me.cboEstado.SelectedIndex = -1
        Me.cboEstado.SelectedItem = Nothing
        Me.cboEstado.Size = New System.Drawing.Size(124, 21)
        Me.cboEstado.TabIndex = 4
        Me.cboEstado.ValueMember = "IDEstado"
        Me.cboEstado.ViewName = "tbMaestroArticuloEstado"
        '
        'ValoracionEnFechaAlmacen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.EntityName = "HistoricoMovimiento"
        Me.KeyField = "IDLineaMovimiento"
        Me.Name = "ValoracionEnFechaAlmacen"
        Me.Text = "Valoración en Fecha"
        Me.ViewName = "vFrmCIValoracionAlmacenFecha"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.FrmFecha.ResumeLayout(False)
        Me.FrmFecha.PerformLayout()
        CType(Me.cboActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Delegate Function GetDataVal() As DataTable
    Private mEsquema As String
   
#Region "Funciones / Procesos Privados"

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Artículo", AddressOf AbrirMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add("Consultar movimientos", AddressOf AbrirConsultaMovimientos, ExpertisApp.GetIcon("xConsultaMovim.ico"))
    End Sub

    Private Sub AbrirConsultaMovimientos()
        Dim parameters As New Hashtable
        parameters("IDArticulo") = Grid.Value("IDArticulo")
        parameters("IDAlmacen") = Grid.Value("IDAlmacen")
        If ExpertisApp.IsFormOpen("CONSMOV") Then ExpertisApp.CloseForm("CONSMOV")
        ExpertisApp.OpenForm("CONSMOV", , parameters)
    End Sub

    Private Sub AbrirMantenimientoArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub

    Private Sub FormatColumns()
        Dim Moneda As New Moneda
        Dim mMonedaA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
        Dim mMonedaB As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, cnMinDate)

        Grid.Columns("Precio").Caption = "Precio (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("PrecioMedio").Caption = "Precio Medio (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("PrecioEstandar").Caption = "Precio Std.(" & mMonedaA.Abreviatura & ")"
        Grid.Columns("PrecioUltimaCompra").Caption = "Precio Ult. Compra (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("FifoF").Caption = "Precio FIFO Fecha (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("FifoFD").Caption = "Precio FIFO Fecha Doc.(" & mMonedaA.Abreviatura & ")"

        Grid.Columns("ImportePrecio").Caption = "Importe(" & mMonedaA.Abreviatura & ")"
        Grid.Columns("ImportePrecioEstandar").Caption = "Imp. Precio Std. (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("ImportePrecioUltimaCompra").Caption = "Imp. Precio Ult. Compra (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("ImportePrecioMedio").Caption = "Imp. Precio Medio (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("ImporteFifoF").Caption = "Imp. FIFO Fecha (" & mMonedaA.Abreviatura & ")"
        Grid.Columns("ImporteFifoFD").Caption = "Imp. FIFO Fecha Doc (" & mMonedaA.Abreviatura & ")"

        Grid.Columns("Precio").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
        Grid.Columns("PrecioMedio").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
        Grid.Columns("PrecioEstandar").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
        Grid.Columns("PrecioUltimaCompra").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
        Grid.Columns("FifoF").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
        Grid.Columns("FifoFD").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)

        Grid.Columns("ImportePrecio").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
        Grid.Columns("ImportePrecioEstandar").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
        Grid.Columns("ImportePrecioUltimaCompra").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
        Grid.Columns("ImportePrecioMedio").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
        Grid.Columns("ImporteFifoF").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
        Grid.Columns("ImporteFifoFD").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
    End Sub

    Private Sub LoadDefaultValues()
        Me.NtbStockMayor.Value = Nothing
        Me.NtbStockMenor.Value = Nothing
        cboActivo.Value = enumBoolean.Todos
    End Sub

#End Region

#Region "Eventos ValoracionEnFechaAlmacen"

    Private Sub ValoracionEnFechaAlmacen_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FilterCleared
        LoadDefaultValues()
    End Sub

    Private Sub ValoracionEnFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mEsquema = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Business.General.Comunes.GetEsquemaBD, Nothing)
            LoadERPData()
            LoadGridActions()
            FormatColumns()
            LoadEnums()
            LoadDefaultValues()
        End If

    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        If p.GestionBodegas Then
            Dim dtParam As DataTable = p.SelOnPrimaryKey("BDGUDMED")
            If dtParam.Rows.Count > 0 Then
                Dim IDUDMedida As String = dtParam.Rows(0)("Valor") & String.Empty
                AdvUDValoracion.Value = IDUDMedida
            End If
        End If
    End Sub

    Private Sub LoadEnums()
        cboActivo.DataSource = New EnumData("enumBoolean")
        EnumData.PopulateValueList("enumBoolean", Grid.Columns("Activo"))
    End Sub

    Private Sub ValoracionEnFechaAlmacen_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        If Length(Me.ClbFechaCalculo.Value) > 0 Then
            e.Filter.Add("IDArticulo", FilterOperator.Equal, Me.AdvArticulo.Value, FilterType.String)
            e.Filter.Add("IDAlmacen", FilterOperator.Equal, Me.AdvAlmacen.Value, FilterType.String)
            e.Filter.Add("IDTipo", FilterOperator.Equal, Me.AdvTipo.Value, FilterType.String)
            e.Filter.Add("IDFamilia", FilterOperator.Equal, Me.AdvFamilia.Value, FilterType.String)
            e.Filter.Add("Acumulado", FilterOperator.GreaterThanOrEqual, Me.NtbStockMayor.Value, FilterType.Numeric)
            e.Filter.Add("Acumulado", FilterOperator.LessThanOrEqual, Me.NtbStockMenor.Value, FilterType.Numeric)
            If cboActivo.Value <> CInt(enumBoolean.Todos) Then e.Filter.Add("Activo", FilterOperator.Equal, cboActivo.Value, FilterType.Boolean)
            e.Filter.Add("IDEstado", FilterOperator.Equal, Me.cboEstado.Value, FilterType.String)

            'Dim vStr As String = "SELECT v.*"
            'If Length(AdvUDValoracion.Value) > 0 Then
            '    vStr &= ", " & mEsquema & ".fFactorArticuloAB(v.IDArticulo, v.IDUdInterna, " & Quoted(AdvUDValoracion.Value & String.Empty) & ", 0) AS FactorUdValoracion, " & _
            '                     "v.Acumulado * " & mEsquema & ".fFactorArticuloAB(v.IDArticulo, v.IDUdInterna, " & Quoted(AdvUDValoracion.Value & String.Empty) & ", 0) AS StockAFechaUdValoracion"
            'End If
            'vStr &= " FROM vFrmCIValoracionAlmacenFecha v RIGHT JOIN " & _
            '     "(SELECT   tbMaestroArticuloAlmacen.IDArticulo AS MIDArticulo, tbMaestroArticuloAlmacen.IDAlmacen AS MIDAlmacen," & mEsquema & ".fMovimientoValArticulo('" & Format(CDate(Me.ClbFechaCalculo.Value), "yyyyMMdd") & "', IDArticulo, IDAlmacen) AS MIDLineaMovimiento " & _
            '     "  FROM            tbMaestroArticuloAlmacen WHERE " & mEsquema & ".fMovimientoValArticulo('" & Format(CDate(Me.ClbFechaCalculo.Value), "yyyyMMdd") & "', IDArticulo, IDAlmacen)<>0 ) AS MovimientoArticuloAlmacen ON " & _
            '     " v.IDLineaMovimiento = MovimientoArticuloAlmacen.MIDLineaMovimiento " & _
            '     " AND v.IDArticulo = MovimientoArticuloAlmacen.MIDArticulo " & _
            '     " AND v.IDAlmacen = MovimientoArticuloAlmacen.MIDAlmacen " & _
            '     " WHERE v.IDLineaMovimiento IS NOT NULL"
            'If e.Filter.InnerFilter.Count > 0 Then
            '    vStr &= " AND " & e.Filter.InnerFilter.Compose(New AdoFilterComposer)
            'End If

            Dim datCalc As New ProcesoStocks.DataCalculoValoracionEnFechaAlmacen(Me.ClbFechaCalculo.Value, AdvUDValoracion.Value & String.Empty, e.Filter.InnerFilter)
            Dim vstr As String = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataCalculoValoracionEnFechaAlmacen, String)(AddressOf ProcesoStocks.CalculoValoracionEnFechaAlmacen, datCalc)
            Grid.ViewName = vStr
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar una fecha de cálculo para mostrar.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If Length(Me.AdvTipo.Value) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, Me.AdvTipo.Value)
        End If
        e.ForcePredefinedFilter = True
    End Sub

#End Region

    Private Sub AdvUDValoracion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvUDValoracion.SelectionChanged
        If Not AdvUDValoracion.SelectedRow Is Nothing Then        
            Grid.Columns("StockAFechaUdValoracion").Caption = AdvUDValoracion.SelectedRow("DescUdMedida") & String.Empty
        Else
            Grid.Columns("StockAFechaUdValoracion").Caption = ExpertisApp.Traslate("Stock Ud. Valoración")
        End If
    End Sub

    Private Sub AdvUDValoracion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvUDValoracion.Validated
        If Length(AdvUDValoracion.Text) = 0 Then
            Grid.Columns("StockAFechaUdValoracion").Visible = False
            Grid.Columns("StockAFechaUdValoracion").Caption = ExpertisApp.Traslate("Stock Ud. Valoración")
        End If
    End Sub

End Class