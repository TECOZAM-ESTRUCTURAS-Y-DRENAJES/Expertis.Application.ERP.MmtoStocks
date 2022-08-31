<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeFechaFamilia
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
        Dim cbFamilia_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInformeFechaFamilia))
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbValorado = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvAlmacen = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.cbFamilia = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        CType(Me.cbFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cbValorado)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.AdvAlmacen)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.cbFamilia)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Location = New System.Drawing.Point(30, 24)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(233, 132)
        Me.Frame1.TabIndex = 12
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Filtros Fecha"
        '
        'cbValorado
        '
        Me.cbValorado.Location = New System.Drawing.Point(97, 106)
        Me.cbValorado.Name = "cbValorado"
        Me.cbValorado.Size = New System.Drawing.Size(26, 23)
        Me.cbValorado.TabIndex = 9
        Me.cbValorado.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(19, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Valorado"
        Me.Label5.Visible = False
        '
        'AdvAlmacen
        '
        Me.AdvAlmacen.DisabledBackColor = System.Drawing.Color.White
        Me.AdvAlmacen.EntityName = "Almacen"
        Me.AdvAlmacen.Location = New System.Drawing.Point(97, 70)
        Me.AdvAlmacen.Name = "AdvAlmacen"
        Me.AdvAlmacen.SecondaryDataFields = "IDAlmacen"
        Me.AdvAlmacen.Size = New System.Drawing.Size(117, 23)
        Me.AdvAlmacen.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Almacen"
        '
        'cbFamilia
        '
        cbFamilia_DesignTimeLayout.LayoutString = resources.GetString("cbFamilia_DesignTimeLayout.LayoutString")
        Me.cbFamilia.DesignTimeLayout = cbFamilia_DesignTimeLayout
        Me.cbFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.cbFamilia.Location = New System.Drawing.Point(97, 29)
        Me.cbFamilia.Name = "cbFamilia"
        Me.cbFamilia.SelectedIndex = -1
        Me.cbFamilia.SelectedItem = Nothing
        Me.cbFamilia.Size = New System.Drawing.Size(117, 21)
        Me.cbFamilia.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Familia"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(176, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Aceptar"
        '
        'frmInformeFechaFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 239)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmInformeFechaFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInformeFechaFamilia"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.cbFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbFamilia As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cbValorado As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvAlmacen As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
End Class
