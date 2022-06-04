
Imports MySql.Data.MySqlClient

Public Class printmasterlist
    Private con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")


    Private Sub printmasterlist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "Select * from employee"
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "employee")
            Dim report As New CrystalReport2
            report.SetDataSource(dt)
            CrystalReportViewer2.ReportSource = report
            CrystalReportViewer2.Refresh()
            cmd.Dispose()
            adp.Dispose()
            dt.Dispose()
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            con.Close()
        End Try
        con.Close()
    End Sub

End Class