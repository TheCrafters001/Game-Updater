Public Class Form1
    Private Sub about_pcbox_Click(sender As Object, e As EventArgs) Handles about_pcbox.Click
        About.Show()
    End Sub

    Private Sub itch_pcbox_Click(sender As Object, e As EventArgs) Handles itch_pcbox.Click
        ItchPush.ItchPush.FileCheck()
        Itch.Show()
        Me.Close()
    End Sub
End Class
