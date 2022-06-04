Imports System.Data.OleDb
Public Class grid
    Dim da As New OleDbDataAdapter
    Dim con As New OleDbConnection
    Dim dtable As New DataTable
    Dim dataset As New DataSet
    Dim cmd As New OleDb.OleDbCommand
    Sub refres()
        dataset.Clear()
        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Sanchez\Documents\Visual Studio 2010\Projects\PayrollSystem\PayrollSystem\Employee.accdb")
        con.Open()
        cmd = New OleDb.OleDbCommand("Select * from Employee", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "Employee")
        DataGridView1.DataSource = dataset
        DataGridView1.DataMember = "Employee"
        con.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class