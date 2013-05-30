' Copyright ali LIM
' lee@konglie.web.id

Imports System.Reflection

Public Class mainForm
    Public db As mysqlHandler
    Private appTitle As String

    Private t As Timer
    Private showChild As Form

    Private minWidth As Integer = 442
    Private minHeight As Integer = 276
    Private moveW = 0
    Private moveH = 0

    Private Sub mainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' to edit or set mysql connection paramaters
        ' see mysqlHandler constructor
        db = New mysqlHandler

        appTitle = Me.Text
        session.start()

        setStatus("Aplikasi siap dijalankan")
        loadChild(New loginForm)
    End Sub

    Public Sub logoutApplication(ByVal sender As System.Object, ByVal e As System.EventArgs)
        session.start()
        loadChild(New loginForm)
        loginForm.setUserInfo()
    End Sub

    Public Sub loadChild(ByVal win As Form)
        For Each child As Form In Me.MdiChildren
            If win.Name = child.Name Then
                'setStatus("Form " & win.Text & " telah dibuka")
                Return
            End If
        Next

        Me.showChild = win
        Me.t = New Timer
        Me.t.Interval = 1000 / 40
        AddHandler Me.t.Tick, AddressOf t_handler
        Me.t.Enabled = True
        Me.t.Start()
    End Sub

    Private Sub t_handler()
        Dim win As Form = Me.showChild
        Dim w As Integer = win.Width
        Dim h As Integer = win.Height + statusBar.Height + mainMenu.Height

        If h < minHeight Then
            h = minHeight
        End If

        If w < minWidth Then
            w = minWidth
        End If

        Dim move As Integer = 2
        Dim diff As Integer = 0
        Dim fps As Integer = 400 / Me.t.Interval

        If Me.Width <> w Then
            move = w / fps
            If Me.Width < w Then
                diff = w - Me.Width
                If move > diff Then
                    move = diff
                End If
                Me.Width += move
            Else
                diff = Me.Width - w
                If move > diff Then
                    move = diff
                End If
                Me.Width -= move
            End If
        End If
        If Me.Height <> h Then
            move = h / fps
            If Me.Height < h Then
                diff = h - Me.Height
                If move > diff Then
                    move = diff
                End If
                Me.Height += move
            Else
                diff = Me.Height - h
                If move > diff Then
                    move = diff
                End If
                Me.Height -= move
            End If
        End If

        If Me.Height = h AndAlso Me.Width = w Then
            Me.t.Stop()
            Me.t.Enabled = False

            Try
                win.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                win.MinimizeBox = False
                win.MaximizeBox = False
                win.ShowIcon = False
                win.ShowInTaskbar = False
                win.ControlBox = False
                win.MdiParent = Me

                Me.setStatus(win.Text)
                Me.Text = appTitle & " :: " & win.Text
                win.Show()
            Catch e As Exception
                setStatus("Error: " & e.Message)
            End Try

            Me.clearOtherChild()
            win.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Public Sub setStatus(ByVal text As String)
        mainStatus.Text = text & "."
    End Sub
    Public Sub setUserStatus(ByVal s As String)
        Me.userInfo.Text = s
    End Sub
    Public Sub showSearchDialog(ByVal keyval As Dictionary(Of String, String), ByVal sql As String)
        Dim searchForm As New searchForm
        Me.db.getDataset(sql)
        Dim pair As KeyValuePair(Of String, String)
        Dim column As DataGridViewTextBoxColumn
        Dim columns As New List(Of DataGridViewTextBoxColumn)

        For Each pair In keyval
            Dim dbField As String = pair.Key
            Dim columnName As String = pair.Value

            column = New DataGridViewTextBoxColumn()
            column.HeaderText = columnName
            column.Width = 0
            column.DataPropertyName = dbField
            columns.Add(column)
        Next

        showSearchDialog(columns, sql)
    End Sub

    Public Sub showSearchDialog(ByVal columns As List(Of DataGridViewTextBoxColumn), ByVal sql As String)
        Dim searchForm As New searchForm
        'Me.db.getDataset(sql)

        searchForm.setColumn(columns, sql, Me)
    End Sub
    Private Sub clearOtherChild()
        For Each child As Form In Me.MdiChildren
            If child.Name = showChild.Name Then
                Continue For
            End If
            child.Close()
            child.Dispose()
        Next
        Me.Text = appTitle
    End Sub

#Region "Menus"
    Public Function getFormObject(ByVal name As String, Optional ByVal args() As Object = Nothing) As Form

        Dim returnObj As Object = Nothing
        Dim frmName As String = "dotNetACL." & name
        Dim Type As Type = Assembly.GetExecutingAssembly().GetType(frmName)
        If Type IsNot Nothing Then
            returnObj = Activator.CreateInstance(Type, args)
        End If
        Return returnObj
    End Function
    Public Sub menuItemClick(ByVal theMenuItem As System.Object, ByVal e As System.EventArgs)
        Dim mn As ToolStripMenuItem
        mn = theMenuItem
        Dim frm As Object
        frm = Activator.CreateInstance(mn.Tag.GetType)
        loadChild(frm)
    End Sub

    Public Sub exitApplication(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        clearOtherChild()
    End Sub

    Private Sub Form1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form1ToolStripMenuItem.Click
        loadChild(New form3())
    End Sub

    Private Sub Form2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Form2ToolStripMenuItem.Click
        loadChild(New form2())
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        loadChild(New appAbout())
    End Sub
#End Region


    Private Sub userInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles userInfo.Click
        Dim info As String = ""
        If session.var("uid") Is Nothing Then
            MsgBox("Belum ada user yang login")
            Return
        End If

        Dim dt As Date
        dt = session.var("loginTime")
        info &= "User: " & session.var("name") & " (uid: " & session.var("uid") & ")" & vbCrLf
        info &= "Login jam " & String.Format("{0:HH:mm:ss}", dt)

        MsgBox(info)
    End Sub
End Class
