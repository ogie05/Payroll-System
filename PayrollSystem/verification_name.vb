Imports MySql.Data.MySqlClient
Public Class verification_name
    Dim con As New MySqlConnection
    Public fname As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'this command will check if the input user is really register in system database
        Dim con As New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
        con.Open()
        Try
            Dim logincmd As New MySqlCommand("select FirstName,LastName,system_user from employee where FirstName=@FirstName and LastName=@LastName", con)

           

            logincmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = FirstName.Text.ToUpper()
            logincmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = LastName.Text.ToUpper()
            Dim suggestname As String



            Dim adapter As New MySqlDataAdapter(logincmd)
            Dim table As New DataTable()
            adapter.Fill(table)


            If FirstName.Text = Nothing Then
                MsgBox("Input your FullName", MsgBoxStyle.Information, "Error")
            ElseIf table.Rows.Count > 0 Then
                'this command will check if the employee is already system user
                Dim dasystem As MySqlDataReader
                dasystem = logincmd.ExecuteReader
                dasystem.Read()
                Dim systemcheck As String
                systemcheck = dasystem.GetString("system_user")

                If (systemcheck = "Yes") Then
                    MsgBox("This user is already registered!", MsgBoxStyle.Exclamation)
                ElseIf (systemcheck = "No") Then
                    dasystem.Close()

                    'change system_user to registered
                    Dim yes As String
                    yes = "Yes"
                    Dim changesystem_user As MySqlDataReader
                    changesystem_user = logincmd.ExecuteReader
                    changesystem_user.Read()
                    fname = changesystem_user.GetString("FirstName")
                    register.fnameR = fname
                    changesystem_user.Close()
                   


                    'command to get automated username
                    Dim cmd As New MySqlCommand("select concat(left(FirstName,3),LEFT(LastName,3),EmployeeCode) as fullname from employee where FirstName='" & FirstName.Text & "' ", con)
                    Dim da As MySqlDataReader
                    da = cmd.ExecuteReader
                    da.Read()
                    suggestname = da.GetString("fullname")
                    register.ruser.Text = suggestname
                    MsgBox("Fullname Verified!", MsgBoxStyle.Information, "Success")
                    Me.Hide()


                    register.Show()
                    da.Close()
                    cmd.Dispose()
                    adapter.Dispose()
                    con.Close()
                    ''
                End If
                Else
                    MsgBox("Can't find name in the database!", MsgBoxStyle.Exclamation, "Error")
                End If



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        registercode.Show()

    End Sub

    Private Sub verification_name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FirstName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FirstName.KeyPress
        Settings.blocknum(e)
    End Sub

    Private Sub LastName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LastName.KeyPress
        Settings.blocknum(e)
    End Sub
End Class