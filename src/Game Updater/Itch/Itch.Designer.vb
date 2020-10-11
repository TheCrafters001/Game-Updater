<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Itch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Itch))
        Me.userName_lbl = New System.Windows.Forms.Label()
        Me.userName_txtBox = New System.Windows.Forms.TextBox()
        Me.gameURL_txtBox = New System.Windows.Forms.TextBox()
        Me.gameURL_lbl = New System.Windows.Forms.Label()
        Me.os_lbl = New System.Windows.Forms.Label()
        Me.os_cmb = New System.Windows.Forms.ComboBox()
        Me.version_txtBox = New System.Windows.Forms.TextBox()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.folderPath_txtBox = New System.Windows.Forms.TextBox()
        Me.folder_lbl = New System.Windows.Forms.Label()
        Me.folderBrowser_btn = New System.Windows.Forms.Button()
        Me.verbose_chkBox = New System.Windows.Forms.CheckBox()
        Me.buildPush_btn = New System.Windows.Forms.Button()
        Me.ext_btn = New System.Windows.Forms.Button()
        Me.folderPathSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'userName_lbl
        '
        Me.userName_lbl.AutoSize = True
        Me.userName_lbl.BackColor = System.Drawing.Color.Transparent
        Me.userName_lbl.Location = New System.Drawing.Point(12, 9)
        Me.userName_lbl.Name = "userName_lbl"
        Me.userName_lbl.Size = New System.Drawing.Size(58, 13)
        Me.userName_lbl.TabIndex = 0
        Me.userName_lbl.Text = "Username"
        '
        'userName_txtBox
        '
        Me.userName_txtBox.Location = New System.Drawing.Point(12, 25)
        Me.userName_txtBox.Name = "userName_txtBox"
        Me.userName_txtBox.Size = New System.Drawing.Size(406, 22)
        Me.userName_txtBox.TabIndex = 1
        '
        'gameURL_txtBox
        '
        Me.gameURL_txtBox.Location = New System.Drawing.Point(12, 66)
        Me.gameURL_txtBox.Name = "gameURL_txtBox"
        Me.gameURL_txtBox.Size = New System.Drawing.Size(406, 22)
        Me.gameURL_txtBox.TabIndex = 3
        '
        'gameURL_lbl
        '
        Me.gameURL_lbl.AutoSize = True
        Me.gameURL_lbl.BackColor = System.Drawing.Color.Transparent
        Me.gameURL_lbl.Location = New System.Drawing.Point(12, 50)
        Me.gameURL_lbl.Name = "gameURL_lbl"
        Me.gameURL_lbl.Size = New System.Drawing.Size(59, 13)
        Me.gameURL_lbl.TabIndex = 2
        Me.gameURL_lbl.Text = "Game URL"
        '
        'os_lbl
        '
        Me.os_lbl.AutoSize = True
        Me.os_lbl.BackColor = System.Drawing.Color.Transparent
        Me.os_lbl.Location = New System.Drawing.Point(12, 91)
        Me.os_lbl.Name = "os_lbl"
        Me.os_lbl.Size = New System.Drawing.Size(98, 13)
        Me.os_lbl.TabIndex = 4
        Me.os_lbl.Text = "Operating System"
        '
        'os_cmb
        '
        Me.os_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.os_cmb.FormattingEnabled = True
        Me.os_cmb.Items.AddRange(New Object() {"win-stable", "win-beta", "win-alpha", "windows-stable", "windows-beta", "windows-alpha", "linux-stable", "linux-beta", "linux-alpha", "mac-stable", "mac-beta", "mac-alpha", "osx-stable", "osx-beta", "osx-alpha", "android-stable", "android-beta", "android-alpha", "win-linux-mac-stable", "win-linux-mac-beta", "win-linux-mac-alpha", "win-linux-stable", "win-linux-beta", "win-linux-alpha", "win-mac-stable", "win-mac-beta", "win-mac-alpha", "linux-mac-stable", "linux-mac-beta", "linux-mac-alpha", "win-linux-mac-android-stable", "win-linux-mac-android-beta", "win-linux-mac-android-alpha", "win-linux-android-stable", "win-linux-android-beta", "win-linux-android-alpha", "win-mac-android-stable", "win-mac-android-beta", "win-mac-android-alpha", "win-android-stable", "win-android-beta", "win-android-alpha", "mac-android-stable", "mac-android-beta", "mac-android-alpha"})
        Me.os_cmb.Location = New System.Drawing.Point(12, 107)
        Me.os_cmb.Name = "os_cmb"
        Me.os_cmb.Size = New System.Drawing.Size(406, 21)
        Me.os_cmb.TabIndex = 5
        '
        'version_txtBox
        '
        Me.version_txtBox.Location = New System.Drawing.Point(12, 147)
        Me.version_txtBox.Name = "version_txtBox"
        Me.version_txtBox.Size = New System.Drawing.Size(406, 22)
        Me.version_txtBox.TabIndex = 7
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.BackColor = System.Drawing.Color.Transparent
        Me.version_lbl.Location = New System.Drawing.Point(12, 131)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(45, 13)
        Me.version_lbl.TabIndex = 6
        Me.version_lbl.Text = "Version"
        '
        'folderPath_txtBox
        '
        Me.folderPath_txtBox.Location = New System.Drawing.Point(12, 188)
        Me.folderPath_txtBox.Name = "folderPath_txtBox"
        Me.folderPath_txtBox.ReadOnly = True
        Me.folderPath_txtBox.Size = New System.Drawing.Size(373, 22)
        Me.folderPath_txtBox.TabIndex = 9
        '
        'folder_lbl
        '
        Me.folder_lbl.AutoSize = True
        Me.folder_lbl.BackColor = System.Drawing.Color.Transparent
        Me.folder_lbl.Location = New System.Drawing.Point(12, 172)
        Me.folder_lbl.Name = "folder_lbl"
        Me.folder_lbl.Size = New System.Drawing.Size(130, 13)
        Me.folder_lbl.TabIndex = 8
        Me.folder_lbl.Text = "Folder Containing Build"
        '
        'folderBrowser_btn
        '
        Me.folderBrowser_btn.Location = New System.Drawing.Point(391, 188)
        Me.folderBrowser_btn.Name = "folderBrowser_btn"
        Me.folderBrowser_btn.Size = New System.Drawing.Size(27, 22)
        Me.folderBrowser_btn.TabIndex = 10
        Me.folderBrowser_btn.Text = "..."
        Me.folderBrowser_btn.UseVisualStyleBackColor = True
        '
        'verbose_chkBox
        '
        Me.verbose_chkBox.AutoSize = True
        Me.verbose_chkBox.BackColor = System.Drawing.Color.Transparent
        Me.verbose_chkBox.Location = New System.Drawing.Point(12, 216)
        Me.verbose_chkBox.Name = "verbose_chkBox"
        Me.verbose_chkBox.Size = New System.Drawing.Size(89, 17)
        Me.verbose_chkBox.TabIndex = 11
        Me.verbose_chkBox.Text = "Use Verbose"
        Me.verbose_chkBox.UseVisualStyleBackColor = False
        '
        'buildPush_btn
        '
        Me.buildPush_btn.Location = New System.Drawing.Point(343, 395)
        Me.buildPush_btn.Name = "buildPush_btn"
        Me.buildPush_btn.Size = New System.Drawing.Size(75, 23)
        Me.buildPush_btn.TabIndex = 12
        Me.buildPush_btn.Text = "Push Build"
        Me.buildPush_btn.UseVisualStyleBackColor = True
        '
        'ext_btn
        '
        Me.ext_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ext_btn.Location = New System.Drawing.Point(12, 395)
        Me.ext_btn.Name = "ext_btn"
        Me.ext_btn.Size = New System.Drawing.Size(45, 23)
        Me.ext_btn.TabIndex = 13
        Me.ext_btn.Text = "Exit"
        Me.ext_btn.UseVisualStyleBackColor = True
        '
        'folderPathSelect
        '
        Me.folderPathSelect.Description = "Please select the folder where your game build is located."
        Me.folderPathSelect.ShowNewFolderButton = False
        '
        'Itch
        '
        Me.AcceptButton = Me.buildPush_btn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Updater.My.Resources.Resources.GameUpdater_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.ext_btn
        Me.ClientSize = New System.Drawing.Size(430, 430)
        Me.Controls.Add(Me.ext_btn)
        Me.Controls.Add(Me.buildPush_btn)
        Me.Controls.Add(Me.verbose_chkBox)
        Me.Controls.Add(Me.folderBrowser_btn)
        Me.Controls.Add(Me.folderPath_txtBox)
        Me.Controls.Add(Me.folder_lbl)
        Me.Controls.Add(Me.version_txtBox)
        Me.Controls.Add(Me.version_lbl)
        Me.Controls.Add(Me.os_cmb)
        Me.Controls.Add(Me.os_lbl)
        Me.Controls.Add(Me.gameURL_txtBox)
        Me.Controls.Add(Me.gameURL_lbl)
        Me.Controls.Add(Me.userName_txtBox)
        Me.Controls.Add(Me.userName_lbl)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Itch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Itch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents userName_lbl As Label
    Friend WithEvents userName_txtBox As TextBox
    Friend WithEvents gameURL_txtBox As TextBox
    Friend WithEvents gameURL_lbl As Label
    Friend WithEvents os_lbl As Label
    Friend WithEvents os_cmb As ComboBox
    Friend WithEvents version_txtBox As TextBox
    Friend WithEvents version_lbl As Label
    Friend WithEvents folderPath_txtBox As TextBox
    Friend WithEvents folder_lbl As Label
    Friend WithEvents folderBrowser_btn As Button
    Friend WithEvents verbose_chkBox As CheckBox
    Friend WithEvents buildPush_btn As Button
    Friend WithEvents ext_btn As Button
    Friend WithEvents folderPathSelect As FolderBrowserDialog
End Class
