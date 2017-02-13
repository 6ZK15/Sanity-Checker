
Imports System.IO
        Imports System.Data
        Imports System.Data.OleDb
        Imports System.Data.SqlClient
Public Class Form1

    Dim ds As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSortCollege.Click
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "CSV Files (*.csv)|*.csv"

        If OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then

            Try
                Dim fi As New FileInfo(OpenFileDialog1.FileName)
                Dim sConnectionStringz As String = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Text;Data Source=" & fi.DirectoryName
                Dim objConn As New OleDbConnection(sConnectionStringz)
                objConn.Open()
                'DataGridView1.TabIndex = 1
                Dim objCmdSelect As New OleDbCommand("SELECT * FROM " & fi.Name, objConn)
                Dim objAdapter1 As New OleDbDataAdapter
                objAdapter1.SelectCommand = objCmdSelect
                Dim objDataset1 As New DataSet
                objAdapter1.Fill(objDataset1)
                '--objAdapter1.Update(objDataset1) '--updating
                dgv.DataSource = objDataset1.Tables(0).DefaultView

                objConn.Close()
            Finally


            End Try


        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDepartment.Click
        Dim dv As DataView
        dv = New DataView(ds.Tables(0), "type = 'business' ", "type Desc", DataViewRowState.CurrentRows)
        dgv.DataSource = dv
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet._zsgr0042_9417450_1' table. You can move, or remove it, as needed.
        Me.Zsgr0042_9417450_1TableAdapter.Fill(Me.Database1DataSet._zsgr0042_9417450_1)

    End Sub



    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Dim dv As New DataView(ds)
        'dv.RowFilter = String.Format("Course Like '%{0}%", txtSearch.Text)
        'dgv.DataSource = dv
    End Sub
End Class
