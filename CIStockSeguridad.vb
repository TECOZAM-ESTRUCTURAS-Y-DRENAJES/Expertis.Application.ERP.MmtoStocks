Public Class CIStockSeguridad
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
    Friend WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDAlmacen As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents fwiStockBool As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim fwiStockBool_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIStockSeguridad))
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDAlmacen = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.fwiStockBool = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.fwiStockBool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Controls.Add(Me.fwiStockBool)
        Me.FilterPanel.Controls.Add(Me.lblIDArticulo)
        Me.FilterPanel.Controls.Add(Me.advIDArticulo)
        Me.FilterPanel.Controls.Add(Me.lblIDAlmacen)
        Me.FilterPanel.Controls.Add(Me.advIDAlmacen)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 261)
        Me.FilterPanel.Size = New System.Drawing.Size(672, 88)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(672, 261)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ArticuloAlmacen"
        Me.Grid.KeyField = "IDArticulo"
        Me.Grid.PrimaryDataFields = ""
        Me.Grid.SecondaryDataFields = ""
        Me.Grid.Size = New System.Drawing.Size(672, 261)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "VFrmCIStockSeguridad"
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
        Me.MainPanel.Size = New System.Drawing.Size(672, 349)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(672, 349)
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(24, 26)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 0
        Me.lblIDArticulo.Text = "Artículo"
        '
        'advIDArticulo
        '
        Me.TryDataBinding(advIDArticulo, New System.Windows.Forms.Binding("Text", Me, "IDArticulo", True))
        Me.advIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.advIDArticulo.EntityName = "Articulo"
        Me.advIDArticulo.Location = New System.Drawing.Point(96, 24)
        Me.advIDArticulo.Name = "advIDArticulo"
        Me.advIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.advIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.advIDArticulo.Size = New System.Drawing.Size(121, 23)
        Me.advIDArticulo.TabIndex = 1
        Me.advIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'lblIDAlmacen
        '
        Me.lblIDAlmacen.Location = New System.Drawing.Point(24, 56)
        Me.lblIDAlmacen.Name = "lblIDAlmacen"
        Me.lblIDAlmacen.Size = New System.Drawing.Size(56, 13)
        Me.lblIDAlmacen.TabIndex = 2
        Me.lblIDAlmacen.Text = "Almacen"
        '
        'advIDAlmacen
        '
        Me.TryDataBinding(advIDAlmacen, New System.Windows.Forms.Binding("Text", Me, "IDAlmacen", True))
        Me.advIDAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.advIDAlmacen.DisplayField = "IDAlmacen"
        Me.advIDAlmacen.EntityName = "ArticuloAlmacen"
        Me.advIDAlmacen.Location = New System.Drawing.Point(96, 56)
        Me.advIDAlmacen.Name = "advIDAlmacen"
        Me.advIDAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.advIDAlmacen.Size = New System.Drawing.Size(121, 23)
        Me.advIDAlmacen.TabIndex = 3
        Me.advIDAlmacen.ViewName = "tbMaestroArticuloAlmacen"
        '
        'fwiStockBool
        '
        fwiStockBool_DesignTimeLayout.LayoutString = resources.GetString("fwiStockBool_DesignTimeLayout.LayoutString")
        Me.fwiStockBool.DesignTimeLayout = fwiStockBool_DesignTimeLayout
        Me.fwiStockBool.DisabledBackColor = System.Drawing.Color.White
        Me.fwiStockBool.Location = New System.Drawing.Point(480, 24)
        Me.fwiStockBool.Name = "fwiStockBool"
        Me.fwiStockBool.SelectedIndex = -1
        Me.fwiStockBool.SelectedItem = Nothing
        Me.fwiStockBool.Size = New System.Drawing.Size(120, 21)
        Me.fwiStockBool.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(312, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Stock < Stock Seguridad "
        '
        'CIStockSeguridad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 437)
        Me.EntityName = "ArticuloAlmacen"
        Me.KeyField = "IDArticulo"
        Me.Name = "CIStockSeguridad"
        Me.Text = "CIStockSeguridad"
        Me.ViewName = "VFrmCIStockSeguridad"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.fwiStockBool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub CIStockSeguridad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fwiStockBool.DataSource = New EnumData("enumboolean")
            fwiStockBool.Value = CInt(enumBoolean.Todos)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub advIDAlmacen_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles advIDAlmacen.SetPredefinedFilter
        Try        
            If Len(advIDArticulo.Text) > 0 Then
                e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CIStockSeguridad_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        Try
            e.Filter.Add("IDArticulo", FilterOperator.Equal, advIDArticulo.Text, FilterType.String)
            e.Filter.Add("IDAlmacen", FilterOperator.Equal, advIDAlmacen.Text, FilterType.String)
            If Not fwiStockBool.Value Is Nothing Then
                If fwiStockBool.Value = enumBoolean.Si Then
                    e.Filter.Add("Diferencia", FilterOperator.LessThan, 0, FilterType.Numeric)
                ElseIf fwiStockBool.Value = enumBoolean.No Then
                    e.Filter.Add("Diferencia", FilterOperator.GreaterThanOrEqual, 0, FilterType.Numeric)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   


End Class
