Public Class LoadingScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)


        If ProgressBar1.Value = 5 Then
            Label1.Text = "1 %"
            Label2.Text = "Loading ..."
        ElseIf ProgressBar1.Value = 8 Then
            Label1.Text = "2 %"
        ElseIf ProgressBar1.Value = 10 Then
            Label1.Text = "5 %"
        ElseIf ProgressBar1.Value = 12 Then
            Label1.Text = "10 %"
            Label2.Text = "Generating Resources ..."
        ElseIf ProgressBar1.Value = 15 Then
            Label1.Text = "15 %"
        ElseIf ProgressBar1.Value = 20 Then
            Label1.Text = "20 %"
        ElseIf ProgressBar1.Value = 25 Then
            Label1.Text = "25 %"
            Label2.Text = "Loading Framework ..."
        ElseIf ProgressBar1.Value = 30 Then
            Label1.Text = "30 %"
        ElseIf ProgressBar1.Value = 25 Then
            Label1.Text = "35 %"
        ElseIf ProgressBar1.Value = 40 Then
            Label1.Text = "45 %"
            Label2.Text = "Processing Database ..."
        ElseIf ProgressBar1.Value = 50 Then
            Label1.Text = "50 %"
            Label2.Text = "Checking System Compatibility ..."
            Label1.BackColor = Color.ForestGreen
        ElseIf ProgressBar1.Value = 65 Then
            Label1.Text = "65 %"
            Label2.Text = "System Compatible ..."
        ElseIf ProgressBar1.Value = 75 Then
            Label1.Text = "78 %"
            Label2.Text = "Initializing System ..."
        ElseIf ProgressBar1.Value = 85 Then
            Label1.Text = "89 %"
        ElseIf ProgressBar1.Value = 90 Then
            Label1.Text = "95 %"
            Label2.Text = "Load Successfully..."
        ElseIf ProgressBar1.Value = 95 Then
            Label1.Text = "99 %"


        ElseIf ProgressBar1.Value = 96 Then
            Label1.Text = "100 %"
        ElseIf ProgressBar1.Value = 100 Then
            Label1.Text = "100 %"
            Me.Hide()
            loginform.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class