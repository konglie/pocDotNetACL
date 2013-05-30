' Copyright ali LIM
' lee@konglie.web.id

Imports MySql.Data.MySqlClient.MySqlConnection
Public Class mysqlHandler
    Private conn As MySql.Data.MySqlClient.MySqlConnection
    Private da As MySql.Data.MySqlClient.MySqlDataAdapter
    Private _rowset As DataSet
    Public ReadOnly Property rowset() As DataSet
        Get
            Return _rowset
        End Get
    End Property
    Private _resultrows As Dictionary(Of Integer, Dictionary(Of String, String))
    Public ReadOnly Property resultrows() As Dictionary(Of Integer, Dictionary(Of String, String))
        Get
            Return _resultrows
        End Get
    End Property
    Private _resultrow As Dictionary(Of String, String)
    Public ReadOnly Property resultrow() As Dictionary(Of String, String)
        Get
            Return _resultrow
        End Get
    End Property
    Private _datavar As String
    Public ReadOnly Property datavar() As String
        Get
            Return _datavar
        End Get
    End Property
    Public Sub New()
        Dim dbConnString As String = ""
        Dim dbInfo As New Dictionary(Of String, String)

        ' DATABASE CONNECTION PARAMETERS
        ' minimal musti ada 2 table dibawah ini

        'CREATE TABLE IF NOT EXISTS `user` (
        '  `uid` int(11) NOT NULL,
        '  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
        '  `pass` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
        '  `group` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
        '  PRIMARY KEY (`uid`)
        ') ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

        'CREATE TABLE IF NOT EXISTS `useraccess` (
        '  `gid` int(11) NOT NULL,
        '  `name` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
        '  `access` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
        '  PRIMARY KEY (`gid`)
        ') ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

        dbInfo.Add("server", "localhost")
        dbInfo.Add("user", "root")
        dbInfo.Add("password", "")
        dbInfo.Add("database", "dotnetacl")

        For Each pair As KeyValuePair(Of String, String) In dbInfo
            dbConnString &= pair.Key & "=" & pair.Value & ";"
        Next

        conn = New MySql.Data.MySqlClient.MySqlConnection(dbConnString)
        connectDB()
    End Sub
    Public Sub clearResult()
        _resultrow = New Dictionary(Of String, String)()
        _resultrows = New Dictionary(Of Integer, Dictionary(Of String, String))()
        _rowset = New DataSet
    End Sub

    Public Sub query(ByVal sql As String)

    End Sub

    Public Sub connectDB()
        clearResult()
        If conn.State = ConnectionState.Closed Then
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Database Connection Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Public Function hasRow() As Boolean
        Return Me.resultrow.Count > 0 Or Me.resultrows.Count > 0
    End Function

    Public Function getDataset(ByVal sql As String, Optional ByVal tableName As String = "queryTable") As DataSet
        clearResult()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, conn)
        da.Fill(_rowset, tableName)

        Return _rowset
    End Function

    Public Function getDBRows(ByVal sql As String) As Dictionary(Of Integer, Dictionary(Of String, String))
        Dim rows As New Dictionary(Of Integer, Dictionary(Of String, String))()
        Dim row As New Dictionary(Of String, String)()
        getDataset(sql)
        Dim _data As DataTable = _rowset.Tables.Item(0)
        Dim data As DataRowCollection = _data.Rows
        Dim dcs As DataColumnCollection = _data.Columns

        Dim i As Integer
        For i = 1 To data.Count
            Dim dr As DataRow = data.Item(i - 1)
            row = extractRow(dr, dcs)
            rows.Add(i - 1, row)
        Next i
        _resultrows = rows

        Return rows
    End Function
    Private Function extractRow(ByVal data As DataRow, ByVal columns As DataColumnCollection) As Dictionary(Of String, String)
        Dim row As New Dictionary(Of String, String)()

        Dim dc As DataColumn
        For Each dc In columns
            Dim column As String = dc.ColumnName
            If row.ContainsKey(column) Then
                row.Remove(column)
            End If
            row.Add(column, data.Item(column))
        Next

        Return row
    End Function

    Public Function getRow(ByVal sql As String) As Dictionary(Of String, String)
        Dim row As New Dictionary(Of String, String)()
        getDataset(sql)
        Dim _data As DataTable = _rowset.Tables.Item(0)
        Dim data As DataRowCollection = _data.Rows
        Dim dcs As DataColumnCollection = _data.Columns

        If data.Count < 1 Then
            Return row
        End If

        Dim dr As DataRow = data.Item(0)
        row = extractRow(dr, dcs)
        _resultrow = row

        Return row
    End Function
End Class
