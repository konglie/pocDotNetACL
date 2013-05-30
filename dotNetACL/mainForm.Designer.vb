<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.mainMenu = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Form1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Form2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.statusBar = New System.Windows.Forms.StatusStrip
        Me.mainStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.userInfo = New System.Windows.Forms.ToolStripStatusLabel
        Me.mainMenu.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.FormsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(426, 24)
        Me.mainMenu.TabIndex = 1
        Me.mainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.FileToolStripMenuItem.Text = "Aplikasi"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Keluar"
        '
        'FormsToolStripMenuItem
        '
        Me.FormsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form1ToolStripMenuItem, Me.Form2ToolStripMenuItem})
        Me.FormsToolStripMenuItem.Name = "FormsToolStripMenuItem"
        Me.FormsToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FormsToolStripMenuItem.Text = "Forms"
        '
        'Form1ToolStripMenuItem
        '
        Me.Form1ToolStripMenuItem.Name = "Form1ToolStripMenuItem"
        Me.Form1ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form1ToolStripMenuItem.Text = "Form 1"
        '
        'Form2ToolStripMenuItem
        '
        Me.Form2ToolStripMenuItem.Name = "Form2ToolStripMenuItem"
        Me.Form2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.Form2ToolStripMenuItem.Text = "Form 2"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainStatus, Me.userInfo})
        Me.statusBar.Location = New System.Drawing.Point(0, 216)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(426, 22)
        Me.statusBar.TabIndex = 2
        Me.statusBar.Text = "Application Status"
        '
        'mainStatus
        '
        Me.mainStatus.Name = "mainStatus"
        Me.mainStatus.Size = New System.Drawing.Size(316, 17)
        Me.mainStatus.Spring = True
        Me.mainStatus.Text = "application status text"
        Me.mainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userInfo
        '
        Me.userInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.userInfo.Name = "userInfo"
        Me.userInfo.Size = New System.Drawing.Size(95, 17)
        Me.userInfo.Text = "user information"
        '
        'mainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(426, 238)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.mainMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Title"
        Me.mainMenu.ResumeLayout(False)
        Me.mainMenu.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents statusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents mainStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents FormsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents userInfo As System.Windows.Forms.ToolStripStatusLabel

End Class
