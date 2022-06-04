Imports MySql.Data.MySqlClient


Public Class loginform


    Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
    Dim cmd As New MySqlCommand


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password.PasswordChar = "*"
    End Sub
    Public name As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login.Click

        If con.State = ConnectionState.Closed Then

            con.Open()

        End If

        Dim logincmd As New MySqlCommand("select username,password from system where username=@username and password=@password", con)


        logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text
        logincmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text


        Dim adapter As New MySqlDataAdapter(logincmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        If username.Text = Nothing Or password.Text = Nothing Then
            MsgBox("Input your username and password", MsgBoxStyle.Critical, "Error")

        Else
            If table.Rows.Count > 0 Then
                MsgBox("Login Successful!" & vbNewLine & "Login User: " & username.Text, MsgBoxStyle.Information)

                Dim dr As MySqlDataReader
                cmd = New MySqlCommand("Select username,type,verification_code from system where username = '" & username.Text & "'", con)
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim user = dr.GetString("username")
                    name = user
                    Settings.username.Text = user
                    Dim Type1 = dr.GetString("type")
                    Main.atype.Text = Type1
                    Main.wtype.Text = Type1
                    Settings.type.Text = Type1
                    Dim vcode = dr.GetString("verification_code")
                    Settings.vercode.Text = vcode
                    Dashboard.mainname.Text = user


                    If Main.wtype.Text = "Admin" Then

                        Dashboard.payrollsummary.Visible = True
                        Dashboard.employeesummary.Visible = True
                    ElseIf Main.wtype.Text = "Assistant Admin" Then

                        Dashboard.payrollsummary.Visible = True
                        Dashboard.employeesummary.Visible = True
                    ElseIf Main.wtype.Text = "HR" Then

                        Dashboard.payrollsummary.Visible = False
                        Dashboard.employeesummary.Visible = True
                    ElseIf Main.wtype.Text = "Accountant" Then

                        Dashboard.payrollsummary.Visible = True
                        Dashboard.employeesummary.Visible = False
                    End If


                End While

               

                Me.Hide()
                Main.Show()
                adapter.Dispose()
                dr.Close()
                con.Close()

            Else
                MsgBox("Incorrect username or password!", MsgBoxStyle.Information, "Error")

            End If
            con.Close()
        End If
        con.Close()
    End Sub

    Private Sub register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerb.Click



        Me.Hide()
        registercode.Show()



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        con.Open()
        Try
            Dim logincmd As New MySqlCommand("select username from system where username=@username", con)

            logincmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.Text


            Dim adapter As New MySqlDataAdapter(logincmd)
            Dim table As New DataTable()
            adapter.Fill(table)


            If username.Text = Nothing Then
                MsgBox("Input your username you want to recover.", MsgBoxStyle.Information, "Error")
            ElseIf table.Rows.Count > 0 Then
                forgotpassword.username.Text = username.Text

                Me.Hide()
                forgotpassword.Show()
                adapter.Dispose()
                con.Close()
            Else
                MsgBox("Can't find username in the database!", MsgBoxStyle.Exclamation, "Error")
            End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()



    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            password.PasswordChar = "*"
        Else
            password.PasswordChar = ""
        End If
    End Sub

    Private Sub username_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        Settings.blockspchar(e)
    End Sub

    Private Sub password_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        Settings.blockspchar(e)
    End Sub
End Class