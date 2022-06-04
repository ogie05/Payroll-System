Imports MySql.Data.MySqlClient

Public Class report
    Dim dataset As New DataSet
    Dim da As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Sub history()

        'code to show the log history

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand

        dtable.Clear()

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        Try
            cmd = New MySqlCommand("Select * from report order by report_code DESC", con)
            da.SelectCommand = cmd

            da.Fill(dtable)
            da.Update(dtable)

            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                DataGridView2.AutoGenerateColumns = False
                DataGridView2.DataSource = dtable
                DataGridView2.Columns(0).DataPropertyName = "report_code"
                DataGridView2.Columns(1).DataPropertyName = "report_history"
                DataGridView2.Columns(2).DataPropertyName = "report_date"
                DataGridView2.Columns(3).DataPropertyName = "report_time"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        history()
        Button2.BackColor = Color.Firebrick
        Button3.BackColor = Color.FromArgb(30, 37, 47)
        Button4.BackColor = Color.FromArgb(30, 37, 47)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        history()
        Label3.Text = "All"

        Button2.BackColor = Color.Firebrick
        Button3.BackColor = Color.FromArgb(30, 37, 47)
        Button4.BackColor = Color.FromArgb(30, 37, 47)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearhis.Click
        'command use to clear log history
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to clear log history? This cannot be undone. ", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If ans = DialogResult.Yes Then
            con.Open()
            Try

                cmd = New MySqlCommand("SET FOREIGN_KEY_CHECKS = 0; TRUNCATE table report_backup;SET FOREIGN_KEY_CHECKS = 1;INSERT into report_backup SELECT * FROM report;SET FOREIGN_KEY_CHECKS = 0; TRUNCATE table report; SET FOREIGN_KEY_CHECKS = 1", con)
                cmd.ExecuteNonQuery()
                MsgBox("Log History cleared!", MsgBoxStyle.Information, "Successful")
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                con.Close()
            End Try
        End If

        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Button3.BackColor = Color.Firebrick
        Button2.BackColor = Color.FromArgb(30, 37, 47)
        Button4.BackColor = Color.FromArgb(30, 37, 47)

        Label3.Text = "Today"
        'this command will show the log history for today only
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim datenow As String
        datenow = Date.Now.ToString("dddd-MMMM-dd-yyyy")
        dtable.Clear()

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        Try
            cmd = New MySqlCommand("Select * from report where report_date='" & datenow & "' order by report_code DESC", con)
            da.SelectCommand = cmd

            da.Fill(dtable)
            da.Update(dtable)

            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                DataGridView2.AutoGenerateColumns = False
                DataGridView2.DataSource = dtable
                DataGridView2.Columns(0).DataPropertyName = "report_code"
                DataGridView2.Columns(1).DataPropertyName = "report_history"
                DataGridView2.Columns(2).DataPropertyName = "report_date"
                DataGridView2.Columns(3).DataPropertyName = "report_time"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Button4.BackColor = Color.Firebrick
        Button3.BackColor = Color.FromArgb(30, 37, 47)
        Button2.BackColor = Color.FromArgb(30, 37, 47)

        Label3.Text = "Older"
        'this command will show all the older report

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim datenow As String
        datenow = Date.Now.ToString("dddd-MMMM-dd-yyyy")
        dtable.Clear()

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        Try
            cmd = New MySqlCommand("Select * from report where report_date<>'" & datenow & "' order by report_code DESC", con)
            da.SelectCommand = cmd

            da.Fill(dtable)
            da.Update(dtable)

            If Not dtable Is Nothing AndAlso dtable.Rows.Count > 0 Then
                DataGridView2.AutoGenerateColumns = False
                DataGridView2.DataSource = dtable
                DataGridView2.Columns(0).DataPropertyName = "report_code"
                DataGridView2.Columns(1).DataPropertyName = "report_history"
                DataGridView2.Columns(2).DataPropertyName = "report_date"
                DataGridView2.Columns(3).DataPropertyName = "report_time"

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class