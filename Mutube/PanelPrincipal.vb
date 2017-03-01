Imports VideoLibrary
Imports System.IO
Public Class Mutube
    Private Sub Mutube_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On load, set informationlabel as nothing
        informationlabel.Text = ""
        'Mode video on-off on launch (configurated on My.Settings)
        If My.Settings.OpModoVideoPorDefecto = True Then
            'For optimization, send event click on respect buttons
            Me.Button4_Click(sender, e)
        Else
            Me.Button3_Click(sender, e)
        End If
    End Sub
    Sub SaveVideoToTmp(ByVal link As String)
        'save video to tmp for then replay
        informationlabel.Text = "Processing..."
        Try
            'Creating var video as Youtube.Default.Getvideo
            Dim video = YouTube.Default.GetVideo(link)
            informationlabel.Text = "Dowloading..."
            'Creating var video as Path where save our video
            Dim route As String = Path.GetTempPath() & video.FullName
            File.WriteAllBytes(route, video.GetBytes())
            'Play video
            PlayVideoFromTmp(route)
        Catch ex As Exception
            informationlabel.Text = "Error, check the link..."
        End Try
    End Sub
    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        'but download
        SaveVideoToTmp(enlace.Text)
    End Sub
    Sub PlayVideoFromTmp(ByVal route As String)
        'Start video reproduction
        informationlabel.Text = "Playing video..."
        AxWindowsMediaPlayer.URL = route
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles descargar.Click
        'but for download video
        'if option default download are true, then don't ask for path and use customizated controller (Ajustes > "Descarga Automática)
        If My.Settings.OpcionesDescargaAut = True Then
            informationlabel.Text = "Processing..."
            Try
                Dim video = YouTube.Default.GetVideo(enlace.Text)
                informationlabel.Text = "Downloading..."
                File.WriteAllBytes(My.Settings.OpcionesDescargaAutRuta & "\" & video.FullName, video.GetBytes())
                informationlabel.Text = "Downloaded"
            Catch ex As Exception
                informationlabel.Text = "Error, check the link or download path (Settings > Automatic Downloads)"
            End Try
            'if option default donwload are false, then ask for path
        ElseIf FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            informationlabel.Text = "Processing..."
            Try
                Dim video = YouTube.Default.GetVideo(enlace.Text)
                informationlabel.Text = "Downloading..."
                File.WriteAllBytes(FolderBrowserDialog1.SelectedPath & "\" & video.FullName, video.GetBytes())
                informationlabel.Text = "Downloaded"
            Catch ex As Exception
                informationlabel.Text = "Error, chek the link..."
            End Try
        End If
    End Sub
    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonOcultarVideo.Click
        'Butt for hide video controller
        Me.Size = New Size(570, 148)
        AxWindowsMediaPlayer.Size = New Size(431, 47)
        ButtonVerVideo.Visible = True
        ButtonOcultarVideo.Visible = False
    End Sub
    Public Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonVerVideo.Click
        'Butt for show video controller
        Me.Size = New Size(570, 375)
        AxWindowsMediaPlayer.Size = New Size(431, 279)
        ButtonOcultarVideo.Visible = True
        ButtonVerVideo.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ajustes.Click
        PanelOpciones.Show()
    End Sub
End Class
