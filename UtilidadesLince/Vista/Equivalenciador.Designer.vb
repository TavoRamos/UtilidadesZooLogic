<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Equivalenciador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BTNExportar = New System.Windows.Forms.Button()
        Me.SB = New System.Windows.Forms.StatusStrip()
        Me.STProgreso = New System.Windows.Forms.ToolStripProgressBar()
        Me.SBLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TXTCODGrupo = New System.Windows.Forms.TextBox()
        Me.TXTNombreGrupo = New System.Windows.Forms.TextBox()
        Me.LBLGrupo = New System.Windows.Forms.Label()
        Me.BTNGenerar = New System.Windows.Forms.Button()
        Me.TXTSalida = New System.Windows.Forms.TextBox()
        Me.TXTColor = New System.Windows.Forms.TextBox()
        Me.LBLColor = New System.Windows.Forms.Label()
        Me.TXTTalle = New System.Windows.Forms.TextBox()
        Me.LBLTalle = New System.Windows.Forms.Label()
        Me.TXTArticulo = New System.Windows.Forms.TextBox()
        Me.LBLArticulo = New System.Windows.Forms.Label()
        Me.CHKValidarArticulo = New System.Windows.Forms.CheckBox()
        Me.LBLEtiqueta = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PruebaDeStressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarEquivalenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeInventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TXTCAI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCAI2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTEtiqueta = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TTCAI = New System.Windows.Forms.ToolTip(Me.components)
        Me.NMRInicioCAI = New System.Windows.Forms.NumericUpDown()
        Me.NMRInicioCAI2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CHKFiltrosAvanzados = New System.Windows.Forms.CheckBox()
        Me.NMRAumento2 = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NMRAumento1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTDelimitadorTalleI = New System.Windows.Forms.TextBox()
        Me.TXTDelimitadorTalleE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BW1 = New System.ComponentModel.BackgroundWorker()
        Me.SB.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.NMRInicioCAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NMRInicioCAI2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NMRAumento2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NMRAumento1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNExportar
        '
        Me.BTNExportar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNExportar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BTNExportar.Enabled = False
        Me.BTNExportar.Location = New System.Drawing.Point(385, 360)
        Me.BTNExportar.Name = "BTNExportar"
        Me.BTNExportar.Size = New System.Drawing.Size(492, 21)
        Me.BTNExportar.TabIndex = 51
        Me.BTNExportar.Text = "EXPORTAR EQUIVALENCIAS"
        Me.BTNExportar.UseVisualStyleBackColor = True
        '
        'SB
        '
        Me.SB.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STProgreso, Me.SBLBL})
        Me.SB.Location = New System.Drawing.Point(0, 398)
        Me.SB.Name = "SB"
        Me.SB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SB.Size = New System.Drawing.Size(893, 22)
        Me.SB.SizingGrip = False
        Me.SB.TabIndex = 50
        Me.SB.Text = "SB"
        '
        'STProgreso
        '
        Me.STProgreso.Name = "STProgreso"
        Me.STProgreso.Size = New System.Drawing.Size(100, 16)
        '
        'SBLBL
        '
        Me.SBLBL.Name = "SBLBL"
        Me.SBLBL.Size = New System.Drawing.Size(0, 17)
        '
        'TXTCODGrupo
        '
        Me.TXTCODGrupo.Enabled = False
        Me.TXTCODGrupo.Location = New System.Drawing.Point(79, 307)
        Me.TXTCODGrupo.Name = "TXTCODGrupo"
        Me.TXTCODGrupo.Size = New System.Drawing.Size(75, 20)
        Me.TXTCODGrupo.TabIndex = 48
        Me.TXTCODGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNombreGrupo
        '
        Me.TXTNombreGrupo.Enabled = False
        Me.TXTNombreGrupo.Location = New System.Drawing.Point(160, 307)
        Me.TXTNombreGrupo.Name = "TXTNombreGrupo"
        Me.TXTNombreGrupo.Size = New System.Drawing.Size(199, 20)
        Me.TXTNombreGrupo.TabIndex = 47
        Me.TXTNombreGrupo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBLGrupo
        '
        Me.LBLGrupo.AutoSize = True
        Me.LBLGrupo.Location = New System.Drawing.Point(27, 310)
        Me.LBLGrupo.Name = "LBLGrupo"
        Me.LBLGrupo.Size = New System.Drawing.Size(46, 13)
        Me.LBLGrupo.TabIndex = 46
        Me.LBLGrupo.Text = "GRUPO"
        '
        'BTNGenerar
        '
        Me.BTNGenerar.Location = New System.Drawing.Point(79, 357)
        Me.BTNGenerar.Name = "BTNGenerar"
        Me.BTNGenerar.Size = New System.Drawing.Size(280, 27)
        Me.BTNGenerar.TabIndex = 45
        Me.BTNGenerar.Text = "GENERAR EQUIVALENCIA"
        Me.BTNGenerar.UseVisualStyleBackColor = True
        '
        'TXTSalida
        '
        Me.TXTSalida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXTSalida.Location = New System.Drawing.Point(385, 34)
        Me.TXTSalida.MaxLength = 999999999
        Me.TXTSalida.Multiline = True
        Me.TXTSalida.Name = "TXTSalida"
        Me.TXTSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTSalida.Size = New System.Drawing.Size(492, 320)
        Me.TXTSalida.TabIndex = 44
        '
        'TXTColor
        '
        Me.TXTColor.Location = New System.Drawing.Point(79, 281)
        Me.TXTColor.Name = "TXTColor"
        Me.TXTColor.Size = New System.Drawing.Size(280, 20)
        Me.TXTColor.TabIndex = 43
        '
        'LBLColor
        '
        Me.LBLColor.AutoSize = True
        Me.LBLColor.Location = New System.Drawing.Point(29, 284)
        Me.LBLColor.Name = "LBLColor"
        Me.LBLColor.Size = New System.Drawing.Size(44, 13)
        Me.LBLColor.TabIndex = 42
        Me.LBLColor.Text = "COLOR"
        '
        'TXTTalle
        '
        Me.TXTTalle.Location = New System.Drawing.Point(79, 255)
        Me.TXTTalle.Name = "TXTTalle"
        Me.TXTTalle.Size = New System.Drawing.Size(280, 20)
        Me.TXTTalle.TabIndex = 41
        '
        'LBLTalle
        '
        Me.LBLTalle.AutoSize = True
        Me.LBLTalle.Location = New System.Drawing.Point(33, 258)
        Me.LBLTalle.Name = "LBLTalle"
        Me.LBLTalle.Size = New System.Drawing.Size(40, 13)
        Me.LBLTalle.TabIndex = 40
        Me.LBLTalle.Text = "TALLE"
        '
        'TXTArticulo
        '
        Me.TXTArticulo.Location = New System.Drawing.Point(79, 229)
        Me.TXTArticulo.Name = "TXTArticulo"
        Me.TXTArticulo.Size = New System.Drawing.Size(280, 20)
        Me.TXTArticulo.TabIndex = 39
        '
        'LBLArticulo
        '
        Me.LBLArticulo.AutoSize = True
        Me.LBLArticulo.Location = New System.Drawing.Point(12, 232)
        Me.LBLArticulo.Name = "LBLArticulo"
        Me.LBLArticulo.Size = New System.Drawing.Size(61, 13)
        Me.LBLArticulo.TabIndex = 38
        Me.LBLArticulo.Text = "ARTICULO"
        '
        'CHKValidarArticulo
        '
        Me.CHKValidarArticulo.AutoSize = True
        Me.CHKValidarArticulo.Checked = True
        Me.CHKValidarArticulo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKValidarArticulo.Location = New System.Drawing.Point(79, 332)
        Me.CHKValidarArticulo.Name = "CHKValidarArticulo"
        Me.CHKValidarArticulo.Size = New System.Drawing.Size(95, 17)
        Me.CHKValidarArticulo.TabIndex = 37
        Me.CHKValidarArticulo.Text = "Validar articulo"
        Me.CHKValidarArticulo.UseVisualStyleBackColor = True
        '
        'LBLEtiqueta
        '
        Me.LBLEtiqueta.AutoSize = True
        Me.LBLEtiqueta.Location = New System.Drawing.Point(12, 37)
        Me.LBLEtiqueta.Name = "LBLEtiqueta"
        Me.LBLEtiqueta.Size = New System.Drawing.Size(61, 13)
        Me.LBLEtiqueta.TabIndex = 35
        Me.LBLEtiqueta.Text = "ETIQUETA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraciónToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.ControlDeInventariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
        Me.MenuStrip1.TabIndex = 49
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "&Configuración"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PruebaDeStressToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'PruebaDeStressToolStripMenuItem
        '
        Me.PruebaDeStressToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarEquivalenciasToolStripMenuItem})
        Me.PruebaDeStressToolStripMenuItem.Name = "PruebaDeStressToolStripMenuItem"
        Me.PruebaDeStressToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PruebaDeStressToolStripMenuItem.Text = "Prueba de Stress"
        '
        'GenerarEquivalenciasToolStripMenuItem
        '
        Me.GenerarEquivalenciasToolStripMenuItem.Name = "GenerarEquivalenciasToolStripMenuItem"
        Me.GenerarEquivalenciasToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.GenerarEquivalenciasToolStripMenuItem.Text = "Generar equivalencias"
        '
        'ControlDeInventariosToolStripMenuItem
        '
        Me.ControlDeInventariosToolStripMenuItem.Name = "ControlDeInventariosToolStripMenuItem"
        Me.ControlDeInventariosToolStripMenuItem.Size = New System.Drawing.Size(136, 20)
        Me.ControlDeInventariosToolStripMenuItem.Text = "Control de Inventarios"
        '
        'TXTCAI
        '
        Me.TXTCAI.Enabled = False
        Me.TXTCAI.Location = New System.Drawing.Point(79, 78)
        Me.TXTCAI.Name = "TXTCAI"
        Me.TXTCAI.Size = New System.Drawing.Size(104, 20)
        Me.TXTCAI.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "CAI"
        '
        'TXTCAI2
        '
        Me.TXTCAI2.Enabled = False
        Me.TXTCAI2.Location = New System.Drawing.Point(255, 78)
        Me.TXTCAI2.Name = "TXTCAI2"
        Me.TXTCAI2.Size = New System.Drawing.Size(104, 20)
        Me.TXTCAI2.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "CAI 2"
        '
        'TXTEtiqueta
        '
        Me.TXTEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTEtiqueta.Location = New System.Drawing.Point(79, 34)
        Me.TXTEtiqueta.Multiline = False
        Me.TXTEtiqueta.Name = "TXTEtiqueta"
        Me.TXTEtiqueta.Size = New System.Drawing.Size(280, 20)
        Me.TXTEtiqueta.TabIndex = 56
        Me.TXTEtiqueta.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "INICIO"
        '
        'NMRInicioCAI
        '
        Me.NMRInicioCAI.Enabled = False
        Me.NMRInicioCAI.Location = New System.Drawing.Point(79, 104)
        Me.NMRInicioCAI.Name = "NMRInicioCAI"
        Me.NMRInicioCAI.Size = New System.Drawing.Size(104, 20)
        Me.NMRInicioCAI.TabIndex = 58
        Me.NMRInicioCAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NMRInicioCAI2
        '
        Me.NMRInicioCAI2.Enabled = False
        Me.NMRInicioCAI2.Location = New System.Drawing.Point(255, 106)
        Me.NMRInicioCAI2.Name = "NMRInicioCAI2"
        Me.NMRInicioCAI2.Size = New System.Drawing.Size(104, 20)
        Me.NMRInicioCAI2.TabIndex = 60
        Me.NMRInicioCAI2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "INICIO"
        '
        'CHKFiltrosAvanzados
        '
        Me.CHKFiltrosAvanzados.AutoSize = True
        Me.CHKFiltrosAvanzados.Location = New System.Drawing.Point(79, 60)
        Me.CHKFiltrosAvanzados.Name = "CHKFiltrosAvanzados"
        Me.CHKFiltrosAvanzados.Size = New System.Drawing.Size(109, 17)
        Me.CHKFiltrosAvanzados.TabIndex = 61
        Me.CHKFiltrosAvanzados.Text = "Filtros Avanzados"
        Me.CHKFiltrosAvanzados.UseVisualStyleBackColor = True
        '
        'NMRAumento2
        '
        Me.NMRAumento2.Enabled = False
        Me.NMRAumento2.Location = New System.Drawing.Point(255, 132)
        Me.NMRAumento2.Name = "NMRAumento2"
        Me.NMRAumento2.Size = New System.Drawing.Size(104, 20)
        Me.NMRAumento2.TabIndex = 65
        Me.NMRAumento2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(189, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "AUMENTO"
        '
        'NMRAumento1
        '
        Me.NMRAumento1.Enabled = False
        Me.NMRAumento1.Location = New System.Drawing.Point(79, 132)
        Me.NMRAumento1.Name = "NMRAumento1"
        Me.NMRAumento1.Size = New System.Drawing.Size(104, 20)
        Me.NMRAumento1.TabIndex = 63
        Me.NMRAumento1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "AUMENTO"
        '
        'TXTDelimitadorTalleI
        '
        Me.TXTDelimitadorTalleI.Location = New System.Drawing.Point(255, 174)
        Me.TXTDelimitadorTalleI.Name = "TXTDelimitadorTalleI"
        Me.TXTDelimitadorTalleI.Size = New System.Drawing.Size(104, 20)
        Me.TXTDelimitadorTalleI.TabIndex = 69
        Me.TXTDelimitadorTalleI.Visible = False
        '
        'TXTDelimitadorTalleE
        '
        Me.TXTDelimitadorTalleE.Location = New System.Drawing.Point(79, 174)
        Me.TXTDelimitadorTalleE.Name = "TXTDelimitadorTalleE"
        Me.TXTDelimitadorTalleE.Size = New System.Drawing.Size(104, 20)
        Me.TXTDelimitadorTalleE.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Delimitador talle en etiqueta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Delimitador talle para importar"
        Me.Label9.Visible = False
        '
        'BW1
        '
        Me.BW1.WorkerReportsProgress = True
        '
        'Equivalenciador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 420)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTDelimitadorTalleI)
        Me.Controls.Add(Me.TXTDelimitadorTalleE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NMRAumento2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NMRAumento1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CHKFiltrosAvanzados)
        Me.Controls.Add(Me.NMRInicioCAI2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NMRInicioCAI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTEtiqueta)
        Me.Controls.Add(Me.TXTCAI2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTCAI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNExportar)
        Me.Controls.Add(Me.SB)
        Me.Controls.Add(Me.TXTCODGrupo)
        Me.Controls.Add(Me.TXTNombreGrupo)
        Me.Controls.Add(Me.LBLGrupo)
        Me.Controls.Add(Me.BTNGenerar)
        Me.Controls.Add(Me.TXTSalida)
        Me.Controls.Add(Me.TXTColor)
        Me.Controls.Add(Me.LBLColor)
        Me.Controls.Add(Me.TXTTalle)
        Me.Controls.Add(Me.LBLTalle)
        Me.Controls.Add(Me.TXTArticulo)
        Me.Controls.Add(Me.LBLArticulo)
        Me.Controls.Add(Me.CHKValidarArticulo)
        Me.Controls.Add(Me.LBLEtiqueta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Name = "Equivalenciador"
        Me.Text = "Equivalenciador"
        Me.SB.ResumeLayout(False)
        Me.SB.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.NMRInicioCAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NMRInicioCAI2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NMRAumento2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NMRAumento1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNExportar As Button
    Friend WithEvents SB As StatusStrip
    Friend WithEvents SBLBL As ToolStripStatusLabel
    Friend WithEvents STProgreso As ToolStripProgressBar
    Friend WithEvents TXTCODGrupo As TextBox
    Friend WithEvents TXTNombreGrupo As TextBox
    Friend WithEvents LBLGrupo As Label
    Friend WithEvents BTNGenerar As Button
    Friend WithEvents TXTSalida As TextBox
    Friend WithEvents TXTColor As TextBox
    Friend WithEvents LBLColor As Label
    Friend WithEvents TXTTalle As TextBox
    Friend WithEvents LBLTalle As Label
    Friend WithEvents TXTArticulo As TextBox
    Friend WithEvents LBLArticulo As Label
    Friend WithEvents CHKValidarArticulo As CheckBox
    Friend WithEvents LBLEtiqueta As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TXTCAI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCAI2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTEtiqueta As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TTCAI As ToolTip
    Friend WithEvents NMRInicioCAI As NumericUpDown
    Friend WithEvents NMRInicioCAI2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents CHKFiltrosAvanzados As CheckBox
    Friend WithEvents NMRAumento2 As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents NMRAumento1 As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents HerramientasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PruebaDeStressToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarEquivalenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TXTDelimitadorTalleI As TextBox
    Friend WithEvents TXTDelimitadorTalleE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ControlDeInventariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BW1 As System.ComponentModel.BackgroundWorker
End Class
