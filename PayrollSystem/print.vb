Imports MySql.Data.MySqlClient
Public Class printtab
    Private con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")


    Public Sub all()
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "Select * from payslip natural join salary natural join employee order by payslip_code"
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd
            adp.Fill(dt, "employee")
            adp.Fill(dt, "salary")
            adp.Fill(dt, "payslip")
            Dim report As New CrystalReport1
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
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
    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        con.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showcurrentp.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        Dim current As String
        current = salary.pcode
        If current = Nothing Then
            MsgBox("Please Click Save Payslip First")
        Else
            MsgBox("This Is the Current Save Payslip")
            sql = "Select * from employee natural join salary natural join payslip where payslip_code =('" & current & "')"
            Try
                con.Open()
                cmd = New MySqlCommand(sql, con)
                adp.SelectCommand = cmd
                adp.Fill(dt, "employee")
                adp.Fill(dt, "salary")
                adp.Fill(dt, "payslip")
                Dim report As New CrystalReport1
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                dt.Dispose()
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                con.Close()
            End Try
        End If
        con.Close()
    End Sub

    Private Sub printtab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolTip1.SetToolTip(showcurrentp, "This button will view your current save payslip.")
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String
        Dim datenow As String

        datenow = Date.Now.ToString("dddd-MMMM-dd-yyyy")


        sql = "Select * from employee natural join salary natural join payslip where date_save =('" & datenow & "')"
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)

            cmd.Parameters.Add("@date_save", MySqlDbType.VarChar).Value = datenow
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)
            If table.Rows.Count > 0 Then

                MsgBox("This is the PaySliprecord for Today")
                adp.SelectCommand = cmd
                adp.Fill(dt, "employee")
                adp.Fill(dt, "salary")
                adp.Fill(dt, "payslip")
                Dim report As New CrystalReport1
                report.SetDataSource(dt)
                CrystalReportViewer1.ReportSource = report
                CrystalReportViewer1.Refresh()
                cmd.Dispose()
                adp.Dispose()
                adapter.Dispose()
                table.Dispose()
                dt.Dispose()
                con.Close()
            Else
                MsgBox("Sorry! You dont have any payslip saved record for today")
                con.Close()
            End If
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        printmasterlist.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        monthoption.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        monthrange.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
         Dim cmd As MySqlCommand
        Dim adp As New MySqlDataAdapter
        Dim dt As New DataSet
        Dim sql As String

        sql = "Select * from record"
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            adp.SelectCommand = cmd

            adp.Fill(dt, "record")

            Dim report As New CrystalReport3
            report.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = report
            CrystalReportViewer1.Refresh()
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