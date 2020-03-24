Public Class GameJolt
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Your User Token is a key that was issued to you when you signed up to GameJolt. You can find this key on the GameJolt website by clicking your Avatar (top right), and clicking Game Token", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        MessageBox.Show("The Game ID is a number provided by GameJolt that is only given to one game. For example, in your game dashboard, your URL will be https://gamejolt.com/dashboard/games/123456, that means your game ID would be 123456.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        MessageBox.Show("The Package ID is DIFFERENT from the Game ID. In this link https://gamejolt.com/dashboard/games/123456/packages/654321, the Game ID is shown, but the package you are currently viewing is numbered 654321.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        MessageBox.Show("Enter in the version of the game you are entering (has to be formatted as 1.2.3 or 1.2.3-build)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        MessageBox.Show("Location of where the game is located on your machine. Please use the Browse button.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            OpenFileDialog1.Filter = "Executables (.exe, .msi, .zip, .rar, .7z)|*.exe;*.msi;*.zip;*.rar;*.7z|ZIP files (.zip, .rar, .7z)|*.zip;*.rar;*.7z|All Files (*.*)|*.*"
            OpenFileDialog1.FilterIndex = 1
            OpenFileDialog1.RestoreDirectory = True
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.ShowDialog()
            TextBox5.Text = OpenFileDialog1.FileName()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        MessageBox.Show("Tells if you are making this game for a browser, or if it needs to be downloaded. (can be both, but can only upload one at a time.)", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            Try
                GJPush.GJPush.normalbuild(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            Catch ex As Exception
                MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf RadioButton2.Checked = True Then
            Try
                GJPush.GJPush.browserbuild(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
            Catch ex As Exception
                MessageBox.Show("The following error occurred: " & vbCrLf & ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class