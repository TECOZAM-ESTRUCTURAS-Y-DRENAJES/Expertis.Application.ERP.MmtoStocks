<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformeFechasFamilia
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
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.cFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.bCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.bAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame2 = New Solmicro.Expertis.Engine.UI.Frame
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.advFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.cFechaHasta)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.cFechaDesde)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Location = New System.Drawing.Point(12, 12)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(200, 95)
        Me.Frame1.TabIndex = 7
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Filtros Fecha"
        '
        'cFechaHasta
        '
        Me.cFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cFechaHasta.Location = New System.Drawing.Point(83, 61)
        Me.cFechaHasta.Name = "cFechaHasta"
        Me.cFechaHasta.Size = New System.Drawing.Size(105, 21)
        Me.cFechaHasta.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde"
        '
        'cFechaDesde
        '
        Me.cFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cFechaDesde.Location = New System.Drawing.Point(83, 23)
        Me.cFechaDesde.Name = "cFechaDesde"
        Me.cFechaDesde.Size = New System.Drawing.Size(105, 21)
        Me.cFechaDesde.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta"
        '
        'bCancelar
        '
        Me.bCancelar.Location = New System.Drawing.Point(32, 178)
        Me.bCancelar.Name = "bCancelar"
        Me.bCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bCancelar.TabIndex = 12
        Me.bCancelar.Text = "Cancelar"
        '
        'bAceptar
        '
        Me.bAceptar.Location = New System.Drawing.Point(113, 178)
        Me.bAceptar.Name = "bAceptar"
        Me.bAceptar.Size = New System.Drawing.Size(75, 23)
        Me.bAceptar.TabIndex = 11
        Me.bAceptar.Text = "Aceptar"
        '
        'Frame2
        '
        Me.Frame2.Controls.Add(Me.advFamilia)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Location = New System.Drawing.Point(13, 110)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Size = New System.Drawing.Size(200, 57)
        Me.Frame2.TabIndex = 8
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "Filtro Familia"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Familia"
        '
        'advFamilia
        '
        Me.advFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.advFamilia.EntityName = "Familia"
        Me.advFamilia.Location = New System.Drawing.Point(82, 23)
        Me.advFamilia.Name = "advFamilia"
        Me.advFamilia.SecondaryDataFields = "IDFamilia"
        Me.advFamilia.Size = New System.Drawing.Size(105, 23)
        Me.advFamilia.TabIndex = 10
        '
        'frmInformeFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 211)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.bAceptar)
        Me.Controls.Add(Me.bCancelar)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "frmInformeFecha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtrar"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Public WithEvents cFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents bCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents bAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Frame2 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
