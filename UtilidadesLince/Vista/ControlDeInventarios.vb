Imports System.ComponentModel
Imports System.IO

Public Class ControlDeInventarios
    Private Sub ControlDeInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim DB As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDArt)
        'Dim ListaArts As DataTable = ConectarDBF.LlenarDGVCI(DB)
        'DGVCI.DataSource = ListaArts
        For i = 1 To 10
            'Dim bmp As New Drawing.Bitmap(40, 40)
            'Dim grap As Drawing.Graphics = Drawing.Graphics.FromImage(bmp)
            'grap.Clear(ColorTranslator.FromHtml()
        Next

    End Sub

    Private Sub ArchivoDeTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoDeTextoToolStripMenuItem.Click
        Dim Lineas As New List(Of String)
        Try
            Dim fic As Stream
            Dim OPF As New OpenFileDialog()
            OPF.Filter = "Texto delimitado por TAB|*.txt"
            OPF.ShowDialog()
            fic = OPF.OpenFile
            Dim texto As String
            Dim sr As New System.IO.StreamReader(fic)
            texto = sr.ReadToEnd()
            Debug.Print("Leyendo Archivo")
            sr.Close()

            Lineas = texto.Split(Environment.NewLine).ToList
            Debug.Print("Explotando texto")
            Dim ListaArticulos As New BindingList(Of ArticuloCI)

            For Each linea As String In Lineas
                Dim ArtAux = linea.Split(vbTab)
                Dim Precio As New List(Of Decimal)
                Precio.Add(Decimal.Parse(ArtAux(4)))
                Dim a = New ArticuloCI(ArtAux(0).ToString.Trim, ArtAux(1), ArtAux(2), ArtAux(3), Precio, ArtAux(5), ArtAux(6))
                a.Grupo = GrupoLince.NuevoDesdeDB(ArtAux(3))
                ListaArticulos.Add(a)
            Next
            Dim ListaSinJus = ListaArticulos
            DGVCIJustificados.DataSource = ListaArticulos
            DGVCISinJustificar.DataSource = ListaSinJus
            DGVCISinJustificar.Columns("Grupo").DataPropertyName = "ArticuloCI.GrupoLince.ID"
            DGVCIJustificados.Columns("Grupo").DataPropertyName = "GrupoLince->ID"
            DGVCISinJustificar.Refresh()
            DGVCIJustificados.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DGVCIJustificados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCIJustificados.CellContentClick
        MsgBox(DGVCIJustificados.Rows(e.RowIndex).DataBoundItem.ToString)
    End Sub
End Class