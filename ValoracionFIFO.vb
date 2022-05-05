Public Class ValoracionFIFO
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Private mblnStkDobleUnidad As Boolean

    Private mMonedaA As MonedaInfo
    Private mMonedaB As MonedaInfo

    Private mEsMonedaA As Boolean
    Friend WithEvents advIDArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FrmTotales As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents NtbValorFIFO As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblValorFIFO As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbValorMedio As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblValorMedio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NtbValorStd As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents LblValorStd As Solmicro.Expertis.Engine.UI.Label
    Private Const cnABRIRARTICULO As String = "Abrir Artículo"

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
    Friend WithEvents lblfwiStockMenorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiStockMayorQue As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtStockHasta As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtStockDesde As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents advSubfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents advArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chkMonedaA As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents chkMonedaB As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValoracionFIFO))
        Me.txtStockHasta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiStockMenorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.txtStockDesde = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiStockMayorQue = New Solmicro.Expertis.Engine.UI.Label
        Me.advSubfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.advAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.advArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.chkMonedaA = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMonedaB = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.advIDArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmTotales = New Solmicro.Expertis.Engine.UI.Frame
        Me.NtbValorFIFO = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblValorFIFO = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbValorMedio = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblValorMedio = New Solmicro.Expertis.Engine.UI.Label
        Me.NtbValorStd = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.LblValorStd = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.FrmTotales.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.advIDArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.chkMonedaB)
        Me.FilterPanel.Controls.Add(Me.chkMonedaA)
        Me.FilterPanel.Controls.Add(Me.advSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiSubfamilia)
        Me.FilterPanel.Controls.Add(Me.advAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.txtStockHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMenorQue)
        Me.FilterPanel.Controls.Add(Me.advTipo)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipo)
        Me.FilterPanel.Controls.Add(Me.txtStockDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiStockMayorQue)
        Me.FilterPanel.Controls.Add(Me.advFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.advArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 333)
        Me.FilterPanel.Size = New System.Drawing.Size(734, 112)
        Me.FilterPanel.Text = "Criterios de Consulta"
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.FrmTotales)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(734, 333)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.FrmTotales, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "TipoMovimiento"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Size = New System.Drawing.Size(734, 287)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmCIValoracionAlmacenFIFO"
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
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(734, 445)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(734, 445)
        '
        'txtStockHasta
        '
        Me.txtStockHasta.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockHasta.Location = New System.Drawing.Point(587, 56)
        Me.txtStockHasta.Name = "txtStockHasta"
        Me.txtStockHasta.Size = New System.Drawing.Size(120, 21)
        Me.txtStockHasta.TabIndex = 15
        '
        'lblfwiStockMenorQue
        '
        Me.lblfwiStockMenorQue.Location = New System.Drawing.Point(523, 60)
        Me.lblfwiStockMenorQue.Name = "lblfwiStockMenorQue"
        Me.lblfwiStockMenorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMenorQue.TabIndex = 0
        Me.lblfwiStockMenorQue.Tag = "IdRec=5264;"
        Me.lblfwiStockMenorQue.Text = "Stock <="
        '
        'txtStockDesde
        '
        Me.txtStockDesde.DisabledBackColor = System.Drawing.Color.White
        Me.txtStockDesde.Location = New System.Drawing.Point(587, 32)
        Me.txtStockDesde.Name = "txtStockDesde"
        Me.txtStockDesde.Size = New System.Drawing.Size(120, 21)
        Me.txtStockDesde.TabIndex = 14
        '
        'lblfwiStockMayorQue
        '
        Me.lblfwiStockMayorQue.Location = New System.Drawing.Point(523, 36)
        Me.lblfwiStockMayorQue.Name = "lblfwiStockMayorQue"
        Me.lblfwiStockMayorQue.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiStockMayorQue.TabIndex = 16
        Me.lblfwiStockMayorQue.Tag = "IdRec=5268;"
        Me.lblfwiStockMayorQue.Text = "Stock >="
        '
        'advSubfamilia
        '
        Me.advSubfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advSubfamilia.EntityName = "Subfamilia"
        Me.advSubfamilia.Location = New System.Drawing.Point(347, 80)
        Me.advSubfamilia.Name = "advSubfamilia"
        Me.advSubfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.advSubfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.advSubfamilia.Size = New System.Drawing.Size(136, 23)
        Me.advSubfamilia.TabIndex = 13
        Me.advSubfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(275, 85)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 17
        Me.lblfwiSubfamilia.Tag = "IdRec=4452;"
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(347, 56)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.PrimaryDataFields = "IDFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(136, 23)
        Me.advFamilia.TabIndex = 12
        Me.advFamilia.ViewName = "tbMaestroFamilia"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(275, 60)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 19
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'advAlmacen
        '
        Me.advAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advAlmacen.EntityName = "Almacen"
        Me.advAlmacen.Location = New System.Drawing.Point(99, 56)
        Me.advAlmacen.Name = "advAlmacen"
        Me.advAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.advAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advAlmacen.Size = New System.Drawing.Size(136, 23)
        Me.advAlmacen.TabIndex = 11
        Me.advAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(10, 60)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 21
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'advTipo
        '
        Me.advTipo.DisabledBackColor = System.Drawing.Color.White
        Me.advTipo.EntityName = "TipoArticulo"
        Me.advTipo.Location = New System.Drawing.Point(347, 32)
        Me.advTipo.Name = "advTipo"
        Me.advTipo.PrimaryDataFields = "IDTipo"
        Me.advTipo.SecondaryDataFields = "IDTipo"
        Me.advTipo.Size = New System.Drawing.Size(136, 23)
        Me.advTipo.TabIndex = 10
        Me.advTipo.ViewName = "tbMaestroTipoArticulo"
        '
        'lblfwiTipo
        '
        Me.lblfwiTipo.Location = New System.Drawing.Point(275, 36)
        Me.lblfwiTipo.Name = "lblfwiTipo"
        Me.lblfwiTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipo.TabIndex = 23
        Me.lblfwiTipo.Tag = "IdRec=4456;"
        Me.lblfwiTipo.Text = "Tipo"
        '
        'advArticulo
        '
        Me.advArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advArticulo.EntityName = "Articulo"
        Me.advArticulo.Location = New System.Drawing.Point(99, 32)
        Me.advArticulo.Name = "advArticulo"
        Me.advArticulo.PrimaryDataFields = "IDArticulo"
        Me.advArticulo.SecondaryDataFields = "IDArticulo"
        Me.advArticulo.Size = New System.Drawing.Size(136, 23)
        Me.advArticulo.TabIndex = 9
        Me.advArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(10, 36)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 25
        Me.lblfwiArticulo.Tag = "IdRec=4430;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'chkMonedaA
        '
        Me.chkMonedaA.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMonedaA.Location = New System.Drawing.Point(523, 80)
        Me.chkMonedaA.Name = "chkMonedaA"
        Me.chkMonedaA.Size = New System.Drawing.Size(96, 24)
        Me.chkMonedaA.TabIndex = 26
        Me.chkMonedaA.Text = "<moneda A>"
        '
        'chkMonedaB
        '
        Me.chkMonedaB.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMonedaB.Location = New System.Drawing.Point(627, 80)
        Me.chkMonedaB.Name = "chkMonedaB"
        Me.chkMonedaB.Size = New System.Drawing.Size(96, 24)
        Me.chkMonedaB.TabIndex = 27
        Me.chkMonedaB.Text = "<moneda B>"
        '
        'advIDArticuloPadre
        '
        Me.advIDArticuloPadre.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloPadre.EntityName = "Articulo"
        Me.advIDArticuloPadre.Location = New System.Drawing.Point(99, 80)
        Me.advIDArticuloPadre.Name = "advIDArticuloPadre"
        Me.advIDArticuloPadre.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloPadre.Size = New System.Drawing.Size(136, 23)
        Me.advIDArticuloPadre.TabIndex = 28
        Me.advIDArticuloPadre.ViewName = "tbMaestroArticulo"
        '
        'lblArticuloPadre
        '
        Me.lblArticuloPadre.Location = New System.Drawing.Point(10, 85)
        Me.lblArticuloPadre.Name = "lblArticuloPadre"
        Me.lblArticuloPadre.Size = New System.Drawing.Size(87, 13)
        Me.lblArticuloPadre.TabIndex = 29
        Me.lblArticuloPadre.Tag = ""
        Me.lblArticuloPadre.Text = "Artículo Padre"
        '
        'FrmTotales
        '
        Me.FrmTotales.Controls.Add(Me.NtbValorFIFO)
        Me.FrmTotales.Controls.Add(Me.LblValorFIFO)
        Me.FrmTotales.Controls.Add(Me.NtbValorMedio)
        Me.FrmTotales.Controls.Add(Me.LblValorMedio)
        Me.FrmTotales.Controls.Add(Me.NtbValorStd)
        Me.FrmTotales.Controls.Add(Me.LblValorStd)
        Me.FrmTotales.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FrmTotales.Location = New System.Drawing.Point(0, 287)
        Me.FrmTotales.Name = "FrmTotales"
        Me.FrmTotales.Size = New System.Drawing.Size(734, 46)
        Me.FrmTotales.TabIndex = 1
        Me.FrmTotales.TabStop = False
        Me.FrmTotales.Text = "Totales"
        Me.FrmTotales.Visible = False
        '
        'NtbValorFIFO
        '
        Me.NtbValorFIFO.DisabledBackColor = System.Drawing.Color.White
        Me.NtbValorFIFO.Enabled = False
        Me.NtbValorFIFO.Location = New System.Drawing.Point(623, 17)
        Me.NtbValorFIFO.Name = "NtbValorFIFO"
        Me.NtbValorFIFO.Size = New System.Drawing.Size(100, 21)
        Me.NtbValorFIFO.TabIndex = 5
        '
        'LblValorFIFO
        '
        Me.LblValorFIFO.Location = New System.Drawing.Point(550, 21)
        Me.LblValorFIFO.Name = "LblValorFIFO"
        Me.LblValorFIFO.Size = New System.Drawing.Size(66, 13)
        Me.LblValorFIFO.TabIndex = 4
        Me.LblValorFIFO.Text = "Valor FIFO"
        '
        'NtbValorMedio
        '
        Me.NtbValorMedio.DisabledBackColor = System.Drawing.Color.White
        Me.NtbValorMedio.Enabled = False
        Me.NtbValorMedio.Location = New System.Drawing.Point(444, 17)
        Me.NtbValorMedio.Name = "NtbValorMedio"
        Me.NtbValorMedio.Size = New System.Drawing.Size(100, 21)
        Me.NtbValorMedio.TabIndex = 3
        '
        'LblValorMedio
        '
        Me.LblValorMedio.Location = New System.Drawing.Point(364, 21)
        Me.LblValorMedio.Name = "LblValorMedio"
        Me.LblValorMedio.Size = New System.Drawing.Size(73, 13)
        Me.LblValorMedio.TabIndex = 2
        Me.LblValorMedio.Text = "Valor Medio"
        '
        'NtbValorStd
        '
        Me.NtbValorStd.DisabledBackColor = System.Drawing.Color.White
        Me.NtbValorStd.Enabled = False
        Me.NtbValorStd.Location = New System.Drawing.Point(258, 17)
        Me.NtbValorStd.Name = "NtbValorStd"
        Me.NtbValorStd.Size = New System.Drawing.Size(100, 21)
        Me.NtbValorStd.TabIndex = 1
        '
        'LblValorStd
        '
        Me.LblValorStd.Location = New System.Drawing.Point(161, 21)
        Me.LblValorStd.Name = "LblValorStd"
        Me.LblValorStd.Size = New System.Drawing.Size(90, 13)
        Me.LblValorStd.TabIndex = 0
        Me.LblValorStd.Text = "Valor Estándar"
        '
        'ValoracionFIFO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(742, 533)
        Me.EntityName = "TipoMovimiento"
        Me.Name = "ValoracionFIFO"
        Me.ViewName = "vFrmCIValoracionAlmacenFIFO"
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ValoracionFIFO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim Moneda As New Moneda

            mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, cnMinDate)
            mMonedaB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, cnMinDate)

            Grid.Columns("PrecioEstandarA").Caption = Grid.Columns("PrecioEstandarA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("ValorEstandarA").Caption = Grid.Columns("ValorEstandarA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("PrecioMedioA").Caption = Grid.Columns("PrecioMedioA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("ValorMedioA").Caption = Grid.Columns("ValorMedioA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("PrecioFIFOA").Caption = Grid.Columns("PrecioFIFOA").Caption & " (" & mMonedaA.Abreviatura & ")"
            Grid.Columns("ValorFIFOA").Caption = Grid.Columns("ValorFIFOA").Caption & " (" & mMonedaA.Abreviatura & ")"

            Grid.Columns("PrecioEstandarB").Caption = Grid.Columns("PrecioEstandarB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("ValorEstandarB").Caption = Grid.Columns("ValorEstandarB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("PrecioMedioB").Caption = Grid.Columns("PrecioMedioB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("ValorMedioB").Caption = Grid.Columns("ValorMedioB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("PrecioFIFOB").Caption = Grid.Columns("PrecioFIFOB").Caption & " (" & mMonedaB.Abreviatura & ")"
            Grid.Columns("ValorFIFOB").Caption = Grid.Columns("ValorFIFOB").Caption & " (" & mMonedaB.Abreviatura & ")"

            Grid.Columns("PrecioEstandarA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
            Grid.Columns("ValorEstandarA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
            Grid.Columns("PrecioMedioA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
            Grid.Columns("ValorMedioA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)
            Grid.Columns("PrecioFIFOA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesPrecio)
            Grid.Columns("ValorFIFOA").FormatString = FormatStringGenerator(mMonedaA.NDecimalesImporte)

            Grid.Columns("PrecioEstandarB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesPrecio)
            Grid.Columns("ValorEstandarB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesImporte)
            Grid.Columns("PrecioMedioB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesPrecio)
            Grid.Columns("ValorMedioB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesImporte)
            Grid.Columns("PrecioFIFOB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesPrecio)
            Grid.Columns("ValorFIFOB").FormatString = FormatStringGenerator(mMonedaB.NDecimalesImporte)

            Grid.Columns("PrecioEstandarA").AutoSize()
            Grid.Columns("ValorEstandarA").AutoSize()
            Grid.Columns("PrecioMedioA").AutoSize()
            Grid.Columns("ValorMedioA").AutoSize()
            Grid.Columns("PrecioFIFOA").AutoSize()
            Grid.Columns("ValorFIFOA").AutoSize()

            Grid.Columns("PrecioEstandarB").AutoSize()
            Grid.Columns("ValorEstandarB").AutoSize()
            Grid.Columns("PrecioMedioB").AutoSize()
            Grid.Columns("ValorMedioB").AutoSize()
            Grid.Columns("PrecioFIFOB").AutoSize()
            Grid.Columns("ValorFIFOB").AutoSize()

            'txtStockDesde.Text.Format("#,0.0###")
            'txtStockHasta.Text.Format("#,0.0###")

            chkMonedaA.Text = mMonedaA.Texto & "(" & mMonedaA.Abreviatura & ")"
            chkMonedaB.Text = mMonedaB.Texto & "(" & mMonedaB.Abreviatura & ")"

            chkMonedaA.Checked = True
            Grid.Columns("PrecioEstandarB").Visible = False
            Grid.Columns("ValorEstandarB").Visible = False
            Grid.Columns("PrecioMedioB").Visible = False
            Grid.Columns("ValorMedioB").Visible = False
            Grid.Columns("PrecioFIFOB").Visible = False
            Grid.Columns("ValorFIFOB").Visible = False

            Grid.Actions.Add(cnABRIRARTICULO, AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))

            Me.FormActions.Add("Mostrar Totales", AddressOf MostrarTotales, ExpertisApp.GetIcon("currency_euro.ico"))
            Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.True

            SettingDobleUnidad()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MostrarTotales()
        Me.Grid.DataSource = Nothing
        Dim FilFIFO As New Filter
        If Length(advArticulo.Text) > 0 Then FilFIFO.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
        If Length(advIDArticuloPadre.Text) > 0 Then FilFIFO.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        If Length(advAlmacen.Text) > 0 Then FilFIFO.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
        If Length(advTipo.Text) > 0 Then FilFIFO.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
        If Length(advFamilia.Text) > 0 Then FilFIFO.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
        If Length(advSubfamilia.Text) > 0 Then FilFIFO.Add("IDSubfamilia", FilterOperator.Equal, advSubfamilia.Text, FilterType.String)
        If Length(txtStockDesde.Text) > 0 Then FilFIFO.Add("StockFisico", FilterOperator.GreaterThanOrEqual, txtStockDesde.Text, FilterType.Numeric)
        If Length(txtStockHasta.Text) > 0 Then FilFIFO.Add("StockFisico", FilterOperator.LessThanOrEqual, txtStockHasta.Text, FilterType.Numeric)

        Dim DtTotales As DataTable = ExpertisApp.ExecuteTask(Of Filter, DataTable)(AddressOf Business.Negocio.ProcesoStocks.ObtenerValoracionActualFIFO, FilFIFO)

        Me.NtbValorStd.Value = DtTotales.Rows(0)("ValorEstandar")
        Me.NtbValorMedio.Value = DtTotales.Rows(0)("ValorMedio")
        Me.NtbValorFIFO.Value = DtTotales.Rows(0)("ValorFIFO")
        Me.FrmTotales.Visible = True
    End Sub

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad
        If Me.Grid.Columns.Contains("StockFisico2") Then
            Me.Grid.Columns("StockFisico2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("StockFisico2").Position = Me.Grid.Columns("StockFisico").Position + 1
        End If
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        If e.Row.RowType = RowType.TotalRow Then
            e.Row.RowStyle = Grid.FormatStyles("TotalRowFormatStyle2")
        ElseIf e.Row.RowType = RowType.Record Then
            If e.Row.Cells("StockFisico").Value < 0 Then
                e.Row.RowStyle = Grid.FormatStyles("StockNegativoFormatStyle")
            End If
        End If
    End Sub

    Protected Overrides Sub OnQueryExecuting(ByVal e As Engine.UI.QueryExecutingEventArgs)
        e.Filter.Add("IDArticulo", FilterOperator.Equal, advArticulo.Text, FilterType.String)
        e.Filter.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, advAlmacen.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, advTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, advFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, advSubfamilia.Text, FilterType.String)
        e.Filter.Add("StockFisico", FilterOperator.GreaterThanOrEqual, txtStockDesde.Text, FilterType.Numeric)
        e.Filter.Add("StockFisico", FilterOperator.LessThanOrEqual, txtStockHasta.Text, FilterType.Numeric)
    End Sub

    Private Sub advSubfamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advSubfamilia.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, advArticulo.Text))
        e.Filter.Add(New StringFilterItem("IDFamilia", FilterOperator.Equal, advFamilia.Text))
    End Sub

    Private Sub advFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advFamilia.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, advTipo.Text))
    End Sub

    Private Sub ValoracionFIFO_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        txtStockDesde.Text = Nothing
        txtStockHasta.Text = Nothing
    End Sub

    Protected Overrides Sub OnQueryExecuted(ByVal e As Engine.UI.QueryExecutedEventArgs)
        MyBase.OnQueryExecuted(e)
        If Not IsNothing(Grid.DataSource) Then
            Dim dt As DataTable = CType(Grid.DataSource, DataTable).Copy
            dt.Columns.Add("PrecioFIFOA", GetType(Double))
            dt.Columns.Add("PrecioFIFOB", GetType(Double))
            dt.Columns.Add("ValorFIFOA", GetType(Double))
            dt.Columns.Add("ValorFIFOB", GetType(Double))
            Grid.DataSource = dt
            If Me.FrmTotales.Visible Then
                Me.NtbValorStd.Value = Me.Grid.GetTotal(Me.Grid.Columns("ValorEstandarA"), AggregateFunction.Sum)
                Me.NtbValorMedio.Value = Me.Grid.GetTotal(Me.Grid.Columns("ValorMedioA"), AggregateFunction.Sum)
                Me.NtbValorFIFO.Value = Me.Grid.GetTotal(Me.Grid.Columns("ValorFIFOA"), AggregateFunction.Sum)
            End If
        End If
    End Sub

    Private Sub AccionValoracion(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ExecuteActions.Click
        If Grid.RecordCount > 0 Then
            Me.Cursor = Cursors.WaitCursor
            Dim data As DataTable = CType(Grid.DataSource, DataTable)
            Dim datosVal As New ProcesoStocks.DataValoracionAlmacenesFIFO(data)
            Grid.DataSource = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataValoracionAlmacenesFIFO, DataTable)(AddressOf ProcesoStocks.ValoracionAlmacenesFIFO, datosVal)
            Me.Cursor = Cursors.Default

            ExpertisApp.GenerateMessage("Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Resumen()

            Me.NtbValorFIFO.Value = Me.Grid.GetTotal(Me.Grid.Columns("ValorFIFOA"), AggregateFunction.Sum)
        End If
    End Sub

    'Private Sub FetchData(ByVal valoracion As ValoracionPreciosInfo())
    '    If Not valoracion Is Nothing AndAlso valoracion.Length > 0 Then
    '        Dim data As DataTable = CType(Grid.DataSource, DataTable)
    '        Dim f As New Filter
    '        Dim dv As DataView
    '        For Each valor As ValoracionPreciosInfo In valoracion
    '            f.Clear()
    '            f.Add(New StringFilterItem("IDArticulo", valor.IDArticulo))
    '            f.Add(New StringFilterItem("IDAlmacen", valor.IDAlmacen))
    '            dv = New DataView(data)
    '            dv.RowFilter = f.Compose(New AdoFilterComposer)
    '            If dv.Count > 0 Then
    '                dv(0).Row("PrecioFIFOA") = valor.PrecioA
    '                dv(0).Row("PrecioFIFOB") = valor.PrecioB
    '                dv(0).Row("ValorFIFOA") = valor.PrecioA * dv(0).Row("StockFisico")
    '                dv(0).Row("ValorFIFOB") = valor.PrecioB * dv(0).Row("StockFisico")
    '            End If
    '        Next
    '        Grid.Refetch()
    '    End If
    'End Sub

    Private Sub Resumen()
        Grid.Columns("ValorEstandarA").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ValorEstandarB").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ValorMedioA").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ValorMedioB").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ValorFIFOA").AggregateFunction = AggregateFunction.Sum
        Grid.Columns("ValorFIFOB").AggregateFunction = AggregateFunction.Sum

        Grid.Columns("ValorEstandarA").TotalFormatString = Grid.Columns("ValorEstandarA").FormatString
        Grid.Columns("ValorEstandarB").TotalFormatString = Grid.Columns("ValorEstandarB").FormatString
        Grid.Columns("ValorMedioA").TotalFormatString = Grid.Columns("ValorMedioA").FormatString
        Grid.Columns("ValorMedioB").TotalFormatString = Grid.Columns("ValorMedioB").FormatString
        Grid.Columns("ValorFIFOA").TotalFormatString = Grid.Columns("ValorFIFOA").FormatString
        Grid.Columns("ValorFIFOB").TotalFormatString = Grid.Columns("ValorFIFOB").FormatString

        Grid.TotalRow = InheritableBoolean.True
        Grid.Row = Grid.GetTotalRow.Position

        Grid.Columns("ValorEstandarA").AutoSize()
        Grid.Columns("ValorEstandarB").AutoSize()
        Grid.Columns("ValorMedioA").AutoSize()
        Grid.Columns("ValorMedioB").AutoSize()
        Grid.Columns("ValorFIFOA").AutoSize()
        Grid.Columns("ValorFIFOB").AutoSize()
    End Sub

    Private Sub ValoracionFIFO_SetReportDataSource(ByVal sender As Object, ByVal e As Engine.UI.ReportDataSourceEventArgs) Handles MyBase.SetReportDataSource
        Dim source As New DataTable
        source.Columns.Add("IDArticulo", GetType(String))
        source.Columns.Add("DescArticulo", GetType(String))
        source.Columns.Add("IDAlmacen", GetType(String))
        source.Columns.Add("DescAlmacen", GetType(String))
        source.Columns.Add("StockFisico", GetType(Double))
        source.Columns.Add("PrecioEstandar", GetType(Double))
        source.Columns.Add("ValorEstandar", GetType(Double))
        source.Columns.Add("PrecioMedio", GetType(Double))
        source.Columns.Add("ValorMedio", GetType(Double))
        source.Columns.Add("PrecioFIFO", GetType(Double))
        source.Columns.Add("ValorFIFO", GetType(Double))

        Dim dt As DataTable = CType(Grid.DataSource, DataTable)
        If Not IsNothing(dt) Then
            For Each row As DataRow In dt.Rows
                Dim newrow As DataRow = source.NewRow
                newrow("IDArticulo") = row("IDArticulo")
                newrow("DescArticulo") = row("DescArticulo")
                newrow("IDAlmacen") = row("IDAlmacen")
                newrow("DescAlmacen") = row("DescAlmacen")
                newrow("StockFisico") = row("StockFisico")
                If mEsMonedaA Then
                    newrow("PrecioEstandar") = row("PrecioEstandarA")
                    newrow("ValorEstandar") = row("ValorEstandarA")
                    newrow("PrecioMedio") = row("PrecioMedioA")
                    newrow("ValorMedio") = row("ValorMedioA")
                    newrow("PrecioFIFO") = row("PrecioFIFOA")
                    newrow("ValorFIFO") = row("ValorFIFOA")
                Else
                    newrow("PrecioEstandar") = row("PrecioEstandarB")
                    newrow("ValorEstandar") = row("ValorEstandarB")
                    newrow("PrecioMedio") = row("PrecioMedioB")
                    newrow("ValorMedio") = row("ValorMedioB")
                    newrow("PrecioFIFO") = row("PrecioFIFOB")
                    newrow("ValorFIFO") = row("ValorFIFOB")
                End If
            Next
        End If
    End Sub

    Private Sub ValoracionFIFO_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Dim frm As New SeleccionMoneda
        frm.optMonedaA.Text = mMonedaA.Texto
        frm.optMonedaB.Text = mMonedaB.Texto

        If frm.ShowDialog() = DialogResult.OK Then
            mEsMonedaA = frm.MonedaA
            If mEsMonedaA Then
                e.Formulas("Moneda").Text = mMonedaA.Texto
            Else
                e.Formulas("Moneda").Text = mMonedaB.Texto
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub chkMonedaA_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMonedaA.CheckedChanged
        Grid.Columns("PrecioEstandarA").Visible = chkMonedaA.Checked
        Grid.Columns("ValorEstandarA").Visible = chkMonedaA.Checked
        Grid.Columns("PrecioMedioA").Visible = chkMonedaA.Checked
        Grid.Columns("ValorMedioA").Visible = chkMonedaA.Checked
        Grid.Columns("PrecioFIFOA").Visible = chkMonedaA.Checked
        Grid.Columns("ValorFIFOA").Visible = chkMonedaA.Checked
    End Sub

    Private Sub chkMonedaB_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMonedaB.CheckedChanged
        Grid.Columns("PrecioEstandarB").Visible = chkMonedaB.Checked
        Grid.Columns("ValorEstandarB").Visible = chkMonedaB.Checked
        Grid.Columns("PrecioMedioB").Visible = chkMonedaB.Checked
        Grid.Columns("ValorMedioB").Visible = chkMonedaB.Checked
        Grid.Columns("PrecioFIFOB").Visible = chkMonedaB.Checked
        Grid.Columns("ValorFIFOB").Visible = chkMonedaB.Checked
    End Sub

    Private Sub CargarMantenimientoArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub
End Class
