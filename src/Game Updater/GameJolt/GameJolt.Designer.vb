<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameJolt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameJolt))
        Me.ext_btn = New System.Windows.Forms.Button()
        Me.buildPush_btn = New System.Windows.Forms.Button()
        Me.folderBrowser_btn = New System.Windows.Forms.Button()
        Me.folderPath_txtBox = New System.Windows.Forms.TextBox()
        Me.folder_lbl = New System.Windows.Forms.Label()
        Me.version_txtBox = New System.Windows.Forms.TextBox()
        Me.version_lbl = New System.Windows.Forms.Label()
        Me.gameID_txtBox = New System.Windows.Forms.TextBox()
        Me.gameID_lbl = New System.Windows.Forms.Label()
        Me.token_txtBox = New System.Windows.Forms.TextBox()
        Me.token_lbl = New System.Windows.Forms.Label()
        Me.packageID_txtBox = New System.Windows.Forms.TextBox()
        Me.packageID_lbl = New System.Windows.Forms.Label()
        Me.fileSelecter = New System.Windows.Forms.OpenFileDialog()
        Me.webBuild_chkBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ext_btn
        '
        Me.ext_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ext_btn.Location = New System.Drawing.Point(12, 397)
        Me.ext_btn.Name = "ext_btn"
        Me.ext_btn.Size = New System.Drawing.Size(45, 23)
        Me.ext_btn.TabIndex = 26
        Me.ext_btn.Text = "Exit"
        Me.ext_btn.UseVisualStyleBackColor = True
        '
        'buildPush_btn
        '
        Me.buildPush_btn.Location = New System.Drawing.Point(343, 397)
        Me.buildPush_btn.Name = "buildPush_btn"
        Me.buildPush_btn.Size = New System.Drawing.Size(75, 23)
        Me.buildPush_btn.TabIndex = 25
        Me.buildPush_btn.Text = "Push Build"
        Me.buildPush_btn.UseVisualStyleBackColor = True
        '
        'folderBrowser_btn
        '
        Me.folderBrowser_btn.Location = New System.Drawing.Point(391, 190)
        Me.folderBrowser_btn.Name = "folderBrowser_btn"
        Me.folderBrowser_btn.Size = New System.Drawing.Size(27, 22)
        Me.folderBrowser_btn.TabIndex = 24
        Me.folderBrowser_btn.Text = "..."
        Me.folderBrowser_btn.UseVisualStyleBackColor = True
        '
        'folderPath_txtBox
        '
        Me.folderPath_txtBox.Location = New System.Drawing.Point(12, 190)
        Me.folderPath_txtBox.Name = "folderPath_txtBox"
        Me.folderPath_txtBox.ReadOnly = True
        Me.folderPath_txtBox.Size = New System.Drawing.Size(373, 20)
        Me.folderPath_txtBox.TabIndex = 23
        '
        'folder_lbl
        '
        Me.folder_lbl.AutoSize = True
        Me.folder_lbl.BackColor = System.Drawing.Color.Transparent
        Me.folder_lbl.Location = New System.Drawing.Point(12, 174)
        Me.folder_lbl.Name = "folder_lbl"
        Me.folder_lbl.Size = New System.Drawing.Size(115, 13)
        Me.folder_lbl.TabIndex = 22
        Me.folder_lbl.Text = "Folder Containing Build"
        '
        'version_txtBox
        '
        Me.version_txtBox.Location = New System.Drawing.Point(12, 149)
        Me.version_txtBox.Name = "version_txtBox"
        Me.version_txtBox.Size = New System.Drawing.Size(406, 20)
        Me.version_txtBox.TabIndex = 21
        '
        'version_lbl
        '
        Me.version_lbl.AutoSize = True
        Me.version_lbl.BackColor = System.Drawing.Color.Transparent
        Me.version_lbl.Location = New System.Drawing.Point(12, 133)
        Me.version_lbl.Name = "version_lbl"
        Me.version_lbl.Size = New System.Drawing.Size(42, 13)
        Me.version_lbl.TabIndex = 20
        Me.version_lbl.Text = "Version"
        '
        'gameID_txtBox
        '
        Me.gameID_txtBox.Location = New System.Drawing.Point(12, 68)
        Me.gameID_txtBox.Name = "gameID_txtBox"
        Me.gameID_txtBox.Size = New System.Drawing.Size(406, 20)
        Me.gameID_txtBox.TabIndex = 17
        '
        'gameID_lbl
        '
        Me.gameID_lbl.AutoSize = True
        Me.gameID_lbl.BackColor = System.Drawing.Color.Transparent
        Me.gameID_lbl.Location = New System.Drawing.Point(12, 52)
        Me.gameID_lbl.Name = "gameID_lbl"
        Me.gameID_lbl.Size = New System.Drawing.Size(49, 13)
        Me.gameID_lbl.TabIndex = 16
        Me.gameID_lbl.Text = "Game ID"
        '
        'token_txtBox
        '
        Me.token_txtBox.Location = New System.Drawing.Point(12, 27)
        Me.token_txtBox.Name = "token_txtBox"
        Me.token_txtBox.Size = New System.Drawing.Size(406, 20)
        Me.token_txtBox.TabIndex = 15
        '
        'token_lbl
        '
        Me.token_lbl.AutoSize = True
        Me.token_lbl.BackColor = System.Drawing.Color.Transparent
        Me.token_lbl.Location = New System.Drawing.Point(12, 11)
        Me.token_lbl.Name = "token_lbl"
        Me.token_lbl.Size = New System.Drawing.Size(38, 13)
        Me.token_lbl.TabIndex = 14
        Me.token_lbl.Text = "Token"
        '
        'packageID_txtBox
        '
        Me.packageID_txtBox.Location = New System.Drawing.Point(12, 107)
        Me.packageID_txtBox.Name = "packageID_txtBox"
        Me.packageID_txtBox.Size = New System.Drawing.Size(406, 20)
        Me.packageID_txtBox.TabIndex = 28
        '
        'packageID_lbl
        '
        Me.packageID_lbl.AutoSize = True
        Me.packageID_lbl.BackColor = System.Drawing.Color.Transparent
        Me.packageID_lbl.Location = New System.Drawing.Point(12, 91)
        Me.packageID_lbl.Name = "packageID_lbl"
        Me.packageID_lbl.Size = New System.Drawing.Size(64, 13)
        Me.packageID_lbl.TabIndex = 27
        Me.packageID_lbl.Text = "Package ID"
        '
        'webBuild_chkBox
        '
        Me.webBuild_chkBox.AutoSize = True
        Me.webBuild_chkBox.BackColor = System.Drawing.Color.Transparent
        Me.webBuild_chkBox.Location = New System.Drawing.Point(12, 216)
        Me.webBuild_chkBox.Name = "webBuild_chkBox"
        Me.webBuild_chkBox.Size = New System.Drawing.Size(75, 17)
        Me.webBuild_chkBox.TabIndex = 29
        Me.webBuild_chkBox.Text = "Web Build"
        Me.webBuild_chkBox.UseVisualStyleBackColor = False
        '
        'GameJolt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Updater.My.Resources.Resources.GameUpdater_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 430)
        Me.Controls.Add(Me.webBuild_chkBox)
        Me.Controls.Add(Me.packageID_txtBox)
        Me.Controls.Add(Me.packageID_lbl)
        Me.Controls.Add(Me.ext_btn)
        Me.Controls.Add(Me.buildPush_btn)
        Me.Controls.Add(Me.folderBrowser_btn)
        Me.Controls.Add(Me.folderPath_txtBox)
        Me.Controls.Add(Me.folder_lbl)
        Me.Controls.Add(Me.version_txtBox)
        Me.Controls.Add(Me.version_lbl)
        Me.Controls.Add(Me.gameID_txtBox)
        Me.Controls.Add(Me.gameID_lbl)
        Me.Controls.Add(Me.token_txtBox)
        Me.Controls.Add(Me.token_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GameJolt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameJolt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ext_btn As Button
    Friend WithEvents buildPush_btn As Button
    Friend WithEvents folderBrowser_btn As Button
    Friend WithEvents folderPath_txtBox As TextBox
    Friend WithEvents folder_lbl As Label
    Friend WithEvents version_txtBox As TextBox
    Friend WithEvents version_lbl As Label
    Friend WithEvents gameID_txtBox As TextBox
    Friend WithEvents gameID_lbl As Label
    Friend WithEvents token_txtBox As TextBox
    Friend WithEvents token_lbl As Label
    Friend WithEvents packageID_txtBox As TextBox
    Friend WithEvents packageID_lbl As Label
    Friend WithEvents fileSelecter As OpenFileDialog
    Friend WithEvents webBuild_chkBox As CheckBox
End Class
