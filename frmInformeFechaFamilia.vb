Public Class frmInformeFechaFamilia

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cargarCombo()
    End Sub


    Public Sub cargarCombo()
        Dim dtcombo As New DataTable
        dtcombo.Columns.Add("Codigo")
        dtcombo.Columns.Add("Descripcion")

        Dim dr As DataRow
        dr = dtcombo.NewRow()

        dr("Codigo") = "2001"
        dr("Descripcion") = "Ferreteria"
        dtcombo.Rows.Add(dr)

        dr = dtcombo.NewRow()
        dr("Codigo") = "2002"
        dr("Descripcion") = "Madera"
        dtcombo.Rows.Add(dr)

        cbFamilia.DataSource = dtcombo
        cbFamilia.ValueMember = "Descripcion"
        cbFamilia.DisplayMember = "Codigo"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class