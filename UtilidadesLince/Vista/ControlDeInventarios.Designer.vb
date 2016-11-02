<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDeInventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDeInventarios))
        Me.BarraStatus = New System.Windows.Forms.StatusStrip()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.ImportarDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoDeTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BaseDeDatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Contenedor = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DGVCIJustificados = New System.Windows.Forms.DataGridView()
        Me.DGVCISinJustificar = New System.Windows.Forms.DataGridView()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.TXTConsolaSQL = New System.Windows.Forms.RichTextBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BTNJust1 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust2 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust3 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust4 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust5 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust6 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust7 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust8 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust9 = New System.Windows.Forms.ToolStripButton()
        Me.BTNJust10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Menu.SuspendLayout()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.Panel1.SuspendLayout()
        Me.Contenedor.Panel2.SuspendLayout()
        Me.Contenedor.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGVCIJustificados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCISinJustificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraStatus
        '
        Me.BarraStatus.Location = New System.Drawing.Point(0, 503)
        Me.BarraStatus.Name = "BarraStatus"
        Me.BarraStatus.Size = New System.Drawing.Size(980, 22)
        Me.BarraStatus.TabIndex = 0
        Me.BarraStatus.Text = "StatusStrip1"
        '
        'Menu
        '
        Me.Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDatosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(980, 24)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
        '
        'ImportarDatosToolStripMenuItem
        '
        Me.ImportarDatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoDeTextoToolStripMenuItem, Me.BaseDeDatosToolStripMenuItem})
        Me.ImportarDatosToolStripMenuItem.Name = "ImportarDatosToolStripMenuItem"
        Me.ImportarDatosToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ImportarDatosToolStripMenuItem.Text = "&Importar datos"
        '
        'ArchivoDeTextoToolStripMenuItem
        '
        Me.ArchivoDeTextoToolStripMenuItem.Name = "ArchivoDeTextoToolStripMenuItem"
        Me.ArchivoDeTextoToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ArchivoDeTextoToolStripMenuItem.Text = "Archivo de texto"
        '
        'BaseDeDatosToolStripMenuItem
        '
        Me.BaseDeDatosToolStripMenuItem.Name = "BaseDeDatosToolStripMenuItem"
        Me.BaseDeDatosToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BaseDeDatosToolStripMenuItem.Text = "Base de datos"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColoresToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ColoresToolStripMenuItem
        '
        Me.ColoresToolStripMenuItem.Name = "ColoresToolStripMenuItem"
        Me.ColoresToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ColoresToolStripMenuItem.Text = "Motivos y colores"
        '
        'Contenedor
        '
        Me.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Contenedor.Location = New System.Drawing.Point(0, 24)
        Me.Contenedor.Name = "Contenedor"
        Me.Contenedor.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Contenedor.Panel1
        '
        Me.Contenedor.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'Contenedor.Panel2
        '
        Me.Contenedor.Panel2.Controls.Add(Me.Tab)
        Me.Contenedor.Size = New System.Drawing.Size(980, 479)
        Me.Contenedor.SplitterDistance = 449
        Me.Contenedor.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGVCIJustificados)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVCISinJustificar)
        Me.SplitContainer1.Size = New System.Drawing.Size(980, 449)
        Me.SplitContainer1.SplitterDistance = 680
        Me.SplitContainer1.TabIndex = 0
        '
        'DGVCIJustificados
        '
        Me.DGVCIJustificados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVCIJustificados.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DGVCIJustificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCIJustificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCIJustificados.Location = New System.Drawing.Point(0, 0)
        Me.DGVCIJustificados.Name = "DGVCIJustificados"
        Me.DGVCIJustificados.RowHeadersVisible = False
        Me.DGVCIJustificados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCIJustificados.Size = New System.Drawing.Size(680, 449)
        Me.DGVCIJustificados.TabIndex = 0
        '
        'DGVCISinJustificar
        '
        Me.DGVCISinJustificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCISinJustificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCISinJustificar.Location = New System.Drawing.Point(0, 0)
        Me.DGVCISinJustificar.Name = "DGVCISinJustificar"
        Me.DGVCISinJustificar.Size = New System.Drawing.Size(296, 449)
        Me.DGVCISinJustificar.TabIndex = 0
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Tab1)
        Me.Tab.Controls.Add(Me.Tab2)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(980, 26)
        Me.Tab.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TXTConsolaSQL)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(972, 0)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "Consola SQL"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'TXTConsolaSQL
        '
        Me.TXTConsolaSQL.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXTConsolaSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXTConsolaSQL.Location = New System.Drawing.Point(3, 3)
        Me.TXTConsolaSQL.Name = "TXTConsolaSQL"
        Me.TXTConsolaSQL.Size = New System.Drawing.Size(966, 0)
        Me.TXTConsolaSQL.TabIndex = 0
        Me.TXTConsolaSQL.Text = ""
        '
        'Tab2
        '
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(972, 0)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Tablas / Bases"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNJust1, Me.BTNJust2, Me.BTNJust3, Me.BTNJust4, Me.BTNJust5, Me.BTNJust6, Me.BTNJust7, Me.BTNJust8, Me.BTNJust9, Me.BTNJust10, Me.ToolStripSeparator1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(980, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BTNJust1
        '
        Me.BTNJust1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust1.Image = CType(resources.GetObject("BTNJust1.Image"), System.Drawing.Image)
        Me.BTNJust1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust1.Name = "BTNJust1"
        Me.BTNJust1.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust1.Text = "ToolStripButton1"
        '
        'BTNJust2
        '
        Me.BTNJust2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust2.Image = CType(resources.GetObject("BTNJust2.Image"), System.Drawing.Image)
        Me.BTNJust2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust2.Name = "BTNJust2"
        Me.BTNJust2.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust2.Text = "ToolStripButton2"
        '
        'BTNJust3
        '
        Me.BTNJust3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust3.Image = CType(resources.GetObject("BTNJust3.Image"), System.Drawing.Image)
        Me.BTNJust3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust3.Name = "BTNJust3"
        Me.BTNJust3.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust3.Text = "ToolStripButton3"
        '
        'BTNJust4
        '
        Me.BTNJust4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust4.Image = CType(resources.GetObject("BTNJust4.Image"), System.Drawing.Image)
        Me.BTNJust4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust4.Name = "BTNJust4"
        Me.BTNJust4.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust4.Text = "ToolStripButton4"
        '
        'BTNJust5
        '
        Me.BTNJust5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust5.Image = CType(resources.GetObject("BTNJust5.Image"), System.Drawing.Image)
        Me.BTNJust5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust5.Name = "BTNJust5"
        Me.BTNJust5.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust5.Text = "ToolStripButton5"
        '
        'BTNJust6
        '
        Me.BTNJust6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust6.Image = CType(resources.GetObject("BTNJust6.Image"), System.Drawing.Image)
        Me.BTNJust6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust6.Name = "BTNJust6"
        Me.BTNJust6.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust6.Text = "ToolStripButton6"
        '
        'BTNJust7
        '
        Me.BTNJust7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust7.Image = CType(resources.GetObject("BTNJust7.Image"), System.Drawing.Image)
        Me.BTNJust7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust7.Name = "BTNJust7"
        Me.BTNJust7.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust7.Text = "ToolStripButton7"
        '
        'BTNJust8
        '
        Me.BTNJust8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust8.Image = CType(resources.GetObject("BTNJust8.Image"), System.Drawing.Image)
        Me.BTNJust8.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust8.Name = "BTNJust8"
        Me.BTNJust8.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust8.Text = "ToolStripButton8"
        '
        'BTNJust9
        '
        Me.BTNJust9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust9.Image = CType(resources.GetObject("BTNJust9.Image"), System.Drawing.Image)
        Me.BTNJust9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust9.Name = "BTNJust9"
        Me.BTNJust9.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust9.Text = "ToolStripButton9"
        '
        'BTNJust10
        '
        Me.BTNJust10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTNJust10.Image = CType(resources.GetObject("BTNJust10.Image"), System.Drawing.Image)
        Me.BTNJust10.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTNJust10.Name = "BTNJust10"
        Me.BTNJust10.Size = New System.Drawing.Size(23, 22)
        Me.BTNJust10.Text = "ToolStripButton10"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ControlDeInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 525)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.BarraStatus)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "ControlDeInventarios"
        Me.Text = "ControlDeInventarios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Menu.ResumeLayout(False)
        Me.Menu.PerformLayout()
        Me.Contenedor.Panel1.ResumeLayout(False)
        Me.Contenedor.Panel2.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGVCIJustificados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCISinJustificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraStatus As StatusStrip
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Contenedor As SplitContainer
    Friend WithEvents Tab As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents TXTConsolaSQL As RichTextBox
    Friend WithEvents ImportarDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArchivoDeTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BaseDeDatosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DGVCIJustificados As DataGridView
    Friend WithEvents DGVCISinJustificar As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BTNJust1 As ToolStripButton
    Friend WithEvents BTNJust2 As ToolStripButton
    Friend WithEvents BTNJust3 As ToolStripButton
    Friend WithEvents BTNJust4 As ToolStripButton
    Friend WithEvents BTNJust5 As ToolStripButton
    Friend WithEvents BTNJust6 As ToolStripButton
    Friend WithEvents BTNJust7 As ToolStripButton
    Friend WithEvents BTNJust8 As ToolStripButton
    Friend WithEvents BTNJust9 As ToolStripButton
    Friend WithEvents BTNJust10 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
