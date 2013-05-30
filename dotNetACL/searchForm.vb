Public Class searchForm
    Private searchDialogCallback As String = "searchDialogCallback"
    Private searchDialogFilterCallback As String = "searchDialogFilterCallback"

    Private called As Boolean = False
    Private gridColumns As List(Of DataGridViewTextBoxColumn)
    Private Sub searchForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If called = False Then
            Me.Close()
        End If
    End Sub

    Public Sub setColumn(ByVal columns As List(Of DataGridViewTextBoxColumn), ByVal sql As String, ByVal parent As Form)

        Me.called = True
        clearColumns()

        mainForm.db.getDataset(sql, "searchResultTable")
        theGrid.DataSource = mainForm.db.rowset
        theGrid.AutoGenerateColumns = False
        theGrid.ReadOnly = True
        theGrid.DataMember = "searchResultTable"
        theGrid.VirtualMode = True

        Dim i As Integer = 0
        Dim column As DataGridViewTextBoxColumn
        column = New DataGridViewTextBoxColumn()
        column.Name = "columnIndex"
        column.HeaderText = "No."
        theGrid.Columns.Insert(i, column)

        For Each column In columns
            i += 1
            theGrid.Columns.Insert(i, column)
        Next

        gridColumns = columns
        If Me.Visible = False Then
            Me.ShowDialog(parent)
        End If
    End Sub
    Private Sub clearColumns()
        theGrid.Columns.Clear()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub theGrid_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles theGrid.CellMouseClick
        searchHelp.Text = "DoubleClick untuk memilih baris ini"
    End Sub

    Private Sub theGrid_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles theGrid.CellMouseDoubleClick
        Dim row As DataGridViewRow
        row = theGrid.Rows.Item(e.RowIndex)

        CallByName(mainForm, searchDialogCallback, CallType.Method, row, theGrid.Columns)
    End Sub

    Private Sub theGrid_CellValueNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles theGrid.CellValueNeeded
        If e.ColumnIndex = 0 Then
            e.Value = e.RowIndex + 1
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim filterSql As String = ""
        Dim filter As String = txtSearch.Text
        filterSql = CallByName(mainForm.MdiChildren(0), searchDialogFilterCallback, CallType.Method, filter)

        setColumn(gridColumns, filterSql, mainForm)
    End Sub

    Private Sub txtSearch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        Button1_Click(sender, e)
    End Sub

	Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged

	End Sub
End Class