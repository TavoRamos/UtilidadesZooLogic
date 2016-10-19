Public Class ControlDeInventarios
    Private Sub DGVCI_DragOver(sender As Object, e As DragEventArgs) Handles DGVCI.DragOver
        MsgBox(e.Data.GetFormats().ToString + vbCrLf + "DragOver")
    End Sub

    Private Sub ControlDeInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim DB As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDArt)
        'Dim ListaArts As DataTable = ConectarDBF.LlenarDGVCI(DB)
        'DGVCI.DataSource = ListaArts
    End Sub
End Class