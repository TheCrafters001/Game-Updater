Public Class Itch
    Private Sub ext_btn_Click(sender As Object, e As EventArgs) Handles ext_btn.Click
        Dim exitdialog As DialogResult
        exitdialog = MessageBox.Show("Are you sure you want to exit?", "Push To Itch", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If exitdialog = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub buildPush_btn_Click(sender As Object, e As EventArgs) Handles buildPush_btn.Click
        Try
            If verbose_chkBox.Checked = True Then
                ItchPush.ItchPush.verbosebuild(folderPath_txtBox.Text, userName_txtBox.Text, gameURL_txtBox.Text, os_cmb.SelectedItem.ToString, version_txtBox.Text)
            ElseIf verbose_chkBox.Checked = False Then
                ItchPush.ItchPush.normalbuild(folderPath_txtBox.Text, userName_txtBox.Text, gameURL_txtBox.Text, os_cmb.SelectedItem.ToString, version_txtBox.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub folderBrowser_btn_Click(sender As Object, e As EventArgs) Handles folderBrowser_btn.Click
        Try
            folderPathSelect.ShowDialog()
            folderPath_txtBox.Text = folderPathSelect.SelectedPath()
        Catch ex As Exception
            MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class