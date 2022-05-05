Public Class frmInformeFechaEncofrado

    Public blEstado As Boolean
    Public fecha1 As Date
    Public fecha2 As Date
    Public familia As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        fecha1 = Nz(FechaDesde.Value, 0)
        fecha2 = Nz(FechaHasta.Value, 0)
        blEstado = False
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        blEstado = True
        Me.Close()
    End Sub
End Class