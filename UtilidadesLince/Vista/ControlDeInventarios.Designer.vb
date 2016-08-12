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
        Me.BarraStatus = New System.Windows.Forms.StatusStrip()
        Me.Menu = New System.Windows.Forms.MenuStrip()
        Me.Contenedor = New System.Windows.Forms.SplitContainer()
        Me.DGVCI = New System.Windows.Forms.DataGridView()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.TXTConsolaSQL = New System.Windows.Forms.RichTextBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Contenedor.Panel1.SuspendLayout()
        Me.Contenedor.Panel2.SuspendLayout()
        Me.Contenedor.SuspendLayout()
        CType(Me.DGVCI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab.SuspendLayout()
        Me.Tab1.SuspendLayout()
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
        Me.Menu.Location = New System.Drawing.Point(0, 0)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(980, 24)
        Me.Menu.TabIndex = 1
        Me.Menu.Text = "MenuStrip1"
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
        Me.Contenedor.Panel1.Controls.Add(Me.DGVCI)
        '
        'Contenedor.Panel2
        '
        Me.Contenedor.Panel2.Controls.Add(Me.Tab)
        Me.Contenedor.Size = New System.Drawing.Size(980, 479)
        Me.Contenedor.SplitterDistance = 326
        Me.Contenedor.TabIndex = 2
        '
        'DGVCI
        '
        Me.DGVCI.AllowDrop = True
        Me.DGVCI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DGVCI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVCI.Location = New System.Drawing.Point(0, 0)
        Me.DGVCI.Name = "DGVCI"
        Me.DGVCI.Size = New System.Drawing.Size(980, 326)
        Me.DGVCI.TabIndex = 0
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Tab1)
        Me.Tab.Controls.Add(Me.Tab2)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(980, 149)
        Me.Tab.TabIndex = 0
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TXTConsolaSQL)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(972, 123)
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
        Me.TXTConsolaSQL.Size = New System.Drawing.Size(966, 117)
        Me.TXTConsolaSQL.TabIndex = 0
        Me.TXTConsolaSQL.Text = ""
        '
        'Tab2
        '
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(972, 123)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "Tablas / Bases"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'ControlDeInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 525)
        Me.Controls.Add(Me.Contenedor)
        Me.Controls.Add(Me.BarraStatus)
        Me.Controls.Add(Me.Menu)
        Me.MainMenuStrip = Me.Menu
        Me.Name = "ControlDeInventarios"
        Me.Text = "ControlDeInventarios"
        Me.Contenedor.Panel1.ResumeLayout(False)
        Me.Contenedor.Panel2.ResumeLayout(False)
        CType(Me.Contenedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Contenedor.ResumeLayout(False)
        CType(Me.DGVCI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraStatus As StatusStrip
    Friend WithEvents Menu As MenuStrip
    Friend WithEvents Contenedor As SplitContainer
    Friend WithEvents Tab As TabControl
    Friend WithEvents Tab1 As TabPage
    Friend WithEvents Tab2 As TabPage
    Friend WithEvents DGVCI As DataGridView
    Friend WithEvents TXTConsolaSQL As RichTextBox
End Class
