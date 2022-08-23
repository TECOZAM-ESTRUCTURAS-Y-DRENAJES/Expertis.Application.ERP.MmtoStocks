Public Class MovimientoManual
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

    Private mblnStkDobleUnidad As Boolean
    Private mMonedaA As MonedaInfo
    Private mMonedaB As MonedaInfo
    Private mCurrentData As DataTable
    'Private mRestoreID As Long
    Private Const mcNavigationField As String = "IDMovimiento"
    Private mEnlace As Long
    Private HT As Hashtable
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

    Private mblnGestionInvPermanente As Boolean
    Private Const cnCONTABILIZAR As String = "Contabilizar Movimientos"
    Private Const cnDESCONTABILIZAR As String = "Descontabilizar Movimientos"
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button

    Private mSeries As ERP.CommonClasses.NSerieStockableUserDialogIN

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        Me.NavigationFields = mcNavigationField

        '//GESTION NUMEROS DE SERIE
        mSeries = New ERP.CommonClasses.NSerieStockableUserDialogIN
        mSeries.Text = "MOVIMIENTOS MANUALES"
        mSeries.DataSource = Me.grdMovimientos
        mSeries.DataSchema.Cantidad = "Cantidad"
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
    Public WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents lblfwiFechaDoc As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents lblcfwiTipoMov As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Public WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxFechaDocumento As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents txtNumeroMovimiento As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents cboTipoMovimiento As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents grdMovimientos As Solmicro.Expertis.Engine.UI.Grid
    Public WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents chkMostrarCorrecciones As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MovimientoManual))
        Dim cboTipoMovimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim grdMovimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFechaDoc = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDocumento = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.txtNumeroMovimiento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.lblcfwiTipoMov = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.cboTipoMovimiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.grdMovimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkMostrarCorrecciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.Frame1.SuspendLayout()
        CType(Me.cboTipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Duplicate.Icon = CType(resources.GetObject("Duplicate.Icon"), System.Drawing.Icon)
        Me.Duplicate.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(643, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 39)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'GoFirst
        '
        Me.GoFirst.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoFirst.Icon = CType(resources.GetObject("GoFirst.Icon"), System.Drawing.Icon)
        '
        'GoPrevious
        '
        Me.GoPrevious.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.GoPrevious.Icon = CType(resources.GetObject("GoPrevious.Icon"), System.Drawing.Icon)
        '
        'GoNext
        '
        Me.GoNext.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.GoNext.Icon = CType(resources.GetObject("GoNext.Icon"), System.Drawing.Icon)
        '
        'Delete
        '
        Me.Delete.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Delete.Icon = CType(resources.GetObject("Delete.Icon"), System.Drawing.Icon)
        Me.Delete.Text = ""
        Me.Delete.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Ok
        '
        Me.Ok.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Ok.Icon = CType(resources.GetObject("Ok.Icon"), System.Drawing.Icon)
        Me.Ok.Text = ""
        '
        'Cancel
        '
        Me.Cancel.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Cancel.Icon = CType(resources.GetObject("Cancel.Icon"), System.Drawing.Icon)
        Me.Cancel.Text = ""
        '
        'Print
        '
        Me.Print.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Print.Icon = CType(resources.GetObject("Print.Icon"), System.Drawing.Icon)
        Me.Print.Text = ""
        Me.Print.Visible = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Search
        '
        Me.Search.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Search.Icon = CType(resources.GetObject("Search.Icon"), System.Drawing.Icon)
        Me.Search.Text = ""
        Me.Search.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'GoLast
        '
        Me.GoLast.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.GoLast.Icon = CType(resources.GetObject("GoLast.Icon"), System.Drawing.Icon)
        '
        'FindText
        '
        Me.FindText.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'Find
        '
        Me.Find.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.Find.Icon = CType(resources.GetObject("Find.Icon"), System.Drawing.Icon)
        Me.Find.Text = ""
        Me.Find.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'NewRow
        '
        Me.NewRow.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        Me.NewRow.Icon = CType(resources.GetObject("NewRow.Icon"), System.Drawing.Icon)
        Me.NewRow.Text = ""
        '
        'Requery
        '
        Me.Requery.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.Requery.Icon = CType(resources.GetObject("Requery.Icon"), System.Drawing.Icon)
        Me.Requery.Text = ""
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.[False]
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        Me.ExecuteActions.Text = ""
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Panel2)
        Me.MainPanel.Controls.Add(Me.Panel1)
        Me.MainPanel.Controls.Add(Me.Frame2)
        Me.MainPanel.Controls.Add(Me.Frame1)
        Me.MainPanel.Size = New System.Drawing.Size(737, 401)
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.Button1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.lblfwiAlmacen)
        Me.Frame1.Controls.Add(Me.lblfwiFechaDoc)
        Me.Frame1.Controls.Add(Me.cbxFechaDocumento)
        Me.Frame1.Controls.Add(Me.txtNumeroMovimiento)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(737, 51)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        Me.Frame1.Tag = "IdRec=0;"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(597, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CargaDatos"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(354, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nº Movimiento"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(331, 39)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiAlmacen.TabIndex = 0
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        '
        'lblfwiFechaDoc
        '
        Me.lblfwiFechaDoc.Location = New System.Drawing.Point(331, 15)
        Me.lblfwiFechaDoc.Name = "lblfwiFechaDoc"
        Me.lblfwiFechaDoc.Size = New System.Drawing.Size(0, 13)
        Me.lblfwiFechaDoc.TabIndex = 7
        Me.lblfwiFechaDoc.Tag = "IdRec=5256;"
        '
        'cbxFechaDocumento
        '
        Me.cbxFechaDocumento.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDocumento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbxFechaDocumento.Location = New System.Drawing.Point(417, 15)
        Me.cbxFechaDocumento.Name = "cbxFechaDocumento"
        Me.cbxFechaDocumento.Size = New System.Drawing.Size(114, 21)
        Me.cbxFechaDocumento.TabIndex = 5
        '
        'txtNumeroMovimiento
        '
        Me.txtNumeroMovimiento.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroMovimiento.Location = New System.Drawing.Point(99, 15)
        Me.txtNumeroMovimiento.Name = "txtNumeroMovimiento"
        Me.txtNumeroMovimiento.ReadOnly = True
        Me.txtNumeroMovimiento.Size = New System.Drawing.Size(132, 21)
        Me.txtNumeroMovimiento.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(354, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Almacén"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tipo de movimiento"
        '
        'lblcfwiAlmacen
        '
        Me.TryDataBinding(lblcfwiAlmacen, New System.Windows.Forms.Binding("Text", Me.AdvAlmacen, "DescAlmacen", True))
        Me.lblcfwiAlmacen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcfwiAlmacen.Location = New System.Drawing.Point(534, 15)
        Me.lblcfwiAlmacen.Name = "lblcfwiAlmacen"
        Me.lblcfwiAlmacen.Size = New System.Drawing.Size(195, 21)
        Me.lblcfwiAlmacen.TabIndex = 1
        '
        'lblcfwiTipoMov
        '
        Me.TryDataBinding(lblcfwiTipoMov, New System.Windows.Forms.Binding("Text", Me.cboTipoMovimiento, "DescTipoMovimiento", True))
        Me.lblcfwiTipoMov.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblcfwiTipoMov.Location = New System.Drawing.Point(198, 15)
        Me.lblcfwiTipoMov.Name = "lblcfwiTipoMov"
        Me.lblcfwiTipoMov.Size = New System.Drawing.Size(150, 21)
        Me.lblcfwiTipoMov.TabIndex = 8
        '
        'cboTipoMovimiento
        '
        cboTipoMovimiento_DesignTimeLayout.LayoutString = resources.GetString("cboTipoMovimiento_DesignTimeLayout.LayoutString")
        Me.cboTipoMovimiento.DesignTimeLayout = cboTipoMovimiento_DesignTimeLayout
        Me.cboTipoMovimiento.DisabledBackColor = System.Drawing.Color.White
        Me.cboTipoMovimiento.DisplayMember = "CodTipoMovimiento"
        Me.cboTipoMovimiento.EntityName = "TipoMovimiento"
        Me.cboTipoMovimiento.Location = New System.Drawing.Point(132, 15)
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        Me.cboTipoMovimiento.PrimaryDataFields = "IDTipoMovimiento"
        Me.cboTipoMovimiento.SecondaryDataFields = "IDTipoMovimiento"
        Me.cboTipoMovimiento.SelectedIndex = -1
        Me.cboTipoMovimiento.SelectedItem = Nothing
        Me.cboTipoMovimiento.Size = New System.Drawing.Size(63, 21)
        Me.cboTipoMovimiento.TabIndex = 3
        Me.cboTipoMovimiento.ValueMember = "IDTipoMovimiento"
        Me.cboTipoMovimiento.ViewName = "tbMaestroTipoMovimiento"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.AdvAlmacen)
        Me.Frame2.Controls.Add(Me.lblcfwiTipoMov)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.lblcfwiAlmacen)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.cboTipoMovimiento)
        Me.Frame2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame2.Location = New System.Drawing.Point(0, 51)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(737, 48)
        Me.Frame2.TabIndex = 5
        Me.Frame2.TabStop = False
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescAlmacen", lblcfwiAlmacen)})
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.DisplayField = "IDAlmacen"
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(417, 15)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(114, 23)
        Me.AdvAlmacen.TabIndex = 13
        Me.AdvAlmacen.ViewName = "advAlmacen"
        '
        'grdMovimientos
        '
        Me.grdMovimientos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescArticulo", "DescArticulo"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("GestionStockPorLotes", "GestionStockPorLotes"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("NSerieObligatorio", "NSerieObligatorio"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("CriterioValoracion", "CriterioValoracion")}), "advArticuloStock"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDAlmacen", "Almacen", "IDAlmacen", "advAlmacen"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Lote", "ArticuloAlmacenLote", "Lote"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("Ubicacion", "AlmacenUbicacion", "IDUbicacion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDObra", "ObraCabecera", "IDObra"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("OperarioGeneral", "Operario", "IDOperario"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("DescAlmacen", Nothing, "DescAlmacen")})
        Me.grdMovimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grdMovimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        grdMovimientos_DesignTimeLayout.LayoutString = resources.GetString("grdMovimientos_DesignTimeLayout.LayoutString")
        Me.grdMovimientos.DesignTimeLayout = grdMovimientos_DesignTimeLayout
        Me.grdMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdMovimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.grdMovimientos.EntityName = ""
        Me.grdMovimientos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.grdMovimientos.ImageList = Me.ImageList1
        Me.grdMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.grdMovimientos.Name = "grdMovimientos"
        Me.grdMovimientos.PrimaryDataFields = ""
        Me.grdMovimientos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.grdMovimientos.SecondaryDataFields = ""
        Me.grdMovimientos.Size = New System.Drawing.Size(737, 263)
        Me.grdMovimientos.TabIndex = 6
        Me.grdMovimientos.Tag = "IdRec=5484:5250:4377:4379:4390:5968:7240:5265:4739:4498:4385:4385:8564:4548:12641" & _
            ":4469:12612:;"
        Me.grdMovimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.grdMovimientos.ViewName = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BarCode.ico")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chkMostrarCorrecciones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 362)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 39)
        Me.Panel1.TabIndex = 7
        '
        'chkMostrarCorrecciones
        '
        Me.chkMostrarCorrecciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMostrarCorrecciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMostrarCorrecciones.Checked = True
        Me.chkMostrarCorrecciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostrarCorrecciones.Location = New System.Drawing.Point(504, 12)
        Me.chkMostrarCorrecciones.Name = "chkMostrarCorrecciones"
        Me.chkMostrarCorrecciones.Size = New System.Drawing.Size(225, 18)
        Me.chkMostrarCorrecciones.TabIndex = 0
        Me.chkMostrarCorrecciones.Text = "Mostrar movimientos de corrección"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.grdMovimientos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(737, 263)
        Me.Panel2.TabIndex = 8
        '
        'MovimientoManual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(745, 474)
        Me.Name = "MovimientoManual"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cboTipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.grdMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub MovimientoManual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            SettingDobleUnidad()
            LoadERPData()
            SettingGrid()
            LoadFormActions()
            LoadEnums()

            If Not Me.Params Is Nothing Then
                HT = Me.Params
                Me.GotoRecord(DataProviderActions.GoRecord)
            End If
        End If
    End Sub

    Private Sub SettingGrid()
        Dim moneda As New Moneda
        mMonedaA = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf moneda.MonedaA, cnMinDate)
        mMonedaB = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf moneda.MonedaB, cnMinDate)
        grdMovimientos.Columns("PrecioA").Caption = grdMovimientos.Columns("PrecioA").Caption & " (" & mMonedaA.Abreviatura & ")"
        grdMovimientos.Columns("PrecioB").Caption = grdMovimientos.Columns("PrecioB").Caption & " (" & mMonedaB.Abreviatura & ")"
        grdMovimientos.Columns("Cantidad").DefaultValue = 0
        grdMovimientos.Columns("PrecioA").DefaultValue = 0
        grdMovimientos.Columns("PrecioB").DefaultValue = 0

        Dim f1 As New Filter
        f1.Add(New BooleanFilterItem("Manual", True))
        cboTipoMovimiento.Filter = f1
        Dim tipoMovimiento As New Business.Negocio.TipoMovimiento
        Dim tipos As DataTable = tipoMovimiento.Filter(f1)
        grdMovimientos.Columns("IDTipoMovimiento").DropDown.SetDataBinding(tipos, Nothing)
        Me.cboTipoMovimiento.DropDownList.SetDataBinding(tipos, Nothing)
        grdMovimientos.Columns("IDTipoMovimiento").EditType = EditType.NoEdit
        grdMovimientos.Columns("IDTipoMovimiento").ButtonStyle = ButtonStyle.NoButton

        Dim f2 As New Filter
        f2.Add(New BooleanFilterItem("Activo", True))
        AdvAlmacen.PredefinedFilter = f2
        grdMovimientos.AdvSearchColumns("IDAlmacen").Filter = f2

        If mblnGestionInvPermanente Then
            grdMovimientos.Columns("CCStocks").Visible = mblnGestionInvPermanente
            grdMovimientos.Columns("Contabilizado").Visible = mblnGestionInvPermanente
        End If
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mblnGestionInvPermanente = p.GestionInventarioPermanente
    End Sub

    Private Sub LoadFormActions()
        If mblnGestionInvPermanente Then
            Me.UiCommandManager1.Commands("ExecuteActions").IsVisible = True
            Me.FormActions.Add(cnCONTABILIZAR, AddressOf AccionContabilizar)
            Me.FormActions.Add(cnDESCONTABILIZAR, AddressOf AccionDescontabilizar)
        Else
            Me.UiCommandManager1.Commands("ExecuteActions").IsVisible = False
        End If
    End Sub

    Private Sub LoadEnums()
        If mblnGestionInvPermanente Then EnumData.PopulateValueList("enumContabilizado", grdMovimientos.Columns("Contabilizado"))
    End Sub


