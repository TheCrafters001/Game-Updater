Imports System.Windows.Forms

Public Class ItchPush

    Public Shared Sub FileCheck()
        If My.Computer.FileSystem.FileExists(".\butler.exe") Then
            'Do Nothing
        Else
            Try
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

End Class
