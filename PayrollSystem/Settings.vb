Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Settings
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vcode1.Click
        Dim admin As String
        admin = "admin"

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        Dim ans As DialogResult
        ans = MsgBox("Are you sure to update verification code?", MsgBoxStyle.YesNo)

        If ans = DialogResult.Yes Then
            con.Open()

            Try
                cmd = New MySqlCommand("Update system set verification_code ='" & vcode.Text & "'  where id = 1", con)
                MsgBox("VERIFICATION CODE UPDATED")
                vercode.Text = vcode.Text
                vcode.Clear()
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If type.Text = "Admin" Then
            adminpic.Visible = True
            assistadminpic.Visible = False
            payrollmasterpic.Visible = False
        ElseIf type.Text = "Assistant Admin" Then
            adminpic.Visible = False
            assistadminpic.Visible = True
            payrollmasterpic.Visible = False

        ElseIf type.Text = "HR" Then
            adminpic.Visible = False
            assistadminpic.Visible = False
            payrollmasterpic.Visible = True
        ElseIf type.Text = "Accountant" Then
            adminpic.Visible = False
            assistadminpic.Visible = False
            payrollmasterpic.Visible = True

        End If



    End Sub

    Public Sub blockspchar(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'command to block special character
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled = True Then
            MsgBox("Special Character not allowed", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub blocknum(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'command to block number
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsLetter(e.KeyChar)
        If e.Handled = True Then
            MsgBox("Special Character and Number is not allowed", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Public Sub blockletter(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'command to char number
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsSeparator(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled = True Then
            MsgBox("Special Character and Letter is not allowed", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.WindowState = FormWindowState.Maximized




    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.panelemployee.BackColor = Color.AntiqueWhite



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim customColor As Color = Color.FromArgb(30, 37, 47)

        Main.panelemployee.BackColor = customColor


    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint
        Me.ToolTip1.SetToolTip(vcode1, "Update Verification Code?")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Process.Start("https://www.facebook.com/ogiesanchez/")
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        createNewUserPassword.Show()
        createNewUserPassword.username.Text = username.Text
    End Sub

    Private Sub Button2_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        'command use to clear log history

        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        Dim ans As DialogResult
        ans = MsgBox("Are you sure you want to clear log history? This cannot be undone. ", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If ans = DialogResult.Yes Then
            con.Open()
            Try

                cmd = New MySqlCommand("SET FOREIGN_KEY_CHECKS = 0; TRUNCATE table report_backup; SET FOREIGN_KEY_CHECKS = 1;INSERT into report_backup SELECT * FROM report;SET FOREIGN_KEY_CHECKS = 0; TRUNCATE table report; SET FOREIGN_KEY_CHECKS = 1", con)
                cmd.ExecuteNonQuery()
                MsgBox("Log History Successfully Cleared!")
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                con.Close()
            End Try
        End If

        con.Close()
    End Sub

    Private Sub Button2_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles retrieve.Click
        'command to retrieve log history
        con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        Dim ans As DialogResult
        ans = MsgBox("Retrieve log history? ", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
        If ans = DialogResult.Yes Then
            con.Open()
            Try

                cmd = New MySqlCommand("INSERT into report SELECT * FROM report_backup", con)
                cmd.ExecuteNonQuery()
                MsgBox("Log History Successfully Retrieve!")
                cmd.Dispose()
                con.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
                con.Close()
            End Try
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbackup.Click
        'command go to Google Drive to save database
        System.Diagnostics.Process.Start("https://drive.google.com/drive/u/0/my-drive")
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles abackup.Click
        Timer1.Start()


    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
       

    End Sub

    Private Sub Button5_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export.Click
        OpenFileDialog1.InitialDirectory = "C:\xampp\mysql\database backup"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

        End If

    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        ProgressBar1.Increment(4)
        ProgressBar1.ForeColor = Color.Red
        If ProgressBar1.Value = 100 Then
            Process.Start("C:\xampp\mysql\bin\mysqldump.exe", " -u root system -r ""C:\xampp\mysql\database backup\backup.sql""")
            Timer1.Stop()
            MsgBox("Database Successfully Backup")
            ProgressBar1.Value = 0
        End If
    End Sub

    Public Sub restore()
        Dim myProcess As New Process()
        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        Dim mystreamreader As StreamReader = myProcess.StandardOutput
        myStreamWriter.WriteLine("mysql -u root system < C:\xampp\mysql\database backup\backup.sql")
        myStreamWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub

    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arestore.Click
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(4)
        ProgressBar1.ForeColor = Color.Red
        If ProgressBar1.Value = 100 Then
            restore()

            Timer2.Stop()
            MsgBox("Database Successfully Restore")
            ProgressBar1.Value = 0
        End If
    End Sub
End Class