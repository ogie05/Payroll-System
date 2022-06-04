Imports MySql.Data.MySqlClient
Public Class register
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As MySqlConnection = New MySqlConnection
    Public fnameR As String
    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        vcode.Visible = False
    End Sub

    Private Sub login1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login1.Click
        Me.Hide()
        loginform.Show()

    End Sub

    Private Sub register1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles register1.Click
        If ruser.Text = Nothing Or rpass.Text = Nothing Or ruser.Text = "Username" Or rpass.Text = "Password" Then
            MsgBox("Please Input Credential")
        Else
            pro = "Server=127.0.0.1;Username=root;Password=;database=system"
            connstring = pro
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = "insert into system (username,password,type,code,verification_code) values ('" & ruser.Text & "','" & rpass.Text & "','" & rtype.Text & "','" & rcode.Text & "','" & vcode.Text & "')"
            Dim cmd As MySqlCommand = New MySqlCommand(command, myconnection)
            cmd.Parameters.Add(New MySqlParameter("username", CType(ruser.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("password", CType(rpass.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("type", CType(rtype.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("code", CType(rcode.Text, String)))
            cmd.Parameters.Add(New MySqlParameter("verification_code", CType(vcode.Text, String)))

            'change employee system registered to yes
            Dim command1 As String
            command1 = "update employee set system_user='Yes' where FirstName='" & fnameR & "'"
            Dim cmd1 As MySqlCommand = New MySqlCommand(command1, myconnection)
            cmd1.ExecuteNonQuery()
            cmd1.Dispose()

            MsgBox("Account Save")

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
                ruser.Clear()
                rpass.Clear()
                rcode.Clear()
                vcode.Clear()



            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub rtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtype.SelectedIndexChanged
        If rtype.Text = "Admin" Then
            vcode.ReadOnly = False
            vcode.Visible = True
        Else
            vcode.ReadOnly = True
            vcode.Text = "0"
            vcode.Visible = False
        End If
    End Sub

    Private Sub rpass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rpass.KeyPress
        Settings.blockspchar(e)
    End Sub

    Private Sub rcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rcode.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub vcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles vcode.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class