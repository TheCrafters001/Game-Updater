Public Class GJPush
    Public Shared Sub normalbuild(ByVal token As String, ByVal gameid As Integer, ByVal packageid As Integer, ByVal versionid As String, ByVal GameFile As String)
        Dim SourcePathUpdateButler As String = "gjpush.exe" 'check for gamejolt push
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        If System.IO.File.Exists(SourcePathUpdateButler) Then
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "gj.exe"
            pHelp.Arguments = "-t " & token & " -g " & gameid & " -p " & packageid & " -r " & versionid & GameFile
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        Else
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "cmd.exe"
            pHelp.Arguments = "@echo off && cls && echo Error: Cannot run GameJolt Push, the file 'gjpush.exe' is missing! && pause"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
        End If
    End Sub
End Class