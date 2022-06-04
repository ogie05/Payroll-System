Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Form2
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim sss, phil, pagibig, tax As Double
    Dim daysworkf, otf, regratef, holratef As Double
    Dim errorcount As Integer
    Dim empc As String




    Dim restday As String
    Dim gender As String
    Dim workstatus As String


    Dim myconnection As MySqlConnection = New MySqlConnection
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tab As Integer


        tab = 1
        sss = 280
        phil = 192.5
        pagibig = 60
        tax = sss + phil + pagibig

        sss_d.Text = sss
        phil_d.Text = phil
        pagibig_d.Text = pagibig
        tax_d.Text = tax

        'Formula to compute the total rate per hour
        Dim rateperhr As Double
        rateperhr = 67.125
        regratef = 537
        daysworkf = 13
        otf = Math.Round(rateperhr * 1.25 * 1, 2)
        holratef = rateperhr * 1.3 * 8

        cash_ad.Text = 0
        holrate.Text = holratef
        regrate.Text = regratef
        otrate.Text = otf
        presentday.Text = daysworkf

    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Maritalstatus.SelectedIndexChanged

        numchild.Enabled = True
        numchild.Text = "0"

    End Sub


    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If (Lastname.Text = "" Or Firstname.Text = "" Or Middlename.Text = "" Or Maritalstatus.Text = "" Or RadioButton1.Checked = False And RadioButton2.Checked = False Or Address.Text = "" Or Contactnum.Text = "" Or Telnum.Text = "" Or Designation.Text = "" Or Age.Text = "" Or numchild.Text = "") Then
            MsgBox("Please Fill up all neccesarry fields", MsgBoxStyle.Exclamation)
        Else
            Dim currenttab As Int16
            currenttab = TabControl1.SelectedIndex
            currenttab = currenttab + 1
            If (currenttab < TabControl1.TabCount) Then

                TabControl1.SelectedIndex = currenttab

            End If
        End If






    End Sub

    

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (sss_id.Text = "" Or tin_id.Text = "" Or pagibig_id.Text = "" Or phil_id.Text = "" And mon.Checked = False And tue.Checked = False And wed.Checked = False And thu.Checked = False And fri.Checked = False And sat.Checked = False And sun.Checked = False) Then
            MsgBox("Please Fillup neccessary fields", MsgBoxStyle.Exclamation)
        Else

            Dim ans As DialogResult
            ans = MsgBox("Do you want to save info?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)

            If ans = DialogResult.No Then

            ElseIf ans = DialogResult.Yes Then

                If PictureBox1.Image Is Nothing Then
                    MsgBox("Please Insert A Photo")
                Else


                    If (mon.Checked = False) And (tue.Checked = False) And (wed.Checked = False) And (thu.Checked = False) And (fri.Checked = False) And (sat.Checked = False) And (sun.Checked = False) Then
                        MessageBox.Show("Please Select Restday")

                    Else

                        gender = "Male"
                        pro = "Server=127.0.0.1;Username=root;Password=;database=system"
                        connstring = pro
                        myconnection.ConnectionString = connstring
                        myconnection.Open()
                        If (RadioButton1.Checked = True) Then
                            gender = "Male"
                        ElseIf (RadioButton2.Checked = True) Then
                            gender = "FeMale"
                        End If



                        workstatus = "Active"



                        If (mon.Checked = True) Then
                            restday = "Monday"
                        ElseIf (tue.Checked = True) Then
                            restday = "Tuesday"
                        ElseIf (wed.Checked = True) Then
                            restday = "Wednesday"
                        ElseIf (thu.Checked = True) Then
                            restday = "Thursday"
                        ElseIf (fri.Checked = True) Then
                            restday = "Friday"
                        ElseIf (sat.Checked = True) Then
                            restday = "Saturday"
                        ElseIf (sun.Checked = True) Then
                            restday = "Sunday"
                        End If

                        Dim system_user As String
                        system_user = "No"

                        command = "insert into employee (LastName,FirstName,MiddleName,DateOfBirth,Age,Gender,MaritalStatus,NoOfChildren,Address,ContactNumber,TelNumber,Designation,image,DateHired,WorkStatus,RestDay,SSS_ID,Tin_ID,Philhealth_ID,Pagibig_ID,system_user) values ('" & Lastname.Text.ToUpper() & "','" & Firstname.Text.ToUpper() & "','" & Middlename.Text.ToUpper() & "','" & Dateofbirth.Value.Date & "','" & Age.Text & "','" & gender & "','" & Maritalstatus.Text & "','" & numchild.Text & "','" & Address.Text & "','" & Contactnum.Text & "','" & Telnum.Text & "','" & Designation.Text & "',@image,'" & datehired.Value.Date & "','" & workstatus & "','" & restday & "','" & sss_id.Text & "','" & tin_id.Text & "','" & phil_id.Text & "','" & pagibig_id.Text & "','" & system_user & "')"
                        Dim cmd As MySqlCommand = New MySqlCommand(command, myconnection)







                        cmd.Parameters.Add(New MySqlParameter("Last Name", CType(Lastname.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("First Name", CType(Firstname.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Middle Name", CType(Middlename.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Date Of Birth", CType(Dateofbirth.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Age", CType(Age.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Gender", CType(gender, String)))
                        cmd.Parameters.Add(New MySqlParameter("MaritalStatus", CType(Maritalstatus.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Number Of Children", CType(numchild.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Address", CType(Address.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Contact Number", CType(Contactnum.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Telephone Number", CType(Telnum.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Designation", CType(Designation.Text, String)))




                        Dim ms As New MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        cmd.Parameters.AddWithValue("@image", ms.ToArray())

                        'MsgBox("Picture Saved.", MsgBoxStyle.Information, "Successful")



                        cmd.Parameters.Add(New MySqlParameter("DateHired", CType(datehired.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("WorkStatus", CType(workstatus, String)))
                        cmd.Parameters.Add(New MySqlParameter("RestDay", CType(restday, String)))
                        cmd.Parameters.Add(New MySqlParameter("SSS_ID", CType(sss_id.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Tin_ID", CType(tin_id.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Philhealth_ID", CType(phil_id.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("Pagibig_ID", CType(pagibig_id.Text, String)))
                        cmd.Parameters.Add(New MySqlParameter("system_user", CType(system_user, String)))

                        MsgBox("Employee info saved", MsgBoxStyle.Information, "Successful")
                        MsgBox("Now fillup the employee salary rate.", MsgBoxStyle.Information, "Next")


                        Dim createhis As String
                        createhis = "New Employee data added"

                        Dim time1, date1 As String
                        date1 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                        time1 = Date.Now.ToString("hh:mm tt")

                        command = "insert into report (report_history,report_date,report_time) values ('" & createhis & "','" & date1 & "','" & time1 & "')"
                        Dim cmd1 As MySqlCommand = New MySqlCommand(command, myconnection)
                        cmd1.ExecuteNonQuery()


                        Try
                            cmd.ExecuteNonQuery()
                            cmd.Dispose()
                            myconnection.Close()

                            


                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                        Dim currenttab As Int16

                        currenttab = TabControl1.SelectedIndex
                        currenttab = currenttab + 1
                        If (currenttab < TabControl1.TabCount) Then

                            TabControl1.SelectedIndex = currenttab

                        End If


                    End If

                End If
            End If
        End If
    End Sub
    Dim empcode
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans As DialogResult
        ans = MsgBox("Do you want to save info?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)

        If ans = DialogResult.No Then

        ElseIf ans = DialogResult.Yes Then

            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim command As String

            Dim dr1 As MySqlDataReader
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("SELECT EmployeeCode FROM employee ORDER BY EmployeeCode DESC LIMIT 1", con)

            dr1 = cmd.ExecuteReader
            dr1.Read()

            empcode = dr1.GetString("EmployeeCode")



            command = "insert into salary (days_work,EmployeeCode,RegularRate,OtRate,HolRate,sss_d,philheatlh_d,pagibig_d,tax_d,cashadvance_d) values ('" & presentday.Text & "','" & empcode & "','" & regrate.Text & "','" & otrate.Text & "','" & holrate.Text & "','" & sss_d.Text & "','" & phil_d.Text & "','" & pagibig_d.Text & "','" & tax_d.Text & "','" & cash_ad.Text & "')"
            Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)


            cmd1.Parameters.Add(New MySqlParameter("days_work", CType(presentday.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("EmployeeCode", CType(empcode, String)))
            dr1.Close()

            cmd1.Parameters.Add(New MySqlParameter("RegularRate", CType(regrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("OtRate", CType(otrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("HolRate", CType(holrate.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("sss_d", CType(sss_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("philheatlh_d", CType(phil_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("pagibig_d", CType(pagibig_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("tax_d", CType(tax_d.Text, String)))
            cmd1.Parameters.Add(New MySqlParameter("cashadvance_d", CType(cash_ad.Text, String)))

            
            MsgBox("Salary info saved!", MsgBoxStyle.Information, "Successful")

            'create record
            Dim computecmd As String
            Dim tsss, tphil, tpagibig, ttax, tvale, tnetpay As Integer
            tsss = 0
            tphil = 0
            tpagibig = 0
            ttax = 0
            tvale = 0
            tnetpay = 0

            computecmd = "insert into record (EmployeeCode,FirstName,LastName,total_sss,total_phil,total_pagibig,total_tax,total_vale,total_netpay) values ('" & empcode & "','" & Firstname.Text & "','" & Lastname.Text & "','" & tsss & "','" & tphil & "','" & tpagibig & "','" & ttax & "','" & tvale & "','" & tnetpay & "')"
            Dim com_cmd As New MySqlCommand(computecmd, con)
            com_cmd.ExecuteNonQuery()



            ' code to create a system user
            Dim ans1, ans2 As DialogResult
            ans1 = MsgBox("Do you want to create this account as system user?", MsgBoxStyle.YesNo)
            If ans1 = DialogResult.Yes Then
                ans2 = MsgBox("Are you sure? Do you wish to proceed", MsgBoxStyle.YesNo)
                If ans2 = DialogResult.Yes Then
                    If Firstname.Text = "" Or Lastname.Text = "" Or empcode = "" Then
                        MsgBox("Please fill up all the information")
                    Else
                        fname = Firstname.Text
                        lname = Lastname.Text
                        fulluser = fname.Substring(0, 3) + lname.Substring(0, 3) + empcode
                        register.ruser.Text = fulluser
                        register.login1.Visible = False
                        register.login1.Enabled = False
                    End If
                End If
            End If

            Try
                cmd1.ExecuteNonQuery()
                cmd1.Dispose()
                sss_id.Clear()
                tin_id.Clear()
                phil_id.Clear()
                pagibig_id.Clear()
                Lastname.Clear()
                Firstname.Clear()
                Middlename.Clear()
                Age.Clear()
                numchild.Clear()
                Address.Clear()
                Contactnum.Clear()
                Telnum.Clear()
                Designation.Clear()
                PictureBox1.Image = Nothing
                con.Close()

                Dim currenttab As Int16

                currenttab = TabControl1.SelectedIndex
                currenttab = currenttab - 2
                If (currenttab < TabControl1.TabCount) Then

                    TabControl1.SelectedIndex = currenttab
                    If ans2 = DialogResult.Yes Then
                            register.Show()
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            End If
    End Sub

   




    
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.JPG;*.PNG;*.JPEG;*.GIF)|*.JPG;*.PNG;*.JPEG;*.GIF"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If

        If PictureBox1.Image IsNot Nothing Then

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

    Private Sub Lastname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Lastname.KeyPress

        blocknum(e)
    End Sub
   


    Private Sub Firstname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Firstname.KeyPress

        blocknum(e)
    End Sub

    
    Private Sub Middlename_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Middlename.KeyPress

        blocknum(e)
    End Sub

    Private Sub Address_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Address.KeyPress
        blockspchar(e)

    End Sub

    Private Sub Contactnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Contactnum.KeyPress

        blockletter(e)

    End Sub

    Private Sub Telnum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Telnum.KeyPress

        blockletter(e)
    End Sub

    Private Sub Designation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Designation.KeyPress

        blocknum(e)
    End Sub

    Private Sub Age_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Age.KeyPress

        blockletter(e)
    End Sub

    Private Sub numchild_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numchild.KeyPress

        blockletter(e)
    End Sub

    Private Sub sss_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sss_id.KeyPress

        blockletter(e)
    End Sub

    Private Sub tin_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tin_id.KeyPress

        blockletter(e)
    End Sub

    Private Sub phil_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phil_id.KeyPress

        blockletter(e)
    End Sub

    Private Sub pagibig_id_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pagibig_id.KeyPress

        blockletter(e)
    End Sub

    Private Sub presentday_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles presentday.KeyPress

        blockletter(e)
    End Sub

    Private Sub otrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles otrate.KeyPress

        blockletter(e)
    End Sub

    Private Sub regrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles regrate.KeyPress

        blockletter(e)
    End Sub

    Private Sub holrate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles holrate.KeyPress

        blockletter(e)
    End Sub

    Private Sub sss_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sss_d.KeyPress

        blockletter(e)
    End Sub

    Private Sub phil_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles phil_d.KeyPress

        blockletter(e)
    End Sub

    Private Sub pagibig_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pagibig_d.KeyPress

        blockletter(e)
    End Sub

    Private Sub tax_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tax_d.KeyPress

        blockletter(e)
    End Sub

    Private Sub cash_ad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cash_ad.KeyPress

        blockletter(e)
    End Sub


    Dim fname, lname, fulluser As String

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       
    End Sub
End Class