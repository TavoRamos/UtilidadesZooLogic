Imports System.ComponentModel
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary

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
    Private Sub DGVCIJustificados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCIJustificados.CellContentClick
        MsgBox(DGVCIJustificados.Rows(e.RowIndex).DataBoundItem.ToString)
    End Sub
    Dim ListaArticulos As New BindingList(Of ArticuloCI)
    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        Dim BGW = New BackgroundWorker()
        BGW.RunWorkerAsync(ImportarDesdeArchivo_Inventario)
    End Sub
    Public Sub ImportarDesdeArchivo_Inventario()
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim formatter As IFormatter = New BinaryFormatter 'formateador binario para realizar la serialización.
        ' Todo lo que necesita es crear una instancia de la secuencia y el formateador que desee utilizar,
        Dim DLG = New FolderBrowserDialog
        DLG.ShowDialog()
        Dim stream As Stream = New FileStream(DLG.SelectedPath.ToString, FileMode.Create, FileAccess.Write, FileShare.Read)
        'y a continuación, llamar al método Serialize en el formateador
        formatter.Serialize(stream, ListaArticulos)
        stream.Close()
    End Sub
End Class