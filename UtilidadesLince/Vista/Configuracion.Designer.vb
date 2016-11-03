<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNombreBDGru = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTNombreDBArt = New System.Windows.Forms.TextBox()
        Me.TXTPathBD = New System.Windows.Forms.TextBox()
        Me.BTNPathDB = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabCI = New System.Windows.Forms.TabPage()
        Me.LBL3 = New System.Windows.Forms.Label()
        Me.LBL2 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.LBL1 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.LBL10 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LBL9 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LBL8 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LBL7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LBL6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LBL5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LBL4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabCI.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTNombreBDGru)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTNombreDBArt)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TXTPathBD)
        Me.SplitContainer1.Panel1.Controls.Add(Me.BTNPathDB)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(384, 431)
        Me.SplitContainer1.SplitterDistance = 152
        Me.SplitContainer1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "NOMBRE BD GRUPOS"
        '
        'TXTNombreBDGru
        '
        Me.TXTNombreBDGru.Location = New System.Drawing.Point(154, 97)
        Me.TXTNombreBDGru.Name = "TXTNombreBDGru"
        Me.TXTNombreBDGru.Size = New System.Drawing.Size(218, 20)
        Me.TXTNombreBDGru.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "NOMBRE BD ARTICULOS"
        '
        'TXTNombreDBArt
        '
        Me.TXTNombreDBArt.Location = New System.Drawing.Point(154, 71)
        Me.TXTNombreDBArt.Name = "TXTNombreDBArt"
        Me.TXTNombreDBArt.Size = New System.Drawing.Size(218, 20)
        Me.TXTNombreDBArt.TabIndex = 12
        '
        'TXTPathBD
        '
        Me.TXTPathBD.Location = New System.Drawing.Point(12, 12)
        Me.TXTPathBD.Name = "TXTPathBD"
        Me.TXTPathBD.Size = New System.Drawing.Size(360, 20)
        Me.TXTPathBD.TabIndex = 11
        '
        'BTNPathDB
        '
        Me.BTNPathDB.Location = New System.Drawing.Point(12, 38)
        Me.BTNPathDB.Name = "BTNPathDB"
        Me.BTNPathDB.Size = New System.Drawing.Size(110, 23)
        Me.BTNPathDB.TabIndex = 10
        Me.BTNPathDB.Text = "Ubicación BD"
        Me.BTNPathDB.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabCI)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(384, 275)
        Me.TabControl1.TabIndex = 0
        '
        'TabCI
        '
        Me.TabCI.Controls.Add(Me.LBL3)
        Me.TabCI.Controls.Add(Me.LBL2)
        Me.TabCI.Controls.Add(Me.PictureBox10)
        Me.TabCI.Controls.Add(Me.LBL1)
        Me.TabCI.Controls.Add(Me.PictureBox9)
        Me.TabCI.Controls.Add(Me.PictureBox8)
        Me.TabCI.Controls.Add(Me.LBL10)
        Me.TabCI.Controls.Add(Me.PictureBox7)
        Me.TabCI.Controls.Add(Me.LBL9)
        Me.TabCI.Controls.Add(Me.PictureBox6)
        Me.TabCI.Controls.Add(Me.LBL8)
        Me.TabCI.Controls.Add(Me.PictureBox5)
        Me.TabCI.Controls.Add(Me.LBL7)
        Me.TabCI.Controls.Add(Me.PictureBox4)
        Me.TabCI.Controls.Add(Me.LBL6)
        Me.TabCI.Controls.Add(Me.PictureBox3)
        Me.TabCI.Controls.Add(Me.LBL5)
        Me.TabCI.Controls.Add(Me.PictureBox2)
        Me.TabCI.Controls.Add(Me.LBL4)
        Me.TabCI.Controls.Add(Me.PictureBox1)
        Me.TabCI.Location = New System.Drawing.Point(4, 22)
        Me.TabCI.Name = "TabCI"
        Me.TabCI.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCI.Size = New System.Drawing.Size(376, 249)
        Me.TabCI.TabIndex = 0
        Me.TabCI.Text = "TabPage1"
        Me.TabCI.UseVisualStyleBackColor = True
        '
        'LBL3
        '
        Me.LBL3.AutoSize = True
        Me.LBL3.Location = New System.Drawing.Point(32, 73)
        Me.LBL3.Name = "LBL3"
        Me.LBL3.Size = New System.Drawing.Size(45, 13)
        Me.LBL3.TabIndex = 21
        Me.LBL3.Text = "Label13"
        '
        'LBL2
        '
        Me.LBL2.AutoSize = True
        Me.LBL2.Location = New System.Drawing.Point(32, 52)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(45, 13)
        Me.LBL2.TabIndex = 19
        Me.LBL2.Text = "Label12"
        '
        'PictureBox10
        '
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Location = New System.Drawing.Point(11, 220)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox10.TabIndex = 18
        Me.PictureBox10.TabStop = False
        '
        'LBL1
        '
        Me.LBL1.AutoSize = True
        Me.LBL1.Location = New System.Drawing.Point(32, 31)
        Me.LBL1.Name = "LBL1"
        Me.LBL1.Size = New System.Drawing.Size(45, 13)
        Me.LBL1.TabIndex = 17
        Me.LBL1.Text = "Label11"
        '
        'PictureBox9
        '
        Me.PictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox9.Location = New System.Drawing.Point(11, 199)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox9.TabIndex = 16
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Location = New System.Drawing.Point(11, 178)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        '
        'LBL10
        '
        Me.LBL10.AutoSize = True
        Me.LBL10.Location = New System.Drawing.Point(32, 222)
        Me.LBL10.Name = "LBL10"
        Me.LBL10.Size = New System.Drawing.Size(39, 13)
        Me.LBL10.TabIndex = 13
        Me.LBL10.Text = "Label9"
        '
        'PictureBox7
        '
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Location = New System.Drawing.Point(11, 157)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox7.TabIndex = 12
        Me.PictureBox7.TabStop = False
        '
        'LBL9
        '
        Me.LBL9.AutoSize = True
        Me.LBL9.Location = New System.Drawing.Point(32, 201)
        Me.LBL9.Name = "LBL9"
        Me.LBL9.Size = New System.Drawing.Size(39, 13)
        Me.LBL9.TabIndex = 11
        Me.LBL9.Text = "Label8"
        '
        'PictureBox6
        '
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Location = New System.Drawing.Point(11, 136)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'LBL8
        '
        Me.LBL8.AutoSize = True
        Me.LBL8.Location = New System.Drawing.Point(32, 180)
        Me.LBL8.Name = "LBL8"
        Me.LBL8.Size = New System.Drawing.Size(39, 13)
        Me.LBL8.TabIndex = 9
        Me.LBL8.Text = "Label7"
        '
        'PictureBox5
        '
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Location = New System.Drawing.Point(11, 115)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'LBL7
        '
        Me.LBL7.AutoSize = True
        Me.LBL7.Location = New System.Drawing.Point(32, 159)
        Me.LBL7.Name = "LBL7"
        Me.LBL7.Size = New System.Drawing.Size(39, 13)
        Me.LBL7.TabIndex = 7
        Me.LBL7.Text = "Label6"
        '
        'PictureBox4
        '
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(11, 94)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'LBL6
        '
        Me.LBL6.AutoSize = True
        Me.LBL6.Location = New System.Drawing.Point(32, 138)
        Me.LBL6.Name = "LBL6"
        Me.LBL6.Size = New System.Drawing.Size(39, 13)
        Me.LBL6.TabIndex = 5
        Me.LBL6.Text = "Label5"
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Location = New System.Drawing.Point(11, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'LBL5
        '
        Me.LBL5.AutoSize = True
        Me.LBL5.Location = New System.Drawing.Point(32, 117)
        Me.LBL5.Name = "LBL5"
        Me.LBL5.Size = New System.Drawing.Size(39, 13)
        Me.LBL5.TabIndex = 3
        Me.LBL5.Text = "Label4"
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(11, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'LBL4
        '
        Me.LBL4.AutoSize = True
        Me.LBL4.Location = New System.Drawing.Point(32, 96)
        Me.LBL4.Name = "LBL4"
        Me.LBL4.Size = New System.Drawing.Size(39, 13)
        Me.LBL4.TabIndex = 1
        Me.LBL4.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(11, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(376, 272)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 431)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabCI.ResumeLayout(False)
        Me.TabCI.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNombreBDGru As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTNombreDBArt As TextBox
    Friend WithEvents TXTPathBD As TextBox
    Friend WithEvents BTNPathDB As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabCI As TabPage
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents LBL10 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LBL9 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents LBL8 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents LBL7 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LBL6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LBL5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LBL4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents LBL3 As Label
    Friend WithEvents LBL2 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents LBL1 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
