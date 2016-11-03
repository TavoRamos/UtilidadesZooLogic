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


        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust1) Then
            BTNJust1.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust1)
            BTNJust1.Text = My.Settings.ColJust1.ToString
        Else
            BTNJust1.BackColor = Color.Empty
            BTNJust1.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust2) Then
            BTNJust2.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust2)
            BTNJust2.Text = My.Settings.ColJust2.ToString
        Else
            BTNJust2.BackColor = Color.Empty
            BTNJust2.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust3) Then
            BTNJust3.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust3)
            BTNJust3.Text = My.Settings.ColJust3.ToString
        Else
            BTNJust3.BackColor = Color.Empty
            BTNJust3.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust4) Then
            BTNJust4.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust4)
            BTNJust5.Text = My.Settings.ColJust4.ToString
        Else
            BTNJust4.BackColor = Color.Empty
            BTNJust5.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust5) Then
            BTNJust5.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust5)
            BTNJust6.Text = My.Settings.ColJust5.ToString
        Else
            BTNJust5.BackColor = Color.Empty
            BTNJust6.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust6) Then
            BTNJust6.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust6)
            BTNJust7.Text = My.Settings.ColJust6.ToString
        Else
            BTNJust6.BackColor = Color.Empty
            BTNJust7.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust7) Then
            BTNJust7.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust7)
            BTNJust8.Text = My.Settings.ColJust7.ToString
        Else
            BTNJust7.BackColor = Color.Empty
            BTNJust8.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust8) Then
            BTNJust8.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust8)
            BTNJust9.Text = My.Settings.ColJust8.ToString
        Else
            BTNJust8.BackColor = Color.Empty
            BTNJust9.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust9) Then
            BTNJust9.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust9)
            BTNJust10.Text = My.Settings.ColJust1.ToString
        Else
            BTNJust9.BackColor = Color.Empty
            BTNJust10.Text = "Sin color asignado"
        End If

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