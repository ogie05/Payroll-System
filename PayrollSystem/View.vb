
Imports MySql.Data.MySqlClient

Public Class View
    Dim da As New MySqlDataAdapter
    Dim con As New MySqlConnection
    Dim dtable As New DataTable
    Dim dataset As New DataSet
    Dim cmd As New MySqlCommand

    Private Sub View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Server=127.0.0.1;Username=root;Password=;database=system"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView2.Hide()
        DataGridView1.Show()

        refres()

    End Sub





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DataGridView2.Hide()
        DataGridView1.Show()

        con = New MySqlConnection
        con.ConnectionString = "Server=127.0.0.1;Username=root;Password=;database=system"
        con.Open()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim dadapter As New MySqlDataAdapter

        If RadioButton1.Checked Then
            dadapter = New MySqlDataAdapter("Select * from Employee where EmployeeCode like '%" & Search.Text & "%'", con)
            dadapter.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView

        ElseIf RadioButton2.Checked Then
            dadapter = New MySqlDataAdapter("Select * from Employee where FirstName like '%" & Search.Text & "%'", con)
            dadapter.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView

        ElseIf RadioButton3.Checked Then
            dadapter = New MySqlDataAdapter("Select * from Employee where LastName like '%" & Search.Text & "%'", con)
            dadapter.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView

        Else
            MsgBox("Select one of the filter [ID] [First Name] [Last Name] to search employee data.", MsgBoxStyle.Information, "Select")
            DataGridView1.DataSource = dt.DefaultView

        End If
        con.Close()
    End Sub

    Private Sub Search_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Search.TextChanged

    End Sub

    Public Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'DataGridView2.Hide()
        'DataGridView1.Show()

        'If (Search.Text = "") Then
        '    MsgBox("Select one of the search filter in order to delete data!", MsgBoxStyle.Information, "Error")
        'Else
        '    Dim ans As DialogResult
        '    ans = MsgBox("Are you sure do you want to delete this employee data? ", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        '    If ans = DialogResult.No Then

        '    ElseIf ans = DialogResult.Yes Then


        '        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        '        con.Open()
        '        cmd = New MySqlCommand("Delete from Employee where EmployeeCode=" & Search.Text & "", con)
        '        cmd.ExecuteNonQuery()
        '        MsgBox("Employee data has been deleted!", MsgBoxStyle.Information, "Deleted")

        '        Dim command As String
        '        Dim createhis As String
        '        createhis = "Employee Record Deleted with EmployeeCode =" + Search.Text

        '        Dim time1, date1 As String
        '        date1 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
        '        time1 = Date.Now.ToString("hh:mm tt")

        '        command = "insert into report (report_history,report_date,report_time) values ('" & createhis & "','" & date1 & "','" & time1 & "')"
        '        Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)
        '        cmd1.ExecuteNonQuery()

        '        con.Close()
        '        Call refres()
        '    End If
        'End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update12.Click, update123.Click, update12.Click
        updateemployee.Show()
        refres()



    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Upanel.Paint

    End Sub
    Sub refres()
        dataset.Clear()
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        cmd = New MySqlCommand("Select EmployeeCode,LastName,FirstName,MiddleName,DateOfBirth,Age,Gender,MaritalStatus,NoOfChildren,Address,ContactNumber,TelNumber,Designation,DateHired,WorkStatus,RestDay,SSS_ID,Tin_ID,Philhealth_ID,Pagibig_ID from Employee", con)
        da.SelectCommand = cmd
        da.Fill(dataset, "Employee")
        DataGridView1.DataSource = dataset
        DataGridView1.DataMember = "Employee"
        con.Close()
    End Sub
    Sub switchPanel(ByVal panel As Form)
        Upanel.Controls.Clear()
        panel.TopLevel = False
        Upanel.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        'account limitation
        If Main.wtype.Text = "Admin" Then
            Settings.clear.Visible = True
            Settings.vcode.Enabled = True
            Settings.clear.Enabled = True

            update123.Enabled = True
        ElseIf Main.wtype.Text = "Assistant Admin" Then
            Settings.clear.Visible = True
            Settings.vercode.Text = "None"
            Settings.vcode.Enabled = False
            Settings.clear.Enabled = True

            update123.Enabled = True
        ElseIf Main.wtype.Text = "HR" Then
            Settings.clear.Visible = False
            Settings.vercode.Text = "None"
            Settings.vcode.Enabled = False
            Settings.clear.Enabled = False

            update123.Enabled = False
        ElseIf Main.wtype.Text = "Accountant" Then
            Settings.clear.Visible = False
            Settings.vercode.Text = "None"
            Settings.vcode.Enabled = False
            Settings.clear.Enabled = False

            update123.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Sub salaryshow()
        DataGridView1.Hide()
        DataGridView2.Show()

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand

        dtable.Clear()

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()

        cmd = New MySqlCommand("Select * from Salary natural join employee", con)
        da.SelectCommand = cmd

        da.Fill(dtable)
        da.Update(dtable)

        If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
            DataGridView2.AutoGenerateColumns = False
            DataGridView2.DataSource = dtable
            DataGridView2.Columns(0).DataPropertyName = "EmployeeCode"
            DataGridView2.Columns(1).DataPropertyName = "LastName"
            DataGridView2.Columns(2).DataPropertyName = "FirstName"
            DataGridView2.Columns(3).DataPropertyName = "MiddleName"
            DataGridView2.Columns(4).DataPropertyName = "Designation"
            DataGridView2.Columns(5).DataPropertyName = "WorkStatus"
            DataGridView2.Columns(6).DataPropertyName = "salary_code"
            DataGridView2.Columns(7).DataPropertyName = "days_work"
            DataGridView2.Columns(8).DataPropertyName = "RegularRate"
            DataGridView2.Columns(9).DataPropertyName = "OtRate"
            DataGridView2.Columns(10).DataPropertyName = "HolRate"
            DataGridView2.Columns(11).DataPropertyName = "sss_d"
            DataGridView2.Columns(12).DataPropertyName = "philheatlh_d"
            DataGridView2.Columns(13).DataPropertyName = "pagibig_d"
            DataGridView2.Columns(14).DataPropertyName = "tax_d"
            DataGridView2.Columns(15).DataPropertyName = "cashadvance_d"


        End If
        con.Close()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        salaryshow()

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class