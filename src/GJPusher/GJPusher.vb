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
End Class
