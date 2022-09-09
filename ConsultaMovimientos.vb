Public Class ConsultaMovimientos
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
    Friend WithEvents lblFwiIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoMov As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiNDocumento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents IDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Articulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TipoArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Subfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Almacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FechaDocumentoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents TipoMovimiento As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FechaDocumentoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Documento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticuloPadre As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticuloPadre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFwNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiLote As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiUbicacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NSerie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents MostrarCorrecciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents Lote As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Ubicacion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvUDValoracion As Solmicro.Expertis.Engine.UI.AdvSearch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim TipoMovimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaMovimientos))
        Me.lblFwiIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFDocumentoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoMov = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFDocumentoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNDocumento = New Solmicro.Expertis.Engine.UI.Label
        Me.IDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Articulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TipoArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Subfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Almacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FechaDocumentoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.TipoMovimiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FechaDocumentoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Documento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvUDValoracion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.NObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.MostrarCorrecciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Lote = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiLote = New Solmicro.Expertis.Engine.UI.Label
        Me.NSerie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.Ubicacion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiUbicacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblArticuloPadre = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticuloPadre = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.TipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.NObra)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.advIDArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblArticuloPadre)
        Me.FilterPanel.Controls.Add(Me.lblFwNSerie)
        Me.FilterPanel.Controls.Add(Me.lblFwiIDObra)
        Me.FilterPanel.Controls.Add(Me.lblfwiArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiFamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoArticulo)
        Me.FilterPanel.Controls.Add(Me.lblfwiSubfamilia)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiFDocumentoDesde)
        Me.FilterPanel.Controls.Add(Me.lblfwiTipoMov)
        Me.FilterPanel.Controls.Add(Me.lblfwiFDocumentoHasta)
        Me.FilterPanel.Controls.Add(Me.lblfwiNDocumento)
        Me.FilterPanel.Controls.Add(Me.lblfwiLote)
        Me.FilterPanel.Controls.Add(Me.lblfwiUbicacion)
        Me.FilterPanel.Controls.Add(Me.NSerie)
        Me.FilterPanel.Controls.Add(Me.IDObra)
        Me.FilterPanel.Controls.Add(Me.Articulo)
        Me.FilterPanel.Controls.Add(Me.AdvFamilia)
        Me.FilterPanel.Controls.Add(Me.TipoArticulo)
        Me.FilterPanel.Controls.Add(Me.Subfamilia)
        Me.FilterPanel.Controls.Add(Me.Almacen)
        Me.FilterPanel.Controls.Add(Me.FechaDocumentoDesde)
        Me.FilterPanel.Controls.Add(Me.TipoMovimiento)
        Me.FilterPanel.Controls.Add(Me.FechaDocumentoHasta)
        Me.FilterPanel.Controls.Add(Me.MostrarCorrecciones)
        Me.FilterPanel.Controls.Add(Me.Documento)
        Me.FilterPanel.Controls.Add(Me.Lote)
        Me.FilterPanel.Controls.Add(Me.Ubicacion)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 252)
        Me.FilterPanel.Size = New System.Drawing.Size(831, 137)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Panel1)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(831, 252)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Panel1, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "Stock"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 35)
        Me.Grid.PrimaryDataFields = "IDLineaMovimiento"
        Me.Grid.SecondaryDataFields = "IDLineaMovimiento"
        Me.Grid.Size = New System.Drawing.Size(831, 217)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmCIMovimientos"
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
        Me.MainPanel.Size = New System.Drawing.Size(831, 389)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(831, 389)
        '
        'lblFwiIDObra
        '
        Me.lblFwiIDObra.Location = New System.Drawing.Point(212, 107)
        Me.lblFwiIDObra.Name = "lblFwiIDObra"
        Me.lblFwiIDObra.Size = New System.Drawing.Size(57, 13)
        Me.lblFwiIDObra.TabIndex = 77
        Me.lblFwiIDObra.Tag = ""
        Me.lblFwiIDObra.Text = "Proyecto"
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(6, 28)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 78
        Me.lblfwiArticulo.Tag = "IdRec=4430;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(212, 55)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 79
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiTipoArticulo
        '
        Me.lblfwiTipoArticulo.Location = New System.Drawing.Point(212, 29)
        Me.lblfwiTipoArticulo.Name = "lblfwiTipoArticulo"
        Me.lblfwiTipoArticulo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipoArticulo.TabIndex = 80
        Me.lblfwiTipoArticulo.Tag = "IdRec=4456;"
        Me.lblfwiTipoArticulo.Text = "Tipo"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(212, 81)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 81
        Me.lblfwiSubfamilia.Tag = "IdRec=4452;"
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(6, 54)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 82
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'lblfwiFDocumentoDesde
        '
        Me.lblfwiFDocumentoDesde.Location = New System.Drawing.Point(390, 29)
        Me.lblfwiFDocumentoDesde.Name = "lblfwiFDocumentoDesde"
        Me.lblfwiFDocumentoDesde.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoDesde.TabIndex = 83
        Me.lblfwiFDocumentoDesde.Tag = "IdRec=5251;"
        Me.lblfwiFDocumentoDesde.Text = "Fecha Doc. >="
        '
        'lblfwiTipoMov
        '
        Me.lblfwiTipoMov.Location = New System.Drawing.Point(390, 80)
        Me.lblfwiTipoMov.Name = "lblfwiTipoMov"
        Me.lblfwiTipoMov.Size = New System.Drawing.Size(100, 13)
        Me.lblfwiTipoMov.TabIndex = 84
        Me.lblfwiTipoMov.Tag = "IdRec=5250;"
        Me.lblfwiTipoMov.Text = "Tipo Movimiento"
        '
        'lblfwiFDocumentoHasta
        '
        Me.lblfwiFDocumentoHasta.Location = New System.Drawing.Point(590, 28)
        Me.lblfwiFDocumentoHasta.Name = "lblfwiFDocumentoHasta"
        Me.lblfwiFDocumentoHasta.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoHasta.TabIndex = 85
        Me.lblfwiFDocumentoHasta.Tag = "IdRec=4251;"
        Me.lblfwiFDocumentoHasta.Text = "Fecha Doc. <="
        '
        'lblfwiNDocumento
        '
        Me.lblfwiNDocumento.Location = New System.Drawing.Point(593, 80)
        Me.lblfwiNDocumento.Name = "lblfwiNDocumento"
        Me.lblfwiNDocumento.Size = New System.Drawing.Size(90, 13)
        Me.lblfwiNDocumento.TabIndex = 86
        Me.lblfwiNDocumento.Tag = "IdRec=6710;"
        Me.lblfwiNDocumento.Text = "Nº Documento"
        '
        'IDObra
        '
        Me.IDObra.DisabledBackColor = System.Drawing.Color.White
        Me.IDObra.DisplayField = "NObra"
        Me.IDObra.EntityName = "ObraCabecera"
        Me.IDObra.Location = New System.Drawing.Point(284, 102)
        Me.IDObra.Name = "IDObra"
        Me.IDObra.PrimaryDataFields = "IDObra"
        Me.IDObra.SecondaryDataFields = "IDObra"
        Me.IDObra.Size = New System.Drawing.Size(100, 23)
        Me.IDObra.TabIndex = 7
        Me.IDObra.ViewName = "tbObraCabecera"
        '
        'Articulo
        '
        Me.Articulo.DisabledBackColor = System.Drawing.Color.White
        Me.Articulo.EntityName = "Articulo"
        Me.Articulo.Location = New System.Drawing.Point(98, 24)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.PrimaryDataFields = "IDArticulo"
        Me.Articulo.SecondaryDataFields = "IDArticulo"
        Me.Articulo.Size = New System.Drawing.Size(108, 23)
        Me.Articulo.TabIndex = 0
        Me.Articulo.ViewName = "tbMaestroArticulo"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(284, 50)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamilia.TabIndex = 5
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'TipoArticulo
        '
        Me.TipoArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.TipoArticulo.EntityName = "TipoArticulo"
        Me.TipoArticulo.Location = New System.Drawing.Point(284, 24)
        Me.TipoArticulo.Name = "TipoArticulo"
        Me.TipoArticulo.PrimaryDataFields = "IDTipo"
        Me.TipoArticulo.SecondaryDataFields = "IDTipo"
        Me.TipoArticulo.Size = New System.Drawing.Size(100, 23)
        Me.TipoArticulo.TabIndex = 4
        Me.TipoArticulo.ViewName = "tbMaestroTipoArticulo"
        '
        'Subfamilia
        '
        Me.Subfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.Subfamilia.EntityName = "Subfamilia"
        Me.Subfamilia.Location = New System.Drawing.Point(284, 76)
        Me.Subfamilia.Name = "Subfamilia"
        Me.Subfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.Subfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.Subfamilia.Size = New System.Drawing.Size(100, 23)
        Me.Subfamilia.TabIndex = 6
        Me.Subfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'Almacen
        '
        Me.Almacen.DisabledBackColor = System.Drawing.Color.White
        Me.Almacen.EntityName = "Almacen"
        Me.Almacen.Location = New System.Drawing.Point(98, 50)
        Me.Almacen.Name = "Almacen"
        Me.Almacen.PrimaryDataFields = "IDAlmacen"
        Me.Almacen.SecondaryDataFields = "IDAlmacen"
        Me.Almacen.Size = New System.Drawing.Size(108, 23)
        Me.Almacen.TabIndex = 1
        Me.Almacen.ViewName = "tbMaestroAlmacen"
        '
        'FechaDocumentoDesde
        '
        Me.FechaDocumentoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoDesde.Location = New System.Drawing.Point(484, 25)
        Me.FechaDocumentoDesde.Name = "FechaDocumentoDesde"
        Me.FechaDocumentoDesde.Size = New System.Drawing.Size(100, 21)
        Me.FechaDocumentoDesde.TabIndex = 10
        '
        'TipoMovimiento
        '
        TipoMovimiento_DesignTimeLayout.LayoutString = resources.GetString("TipoMovimiento_DesignTimeLayout.LayoutString")
        Me.TipoMovimiento.DesignTimeLayout = TipoMovimiento_DesignTimeLayout
        Me.TipoMovimiento.DisabledBackColor = System.Drawing.Color.White
        Me.TipoMovimiento.DisplayMember = "CodTipoMovimiento"
        Me.TipoMovimiento.EntityName = "TipoMovimiento"
        Me.TipoMovimiento.Location = New System.Drawing.Point(493, 76)
        Me.TipoMovimiento.Name = "TipoMovimiento"
        Me.TipoMovimiento.PrimaryDataFields = "IDTipoMovimiento"
        Me.TipoMovimiento.SecondaryDataFields = "IDArticuloPadre"
        Me.TipoMovimiento.SelectedIndex = -1
        Me.TipoMovimiento.SelectedItem = Nothing
        Me.TipoMovimiento.Size = New System.Drawing.Size(91, 21)
        Me.TipoMovimiento.TabIndex = 11
        Me.TipoMovimiento.ValueMember = "IDTipoMovimiento"
        Me.TipoMovimiento.ViewName = "tbMaestroTipoMovimiento"
        '
        'FechaDocumentoHasta
        '
        Me.FechaDocumentoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoHasta.Location = New System.Drawing.Point(684, 23)
        Me.FechaDocumentoHasta.Name = "FechaDocumentoHasta"
        Me.FechaDocumentoHasta.Size = New System.Drawing.Size(100, 21)
        Me.FechaDocumentoHasta.TabIndex = 11
        '
        'Documento
        '
        Me.Documento.DisabledBackColor = System.Drawing.Color.White
        Me.Documento.Location = New System.Drawing.Point(696, 76)
        Me.Documento.Name = "Documento"
        Me.Documento.Size = New System.Drawing.Size(80, 21)
        Me.Documento.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AdvUDValoracion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 101
        Me.Label1.Tag = ""
        Me.Label1.Text = "Ud. Valoración"
        '
        'AdvUDValoracion
        '
        Me.AdvUDValoracion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvUDValoracion.EntityName = "UdMedida"
        Me.AdvUDValoracion.Location = New System.Drawing.Point(98, 6)
        Me.AdvUDValoracion.Name = "AdvUDValoracion"
        Me.AdvUDValoracion.SecondaryDataFields = "IDUdMedida"
        Me.AdvUDValoracion.Size = New System.Drawing.Size(124, 23)
        Me.AdvUDValoracion.TabIndex = 100
        '
        'NObra
        '
        Me.NObra.DisabledBackColor = System.Drawing.Color.White
        Me.NObra.Location = New System.Drawing.Point(696, 106)
        Me.NObra.Name = "NObra"
        Me.NObra.Size = New System.Drawing.Size(80, 21)
        Me.NObra.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(595, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "NObra"
        '
        'MostrarCorrecciones
        '
        Me.MostrarCorrecciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MostrarCorrecciones.Location = New System.Drawing.Point(593, 48)
        Me.MostrarCorrecciones.Name = "MostrarCorrecciones"
        Me.MostrarCorrecciones.Size = New System.Drawing.Size(183, 24)
        Me.MostrarCorrecciones.TabIndex = 12
        Me.MostrarCorrecciones.Text = "Mostrar Correcciones"
        '
        'Lote
        '
        Me.Lote.DisabledBackColor = System.Drawing.Color.White
        Me.Lote.EntityName = "ArticuloAlmacenLote"
        Me.Lote.Location = New System.Drawing.Point(484, 101)
        Me.Lote.Name = "Lote"
        Me.Lote.PrimaryDataFields = "Lote"
        Me.Lote.SecondaryDataFields = "Lote"
        Me.Lote.Size = New System.Drawing.Size(100, 23)
        Me.Lote.TabIndex = 8
        Me.Lote.ViewName = "tbArticuloAlmacenLote"
        '
        'lblfwiLote
        '
        Me.lblfwiLote.Location = New System.Drawing.Point(390, 106)
        Me.lblfwiLote.Name = "lblfwiLote"
        Me.lblfwiLote.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiLote.TabIndex = 87
        Me.lblfwiLote.Tag = "IdRec=5968;"
        Me.lblfwiLote.Text = "Lote"
        '
        'NSerie
        '
        Me.NSerie.DisabledBackColor = System.Drawing.Color.White
        Me.NSerie.EntityName = "ArticuloNSerie"
        Me.NSerie.Location = New System.Drawing.Point(484, 50)
        Me.NSerie.Name = "NSerie"
        Me.NSerie.PrimaryDataFields = "NSerie"
        Me.NSerie.SecondaryDataFields = "NSerie"
        Me.NSerie.Size = New System.Drawing.Size(100, 23)
        Me.NSerie.TabIndex = 9
        Me.NSerie.ViewName = "tbArticuloNSerie"
        '
        'lblFwNSerie
        '
        Me.lblFwNSerie.Location = New System.Drawing.Point(390, 55)
        Me.lblFwNSerie.Name = "lblFwNSerie"
        Me.lblFwNSerie.Size = New System.Drawing.Size(55, 13)
        Me.lblFwNSerie.TabIndex = 63
        Me.lblFwNSerie.Tag = ""
        Me.lblFwNSerie.Text = "Nº Serie"
        '
        'Ubicacion
        '
        Me.Ubicacion.DisabledBackColor = System.Drawing.Color.White
        Me.Ubicacion.EntityName = "ArticuloAlmacenLote"
        Me.Ubicacion.Location = New System.Drawing.Point(98, 76)
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.PrimaryDataFields = "Ubicacion"
        Me.Ubicacion.SecondaryDataFields = "Ubicacion"
        Me.Ubicacion.Size = New System.Drawing.Size(108, 23)
        Me.Ubicacion.TabIndex = 2
        Me.Ubicacion.ViewName = "tbArticuloAlmacenLote"
        '
        'lblfwiUbicacion
        '
        Me.lblfwiUbicacion.Location = New System.Drawing.Point(6, 81)
        Me.lblfwiUbicacion.Name = "lblfwiUbicacion"
        Me.lblfwiUbicacion.Size = New System.Drawing.Size(61, 13)
        Me.lblfwiUbicacion.TabIndex = 88
        Me.lblfwiUbicacion.Tag = "IdRec=7240;"
        Me.lblfwiUbicacion.Text = "Ubicación"
        '
        'lblArticuloPadre
        '
        Me.lblArticuloPadre.Location = New System.Drawing.Point(6, 107)
        Me.lblArticuloPadre.Name = "lblArticuloPadre"
        Me.lblArticuloPadre.Size = New System.Drawing.Size(87, 13)
        Me.lblArticuloPadre.TabIndex = 90
        Me.lblArticuloPadre.Tag = ""
        Me.lblArticuloPadre.Text = "Artículo Padre"
        '
        'advIDArticuloPadre
        '
        Me.advIDArticuloPadre.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticuloPadre.EntityName = "Articulo"
        Me.advIDArticuloPadre.Location = New System.Drawing.Point(98, 102)
        Me.advIDArticuloPadre.Name = "advIDArticuloPadre"
        Me.advIDArticuloPadre.SecondaryDataFields = "IDArticulo"
        Me.advIDArticuloPadre.Size = New System.Drawing.Size(108, 23)
        Me.advIDArticuloPadre.TabIndex = 3
        Me.advIDArticuloPadre.ViewName = "tbMaestroArticulo"
        '
        'ConsultaMovimientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(839, 477)
        Me.EntityName = "Stock"
        Me.Name = "ConsultaMovimientos"
        Me.Text = "Consulta de Movimientos"
        Me.ViewName = "vFrmCIMovimientos"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.TipoMovimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRARTICULO As String = "Abrir Artículo"
    Private Const cnABRIRALBARAN As String = "Abrir Albarán"

    Private mblnStkDobleUnidad As Boolean
    Private mEsquema As String


    Private Sub ConsultaMovimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            mEsquema = ExpertisApp.ExecuteTask(Of Object, String)(AddressOf Business.General.Comunes.GetEsquemaBD, Nothing)
            LoadERPData()
            LoadGridActions()
            LoadFormParams()
        End If
    End Sub

    Private Sub LoadGridActions()
        Grid.Actions.Add("Abrir Movimiento", AddressOf VerMovimiento, ExpertisApp.GetIcon("xMovimStock.ico"))
        Grid.Actions.Add(cnABRIRARTICULO, AddressOf CargarMantenimientoArticulo, ExpertisApp.GetIcon("xArticulos.ico"))
        Grid.Actions.Add(cnABRIRALBARAN, AddressOf VerAlbaran)
    End Sub

    Private Sub LoadERPData()
        Dim p As New Parametro
        mblnStkDobleUnidad = p.GestionDobleUnidad
        SettingDobleUnidad()
        If p.GestionBodegas Then
            Dim dtParam As DataTable = p.SelOnPrimaryKey("BDGUDMED")
            If dtParam.Rows.Count > 0 Then
                AdvUDValoracion.Value = dtParam.Rows(0)("Valor") & String.Empty
            End If
        End If
    End Sub

    Private Sub LoadFormParams()
        If Not IsNothing(Me.Params) Then
            If TypeOf Me.Params Is Hashtable Then
                Dim parameters As Hashtable = CType(Me.Params, Hashtable)
                If (parameters.ContainsKey("IDArticulo")) Then
                    Articulo.Text = parameters("IDArticulo")
                End If
                If (parameters.ContainsKey("IDAlmacen")) Then
                    Almacen.Text = parameters("IDAlmacen")
                End If
                If (parameters.ContainsKey("Documento")) Then
                    Documento.Text = parameters("Documento")
                End If
                Me.Execute()
            End If
        End If
    End Sub

    Private Sub SettingDobleUnidad()
        If Me.Grid.Columns.Contains("Cantidad2") Then
            Me.Grid.Columns("Cantidad2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("Cantidad2").Position = Me.Grid.Columns("Acumulado").Position + 1
        End If

        If Me.Grid.Columns.Contains("Acumulado2") Then
            Me.Grid.Columns("Acumulado2").Visible = mblnStkDobleUnidad
            Me.Grid.Columns("Acumulado2").Position = Me.Grid.Columns("Cantidad2").Position + 1
        End If
    End Sub

    Private Sub ConsultaMovimientos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, Articulo.Text, FilterType.String)
        e.Filter.Add("IDArticuloPadre", FilterOperator.Equal, advIDArticuloPadre.Text, FilterType.String)
        e.Filter.Add("IDAlmacen", FilterOperator.Equal, Almacen.Text, FilterType.String)
        e.Filter.Add("Lote", FilterOperator.Equal, Lote.Text, FilterType.String)
        e.Filter.Add("Ubicacion", FilterOperator.Equal, Ubicacion.Text, FilterType.String)

        e.Filter.Add("IDTipo", FilterOperator.Equal, TipoArticulo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, Subfamilia.Text, FilterType.String)
        e.Filter.Add("IDObra", FilterOperator.Equal, IDObra.Value, FilterType.Numeric)

        e.Filter.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, FechaDocumentoDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaDocumento", FilterOperator.LessThanOrEqual, FechaDocumentoHasta.Value, FilterType.DateTime)
        e.Filter.Add("Documento", FilterOperator.Equal, Documento.Text, FilterType.String)
        e.Filter.Add("Lote", FilterOperator.Equal, NSerie.Text, FilterType.String)

        e.Filter.Add("IDTipoMovimiento", FilterOperator.Equal, TipoMovimiento.Value, FilterType.Numeric)
        'David 02/11
        e.Filter.Add("NObra", FilterOperator.Equal, NObra.Text, FilterType.String)
        'David

        'pend general: en los combobox al seleccionar el registro vacion toma el valor value=DBNull
        'cuando se carga el formulario tiene el valor nothing
        '¿cuando se selecciona el registro vacio deberia tomar el valor nothing y no DBNull?
        'el valor nothing es 'mas sencillo de validar' en el sentido de que no da error en operaciones del tipo
        '                           TipoMovimiento.Value <> enumTipoMovimiento.tmCorreccion
        If IsDBNull(TipoMovimiento.Value) OrElse TipoMovimiento.Value <> enumTipoMovimiento.tmCorreccion Then
            If Not MostrarCorrecciones.Checked Then
                e.Filter.Add("IDTipoMovimiento", FilterOperator.NotEqual, enumTipoMovimiento.tmCorreccion, FilterType.Numeric)
            End If
        End If

        Dim vStr As String = "SELECT v.*"
        If Length(AdvUDValoracion.Value) > 0 Then
            vStr &= ", " & mEsquema & ".fFactorArticuloAB(v.IDArticulo, v.IDUdInterna, " & Quoted(AdvUDValoracion.Value & String.Empty) & ", 0) AS FactorUdValoracion, " & _
                    "v.Cantidad * " & mEsquema & ".fFactorArticuloAB(v.IDArticulo, v.IDUdInterna, " & Quoted(AdvUDValoracion.Value & String.Empty) & ", 0) AS StockAFechaUdValoracion"
        End If
        vStr &= " FROM vfrmCIMovimientos v"
        If e.Filter.InnerFilter.Count > 0 Then
            vStr &= " WHERE " & ExpertisApp.ExecuteTask(Of Filter, String)(AddressOf Business.General.Comunes.GetComposeFilterSql, e.Filter.InnerFilter)
        End If

        Grid.ViewName = vStr
    End Sub

    Private Sub Grid_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles Grid.FormattingRow
        Dim tipo As enumTipoMovimiento = e.Row.Cells("IDTipoMovimiento").Value
        If tipo = enumTipoMovimiento.tmCorreccion Then
            e.Row.RowStyle = Grid.FormatStyles("MovimientoCorreccion")
        End If
    End Sub

    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Grid.RecordCount > 0 Then
                Grid.UiCommandManager1.Commands(cnABRIRALBARAN).Visible = InheritableBoolean.False
                If Grid.Value("IDTipoMovimiento") = enumTipoMovimiento.tmEntAlbaranCompra Or Grid.Value("IDTipoMovimiento") = enumTipoMovimiento.tmSalAlbaranVenta Then
                    Grid.UiCommandManager1.Commands(cnABRIRALBARAN).Visible = InheritableBoolean.True
                End If
            End If
        End If
    End Sub

    Private Sub VerMovimiento()
        Dim HT As New Hashtable
        HT("IDMovimiento") = Grid.Value("IDMovimiento")
        If ExpertisApp.IsFormOpen("MSTOCK") Then ExpertisApp.CloseForm("MSTOCK")
        ExpertisApp.OpenForm("MSTOCK", , HT)
    End Sub

    Private Sub CargarMantenimientoArticulo()
        If Length(Grid.GetValue("IDArticulo")) > 0 Then
            ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", FilterOperator.Equal, Grid.GetValue("IDArticulo")))
        End If
    End Sub

    Private Sub VerAlbaran()
        Dim row As GridEXRow = Grid.GetRow()
        If Not row Is Nothing Then
            Dim IDAlbaran As String = row.Cells("IDDocumento").Value & String.Empty
            If Len(IDAlbaran) = 0 Then
                ExpertisApp.GenerateMessage("No se puede mostrar el albarán porque el movimiento no tiene aisgnado un Nº de documento.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim Programa As String = String.Empty
                If row.Cells("IDTipoMovimiento").Value = enumTipoMovimiento.tmEntAlbaranCompra Then
                    Programa = "MALBC"
                ElseIf row.Cells("IDTipoMovimiento").Value = enumTipoMovimiento.tmSalAlbaranVenta Then
                    Programa = "MALB"
                End If
                ExpertisApp.OpenForm(Programa, New StringFilterItem("IDAlbaran", FilterOperator.Equal, IDAlbaran))
            End If
        End If
    End Sub

    Private Sub NSerie_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles NSerie.SetPredefinedFilter
        If Len(Articulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, Articulo.Text))
        End If
    End Sub

    Private Sub Lote_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles Lote.SetPredefinedFilter
        If Len(Articulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, Articulo.Text))
        End If
        If Len(Almacen.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, Almacen.Text))
        End If
    End Sub

    Private Sub Ubicacion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles Ubicacion.SetPredefinedFilter
        If Len(Articulo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", FilterOperator.Equal, Articulo.Text))
        End If
        If Len(Almacen.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDAlmacen", FilterOperator.Equal, Almacen.Text))
        End If
        If Len(Lote.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("Lote", FilterOperator.Equal, Lote.Text))
        End If
    End Sub

    Private Sub Subfamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles Subfamilia.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, TipoArticulo.Text))
        e.Filter.Add(New StringFilterItem("IDFamilia", FilterOperator.Equal, AdvFamilia.Text))
    End Sub

    Private Sub Familia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDTipo", FilterOperator.Equal, TipoArticulo.Text))
    End Sub

    Private Sub ConsultaMovimientos_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        'pend general: el evento ya deberia borrar los valores no resetea los valores de controles CalendarBox
        MostrarCorrecciones.Checked = False
    End Sub

    Private Sub grid_ColumnHeaderClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles Grid.ColumnHeaderClick
        If e.Column.Key = "IDLineaMovimiento" Or e.Column.Key = "IDMovimiento" Or e.Column.Key = "FechaDocumento" Then
            Grid.RootTable.SortKeys.Clear()
            Sort(CType(Grid.DataSource, DataTable))
        End If
    End Sub

    Private Sub Sort(ByVal dt As DataTable)
        If Not dt Is Nothing Then
            dt.DefaultView.Sort = "FechaDocumento DESC,IDLineaMovimiento DESC"
        End If
    End Sub

    Private Sub ConsultaMovimientos_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        Sort(CType(Grid.DataSource, DataTable))
        If Me.Grid.RecordCount > 0 Then Grid.Row = 0 'Para evitar que se quede seleccionado el último registro, y por tanto, el scroll automático, que se comporta erróneamente.
    End Sub

    Private Sub AdvUDValoracion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvUDValoracion.SelectionChanged
        If Not AdvUDValoracion.SelectedRow Is Nothing Then
            Grid.Columns("StockAFechaUdValoracion").Visible = True
            Grid.Columns("StockAFechaUdValoracion").Caption = AdvUDValoracion.SelectedRow("DescUdMedida") & String.Empty
        End If
    End Sub

    Private Sub AdvUDValoracion_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles AdvUDValoracion.Validated
        If Length(AdvUDValoracion.Text) = 0 Then
            Grid.Columns("StockAFechaUdValoracion").Visible = False
            Grid.Columns("StockAFechaUdValoracion").Caption = ExpertisApp.Traslate("Stock Ud. Valoración")
        End If
    End Sub

    Private Sub ConsultaMovimientos_SetReportDesignObjects(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        'Dim vMes As Integer
        Dim Fecha1 As Date
        Dim Fecha2 As Date
        Dim Familia As String
        Dim obra As String
        ' Dim vAnio As Integer
        Dim cancel As Boolean


        If e.Alias = "INFALQUILER1" Then
            'Abrir Informe de Beneficio1 - informe transferencias precio reposicion

            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio1(CDate(Fecha1), CDate(Fecha2))

            e.Cancel = True
        ElseIf e.Alias = "MOVOBRFEC" Then
            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            Fecha1 = frm.FechaDesde.Value
            Fecha2 = frm.FechaHasta.Value
            obra = Almacen.Text
            Familia = AdvFamilia.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarMovimientos(CDate(Fecha1), CDate(Fecha2), obra, Familia)
            e.Cancel = True
        ElseIf e.Alias = "INFCOST2" Then
            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            Fecha1 = frm.FechaDesde.Value
            Fecha2 = frm.FechaHasta.Value

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarCostes(CDate(Fecha1), CDate(Fecha2))
            e.Cancel = True
        ElseIf e.Alias = "INFMOVI" Then
            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            Fecha1 = frm.FechaDesde.Value
            Fecha2 = frm.FechaHasta.Value

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            GenerarCostes2(CDate(Fecha1), CDate(Fecha2))
            e.Cancel = True
        ElseIf e.Alias = "INFENCOFRADO" Then
            'Abrir Informe de Beneficio2 - informe transferencias encofrado

            Dim frm As New frmInformeFechaEncofrado
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text
            Familia = AdvFamilia.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio2(CDate(Fecha1), CDate(Fecha2), Familia)

            e.Cancel = True
        ElseIf e.Alias = "INFALQUILER" Then
            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio(CDate(Fecha1), CDate(Fecha2))

            e.Cancel = True
        ElseIf e.Alias = "INFHERRAM" Then
            'Abrir Informe de Beneficio2 - informe transferencias encofrado

            Dim frm As New frmInformeFecha
            frm.ShowDialog()
            'vMes = frm.VM
            Fecha1 = frm.FechaDesde.Value
            'vAnio = frm.VA
            Fecha2 = frm.FechaHasta.Value
            'obra = txtNObra.Text

            If frm.blEstado = True Then
                MessageBox.Show("Proceso Cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
                Exit Sub
            End If
            'GenerarInformeBeneficio(CInt(vMes), CInt(vAnio))
            GenerarInformeBeneficio4(CDate(Fecha1), CDate(Fecha2))

            e.Cancel = True
        End If
    End Sub
    Private Sub GenerarCostes(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Try
            Dim rp As New Report("INFCOST2")
            Dim filtro As New Filter

            filtro.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Fecha1)
            filtro.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
            rp.Formulas("fDesde").Text = Format(Fecha1, "dd-MM-yyyy")
            rp.Formulas("fHasta").Text = Format(Fecha2, "dd-MM-yyyy")
            'Le paso el numero de dias del mes

            
            rp.DataSource = New BE.DataEngine().Filter("vFrmCIMovimientos", filtro)

            ExpertisApp.OpenReport(rp)
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub
    Private Sub GenerarMovimientos(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal obra As String, ByVal familia As String)
        'Este informe eta hecho para consumibles a partir de 2022 que no se gestiona su stock en obra debido a alquileres.
        Try
            Dim rp As New Report("MOVOBRFEC")
            Dim filtro As New Filter
            Dim dt As New DataTable

            '1. Por el uso que hace de la ventana transferencia entre almacenes. IDAlmacen ="Dp19"(Por ejemplo)
            '2. Por el uso que se hace de alquileres. Almacen Origen = "DP19"
            Dim teco As New Expertis.Business.ClasesTecozam.OperarioCalendario
            dt = teco.ejecutarSelect("select * from vFrmCIMovimientos where (IDAlmacen='" & obra & "' OR [Almacen Origen]='" & obra & "') And IDFamilia='" & familia & "' And FechaDocumento>='" & Fecha1 & "' And FechaDocumento<='" & Fecha2 & "'  AND CodTipoMovimiento!='S7' AND CodTipoMovimiento!='T-' AND CodTipoMovimiento!='C'")

            Dim cont As Integer
            cont = 0
            For Each dr As DataRow In dt.Rows
                dt.Rows(cont)("IDAlmacen") = obra
                cont += 1
            Next
            rp.Formulas("Fecha1").Text = Format(Fecha1, "dd-MM-yyyy")
            rp.Formulas("Fecha2").Text = Format(Fecha2, "dd-MM-yyyy")
            'Le paso el numero de dias del mes


            rp.DataSource = dt

            ExpertisApp.OpenReport(rp)
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub
    Private Sub GenerarCostes2(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Try
            Dim rp As New Report("INFMOVI")
            Dim filtro As New Filter

            filtro.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, Fecha1)
            filtro.Add("FechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
            rp.Formulas("fDesde").Text = Format(Fecha1, "dd-MM-yyyy")
            rp.Formulas("fHasta").Text = Format(Fecha2, "dd-MM-yyyy")
            rp.DataSource = New BE.DataEngine().Filter("vFrmCIMovimientos", filtro)

            ExpertisApp.OpenReport(rp)
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try
    End Sub
    Private Sub GenerarInformeBeneficio(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Dim rp As New Report("INFALQUILER")
        Dim filtro As New Filter
        Dim laborables As String

        'Dim e As Engine.UI.ReportDesignObjectsEventArgs

        laborables = Work_Days(Fecha1, Fecha2)

        'filtro.Add("Nobra", FilterOperator.Equal, obra)

        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaMovimiento", FilterOperator.LessThanOrEqual, Fecha2)
        rp.DataSource = New BE.DataEngine().Filter("vFrmConsultaTransferenciasAlquileres", filtro)

        rp.Formulas("laborables").Text = laborables
        rp.Formulas("fecha1").Text = Fecha1
        rp.Formulas("fecha2").Text = Fecha2

        ExpertisApp.OpenReport(rp)

    End Sub
    Private Sub GenerarInformeBeneficio1(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Dim rp As New Report("INFALQUILER1")
        Dim filtro As New Filter
        Dim laborables As String

        'Dim e As Engine.UI.ReportDesignObjectsEventArgs

        laborables = Work_Days(Fecha1, Fecha2)

        'filtro.Add("Nobra", FilterOperator.Equal, obra)

        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaMovimiento", FilterOperator.LessThanOrEqual, Fecha2)
        rp.DataSource = New BE.DataEngine().Filter("vFrmConsultaTransferenciasAlquileres", filtro)

        rp.Formulas("laborables").Text = laborables
        rp.Formulas("fecha1").Text = Fecha1
        rp.Formulas("fecha2").Text = Fecha2

        ExpertisApp.OpenReport(rp)
    End Sub
    Private Sub GenerarInformeBeneficio2(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal idfamilia As String)
        Dim rp As New Report("INFENCOFRADO")
        Dim filtro As New Filter
        Dim laborables As String
        'Dim e As Engine.UI.ReportDesignObjectsEventArgs
        laborables = Dias_naturales(Fecha1, Fecha2)
        'filtro.Add("Nobra", FilterOperator.Equal, obra)
        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.
        Dim familia As String = idfamilia
        Dim dFamilia As String
        Dim arti As New Articulo
        Dim dtFam As DataTable = arti.DevuelveTabla(familia)
        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        filtro.Add("idfamilia", FilterOperator.Equal, familia)
        rp.DataSource = New BE.DataEngine().Filter("vFrmTransferenciasEncofrados2", filtro)
        'Dim Dt As DataTable = AdminData.Execute("exec sp_TransferenciasEncofrado '0210'")
        'rp.DataSource = New BE.DataEngine().Filter(Dt, filtro)
        'rp.DataSource = New BE.DataEngine().Filter("exec sp_TransferenciasEncofrado '0210' ", filtro)
        For Each drfam As DataRow In dtFam.Rows
            dFamilia = drfam(0)
        Next
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            rp.Formulas("Familia").Text = dFamilia

            Dim strSelect As String = "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect &= "FROM tbhistoricomovimiento "
            strSelect &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR "
            strSelect &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-') AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '" & familia & "') "
            strSelect &= "ORDER BY dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.IDArticulo "
            'MsgBox(strSelect)


            rp.Subreports("acumuladoMesAnt").DataSource = arti.DevuelveTabla2(strSelect)
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha1

            'rp.Subreports("acumuladoMesAnt").Parameters("@Fecha").Values.Add(Fecha1)
            'rp.Subreports.Item("acumuladoMesAnt").Parameters("@Fecha").Values.Add(Fecha1)
            'rp.Subreports("acumuladoMesAnt").Parameters("@Fecha").Values.Item("@Fecha")
            'rp.Parameters("fecha1a").Values.Add(Fecha1)
            'rp.Parameters("fecha2a").Values.Add(Fecha2)

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try


    End Sub

    Function Work_Days(ByVal Fecha1 As Object, ByVal Fecha2 As Object) As Integer
        ' No descuenta los Dias Festivos.
        Dim WholeWeeks As Object
        Dim DateCnt As Object
        Dim EndDays As Integer

        Fecha1 = DateValue(Fecha1)
        Fecha2 = DateValue(Fecha2)
        WholeWeeks = DateDiff("w", Fecha1, Fecha2)
        DateCnt = DateAdd("ww", WholeWeeks, Fecha1)
        EndDays = 0
        Do While DateCnt < Fecha2
            If Format(DateCnt, "ddd") <> "Sun" And _
                             Format(DateCnt, "ddd") <> "Sat" Then
                EndDays = EndDays + 1
            End If
            DateCnt = DateAdd("d", 1, DateCnt)
        Loop
        Work_Days = WholeWeeks * 5 + EndDays
    End Function
    Function Dias_naturales(ByVal Fecha1 As Object, ByVal Fecha2 As Object) As Integer
        ' No descuenta los Dias Festivos.
        Dim WholeWeeks As Object
        Dim DateCnt As Object
        Dim EndDays As Integer

        Fecha1 = DateValue(Fecha1)
        Fecha2 = DateValue(Fecha2)
        WholeWeeks = DateDiff("w", Fecha1, Fecha2)
        DateCnt = DateAdd("ww", WholeWeeks, Fecha1)
        EndDays = 0
        Do While DateCnt < Fecha2
            'If Format(DateCnt, "ddd") <> "Sun" And _
            'Format(DateCnt, "ddd") <> "Sat" Then
            EndDays = EndDays + 1
            'End If
            DateCnt = DateAdd("d", 1, DateCnt)
        Loop
        Dias_naturales = WholeWeeks * 5 + EndDays
    End Function
    Private Sub GenerarInformeBeneficio4(ByVal Fecha1 As Date, ByVal Fecha2 As Date)
        Dim rp As New Report("INFHERRAM")
        Dim filtro As New Filter
        Dim laborables As String

        'Dim e As Engine.UI.ReportDesignObjectsEventArgs

        laborables = Dias_naturales(Fecha1, Fecha2)

        'filtro.Add("Nobra", FilterOperator.Equal, obra)

        'no la paso por el fltro para que me saque todos los datos hasta la fecha que le indique yo.

        'filtro.Add("fechaMovimiento", FilterOperator.GreaterThanOrEqual, Fecha1)
        filtro.Add("fechaDocumento", FilterOperator.LessThanOrEqual, Fecha2)
        rp.DataSource = New BE.DataEngine().Filter("vfrmTransferenciasHerramienta", filtro)
        Try
            rp.Formulas("laborables").Text = laborables
            rp.Formulas("fecha1").Text = Fecha1
            rp.Formulas("fecha2").Text = Fecha2
            Dim strSelect As String = "SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect &= "FROM tbhistoricomovimiento "
            strSelect &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR "
            strSelect &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-') AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '2003') "
            strSelect &= "ORDER BY dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.IDArticulo "
            'MsgBox(strSelect)


            Dim strSelect2 As String = "SELECT idAlmacen,(select distinct count(IDArticulo)) as mov FROM "
            strSelect2 &= "(SELECT dbo.tbHistoricoMovimiento.IDLineaMovimiento, dbo.tbHistoricoMovimiento.IDMovimiento, "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento, dbo.tbHistoricoMovimiento.IDArticulo, dbo.tbMaestroArticulo.DescArticulo, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.Cantidad, dbo.tbHistoricoMovimiento.IDAlmacen, dbo.tbHistoricoMovimiento.Lote, dbo.tbHistoricoMovimiento.Ubicacion, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.FechaDocumento, dbo.tbHistoricoMovimiento.Acumulado, dbo.tbHistoricoMovimiento.FechaMovimiento, "
            strSelect2 &= "dbo.tbHistoricoMovimiento.PrecioA, dbo.tbHistoricoMovimiento.PrecioB, dbo.tbMaestroArticulo.IDTipo, dbo.tbMaestroArticulo.IDFamilia, "
            strSelect2 &= "dbo.tbMaestroArticulo.IDSubfamilia, dbo.tbHistoricoMovimiento.IDTipoMovimiento, dbo.tbHistoricoMovimiento.Documento, "
            strSelect2 &= "dbo.tbMaestroArticulo.NSerieObligatorio, dbo.tbHistoricoMovimiento.IDObra, dbo.tbObraCabecera.NObra, dbo.tbMaestroArticulo.ValorReposicionA, "
            strSelect2 &= "dbo.tbMaestroArticulo.PrecioEstandarA "
            strSelect2 &= "FROM dbo.tbObraCabecera RIGHT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento INNER JOIN "
            strSelect2 &= "dbo.tbHistoricoMovimiento ON dbo.tbMaestroTipoMovimiento.IDTipoMovimiento = dbo.tbHistoricoMovimiento.IDTipoMovimiento ON "
            strSelect2 &= "dbo.tbObraCabecera.IDObra = dbo.tbHistoricoMovimiento.IDObra LEFT OUTER JOIN "
            strSelect2 &= "dbo.tbMaestroArticulo ON dbo.tbHistoricoMovimiento.IDArticulo = dbo.tbMaestroArticulo.IDArticulo INNER JOIN "
            strSelect2 &= "dbo.tbMaestroAlmacen ON dbo.tbHistoricoMovimiento.IDAlmacen = dbo.tbMaestroAlmacen.IDAlmacen INNER JOIN "
            strSelect2 &= "(SELECT idarticulo, idalmacen, MAX(fechaDocumento) AS fecha "
            strSelect2 &= "FROM tbhistoricomovimiento "
            strSelect2 &= "WHERE fechaDocumento <'" & Fecha1 & "' "
            strSelect2 &= "GROUP BY idarticulo, idalmacen) FechaMaxima ON dbo.tbHistoricoMovimiento.IDArticulo = FechaMaxima.idarticulo AND "
            strSelect2 &= "dbo.tbHistoricoMovimiento.IDAlmacen = FechaMaxima.idalmacen And FechaMaxima.fecha = dbo.tbHistoricoMovimiento.FechaDocumento "
            strSelect2 &= "WHERE (dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T+' OR "
            strSelect2 &= "dbo.tbMaestroTipoMovimiento.CodTipoMovimiento = 'T-') AND (dbo.tbMaestroAlmacen.Activo = 1) AND (dbo.tbMaestroArticulo.IDFamilia = '2003')) as X "
            strSelect2 &= "where acumulado <> 0 and PrecioEstandarA <> 0 group by idAlmacen "



            Dim strSelect3 As String = "select idalmacen, idArticulo, count(idlineamovimiento)as movimientos from vfrmTransferenciasHerramienta"
            strSelect3 &= " where fechaDocumento between '" & Fecha1 & "' and '" & Fecha2 & "' group by idarticulo,idalmacen order by idalmacen"

            Dim arti As New Articulo
            rp.Subreports("ComprobacionMovimientos").DataSource = arti.DevuelveTabla2(strSelect3)
            rp.Subreports("acumuladoMesAnt").DataSource = arti.DevuelveTabla2(strSelect)
            rp.Subreports("acumuladoMesAnt").Formulas("fechaMax").Text = Fecha2
            rp.Subreports("ComprobacionAlmacen").DataSource = arti.DevuelveTabla2(strSelect2)

            'rp.Subreports("acumuladoMesAnt").Parameters("@Fecha").Values.Add(Fecha1)
            'rp.Subreports.Item("acumuladoMesAnt").Parameters("@Fecha").Values.Add(Fecha1)
            'rp.Subreports("acumuladoMesAnt").Parameters("@Fecha").Values.Item("@Fecha")
            'rp.Parameters("fecha1a").Values.Add(Fecha1)
            'rp.Parameters("fecha2a").Values.Add(Fecha2)

            ExpertisApp.OpenReport(rp)
        Catch ex As SqlClient.SqlException
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub IDObra_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles IDObra.SetPredefinedFilter
        e.Filter.Add("TipoMnto", enumTipoObra.tpalquiler)
    End Sub
End Class
