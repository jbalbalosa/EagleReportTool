Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Imports System.Windows.Input

Public Class frmMain

    Private DirPathEpicor As String = "C:\Users\" & Environment.UserName & "\AppData\Local\Temp\Epicor"
    Private DirPath3Apps As String = "C:\3apps\Temp"

    Private Sub loadExcelFile(filename As String)
        ' load Excel File To DataGridView

        Dim xlConn As New OleDb.OleDbConnection
        Dim xlDataset As New System.Data.DataSet
        Dim xlDataAdapter As New System.Data.OleDb.OleDbDataAdapter
        Dim xlCmd As New System.Data.OleDb.OleDbCommand


        xlConn = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source= " & filename & ";Extended Properties = 'Excel 12.0 Xml;HDR=YES;'")
        xlConn.Open()
        xlCmd.Connection = xlConn
        xlCmd.CommandType = CommandType.Text
        'xlCmd.CommandText = "select * from [Sheet1$] order by [Item Number], Store"

        'Filter the unique data.
        xlCmd.CommandText = "SELECT DISTINCT [item number] FROM [Sheet1$] ORDER BY [Item Number]"

        xlCmd.ExecuteNonQuery()

        xlDataAdapter.SelectCommand = xlCmd
        xlDataAdapter.TableMappings.Add("Table", "Sheet1")
        xlDataAdapter.Fill(xlDataset)

        'MessageBox.Show(xlDataset.Tables(0).Rows.Count())

        'MAYBE it doesn't need to show the data in datagridview
        With dgvData
            .DataSource = Nothing
            .DataSource = xlDataset
            .DataMember = "Sheet1"

            Dim col As New DataGridViewColumn
            col.HeaderText = "abc"

            .Columns.Insert(.ColumnCount, col)

        End With

        xlConn.Close()

    End Sub

    Private Sub LoadFiles(ByVal FileDirectory As String)

        Dim dDirectories() As String = IO.Directory.GetDirectories(FileDirectory)
        Dim strDirectory As String = ""

        Me.Cursor = Cursors.WaitCursor

        For Each Dir As String In dDirectories

            Application.DoEvents()
            Dim dFiles As New IO.DirectoryInfo(Dir.ToString)
            Dim dGetFiles As IO.FileInfo() = dFiles.GetFiles()
            Dim dFile As IO.FileInfo
            Dim strItem(4) As String
            Dim lsvItem As ListViewItem

            For Each dFile In dGetFiles
                Application.DoEvents()

                If Mid(dFile.ToString, 1, 2) <> "~$" And (Path.GetExtension(dFile.ToString) = ".xlsx" Or Path.GetExtension(dFile.ToString) = ".xls" Or Path.GetExtension(dFile.ToString) = ".csv") Then

                    strItem(0) = Path.GetFileName(dFile.ToString)
                    strItem(1) = Dir.ToString

                    lsvItem = New ListViewItem(strItem)
                    lsvFiles.Items.Add(lsvItem)
                    lsvFiles.Sorting = System.Windows.Forms.SortOrder.Ascending
                    lsvFiles.Sort()

                End If
            Next

            dFiles = Nothing
            dGetFiles = Nothing
        Next

        lblProcessing.Text = "Status: Ready"
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show(Me, "Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo) = vbYes Then
            End
        End If

    End Sub

    Private Sub butProcess_Click(sender As Object, e As EventArgs) Handles butProcess.Click

    End Sub

    Private Sub butExit_Click(sender As Object, e As EventArgs) Handles butExit.Click
        If MessageBox.Show(Me, "Are you sure you want to exit?", "Exit?", MessageBoxButtons.YesNo) = vbYes Then
            Close()
        End If

    End Sub

    Private Sub butSettings_Click(sender As Object, e As EventArgs) Handles butSettings.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Check Epicor directory
        Me.Text = "Surangel and Sons - Eagle Report Tool"
        lblProcessing.Text = "Status: "

        If Directory.Exists(DirPathEpicor) = False Then
            Directory.CreateDirectory("C:\Users\" & Environment.UserName & "\AppData\Local\Temp\Epicor")
        End If

        If Directory.Exists(DirPath3Apps) = False Then
            MessageBox.Show("Eagle 3apps file directory doesn't exist. Please contact your admin", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End If

        LoadFiles(DirPathEpicor)
        LoadFiles(DirPath3Apps)

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub lsvFiles_Click(sender As Object, e As EventArgs) Handles lsvFiles.Click
        Dim intIndex = lsvFiles.FocusedItem.Index
        Dim strFile = lsvFiles.Items(intIndex).SubItems(1).Text & "\" & lsvFiles.Items(intIndex).SubItems(0).Text

        'MessageBox.Show(strFile)

        loadExcelFile(strFile)


    End Sub

    Private Sub lsvFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvFiles.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        frmInfo.ShowDialog()
    End Sub
End Class
