﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class appAbout
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.loginControl = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.loginControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(19, 0, 19, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(620, 172)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEMO DOANG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "lee@konglie.web.id"
        '
        'loginControl
        '
        Me.loginControl.Controls.Add(Me.Button1)
        Me.loginControl.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginControl.Location = New System.Drawing.Point(445, 200)
        Me.loginControl.Name = "loginControl"
        Me.loginControl.Size = New System.Drawing.Size(230, 72)
        Me.loginControl.TabIndex = 1
        Me.loginControl.TabStop = False
        Me.loginControl.Text = "Belum ada user"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Login Sekarang"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'appAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(38.0!, 86.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 308)
        Me.Controls.Add(Me.loginControl)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(19, 20, 19, 20)
        Me.Name = "appAbout"
        Me.Text = "About"
        Me.loginControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents loginControl As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
