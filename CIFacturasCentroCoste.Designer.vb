<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIFacturasCentroCoste
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
        Dim cbArticulo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIFacturasCentroCoste))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.CBFInicioMayor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.CBFInicioMenor = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.advCentroCoste = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.cbArticulo = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.cbArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.cbArticulo)
        Me.FilterPanel.Controls.Add(Me.txtArticulo)
        Me.FilterPanel.Controls.Add(Me.advCentroCoste)
        Me.FilterPanel.Controls.Add(Me.CBFInicioMenor)
        Me.FilterPanel.Controls.Add(Me.CBFInicioMayor)
        Me.FilterPanel.Controls.Add(Me.Label4)
        Me.FilterPanel.Controls.Add(Me.Label3)
        Me.FilterPanel.Controls.Add(Me.Label2)
        Me.FilterPanel.Controls.Add(Me.Label1)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 172)
        Me.FilterPanel.Size = New System.Drawing.Size(536, 97)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(536, 172)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(536, 172)
        Me.Grid.ViewName = "vFrmMntoFacturaCompraArticuloCentroCoste"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Articulo"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Centro de Coste"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(299, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "F. Inicio >="
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(299, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "F. Inicio <="
        '
        'CBFInicioMayor
        '
        Me.CBFInicioMayor.DisabledBackColor = System.Drawing.Color.White
        Me.CBFInicioMayor.Location = New System.Drawing.Point(389, 20)
        Me.CBFInicioMayor.Name = "CBFInicioMayor"
        Me.CBFInicioMayor.Size = New System.Drawing.Size(99, 21)
        Me.CBFInicioMayor.TabIndex = 4
        '
        'CBFInicioMenor
        '
        Me.CBFInicioMenor.DisabledBackColor = System.Drawing.Color.White
        Me.CBFInicioMenor.Location = New System.Drawing.Point(389, 50)
        Me.CBFInicioMenor.Name = "CBFInicioMenor"
        Me.CBFInicioMenor.Size = New System.Drawing.Size(99, 21)
        Me.CBFInicioMenor.TabIndex = 5
        '
        'advCentroCoste
        '
        Me.advCentroCoste.DisabledBackColor = System.Drawing.Color.White
        Me.advCentroCoste.EntityName = "CentroCosteAnalitica"
        Me.advCentroCoste.Location = New System.Drawing.Point(149, 20)
        Me.advCentroCoste.Name = "advCentroCoste"
        Me.advCentroCoste.SecondaryDataFields = "IDCentroCoste"
        Me.advCentroCoste.Size = New System.Drawing.Size(100, 23)
        Me.advCentroCoste.TabIndex = 7
        Me.advCentroCoste.ViewName = "tbMaestroCentroCosteAnalitica"
        '
        'txtArticulo
        '
        Me.txtArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.txtArticulo.Location = New System.Drawing.Point(149, 58)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(100, 21)
        Me.txtArticulo.TabIndex = 8
        '
        'cbArticulo
        '
        cbArticulo_DesignTimeLayout.LayoutString = resources.GetString("cbArticulo_DesignTimeLayout.LayoutString")
        Me.cbArticulo.DesignTimeLayout = cbArticulo_DesignTimeLayout
        Me.cbArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.cbArticulo.Location = New System.Drawing.Point(149, 58)
        Me.cbArticulo.Name = "cbArticulo"
        Me.cbArticulo.SelectedIndex = -1
        Me.cbArticulo.SelectedItem = Nothing
        Me.cbArticulo.Size = New System.Drawing.Size(100, 21)
        Me.cbArticulo.TabIndex = 9
        Me.cbArticulo.Visible = False
        '
        'CIFacturasCentroCoste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Name = "CIFacturasCentroCoste"
        Me.Text = "CIFacturasCentroCoste"
        Me.ViewName = "vFrmMntoFacturaCompraArticuloCentroCoste"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.cbArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CBFInicioMenor As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents CBFInicioMayor As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents advCentroCoste As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents cbArticulo As Solmicro.Expertis.Engine.UI.ComboBox
End Class
