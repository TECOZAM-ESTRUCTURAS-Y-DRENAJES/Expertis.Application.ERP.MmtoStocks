Public Class ParametrosValoracion
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    Private mParams As ProcesoStocks.ParametrosValoracion

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        mParams = New ProcesoStocks.ParametrosValoracion
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
    Friend WithEvents cmdCancel As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblfwiFecha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents WLFrame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pic2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents WLFrame3 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblfwiFechaInicio As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cboCriterio As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents cmdOk As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cbxFechaCalculo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents optArticulo As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents optOtro As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents cbxFechaInicio As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FrmOpciones As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents ChkConTotales As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents ChkConRegistros As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblUdValoracion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvUDValoracion As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chkSalvar As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cboCriterio_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ParametrosValoracion))
        Me.cmdCancel = New Solmicro.Expertis.Engine.UI.Button
        Me.lblfwiFecha = New Solmicro.Expertis.Engine.UI.Label
        Me.chkSalvar = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.WLFrame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.cboCriterio = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.optArticulo = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.optOtro = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.pic2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblUdValoracion = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvUDValoracion = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FrmOpciones = New Solmicro.Expertis.Engine.UI.Frame
        Me.ChkConTotales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.ChkConRegistros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.WLFrame3 = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblfwiFechaInicio = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicio = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cbxFechaCalculo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cmdOk = New Solmicro.Expertis.Engine.UI.Button
        Me.WLFrame1.SuspendLayout()
        CType(Me.cboCriterio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pic2.suspendlayout()
        Me.FrmOpciones.SuspendLayout()
        Me.WLFrame3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(255, 360)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(106, 28)
        Me.cmdCancel.TabIndex = 2
        Me.cmdCancel.Text = "Cancelar"
        '
        'lblfwiFecha
        '
        Me.lblfwiFecha.Location = New System.Drawing.Point(16, 16)
        Me.lblfwiFecha.Name = "lblfwiFecha"
        Me.lblfwiFecha.Size = New System.Drawing.Size(101, 13)
        Me.lblfwiFecha.TabIndex = 19
        Me.lblfwiFecha.Tag = "IdRec=13088;"
        Me.lblfwiFecha.Text = "Fecha de cálculo"
        '
        'chkSalvar
        '
        Me.chkSalvar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSalvar.Location = New System.Drawing.Point(23, 64)
        Me.chkSalvar.Name = "chkSalvar"
        Me.chkSalvar.Size = New System.Drawing.Size(184, 19)
        Me.chkSalvar.TabIndex = 2
        Me.chkSalvar.Text = "Guardar precios calculados"
        '
        'WLFrame1
        '
        Me.WLFrame1.Controls.Add(Me.cboCriterio)
        Me.WLFrame1.Controls.Add(Me.optArticulo)
        Me.WLFrame1.Controls.Add(Me.optOtro)
        Me.WLFrame1.Location = New System.Drawing.Point(16, 48)
        Me.WLFrame1.Name = "WLFrame1"
        Me.WLFrame1.Size = New System.Drawing.Size(440, 88)
        Me.WLFrame1.TabIndex = 2
        Me.WLFrame1.TabStop = False
        Me.WLFrame1.Tag = "IdRec=13081;"
        Me.WLFrame1.Text = "Criterio de valoración"
        '
        'cboCriterio
        '
        cboCriterio_DesignTimeLayout.LayoutString = resources.GetString("cboCriterio_DesignTimeLayout.LayoutString")
        Me.cboCriterio.DesignTimeLayout = cboCriterio_DesignTimeLayout
        Me.cboCriterio.DisabledBackColor = System.Drawing.Color.White
        Me.cboCriterio.Location = New System.Drawing.Point(160, 56)
        Me.cboCriterio.Name = "cboCriterio"
        Me.cboCriterio.SelectedIndex = -1
        Me.cboCriterio.SelectedItem = Nothing
        Me.cboCriterio.Size = New System.Drawing.Size(264, 21)
        Me.cboCriterio.TabIndex = 2
        '
        'optArticulo
        '
        Me.optArticulo.Location = New System.Drawing.Point(10, 24)
        Me.optArticulo.Name = "optArticulo"
        Me.optArticulo.Size = New System.Drawing.Size(294, 19)
        Me.optArticulo.TabIndex = 0
        Me.optArticulo.Text = "Aplicar el criterio de valoración del artículo"
        '
        'optOtro
        '
        Me.optOtro.Location = New System.Drawing.Point(10, 56)
        Me.optOtro.Name = "optOtro"
        Me.optOtro.Size = New System.Drawing.Size(134, 19)
        Me.optOtro.TabIndex = 1
        Me.optOtro.Text = "Aplicar otro criterio"
        '
        'pic2
        '
        Me.pic2.Controls.Add(Me.lblUdValoracion)
        Me.pic2.Controls.Add(Me.AdvUDValoracion)
        Me.pic2.Controls.Add(Me.FrmOpciones)
        Me.pic2.Controls.Add(Me.WLFrame3)
        Me.pic2.Controls.Add(Me.WLFrame1)
        Me.pic2.Controls.Add(Me.lblfwiFecha)
        Me.pic2.Controls.Add(Me.cbxFechaCalculo)
        Me.pic2.Location = New System.Drawing.Point(8, 8)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(472, 346)
        Me.pic2.TabIndex = 0
        '
        'lblUdValoracion
        '
        Me.lblUdValoracion.Location = New System.Drawing.Point(242, 19)
        Me.lblUdValoracion.Name = "lblUdValoracion"
        Me.lblUdValoracion.Size = New System.Drawing.Size(90, 13)
        Me.lblUdValoracion.TabIndex = 103
        Me.lblUdValoracion.Tag = ""
        Me.lblUdValoracion.Text = "Ud. Valoración"
        '
        'AdvUDValoracion
        '
        Me.AdvUDValoracion.DisabledBackColor = System.Drawing.Color.White
        Me.AdvUDValoracion.EntityName = "UdMedida"
        Me.AdvUDValoracion.Location = New System.Drawing.Point(332, 14)
        Me.AdvUDValoracion.Name = "AdvUDValoracion"
        Me.AdvUDValoracion.SecondaryDataFields = "IDUdMedida"
        Me.AdvUDValoracion.Size = New System.Drawing.Size(124, 23)
        Me.AdvUDValoracion.TabIndex = 1
        '
        'FrmOpciones
        '
        Me.FrmOpciones.Controls.Add(Me.ChkConTotales)
        Me.FrmOpciones.Controls.Add(Me.ChkConRegistros)
        Me.FrmOpciones.Location = New System.Drawing.Point(16, 257)
        Me.FrmOpciones.Name = "FrmOpciones"
        Me.FrmOpciones.Size = New System.Drawing.Size(440, 82)
        Me.FrmOpciones.TabIndex = 4
        Me.FrmOpciones.TabStop = False
        Me.FrmOpciones.Text = "Opciones"
        '
        'ChkConTotales
        '
        Me.ChkConTotales.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkConTotales.Checked = True
        Me.ChkConTotales.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkConTotales.Location = New System.Drawing.Point(23, 49)
        Me.ChkConTotales.Name = "ChkConTotales"
        Me.ChkConTotales.Size = New System.Drawing.Size(139, 23)
        Me.ChkConTotales.TabIndex = 1
        Me.ChkConTotales.Text = "Mostrar Totales"
        '
        'ChkConRegistros
        '
        Me.ChkConRegistros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkConRegistros.Checked = True
        Me.ChkConRegistros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkConRegistros.Location = New System.Drawing.Point(23, 20)
        Me.ChkConRegistros.Name = "ChkConRegistros"
        Me.ChkConRegistros.Size = New System.Drawing.Size(139, 23)
        Me.ChkConRegistros.TabIndex = 0
        Me.ChkConRegistros.Text = "Mostrar Registros"
        '
        'WLFrame3
        '
        Me.WLFrame3.Controls.Add(Me.lblfwiFechaInicio)
        Me.WLFrame3.Controls.Add(Me.cbxFechaInicio)
        Me.WLFrame3.Controls.Add(Me.chkSalvar)
        Me.WLFrame3.Location = New System.Drawing.Point(16, 144)
        Me.WLFrame3.Name = "WLFrame3"
        Me.WLFrame3.Size = New System.Drawing.Size(440, 107)
        Me.WLFrame3.TabIndex = 3
        Me.WLFrame3.TabStop = False
        Me.WLFrame3.Tag = "IdRec=0;"
        Me.WLFrame3.Text = "Parámetros opcionales"
        '
        'lblfwiFechaInicio
        '
        Me.lblfwiFechaInicio.Location = New System.Drawing.Point(23, 24)
        Me.lblfwiFechaInicio.Name = "lblfwiFechaInicio"
        Me.lblfwiFechaInicio.Size = New System.Drawing.Size(161, 13)
        Me.lblfwiFechaInicio.TabIndex = 0
        Me.lblfwiFechaInicio.Tag = "IdRec=13082;"
        Me.lblfwiFechaInicio.Text = "Fecha Inicio (Precio Medio)"
        '
        'cbxFechaInicio
        '
        Me.cbxFechaInicio.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicio.Enabled = False
        Me.cbxFechaInicio.Location = New System.Drawing.Point(192, 24)
        Me.cbxFechaInicio.Name = "cbxFechaInicio"
        Me.cbxFechaInicio.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaInicio.TabIndex = 1
        '
        'cbxFechaCalculo
        '
        Me.cbxFechaCalculo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCalculo.Location = New System.Drawing.Point(123, 16)
        Me.cbxFechaCalculo.Name = "cbxFechaCalculo"
        Me.cbxFechaCalculo.Size = New System.Drawing.Size(104, 21)
        Me.cbxFechaCalculo.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Enabled = False
        Me.cmdOk.Location = New System.Drawing.Point(135, 360)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(106, 28)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Aceptar"
        '
        'ParametrosValoracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(496, 395)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.pic2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ParametrosValoracion"
        Me.Text = "Parámetros de la Valoración"
        Me.WLFrame1.ResumeLayout(False)
        Me.WLFrame1.PerformLayout()
        CType(Me.cboCriterio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pic2.ResumeLayout(False)
        Me.pic2.PerformLayout()
        Me.FrmOpciones.ResumeLayout(False)
        Me.WLFrame3.ResumeLayout(False)
        Me.WLFrame3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ReadOnly Property Parametros() As ProcesoStocks.ParametrosValoracion
        Get
            Return mParams
        End Get
    End Property

    Private mDescUDValoracion As String
    Public Property DescUdValoracion() As String
        Get
            Return mDescUDValoracion
        End Get
        Set(ByVal value As String)
            mDescUDValoracion = value
        End Set
    End Property
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim ok As Boolean
        mDescUDValoracion = String.Empty
        If Not IsDate(cbxFechaCalculo.Value) Then
            ExpertisApp.GenerateMessage("La fecha de cálculo no es válida.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            mParams.FechaCalculo = cbxFechaCalculo.Value
            If optArticulo.Checked Then
                mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.Articulo
                ok = True
            ElseIf optOtro.Checked Then
                If IsNothing(cboCriterio.Value) Then
                    ExpertisApp.GenerateMessage("Seleccione un criterio de valoración.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim criterio As enumtaValoracion = cboCriterio.Value
                    Select Case criterio
                        Case enumtaValoracion.taPrecioEstandar
                            mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.PrecioEstandar
                        Case enumtaValoracion.taPrecioFIFOFecha
                            mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.PrecioFifoFecha
                        Case enumtaValoracion.taPrecioFIFOMvto
                            mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.PrecioFifoMvto
                        Case enumtaValoracion.taPrecioMedio
                            mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.PrecioMedio
                        Case enumtaValoracion.taPrecioUltCompra
                            mParams.CriterioValoracion = ProcesoStocks.CriterioValoracion.PrecioUltimaCompra
                    End Select
                    ok = True
                End If
            End If

            If IsDate(cbxFechaInicio.Value) Then
                mParams.FechaInicioPrecioMedio = cbxFechaInicio.Value
            End If
            If ChkConRegistros.Checked = False AndAlso ChkConTotales.Checked = False Then
                ExpertisApp.GenerateMessage("Seleccione ver con registro o ver los totales para la valoración.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ok = False
            End If
            mParams.Salvar = chkSalvar.Checked
            mParams.ConRegistros = ChkConRegistros.Checked
            mParams.ConTotales = ChkConTotales.Checked
            mParams.UDValoracion = AdvUDValoracion.Value
            If Not AdvUDValoracion.SelectedRow Is Nothing Then
                mDescUDValoracion = AdvUDValoracion.SelectedRow("DescUDMedida") & String.Empty
            End If
        End If

        If ok Then
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Public Shadows Function ShowDialog(ByVal params As ProcesoStocks.ParametrosValoracion) As DialogResult
        If Not params Is Nothing Then
            cboCriterio.DataSource = New EnumData("enumtaValoracion")
            cboCriterio.DropDownList.ColumnAutoResize = True

            cbxFechaCalculo.Value = params.FechaCalculo
            If params.CriterioValoracion = ProcesoStocks.CriterioValoracion.Articulo Then
                optArticulo.Checked = True
            Else
                optOtro.Checked = True
                Dim criterioBBDD As enumtaValoracion
                Select Case params.CriterioValoracion
                    Case ProcesoStocks.CriterioValoracion.PrecioEstandar
                        criterioBBDD = enumtaValoracion.taPrecioEstandar
                    Case ProcesoStocks.CriterioValoracion.PrecioFifoFecha
                        criterioBBDD = enumtaValoracion.taPrecioFIFOFecha
                    Case ProcesoStocks.CriterioValoracion.PrecioFifoMvto
                        criterioBBDD = enumtaValoracion.taPrecioFIFOMvto
                    Case ProcesoStocks.CriterioValoracion.PrecioMedio
                        criterioBBDD = enumtaValoracion.taPrecioMedio
                    Case ProcesoStocks.CriterioValoracion.PrecioUltimaCompra
                        criterioBBDD = enumtaValoracion.taPrecioUltCompra
                End Select
                cboCriterio.Value = criterioBBDD
            End If
            If params.FechaInicioPrecioMedio <> cnMinDate Then
                cbxFechaInicio.Value = params.FechaInicioPrecioMedio
            End If
            chkSalvar.Checked = params.Salvar
            cmdOk.Enabled = True
        End If
        Return MyBase.ShowDialog
    End Function

    Private Sub optArticulo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optArticulo.CheckedChanged
        cboCriterio.Enabled = Not optArticulo.Checked
    End Sub

    Private Sub optOtro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optOtro.CheckedChanged
        cboCriterio.Enabled = optOtro.Checked
    End Sub

    Private Sub cboCriterio_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCriterio.EnabledChanged
        EstadoParametrosOpcionales()
    End Sub

    Private Sub cboCriterio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCriterio.ValueChanged
        EstadoParametrosOpcionales()
    End Sub

    Private Sub EstadoParametrosOpcionales()
        If optArticulo.Checked Then
            cbxFechaInicio.Enabled = True
            chkSalvar.Enabled = True
        Else
            cbxFechaInicio.Enabled = False
            chkSalvar.Enabled = False

            If cboCriterio.Value = enumtaValoracion.taPrecioFIFOFecha _
            Or cboCriterio.Value = enumtaValoracion.taPrecioFIFOMvto _
            Or cboCriterio.Value = enumtaValoracion.taPrecioMedio Then
                chkSalvar.Enabled = True
            Else
                chkSalvar.Enabled = False
            End If

            If cboCriterio.Value = enumtaValoracion.taPrecioMedio Then
                cbxFechaInicio.Enabled = True
            Else
                cbxFechaInicio.Enabled = False
            End If
        End If
    End Sub

    Private Sub ParametrosValoracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.DesignMode Then
            LoadERPData()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim dtParam As DataTable = New Parametro().SelOnPrimaryKey("BDGUDMED")
        If dtParam.Rows.Count > 0 Then
            Dim IDUDMedida As String = dtParam.Rows(0)("Valor") & String.Empty
            AdvUDValoracion.Value = IDUDMedida
        End If
    End Sub

End Class