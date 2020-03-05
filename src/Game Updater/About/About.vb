Imports AutoUpdaterDotNET

Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Label2.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        AutoUpdater.ShowSkipButton = False
        AutoUpdater.ShowRemindLaterButton = True
        AutoUpdater.ReportErrors = True
        AutoUpdater.RunUpdateAsAdmin = True
        AutoUpdater.LetUserSelectRemindLater = True
        AutoUpdater.RemindLaterTimeSpan = RemindLaterFormat.Hours
        AutoUpdater.RemindLaterAt = 1
        AutoUpdater.UpdateFormSize = New System.Drawing.Size(554, 489)
        AutoUpdater.Start("http://api.thecrafters001.ga/updates/Launcher.xml")
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class