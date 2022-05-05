Public Class TransferenciaPortes
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
    Friend WithEvents FwIEstadoActivo As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblFwIEstadoActivo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiNserie As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiNserie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiNserie As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiAlmacen As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents fwiAlmacenNS As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblfwiAlmacenNS As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblcfwiAlmacenNS As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FwIEstadoActivo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblFwIEstadoActivo = New Solmicro.Expertis.Engine.UI.Label
        Me.fwiNserie = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiNserie = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiNserie = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiAlmacen = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.fwiAlmacenNS = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblfwiAlmacenNS = New Solmicro.Expertis.Engine.UI.Label
        Me.lblcfwiAlmacenNS = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        CType(Me.FilterPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FilterPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.lblFwIEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.FwIEstadoActivo)
        Me.FilterPanel.Controls.Add(Me.lblfwiNserie)
        Me.FilterPanel.Controls.Add(Me.lblcfwiNserie)
        Me.FilterPanel.Controls.Add(Me.fwiNserie)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblcfwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.fwiAlmacen)
        Me.FilterPanel.Controls.Add(Me.lblfwiAlmacenNS)
        Me.FilterPanel.Controls.Add(Me.lblcfwiAlmacenNS)
        Me.FilterPanel.Controls.Add(Me.fwiAlmacenNS)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 361)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(696, 96)
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(696, 457)
        '
        'Grid
        '
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(696, 457)
        '
        'Export
        '
        Me.Export.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 26)
        Me.Menubar.Name = "Menubar"
        Me.Menubar.Size = New System.Drawing.Size(87, 26)
        '
        'ClearFilter
        '
        Me.ClearFilter.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'UncheckAll
        '
        Me.UncheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'CheckAll
        '
        Me.CheckAll.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(106, 26)
        '
        'FwIEstadoActivo
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition ID="""" /></RootTable><RowWithErrorsFo" & _
        "rmatStyle><PredefinedStyle>RowWithErrorsFormatStyle</PredefinedStyle></RowWithEr" & _
        "rorsFormatStyle><LinkFormatStyle><PredefinedStyle>LinkFormatStyle</PredefinedSty" & _
        "le></LinkFormatStyle><CardCaptionFormatStyle><PredefinedStyle>CardCaptionFormatS" & _
        "tyle</PredefinedStyle></CardCaptionFormatStyle><GroupByBoxInfoFormatStyle><Prede" & _
        "finedStyle>GroupByBoxInfoFormatStyle</PredefinedStyle></GroupByBoxInfoFormatStyl" & _
        "e><GroupRowFormatStyle><PredefinedStyle>GroupRowFormatStyle</PredefinedStyle></G" & _
        "roupRowFormatStyle><HeaderFormatStyle><PredefinedStyle>HeaderFormatStyle</Predef" & _
        "inedStyle></HeaderFormatStyle><PreviewRowFormatStyle><PredefinedStyle>PreviewRow" & _
        "FormatStyle</PredefinedStyle></PreviewRowFormatStyle><RowFormatStyle><Predefined" & _
        "Style>RowFormatStyle</PredefinedStyle></RowFormatStyle><SelectedFormatStyle><Pre" & _
        "definedStyle>SelectedFormatStyle</PredefinedStyle></SelectedFormatStyle><Selecte" & _
        "dInactiveFormatStyle><PredefinedStyle>SelectedInactiveFormatStyle</PredefinedSty" & _
        "le></SelectedInactiveFormatStyle><WatermarkImage /><FlatBorderColor>125, 159, 19" & _
        "0</FlatBorderColor><ControlStyle><ButtonAppearance>Flat</ButtonAppearance></Cont" & _
        "rolStyle><VisualStyle>Standard</VisualStyle><AllowEdit>False</AllowEdit><Expanda" & _
        "bleGroups>False</ExpandableGroups><GroupByBoxVisible>False</GroupByBoxVisible><H" & _
        "ideSelection>Highlight</HideSelection></GridEXLayoutData>"
        Me.FwIEstadoActivo.DesignTimeLayout = GridEXLayout1
        Me.FwIEstadoActivo.EntityName = "MntoEstadoActivo"
        Me.FwIEstadoActivo.Location = New System.Drawing.Point(553, 28)
        Me.FwIEstadoActivo.Name = "FwIEstadoActivo"
        Me.FwIEstadoActivo.PrimaryDataFields = "IDEstadoActivo"
        Me.FwIEstadoActivo.SecondaryDataFields = "IDEstadoActivo"
        Me.FwIEstadoActivo.Size = New System.Drawing.Size(87, 22)
        Me.FwIEstadoActivo.TabIndex = 4
        Me.FwIEstadoActivo.ViewName = "tbMntoEstadoActivo"
        '
        'lblFwIEstadoActivo
        '
        Me.lblFwIEstadoActivo.Location = New System.Drawing.Point(472, 28)
        Me.lblFwIEstadoActivo.Name = "lblFwIEstadoActivo"
        Me.lblFwIEstadoActivo.Size = New System.Drawing.Size(80, 21)
        Me.lblFwIEstadoActivo.TabIndex = 0
        Me.lblFwIEstadoActivo.Tag = "IdRec=13091;"
        Me.lblFwIEstadoActivo.Text = "Estado Nº Serie"
        '
        'fwiNserie
        '
        Me.fwiNserie.EntityName = "ArticuloNSerie"
        Me.fwiNserie.Location = New System.Drawing.Point(67, 28)
        Me.fwiNserie.Name = "fwiNserie"
        Me.fwiNserie.PredefinedFilter = Nothing
        Me.fwiNserie.PrimaryDataFields = "NSerie"
        Me.fwiNserie.SecondaryDataFields = "NSerie"
        Me.fwiNserie.Size = New System.Drawing.Size(76, 22)
        Me.fwiNserie.TabIndex = 3
        Me.fwiNserie.ViewName = "tbArticuloNSerie"
        '
        'lblfwiNserie
        '
        Me.lblfwiNserie.Location = New System.Drawing.Point(16, 28)
        Me.lblfwiNserie.Name = "lblfwiNserie"
        Me.lblfwiNserie.Size = New System.Drawing.Size(50, 21)
        Me.lblfwiNserie.TabIndex = 5
        Me.lblfwiNserie.Tag = "IdRec=11628;"
        Me.lblfwiNserie.Text = "Nserie"
        '
        'lblcfwiNserie
        '
        Me.lblcfwiNserie.Location = New System.Drawing.Point(143, 28)
        Me.lblcfwiNserie.Name = "lblcfwiNserie"
        Me.lblcfwiNserie.Size = New System.Drawing.Size(100, 21)
        Me.lblcfwiNserie.TabIndex = 6
        '
        'fwiAlmacen
        '
        Me.fwiAlmacen.EntityName = "Almacen"
        Me.fwiAlmacen.Location = New System.Drawing.Point(326, 57)
        Me.fwiAlmacen.Name = "fwiAlmacen"
        Me.fwiAlmacen.PredefinedFilter = Nothing
        Me.fwiAlmacen.PrimaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.fwiAlmacen.Size = New System.Drawing.Size(87, 22)
        Me.fwiAlmacen.TabIndex = 2
        Me.fwiAlmacen.ViewName = "tbMaestroAlmacen"
        '
        'lblfwiAlmacen
        '
        Me.lblfwiAlmacen.Location = New System.Drawing.Point(192, 57)
        Me.lblfwiAlmacen.Name = "lblfwiAlmacen"
        Me.lblfwiAlmacen.Size = New System.Drawing.Size(133, 21)
        Me.lblfwiAlmacen.TabIndex = 7
        Me.lblfwiAlmacen.Tag = "IdRec=7200;"
        Me.lblfwiAlmacen.Text = "Almacén Predeterminado"
        '
        'lblcfwiAlmacen
        '
        Me.lblcfwiAlmacen.Location = New System.Drawing.Point(413, 57)
        Me.lblcfwiAlmacen.Name = "lblcfwiAlmacen"
        Me.lblcfwiAlmacen.Size = New System.Drawing.Size(100, 21)
        Me.lblcfwiAlmacen.TabIndex = 8
        '
        'fwiAlmacenNS
        '
        Me.fwiAlmacenNS.EntityName = "Articulo"
        Me.fwiAlmacenNS.Location = New System.Drawing.Point(326, 28)
        Me.fwiAlmacenNS.Name = "fwiAlmacenNS"
        Me.fwiAlmacenNS.PredefinedFilter = Nothing
        Me.fwiAlmacenNS.PrimaryDataFields = "IDArticulo"
        Me.fwiAlmacenNS.SecondaryDataFields = "IDArticulo"
        Me.fwiAlmacenNS.Size = New System.Drawing.Size(87, 22)
        Me.fwiAlmacenNS.TabIndex = 1
        Me.fwiAlmacenNS.ViewName = "tbMaestroArticulo"
        '
        'lblfwiAlmacenNS
        '
        Me.lblfwiAlmacenNS.Location = New System.Drawing.Point(192, 28)
        Me.lblfwiAlmacenNS.Name = "lblfwiAlmacenNS"
        Me.lblfwiAlmacenNS.Size = New System.Drawing.Size(133, 21)
        Me.lblfwiAlmacenNS.TabIndex = 9
        Me.lblfwiAlmacenNS.Tag = "IdRec=13092;"
        Me.lblfwiAlmacenNS.Text = "Almacén Nserie"
        '
        'lblcfwiAlmacenNS
        '
        Me.lblcfwiAlmacenNS.Location = New System.Drawing.Point(413, 28)
        Me.lblcfwiAlmacenNS.Name = "lblcfwiAlmacenNS"
        Me.lblcfwiAlmacenNS.Size = New System.Drawing.Size(100, 21)
        Me.lblcfwiAlmacenNS.TabIndex = 10
        '
        'TransferenciaPortes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(696, 509)
        Me.Name = "TransferenciaPortes"
        CType(Me.FilterPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FilterPanel.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
