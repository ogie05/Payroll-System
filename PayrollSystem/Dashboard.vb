Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


       

        Dim dt As DateTime = DateTime.Now

        If dt.Hour < 12 Then
            Label1.Text = "Good Morning,"
            Label15.Text = "Start a day with a minimal work."
        ElseIf dt.Hour < 18 Then
            Label1.Text = "Good Afternoon, "
            Label15.Text = "Here what's going on in the software."
        Else
            Label1.Text = "Good Evening, "
            Label15.Text = "Give yourself a little time to rest."
        End If

        mainname.Text = loginform.name

        

        'command to show the Number of Employee data in dashboard
        Dim dr As MySqlDataReader
        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("select count(EmployeeCode) from employee where WorkStatus='" & "Active" & "'", con)
            dr = cmd.ExecuteReader
            dr.Read()
            Dim empcount = dr.GetString("count(EmployeeCode)")
            Label3.Text = empcount + " Active employees"
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()

        End Try

        'command that will show the total grosspay of employee in the database
        Try
        Dim dr1 As MySqlDataReader
            Dim cmd1 As New MySqlCommand
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()

        cmd1 = New MySqlCommand("select sum(netpay) from payslip", con)
        dr1 = cmd1.ExecuteReader
        dr1.Read()
            Dim netsum = dr1.GetString("sum(netpay)")
            totalgpdash.Text = "₱ " + netsum
            con.Close()
            dr1.Close()
        Catch ex As Exception
            MsgBox("No Grosspay Record Detected")
            con.Close()
        End Try

        'command that will compute the total taxes
        Try

            Dim dr2 As MySqlDataReader
            Dim cmd2 As New MySqlCommand
            con.Open()

            cmd2 = New MySqlCommand("select sum(tax_d) from salary", con)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            Dim taxsum = dr2.GetString("sum(tax_d)")
            totaltaxdash.Text = "₱ " + taxsum
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
            totaldeducdash.Text = "₱ " + totaldsum
            con.Close()
            dr3.Close()
        Catch ex As Exception
            MsgBox("No Total Deduction Has been detected")
            con.Close()
        End Try

        'command that will compute the total resigned employee
        Try

            Dim dr4 As MySqlDataReader
            Dim cmd4 As New MySqlCommand
            con.Open()

            cmd4 = New MySqlCommand("select count(EmployeeCode) from employee where WorkStatus= '" & "Resigned" & "' ", con)
            dr4 = cmd4.ExecuteReader
            dr4.Read()
            Dim totalres = dr4.GetString("count(EmployeeCode)")
            a1.Text = totalres + " Employees"
            con.Close()
            dr4.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try

        'command that will compute all total employee
        Try

            Dim dr5 As MySqlDataReader
            Dim cmd5 As New MySqlCommand
            con.Open()
            cmd5 = New MySqlCommand("select count(EmployeeCode) from employee", con)
            dr5 = cmd5.ExecuteReader
            dr5.Read()
            Dim totalemp = dr5.GetString("count(EmployeeCode)")
            Label25.Text = totalemp + " Employees"
            con.Close()
            dr5.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Switchpanel(report)
        Main.Button5.BackColor = Color.Firebrick
        Main.Button7.BackColor = Color.FromArgb(26, 27, 34)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Switchpanel(View)
        Main.Button3.BackColor = Color.Firebrick
        Main.Button7.BackColor = Color.FromArgb(26, 27, 34)
    End Sub

    Sub Switchpanel(ByVal panel As Form)
        Main.Mainpanel.Controls.Clear()
        panel.TopLevel = False
        Main.Mainpanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Main.wtype.Text = "HR" Then
            MsgBox("Hr cant Compute Payroll")
        ElseIf Main.wtype.Text = "Assistant Admin" Then
            MsgBox("Assistant Admin cant Compute Payroll")
        Else
            Switchpanel(salary)
            Main.Button1.BackColor = Color.Firebrick
            Main.Button7.BackColor = Color.FromArgb(26, 27, 34)
        End If
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles payrollsummary.Paint

    End Sub

    Private Sub activeempdash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class