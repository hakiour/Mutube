<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mutube
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mutube))
        Me.enviar = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.enlace = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.descargar = New System.Windows.Forms.Button()
        Me.ajustes = New System.Windows.Forms.Button()
        Me.informationlabel = New System.Windows.Forms.Label()
        Me.ButtonOcultarVideo = New System.Windows.Forms.Button()
        Me.ButtonVerVideo = New System.Windows.Forms.Button()
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'enviar
        '
        Me.enviar.BackColor = System.Drawing.Color.Transparent
        Me.enviar.BackgroundImage = CType(resources.GetObject("enviar.BackgroundImage"), System.Drawing.Image)
        Me.enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.enviar.FlatAppearance.BorderSize = 2
        Me.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enviar.Location = New System.Drawing.Point(599, 14)
        Me.enviar.Margin = New System.Windows.Forms.Padding(4)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(36, 36)
        Me.enviar.TabIndex = 0
        Me.enviar.UseVisualStyleBackColor = False
        '
        'enlace
        '
        Me.enlace.Location = New System.Drawing.Point(16, 18)
        Me.enlace.Margin = New System.Windows.Forms.Padding(4)
        Me.enlace.Name = "enlace"
        Me.enlace.Size = New System.Drawing.Size(573, 22)
        Me.enlace.TabIndex = 3
        '
        'AxWindowsMediaPlayer
        '
        Me.AxWindowsMediaPlayer.Enabled = True
        Me.AxWindowsMediaPlayer.Location = New System.Drawing.Point(12, 52)
        Me.AxWindowsMediaPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.AxWindowsMediaPlayer.Name = "AxWindowsMediaPlayer"
        Me.AxWindowsMediaPlayer.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer.Size = New System.Drawing.Size(577, 70)
        Me.AxWindowsMediaPlayer.TabIndex = 4
        '
        'descargar
        '
        Me.descargar.BackColor = System.Drawing.Color.Transparent
        Me.descargar.BackgroundImage = CType(resources.GetObject("descargar.BackgroundImage"), System.Drawing.Image)
        Me.descargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.descargar.FlatAppearance.BorderSize = 2
        Me.descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.descargar.Location = New System.Drawing.Point(643, 14)
        Me.descargar.Margin = New System.Windows.Forms.Padding(4)
        Me.descargar.Name = "descargar"
        Me.descargar.Size = New System.Drawing.Size(36, 36)
        Me.descargar.TabIndex = 5
        Me.descargar.UseVisualStyleBackColor = False
        '
        'ajustes
        '
        Me.ajustes.BackColor = System.Drawing.Color.Transparent
        Me.ajustes.BackgroundImage = CType(resources.GetObject("ajustes.BackgroundImage"), System.Drawing.Image)
        Me.ajustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ajustes.FlatAppearance.BorderSize = 2
        Me.ajustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ajustes.Location = New System.Drawing.Point(687, 14)
        Me.ajustes.Margin = New System.Windows.Forms.Padding(4)
        Me.ajustes.Name = "ajustes"
        Me.ajustes.Size = New System.Drawing.Size(36, 36)
        Me.ajustes.TabIndex = 7
        Me.ajustes.UseVisualStyleBackColor = False
        '
        'informationlabel
        '
        Me.informationlabel.AutoSize = True
        Me.informationlabel.Location = New System.Drawing.Point(265, 46)
        Me.informationlabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.informationlabel.Name = "informationlabel"
        Me.informationlabel.Size = New System.Drawing.Size(48, 17)
        Me.informationlabel.TabIndex = 8
        Me.informationlabel.Text = "Status"
        '
        'ButtonOcultarVideo
        '
        Me.ButtonOcultarVideo.BackColor = System.Drawing.Color.Transparent
        Me.ButtonOcultarVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonOcultarVideo.FlatAppearance.BorderSize = 2
        Me.ButtonOcultarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOcultarVideo.Location = New System.Drawing.Point(599, 64)
        Me.ButtonOcultarVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOcultarVideo.Name = "ButtonOcultarVideo"
        Me.ButtonOcultarVideo.Size = New System.Drawing.Size(124, 58)
        Me.ButtonOcultarVideo.TabIndex = 9
        Me.ButtonOcultarVideo.Text = "HIDE VIDEO"
        Me.ButtonOcultarVideo.UseVisualStyleBackColor = False
        '
        'ButtonVerVideo
        '
        Me.ButtonVerVideo.BackColor = System.Drawing.Color.Transparent
        Me.ButtonVerVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonVerVideo.FlatAppearance.BorderSize = 2
        Me.ButtonVerVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonVerVideo.Location = New System.Drawing.Point(599, 64)
        Me.ButtonVerVideo.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonVerVideo.Name = "ButtonVerVideo"
        Me.ButtonVerVideo.Size = New System.Drawing.Size(124, 58)
        Me.ButtonVerVideo.TabIndex = 10
        Me.ButtonVerVideo.Text = "WATCH VIDEO"
        Me.ButtonVerVideo.UseVisualStyleBackColor = False
        '
        'Mutube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 133)
        Me.Controls.Add(Me.ButtonVerVideo)
        Me.Controls.Add(Me.ButtonOcultarVideo)
        Me.Controls.Add(Me.informationlabel)
        Me.Controls.Add(Me.ajustes)
        Me.Controls.Add(Me.descargar)
        Me.Controls.Add(Me.AxWindowsMediaPlayer)
        Me.Controls.Add(Me.enlace)
        Me.Controls.Add(Me.enviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Mutube"
        Me.Text = "Mutube"
        CType(Me.AxWindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents enviar As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents enlace As TextBox
    Friend WithEvents AxWindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents descargar As Button
    Friend WithEvents ajustes As Button
    Friend WithEvents informationlabel As Label
    Friend WithEvents ButtonOcultarVideo As Button
    Friend WithEvents ButtonVerVideo As Button
End Class
