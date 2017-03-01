<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelOpciones
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Radioinisi = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Radioinino = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Radiovideosi = New System.Windows.Forms.RadioButton()
        Me.Radiovideono = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Radiodesi = New System.Windows.Forms.RadioButton()
        Me.Radiodesno = New System.Windows.Forms.RadioButton()
        Me.Buttoncancelar = New System.Windows.Forms.Button()
        Me.ButtonGuardar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Radioinisi)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Radioinino)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 134)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(267, 65)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        '
        'Radioinisi
        '
        Me.Radioinisi.AutoSize = True
        Me.Radioinisi.Location = New System.Drawing.Point(75, 34)
        Me.Radioinisi.Margin = New System.Windows.Forms.Padding(4)
        Me.Radioinisi.Name = "Radioinisi"
        Me.Radioinisi.Size = New System.Drawing.Size(53, 21)
        Me.Radioinisi.TabIndex = 7
        Me.Radioinisi.Text = "Yes"
        Me.Radioinisi.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Start automatically with Windows"
        '
        'Radioinino
        '
        Me.Radioinino.AutoSize = True
        Me.Radioinino.Checked = True
        Me.Radioinino.Location = New System.Drawing.Point(15, 34)
        Me.Radioinino.Margin = New System.Windows.Forms.Padding(4)
        Me.Radioinino.Name = "Radioinino"
        Me.Radioinino.Size = New System.Drawing.Size(47, 21)
        Me.Radioinino.TabIndex = 8
        Me.Radioinino.TabStop = True
        Me.Radioinino.Text = "No"
        Me.Radioinino.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Radiovideosi)
        Me.GroupBox2.Controls.Add(Me.Radiovideono)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 74)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(269, 60)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enable default video mode"
        '
        'Radiovideosi
        '
        Me.Radiovideosi.AutoSize = True
        Me.Radiovideosi.Location = New System.Drawing.Point(72, 32)
        Me.Radiovideosi.Margin = New System.Windows.Forms.Padding(4)
        Me.Radiovideosi.Name = "Radiovideosi"
        Me.Radiovideosi.Size = New System.Drawing.Size(53, 21)
        Me.Radiovideosi.TabIndex = 4
        Me.Radiovideosi.Text = "Yes"
        Me.Radiovideosi.UseVisualStyleBackColor = True
        '
        'Radiovideono
        '
        Me.Radiovideono.AutoSize = True
        Me.Radiovideono.Checked = True
        Me.Radiovideono.Location = New System.Drawing.Point(12, 32)
        Me.Radiovideono.Margin = New System.Windows.Forms.Padding(4)
        Me.Radiovideono.Name = "Radiovideono"
        Me.Radiovideono.Size = New System.Drawing.Size(47, 21)
        Me.Radiovideono.TabIndex = 5
        Me.Radiovideono.TabStop = True
        Me.Radiovideono.Text = "No"
        Me.Radiovideono.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Radiodesi)
        Me.GroupBox1.Controls.Add(Me.Radiodesno)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(269, 59)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "*Path"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Automatic downloads"
        '
        'Radiodesi
        '
        Me.Radiodesi.AutoSize = True
        Me.Radiodesi.Location = New System.Drawing.Point(72, 33)
        Me.Radiodesi.Margin = New System.Windows.Forms.Padding(4)
        Me.Radiodesi.Name = "Radiodesi"
        Me.Radiodesi.Size = New System.Drawing.Size(53, 21)
        Me.Radiodesi.TabIndex = 1
        Me.Radiodesi.Text = "Yes"
        Me.Radiodesi.UseVisualStyleBackColor = True
        '
        'Radiodesno
        '
        Me.Radiodesno.AutoSize = True
        Me.Radiodesno.Checked = True
        Me.Radiodesno.Location = New System.Drawing.Point(12, 33)
        Me.Radiodesno.Margin = New System.Windows.Forms.Padding(4)
        Me.Radiodesno.Name = "Radiodesno"
        Me.Radiodesno.Size = New System.Drawing.Size(47, 21)
        Me.Radiodesno.TabIndex = 2
        Me.Radiodesno.TabStop = True
        Me.Radiodesno.Text = "No"
        Me.Radiodesno.UseVisualStyleBackColor = True
        '
        'Buttoncancelar
        '
        Me.Buttoncancelar.Location = New System.Drawing.Point(16, 207)
        Me.Buttoncancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.Buttoncancelar.Name = "Buttoncancelar"
        Me.Buttoncancelar.Size = New System.Drawing.Size(100, 28)
        Me.Buttoncancelar.TabIndex = 15
        Me.Buttoncancelar.Text = "Cancel"
        Me.Buttoncancelar.UseVisualStyleBackColor = True
        '
        'ButtonGuardar
        '
        Me.ButtonGuardar.Location = New System.Drawing.Point(185, 207)
        Me.ButtonGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGuardar.Name = "ButtonGuardar"
        Me.ButtonGuardar.Size = New System.Drawing.Size(100, 28)
        Me.ButtonGuardar.TabIndex = 14
        Me.ButtonGuardar.Text = "Save"
        Me.ButtonGuardar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(288, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "*Beta | Created by Hamza Akiour - hamza.es"
        '
        'PanelOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 256)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Buttoncancelar)
        Me.Controls.Add(Me.ButtonGuardar)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PanelOpciones"
        Me.Text = "PanelOpciones"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Radioinisi As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Radioinino As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Radiovideosi As RadioButton
    Friend WithEvents Radiovideono As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Radiodesi As RadioButton
    Friend WithEvents Radiodesno As RadioButton
    Friend WithEvents Buttoncancelar As Button
    Friend WithEvents ButtonGuardar As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Label5 As Label
End Class
