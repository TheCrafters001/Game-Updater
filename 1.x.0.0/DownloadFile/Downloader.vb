Imports System.IO
Imports System.IO.Compression
Imports System.HttpStyleUriParser
Imports System.Net
Imports System.Net.Http

Public Class Downloader

    'This will NOT download anything harmful to your computer.
    'This WILL download either GJPush or butler if the files are missing.
    'File downloads are from trusted sources (GitHub) and will 
    'not be changed, unless there is some major update.
    '
    'Please do NOT alter these files, as they are required, and
    'I don't want to be blamed for any wrong doing. Any pull request (PRs)
    'Will be ignored and closed.
    '
    '- TheCrafters001

    Public Shared Sub GJPush(ByVal fileURL As String, ByVal fileOutput As String)
        If (Not System.IO.Directory.Exists(".\download")) Then
            System.IO.Directory.CreateDirectory(".\download")
        End If
        Using client = New WebClient()
            client.DownloadFile(New Uri(fileURL), ".\download\" & fileOutput)
        End Using
    End Sub

    Public Shared Sub butler(ByVal fileURL As String, ByVal fileOutput As String)
        If (Not System.IO.Directory.Exists(".\download")) Then
            System.IO.Directory.CreateDirectory(".\download")
        End If
        Using client = New WebClient()
            client.DownloadFile(New Uri(fileURL), ".\download\" & fileOutput)
        End Using
    End Sub

    Public Shared Sub Unzip(ByVal zipName As String)
        Dim startPath As String = ".\"
        Dim zipPath As String = ".\download\" & zipName & ".zip"
        Dim extractPath As String = ".\"
        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub
End Class
