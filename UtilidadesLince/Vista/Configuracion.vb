Public Class Configuracion
    Private Sub BTNPathDB_Click(sender As Object, e As EventArgs) Handles BTNPathDB.Click
        FolderBrowserDialog1.ShowDialog()
        TXTPathBD.Text = FolderBrowserDialog1.SelectedPath + "\"
        My.Settings.BDLince = TXTPathBD.Text.Trim
        My.Settings.Save()
    End Sub
    Private Sub Configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler TXTNombreBDGru.TextChanged, AddressOf TXTNombreDBArt_TextChanged
        RemoveHandler TXTNombreDBArt.TextChanged, AddressOf TXTNombreDBArt_TextChanged

        If Not String.IsNullOrWhiteSpace(My.Settings.BDLince) Then
            TXTPathBD.Text = My.Settings.BDLince
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.NombreBDArt) Then
            TXTNombreDBArt.Text = My.Settings.NombreBDArt
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.NombreBDGru) Then
            TXTNombreBDGru.Text = My.Settings.NombreBDGru
        End If
        AddHandler TXTNombreBDGru.TextChanged, AddressOf TXTNombreDBArt_TextChanged
        AddHandler TXTNombreDBArt.TextChanged, AddressOf TXTNombreDBArt_TextChanged
    End Sub

    Private Sub TXTNombreDBArt_TextChanged(sender As Object, e As EventArgs) Handles TXTNombreDBArt.TextChanged, TXTNombreBDGru.TextChanged
        My.Settings.NombreBDArt = TXTNombreDBArt.Text.Trim
        My.Settings.NombreBDGru = TXTNombreBDGru.Text.Trim
        My.Settings.Save()
    End Sub
End Class