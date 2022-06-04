Imports MySql.Data.MySqlClient
Public Class salary
    Dim basicpay1, rot1, hol1, totalern1, totald1, netpay1, dayswork1 As Double

    Dim tax, cashd, salaryd, sssl, pagibigl, otherl, vale1 As Double

    Public pcode As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
       


            If holothrs.Text = Nothing Or regothrs.Text = Nothing Then
                MsgBox("Please Input value in OTHOURS if none put 0")
            Else
                Dim dwork, dabs, reg As Double
                dwork = dayswork.Text
            dabs = dayabsent.Text
            vale1 = vale.Text
                dayswork1 = dwork - dabs
                reg = regrate.Text

                basicpay1 = dayswork1 * reg
                basicpay.Text = basicpay1

                If regothrs.Text = 0 Then
                    rot1 = 0
                Else
                    rot1 = otrate.Text * regothrs.Text
                End If

                If holothrs.Text = 0 Then
                    hol1 = 0
                Else
                    hol1 = holrate.Text * holothrs.Text
                End If


                ot.Text = rot1 + hol1
            totalern1 = basicpay1 + ot.Text + vale1
                totalern.Text = totalern1

                tax = tax_d.Text
                cashd = cash_d.Text
                salaryd = salary_l.Text
                sssl = sss_l.Text
                pagibigl = pagibig_l.Text
                otherl = other_l.Text

                totald1 = tax + cashd + salaryd + sssl + pagibigl + otherl
                totald.Text = totald1

                netpay1 = totalern1 - totald1
                netpay.Text = netpay1
            End If

    End Sub

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sid.Text = "1"
        autonext()
        Me.ToolTip1.SetToolTip(save, "This button will let you save your computed salary to database.")
        Me.ToolTip1.SetToolTip(Print, "This button will let you PRINT your computed salary to payslip.")
       
    End Sub
    Public psss As Integer
    Public Sub autonext()

       
            basicpay.Clear()
            ot.Clear()
            totalern.Clear()
            totald.Clear()
            netpay.Clear()

            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader

            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            Try


                cmd = New MySqlCommand("SELECT * from employee natural join salary where EmployeeCode='" & sid.Text & "' ", con)
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim fname = dr.GetString("FirstName")
                    Dim mname = dr.GetString("MiddleName")
                    Dim lname = dr.GetString("LastName")
                    Dim fullname = fname + " " + mname + " " + lname
                    sname.Text = fullname

                    Dim presentday = dr.GetString("days_work")
                    dayswork.Text = presentday
                    Dim rrate = dr.GetString("RegularRate")
                    regrate.Text = rrate
                    Dim otrate1 = dr.GetString("OtRate")
                    otrate.Text = otrate1
                    Dim holrate1 = dr.GetString("HolRate")
                    holrate.Text = holrate1
                Dim sss = dr.GetString("sss_d")
                sss_d.Text = sss
                psss = sss
                    Dim phil = dr.GetString("philheatlh_d")
                    phil_d.Text = phil
                    Dim pagibig = dr.GetString("pagibig_d")
                    pagibig_d.Text = pagibig
                    Dim tax = dr.GetString("tax_d")
                    tax_d.Text = tax
                    Dim cash = dr.GetString("cashadvance_d")
                    cash_d.Text = cash

                    salary_l.Text = 0
                    sss_l.Text = 0
                    pagibig_l.Text = 0
                    other_l.Text = 0
                    regothrs.Text = 0
                    holothrs.Text = 0
                    dayabsent.Text = 0
                vale.Text = 0


                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()

  
    End Sub
    
    

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If basicpay.Text = Nothing Or ot.Text = Nothing Or totalern.Text = Nothing Or totald.Text = Nothing Or netpay.Text = Nothing Then
            MsgBox("Please Click Compute First")
        Else
            Dim ans As DialogResult
            ans = MsgBox("Are You Sure to Save?", MsgBoxStyle.YesNo)
            If ans = DialogResult.Yes Then


                Dim con As New MySqlConnection
                Dim dr As MySqlDataReader
                Dim dr1 As MySqlDataReader
                Dim command As String
                Dim cmd As MySqlCommand
                Dim cmd2 As MySqlCommand
                con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
                con.Open()
                cmd = New MySqlCommand("SELECT salary_code FROM salary where EmployeeCode=('" & sid.Text & "')", con)

                dr = cmd.ExecuteReader
                dr.Read()
                Dim scode = dr.GetString("salary_code")

                Dim date2 As String
                date2 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                Dim month As String
                month = Date.Now.ToString("MMMM")
                Dim fulldate As String
                fulldate = Date.Now.ToString("yyyy-MM-dd")

                'Dim date2 As String
                'date2 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                Dim cut As String
                cut = salarymanage.cutoff
                command = "insert into payslip (salary_code,EmployeeCode,basicpay,overtime,total_earnings,total_deduction,netpay,reg_ot_hrs,hol_ot_hrs,salary_loan,sss_loan,pagibig_loan,other_loan,days_absent,date_save,month,fulldate,cutoff) values ('" & scode & "','" & sid.Text & "','" & basicpay.Text & "','" & ot.Text & "','" & totalern.Text & "','" & totald.Text & "','" & netpay.Text & "','" & regothrs.Text & "','" & holothrs.Text & "','" & salary_l.Text & "','" & sss_l.Text & "','" & pagibig_l.Text & "','" & other_l.Text & "','" & dayabsent.Text & "','" & date2 & "','" & month & "','" & fulldate & "','" & cut & "')"
                Dim cmd1 As MySqlCommand = New MySqlCommand(command, con)


                cmd1.Parameters.Add(New MySqlParameter("salary_code", CType(scode, String)))
                cmd1.Parameters.Add(New MySqlParameter("EmployeeCode", CType(sid.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("basicpay", CType(basicpay.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("overtime", CType(ot.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("total_earnings", CType(totalern.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("total_deduction", CType(totald.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("netpay", CType(netpay.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("reg_ot_hrs", CType(regothrs.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("hol_ot_hrs", CType(holothrs.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("salary_loan", CType(salary_l.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("sss_loan", CType(sss_l.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("pagibig_loan", CType(pagibig_l.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("other_loan", CType(other_l.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("days_absent", CType(dayabsent.Text, String)))
                cmd1.Parameters.Add(New MySqlParameter("date_save", CType(date2, String)))
                cmd1.Parameters.Add(New MySqlParameter("month", CType(month, String)))
                cmd1.Parameters.Add(New MySqlParameter("fulldate", CType(fulldate, String)))
                cmd1.Parameters.Add(New MySqlParameter("cutoff", CType(cut, String)))
                dr.Close()
                'command to update the vale
                Dim valecommand = New MySqlCommand("update salary set cashadvance_d = cashadvance_d + '" & vale.Text & "' where salary_code='" & scode & "'", con)
                valecommand.ExecuteNonQuery()


               
                MsgBox("SAVED TO DATABASE")


                'command to update the cash advance
                Dim cashcommand = New MySqlCommand("update salary set cashadvance_d = cashadvance_d - '" & cash_d.Text & "' where salary_code='" & scode & "'", con)
                cashcommand.ExecuteNonQuery()


                Dim createhis As String
                createhis = "New Computation Saved. Payslip has been added"



                Dim time1, date1 As String
                date1 = Date.Now.ToString("dddd-MMMM-dd-yyyy")
                time1 = Date.Now.ToString("hh:mm tt")

                command = "insert into report (report_history,report_date,report_time) values ('" & createhis & "','" & date1 & "','" & time1 & "')"
                Dim cmd3 As MySqlCommand = New MySqlCommand(command, con)
                cmd3.ExecuteNonQuery()



                Try
                    cmd1.ExecuteNonQuery()
                    dr.Close()

                    'COMPUTE ALL RECORD
                    Dim get_info_record As String
                    Dim totalsss, totalphil, totalpagibig, totaltax, totalvale, totalnetpay As Integer
                    
                    'update the total deduction
                    Dim get_total As New MySqlCommand
                    get_total = New MySqlCommand("SELECT total_sss,total_phil,total_pagibig,total_tax,total_vale,total_netpay FROM record where EmployeeCode='" & sid.Text & "'", con)
                    dr1 = get_total.ExecuteReader
                    Dim total_sss = "", total_phil = "", total_pagibig = "", total_tax = "", total_vale = "", total_netpay = ""
                    While dr1.Read()

                        total_sss = dr1.GetString("total_sss")
                        total_phil = dr1.GetString("total_phil")
                        total_pagibig = dr1.GetString("total_pagibig")
                        total_tax = dr1.GetString("total_tax")
                        total_vale = dr1.GetString("total_vale")
                        total_netpay = dr1.GetString("total_netpay")

                    End While
                    'compute total
                    dr1.Close()
                    'for sss
                    Dim sss_text As Integer
                    sss_text = sss_d.Text
                    totalsss = total_sss + sss_text

                    'for phil
                    Dim phil_text As Integer
                    phil_text = phil_d.Text
                    totalphil = total_phil + phil_text

                    'for pagibig
                    Dim pagibig_text As Integer
                    pagibig_text = pagibig_d.Text
                    totalpagibig = total_pagibig + pagibig_text

                    'for tax
                    Dim tax_text As Integer
                    tax_text = tax_d.Text
                    totaltax = total_tax + tax_text

                    'for vale
                    Dim vale_text As Integer
                    vale_text = cash_d.Text
                    totalvale = total_vale + vale_text

                    'for netpay
                    Dim netpay_text As Integer
                    netpay_text = netpay.Text
                    totalnetpay = total_netpay + netpay_text


                    get_total.Dispose()
                    cmd1.Dispose()
                    get_info_record = "update record set total_sss='" & totalsss & "',total_phil='" & totalphil & "',total_pagibig='" & totalpagibig & "',total_tax='" & totaltax & "',total_vale='" & totalvale & "',total_netpay='" & totalnetpay & "' where EmployeeCode='" & sid.Text & "'"
                    Dim update_record As New MySqlCommand(get_info_record, con)
                    update_record.ExecuteNonQuery()


                    'update employee id
                    sid.Text = sid.Text + 1
                    cmd1.Dispose()
                    cmd3.Dispose()
                    'sid.Clear()
                    basicpay.Clear()
                    ot.Clear()
                    totalern.Clear()
                    totald.Clear()
                    netpay.Clear()
                    regothrs.Clear()
                    holothrs.Clear()
                    otrate.Clear()
                    holrate.Clear()
                    salary_l.Clear()
                    sss_l.Clear()
                    pagibig_l.Clear()
                    other_l.Clear()
                    dayabsent.Clear()
                    dayswork.Clear()
                    regrate.Clear()
                    sss_d.Clear()
                    phil_d.Clear()
                    pagibig_d.Clear()
                    tax_d.Clear()
                    cash_d.Clear()
                    vale.Clear()
                    sname.Clear()
                    con.Close()

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                autonext()
                con.Open()
                cmd2 = New MySqlCommand("SELECT payslip_code FROM payslip ORDER BY payslip_code DESC LIMIT 1", con)

                dr1 = cmd2.ExecuteReader
                dr1.Read()

                pcode = dr1.GetString("payslip_code")
                

                dr1.Close()
                cmd2.Dispose()
                con.Close()

            End If

        End If

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Me.ToolTip1.SetToolTip(Button2, "Press to Compute Salary.")
        Me.ToolTip1.SetToolTip(Button1, "Find Employee ID")
        Me.ToolTip1.SetToolTip(save, "This button will let you SAVE your computed salary to database.")
        Me.ToolTip1.SetToolTip(Print, "This button will let you PRINT your computed salary to payslip.")

        autonext()
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print.Click
        
        printtab.Show()



    End Sub

    Private Sub regothrs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles regothrs.KeyPress
        Settings.blockletter(e)

    End Sub

    Private Sub holothrs_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles holothrs.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub salary_l_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles salary_l.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub sss_l_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sss_l.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub pagibig_l_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pagibig_l.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub other_l_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles other_l.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub dayabsent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dayabsent.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub Find_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Find.Click
        If sid.Text = Nothing Then
            MsgBox("Please Input Employee Code")
        Else
            basicpay.Clear()
            ot.Clear()
            totalern.Clear()
            totald.Clear()
            netpay.Clear()

            Dim con As New MySqlConnection
            Dim cmd As New MySqlCommand
            Dim dr As MySqlDataReader

            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            Try


                cmd = New MySqlCommand("SELECT * from employee natural join salary where EmployeeCode='" & sid.Text & "' ", con)
                dr = cmd.ExecuteReader

                While dr.Read
                    Dim fname = dr.GetString("FirstName")
                    Dim mname = dr.GetString("MiddleName")
                    Dim lname = dr.GetString("LastName")
                    Dim fullname = fname + " " + mname + " " + lname
                    sname.Text = fullname

                    Dim presentday = dr.GetString("days_work")
                    dayswork.Text = presentday
                    Dim rrate = dr.GetString("RegularRate")
                    regrate.Text = rrate
                    Dim otrate1 = dr.GetString("OtRate")
                    otrate.Text = otrate1
                    Dim holrate1 = dr.GetString("HolRate")
                    holrate.Text = holrate1
                    Dim sss = dr.GetString("sss_d")
                    sss_d.Text = sss
                    Dim phil = dr.GetString("philheatlh_d")
                    phil_d.Text = phil
                    Dim pagibig = dr.GetString("pagibig_d")
                    pagibig_d.Text = pagibig
                    Dim tax = dr.GetString("tax_d")
                    tax_d.Text = tax
                    Dim cash = dr.GetString("cashadvance_d")
                    cash_d.Text = cash

                    salary_l.Text = 0
                    sss_l.Text = 0
                    pagibig_l.Text = 0
                    other_l.Text = 0
                    regothrs.Text = 0
                    holothrs.Text = 0
                    dayabsent.Text = 0
                    vale.Text = 0
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()

        End If
    End Sub

    Private Sub cash_d_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cash_d.KeyPress
        Settings.blockletter(e)
    End Sub

    Private Sub sid_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles sid.KeyPress
        Settings.blockletter(e)
    End Sub
End Class