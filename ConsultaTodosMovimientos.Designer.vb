<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaTodosMovimientos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim TipoMovimiento_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaTodosMovimientos))
        Me.lblfwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiSubfamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFDocumentoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiTipoMov = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiFDocumentoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.lblfwiNDocumento = New Solmicro.Expertis.Engine.UI.Label
        Me.Articulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TipoArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Subfamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Almacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FechaDocumentoDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.TipoMovimiento = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FechaDocumentoHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.MostrarCorrecciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Documento = New Solmicro.Expertis.Engine.UI.TextBox
        Me.IDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblFwiIDObra = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.TipoMovimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
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
        Me.FilterPanel.Location = New System.Drawing.Point(0, 207)
        Me.FilterPanel.Size = New System.Drawing.Size(790, 109)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(790, 207)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.PrimaryDataFields = "IDLineaMovimiento"
        Me.Grid.SecondaryDataFields = "IDLineaMovimiento"
        Me.Grid.Size = New System.Drawing.Size(790, 207)
        Me.Grid.ViewName = "vFrmCIMovimientosE4_1"
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
        Me.MainPanel.Size = New System.Drawing.Size(790, 316)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(790, 316)
        '
        'lblfwiArticulo
        '
        Me.lblfwiArticulo.Location = New System.Drawing.Point(-1, 21)
        Me.lblfwiArticulo.Name = "lblfwiArticulo"
        Me.lblfwiArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblfwiArticulo.TabIndex = 110
        Me.lblfwiArticulo.Tag = "IdRec=4430;"
        Me.lblfwiArticulo.Text = "Artículo"
        '
        'lblfwiFamilia
        '
        Me.lblfwiFamilia.Location = New System.Drawing.Point(205, 48)
        Me.lblfwiFamilia.Name = "lblfwiFamilia"
        Me.lblfwiFamilia.Size = New System.Drawing.Size(46, 13)
        Me.lblfwiFamilia.TabIndex = 111
        Me.lblfwiFamilia.Tag = "IdRec=4454;"
        Me.lblfwiFamilia.Text = "Familia"
        '
        'lblfwiTipoArticulo
        '
        Me.lblfwiTipoArticulo.Location = New System.Drawing.Point(205, 22)
        Me.lblfwiTipoArticulo.Name = "lblfwiTipoArticulo"
        Me.lblfwiTipoArticulo.Size = New System.Drawing.Size(31, 13)
        Me.lblfwiTipoArticulo.TabIndex = 112
        Me.lblfwiTipoArticulo.Tag = "IdRec=4456;"
        Me.lblfwiTipoArticulo.Text = "Tipo"
        '
        'lblfwiSubfamilia
        '
        Me.lblfwiSubfamilia.Location = New System.Drawing.Point(205, 74)
        Me.lblfwiSubfamilia.Name = "lblfwiSubfamilia"
        Me.lblfwiSubfamilia.Size = New System.Drawing.Size(67, 13)
        Me.lblfwiSubfamilia.TabIndex = 113
        Me.lblfwiSubfamilia.Tag = "IdRec=4452;"
        Me.lblfwiSubfamilia.Text = "Subfamilia"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(-1, 47)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblfwiAlmacen.TabIndex = 114
        Me.lblfwiAlmacen.Tag = "IdRec=4408;"
        Me.lblfwiAlmacen.Text = "Almacén"
        '
        'lblfwiFDocumentoDesde
        '
        Me.lblfwiFDocumentoDesde.Location = New System.Drawing.Point(383, 22)
        Me.lblfwiFDocumentoDesde.Name = "lblfwiFDocumentoDesde"
        Me.lblfwiFDocumentoDesde.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoDesde.TabIndex = 115
        Me.lblfwiFDocumentoDesde.Tag = "IdRec=5251;"
        Me.lblfwiFDocumentoDesde.Text = "Fecha Doc. >="
        '
        'lblfwiTipoMov
        '
        Me.lblfwiTipoMov.Location = New System.Drawing.Point(383, 47)
        Me.lblfwiTipoMov.Name = "lblfwiTipoMov"
        Me.lblfwiTipoMov.Size = New System.Drawing.Size(100, 13)
        Me.lblfwiTipoMov.TabIndex = 116
        Me.lblfwiTipoMov.Tag = "IdRec=5250;"
        Me.lblfwiTipoMov.Text = "Tipo Movimiento"
        '
        'lblfwiFDocumentoHasta
        '
        Me.lblfwiFDocumentoHasta.Location = New System.Drawing.Point(592, 21)
        Me.lblfwiFDocumentoHasta.Name = "lblfwiFDocumentoHasta"
        Me.lblfwiFDocumentoHasta.Size = New System.Drawing.Size(92, 13)
        Me.lblfwiFDocumentoHasta.TabIndex = 117
        Me.lblfwiFDocumentoHasta.Tag = "IdRec=4251;"
        Me.lblfwiFDocumentoHasta.Text = "Fecha Doc. <="
        '
        'lblfwiNDocumento
        '
        Me.lblfwiNDocumento.Location = New System.Drawing.Point(385, 74)
        Me.lblfwiNDocumento.Name = "lblfwiNDocumento"
        Me.lblfwiNDocumento.Size = New System.Drawing.Size(90, 13)
        Me.lblfwiNDocumento.TabIndex = 118
        Me.lblfwiNDocumento.Tag = "IdRec=6710;"
        Me.lblfwiNDocumento.Text = "Nº Documento"
        '
        'Articulo
        '
        Me.Articulo.DisabledBackColor = System.Drawing.Color.White
        Me.Articulo.EntityName = "Articulo"
        Me.Articulo.Location = New System.Drawing.Point(91, 17)
        Me.Articulo.Name = "Articulo"
        Me.Articulo.PrimaryDataFields = "IDArticulo"
        Me.Articulo.SecondaryDataFields = "IDArticulo"
        Me.Articulo.Size = New System.Drawing.Size(108, 23)
        Me.Articulo.TabIndex = 93
        Me.Articulo.ViewName = "tbMaestroArticulo"
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(277, 43)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.PrimaryDataFields = "IDFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(100, 23)
        Me.AdvFamilia.TabIndex = 98
        Me.AdvFamilia.ViewName = "tbMaestroFamilia"
        '
        'TipoArticulo
        '
        Me.TipoArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.TipoArticulo.EntityName = "TipoArticulo"
        Me.TipoArticulo.Location = New System.Drawing.Point(277, 17)
        Me.TipoArticulo.Name = "TipoArticulo"
        Me.TipoArticulo.PrimaryDataFields = "IDTipo"
        Me.TipoArticulo.SecondaryDataFields = "IDTipo"
        Me.TipoArticulo.Size = New System.Drawing.Size(100, 23)
        Me.TipoArticulo.TabIndex = 97
        Me.TipoArticulo.ViewName = "tbMaestroTipoArticulo"
        '
        'Subfamilia
        '
        Me.Subfamilia.DisabledBackColor = System.Drawing.Color.White
        Me.Subfamilia.EntityName = "Subfamilia"
        Me.Subfamilia.Location = New System.Drawing.Point(277, 69)
        Me.Subfamilia.Name = "Subfamilia"
        Me.Subfamilia.PrimaryDataFields = "IDSubfamilia"
        Me.Subfamilia.SecondaryDataFields = "IDSubfamilia"
        Me.Subfamilia.Size = New System.Drawing.Size(100, 23)
        Me.Subfamilia.TabIndex = 99
        Me.Subfamilia.ViewName = "tbMaestroSubfamilia"
        '
        'Almacen
        '
        Me.Almacen.DisabledBackColor = System.Drawing.Color.White
        Me.Almacen.EntityName = "Almacen"
        Me.Almacen.Location = New System.Drawing.Point(91, 43)
        Me.Almacen.Name = "Almacen"
        Me.Almacen.PrimaryDataFields = "IDAlmacen"
        Me.Almacen.SecondaryDataFields = "IDAlmacen"
        Me.Almacen.Size = New System.Drawing.Size(108, 23)
        Me.Almacen.TabIndex = 94
        Me.Almacen.ViewName = "tbMaestroAlmacen"
        '
        'FechaDocumentoDesde
        '
        Me.FechaDocumentoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoDesde.Location = New System.Drawing.Point(486, 17)
        Me.FechaDocumentoDesde.Name = "FechaDocumentoDesde"
        Me.FechaDocumentoDesde.Size = New System.Drawing.Size(100, 21)
        Me.FechaDocumentoDesde.TabIndex = 103
        '
        'TipoMovimiento
        '
        TipoMovimiento_DesignTimeLayout.LayoutString = resources.GetString("TipoMovimiento_DesignTimeLayout.LayoutString")
        Me.TipoMovimiento.DesignTimeLayout = TipoMovimiento_DesignTimeLayout
        Me.TipoMovimiento.DisabledBackColor = System.Drawing.Color.White
        Me.TipoMovimiento.DisplayMember = "CodTipoMovimiento"
        Me.TipoMovimiento.EntityName = "TipoMovimiento"
        Me.TipoMovimiento.Location = New System.Drawing.Point(486, 43)
        Me.TipoMovimiento.Name = "TipoMovimiento"
        Me.TipoMovimiento.PrimaryDataFields = "IDTipoMovimiento"
        Me.TipoMovimiento.SecondaryDataFields = "IDArticuloPadre"
        Me.TipoMovimiento.SelectedIndex = -1
        Me.TipoMovimiento.SelectedItem = Nothing
        Me.TipoMovimiento.Size = New System.Drawing.Size(100, 21)
        Me.TipoMovimiento.TabIndex = 105
        Me.TipoMovimiento.ValueMember = "IDTipoMovimiento"
        Me.TipoMovimiento.ViewName = "tbMaestroTipoMovimiento"
        '
        'FechaDocumentoHasta
        '
        Me.FechaDocumentoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDocumentoHasta.Location = New System.Drawing.Point(686, 16)
        Me.FechaDocumentoHasta.Name = "FechaDocumentoHasta"
        Me.FechaDocumentoHasta.Size = New System.Drawing.Size(91, 21)
        Me.FechaDocumentoHasta.TabIndex = 104
        '
        'MostrarCorrecciones
        '
        Me.MostrarCorrecciones.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.MostrarCorrecciones.Location = New System.Drawing.Point(595, 41)
        Me.MostrarCorrecciones.Name = "MostrarCorrecciones"
        Me.MostrarCorrecciones.Size = New System.Drawing.Size(183, 24)
        Me.MostrarCorrecciones.TabIndex = 106
        Me.MostrarCorrecciones.Text = "Mostrar Correcciones"
        '
        'Documento
        '
        Me.Documento.DisabledBackColor = System.Drawing.Color.White
        Me.Documento.Location = New System.Drawing.Point(486, 69)
        Me.Documento.Name = "Documento"
        Me.Documento.Size = New System.Drawing.Size(100, 21)
        Me.Documento.TabIndex = 107
        '
        'IDObra
        '
        Me.IDObra.DisabledBackColor = System.Drawing.Color.White
        Me.IDObra.DisplayField = "NObra"
        Me.IDObra.EntityName = "ObraCabecera"
        Me.IDObra.Location = New System.Drawing.Point(91, 72)
        Me.IDObra.Name = "IDObra"
        Me.IDObra.PrimaryDataFields = "IDObra"
        Me.IDObra.SecondaryDataFields = "IDObra"
        Me.IDObra.Size = New System.Drawing.Size(108, 23)
        Me.IDObra.TabIndex = 100
        Me.IDObra.ViewName = "tbObraCabecera"
        '
        'lblFwiIDObra
        '
        Me.lblFwiIDObra.Location = New System.Drawing.Point(3, 77)
        Me.lblFwiIDObra.Name = "lblFwiIDObra"
        Me.lblFwiIDObra.Size = New System.Drawing.Size(57, 13)
        Me.lblFwiIDObra.TabIndex = 109
        Me.lblFwiIDObra.Tag = ""
        Me.lblFwiIDObra.Text = "Proyecto"
        '
        'ConsultaTodosMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 404)
        Me.Name = "ConsultaTodosMovimientos"
        Me.Text = "ConsultaTodosMovimientos"
        Me.ViewName = "vFrmCIMovimientosE4_1"
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblfwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiSubfamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiTipoMov As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiFDocumentoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiNDocumento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Articulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Public WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TipoArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Subfamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Almacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FechaDocumentoDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents TipoMovimiento As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents FechaDocumentoHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents MostrarCorrecciones As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents Documento As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFwiIDObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents IDObra As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
