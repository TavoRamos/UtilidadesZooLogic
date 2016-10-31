Imports System.ComponentModel
Imports System.IO

Public Class ControlDeInventarios
    Private Sub ControlDeInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim DB As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDArt)
        'Dim ListaArts As DataTable = ConectarDBF.LlenarDGVCI(DB)
        'DGVCI.DataSource = ListaArts
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

            MsgBox(Lineas(1).ToString)
            For Each linea As String In Lineas
                Dim ArtAux = linea.Split(vbTab)
                Dim Precio(0)
                Precio(0) = ArtAux(4)
                ListaArticulos.Add(New ArticuloCI(ArtAux(0), ArtAux(1), ArtAux(2), ArtAux(3), Precio, ArtAux(5), ArtAux(6)))

            Next
            Dim ListaSinJus = ListaArticulos
            DGVCIJustificados.DataSource = ListaArticulos
            DGVCISinJustificar.DataSource = ListaSinJus
            DGVCIJustificados.Columns("Grupo").DataPropertyName = "ID"
            DGVCISinJustificar.Refresh()
            DGVCIJustificados.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class