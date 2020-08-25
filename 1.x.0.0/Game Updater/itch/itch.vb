Imports ItchPush


Public Class itch

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            FolderBrowserDialog1.ShowDialog()
            TextBox5.Text = FolderBrowserDialog1.SelectedPath()
        Catch ex As Exception
            MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Your Username you use to login to Itch.IO with!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("This is where, when you visit your game in a browser, your link will appear as https://username.itch.io/game-name, where game-name is the Game URL", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("Select what Operating System(s) (OS(s)) that your game is compatible with", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MessageBox.Show("Enter in the version of the game you are entering (has to be formatted as 1.2.3 or 1.2.3-build)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        MessageBox.Show("Location of where the game is located on your machine. Please use the Browse button.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Try
                ItchPush.ItchPush.normalbuild(TextBox5.Text, TextBox1.Text, TextBox2.Text, ComboBox1.Text, TextBox4.Text)
            Catch ex As Exception
                MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf RadioButton2.Checked = True Then
            Try
                ItchPush.ItchPush.Verbose(TextBox5.Text, TextBox1.Text, TextBox2.Text, ComboBox1.Text, TextBox4.Text)
            Catch ex As Exception
                MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        MessageBox.Show("Be very chatty about what's happening while you are pushing your game.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class