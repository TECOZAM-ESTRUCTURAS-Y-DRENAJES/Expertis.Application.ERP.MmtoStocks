Public Class SeleccionMoneda
    Inherits System.Windows.Forms.Form

    Private mMonedaA As Boolean

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
    Public WithEvents optMonedaA As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents optMonedaB As Solmicro.Expertis.Engine.UI.RadioButton
    Public WithEvents cmdOk As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmdCancel As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.optMonedaA = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optMonedaB = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.cmdOk = New Solmicro.Expertis.Engine.UI.Button
        Me.cmdCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.SuspendLayout()
        '
        'optMonedaA
        '
        Me.optMonedaA.Location = New System.Drawing.Point(45, 15)
        Me.optMonedaA.Name = "optMonedaA"
        Me.optMonedaA.Size = New System.Drawing.Size(180, 18)
        Me.optMonedaA.TabIndex = 0
        Me.optMonedaA.Text = "<Moneda A>"
        '
        'optMonedaB
        '
        Me.optMonedaB.Location = New System.Drawing.Point(45, 42)
        Me.optMonedaB.Name = "optMonedaB"
        Me.optMonedaB.Size = New System.Drawing.Size(180, 18)
        Me.optMonedaB.TabIndex = 1
        Me.optMonedaB.Text = "<Moneda B>"
        '
        'cmdOk
        '
        Me.cmdOk.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdOk.Location = New System.Drawing.Point(27, 87)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(87, 33)
        Me.cmdOk.TabIndex = 2
        Me.cmdOk.Text = "Aceptar"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(123, 87)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(87, 33)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "Cancelar"
        '
        'SeleccionMoneda
        '
        Me.AcceptButton = Me.cmdOk
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(238, 132)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.optMonedaB)
        Me.Controls.Add(Me.optMonedaA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionMoneda"
        Me.Text = "Seleccionar Moneda"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ReadOnly Property MonedaA() As Boolean
        Get
            Return mMonedaA
        End Get
    End Property

    Private Sub optMonedaA_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optMonedaA.CheckedChanged
        mMonedaA = True
    End Sub

    Private Sub optMonedaB_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optMonedaB.CheckedChanged
        mMonedaA = False
    End Sub
End Class
