Imports System.IO

Public Class frmMain

    'Define global variables for OleDB connection
    Dim file, path, filePathString, conStr As String
    Dim lastSlash As Integer
    Dim ds As New DataSet

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MasterDataSet1.mytable' table. You can move, or remove it, as needed.
        Me.MytableTableAdapter.Fill(Me.MasterDataSet1.mytable)

    End Sub

    Private Sub Bcheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'Release hold on tables and data source
        ds.Tables.Clear()
        dgvDisplay.DataSource = Nothing
        'clear dgv
        dgvDisplay.Rows.Clear()
        Dim newConn As New OleDb.OleDbConnection(conStr)
        Dim chkSQL As New OleDb.OleDbDataAdapter("SELECT DAYS FROM mytable", newConn)
        chkSQL.Fill(ds, "TextFile")
        dgvDisplay.DataSource = ds.Tables(0)
    End Sub

    Public Function CreateAccessDatabase(ByVal DatabaseFullPath As String) As Boolean
        Dim bAns As Boolean
        Dim cat As New ADOX.Catalog()

        Try
            Dim sCreateString As String
            sCreateString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & DatabaseFullPath
            cat.Create(sCreateString)
            Dim tbl As ADOX.Table
            For Each tbl In cat.Tables
                MessageBox.Show(tbl.Name)
            Next
            bAns = True
        Catch Excep As System.Runtime.InteropServices.COMException
            bAns = False
        Finally
            cat = Nothing
        End Try

        Return bAns
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MytableTableAdapter.Check3(Me.MasterDataSet1.mytable)
        ListBox1.Items.Clear()
        For number As Integer = 0 To dgvDisplay.RowCount - 1
            Dim x As Integer = dgvDisplay.Rows(number).Cells(2).Value
            ListBox1.Items.Add(x)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.MytableTableAdapter.Check4(Me.MasterDataSet1.mytable)
        ListBox1.Items.Clear()
        For number As Integer = 1 To dgvDisplay.RowCount - 1
            Dim x As Integer = dgvDisplay.Rows(number).Cells(2).Value
            ListBox1.Items.Add(x)
        Next

    End Sub

    Private Sub btnCreate_Click(sender As System.Object, e As EventArgs) Handles btnCreate.Click
        ' Zach's version
        If OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            CreateAccessDatabase(fi.FullName)
            MsgBox("Database created")
        End If

        ' Alec's version
        'Dim adapter As New sanityCheckerDataSetTableAdapters.sanityCheckerTableAdapter
        'dgvDisplay.DataSource = adapter.GetData
        'MsgBox("Database created")
    End Sub

    Private Sub dgvDisplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        'Dim file As String
        'Dim path As String
        If OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            ' User selects file to open
            Dim fileAndPath As New FileInfo(OpenFileDialog1.FileName)
            ' File and path represented as a string
            filePathString = OpenFileDialog1.FileName
            lastSlash = filePathString.LastIndexOf("\")
            ' File isolated from filePathString
            file = filePathString.Substring(lastSlash + 1, filePathString.Length - lastSlash - 1)
            ' Path isolated from filePathString
            path = System.IO.Path.GetDirectoryName(filePathString)
        End If
        'Dim ds As New DataSet
        Try
            If IO.File.Exists(IO.Path.Combine(path, file)) Then
                conStr =
                "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" &
                path & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
                Dim conn As New OleDb.OleDbConnection(conStr)
                Dim da As New OleDb.OleDbDataAdapter("Select * from " &
                file, conn)
                da.Fill(ds, "TextFile")
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        dgvDisplay.DataSource = ds.Tables(0)
    End Sub

End Class
