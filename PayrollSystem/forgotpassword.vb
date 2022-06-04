Imports MySql.Data.MySqlClient

Public Class forgotpassword
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        Dim cmd As New MySqlCommand
        con.Open()

        Try
        Dim dr As MySqlDataReader
        cmd = New MySqlCommand("Select username,code from system where username = '" & username.Text & "'", con)
        dr = cmd.ExecuteReader

        While dr.Read
                Dim user = dr.GetString("username")
                Dim code = dr.GetString("code")
                MsgBox(code)
                If user.ToUpper() = username.Text.ToUpper() And code = rcode.Text Then
                    MsgBox("Code is matched into your username!", MsgBoxStyle.Information, "Successful")
                    createNewUserPassword.username.Text = user
                    Me.Hide()
                    createNewUserPassword.Show()

                Else
                    MsgBox("Incorrect Recovery code!", MsgBoxStyle.Critical, "Error")
                End If

        End While
            dr.Close()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        loginform.Show()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class