Imports System.IO
Imports System.IO.Compression
Imports System.HttpStyleUriParser
Imports System.Net
Imports System.Net.Http
Imports System.Windows.Forms

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
        Try
            If (Not System.IO.Directory.Exists(".\download")) Then
                System.IO.Directory.CreateDirectory(".\download")
                Debug.WriteLine("Created folder "".\download""")
                Console.WriteLine("Created folder "".\download""")
            End If
            Using client = New WebClient()
                Debug.WriteLine("Attempting to download GJPush to folder "".\download""")
                Console.WriteLine("Attempting to download GJPush to folder "".\download""")
                client.DownloadFile(New Uri(fileURL), ".\download\" & fileOutput)
                Debug.WriteLine("Downloaded GJPush to folder "".\download""")
                Console.WriteLine("Downloaded GJPush to folder "".\download""")
            End Using
        Catch ex As Exception
            MessageBox.Show("Sorry, cannot download file: " & ex.ToString, "Cannot Download", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub butler(ByVal fileURL As String, ByVal fileOutput As String)
        Try
            If (Not System.IO.Directory.Exists(".\download")) Then
                System.IO.Directory.CreateDirectory(".\download")
                Debug.WriteLine("Created folder "".\download""")
                Console.WriteLine("Created folder "".\download""")
            End If
            Using client = New WebClient()
                Debug.WriteLine("Attempting to download butler to folder "".\download""")
                Console.WriteLine("Attempting to download butler to folder "".\download""")
                client.DownloadFile(New Uri(fileURL), ".\download\" & fileOutput)
                Debug.WriteLine("Downloaded butler to folder "".\download""")
                Console.WriteLine("Downloaded butler to folder "".\download""")
            End Using
        Catch ex As Exception
            Console.WriteLine("Sorry, cannot download file: " & ex.ToString)
            Debug.WriteLine("Sorry, cannot download file: " & ex.ToString)
            MessageBox.Show("Sorry, cannot download file: " & ex.ToString, "Cannot Download", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Shared Sub Unzip(ByVal zipName As String)
        Try
            Dim startPath As String = ".\"
            Debug.WriteLine("Attempting to Unzip")
            Console.WriteLine("Attempting to Unzip")
            Dim zipPath As String = ".\download\" & zipName & ".zip"
            Dim extractPath As String = ".\"
            ZipFile.ExtractToDirectory(zipPath, extractPath)
            Debug.WriteLine("Unzipped!")
            Console.WriteLine("Unzipped!")
        Catch ex As Exception
            Console.WriteLine("Sorry, cannot unzip file: " & ex.ToString)
            Debug.WriteLine("Sorry, cannot unzip file: " & ex.ToString)
            MessageBox.Show("Sorry, cannot unzip file: " & ex.ToString, "Cannot unzip", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class