#Region " Contabilización "

    Private Sub AccionContabilizar()
        'c("Contabilizado") <> enumContabilizado.Contabilizado AndAlso _
        Dim LineasContabilizar As List(Of DataRow) = (From c In CType(Me.grdMovimientos.DataSource, DataTable) _
                                                       Where Not c.IsNull("Contabilizado") AndAlso _
                                                            Nz(c("Contabilizado"), enumContabilizado.NoContabilizado) <> enumContabilizado.Contabilizado OrElse _
                                                              ((Length(c("QPdteContabilizarNIIF")) > 0 AndAlso c("QPdteContabilizarNIIF") <> 0) OrElse _
                                                               (Length(c("QPdteContabilizarTrib")) > 0 AndAlso c("QPdteContabilizarTrib") <> 0)) AndAlso _
                                                             c("IDTipoMovimiento") <> enumTipoMovimiento.tmEntAlbaranCompra AndAlso _
                                                             c("IDTipoMovimiento") <> enumTipoMovimiento.tmSalAlbaranVenta AndAlso _
                                                             c("IDTipoMovimiento") <> enumTipoMovimiento.tmInventario AndAlso _
                                                             c("IDTipoMovimiento") <> enumTipoMovimiento.tmCorreccion AndAlso _
                                                             c("Manual") <> False AndAlso _
                                                             c("Contabilizar") <> False).ToList()
        If LineasContabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No hay lineas para contabilizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim IDLineasMovimiento(-1) As Integer
            For Each drLinea As DataRow In LineasContabilizar
                ReDim Preserve IDLineasMovimiento(IDLineasMovimiento.Length)
                IDLineasMovimiento(IDLineasMovimiento.Length - 1) = drLinea("IDLineaMovimiento")
            Next

            Dim SimInfo As New DataSimulacionContableInfoStocks(enumTipoContabilizacion.tcMovtosManuales, IDLineasMovimiento)
            SimInfo.Caption = "Simulación Contable - MOVIMIENTOS MANUALES -"
            Dim oFrm As Form = ExpertisApp.OpenForm("CISIMUCONT", , SimInfo, Me)
            AddHandler oFrm.Closed, AddressOf FrmActionClosed
        End If
    End Sub

    Private Sub FrmActionClosed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Closed, AddressOf FrmActionClosed
        Me.Requery.InvokeOnClick()
    End Sub

    Private Sub AccionDescontabilizar()
        Dim LineasDescontabilizar As List(Of Object) = (From c In CType(Me.grdMovimientos.DataSource, DataTable) _
                                                         Where Not c.IsNull("Contabilizado") AndAlso _
                                                            c("Contabilizado") <> enumContabilizado.NoContabilizado AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmEntAlbaranCompra AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmSalAlbaranVenta AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmInventario AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmCorreccion AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmEntFabrica AndAlso _
                                                            c("IDTipoMovimiento") <> enumTipoMovimiento.tmSalFabrica AndAlso _
                                                            c("Manual") <> False AndAlso _
                                                            c("Contabilizar") <> False _
                                                        Select c("IDLineaMovimiento") Distinct).ToList()
        If LineasDescontabilizar.Count = 0 Then
            ExpertisApp.GenerateMessage("No hay lineas para Descontabilizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim frm As New frmDescontabilizar
            frm.LineasMovimiento = LineasDescontabilizar
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.Requery.InvokeOnClick()
            End If
        End If
    End Sub


#End Region

    Private Sub SettingDobleUnidad()
        mblnStkDobleUnidad = New Parametro().GestionDobleUnidad
        If grdMovimientos.Columns.Contains("Cantidad2") Then
            grdMovimientos.Columns("Cantidad2").Visible = mblnStkDobleUnidad
            grdMovimientos.Columns("Cantidad2").Position = grdMovimientos.Columns("Cantidad").Position + 1

            If Me.grdMovimientos.Columns("Cantidad2").Visible Then
                Me.grdMovimientos.Columns("Cantidad2").CellStyle.FontBold = Janus.Windows.GridEX.TriState.True
                Me.grdMovimientos.Columns("Cantidad2").CellStyle.ForeColor = Color.Red
            End If
        End If
    End Sub
    Protected Overrides Sub OnNavigating(ByVal e As Engine.UI.NavigatingEventArgs)
        If e.Action <> DataProviderActions.NewRecord Then
            Dim NumeroMovimiento As Long = -1
            Dim myAction As DataProviderActions
            Dim f As New Filter

            '//NOTA: FindText funciona porque en el New se ha puesto Me.NavigaionFields

            '//Cuando se presiona 'Enter' en FindText se lanza OnNavigating con e.Action=GoFirst ?????
            If e.Action = DataProviderActions.GoFirst And Len(FindText.GetTextBox.Text) > 0 Then
                myAction = DataProviderActions.GoRecord
            Else
                myAction = e.Action
            End If
            '//

            If myAction = DataProviderActions.GoRecord Or myAction = DataProviderActions.Refresh Then
                If myAction = DataProviderActions.GoRecord Then
                    If IsNumeric(FindText.GetTextBox.Text) Then
                        NumeroMovimiento = CLng(FindText.GetTextBox.Text)
                    ElseIf IsNumeric(txtNumeroMovimiento.Text) Then
                        NumeroMovimiento = CLng(txtNumeroMovimiento.Text)
                    End If
                ElseIf myAction = DataProviderActions.Refresh Then
                    If IsNumeric(txtNumeroMovimiento.Text) Then
                        NumeroMovimiento = CLng(txtNumeroMovimiento.Text)
                    End If
                End If
                If Not HT Is Nothing Then
                    NumeroMovimiento = HT("IDMovimiento")
                End If

                Dim auxData As DataTable = Me.RetrieveData(NumeroMovimiento)
                If Not auxData Is Nothing AndAlso auxData.Rows.Count > 0 Then
                    mCurrentData = auxData.Copy
                Else
                    ExpertisApp.GenerateMessage("El movimiento no existe o se ha eliminado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                If IsNumeric(txtNumeroMovimiento.Text) Then
                    NumeroMovimiento = CLng(txtNumeroMovimiento.Text)
                End If

                Dim sqlSelect As String = "top 1 " & mcNavigationField
                Dim sqlWhere As String = ""
                Dim sqlOrderBy As String = ""
                Select Case e.Action
                    Case DataProviderActions.GoFirst
                        sqlWhere = String.Empty
                    Case DataProviderActions.GoLast
                        sqlWhere = String.Empty
                        sqlOrderBy = "tbHistoricoMovimiento." & mcNavigationField & " DESC"
                    Case DataProviderActions.GoNext
                        If NumeroMovimiento >= 0 Then
                            f.Add(mcNavigationField, FilterOperator.GreaterThan, NumeroMovimiento)
                        End If
                    Case DataProviderActions.GoPrevious
                        If NumeroMovimiento >= 0 Then
                            f.Add(mcNavigationField, FilterOperator.LessThan, NumeroMovimiento)
                        End If
                        sqlOrderBy = "tbHistoricoMovimiento." & mcNavigationField & " DESC"
                End Select

                Dim be As New BE.DataEngine
                Dim auxData As DataTable = be.Filter("tbHistoricoMovimiento", f)
                If Not auxData Is Nothing AndAlso auxData.Rows.Count > 0 Then
                    mCurrentData = Me.RetrieveData(auxData.Rows(0)(mcNavigationField))
                End If
            End If

            If Not mCurrentData Is Nothing Then
                If mCurrentData.Rows.Count > 0 Then
                    Me.RecordsState = RecordsState.Saved
                    MyBase.OnNavigated(New NavigatedEventArgs(e.Action))
                End If
            End If

            '//Cancelar siempre: en este mantenimiento en particular no interesa lo que se ejecuta despues de OnNavigating,
            '//de hecho da error si queremos que funcione lo de FindText.

            e.Cancel = True
            FindText.GetTextBox.Text = Nothing
            HT = Nothing
        End If
    End Sub

    Private Shadows Function RetrieveData(ByVal NumeroMovimiento As Long) As DataTable
        Dim sqlWhere As String
        Dim sqlOrderBy As String
        Dim auxData As DataTable = Nothing
        Dim f As New Filter
        If NumeroMovimiento >= 0 Then
            sqlWhere = mcNavigationField & "=" & NumeroMovimiento
            If Not chkMostrarCorrecciones.Checked Then
                sqlWhere = sqlWhere & " AND IDTipoMovimiento<>" & enumTipoMovimiento.tmCorreccion
            End If
            sqlOrderBy = "IDLineaMovimiento"

            Dim be As New BE.DataEngine
            f.Add("IDTipoMovimiento", FilterOperator.NotEqual, enumTipoMovimiento.tmCorreccion)
            auxData = be.Filter("vFrmMovimientoStock", f)
        End If
        Return auxData
    End Function

    Private Sub MovimientoManual_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        Binding()
        VisibilidadColumnaNSerie()
    End Sub

    Private Sub Binding()
        'mRestoreID = -1
        If Not mCurrentData Is Nothing Then
            If mCurrentData.Rows.Count > 0 Then
                txtNumeroMovimiento.Text = mCurrentData.Rows(0)(mcNavigationField)
                cbxFechaDocumento.Value = mCurrentData.Rows(0)("FechaDocumento")
                cboTipoMovimiento.Value = Nothing
                AdvAlmacen.Value = Nothing
                'mRestoreID = CLng(txtNumeroMovimiento.Text)
            End If
        End If
        grdMovimientos.DataSource = mCurrentData
    End Sub

    Protected Overrides Sub OnRecordAdding(ByVal e As System.ComponentModel.CancelEventArgs)
        ClearControls()
        mCurrentData = Nothing
    End Sub

    Protected Overrides Sub OnRecordAdded(ByVal e As System.EventArgs)
        Dim NumeroMovimiento As Integer = ExpertisApp.ExecuteTask(Of Object, Integer)(AddressOf ProcesoStocks.NuevoNumeroMovimiento, Nothing)
        If NumeroMovimiento >= 0 Then
            txtNumeroMovimiento.Text = NumeroMovimiento
            cbxFechaDocumento.Value = Today
            Dim be As New BE.DataEngine
            mCurrentData = be.Filter("vFrmMovimientoStock", New NoRowsFilterItem)
            grdMovimientos.DataSource = mCurrentData
            Me.RecordsState = RecordsState.[New]
        End If
    End Sub

    Private Sub ClearControls()
        txtNumeroMovimiento.Text = Nothing
        cbxFechaDocumento.Value = Nothing
        AdvAlmacen.Value = Nothing
        cboTipoMovimiento.Value = Nothing
        grdMovimientos.DataSource = Nothing
        grdMovimientos.Columns("IDTipoMovimiento").DefaultValue = Nothing
        grdMovimientos.Columns("IDAlmacen").DefaultValue = Nothing
    End Sub

    Private Sub MovimientoManual_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        ControlState()
    End Sub

    Private Sub ControlState()
        Select Case Me.RecordsState
            Case RecordsState.Saved
                cbxFechaDocumento.ReadOnly = True
                cboTipoMovimiento.Enabled = False
                AdvAlmacen.Enabled = False
                grdMovimientos.AllowAddNew = InheritableBoolean.False
                grdMovimientos.AllowDelete = InheritableBoolean.False
                grdMovimientos.Columns("CodTipoMovimiento").Visible = True
                grdMovimientos.Columns("IDTipoMovimiento").Visible = False
                chkMostrarCorrecciones.Enabled = True
            Case RecordsState.[New]
                Me.MainPanel.Enabled = True
                cbxFechaDocumento.ReadOnly = False
                cboTipoMovimiento.Enabled = True
                AdvAlmacen.Enabled = True
                grdMovimientos.AllowAddNew = InheritableBoolean.True
                grdMovimientos.AllowDelete = InheritableBoolean.True
                grdMovimientos.Columns("CodTipoMovimiento").Visible = False
                grdMovimientos.Columns("IDTipoMovimiento").Visible = True
                chkMostrarCorrecciones.Enabled = False
        End Select
    End Sub

    Private Function DatosValidos() As Boolean
        If DatosCabeceraValidos() Then
            If DatosGridValidos() Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Function DatosCabeceraValidos() As Boolean
        If Not IsNumeric(txtNumeroMovimiento.Text) Then
            ExpertisApp.GenerateMessage("El número de movimiento no es válido.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        ElseIf Not IsDate(cbxFechaDocumento.Value) Then
            ExpertisApp.GenerateMessage("La fecha de documento no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function DatosGridValidos() As Boolean
        For Each row As GridEXRow In grdMovimientos.GetRows
            If Not DatosGridValidos(row) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function DatosGridValidos(ByVal row As GridEXRow) As Boolean
        If Not row Is Nothing Then
            If Length(row.Cells("IDTipoMovimiento").Value) = 0 Then
                ExpertisApp.GenerateMessage("El tipo de movimiento es obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            ElseIf Length(row.Cells("IDArticulo").Value) = 0 Then
                ExpertisApp.GenerateMessage("El artículo es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            ElseIf Length(row.Cells("IDAlmacen").Value) = 0 Then
                ExpertisApp.GenerateMessage("El almacén es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            If Length(row.Cells("GestionStockPorLotes").Value) = 0 Then
                If Length(row.Cells("Lote").Value) = 0 Then
                    ExpertisApp.GenerateMessage("El lote es obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                ElseIf Length(row.Cells("Ubicacion").Value) = 0 Then
                    ExpertisApp.GenerateMessage("La ubicación es obligatoria.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If
            Return True
        End If
    End Function

    Private Sub grdMovimientos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMovimientos.Click
        Dim c As GridEXColumn = grdMovimientos.ColumnFromPoint()
        If Not c Is Nothing Then
            Dim hit As GridArea = grdMovimientos.HitTest()
            If hit = GridArea.Cell OrElse hit = GridArea.NewRowCell Then
                Select Case c.Key
                    Case "Series"
                        AbrirNumerosSerie()
                End Select
            End If
        End If
    End Sub

    Private Sub AbrirNumerosSerie()
        If Nz(grdMovimientos.GetValue("NSerieObligatorio"), False) Then
            If grdMovimientos.Row <> Grid.newTopRowPosition Then
                If Length(grdMovimientos.GetValue("IDArticulo")) > 0 AndAlso Length(grdMovimientos.GetValue("Lote")) > 0 Then
                    Dim FrmNSerie As New NSerieSituacion(grdMovimientos.GetValue("IDArticulo"))
                    FrmNSerie.ShowDialog()
                ElseIf Length(grdMovimientos.GetValue("IDArticulo")) > 0 AndAlso Length(grdMovimientos.GetValue("IDAlmacen")) > 0 AndAlso Length(grdMovimientos.GetValue("Lote")) = 0 Then
                    If Length(grdMovimientos.GetValue("IDArticulo")) > 0 Then
                        If mSeries.ShowDialog(CStr(grdMovimientos.GetValue("IDArticulo"))) = DialogResult.OK Then
                            NumerosDeSerie()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub grdMovimientos_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMovimientos.RecordAdded
        VisibilidadColumnaNSerie()
    End Sub

    Private Sub grdMovimientos_UpdatingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles grdMovimientos.UpdatingCell
        Try
            Select Case e.Column.Key
                Case "IDTipoMovimiento"
                    If Length(e.Value) > 0 Then
                        Dim claseMovimiento As enumtpmTipoMovimiento = Me.ClaseMovimiento(e.Value)
                        grdMovimientos.SetValue("ClaseMovimiento", claseMovimiento)
                    End If
                Case "IDArticulo"
                    If Nz(e.Value) <> Nz(e.InitialValue) And Not Nz(e.InitialValue) Is Nothing Then
                        grdMovimientos.SetValue("IDAlmacen", Nothing)
                        grdMovimientos.SetValue("Lote", Nothing)
                        grdMovimientos.SetValue("Ubicacion", Nothing)
                        grdMovimientos.SetValue("PrecioA", 0)
                        grdMovimientos.SetValue("PrecioB", 0)
                    End If
                Case "IDAlmacen"
                    If Nz(e.Value) <> Nz(e.InitialValue) And Not Nz(e.InitialValue) Is Nothing Then
                        grdMovimientos.SetValue("Lote", Nothing)
                        grdMovimientos.SetValue("Ubicacion", Nothing)
                    End If
                Case "Lote"
                    If Nz(e.Value) <> Nz(e.InitialValue) And Not Nz(e.InitialValue) Is Nothing Then
                        grdMovimientos.SetValue("Ubicacion", Nothing)
                    End If
                Case "Cantidad", "Cantidad2"
                    If Not IsNumeric(e.Value) Then
                        e.Value = 0
                    Else
                        Dim datFactor As New Articulo.DataFactorDobleUnidad(grdMovimientos.Value("IDArticulo"), (e.Column.Key = "Cantidad"), (e.Column.Key = "Cantidad2"))
                        Dim Factor As Double = ExpertisApp.ExecuteTask(Of Articulo.DataFactorDobleUnidad, Double)(AddressOf Articulo.FactorDobleUnidad, datFactor)
                        If Factor = 0 Then
                            If e.Column.Key = "Cantidad" AndAlso Nz(grdMovimientos.Value("Cantidad2"), 0) = 0 Then ExpertisApp.GenerateMessage("Debe indicar la Cantidad de la Segunda Unidad Interna.")
                        ElseIf Factor > 0 Then
                            If e.Column.Key = "Cantidad" Then
                                grdMovimientos.SetValue("Cantidad2", e.Value * Factor)
                            ElseIf e.Column.Key = "Cantidad2" Then
                                grdMovimientos.SetValue("Cantidad", e.Value * Factor)
                            End If
                        End If
                    End If
                Case "PrecioA"
                    If Not IsNumeric(e.Value) Then
                        e.Value = 0
                    End If
                    grdMovimientos.SetValue("PrecioB", xRound(e.Value * mMonedaA.CambioB, mMonedaB.NDecimalesPrecio))
                Case "PrecioB"
                    If Not IsNumeric(e.Value) Then
                        e.Value = 0
                    End If
                    grdMovimientos.SetValue("PrecioA", xRound(e.Value * mMonedaB.CambioA, mMonedaA.NDecimalesPrecio))
            End Select
        Catch ex As Exception
            e.Cancel = True
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalcularValoracion()
        Dim articulo As String = Nz(grdMovimientos.GetValue("IDArticulo"))
        Dim almacen As String = Nz(grdMovimientos.GetValue("IDAlmacen"))
        If Len(articulo) > 0 And Len(almacen) > 0 Then
            Dim precios As Hashtable = Nothing
            If Length(grdMovimientos.GetValue("claseMovimiento")) > 0 Then
                Dim claseMovimiento As enumtpmTipoMovimiento = grdMovimientos.GetValue("claseMovimiento")
                Select Case claseMovimiento
                    Case enumtpmTipoMovimiento.tpmInput
                        If IsDate(cbxFechaDocumento.Value) Then
                            Dim fecha As Date = cbxFechaDocumento.Value
                            Dim cantidad As Double = grdMovimientos.GetValue("Cantidad")
                            If grdMovimientos.GetValue("PrecioA") = 0 Or grdMovimientos.GetValue("PrecioB") = 0 Then
                                Dim datosPrecio As New ProcesoStocks.DataPrecioMovimiento(articulo, almacen, fecha, cantidad, claseMovimiento)
                                precios = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataPrecioMovimiento, Hashtable)(AddressOf ProcesoStocks.PrecioMovimiento, datosPrecio)
                            End If
                        Else
                            ExpertisApp.GenerateMessage("La fecha de documento no es válida. No es posible hacer una valoración del movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Case enumtpmTipoMovimiento.tpmOutput
                        If IsDate(cbxFechaDocumento.Value) Then
                            Dim fecha As Date = cbxFechaDocumento.Value
                            Dim cantidad As Double = grdMovimientos.GetValue("Cantidad")
                            Dim PrecioA As Double = grdMovimientos.GetValue("precioA")
                            Dim datosPrecio As New ProcesoStocks.DataPrecioMovimiento(articulo, almacen, fecha, cantidad, claseMovimiento, PrecioA)
                            precios = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataPrecioMovimiento, Hashtable)(AddressOf ProcesoStocks.PrecioMovimiento, datosPrecio)
                        Else
                            ExpertisApp.GenerateMessage("La fecha de documento no es válida. No es posible hacer una valoración del movimiento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                End Select
            End If
            If Not precios Is Nothing Then
                grdMovimientos.SetValue("PrecioA", precios("PrecioA"))
                grdMovimientos.SetValue("PrecioB", precios("PrecioB"))
            End If
        End If
    End Sub

    Private Sub grdMovimientos_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grdMovimientos.AddingRecord
        EstablecerClaseMovimiento()
        CalcularValoracion()
    End Sub

    Private Sub grdMovimientos_UpdatingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grdMovimientos.UpdatingRecord
        EstablecerClaseMovimiento()
        'CalcularValoracion()
    End Sub

    Private Sub grdMovimientos_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles grdMovimientos.AdvSearchNotInList
        Dim claseMovimiento As enumtpmTipoMovimiento = grdMovimientos.GetValue("ClaseMovimiento")
        Select Case claseMovimiento
            Case enumtpmTipoMovimiento.tpmInput
                e.Cancel = (e.Key = "IDArticulo" Or e.Key = "Ubicacion")
            Case enumtpmTipoMovimiento.tpmOutput
                e.Cancel = True
        End Select
    End Sub

    Private Sub grdMovimientos_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grdMovimientos.EditingCell
        If Me.RecordsState = RecordsState.[New] Then
            For Each adv As AdvSearchColumn In grdMovimientos.AdvSearchColumns
                grdMovimientos.Columns(adv.Key).ButtonStyle = ButtonStyle.Image
            Next
            Select Case e.Column.Key
                Case "Lote"
                    If (Nz(grdMovimientos.GetValue("GestionStockPorLotes"), False)) AndAlso (Length(grdMovimientos.GetValue("IDArticulo")) > 0 And Length(grdMovimientos.GetValue("IDAlmacen")) > 0) Then
                        e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    Else
                        e.Cancel = True
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
                Case "Ubicacion"
                    If Nz(grdMovimientos.GetValue("GestionStockPorLotes"), False) AndAlso Length(grdMovimientos.GetValue("IDAlmacen")) > 0 Then
                        e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Image
                    Else
                        e.Cancel = True
                        e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
                Case "Texto"
                    e.Column.EditType = Janus.Windows.GridEX.EditType.TextBox
                    e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.Ellipsis
            End Select
        Else
            e.Cancel = True
            e.Column.ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
        End If
    End Sub

    Private Sub grdMovimientos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles grdMovimientos.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "Lote"
                e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, grdMovimientos.GetValue("IDArticulo")))
                e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, grdMovimientos.GetValue("IDAlmacen")))
            Case "Ubicacion"
                e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, grdMovimientos.GetValue("IDAlmacen")))
        End Select
    End Sub

    Private Function ClaseMovimiento(ByVal IDTipoMovimiento As enumTipoMovimiento) As enumtpmTipoMovimiento
        Dim dt As DataTable = CType(grdMovimientos.DropDowns("TipoMovimiento").DataSource, DataTable)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            Dim f As New Filter
            f.Add(New NumberFilterItem("IDTipoMovimiento", IDTipoMovimiento))
            Dim dv As New DataView(dt)
            dv.RowFilter = f.Compose(New AdoFilterComposer)
            If dv.Count > 0 Then
                Return dv(0).Row("ClaseMovimiento")
            End If
        End If
    End Function

    Protected Overrides Sub OnRecordUpdating(ByVal e As System.ComponentModel.CancelEventArgs)
        If grdMovimientos.DataChanged Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("Existen actualizaciones pendientes en las líneas.", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Public Overrides Sub UpdateData(Optional ByVal EndCurrentEdit As Boolean = True)
        If DatosCabeceraValidos() Then
            If DatosGridValidos() Then
                Dim movimientos(-1) As StockData
                For Each row As GridEXRow In grdMovimientos.GetRows
                    mEnlace = mEnlace + 1

                    '//IDLineaMovimiento se va a utilizar como enlace provisional para identificar posteriormente la linea actualizada
                    row.BeginEdit()
                    row.Cells("IDLineaMovimiento").Value = mEnlace
                    row.EndEdit()

                    Dim movimiento As New StockData
                    movimiento.Enlace = mEnlace
                    movimiento.Articulo = row.Cells("IDArticulo").Value

                    movimiento.Almacen = row.Cells("IDAlmacen").Value
                    If Nz(row.Cells("NSerieObligatorio").Value, False) Then
                        movimiento.NSerie = Nz(row.Cells("Lote").Value)
                        movimiento.EstadoNSerie = Nz(row.Cells("IDEstadoActivo").Value)
                        movimiento.Ubicacion = Nz(row.Cells("Ubicacion").Value)
                    Else
                        movimiento.Lote = Nz(row.Cells("Lote").Value)
                        movimiento.Ubicacion = Nz(row.Cells("Ubicacion").Value)
                    End If
                    movimiento.Operario = Nz(row.Cells("OperarioGeneral").Value)
                    movimiento.Obra = Nz(row.Cells("IDObra").Value)
                    movimiento.FechaCaducidad = Nz(row.Cells("FechaCaducidad").Value)
                    movimiento.Cantidad = row.Cells("Cantidad").Value
                    If ExpertisApp.ExecuteTask(Of String, Boolean)(AddressOf ProcesoComunes.AplicarSegundaUnidad, movimiento.Articulo) Then
                        movimiento.Cantidad2 = CDbl(row.Cells("Cantidad2").Value)
                    End If
                    movimiento.PrecioA = row.Cells("PrecioA").Value
                    movimiento.PrecioB = row.Cells("PrecioB").Value
                    movimiento.Documento = Nz(row.Cells("Documento").Value)
                    movimiento.Texto = Nz(row.Cells("Texto").Value)
                    movimiento.FechaDocumento = cbxFechaDocumento.Value
                    movimiento.TipoMovimiento = row.Cells("IDTipoMovimiento").Value
                    ReDim Preserve movimientos(UBound(movimientos) + 1)
                    movimientos(UBound(movimientos)) = movimiento
                Next

                If movimientos.Length = 0 Then
                    ExpertisApp.GenerateMessage("No hay datos para actualizar.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim NumeroMovimiento As Long = CLng(txtNumeroMovimiento.Text)

                    Dim datMovtos As New ProcesoStocks.DataMovimientosGenericosES(NumeroMovimiento, movimientos)
                    Dim updateData As StockUpdateData() = ExpertisApp.ExecuteTask(Of ProcesoStocks.DataMovimientosGenericosES, StockUpdateData())(AddressOf ProcesoStocks.MovimientosGenericosES, datMovtos)

                    Dim frm As New DetalleActualizacionStock
                    frm.DataSource = updateData
                    frm.ShowDialog()

                    If Resumen(updateData) = 0 Then
                        '  Me.GotoRecord(DataProviderActions.GoLast)
                        Me.Requery.InvokeOnClick()
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Resumen(ByVal updateData As StockUpdateData()) As Long
        Dim notUpdated As Long
        If Not updateData Is Nothing AndAlso updateData.Length > 0 Then
            Dim lineas As DataTable = CType(grdMovimientos.DataSource, DataTable)
            For Each data As StockUpdateData In updateData
                If data.Estado = EstadoStock.Actualizado Then
                    For Each row As DataRow In lineas.Rows
                        If row("IDLineaMovimiento") = data.StockData.Enlace Then
                            row.Delete()
                            Exit For
                        End If
                    Next
                Else
                    notUpdated += 1
                End If
            Next
        End If
        grdMovimientos.Refetch()
        Return notUpdated
    End Function

    'pend: en el engine no hay un metodo overridable asociado al comando Cancel de la Toolbar
    'Esto tambien hace que:
    'Cargar el mantenimiento en vacio -> newRow -> Cancel -> No se recupera el estado inicial

    'Private Sub CancelUpdate(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles Cancel.Click
    '    RestoreItem()
    'End Sub
    'Private Sub RestoreItem()
    '    'MessageBox.Show(mRestoreID)
    'End Sub

    Private Sub grdMovimientos_ColumnButtonClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMovimientos.ColumnButtonClick
        If e.Column.Key = "Texto" Then
            Dim frm As New ERP.CommonClasses.FormularioTexto
            frm.Texto = grdMovimientos.GetValue(e.Column) & String.Empty
            frm.ShowDialog()
            If frm.DialogResult = DialogResult.OK Then
                If frm.Texto & String.Empty <> grdMovimientos.GetValue(e.Column) & String.Empty Then
                    grdMovimientos.SetValue(e.Column.Key, frm.Texto)
                End If
            End If
        End If
    End Sub

    Private Sub cboTipoMovimiento_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboTipoMovimiento.Validating
        If Length(cboTipoMovimiento.Value) > 0 Then
            Dim claseMovimiento As enumtpmTipoMovimiento = Me.ClaseMovimiento(cboTipoMovimiento.Value)

            grdMovimientos.Columns("IDTipoMovimiento").DefaultValue = cboTipoMovimiento.Value
            grdMovimientos.Columns("ClaseMovimiento").DefaultValue = claseMovimiento
            For Each row As GridEXRow In grdMovimientos.GetRows
                row.BeginEdit()
                row.Cells("IDTipoMovimiento").Value = cboTipoMovimiento.Value
                row.Cells("ClaseMovimiento").Value = claseMovimiento
                row.EndEdit()
            Next
            grdMovimientos.UpdateData()
        End If
    End Sub

    Private Sub AdvAlmacen_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvAlmacen.SelectionChanged
        If Length(AdvAlmacen.Value) > 0 Then
            grdMovimientos.Columns("IDAlmacen").DefaultValue = AdvAlmacen.Value
            For Each row As GridEXRow In grdMovimientos.GetRows
                row.BeginEdit()
                row.Cells("IDAlmacen").Value = AdvAlmacen.Value
                row.EndEdit()
            Next
            grdMovimientos.UpdateData()
        End If
    End Sub

    Private Sub chkMostrarCorrecciones_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMostrarCorrecciones.CheckedChanged
        If Me.RecordsState = RecordsState.Saved Then
            Me.GotoRecord(DataProviderActions.Refresh)
        End If
    End Sub

    Private Sub grdMovimientos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles grdMovimientos.FormattingRow
        If Not IsDBNull(e.Row.Cells("IDTipoMovimiento").Value) Then
            If e.Row.Cells("IDTipoMovimiento").Value = enumTipoMovimiento.tmCorreccion Then
                e.Row.RowStyle = grdMovimientos.FormatStyles("MovimientoCorreccion")
            End If
        End If
    End Sub

#Region " Números de Serie "

    Private Sub EstablecerClaseMovimiento()
        If Not cboTipoMovimiento.SelectedItem Is Nothing AndAlso Length(cboTipoMovimiento.SelectedItem.row("ClaseMovimiento")) > 0 Then
            Select Case CType(cboTipoMovimiento.SelectedItem.row("ClaseMovimiento"), enumtpmTipoMovimiento)
                Case enumtpmTipoMovimiento.tpmInput
                    mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Entrada
                    mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_DISPONIBLE
                    mSeries.UsarColumnaSeleccion = False
                Case enumtpmTipoMovimiento.tpmOutput
                    mSeries.ClaseMovimiento = [Shared].ClaseMovimiento.Salida
                    mSeries.ValorPorDefectoSeleccionEstado = ERP.CommonClasses.NSerie.ESTADO_BAJA
                    mSeries.UsarColumnaSeleccion = True
                    mSeries.Filtro.Clear()
                    mSeries.Filtro.Add(New BooleanFilterItem("Disponible", True))
            End Select
        End If
    End Sub

    Private Sub VisibilidadColumnaNSerie()
        If grdMovimientos.RowCount > 0 Then
            Dim dtMovtos As DataTable = grdMovimientos.DataSource
            Dim FilAlb As New Filter
            FilAlb.Add(New BooleanFilterItem("NSerieObligatorio", FilterOperator.Equal, True))
            Dim aux() As DataRow = dtMovtos.Select(FilAlb.Compose(New AdoFilterComposer))
            grdMovimientos.Columns("Series").Visible = (Not aux Is Nothing AndAlso aux.Length <> 0)
        End If
    End Sub

    Private Sub NumerosDeSerie()
        If Nz(grdMovimientos.GetValue("NSerieObligatorio"), False) AndAlso Length(grdMovimientos.GetValue("IDArticulo")) > 0 Then
            Dim dtGrid As DataTable = CType(grdMovimientos.DataSource, DataTable).Clone
            Dim current As DataRowView = grdMovimientos.GetRow.DataRow
            Dim dtSeries As DataTable = mSeries.SerieCollection.GetDataTable(grdMovimientos.GetValue("IDArticulo"))
            If Not dtSeries Is Nothing AndAlso dtSeries.Rows.Count > 0 Then
                For i As Integer = 0 To dtSeries.Rows.Count - 1
                    Dim DrNew As DataRow = current.Row
                    If i > 0 Then
                        DrNew = dtGrid.NewRow
                        DrNew.ItemArray = current.Row.ItemArray
                    Else
                        DrNew = current.Row
                    End If
                    DrNew("Lote") = dtSeries.Rows(i)("NSerie")
                    If dtSeries.Columns.Contains("Ubicacion") Then DrNew("Ubicacion") = dtSeries.Rows(i)("Ubicacion")
                    DrNew("IDEstadoActivo") = dtSeries.Rows(i)("IDEstadoActivo")
                    DrNew("OperarioGeneral") = dtSeries.Rows(i)("IDOperario")
                    DrNew("cantidad") = IIf(current("cantidad") > 0, 1, -1)

                    dtGrid.Rows.Add(DrNew.ItemArray)
                Next
            End If
            grdMovimientos.DataSource = dtGrid
            '//borramos el desglose para volver a cargar en vacio el formulario de numeros de serie
            mSeries.SerieCollection.Clear()
        End If
    End Sub

#End Region

    Private Sub cboTipoMovimiento_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoMovimiento.ValueChanged
        EstablecerClaseMovimiento()
    End Sub


    Protected Overridable Sub grdMovimientos_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grdMovimientos.CellUpdated
        Select Case e.Column.Key
            Case "Lote" '// CUIDADO: Esta gestión del lote, es por que la B.Avanzada no sabe distinguir cuando tenemos 2 ubicaciones distintas para el mismo lote
                If Length(grdMovimientos.Value("Lote")) = 0 Then
                    grdMovimientos.Value("Ubicacion") = System.DBNull.Value
                    grdMovimientos.Value("FechaCaducidad") = System.DBNull.Value
                End If
        End Select
    End Sub

    Protected Overridable Sub grdMovimientos_AdvSearchSelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchSelectionChangedEventArgs) Handles grdMovimientos.AdvSearchSelectionChanged
        Select Case e.Key
            Case "Lote" '// CUIDADO: Esta gestión del lote, es por que la B.Avanzada no sabe distinguir cuando tenemos 2 ubicaciones distintas para el mismo lote
                If e.Selected.Rows.Count = 1 Then
                    grdMovimientos.Value("Ubicacion") = e.Selected.Rows(0)("Ubicacion")
                    grdMovimientos.Value("FechaCaducidad") = e.Selected.Rows(0)("FechaCaducidad")
                ElseIf e.Selected.Rows.Count > 1 Then
                    Dim Ubicacion As String = grdMovimientos.Value("Ubicacion") & String.Empty
                    If Length(Ubicacion) > 0 Then
                        Dim UbiacionEsDeLote As List(Of DataRow) = (From c In e.Selected Where c("Ubicacion") = Ubicacion Select c).ToList
                        If UbiacionEsDeLote Is Nothing OrElse UbiacionEsDeLote.Count = 0 Then
                            grdMovimientos.Value("Ubicacion") = System.DBNull.Value
                            grdMovimientos.Value("FechaCaducidad") = System.DBNull.Value
                        End If
                    End If
                End If
        End Select
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ruta As String = ""
        Dim hoja As String = 1
        Dim rango As String = ""

        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos Excel(*.xls;*.xlsx)|*.xls;*xlsx|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim control As Integer = 0
                Try
                    ruta = openFD.FileName
                    hoja = "Hoja1"
                    rango = "A1:D500"

                    Dim dt As DataTable = ObtenerDatosExcel(ruta, hoja, rango)

                    'Creo la tabla con formato deseado
                    Dim dt2 As New DataTable
                    dt2.Columns.Add("IDTipoMovimiento")
                    dt2.Columns.Add("IDArticulo")
                    dt2.Columns.Add("DescArticulo")
                    dt2.Columns.Add("IDAlmacen")
                    dt2.Columns.Add("Cantidad")
                    dt2.Columns.Add("Lote")
                    dt2.Columns.Add("Ubicacion")
                    dt2.Columns.Add("IDLineaMovimiento")

                    Dim dr2 As DataRow
                    For Each dr As DataRow In dt.Rows
                        'MessageBox.Show(dr(0) & " , " & dr(2) & " , " & dr(7))
                        If IsDBNull(dr(0)) Then
                        Else
                            If IsDBNull(dr(3)) = False Then
                                'Grid1.RetrieveStructure()
                                dr2 = dt2.NewRow
                                dr2("IDTipoMovimiento") = cboTipoMovimiento.Value
                                dr2("IDArticulo") = dr(0)
                                dr2("DescArticulo") = dr(1)
                                dr2("IDAlmacen") = dr(2)
                                dr2("Cantidad") = dr(3)
                                dr2("Lote") = "False"
                                dr2("Ubicacion") = "NULL"
                                dr2("IDLineaMovimiento") = " "
                                dt2.Rows.Add(dr2)
                                control = control + 1
                            End If
                        End If
                    Next

                    grdMovimientos.DataSource = dt2
                Catch ex As Exception
                    MessageBox.Show("No hay más datos que añadir. ")

                End Try
            End If
        End With

        'FIN
        'ESTO ESTÁ BIEN

        'Dim dt As New DataTable
        'dt.Columns.Add("IDTipoMovimiento")
        'dt.Columns.Add("IDArticulo")
        'dt.Columns.Add("DescArticulo")
        'dt.Columns.Add("IDAlmacen")
        'dt.Columns.Add("Cantidad")
        'dt.Columns.Add("Lote")
        'dt.Columns.Add("Ubicacion")
        'dt.Columns.Add("IDLineaMovimiento")


        'Dim dr As DataRow
        'dr = dt.NewRow

        ''Aqui cargo la tabla del Excel con el stock

        'dr("IDTipoMovimiento") = 3
        'dr("IDArticulo") = "PruebaDavid10"
        'dr("DescArticulo") = "VASO 1/2 '' Nº 100"
        'dr("IDAlmacen") = "011"
        'dr("Cantidad") = "4"
        'dr("Lote") = "False"
        'dr("Ubicacion") = "NULL"
        'dr("IDLineaMovimiento") = " "

        'dt.Rows.Add(dr)
        'dr = dt.NewRow
        'dr("IDTipoMovimiento") = 3
        'dr("IDArticulo") = "PruebaDavid1"
        'dr("DescArticulo") = "VASO 1/2 '' Nº 100"
        'dr("IDAlmacen") = "011"
        'dr("Cantidad") = "5"
        'dr("Lote") = "False"
        'dr("Ubicacion") = "NULL"
        'dr("IDLineaMovimiento") = " "

        'dt.Rows.Add(dr)

        'grdMovimientos.DataSource = dt
        ''BIEN

    End Sub
    Public Function ObtenerDatosExcel(ByVal ruta As String, ByVal hoja As String, ByVal rango As String) As DataTable
        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & ruta & "';Extended Properties=Excel 12.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$" & rango & "]", MyConnection)
        'MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        Dim dt As DataTable = DtSet.Tables(0)
        MyConnection.Close()

        Return dt



    End Function
End Class
