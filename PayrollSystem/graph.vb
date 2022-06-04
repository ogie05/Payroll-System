Imports MySql.Data.MySqlClient
Public Class graph
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    
    End Sub

    Private Sub graph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dr As MySqlDataReader

        Try
            con = New MySqlConnection("Server=127.0.0.1;Username=root;Password=;database=system")
            con.Open()
            cmd = New MySqlCommand("SELECT MAX(netpay),month from payslip GROUP BY month", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                Chart1.Series("Grosspay").Points.AddXY(dr.GetString("month"), dr.GetInt32("MAX(netpay)"))
            End While
            con.Close()
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            con.Close()
        End Try
        con.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Chart3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart3.Click

    End Sub
End Class