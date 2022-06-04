Imports MySql.Data.MySqlClient
Public Class monthoption
    Private con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cutoffcombo.Text = "" Or monthcombo.Text = "" Then
            MsgBox("Please Select option!", MsgBoxStyle.Exclamation)
        Else

            Me.Hide()
            Dim cmd As MySqlCommand
            Dim adp As New MySqlDataAdapter
            Dim dt As New DataSet
            Dim sql As String
            Dim month, cutoff As String
            month = monthcombo.Text
            cutoff = cutoffcombo.Text



            sql = "SELECT * FROM payslip natural join salary natural join employee WHERE month ='" & month & "' and cutoff='" & cutoff & "' ORDER BY payslip_code"
            Try
                con.Open()
                cmd = New MySqlCommand(sql, con)

                cmd.Parameters.Add("@month", MySqlDbType.VarChar).Value = month
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()

                adapter.Fill(table)
                If table.Rows.Count > 0 Then

                    MsgBox("This is the PaySliprecord you selected")
                    adp.SelectCommand = cmd
                    adp.Fill(dt, "employee")
                    adp.Fill(dt, "salary")
                    adp.Fill(dt, "payslip")
                    Dim report As New CrystalReport1
                    report.SetDataSource(dt)
                    printtab.CrystalReportViewer1.ReportSource = report
                    printtab.CrystalReportViewer1.Refresh()
                    cmd.Dispose()
                    adp.Dispose()
                    adapter.Dispose()
                    table.Dispose()
                    dt.Dispose()
                    con.Close()
                Else
                    MsgBox("Sorry! You dont have any payslip saved record for that day")
                    con.Close()
                End If
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                con.Close()
            End Try
            con.Close()
        End If
    End Sub
End Class