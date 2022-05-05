<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CltStock
    Inherits Solmicro.Expertis.Engine.UI.CIMnto


    Public Sub New()
        MyBase.New()

        InitializeComponent()
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
    Friend WithEvents Fra2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiIdArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulbDescArticulo As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents lblNSerie As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FwiFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FwiFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Panel3 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents jngMovimientos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FwiTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FwNumeroSerie As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblMov As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents fwiStock As Solmicro.Expertis.Engine.UI.NumericTextBox

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim jngMovimientos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CltStock))
        Me.Fra2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.FwNumeroSerie = New Solmicro.Expertis.Engine.UI.TextBox
        Me.FwiTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.ulbDescArticulo = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.FwiIdArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblNSerie = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Panel3 = New Solmicro.Expertis.Engine.UI.Panel
        Me.jngMovimientos = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblMov = New Solmicro.Expertis.Engine.UI.Label
        Me.FwiFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FwiFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.fwiStock = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.Fra2.suspendlayout()
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        Me.Panel3.suspendlayout()
        CType(Me.jngMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.suspendlayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Frame2)
        Me.FilterPanel.Controls.Add(Me.Panel1)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 286)
        Me.FilterPanel.Size = New System.Drawing.Size(776, 176)
        Me.FilterPanel.Text = ""
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Controls.Add(Me.Fra2)
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(776, 286)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Fra2, 0)
        Me.CIMntoGridPanel.Controls.SetChildIndex(Me.Grid, 0)
        '
        'Grid
        '
        Me.Grid.AlternatingColors = True
        Me.Grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Grid.DataSource = Me
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "AlbaranVentaLinea"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Grid.Location = New System.Drawing.Point(0, 56)
        Me.Grid.Size = New System.Drawing.Size(776, 230)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vFrmStockNSerie"
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
        Me.MainPanel.Size = New System.Drawing.Size(776, 462)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(776, 462)
        '
        'Fra2
        '
        Me.Fra2.Controls.Add(Me.Frame1)
        Me.Fra2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Fra2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fra2.Location = New System.Drawing.Point(0, 0)
        Me.Fra2.Name = "Fra2"
        Me.Fra2.Size = New System.Drawing.Size(776, 56)
        Me.Fra2.TabIndex = 1
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.Controls.Add(Me.FwNumeroSerie)
        Me.Frame1.Controls.Add(Me.FwiTotal)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.ulbDescArticulo)
        Me.Frame1.Controls.Add(Me.FwiIdArticulo)
        Me.Frame1.Controls.Add(Me.lblIDArticulo)
        Me.Frame1.Controls.Add(Me.lblNSerie)
        Me.Frame1.Location = New System.Drawing.Point(8, 1)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(760, 47)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'FwNumeroSerie
        '
        Me.TryDataBinding(FwNumeroSerie, New System.Windows.Forms.Binding("Text", Me, "NSerie", True))
        Me.FwNumeroSerie.DisabledBackColor = System.Drawing.Color.White
        Me.FwNumeroSerie.Location = New System.Drawing.Point(408, 16)
        Me.FwNumeroSerie.Name = "FwNumeroSerie"
        Me.FwNumeroSerie.Size = New System.Drawing.Size(88, 21)
        Me.FwNumeroSerie.TabIndex = 2
        '
        'FwiTotal
        '
        Me.FwiTotal.DisabledBackColor = System.Drawing.Color.White
        Me.FwiTotal.Enabled = False
        Me.FwiTotal.Location = New System.Drawing.Point(648, 16)
        Me.FwiTotal.Name = "FwiTotal"
        Me.FwiTotal.Size = New System.Drawing.Size(104, 21)
        Me.FwiTotal.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(608, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ulbDescArticulo
        '
        Me.TryDataBinding(ulbDescArticulo, New System.Windows.Forms.Binding("Text", Me.FwiIdArticulo, "DescArticulo", True))
        Me.ulbDescArticulo.Location = New System.Drawing.Point(160, 16)
        Me.ulbDescArticulo.Name = "ulbDescArticulo"
        Me.ulbDescArticulo.Size = New System.Drawing.Size(152, 23)
        Me.ulbDescArticulo.TabIndex = 0
        '
        'FwiIdArticulo
        '
        Me.TryDataBinding(FwiIdArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.FwiIdArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.FwiIdArticulo.EntityName = "Articulo"
        Me.FwiIdArticulo.Location = New System.Drawing.Point(64, 16)
        Me.FwiIdArticulo.Name = "FwiIdArticulo"
        Me.FwiIdArticulo.PrimaryDataFields = "IDArticulo"
        Me.FwiIdArticulo.SecondaryDataFields = "IDArticulo"
        Me.FwiIdArticulo.Size = New System.Drawing.Size(88, 23)
        Me.FwiIdArticulo.TabIndex = 1
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(8, 16)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 0
        Me.lblIDArticulo.Text = "Articulo"
        Me.lblIDArticulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNSerie
        '
        Me.lblNSerie.Location = New System.Drawing.Point(336, 16)
        Me.lblNSerie.Name = "lblNSerie"
        Me.lblNSerie.Size = New System.Drawing.Size(47, 13)
        Me.lblNSerie.TabIndex = 0
        Me.lblNSerie.Text = "Colada"
        Me.lblNSerie.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(8, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 152)
        Me.Panel1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.jngMovimientos)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 120)
        Me.Panel3.TabIndex = 2
        '
        'jngMovimientos
        '
        Me.jngMovimientos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMovimientos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMovimientos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.jngMovimientos.AlternatingColors = True
        Me.jngMovimientos.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        jngMovimientos_DesignTimeLayout.LayoutString = resources.GetString("jngMovimientos_DesignTimeLayout.LayoutString")
        Me.jngMovimientos.DesignTimeLayout = jngMovimientos_DesignTimeLayout
        Me.jngMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.jngMovimientos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.jngMovimientos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.jngMovimientos.EntityName = "AlbaranVentaLinea"
        Me.jngMovimientos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.jngMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.jngMovimientos.Name = "jngMovimientos"
        Me.jngMovimientos.PrimaryDataFields = ""
        Me.jngMovimientos.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.jngMovimientos.SecondaryDataFields = ""
        Me.jngMovimientos.Size = New System.Drawing.Size(520, 120)
        Me.jngMovimientos.TabIndex = 0
        Me.jngMovimientos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.jngMovimientos.ViewName = "vFrmMovimientosNSerie"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblMov)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(520, 32)
        Me.Panel2.TabIndex = 0
        '
        'lblMov
        '
        Me.lblMov.Location = New System.Drawing.Point(8, 8)
        Me.lblMov.Name = "lblMov"
        Me.lblMov.Size = New System.Drawing.Size(78, 13)
        Me.lblMov.TabIndex = 0
        Me.lblMov.Text = "Movimientos"
        '
        'FwiFechaDesde
        '
        Me.FwiFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaDesde.Location = New System.Drawing.Point(112, 56)
        Me.FwiFechaDesde.Name = "FwiFechaDesde"
        Me.FwiFechaDesde.Size = New System.Drawing.Size(104, 21)
        Me.FwiFechaDesde.TabIndex = 5
        '
        'FwiFechaHasta
        '
        Me.FwiFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FwiFechaHasta.Location = New System.Drawing.Point(112, 80)
        Me.FwiFechaHasta.Name = "FwiFechaHasta"
        Me.FwiFechaHasta.Size = New System.Drawing.Size(104, 21)
        Me.FwiFechaHasta.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha Desde"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Fecha Hasta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Stock > "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.FwiFechaDesde)
        Me.Frame2.Controls.Add(Me.FwiFechaHasta)
        Me.Frame2.Controls.Add(Me.fwiStock)
        Me.Frame2.Location = New System.Drawing.Point(536, 40)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(232, 128)
        Me.Frame2.TabIndex = 7
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Criterios de Consulta "
        '
        'fwiStock
        '
        Me.fwiStock.DisabledBackColor = System.Drawing.Color.White
        Me.fwiStock.Location = New System.Drawing.Point(112, 32)
        Me.fwiStock.Name = "fwiStock"
        Me.fwiStock.Size = New System.Drawing.Size(104, 21)
        Me.fwiStock.TabIndex = 8
        '
        'CltStock
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 550)
        Me.EntityName = "AlbaranVentaLinea"
        Me.Name = "CltStock"
        Me.Text = "CltStock"
        Me.ViewName = "vFrmStockNSerie"
        Me.FilterPanel.ResumeLayout(False)
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.Fra2.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.jngMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
End Class
