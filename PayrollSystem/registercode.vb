Imports MySql.Data.MySqlClient
Public Class registercode
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub registercode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        loginform.Show()

    End Sub
    Dim code1, code2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If code.Text = "" Then
            MsgBox("Please Input Verification Code", MsgBoxStyle.Information)
        Else

            Dim dr As MySqlDataReader
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("select verification_code from system where type = 'Admin'", con)

            dr = cmd.ExecuteReader
            While dr.Read()

                code1 = dr.GetString("verification_code")
                If code.Text = code1 Then
                    code2 = code.Text
                End If

            End While
            If code.Text = code2 Then
                MsgBox("Code Verified!", MsgBoxStyle.Information, "Successful")
                Me.Hide()
                verification_name.Show()

            Else
                MsgBox("Invalid code!", MsgBoxStyle.Critical, "Error")
            End If
            con.Close()
        End If
    End Sub


    Private Sub code_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles code.KeyPress
        Settings.blockletter(e)
    End Sub
End Class