Public Class GameJolt
    Private Sub folderBrowser_btn_Click(sender As Object, e As EventArgs) Handles folderBrowser_btn.Click
        Try
            fileSelecter.Filter = "Executables (.exe, .msi, .zip, .rar, .7z)|*.exe;*.msi;*.zip;*.rar;*.7z|ZIP files (.zip, .rar, .7z)|*.zip;*.rar;*.7z|All Files (*.*)|*.*"
            fileSelecter.FilterIndex = 1
            fileSelecter.RestoreDirectory = True
            fileSelecter.FileName = ""
            fileSelecter.ShowDialog()
            folderPath_txtBox.Text = fileSelecter.FileName()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buildPush_btn_Click(sender As Object, e As EventArgs) Handles buildPush_btn.Click
        Try
            If webBuild_chkBox.Checked = True Then
                GJPusher.GJPusher.browserbuild(token_txtBox.Text, gameID_txtBox.Text, packageID_txtBox.Text, version_txtBox.Text, folderPath_txtBox.Text)
            ElseIf webBuild_chkBox.Checked = False Then
                GJPusher.GJPusher.normalbuild(token_txtBox.Text, gameID_txtBox.Text, packageID_txtBox.Text, version_txtBox.Text, folderPath_txtBox.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class