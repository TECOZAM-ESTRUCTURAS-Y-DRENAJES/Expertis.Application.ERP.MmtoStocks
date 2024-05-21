Imports Solmicro.Expertis.Engine.Global

Public Class frmInformeFechasFamilia

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date

    Public Sub EstablecerModoPorInforme(ByVal informe As String)
        Select Case informe
            Case "COSTESESCALERAS"
                ' El campo de la familia está deshabilitado
                advFamilia.Enabled = False
            Case "COSTES3017"
                advFamilia.Value = "3017"
            Case "INFENCOSUBFAM"
                advFamilia.Value = "3010"
            Case Else
                advFamilia.Enabled = True
        End Select
    End Sub

    Private Sub frmInformeFechasFamilia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        bAceptar.Enabled = False

        ' Agrega los controladores de eventos para los controles de fecha
        AddHandler cFechaDesde.ValueChanged, AddressOf Fecha_ValueChanged
        AddHandler cFechaHasta.ValueChanged, AddressOf Fecha_ValueChanged
    End Sub

    Private Sub Fecha_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' Verifica si cFechaDesde.Value y cFechaHasta.Value son DBNull antes de acceder a la propiedad Date
        Dim fechaDesde As Date = If(cFechaDesde.Value Is DBNull.Value, DateTime.MinValue, cFechaDesde.Value)
        Dim fechaHasta As Date = If(cFechaHasta.Value Is DBNull.Value, DateTime.MinValue, cFechaHasta.Value)

        ' Habilita el botón de aceptar solo si ambos campos tienen una fecha distinta de DateTime.MinValue
        bAceptar.Enabled = fechaDesde.Date <> DateTime.MinValue.Date AndAlso fechaHasta.Date <> DateTime.MinValue.Date
    End Sub

    Private Sub bAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bAceptar.Click
        fecha1 = Nz(cFechaDesde.Value, 0)
        fecha2 = Nz(cFechaHasta.Value, 0)
        blEstado = False
        Me.Close()
    End Sub

    Private Sub bCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bCancelar.Click
        blEstado = True
        Me.Close()
    End Sub
End Class