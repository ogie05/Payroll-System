<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.vcode1 = New System.Windows.Forms.Button()
        Me.vcode = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.assistadminpic = New System.Windows.Forms.PictureBox()
        Me.payrollmasterpic = New System.Windows.Forms.PictureBox()
        Me.adminpic = New System.Windows.Forms.PictureBox()
        Me.vercode = New System.Windows.Forms.Label()
        Me.type = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.retrieve = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.arestore = New System.Windows.Forms.Button()
        Me.abackup = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.export = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.gbackup = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.assistadminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.payrollmasterpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adminpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(36, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New verification code"
        '
        'vcode1
        '
        Me.vcode1.BackColor = System.Drawing.Color.Firebrick
        Me.vcode1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.vcode1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.vcode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.vcode1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcode1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.vcode1.Location = New System.Drawing.Point(39, 61)
        Me.vcode1.Name = "vcode1"
        Me.vcode1.Size = New System.Drawing.Size(119, 31)
        Me.vcode1.TabIndex = 1
        Me.vcode1.Text = "Confirm"
        Me.vcode1.UseVisualStyleBackColor = False
        '
        'vcode
        '
        Me.vcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.vcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.vcode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vcode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.vcode.Location = New System.Drawing.Point(38, 34)
        Me.vcode.Name = "vcode"
        Me.vcode.Size = New System.Drawing.Size(120, 18)
        Me.vcode.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.assistadminpic)
        Me.Panel2.Controls.Add(Me.payrollmasterpic)
        Me.Panel2.Controls.Add(Me.adminpic)
        Me.Panel2.Controls.Add(Me.vercode)
        Me.Panel2.Controls.Add(Me.type)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.username)
        Me.Panel2.Location = New System.Drawing.Point(18, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(296, 143)
        Me.Panel2.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(134, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Change my password"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'assistadminpic
        '
        Me.assistadminpic.Image = CType(resources.GetObject("assistadminpic.Image"), System.Drawing.Image)
        Me.assistadminpic.Location = New System.Drawing.Point(18, 16)
        Me.assistadminpic.Name = "assistadminpic"
        Me.assistadminpic.Size = New System.Drawing.Size(108, 104)
        Me.assistadminpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.assistadminpic.TabIndex = 15
        Me.assistadminpic.TabStop = False
        '
        'payrollmasterpic
        '
        Me.payrollmasterpic.Image = CType(resources.GetObject("payrollmasterpic.Image"), System.Drawing.Image)
        Me.payrollmasterpic.Location = New System.Drawing.Point(18, 16)
        Me.payrollmasterpic.Name = "payrollmasterpic"
        Me.payrollmasterpic.Size = New System.Drawing.Size(108, 104)
        Me.payrollmasterpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.payrollmasterpic.TabIndex = 14
        Me.payrollmasterpic.TabStop = False
        '
        'adminpic
        '
        Me.adminpic.Image = CType(resources.GetObject("adminpic.Image"), System.Drawing.Image)
        Me.adminpic.Location = New System.Drawing.Point(18, 16)
        Me.adminpic.Name = "adminpic"
        Me.adminpic.Size = New System.Drawing.Size(108, 104)
        Me.adminpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.adminpic.TabIndex = 13
        Me.adminpic.TabStop = False
        '
        'vercode
        '
        Me.vercode.AutoSize = True
        Me.vercode.BackColor = System.Drawing.Color.Transparent
        Me.vercode.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vercode.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.vercode.Location = New System.Drawing.Point(243, 60)
        Me.vercode.Name = "vercode"
        Me.vercode.Size = New System.Drawing.Size(41, 17)
        Me.vercode.TabIndex = 12
        Me.vercode.Text = "None"
        '
        'type
        '
        Me.type.AutoSize = True
        Me.type.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.type.Location = New System.Drawing.Point(139, 83)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(48, 17)
        Me.type.TabIndex = 11
        Me.type.Text = "Admin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(138, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Verification code: "
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.ForeColor = System.Drawing.Color.Firebrick
        Me.username.Location = New System.Drawing.Point(133, 32)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(52, 25)
        Me.username.TabIndex = 9
        Me.username.Text = "Ogie"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel20)
        Me.Panel4.Controls.Add(Me.vcode)
        Me.Panel4.Controls.Add(Me.vcode1)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(12, 412)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(198, 102)
        Me.Panel4.TabIndex = 9
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Firebrick
        Me.Panel20.Location = New System.Drawing.Point(38, 52)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(120, 3)
        Me.Panel20.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Firebrick
        Me.Label5.Location = New System.Drawing.Point(12, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Update code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Firebrick
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 37)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Settings"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel1.Controls.Add(Me.clear)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(19, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 35)
        Me.Panel1.TabIndex = 14
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.Firebrick
        Me.clear.FlatAppearance.BorderSize = 0
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.clear.Location = New System.Drawing.Point(208, 4)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(75, 26)
        Me.clear.TabIndex = 15
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(10, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Log history data"
        '
        'retrieve
        '
        Me.retrieve.BackColor = System.Drawing.Color.Firebrick
        Me.retrieve.FlatAppearance.BorderSize = 0
        Me.retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retrieve.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.retrieve.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.retrieve.Location = New System.Drawing.Point(208, 4)
        Me.retrieve.Name = "retrieve"
        Me.retrieve.Size = New System.Drawing.Size(75, 26)
        Me.retrieve.TabIndex = 15
        Me.retrieve.Text = "Retrieve"
        Me.retrieve.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel3.Controls.Add(Me.retrieve)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(19, 284)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(295, 35)
        Me.Panel3.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Log history data"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel5.Controls.Add(Me.arestore)
        Me.Panel5.Controls.Add(Me.abackup)
        Me.Panel5.Location = New System.Drawing.Point(407, 160)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(204, 86)
        Me.Panel5.TabIndex = 17
        '
        'arestore
        '
        Me.arestore.BackColor = System.Drawing.Color.Firebrick
        Me.arestore.FlatAppearance.BorderSize = 0
        Me.arestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.arestore.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arestore.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.arestore.Location = New System.Drawing.Point(65, 54)
        Me.arestore.Name = "arestore"
        Me.arestore.Size = New System.Drawing.Size(75, 26)
        Me.arestore.TabIndex = 16
        Me.arestore.Text = "Restore"
        Me.arestore.UseVisualStyleBackColor = False
        '
        'abackup
        '
        Me.abackup.BackColor = System.Drawing.Color.Firebrick
        Me.abackup.FlatAppearance.BorderSize = 0
        Me.abackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.abackup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abackup.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.abackup.Location = New System.Drawing.Point(65, 11)
        Me.abackup.Name = "abackup"
        Me.abackup.Size = New System.Drawing.Size(75, 26)
        Me.abackup.TabIndex = 15
        Me.abackup.Text = "Back Up"
        Me.abackup.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 65
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(425, 254)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(157, 14)
        Me.ProgressBar1.TabIndex = 18
        '
        'export
        '
        Me.export.BackColor = System.Drawing.Color.Firebrick
        Me.export.FlatAppearance.BorderSize = 0
        Me.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.export.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.export.Location = New System.Drawing.Point(208, 4)
        Me.export.Name = "export"
        Me.export.Size = New System.Drawing.Size(75, 26)
        Me.export.TabIndex = 15
        Me.export.Text = "Go To"
        Me.export.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel6.Controls.Add(Me.export)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Location = New System.Drawing.Point(407, 343)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(295, 35)
        Me.Panel6.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(10, 7)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Database Folder"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Panel7.Controls.Add(Me.gbackup)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Location = New System.Drawing.Point(407, 393)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(295, 35)
        Me.Panel7.TabIndex = 18
        '
        'gbackup
        '
        Me.gbackup.BackColor = System.Drawing.Color.Firebrick
        Me.gbackup.FlatAppearance.BorderSize = 0
        Me.gbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbackup.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbackup.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.gbackup.Location = New System.Drawing.Point(208, 4)
        Me.gbackup.Name = "gbackup"
        Me.gbackup.Size = New System.Drawing.Size(75, 26)
        Me.gbackup.TabIndex = 15
        Me.gbackup.Text = "Go To"
        Me.gbackup.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(10, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(171, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Backup to Google Drive"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Firebrick
        Me.Label10.Location = New System.Drawing.Point(445, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Database Setting"
        '
        'Timer2
        '
        Me.Timer2.Interval = 65
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 563)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.assistadminpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.payrollmasterpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adminpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents vcode1 As System.Windows.Forms.Button
    Friend WithEvents vcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents type As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents vercode As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents assistadminpic As System.Windows.Forms.PictureBox
    Friend WithEvents payrollmasterpic As System.Windows.Forms.PictureBox
    Friend WithEvents adminpic As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents retrieve As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents arestore As System.Windows.Forms.Button
    Friend WithEvents abackup As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents export As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents gbackup As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class
