<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.itch_pcbox = New System.Windows.Forms.PictureBox()
        Me.gamejolt_pcbox = New System.Windows.Forms.PictureBox()
        Me.about_pcbox = New System.Windows.Forms.PictureBox()
        CType(Me.itch_pcbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gamejolt_pcbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.about_pcbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'itch_pcbox
        '
        Me.itch_pcbox.BackColor = System.Drawing.Color.Transparent
        Me.itch_pcbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.itch_pcbox.Image = Global.Game_Updater.My.Resources.Resources.Itch
        Me.itch_pcbox.Location = New System.Drawing.Point(12, 12)
        Me.itch_pcbox.Name = "itch_pcbox"
        Me.itch_pcbox.Size = New System.Drawing.Size(200, 200)
        Me.itch_pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.itch_pcbox.TabIndex = 0
        Me.itch_pcbox.TabStop = False
        '
        'gamejolt_pcbox
        '
        Me.gamejolt_pcbox.BackColor = System.Drawing.Color.Transparent
        Me.gamejolt_pcbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gamejolt_pcbox.Image = Global.Game_Updater.My.Resources.Resources.GameJolt
        Me.gamejolt_pcbox.Location = New System.Drawing.Point(12, 218)
        Me.gamejolt_pcbox.Name = "gamejolt_pcbox"
        Me.gamejolt_pcbox.Size = New System.Drawing.Size(200, 200)
        Me.gamejolt_pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.gamejolt_pcbox.TabIndex = 1
        Me.gamejolt_pcbox.TabStop = False
        '
        'about_pcbox
        '
        Me.about_pcbox.BackColor = System.Drawing.Color.Transparent
        Me.about_pcbox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.about_pcbox.Image = Global.Game_Updater.My.Resources.Resources.About
        Me.about_pcbox.Location = New System.Drawing.Point(218, 12)
        Me.about_pcbox.Name = "about_pcbox"
        Me.about_pcbox.Size = New System.Drawing.Size(200, 200)
        Me.about_pcbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.about_pcbox.TabIndex = 2
        Me.about_pcbox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Game_Updater.My.Resources.Resources.GameUpdater_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(430, 430)
        Me.Controls.Add(Me.about_pcbox)
        Me.Controls.Add(Me.gamejolt_pcbox)
        Me.Controls.Add(Me.itch_pcbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Updater"
        CType(Me.itch_pcbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gamejolt_pcbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.about_pcbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents itch_pcbox As PictureBox
    Friend WithEvents gamejolt_pcbox As PictureBox
    Friend WithEvents about_pcbox As PictureBox
End Class
