Imports MySql.Data.MySqlClient
Public Class createNewUserPassword
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        forgotpassword.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")

        Dim command As String
        If password1.Text = password2.Text Then


            con.Open()


            command = "update system set password ='" & password2.Text & "' where username ='" & username.Text & "' "
            Dim cmd As MySqlCommand = New MySqlCommand(command, con)
            cmd.Parameters.Add(New MySqlParameter("password", CType(password2.Text, String)))
            MsgBox("Your password has been updated! You may close this window now.", MsgBoxStyle.Information, "Update Successful")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                password1.Clear()
                password2.Clear()

                con.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            con.Close()
        Else
            MsgBox("Your password didn't match! Try again.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub showpass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked = True Then
            password1.PasswordChar = ""
            password2.PasswordChar = ""
        Else
            password1.PasswordChar = "*"
            password2.PasswordChar = "*"
        End If
    End Sub

    Private Sub password1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password1.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class