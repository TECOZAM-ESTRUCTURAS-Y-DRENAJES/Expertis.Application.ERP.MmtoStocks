<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeFecha
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.FechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Button1 = New Solmicro.Expertis.Engine.UI.Button
        Me.Button2 = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'FechaHasta
        '
        Me.FechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.FechaHasta.Location = New System.Drawing.Point(83, 61)
        Me.FechaHasta.Name = "FechaHasta"
        Me.FechaHasta.Size = New System.Drawing.Size(105, 21)
        Me.FechaHasta.TabIndex = 3
        '
        'FechaDesde
        '
        Me.FechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.FechaDesde.Location = New System.Drawing.Point(83, 23)
        Me.FechaDesde.Name = "FechaDesde"
        Me.FechaDesde.Size = New System.Drawing.Size(105, 21)
        Me.FechaDesde.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Aceptar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.FechaHasta)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.FechaDesde)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Location = New System.Drawing.Point(21, 25)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(200, 100)
        Me.Frame1.TabIndex = 6
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Filtros Fecha"
        '
        'frmInformeFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 200)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmInformeFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInformeFecha"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Button1 As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Button2 As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents FechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Public WithEvents FechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
End Class
