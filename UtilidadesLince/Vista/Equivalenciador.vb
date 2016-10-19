Imports System.ComponentModel
Imports System.IO

Public Class Equivalenciador
    Private Sub BTNGenerar_Click(sender As Object, e As EventArgs) Handles BTNGenerar.Click
        Dim inicio As DateTime = DateTime.Now
        If CHKValidarArticulo.Checked = True Then
            SBLBL.Text = "Buscando articulos en base de datos..."
            STProgreso.ProgressBar.Value = 25
            Dim BDArticulos As New ConectarDBF(My.Settings.BDLince, My.Settings.NombreBDArt)
            If BDArticulos.buscarArticulo(TXTArticulo.Text.Trim) Then
                Dim Articulo As ArticuloLince = ArticuloLince.NuevoArticuloDesdeBD(TXTArticulo.Text.Trim)
                If Not IsNothing(Articulo) Then
                    SBLBL.Text = "Cargando Articulo..."
                    STProgreso.ProgressBar.Value = 50
                    TXTArticulo.Text = Articulo.Codigo
                    TXTCODGrupo.Text = Articulo.Grupo
                    TXTColor.Text = Articulo.Color
                    SBLBL.Text = "Cargando curva de talles..."
                    STProgreso.ProgressBar.Value = 75
                    Dim grupo = GrupoLince.NuevoDesdeDB(Articulo.Grupo)
                    TXTNombreGrupo.Text = grupo.Descripcion
                    SBLBL.Text = "Generando equivalencias..."
                    STProgreso.ProgressBar.Value = 100
                    For i As Integer = 0 To grupo.Talles.Count - 1
                        Dim Talle As String = grupo.Talles(i)
                        Dim StrEtiqueta As String = TXTEtiqueta.Text.Trim
                        If Not String.IsNullOrWhiteSpace(TXTSalida.Text) Then
                            StrEtiqueta = "*AE " + StrEtiqueta.Substring(1, StrEtiqueta.LastIndexOf(TXTDelimitadorTalleE.Text) - 1) + TXTDelimitadorTalleE.Text + Talle.Trim
                            TXTSalida.Text += StrEtiqueta + "," + TXTArticulo.Text + "," + TXTColor.Text.Trim + "," + Talle.Trim + vbCrLf
                        Else
                            TXTSalida.Text = "/+" + vbCrLf
                            StrEtiqueta = "*AE " + StrEtiqueta.Substring(1, StrEtiqueta.LastIndexOf(TXTDelimitadorTalleE.Text) - 1) + TXTDelimitadorTalleE.Text + Talle.Trim
                            TXTSalida.Text += StrEtiqueta + "," + TXTArticulo.Text + "," + TXTColor.Text.Trim + "," + Talle.Trim + vbCrLf
                        End If
                    Next
                    'TXTSalida.Text += vbCrLf + grupo.toString
                End If
            Else
                MsgBox("Articulo no encontrado")
                SBLBL.Text = ""
                STProgreso.ProgressBar.Value = 0
            End If
        Else
            If Not String.IsNullOrWhiteSpace(TXTSalida.Text) Then
                TXTSalida.Text += "*AE " + TXTEtiqueta.Text.Trim + "," + TXTArticulo.Text + "," + TXTColor.Text.Trim + "," + TXTTalle.Text.Trim + vbCrLf
            Else
                TXTSalida.Text = "*AE" + vbCrLf
                TXTSalida.Text += "*AE " + TXTEtiqueta.Text.Trim + "," + TXTArticulo.Text + "," + TXTColor.Text.Trim + "," + TXTTalle.Text.Trim + vbCrLf
            End If
        End If
        Dim fin As DateTime = DateTime.Now
        Dim totalMin As String
        Dim total As TimeSpan = New TimeSpan(fin.Ticks - inicio.Ticks)
        totalMin = total.Hours.ToString("00") & ":" & total.Minutes.ToString("00") & ":" & total.Seconds.ToString("00")
        SBLBL.Text = "Tiempo de proceso " + totalMin
        STProgreso.ProgressBar.Value = 0
    End Sub
    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        Configuracion.Show()
    End Sub
    Private Sub BTNExportar_Click(sender As Object, e As EventArgs) Handles BTNExportar.Click
        If Not Len(TXTSalida.Text) = 0 Then
            With SaveFileDialog1
                .Reset()
                .Filter = "Ficheros de texto (*.txt)|*.txt"
                If .ShowDialog = DialogResult.OK Then
                    If My.Computer.FileSystem.FileExists(.FileName) Then
                        My.Computer.FileSystem.DeleteFile(.FileName)
                        My.Computer.FileSystem.WriteAllText(.FileName, TXTSalida.Text & vbCrLf, True)
                        My.Computer.FileSystem.WriteAllText(.FileName + "- Copia -", TXTSalida.Text & vbCrLf, True, System.Text.Encoding.ASCII)
                    Else
                        My.Computer.FileSystem.WriteAllText(.FileName, TXTSalida.Text & vbCrLf, True)
                        My.Computer.FileSystem.WriteAllText(.FileName + "- Copia -", TXTSalida.Text & vbCrLf, True, System.Text.Encoding.ASCII)
                    End If
                End If
            End With
        End If
        SBLBL.Text = "Equivalencias exportadas a " + SaveFileDialog1.FileName
    End Sub
    Private Sub TXTSalida_TextChanged(sender As Object, e As EventArgs) Handles TXTSalida.TextChanged
        If TXTSalida.Lines.Count > 0 Then
            BTNExportar.Enabled = True
            BTNExportar.Text = "EXPORTAR EQUIVALENCIAS (" + (TXTSalida.Lines.Count - 1).ToString + ")"
        Else
            BTNExportar.Text = "EXPORTAR EQUIVALENCIAS"
            BTNExportar.Enabled = False
        End If
    End Sub
    Private Sub TXTEtiqueta_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTEtiqueta.KeyDown
        If e.KeyData = Keys.F1 And TXTEtiqueta.SelectionLength > 0 Then
            TXTEtiqueta.SelectionColor = Color.Red
            TXTCAI.Text = TXTEtiqueta.SelectedText
        End If
        If e.KeyData = Keys.F2 And TXTEtiqueta.SelectionLength > 0 Then
            TXTEtiqueta.SelectionColor = Color.Green
            TXTCAI2.Text = TXTEtiqueta.SelectedText
        End If
    End Sub
    Private Sub TXTCAI_MouseHover(sender As Object, e As EventArgs) Handles TXTCAI.MouseHover, TXTCAI2.MouseHover
        Dim Tecla As String = "F2"
        Dim numeroControl As String = "2"
        If sender.Equals(TXTCAI) Then
            Tecla = "F1"
            numeroControl = "1"
        End If
        TTCAI.ToolTipIcon = ToolTipIcon.Info
        TTCAI.ToolTipTitle = "Campo autoincremental " + numeroControl
        TTCAI.Show("Seleccionar el valor a reemplazar y presionar la TECLA " + Tecla, sender)
    End Sub
    Private Sub CHKFiltrosAvanzados_CheckedChanged(sender As Object, e As EventArgs) Handles CHKFiltrosAvanzados.CheckedChanged
        If CHKFiltrosAvanzados.CheckState = CheckState.Checked Then
            NMRInicioCAI.Enabled = True
            NMRInicioCAI2.Enabled = True
            TXTCAI.Enabled = True
            TXTCAI2.Enabled = True
            NMRAumento1.Enabled = True
            NMRAumento2.Enabled = True
        Else
            NMRInicioCAI.Enabled = False
            NMRInicioCAI2.Enabled = False
            TXTCAI.Enabled = False
            TXTCAI2.Enabled = False
            NMRAumento1.Enabled = False
            NMRAumento2.Enabled = False
        End If
    End Sub
    Private Sub CHKValidarArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles CHKValidarArticulo.CheckedChanged
        If CHKValidarArticulo.CheckState = CheckState.Checked Then
            TXTTalle.Enabled = False
            TXTColor.Enabled = False
        Else
            TXTTalle.Enabled = True
            TXTColor.Enabled = True
        End If
    End Sub

    Private Sub GenerarEquivalenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarEquivalenciasToolStripMenuItem.Click
        BW1.RunWorkerAsync()
    End Sub

    Private Sub ControlDeInventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlDeInventariosToolStripMenuItem.Click
        ControlDeInventarios.Show()
    End Sub
    Public Sub Prueba1Lecoq()
        Try
            Dim DB As New ConectarDBF(My.Settings.BDLince)
            Dim Consulta As String = "SELECT * FROM art WHERE artfab='01'"
            Dim ListaArts As DataTable = ConectarDBF.LlenarDGV(DB, Consulta)
            Dim Articulo As String 'ArticuloLince
            Dim Grupo As GrupoLince
            Dim Texto As String
            Dim Progreso As Integer = 0
            Dim Contador As Integer = 0
            For Each Fila As DataRow In ListaArts.Rows
                Contador += 1
                Articulo = Fila.Item(0).ToString.Trim 'ArticuloLince.NuevoArticuloDesdeBD(Fila.Item(0).ToString.Trim)
                Grupo = GrupoLince.NuevoDesdeDB(Fila.Item(16).ToString)
                For i = 0 To Grupo.Talles.Count - 1
                    Texto = Fila.Item(0).ToString.Trim + "$" + Grupo.Talles(i).Trim + "," + Fila.Item(0).ToString.Trim + ",," + Grupo.Talles(i).Trim + vbCrLf
                    Progreso = (Contador * 100) / ListaArts.Rows.Count
                    BW1.ReportProgress(Progreso, Texto)
                Next
            Next
        Catch ex As Exception
            MsgBox("Prueba Lecoq" + vbCrLf + ex.Message)
        End Try
    End Sub

    Private Sub BW1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW1.DoWork
        Prueba1Lecoq()
    End Sub

    Private Sub BW1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BW1.ProgressChanged
        Try
            TXTSalida.Text += e.UserState
        STProgreso.Value = e.ProgressPercentage
            SBLBL.Text = e.ProgressPercentage.ToString + " % Completado"
        Catch ex As Exception
            MsgBox("BW1_ProgressCahnged" + vbCrLf + ex.Message)
        End Try
    End Sub
End Class
