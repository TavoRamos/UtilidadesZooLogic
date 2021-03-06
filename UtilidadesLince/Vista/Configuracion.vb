﻿Public Class Configuracion
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
            LBL1.Text = My.Settings.ColJust1.ToString
        Else
            PictureBox1.BackColor = Color.Empty
            LBL1.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust2) Then
            PictureBox2.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust2)
            LBL2.Text = My.Settings.ColJust2.ToString
        Else
            PictureBox2.BackColor = Color.Empty
            LBL2.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust3) Then
            PictureBox3.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust3)
            LBL3.Text = My.Settings.ColJust3.ToString
        Else
            PictureBox3.BackColor = Color.Empty
            LBL3.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust4) Then
            PictureBox4.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust4)
            LBL5.Text = My.Settings.ColJust4.ToString
        Else
            PictureBox4.BackColor = Color.Empty
            LBL5.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust5) Then
            PictureBox5.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust5)
            LBL6.Text = My.Settings.ColJust5.ToString
        Else
            PictureBox5.BackColor = Color.Empty
            LBL6.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust6) Then
            PictureBox6.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust6)
            LBL7.Text = My.Settings.ColJust6.ToString
        Else
            PictureBox6.BackColor = Color.Empty
            LBL7.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust7) Then
            PictureBox7.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust7)
            LBL8.Text = My.Settings.ColJust7.ToString
        Else
            PictureBox7.BackColor = Color.Empty
            LBL8.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust8) Then
            PictureBox8.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust8)
            LBL9.Text = My.Settings.ColJust8.ToString
        Else
            PictureBox8.BackColor = Color.Empty
            LBL9.Text = "Sin color asignado"
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.ColJust9) Then
            PictureBox9.BackColor = ColorTranslator.FromHtml(My.Settings.ColJust9)
            LBL10.Text = My.Settings.ColJust1.ToString
        Else
            PictureBox9.BackColor = Color.Empty
            LBL10.Text = "Sin color asignado"
        End If
        '*************************** CONTROL DE INVENTARIOS - JUSTIFICACIONES - TEXTO
        If Not String.IsNullOrWhiteSpace(My.Settings.Just1) Then
            TXTJust1.Text = My.Settings.Just1
        Else
            TXTJust1.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just2) Then
            TXTJust2.Text = My.Settings.Just2
        Else
            TXTJust2.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just3) Then
            TXTJust3.Text = My.Settings.Just3
        Else
            TXTJust3.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just4) Then
            TXTJust4.Text = My.Settings.Just4
        Else
            TXTJust4.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just5) Then
            TXTJust5.Text = My.Settings.Just5
        Else
            TXTJust5.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just6) Then
            TXTJust6.Text = My.Settings.Just6
        Else
            TXTJust6.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just7) Then
            TXTJust7.Text = My.Settings.Just7
        Else
            TXTJust7.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just8) Then
            TXTJust8.Text = My.Settings.Just8
        Else
            TXTJust8.Text = ""
        End If

        If Not String.IsNullOrWhiteSpace(My.Settings.Just9) Then
            TXTJust9.Text = My.Settings.Just9
        Else
            TXTJust9.Text = ""
        End If
        If Not String.IsNullOrWhiteSpace(My.Settings.Just10) Then
            TXTJust10.Text = My.Settings.Just10
        Else
            TXTJust10.Text = ""
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
            My.Settings.ColJust1 = ColorTranslator.ToHtml(PictureBox1.BackColor)
            My.Settings.ColJust2 = ColorTranslator.ToHtml(PictureBox2.BackColor)
            My.Settings.ColJust3 = ColorTranslator.ToHtml(PictureBox3.BackColor)
            My.Settings.ColJust4 = ColorTranslator.ToHtml(PictureBox4.BackColor)
            My.Settings.ColJust5 = ColorTranslator.ToHtml(PictureBox5.BackColor)
            My.Settings.ColJust6 = ColorTranslator.ToHtml(PictureBox6.BackColor)
            My.Settings.ColJust7 = ColorTranslator.ToHtml(PictureBox7.BackColor)
            My.Settings.ColJust8 = ColorTranslator.ToHtml(PictureBox8.BackColor)
            My.Settings.ColJust9 = ColorTranslator.ToHtml(PictureBox9.BackColor)
            My.Settings.ColJust10 = ColorTranslator.ToHtml(PictureBox10.BackColor)
        End If
        My.Settings.Save()
    End Sub

    Private Sub TXTJust_TextChanged(sender As Object, e As EventArgs) Handles TXTJust1.TextChanged, TXTJust2.TextChanged, TXTJust3.TextChanged, TXTJust4.TextChanged, TXTJust5.TextChanged, TXTJust6.TextChanged, TXTJust7.TextChanged, TXTJust8.TextChanged, TXTJust9.TextChanged, TXTJust10.TextChanged
        My.Settings.Just1 = TXTJust1.Text
        My.Settings.Just2 = TXTJust2.Text
        My.Settings.Just3 = TXTJust3.Text
        My.Settings.Just4 = TXTJust4.Text
        My.Settings.Just5 = TXTJust5.Text
        My.Settings.Just6 = TXTJust6.Text
        My.Settings.Just7 = TXTJust7.Text
        My.Settings.Just8 = TXTJust8.Text
        My.Settings.Just9 = TXTJust9.Text
        My.Settings.Just10 = TXTJust10.Text
    End Sub
End Class