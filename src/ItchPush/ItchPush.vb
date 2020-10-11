Imports System.Windows.Forms

Public Class ItchPush

    Public Shared Sub FileCheck()
        If My.Computer.FileSystem.FileExists(".\butler.exe") Then
            'Do Nothing
            Debug.WriteLine("Butler Found")
            Console.WriteLine("Butler Found")
        Else
            Try
                Debug.WriteLine("Butler Not Found")
                Console.WriteLine("Butler Not Found")
                Dim DlgResult As DialogResult = MessageBox.Show("There is a required file that is missing from the application. Download it now? (Internet required)", "File Missing", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If DlgResult = DialogResult.Yes Then
                    DownloadFile.Downloader.butler("https://broth.itch.ovh/butler/windows-386/LATEST/archive/default", "butler.zip")
                    DownloadFile.Downloader.Unzip("butler")
                    MessageBox.Show("butler Installed!", "File Installed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No File Will Be Downloaded", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while downloading butler:" & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Shared Sub normalbuild(ByVal folder As String, ByVal username As String, ByVal gameurl As String, ByVal os As String, ByVal version As String)
        Update()

        Dim SourcePathUpdateButler As String = "butler.exe"
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler)
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "push """ & folder & """ " & username & "/" & gameurl & ":" & os & " --userversion " & version
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            proc.WaitForExit()
        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("An error occurred:" & vbCrLf & ex.Message)
            Console.WriteLine("An error occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Shared Sub verbosebuild(ByVal folder As String, ByVal username As String, ByVal gameurl As String, ByVal os As String, ByVal version As String)
        Update()

        Dim SourcePathUpdateButler As String = "butler.exe"
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler)
        Try
            Dim pHelp As New ProcessStartInfo
            pHelp.FileName = "butler.exe"
            pHelp.Arguments = "push """ & folder & """ " & username & "/" & gameurl & ":" & os & " --userversion " & version & " --verbose"
            pHelp.UseShellExecute = True
            pHelp.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pHelp)
            proc.WaitForExit()
        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("An error occurred:" & vbCrLf & ex.Message)
            Console.WriteLine("An error occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Shared Sub Update()
        FileCheck()
        Dim SourcePathUpdateButler As String = "butler.exe" 'check for butler
        Dim FilenameUpdate As String = System.IO.Path.GetFileName(SourcePathUpdateButler) 'get the filename of the original file without the directory on it
        Try
            Dim pusher As New ProcessStartInfo
            pusher.FileName = "butler.exe"
            pusher.Arguments = "update"
            pusher.UseShellExecute = True
            pusher.WindowStyle = ProcessWindowStyle.Normal
            Dim proc As Process = Process.Start(pusher)
            proc.WaitForExit()
        Catch ex As Exception
            MessageBox.Show("An error occurred:" & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("An error occurred:" & vbCrLf & ex.Message)
            Console.WriteLine("An error occurred:" & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
