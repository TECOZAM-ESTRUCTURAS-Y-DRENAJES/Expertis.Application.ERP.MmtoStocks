Public Class CIFacturasCentroCoste
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub CIFacturasCentroCoste_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If advCentroCoste.Text.ToString.Length = 0 Then
            txtArticulo.Visible = True
            cbArticulo.Visible = False
            cbArticulo.DataSource = ""
            e.Filter.Add("IDArticulo", FilterOperator.Equal, txtArticulo.Text, FilterType.String)
        Else
            e.Filter.Add("IDArticulo", FilterOperator.Equal, cbArticulo.Text, FilterType.String)
        End If

        e.Filter.Add("IDCentroCoste", FilterOperator.Equal, advCentroCoste.Value, FilterType.String)
        e.Filter.Add("FechaFactura", FilterOperator.GreaterThanOrEqual, CBFInicioMayor.Value, FilterType.DateTime)
        e.Filter.Add("FechaFactura", FilterOperator.LessThanOrEqual, CBFInicioMenor.Value, FilterType.DateTime)
    End Sub

    Private Sub advCentroCoste_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles advCentroCoste.SelectionChanged

        If advCentroCoste.Value.ToString.Length = 0 Then
            txtArticulo.Visible = True
        Else
            txtArticulo.Text = ""
            txtArticulo.Visible = False
            cbArticulo.Visible = True
            Dim sql As String
            sql = "select distinct(IDArticulo) from VfrmMntoFacturaCompraArticuloCentroCoste where IDCentroCoste='" & advCentroCoste.Value & "'"
            Dim a As New Business.ClasesTecozam.Acero
            Dim dt As New DataTable
            dt = a.DevuelveTabla(sql)

            cbArticulo.DataSource = dt
        End If
        
    End Sub
End Class