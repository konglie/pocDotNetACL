<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchForm
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
		Me.theGrid = New System.Windows.Forms.DataGridView
		Me.txtSearch = New System.Windows.Forms.TextBox
		Me.btnClose = New System.Windows.Forms.Button
		Me.Button1 = New System.Windows.Forms.Button
		Me.searchTitle = New System.Windows.Forms.Label
		Me.searchStatus = New System.Windows.Forms.StatusStrip
		Me.searchHelp = New System.Windows.Forms.ToolStripStatusLabel
		CType(Me.theGrid, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.searchStatus.SuspendLayout()
		Me.SuspendLayout()
		'
		'theGrid
		'
		Me.theGrid.AllowUserToAddRows = False
		Me.theGrid.AllowUserToDeleteRows = False
		Me.theGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.theGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
		Me.theGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.theGrid.Location = New System.Drawing.Point(5, 71)
		Me.theGrid.MultiSelect = False
		Me.theGrid.Name = "theGrid"
		Me.theGrid.ReadOnly = True
		Me.theGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
		Me.theGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.theGrid.ShowEditingIcon = False
		Me.theGrid.Size = New System.Drawing.Size(542, 247)
		Me.theGrid.TabIndex = 0
		'
		'txtSearch
		'
		Me.txtSearch.Location = New System.Drawing.Point(6, 39)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(262, 22)
		Me.txtSearch.TabIndex = 2
		'
		'btnClose
		'
		Me.btnClose.Location = New System.Drawing.Point(437, 324)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(110, 26)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Tutup"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(285, 38)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(102, 21)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Cari"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'searchTitle
		'
		Me.searchTitle.AutoSize = True
		Me.searchTitle.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.searchTitle.Location = New System.Drawing.Point(8, 5)
		Me.searchTitle.Name = "searchTitle"
		Me.searchTitle.Size = New System.Drawing.Size(193, 30)
		Me.searchTitle.TabIndex = 5
		Me.searchTitle.Text = "Data Yang Tersedia"
		'
		'searchStatus
		'
		Me.searchStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.searchHelp})
		Me.searchStatus.Location = New System.Drawing.Point(5, 364)
		Me.searchStatus.Name = "searchStatus"
		Me.searchStatus.Size = New System.Drawing.Size(551, 22)
		Me.searchStatus.TabIndex = 6
		Me.searchStatus.Text = "StatusStrip1"
		'
		'searchHelp
		'
		Me.searchHelp.Name = "searchHelp"
		Me.searchHelp.Size = New System.Drawing.Size(0, 17)
		'
		'searchForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(561, 391)
		Me.Controls.Add(Me.searchStatus)
		Me.Controls.Add(Me.searchTitle)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.txtSearch)
		Me.Controls.Add(Me.theGrid)
		Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "searchForm"
		Me.Padding = New System.Windows.Forms.Padding(5)
		Me.ShowInTaskbar = False
		Me.Text = "Pencarian Data"
		CType(Me.theGrid, System.ComponentModel.ISupportInitialize).EndInit()
		Me.searchStatus.ResumeLayout(False)
		Me.searchStatus.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents theGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents searchTitle As System.Windows.Forms.Label
    Friend WithEvents searchStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents searchHelp As System.Windows.Forms.ToolStripStatusLabel
End Class
