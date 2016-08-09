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
        Me.TXTPathBD = New System.Windows.Forms.TextBox()
        Me.BTNPathDB = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TXTNombreDBArt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNombreBDGru = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TXTPathBD
        '
        Me.TXTPathBD.Location = New System.Drawing.Point(12, 12)
        Me.TXTPathBD.Name = "TXTPathBD"
        Me.TXTPathBD.Size = New System.Drawing.Size(360, 20)
        Me.TXTPathBD.TabIndex = 5
        '
        'BTNPathDB
        '
        Me.BTNPathDB.Location = New System.Drawing.Point(12, 38)
        Me.BTNPathDB.Name = "BTNPathDB"
        Me.BTNPathDB.Size = New System.Drawing.Size(110, 23)
        Me.BTNPathDB.TabIndex = 4
        Me.BTNPathDB.Text = "Ubicación BD"
        Me.BTNPathDB.UseVisualStyleBackColor = True
        '
        'TXTNombreDBArt
        '
        Me.TXTNombreDBArt.Location = New System.Drawing.Point(154, 71)
        Me.TXTNombreDBArt.Name = "TXTNombreDBArt"
        Me.TXTNombreDBArt.Size = New System.Drawing.Size(218, 20)
        Me.TXTNombreDBArt.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "NOMBRE BD ARTICULOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "NOMBRE BD GRUPOS"
        '
        'TXTNombreBDGru
        '
        Me.TXTNombreBDGru.Location = New System.Drawing.Point(154, 97)
        Me.TXTNombreBDGru.Name = "TXTNombreBDGru"
        Me.TXTNombreBDGru.Size = New System.Drawing.Size(218, 20)
        Me.TXTNombreBDGru.TabIndex = 8
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNombreBDGru)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTNombreDBArt)
        Me.Controls.Add(Me.TXTPathBD)
        Me.Controls.Add(Me.BTNPathDB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTPathBD As TextBox
    Friend WithEvents BTNPathDB As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents TXTNombreDBArt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNombreBDGru As TextBox
End Class
