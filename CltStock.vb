Imports Janus.Windows.GridEX
Imports Solmicro.Expertis.Engine.DAL
Imports System.Windows.Forms
Imports Solmicro.Expertis.Engine
Imports Solmicro.Expertis.Engine.UI
Imports Solmicro.Expertis.Business.General

Public Class CltStock
    Inherits Solmicro.Expertis.Engine.UI.CIMnto


#Region " Eventos Formulario "

    Private Sub CltStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ExecuteQuery.InvokeOnClick()
        FwiTotal.Enabled = False
        FwiTotal.BackColor = Color.Gainsboro
        lblMov.ForeColor = Color.Blue
        lblMov.Font = New Font("Verdana", 9, FontStyle.Bold)
        FilterPanel.Visible = True
        CalcularImportes()
        FiltarGridAbajo()
    End Sub

    Private Sub CltStock_Navigated(ByVal sender As Object, ByVal e As Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        CalcularImportes()
    End Sub

#End Region

#Region " Filtros "

    Private Sub CltStock_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        ConsultaInteractiva(e)
    End Sub

    Private Sub ConsultaInteractiva(ByRef e As Engine.UI.QueryExecutingEventArgs)

        Try
            e.Filter.Add("IdArticulo", FilterOperator.Equal, FwiIdArticulo.Value, FilterType.String)
            e.Filter.Add("NSerie", FilterOperator.Equal, FwNumeroSerie.Text, FilterType.String)
            e.Filter.Add("Stock", FilterOperator.GreaterThanOrEqual, fwiStock.Text, FilterType.Numeric)
            '-----------------------------------------------
            'e.Filter.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Value, FilterType.DateTime)
            'e.Filter.Add("FechaAlbaran", FilterOperator.LessThanOrEqual, FwiFechaHasta.Value, FilterType.DateTime)
            CalcularImportes()

            If IsDBNull(FwiFechaDesde.Value) = False Or IsDBNull(FwiFechaHasta.Value) = False Then
                FiltarGridAbajo()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CltStock_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        LimpiarFiltros()
    End Sub

    Private Sub LimpiarFiltros()
        Try
            FwNumeroSerie.Text = Nothing
            FwiIdArticulo.Value = Nothing
            FwiFechaDesde.Value = Nothing
            FwiFechaHasta.Value = Nothing
            fwiStock.Text = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FwiIdArticulo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwiIdArticulo.TextChanged
        Me.ExecuteQuery.InvokeOnClick()
        FiltarGridAbajo()
    End Sub

    Private Sub FwNumeroSerie_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles FwNumeroSerie.LostFocus
        Me.ExecuteQuery.InvokeOnClick()
        FiltarGridAbajo()
    End Sub
    Private Sub fwiStock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles fwiStock.LostFocus
        Me.ExecuteQuery.InvokeOnClick()
    End Sub

#End Region

#Region " Funciones "

    Private Sub CalcularImportes()
        Dim lngTotal As Long
        Dim dblTotal As Double
        Dim rs As New DataTable

        Try
            rs = Grid.DataSource
            If Not rs Is Nothing Then
                If rs.Rows.Count > 0 Then
                    If rs.Rows.Count <> 0 Then
                        lngTotal = lngTotal + 1
                        dblTotal = dblTotal + 0  'Nz(rs("Precio"), 0)
                    End If
                End If
            End If

            'FwTotalT.Value = Nz(dblTotal, 0)
            FwiTotal.Text = lngTotal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rs = Nothing
        End Try
    End Sub

#End Region

#Region " Grid "

    Private Sub grid_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.SelectionChanged
        FiltarGridAbajo()
    End Sub


    Private Sub FiltarGridAbajo()
        'Dim strWhere As String
        Dim rs As New DataTable
        Dim strSerie As String
        'Dim strfecha As String
        Dim f As New Filter

        Try

            With Grid
                If .RowCount > 0 Then
                    strSerie = rs.Rows(0)("NSerie").Value


                    If IsDBNull(FwiFechaDesde.Value) = False Then
                        f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, FwiFechaDesde.Value)
                    End If

                    If IsDBNull(FwiFechaHasta.Value) = False Then
                        f.Add("FechaAlbaran", FilterOperator.GreaterThanOrEqual, FwiFechaHasta.Value)
                    End If


                    jngMovimientos.DataSource = rs
                    jngMovimientos.Update()
                    jngMovimientos.Refresh()
                    f.Add("NSerie", FilterOperator.Equal, strSerie)

                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            rs = Nothing
        End Try
    End Sub

#End Region


End Class