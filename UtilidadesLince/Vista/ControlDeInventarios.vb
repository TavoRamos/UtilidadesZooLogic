Public Class ControlDeInventarios
    Private Sub DGVCI_DragOver(sender As Object, e As DragEventArgs) Handles DGVCI.DragOver
        MsgBox(e.Data.GetFormats().ToString + vbCrLf + "DragOver")
    End Sub
End Class