Public Class ValoracionEnFecha
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mblnStkDobleUnidad As Boolean
    Private mMonedaA As MonedaInfo
    Private mMonedaB As MonedaInfo
    Private mParametros As ProcesoStocks.ParametrosValoracion
    Private mFilter As CIMntoFilter
    Private mCurrentData As DataTable
    Friend WithEvents advIDArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmTotales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents LblTotalImporte As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbTotalImporte As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboActivo As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents lblcboEstado As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cboEstado As Solmicro.Expertis.Engine.UI.ComboBox

    Private Const cnABRIRARTICULO As String = "Abrir Artículo"


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mParametros = New ProcesoStocks.ParametrosValoracion
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
    Friend WithEvents fwiArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMenor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMayor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtStockDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtStockHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents chkFiltroLocal As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblAsterisco As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboActivo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cboEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValoracionEnFecha))
        Me.fwiArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiStockMenor = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiStockMayor = New Solmicro.Expertis.Engine.UI.Label
        Me.txtStockDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtStockHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.chkFiltroLocal = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblAsterisco = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmTotales = New Solmicro.Expertis.Engine.UI.Frame
        Me.LblTotalImporte = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbTotalImporte = New Solmicro.Expertis.Engine.UI.NumericTextBox
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
        Me.FrmTotales.SuspendLayout()
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
        Me.FilterPanel.Controls.Add(Me.advIDArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblAsterisco)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMayor)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMenor)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipo)
        Me.FilterPanel.Controls.Add(Me.chkFiltroLocal)
        Me.FilterPanel.Controls.Add(Me.txtStockHasta)
        Me.FilterPanel.Controls.Add(Me.txtStockDesde)
        Me.FilterPanel.Controls.Add(Me.fwiArticulo)
        Me.FilterPanel.Controls.Add(Me.fwiFamilia)
        Me.FilterPanel.Controls.Add(Me.fwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.fwiTipo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 285)
        Me.FilterPanel.Size = New System.Drawing.Size(712, 136)
        Me.FilterPanel.TabIndex = 1
        Me.FilterPanel.Text = "Criterios de Consulta"
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.FrmTotales)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(712, 285)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.FrmTotales, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Size = New System.Drawing.Size(712, 241)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmCIValoracionAlmacenEnFecha"
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
        'fwiArticulo
        '
        Me.fwiArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiArticulo.EntityName = "Articulo"
        Me.fwiArticulo.Location = New System.Drawing.Point(98, 31)
        Me.fwiArticulo.Name = "fwiArticulo"
        Me.fwiArticulo.PrimaryDataFields = "IDArticulo"
        Me.fwiArticulo.SecondaryDataFields = "IDArticulo"
        Me.fwiArticulo.Size = New System.Drawing.Size(124, 23)
        Me.fwiArticulo.TabIndex = 0
        Me.fwiArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(8, 36)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 0
        Me.lblfwiArticulo.Tag = "IdRec=4430;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'fwiAlmacen
        '
        Me.fwiAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.fwiAlmacen.EntityName = "Almacen"
        Me.fwiAlmacen.Location = New System.Drawing.Point(98, 57)
        Me.fwiAlmacen.Name = "fwiAlmacen"
        Me.fwiAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.Size = New System.Drawing.Size(124, 23)
        Me.fwiAlmacen.TabIndex = 1
        Me.fwiAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(8, 62)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 2
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'fwiTipo
        '
        Me.fwiTipo.DisabledBackColor = System.Drawing.Color.White
        Me.fwiTipo.EntityName = "TipoArticulo"
        Me.fwiTipo.Location = New System.Drawing.Point(300, 31)
        Me.fwiTipo.Name = "fwiTipo"
        Me.fwiTipo.PrimaryDataFields = "IDTipo"
        Me.fwiTipo.SecondaryDataFields = "IDTipo"
        Me.fwiTipo.Size = New System.Drawing.Size(124, 23)
        Me.fwiTipo.TabIndex = 3
        Me.fwiTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblfwiTipo
        '
        Me.lblfwiTipo.Location = New System.Drawing.Point(248, 36)
        Me.lblfwiTipo.Name = "lblfwiTipo"
        Me.lblfwiTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipo.TabIndex = 4
        Me.lblfwiTipo.Tag = "IdRec=4456;"
        Me.lblfwiTipo.Text = "Tipo"
        '
        'lblfwiStockMenor
        '
        Me.lblfwiStockMenor.Location = New System.Drawing.Point(480, 76)
        Me.lblfwiStockMenor.Name = "lblfwiStockMenor"
        Me.lblfwiStockMenor.Size = New System.Drawing.Size(68, 13)
        Me.lblfwiStockMenor.TabIndex = 10
        Me.lblfwiStockMenor.Tag = "IdRec=8417;"
        Me.lblfwiStockMenor.Text = "*Stock <="
        '
        'fwiFamilia
        '
        Me.fwiFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.fwiFamilia.EntityName = "Familia"
        Me.fwiFamilia.Location = New System.Drawing.Point(300, 57)
        Me.fwiFamilia.Name = "fwiFamilia"
        Me.fwiFamilia.PrimaryDataFields = "IDFamilia"
        Me.fwiFamilia.SecondaryDataFields = "IDFamilia"
        Me.fwiFamilia.Size = New System.Drawing.Size(124, 23)
        Me.fwiFamilia.TabIndex = 4
        Me.fwiFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(248, 62)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(47, 13)
        Me.lblfwiFamilia.TabIndex = 6
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiStockMayor
        '
        Me.lblfwiStockMayor.Location = New System.Drawing.Point(480, 52)
        Me.lblfwiStockMayor.Name = "lblfwiStockMayor"
        Me.lblfwiStockMayor.Size = New System.Drawing.Size(68, 13)
        Me.lblfwiStockMayor.TabIndex = 8
        Me.lblfwiStockMayor.Tag = "IdRec=8418;"
        Me.lblfwiStockMayor.Text = "*Stock >="
        '
        'txtStockDesde
        '
        Me.txtStockDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockDesde.Location = New System.Drawing.Point(552, 48)
        Me.txtStockDesde.Name = "txtStockDesde"
        Me.txtStockDesde.Size = New System.Drawing.Size(120, 21)
        Me.txtStockDesde.TabIndex = 8
        Me.txtStockDesde.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'txtStockHasta
        '
        Me.txtStockHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockHasta.Location = New System.Drawing.Point(552, 72)
        Me.txtStockHasta.Name = "txtStockHasta"
        Me.txtStockHasta.Size = New System.Drawing.Size(120, 21)
        Me.txtStockHasta.TabIndex = 9
        Me.txtStockHasta.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'chkFiltroLocal
        '
        Me.chkFiltroLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiltroLocal.Location = New System.Drawing.Point(480, 24)
        Me.chkFiltroLocal.Name = "chkFiltroLocal"
        Me.chkFiltroLocal.Size = New System.Drawing.Size(208, 16)
        Me.chkFiltroLocal.TabIndex = 7
        Me.chkFiltroLocal.Text = "Filtrar sobre los datos calculados"
        '
        'lblAsterisco
        '
        Me.lblAsterisco.Location = New System.Drawing.Point(480, 100)
        Me.lblAsterisco.Name = "lblAsterisco"
        Me.lblAsterisco.Size = New System.Drawing.Size(254, 13)
        Me.lblAsterisco.TabIndex = 10
        Me.lblAsterisco.Text = "*Sólo se aplican sobre los datos calculados"
        '
        'advIDArticuloPadre
        '
        Me.advIDArticuloPadre.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloPadre.EntityName = "Articulo"
        Me.advIDArticuloPadre.Location = New System.Drawing.Point(98, 83)
        Me.advIDArticuloPadre.Name = "advIDArticuloPadre"
        Me.advIDArticuloPadre.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloPadre.Size = New System.Drawing.Size(124, 23)
        Me.advIDArticuloPadre.TabIndex = 2
        Me.advIDArticuloPadre.ViewName = "tbMaestroArticulo"
        '
        'lblArticuloPadre
        '
        Me.lblArticuloPadre.Location = New System.Drawing.Point(8, 88)
        Me.lblArticuloPadre.Name = "lblArticuloPadre"
        Me.lblArticuloPadre.Size = New System.Drawing.Size(87, 13)
        Me.lblArticuloPadre.TabIndex = 92
        Me.lblArticuloPadre.Tag = ""
        Me.lblArticuloPadre.Text = "Artículo Padre"
        '
        'FrmTotales
        '
        Me.FrmTotales.Controls.Add(Me.LblTotalImporte)
        Me.FrmTotales.Controls.Add(Me.NtbTotalImporte)
        Me.FrmTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmTotales.Location = New System.Drawing.Point(0, 241)
        Me.FrmTotales.Name = "FrmTotales"
        Me.FrmTotales.Size = New System.Drawing.Size(712, 44)
        Me.FrmTotales.TabIndex = 1
        Me.FrmTotales.TabStop = False
        Me.FrmTotales.Text = "Totales"
        Me.FrmTotales.Visible = False
        '
        'LblTotalImporte
        '
        Me.LblTotalImporte.Location = New System.Drawing.Point(515, 17)
        Me.LblTotalImporte.Name = "LblTotalImporte"
        Me.LblTotalImporte.Size = New System.Drawing.Size(85, 13)
        Me.LblTotalImporte.TabIndex = 1
        Me.LblTotalImporte.Text = "Total Importe"
        '
        'NtbTotalImporte
        '
        Me.NtbTotalImporte.DisabledBackColor = System.Drawing.Color.White
        Me.NtbTotalImporte.Enabled = False
        Me.NtbTotalImporte.Location = New System.Drawing.Point(606, 13)
        Me.NtbTotalImporte.Name = "NtbTotalImporte"
        Me.NtbTotalImporte.Size = New System.Drawing.Size(100, 21)
        Me.NtbTotalImporte.TabIndex = 0
        '
        'lblActivo
        '
        Me.lblActivo.Location = New System.Drawing.Point(248, 111)
        Me.lblActivo.Name = "lblActivo"
        Me.lblActivo.Size = New System.Drawing.Size(42, 13)
        Me.lblActivo.TabIndex = 94
        Me.lblActivo.Tag = ""
        Me.lblActivo.Text = "Activo"
        '
        'cboActivo
        '
        cboActivo_DesignTimeLayout.LayoutString = resources.GetString("cboActivo_DesignTimeLayout.LayoutString")
        Me.cboActivo.DesignTimeLayout = cboActivo_DesignTimeLayout
        Me.cboActivo.DisabledBackColor = System.Drawing.Color.White
        Me.cboActivo.Location = New System.Drawing.Point(300, 107)
        Me.cboActivo.Name = "cboActivo"
        Me.cboActivo.SelectedIndex = -1
        Me.cboActivo.SelectedItem = Nothing
        Me.cboActivo.Size = New System.Drawing.Size(124, 21)
        Me.cboActivo.TabIndex = 6
        '
        'lblcboEstado
        '
        Me.lblcboEstado.Location = New System.Drawing.Point(248, 87)
        Me.lblcboEstado.Name = "lblcboEstado"
        Me.lblcboEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblcboEstado.TabIndex = 158
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
        Me.cboEstado.Location = New System.Drawing.Point(300, 83)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.SecondaryDataFields = "IDEstado"
        Me.cboEstado.SelectedIndex = -1
        Me.cboEstado.SelectedItem = Nothing
        Me.cboEstado.Size = New System.Drawing.Size(124, 21)
        Me.cboEstado.TabIndex = 5
        Me.cboEstado.ValueMember = "IDEstado"
        Me.cboEstado.ViewName = "tbMaestroArticuloEstado"
        '
        'ValoracionEnFecha
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.EntityName = "ArticuloAlmacen"
        Me.Name = "ValoracionEnFecha"
        Me.Text = "Valoración en Fecha"
        Me.ViewName = "vFrmCIValoracionAlmacenEnFecha"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.FrmTotales.ResumeLayout(False)
        Me.FrmTotales.PerformLayout()
        CType(Me.cboActivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ValoracionEnFecha_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            Dim Moneda As New Moneda

            mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
            mMonedaB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, cnMinDate)

            Grid.Columns("PrecioA").Caption = Grid.Columns("PrecioA").Caption.Replace("A", "(" & mMonedaA.Abreviatura & ")")
            Grid.Columns("PrecioB").Caption = Grid.Columns("PrecioB").Caption.Replace("B", "(" & mMonedaB.Abreviatura & ")")
            Grid.Columns("ImporteA").Caption = Grid.Columns("ImporteA").Caption.Replace("A", "(" & mMonedaA.Abreviatura & ")")
            Grid.Columns("ImporteB").Caption = Grid.Columns("ImporteB").Caption.Replace("B", "(" & mMonedaB.Abreviatura & ")")

            Grid.Columns("PrecioA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
            Grid.Columns("PrecioB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesPrecio)
            Grid.Columns("ImporteA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
            Grid.Columns("ImporteB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesImporte)

            'txtStockDesde.Text.Format("#,0.0###")
            'txtStockHasta.Text.Format("#,0.0###")

            Grid.Actions.Add(cnABRIRARTICULO, AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
            Grid.Actions.Add("Abrir consulta de descuadres", AddressOf AbrirConsultaDescuadres)
            Grid.Actions.Add("Consultar movimientos", AddressOf AbrirConsultaMovimientos)
            lblAsterisco.ForeColor = Color.Red
            Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.True

            LoadEnums()
            InitFilterCriteria()
        End If
    End Sub


    Private Sub LoadEnums()
        cboActivo.DataSource = New EnumData("enumBoolean")
        EnumData.PopulateValueList("enumBoolean", Grid.Columns("Activo"))
    End Sub

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad

        If Me.Grid.Columns.Contains("StockFisico2") Then
            Me.Grid.Columns("StockFisico2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("StockFisico2").Position = Me.Grid.Columns("Stock").Position + 1
        End If
    End Sub

    Private Sub FormattingRowHandler(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.TotalRow Then
            e.Row.RowStyle = Grid.FormatStyles("TotalRowFormatStyle2")
        ElseIf e.Row.RowType = RowType.Record Then
            If Nz(e.Row.Cells("Stock").Value, 0) < 0 Then
                e.Row.RowStyle = Grid.FormatStyles("StockNegativoFormatStyle")
            End If
            If e.Row.Cells("DesajusteStockLote").Value Or e.Row.Cells("DesajusteStockSerie").Value Then
                e.Row.RowStyle = Grid.FormatStyles("DesajusteStock")
            End If
        End If
    End Sub

#Region "Criterios de filtro"
    Protected Overrides Sub OnQueryExecuting(ByVal e As Engine.UI.QueryExecutingEventArgs)
        mFilter = New CIMntoFilter
        mFilter.Add("IDArticulo", FilterOperator.Equal, fwiArticulo.Text, FilterType.String)
        mFilter.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        mFilter.Add("IDAlmacen", FilterOperator.Equal, fwiAlmacen.Text, FilterType.String)
        mFilter.Add("IDTipo", FilterOperator.Equal, fwiTipo.Text, FilterType.String)
        mFilter.Add("IDFamilia", FilterOperator.Equal, fwiFamilia.Text, FilterType.String)
        mFilter.Add("IDEstado", FilterOperator.Equal, cboEstado.Value, FilterType.String)
        If cboActivo.Value <> CInt(enumBoolean.Todos) Then mFilter.Add("Activo", FilterOperator.Equal, cboActivo.Value, FilterType.Boolean)
        If chkFiltroLocal.Checked Then
            e.Cancel = True
            mFilter.Add("Stock", FilterOperator.GreaterThanOrEqual, txtStockDesde.Text, FilterType.Numeric)
            mFilter.Add("Stock", FilterOperator.LessThanOrEqual, txtStockHasta.Text, FilterType.Numeric)

            If Not IsNothing(mCurrentData) AndAlso mCurrentData.Rows.Count > 0 Then
                Dim dv As New DataView(mCurrentData)
                dv.RowFilter = mFilter.InnerFilter.Compose(New AdoFilterComposer)
                Dim aux As DataTable = mCurrentData.Clone
                For Each drv As DataRowView In dv
                    aux.Rows.Add(drv.Row.ItemArray)
                Next
                Grid.DataSource = aux
            End If
        Else
            MyBase.OnQueryExecuting(e)
        End If
    End Sub

    Protected Overrides Sub OnQueryExecuted(ByVal e As Engine.UI.QueryExecutedEventArgs)
        MyBase.OnQueryExecuted(e)
        If Not IsNothing(Grid.DataSource) Then
            Dim dt As DataTable = CType(Grid.DataSource, DataTable).Copy
            dt.Columns.Add("Stock", GetType(Double))
            dt.Columns.Add("PrecioA", GetType(Double))
            dt.Columns.Add("PrecioB", GetType(Double))
            dt.Columns.Add("ImporteA", GetType(Double))
            dt.Columns.Add("ImporteB", GetType(Double))
            Grid.DataSource = dt
        End If
        ComprobarArticulosKit()
    End Sub

    Private Sub ComprobarArticulosKit()
        Dim DtGrid As DataTable = Grid.DataSource
        For Each Dr As DataRow In DtGrid.Select
            Dim DrTipo As DataRow = CType(New TipoArticulo().SelOnPrimaryKey(Dr("IDTipo")), DataTable).Rows(0)
            If DrTipo("KitVenta") = True Then
                Dim DtComp As DataTable = New Estructura().Filter(New FilterItem("IDArticulo", FilterOperator.Equal, Dr("IDArticulo")))
                For Each DrComp As DataRow In DtComp.Select
                    Dim DrSelArt() As DataRow = DtGrid.Select("IDArticulo = '" & DrComp("IDComponente") & "'")
                    If DrSelArt.Length <= 0 Then
                        Dim DrArtComp As DataRow = CType(New Articulo().SelOnPrimaryKey(DrComp("IDComponente")), DataTable).Rows(0)
                        Dim DrNew As DataRow = DtGrid.NewRow
                        DrNew("IDArticulo") = DrComp("IDComponente")
                        DrNew("DescArticulo") = DrArtComp("DescArticulo")
                        DrNew("IDTipo") = DrArtComp("IDTipo")
                        DrNew("DescTipo") = CType(New TipoArticulo().SelOnPrimaryKey(DrNew("IDTipo")), DataTable).Rows(0)("DescTipo")
                        DrNew("IDFamilia") = DrArtComp("IDFamilia")
                        Dim FilFam As New Filter
                        FilFam.Add("IDTipo", FilterOperator.Equal, DrNew("IDTipo"))
                        FilFam.Add("IDFamilia", FilterOperator.Equal, DrNew("IDFamilia"))
                        DrNew("DescFamilia") = CType(New Familia().Filter(FilFam), DataTable).Rows(0)("DescFamilia")
                        DrNew("IDSubFamilia") = Nz(DrArtComp("IDSubFamilia"), String.Empty)
                        If Length(DrNew("IDSubFamilia")) > 0 Then
                            FilFam.Add("IDSubFamilia", FilterOperator.Equal, DrNew("IDSubFamilia"))
                            DrNew("DescSubFamilia") = CType(New Subfamilia().Filter(FilFam), DataTable).Rows(0)("DescSubFamilia")
                        Else
                            DrNew("DescSubFamilia") = String.Empty
                        End If
                        DrNew("CriterioValoracion") = DrArtComp("CriterioValoracion")
                        DrNew("DesajusteStockLote") = 0
                        DrNew("DesajusteStockSerie") = 0

                        Dim FilAlm As New Filter
                        FilAlm.Add("IDArticulo", FilterOperator.Equal, DrNew("IDArticulo"))
                        FilAlm.Add("Predeterminado", FilterOperator.Equal, 1)
                        Dim DrAlm As DataRow = CType(New ArticuloAlmacen().Filter(FilAlm), DataTable).Rows(0)
                        DrNew("IDAlmacen") = DrAlm("IDAlmacen")
                        DrNew("DescAlmacen") = CType(New Almacen().SelOnPrimaryKey(DrNew("IDAlmacen")), DataTable).Rows(0)("DescAlmacen")
                        DrNew("StockFisico") = DrAlm("StockFisico")
                        DtGrid.Rows.Add(DrNew)
                    End If
                Next
            End If
        Next
        Grid.DataSource = DtGrid
    End Sub


    Private Sub ValoracionEnFecha_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Dim ie As IEnumerator = mFilter.InnerFilter.GetEnumerator
        Do While ie.MoveNext
            e.Filter.Add(CType(ie.Current, IFilter))
        Loop
    End Sub

    Private Sub fwiFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles fwiFamilia.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, fwiTipo.Text))
    End Sub

    Private Sub ValoracionEnFecha_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        InitFilterCriteria()
    End Sub

    Private Sub InitFilterCriteria()
        txtStockDesde.Text = Nothing
        txtStockHasta.Text = Nothing
        cboActivo.Value = enumBoolean.Todos
    End Sub

    Private Sub chkFiltroLocal_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFiltroLocal.CheckedChanged
        If chkFiltroLocal.Checked Then
            If Not IsNothing(Grid.DataSource) Then
                mCurrentData = CType(Grid.DataSource, DataTable).Copy
            End If
        Else
            Grid.DataSource = mCurrentData.Copy
        End If
    End Sub
#End Region

#Region "Procesos"
    Private Sub AccionValoracion(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ExecuteActions.Click
        'If Grid.RecordCount > 0 Then
        Dim frm As New ParametrosValoracion
        frm.ShowDialog(mParametros)
        If frm.DialogResult = DialogResult.OK Then
            mParametros = frm.Parametros

            'Dim dtParam As DataTable = New Parametro().SelOnPrimaryKey("BDGUDMED")
            'If dtParam.Rows.Count > 0 Then
      
            If Length(frm.DescUdValoracion) Then
                Grid.Columns("StockAFechaUdValoracion").Caption = frm.DescUdValoracion
            Else
                Grid.Columns("StockAFechaUdValoracion").Caption = ExpertisApp.Traslate("Stock Ud. Valoración")
            End If
        'End If

            Dim result As ProcesoStocks.ValoracionResultInfo = Nothing
            Dim data As DataTable = Nothing
            Me.Cursor = Cursors.WaitCursor
            If mParametros.ConRegistros Then
                If Not Grid.DataSource Is Nothing AndAlso Grid.RowCount > 0 Then
                    data = CType(Grid.DataSource, DataTable)
                Else
                    Me.Execute()
                    data = CType(Grid.DataSource, DataTable)
                End If
                data.RemotingFormat = SerializationFormat.Binary
                Select Case mParametros.CriterioValoracion
                    Case ProcesoStocks.CriterioValoracion.Articulo
                        Dim datosVal As New ProcesoStocks.DataValoracionEnFechaPrecioMedio(mParametros.FechaCalculo, data, mParametros.Salvar, mParametros.FechaInicioPrecioMedio)
                        datosVal.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFechaPrecioMedio, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFecha, datosVal)
                    Case ProcesoStocks.CriterioValoracion.PrecioEstandar
                        Dim datosValPStd As New ProcesoStocks.DataValoracionEnFecha(mParametros.FechaCalculo, data)
                        datosValPStd.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFecha, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFechaPrecioEstandar, datosValPStd)
                    Case ProcesoStocks.CriterioValoracion.PrecioFifoFecha
                        Dim datosValPFIFO As New ProcesoStocks.DataValoracionEnFechaFIFO(mParametros.FechaCalculo, data, enumstkValoracionFIFO.stkVFOrdenarPorFecha, mParametros.Salvar)
                        datosValPFIFO.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFechaFIFO, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFechaPrecioFIFO, datosValPFIFO)
                    Case ProcesoStocks.CriterioValoracion.PrecioFifoMvto
                        Dim datosValPFIFO As New ProcesoStocks.DataValoracionEnFechaFIFO(mParametros.FechaCalculo, data, enumstkValoracionFIFO.stkVFOrdenarPorMvto, mParametros.Salvar)
                        datosValPFIFO.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFechaFIFO, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFechaPrecioFIFO, datosValPFIFO)
                    Case ProcesoStocks.CriterioValoracion.PrecioMedio
                        Dim datosValPM As New ProcesoStocks.DataValoracionEnFechaPrecioMedio(mParametros.FechaCalculo, data, mParametros.Salvar, mParametros.FechaInicioPrecioMedio)
                        datosValPM.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFechaPrecioMedio, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFechaPrecioMedio, datosValPM)
                    Case ProcesoStocks.CriterioValoracion.PrecioUltimaCompra
                        Dim datosValPUltC As New ProcesoStocks.DataValoracionEnFecha(mParametros.FechaCalculo, data)
                        datosValPUltC.UDValoracion = mParametros.UDValoracion
                        result = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionEnFecha, ProcesoStocks.ValoracionResultInfo)(AddressOf ProcesoStocks.ValoracionEnFechaPrecioUltimaCompra, datosValPUltC)
                End Select

                If Not result Is Nothing Then FetchData(result.Valoraciones)
                SettingDobleUnidad()
                ExpertisApp.GenerateMessage("Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Resumen()
                If mParametros.ConTotales Then
                    Me.FrmTotales.Visible = True
                    Me.NtbTotalImporte.Value = Grid.GetTotal(Grid.Columns("ImporteA"), AggregateFunction.Sum)
                Else : Me.FrmTotales.Visible = False
                End If
                Me.Cursor = Cursors.Default
            ElseIf mParametros.ConTotales Then
                Grid.DataSource = Nothing
                Dim FilVal As New Filter
                If Length(fwiArticulo.Text) > 0 Then FilVal.Add("IDArticulo", FilterOperator.Equal, fwiArticulo.Text)
                If Length(advIDArticuloPadre.Text) > 0 Then FilVal.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text)
                If Length(fwiAlmacen.Text) > 0 Then FilVal.Add("IDAlmacen", FilterOperator.Equal, fwiAlmacen.Text)
                If Length(fwiTipo.Text) > 0 Then FilVal.Add("IDTipo", FilterOperator.Equal, fwiTipo.Text)
                If Length(fwiFamilia.Text) > 0 Then FilVal.Add("IDFamilia", FilterOperator.Equal, fwiFamilia.Text)

                Me.FrmTotales.Visible = True
                Dim StData As New ProcesoStocks.ParamsValoracionTotales(data, mParametros, FilVal)
                Me.NtbTotalImporte.Value = ExpertisApp.ExecuteTask(Of ProcesoStocks.ParamsValoracionTotales, Double)(AddressOf ProcesoStocks.ValoracionEnFechaTotales, StData)
                Me.Cursor = Cursors.Default
            End If
        End If
        'End If
    End Sub

    Private Sub FetchData(ByVal valoracion As ValoracionInfo())
        If Not valoracion Is Nothing AndAlso valoracion.Length > 0 Then
            Dim data As DataTable = CType(Grid.DataSource, DataTable)
            Dim dv As DataView = New DataView(data)
            dv.Sort = "IDArticulo,IDAlmacen"
            Dim index As Integer
            For Each valor As ValoracionInfo In valoracion
                index = dv.Find(New String(1) {valor.IDArticulo, valor.IDAlmacen})
                If index >= 0 Then
                    dv(index)("Stock") = valor.Stock.StockAFecha
                    dv(index)("StockFisico2") = valor.Stock.StockAFecha2
                    dv(index)("PrecioA") = valor.Precios.PrecioA
                    dv(index)("PrecioB") = valor.Precios.PrecioB
                    dv(index)("ImporteA") = valor.Stock.StockAFecha * valor.Precios.PrecioA
                    dv(index)("ImporteB") = valor.Stock.StockAFecha * valor.Precios.PrecioB
                    dv(index)("StockAFechaUdValoracion") = valor.Stock.StockAFechaUdValoracion
                End If
            Next
            Grid.Refetch()
        End If
    End Sub

    Private Sub Resumen()
        Grid.Columns("ImporteA").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ImporteB").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ImporteA").TotalFormatString = Grid.Columns("ImporteA").FormatString
        Grid.Columns("ImporteB").TotalFormatString = Grid.Columns("ImporteB").FormatString
        Grid.TotalRow = InheritableBoolean.True
        Grid.Row = Grid.GetTotalRow.Position
        Grid.Columns("ImporteA").AutoSize()
        Grid.Columns("ImporteB").AutoSize()
    End Sub

