Imports System.Windows.Forms

Public Class GJPusher

    Public Shared Sub FileCheck()
        If My.Computer.FileSystem.FileExists(".\gjpush.exe") Then
            'Do Nothing
        Else
            Try
                Dim DlgResult As DialogResult = MessageBox.Show("There is a required file that is missing from the application. Download it now? (Internet required)", "File Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If DlgResult = DialogResult.Yes Then
                    DownloadFile.Downloader.GJPush("https://github.com/gamejolt/cli/releases/download/v0.3.0/windows.zip", "gjpush.zip")
                    DownloadFile.Downloader.Unzip("gjpush")
                    MessageBox.Show("gjpush Installed!", "File Installed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No File Will Be Downloaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while downloading gjpush:" & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Shared Sub normalbuild(ByVal token As String, ByVal gameid As Integer, ByVal packageid As Integer, ByVal versionid As String, ByVal GameFile As String)
        Dim SourcePathUpdateButler As String = "gjpush.exe" 'check for gamejolt push
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "gjpush.exe"
            pHelp.Arguments = "-t=" & token & " -g=" & gameid & " -p=" & packageid & " -r=" & versionid & " " & """" & GameFile & """"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""gjpush.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Shared Sub browserbuild(ByVal token As String, ByVal gameid As Integer, ByVal packageid As Integer, ByVal versionid As String, ByVal GameFile As String)
        Dim SourcePathUpdateButler As String = "gjpush.exe" 'check for gamejolt push
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler)
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "gjpush.exe"
            pHelp.Arguments = "-t=" & token & " -g=" & gameid & " -p=" & packageid & " -r=" & versionid & " -b " & """" & GameFile & """"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            ' The following example requires that Option Infer be set to On.

            ' Define the message you want to see inside the message box.
            Dim msg = "File ""gjpush.exe"" is missing; cannot push build."

            ' Define a title for the message box.
            Dim title = "Error: File Missing"

            ' Display the message box and save the response, Yes or No.
            Dim response = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
End Class
