Public Class salarymanage
    Public cutoff As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cutoffcombo.Text = "" Then
            MsgBox("Please Select option!", MsgBoxStyle.Exclamation)
        Else
            cutoff = cutoffcombo.Text
            Me.Hide()
            Main.switchPanel(salary)
            Main.Button1.BackColor = Color.Firebrick
            Main.Button9.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button4.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button2.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button3.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button5.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button7.BackColor = Color.FromArgb(26, 27, 34)
            Main.Button8.BackColor = Color.FromArgb(26, 27, 34)
        End If



    End Sub
End Class