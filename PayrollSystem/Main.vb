Imports MySql.Data.MySqlClient
Public Class Main
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        switchPanel(Dashboard)
        Button7.BackColor = Color.Firebrick

        'account limitation
        If wtype.Text = "Admin" Then
            Settings.clear.Visible = True
            Settings.vcode1.Enabled = True
            Settings.clear.Enabled = True
            Settings.retrieve.Enabled = True
            View.update123.Enabled = True
            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "Assistant Admin" Then
            Settings.clear.Visible = True
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = True
            Settings.clear.Enabled = True
            Settings.retrieve.Enabled = True
            View.update123.Enabled = True
            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "HR" Then
            Settings.clear.Visible = False
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = False
            Settings.clear.Enabled = False
            Settings.retrieve.Enabled = False
            View.update123.Enabled = False
            Dashboard.payrollsummary.Visible = False
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "Accountant" Then
            Settings.clear.Visible = False
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = False
            Settings.clear.Enabled = False
            Settings.retrieve.Enabled = False
            View.update123.Enabled = False
            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = False
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim time, date1 As String
        date1 = Date.Now.ToString("MMM-dd-yyyy")
        Datetoday.Text = date1

        time = Date.Now.ToString("hh:mm:ss tt")
        timetoday.Text = time

    End Sub

  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If wtype.Text = "Accountant" Then
            MsgBox("Accountant cant create NEW EMPLOYEE DATA")
        ElseIf wtype.Text = "Assistant Admin" Then
            MsgBox("Assistant Admin cant create NEW EMPLOYEE DATA")
        Else
            switchPanel(Form2)
            Button2.BackColor = Color.Firebrick
            Button9.BackColor = Color.FromArgb(26, 27, 34)
            Button4.BackColor = Color.FromArgb(26, 27, 34)
            Button1.BackColor = Color.FromArgb(26, 27, 34)
            Button3.BackColor = Color.FromArgb(26, 27, 34)
            Button5.BackColor = Color.FromArgb(26, 27, 34)
            Button8.BackColor = Color.FromArgb(26, 27, 34)
            Button7.BackColor = Color.FromArgb(26, 27, 34)
        End If
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Mainpanel.Controls.Clear()
        panel.TopLevel = False
        Mainpanel.Controls.Add(panel)
        panel.Show()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If wtype.Text = "HR" Then
            MsgBox("Hr cant Compute Payroll")
        ElseIf wtype.Text = "Assistant Admin" Then
            MsgBox("Assistant Admin cant Compute Payroll")
        Else
            salarymanage.Show()

            Button1.BackColor = Color.Firebrick
            Button9.BackColor = Color.FromArgb(26, 27, 34)
            Button4.BackColor = Color.FromArgb(26, 27, 34)
            Button2.BackColor = Color.FromArgb(26, 27, 34)
            Button3.BackColor = Color.FromArgb(26, 27, 34)
            Button5.BackColor = Color.FromArgb(26, 27, 34)
            Button7.BackColor = Color.FromArgb(26, 27, 34)
            Button8.BackColor = Color.FromArgb(26, 27, 34)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        switchPanel(View)

        Button3.BackColor = Color.Firebrick
        Button9.BackColor = Color.FromArgb(26, 27, 34)
        Button4.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button5.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.FromArgb(26, 27, 34)
        Button8.BackColor = Color.FromArgb(26, 27, 34)
    End Sub



    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        switchPanel(Settings)
        'account limitation
        If wtype.Text = "Admin" Then
            Settings.clear.Visible = True
            Settings.vcode1.Enabled = True
            Settings.retrieve.Visible = True
            Settings.retrieve.Enabled = True
            Settings.clear.Enabled = True

            Settings.export.Enabled = True
            Settings.gbackup.Enabled = True
            Settings.abackup.Enabled = True
            Settings.arestore.Enabled = True
        ElseIf wtype.Text = "Assistant Admin" Then
            Settings.clear.Visible = True
            Settings.retrieve.Visible = True
            Settings.retrieve.Enabled = True
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = False
            Settings.clear.Enabled = True

            Settings.export.Enabled = True
            Settings.gbackup.Enabled = True
            Settings.abackup.Enabled = True
            Settings.arestore.Enabled = True
        ElseIf wtype.Text = "HR" Then
            Settings.clear.Visible = True
            Settings.retrieve.Visible = True
            Settings.retrieve.Enabled = False
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = False
            Settings.clear.Enabled = False
            Settings.retrieve.Enabled = False

            Settings.export.Enabled = False
            Settings.gbackup.Enabled = False
            Settings.abackup.Enabled = False
            Settings.arestore.Enabled = False
        ElseIf wtype.Text = "Accountant" Then
            Settings.clear.Visible = True
            Settings.retrieve.Visible = True
            Settings.retrieve.Enabled = False
            Settings.vercode.Text = "None"
            Settings.vcode1.Enabled = False
            Settings.clear.Enabled = False
            Settings.retrieve.Enabled = False
            Settings.export.Enabled = False
            Settings.gbackup.Enabled = False
            Settings.abackup.Enabled = False
            Settings.arestore.Enabled = False
        End If
        Button4.BackColor = Color.Firebrick
        Button9.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button3.BackColor = Color.FromArgb(26, 27, 34)
        Button5.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.FromArgb(26, 27, 34)

    End Sub

  

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        switchPanel(report)
        If wtype.Text = "Admin" Then
            report.clearhis.Enabled = True
        ElseIf wtype.Text = "Assistant Admin" Then
            report.clearhis.Enabled = True
        ElseIf wtype.Text = "HR" Then
            report.clearhis.Enabled = False
        ElseIf wtype.Text = "Accountant" Then
            report.clearhis.Enabled = False
        End If
        Button5.BackColor = Color.Firebrick
        Button9.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button3.BackColor = Color.FromArgb(26, 27, 34)
        Button4.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.FromArgb(26, 27, 34)
        Button8.BackColor = Color.FromArgb(26, 27, 34)
    End Sub

 
    Private Sub panelemployee_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelemployee.Paint
        If atype.Text = "Admin" Then
            madmin.Visible = True
            aamainp.Visible = False
            pmmainp.Visible = False
        ElseIf atype.Text = "Assistant Admin" Then
            madmin.Visible = False
            aamainp.Visible = True
            pmmainp.Visible = False

        ElseIf atype.Text = "HR" Then
            madmin.Visible = False
            aamainp.Visible = False
            pmmainp.Visible = True
        ElseIf atype.Text = "Accountant" Then
            madmin.Visible = False
            aamainp.Visible = False
            pmmainp.Visible = True

        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim dialog As DialogResult
        dialog = MsgBox("Are you sure you want to logout? ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Logout account?")
        If (dialog = DialogResult.Yes) Then

            Me.Hide()
            loginform.Show()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        switchPanel(Dashboard)
        If wtype.Text = "Admin" Then

            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "Assistant Admin" Then

            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "HR" Then

            Dashboard.payrollsummary.Visible = False
            Dashboard.employeesummary.Visible = True
        ElseIf wtype.Text = "Accountant" Then

            Dashboard.payrollsummary.Visible = True
            Dashboard.employeesummary.Visible = False
        End If

        Button8.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.Firebrick
        Button9.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button3.BackColor = Color.FromArgb(26, 27, 34)
        Button4.BackColor = Color.FromArgb(26, 27, 34)
        Button5.BackColor = Color.FromArgb(26, 27, 34)

        'this command will refresh and show the Number of Employee data in dashboard
        Dim dr As MySqlDataReader
        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("select count(EmployeeCode) from employee where WorkStatus='" & "Active" & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            Dim empcount = dr.GetString("count(EmployeeCode)")
            Dashboard.Label3.Text = empcount + " Active employees are currently working"
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try

        'command that will refresh every save and show the total grosspay of employee in the database
        Try
            Dim dr1 As MySqlDataReader
            Dim cmd1 As New MySqlCommand
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()

            cmd1 = New MySqlCommand("select sum(netpay) from payslip", con)
            dr1 = cmd1.ExecuteReader
            dr1.Read()
            Dim netsum = dr1.GetString("sum(netpay)")
            Dashboard.totalgpdash.Text = "₱ " + netsum
            con.Close()
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try



        'command that will refresh every save new employee and compute the total taxes
        Try
            Dim dr2 As MySqlDataReader
            Dim cmd2 As New MySqlCommand
            con.Open()

            cmd2 = New MySqlCommand("select sum(tax_d) from salary", con)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            Dim taxsum = dr2.GetString("sum(tax_d)")
            Dashboard.totaltaxdash.Text = "₱ " + taxsum
            con.Close()
            dr2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try



        'command that will compute the total deduction
        Try

            Dim dr3 As MySqlDataReader
            Dim cmd3 As New MySqlCommand
            con.Open()

            cmd3 = New MySqlCommand("select sum(total_deduction) from payslip", con)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            Dim totaldsum = dr3.GetString("sum(total_deduction)")
            Dashboard.totaldeducdash.Text = "₱ " + totaldsum
            con.Close()
            dr3.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try


        'command that will refresh and compute the total resigned employee
        Try

            Dim dr4 As MySqlDataReader
            Dim cmd4 As New MySqlCommand
            con.Open()

            cmd4 = New MySqlCommand("select count(EmployeeCode) from employee where WorkStatus= '" & "Resigned" & "' ", con)
            dr4 = cmd4.ExecuteReader
            dr4.Read()
            Dim totalres = dr4.GetString("count(EmployeeCode)")
            Dashboard.a1.Text = totalres + " Employees"
            con.Close()
            dr4.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try


        'command that will refresh and compute all total employee
        Try

            Dim dr5 As MySqlDataReader
            Dim cmd5 As New MySqlCommand
            con.Open()
            cmd5 = New MySqlCommand("select count(EmployeeCode) from employee", con)
            dr5 = cmd5.ExecuteReader
            dr5.Read()
            Dim totalemp = dr5.GetString("count(EmployeeCode)")
            Dashboard.Label25.Text = totalemp + " Employees"
            con.Close()
            dr5.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try
     
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Help.Show()
        Button8.BackColor = Color.Firebrick
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button3.BackColor = Color.FromArgb(26, 27, 34)
        Button4.BackColor = Color.FromArgb(26, 27, 34)
        Button5.BackColor = Color.FromArgb(26, 27, 34)
        Button6.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.FromArgb(26, 27, 34)
        Button9.BackColor = Color.FromArgb(26, 27, 34)



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        switchPanel(graph)
        Button9.BackColor = Color.Firebrick
        Button1.BackColor = Color.FromArgb(26, 27, 34)
        Button2.BackColor = Color.FromArgb(26, 27, 34)
        Button3.BackColor = Color.FromArgb(26, 27, 34)
        Button4.BackColor = Color.FromArgb(26, 27, 34)
        Button5.BackColor = Color.FromArgb(26, 27, 34)
        Button6.BackColor = Color.FromArgb(26, 27, 34)
        Button7.BackColor = Color.FromArgb(26, 27, 34)
        Button8.BackColor = Color.FromArgb(26, 27, 34)






        'this command will clear the point in chart series
        graph.Chart1.Series("Grosspay").Points.Clear()

        ' this command will refresh your database graph
        Dim dr As MySqlDataReader

        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("SELECT MAX(netpay),month from payslip GROUP BY month", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                graph.Chart1.Series("Grosspay").Points.AddXY(dr.GetString("month"), dr.GetInt32("MAX(netpay)"))
            End While
            con.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try


        'this command will clear the point in chart series
        graph.Chart2.Series("Top 10 Employee").Points.Clear()
        'this command will refresh the top 10 employee grosspay
        Dim dr1 As MySqlDataReader
        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("select CONCAT(LastName,' ',FirstName,' ',MiddleName) as Fullname, netpay FROM payslip NATURAL JOIN employee ORDER by netpay DESC LIMIT 10", con)
            dr1 = cmd.ExecuteReader
            While dr1.Read()
                graph.Chart2.Series("Top 10 Employee").Points.AddXY(dr1.GetString("Fullname"), dr1.GetInt32("netpay"))
            End While
            con.Close()
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try

        'this command will clear the point in chart series
        graph.Chart3.Series("EmployeeStatus").Points.Clear()
        'this command will refresh your company employee status
        Dim dr2 As MySqlDataReader
        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("SELECT COUNT(EmployeeCode),WorkStatus from employee GROUP BY WorkStatus", con)
            dr2 = cmd.ExecuteReader
            While dr2.Read()
                graph.Chart3.Series("EmployeeStatus").Points.AddXY(dr2.GetString("WorkStatus"), dr2.GetInt32("count(EmployeeCode)"))
            End While
            con.Close()
            dr2.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try

        con.Close()


    End Sub

    Private Sub Mainpanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Mainpanel.Paint

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