#End Region

#Region "Reports"
    Private Sub ValoracionEnFecha_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        If e.Alias = "LVALMFECHA" Then
            If Not IsNothing(mParametros) Then
                e.Formulas("FechaValoracion").Text = mParametros.FechaCalculo
                e.Formulas("CriterioValoracion").Text = mParametros.CriterioValoracion.ToString
            End If
        End If
    End Sub

    Private Sub ValoracionEnFecha_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        If e.Alias = "LVALMFECHA" Then
            e.DataSource = Grid.DataSource
        End If
    End Sub
#End Region

    Private Sub AbrirConsultaMovimientos()
        Dim parameters As New Hashtable
        parameters("IDArticulo") = Grid.Value("IDArticulo")
        parameters("IDAlmacen") = Grid.Value("IDAlmacen")
        If ExpertisApp.IsFormOpen("CONSMOV") Then
            ExpertisApp.CloseForm("CONSMOV")
        End If
        ExpertisApp.OpenForm("CONSMOV", , parameters)
    End Sub

    Private Sub AbrirConsultaDescuadres()
        Dim parameters As New Hashtable
        parameters("IDArticulo") = Grid.Value("IDArticulo")
        parameters("IDAlmacen") = Grid.Value("IDAlmacen")
        If ExpertisApp.IsFormOpen("DESAJSTK") Then
            ExpertisApp.CloseForm("DESAJSTK")
        End If
        ExpertisApp.OpenForm("DESAJSTK", , parameters)
    End Sub

    Private Sub CargarMantenimientoArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub

End Class
