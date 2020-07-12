Imports AutoUpdaterDotNET

Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AutoUpdater.ShowSkipButton = True
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(554, 489)
        AutoUpdater.Start("http://api.thecrafters001.ga/updates/gameupdater.xml")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Dim DlgResult As DialogResult = MessageBox.Show("This will check if there are any missing files, then it will download them from the internet if they are. Are you sure you want to check for files?", "Check for Missing Files", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If DlgResult = DialogResult.Yes Then
                FilesCheck.Show()
            Else
                MessageBox.Show("Okay, I will not check for files!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class