Public Class Configuracion
    Private Sub BTNPathDB_Click(sender As Object, e As EventArgs)
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


        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust1) Then
            PictureBox1.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust1)
            Label11.Text = My.Settings.ColJust1.ToString
        Else
            PictureBox1.BackColor = Color.Empty
            Label11.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust2) Then
            PictureBox2.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust2)
            Label12.Text = My.Settings.ColJust2.ToString
        Else
            PictureBox2.BackColor = Color.Empty
            Label12.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust3) Then
            PictureBox3.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust3)
            Label13.Text = My.Settings.ColJust3.ToString
        Else
            PictureBox3.BackColor = Color.Empty
            Label13.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust4) Then
            PictureBox4.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust4)
            Label4.Text = My.Settings.ColJust4.ToString
        Else
            PictureBox4.BackColor = Color.Empty
            Label4.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust5) Then
            PictureBox5.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust5)
            Label5.Text = My.Settings.ColJust5.ToString
        Else
            PictureBox5.BackColor = Color.Empty
            Label5.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust6) Then
            PictureBox6.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust6)
            Label6.Text = My.Settings.ColJust6.ToString
        Else
            PictureBox6.BackColor = Color.Empty
            Label6.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust7) Then
            PictureBox7.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust7)
            Label7.Text = My.Settings.ColJust7.ToString
        Else
            PictureBox7.BackColor = Color.Empty
            Label7.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust8) Then
            PictureBox8.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust8)
            Label8.Text = My.Settings.ColJust8.ToString
        Else
            PictureBox8.BackColor = Color.Empty
            Label8.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust9) Then
            PictureBox9.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust9)
            Label9.Text = My.Settings.ColJust1.ToString
        Else
            PictureBox9.BackColor = Color.Empty
            Label9.Text = "Sin color asignado"
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust10) Then
            PictureBox10.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust10)
            Label10.Text = My.Settings.ColJust1.ToString
        Else
            PictureBox10.BackColor = Color.Empty
            Label10.Text = "Sin color asignado"
        End If
    End Sub

    Private Sub TXTNombreDBArt_TextChanged(sender As Object, e As EventArgs)
        My.Settings.NombreBDArt = TXTNombreDBArt.Text.Trim
        My.Settings.NombreBDGru = TXTNombreBDGru.Text.Trim
        My.Settings.Save()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click
        sender.BackColor = IIf(ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK, ColorDialog1.Color, Color.Empty)
    End Sub

    Private Sub PictureBox9_BackColorChanged(sender As Object, e As EventArgs) Handles PictureBox1.BackColorChanged, PictureBox2.BackColorChanged, PictureBox3.BackColorChanged, PictureBox4.BackColorChanged, PictureBox5.BackColorChanged, PictureBox6.BackColorChanged, PictureBox7.BackColorChanged, PictureBox8.BackColorChanged, PictureBox9.BackColorChanged, PictureBox10.BackColorChanged
        If sender.BackColor <> Color.Empty Then

        End If
    End Sub
End Class