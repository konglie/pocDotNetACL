' Copyright ali LIM
' lee@konglie.web.id

Imports menuItem = System.Windows.Forms.ToolStripMenuItem

Module session
    Private userInfo As New Dictionary(Of String, Object)
    Private loginTime As New Date
    Public Sub auth(ByVal username As String, ByVal pass As String)
        Dim authSQL As String = "SELECT * FROM user WHERE name = '" & username & "' AND pass = '" & pass & "'"
        mainForm.db.getRow(authSQL)
        userInfo = New Dictionary(Of String, Object)()
        For Each pair As KeyValuePair(Of String, String) In mainForm.db.resultrow
            var(pair.Key, pair.Value)
        Next

        loginTime = Now
        var("loginTime", loginTime)
        buildApplicationMenu()
    End Sub

    Public Function isLoggedIn() As Boolean
        Return var("uid") IsNot Nothing
    End Function

    Public Sub start()
        userInfo = New Dictionary(Of String, Object)
        buildApplicationMenu()
    End Sub

    Private Sub buildApplicationMenu()
        collectUserAccess()
        Dim userMenus As Dictionary(Of String, Object)

        Dim mn As MenuStrip = mainForm.mainMenu
        mn.Items.Clear()

        Dim appStrip As New menuItem
        appStrip.Text = "Aplikasi"
        mn.Items.Add(appStrip)

        Dim exitStrip As New menuItem
        exitStrip.Text = "Tutup"
        AddHandler exitStrip.Click, AddressOf mainForm.exitApplication
        appStrip.DropDownItems.Add(exitStrip)

        userMenus = var("usermenus")
        If Not userMenus Is Nothing Then
            Dim menus As New KeyValuePair(Of String, Object)
            For Each menus In userMenus
                Dim mnStrip As New menuItem
                mnStrip.Text = menus.Key

                Dim mnItems As Dictionary(Of Integer, String) = menus.Value
                For Each subs As KeyValuePair(Of Integer, String) In mnItems
                    Dim subStrip As New menuItem
                    Dim frm As Form = mainForm.getFormObject(subs.Value)
                    If frm Is Nothing Then
                        MsgBox("nothing for " & subs.Value)
                        Continue For
                    End If

                    subStrip.Text = frm.Text
                    subStrip.Tag = frm
                    AddHandler subStrip.Click, AddressOf mainForm.menuItemClick

                    mnStrip.DropDownItems.Add(subStrip)
                Next

                mn.Items.Add(mnStrip)
            Next
        End If

        Dim helpStrip As New menuItem
        helpStrip.Text = "Help"
        mn.Items.Add(helpStrip)

        If isLoggedIn() Then
            Dim logoutStrip As New menuItem
            logoutStrip.Text = "Keluar"
            AddHandler logoutStrip.Click, AddressOf mainForm.logoutApplication
            helpStrip.DropDownItems.Add(logoutStrip)
        End If

        Dim aboutStrip As New menuItem
        aboutStrip.Text = "Info Aplikasi"
        aboutStrip.Tag = New appAbout
        AddHandler aboutStrip.Click, AddressOf mainForm.menuItemClick
        helpStrip.DropDownItems.Add(aboutStrip)
    End Sub

    Private Sub collectUserAccess()
        Dim group As String = var("group")
        If (group = "" Or group = Nothing) Then
            Return
        End If

        Dim userMenus As New Dictionary(Of String, Object)()
        Dim allMenus As New List(Of String)

        Dim groups As String() = group.Split(",")
        For i As Integer = 0 To groups.Length - 1
            Dim g As String = groups(i).Trim()
            Dim sql As String = "SELECT name, access FROM useraccess WHERE gid = '" & g & "'"
            mainForm.db.getRow(sql)

            If mainForm.db.hasRow = False Then
                Continue For
            End If

            Dim groupName As String = mainForm.db.resultrow.Item("name")
            Dim access As String() = mainForm.db.resultrow.Item("access").Split(",")

            Dim menu As New Dictionary(Of Integer, String)

            For j As Integer = 0 To access.Length - 1
                Dim m As String = access(j).Trim
                If allMenus.Contains(m) Then
                    Continue For
                End If

                menu.Add(j, m)
                allMenus.Add(m)
            Next

            userMenus.Add(groupName, menu)
        Next

        var("usermenus", userMenus)
    End Sub

    Public Function var(ByVal key As String, Optional ByVal newval As Object = Nothing) As Object
        Dim val As Object = Nothing
        If newval Is Nothing Then
            If userInfo.ContainsKey(key) Then
                Return userInfo.Item(key)
            End If
        Else
            If userInfo.ContainsKey(key) Then
                userInfo.Remove(key)
            End If

            userInfo.Item(key) = newval
        End If

        Return val
    End Function
End Module
