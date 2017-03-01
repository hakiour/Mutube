Imports Microsoft
Imports Microsoft.Win32
Imports Microsoft.Win32.Registry
Public Class PanelOpciones
    Public señal As Boolean = False
    Dim auto As Boolean = False
    Dim auto2 As Boolean = False
    Private Sub PanelOpciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load settings cheks: auto vars is for check change status (auto changed check on load or is maked by click)
        'OpcionesDescargaAut
        If My.Settings.OpcionesDescargaAut = True Then
            auto2 = True
            Label4.Text = My.Settings.OpcionesDescargaAutRuta
            Radiodesi.Checked = True
        Else Radiodesno.Checked = True
        End If
        'OpModoVideoPorDefecto
        If My.Settings.OpModoVideoPorDefecto = True Then
            Radiovideosi.Checked = True
        Else Radiovideono.Checked = True
        End If
        'OpIniciarAutomáticamenteConWindows
        If My.Settings.OpIniciarAutomáticamenteConWindows = True Then
            auto = True
            Radioinisi.Checked = True
        Else Radioinino.Checked = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        'save Settings
        'OpcionesDescargaAut
        If Radiodesi.Checked = True Then
            My.Settings.OpcionesDescargaAut = True
        Else My.Settings.OpcionesDescargaAut = False
        End If

        'OpModoVideoPorDefecto
        If Radiovideosi.Checked = True Then
            My.Settings.OpModoVideoPorDefecto = True
        Else My.Settings.OpModoVideoPorDefecto = False
        End If

        'OpModoVideoPorDefecto
        If Radiovideosi.Checked = True Then
            My.Settings.OpModoVideoPorDefecto = True
            Mutube.Button4_Click(sender, e)
        Else
            My.Settings.OpModoVideoPorDefecto = False
            Mutube.Button3_Click(sender, e)
        End If

        'OpIniciarAutomáticamenteConWindows
        If Radioinisi.Checked = True Then
            My.Settings.OpIniciarAutomáticamenteConWindows = True
        Else My.Settings.OpIniciarAutomáticamenteConWindows = False
        End If

        Me.Close()
    End Sub
    Private Sub Radiodesi_CheckedChanged(sender As Object, e As EventArgs) Handles Radiodesi.CheckedChanged
        'If status of checked on OpcionesDescargaAut is changed to yes, show folder for select path, if changet to no, show only
        ' "*Ruta"
        If Radiodesi.Checked = True And auto2 = True Then
            Try
                Label4.Text = My.Settings.OpcionesDescargaAutRuta
            Catch ex As Exception
                'if can't load, se error and change the 
                MessageBox.Show("¡Error!", "Ups!")
                auto2 = False
                Radiodesno.Checked = True
            End Try
            'if changed to yes...
        ElseIf Radiodesi.Checked = True Then
            If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
                Label4.Text = FolderBrowserDialog1.SelectedPath
                My.Settings.OpcionesDescargaAutRuta = FolderBrowserDialog1.SelectedPath
            End If
            'if changed to no...
        ElseIf Radiodesno.Checked = True Then
            Label4.Text = "*Path"
            My.Settings.OpcionesDescargaAut = False
        End If
    End Sub
    'NO PROGRAMADO POR MI - AUTO INICIO CON WINDOWS
    Private Function start_Up(ByVal bCrear As Boolean) As String
        ' clave del registro para   
        ' colocar el path del ejecutable para iniciar con windows  
        Const CLAVE As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"

        'ProductName : el nombre del programa.  
        Dim subClave As String = Application.ProductName.ToString
        ' Mensaje para retornar el resultado  
        Dim msg As String = ""

        Try
            ' Abre la clave del usuario actual (CurrentUser) para poder extablecer el dato  
            ' si la clave CurrentVersion\Run no existe la crea  
            Dim Registro As RegistryKey = CurrentUser.CreateSubKey(CLAVE, RegistryKeyPermissionCheck.ReadWriteSubTree)
            With Registro
                .OpenSubKey(CLAVE, True)
                Select Case bCrear
                    ' Crear  
                    ''''''''''''''''''''''  
                    Case True
                        ' Escribe el path con SetValue   
                        'Valores : ProductName el nombre del programa y ExecutablePath : la ruta del exe  
                        .SetValue(subClave,
                                  Application.ExecutablePath.ToString)
                        Return "¡It's ok (key added)!"
                        ' Eliminar  
                        ''''''''''''''''''''''  
                        'Elimina la entrada con DeleteValue  
                    Case False
                        If .GetValue(subClave, "").ToString <> "" Then
                            .DeleteValue(subClave) ' eliminar  
                            msg = "Key deleted :("
                        Else
                            msg = "Not deleted, the program is not set to" &
                                   " start whit Windows"
                        End If
                End Select
            End With
            ' Error  
            ''''''''''''''''''''''  
        Catch ex As Exception
            msg = "Error...  You have to run the program as administrator to enable this option - " & ex.Message.ToString
            'AÑADIDA SEÑAL Y MODIFICADO MENSAJE PARA QUE SE PONGA EL CHECK EN NO Y EL MENSAJE ES MÁS ENTENDIBLE
            señal = True
            Radioinino.Checked = True
        End Try
        'retorno  
        Return msg
    End Function
    'ESTO YA VUELVE A ESTAR PROGRAMADO POR MI
    Private Sub Radioinisi_CheckedChanged(sender As Object, e As EventArgs) Handles Radioinisi.CheckedChanged
        'If status of checked on OpIniciarAutomáticamenteConWindows is changed to yes, send true, if changet to no, send false
        If Radioinisi.Checked = True And auto = False Then
            'create  
            MsgBox(start_Up(True))
            'delete  
        ElseIf Radioinisi.Checked = False And señal Then
            Radioinino.Checked = True
            señal = False
        ElseIf Radioinisi.Checked = False Then
            MsgBox(start_Up(False))
        End If
    End Sub
    Private Sub Buttoncancelar_Click(sender As Object, e As EventArgs) Handles Buttoncancelar.Click
        'Cancel close setting whitout save changes
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class