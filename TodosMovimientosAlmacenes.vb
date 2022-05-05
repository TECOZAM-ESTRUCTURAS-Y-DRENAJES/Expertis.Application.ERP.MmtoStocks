Public Class TodosMovimientosAlmacenes
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
    End Sub

    Private Sub TodosMovimientosAlmacenes_QueryExecuting(ByVal sender As System.Object, ByRef e As Solmicro.Expertis.Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDArticulo", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
        e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        e.Filter.Add("IDSubfamilia", FilterOperator.Equal, AdvSubFamilia.Text, FilterType.String)
        e.Filter.Add("FechaDocumento", FilterOperator.GreaterThanOrEqual, CalendarBox1.Value, FilterType.DateTime)
        e.Filter.Add("FechaDocumento", FilterOperator.LessThanOrEqual, CalendarBox2.Value, FilterType.DateTime)
        e.Filter.Add("AlmacenEntrada", FilterOperator.Equal, AdvAlmacenEntrada.Text, FilterType.String)
        e.Filter.Add("AlmacenSalida", FilterOperator.Equal, AdvAlmacenSalida.Text, FilterType.String)
    End Sub
End Class