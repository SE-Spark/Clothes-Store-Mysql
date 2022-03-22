<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMinimise = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.rbUser_register = New System.Windows.Forms.RadioButton()
        Me.rbAdmin_register = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPswd_register = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.txtUsername_register = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tpRegister = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.rbUser = New System.Windows.Forms.RadioButton()
        Me.LlblRegister = New System.Windows.Forms.LinkLabel()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPswd = New System.Windows.Forms.TextBox()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.lblPswd = New System.Windows.Forms.Label()
        Me.lblUname = New System.Windows.Forms.Label()
        Me.lblRank = New System.Windows.Forms.Label()
        Me.tpLogin = New System.Windows.Forms.TabPage()
        Me.TabcontrolLogin = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.tpRegister.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpLogin.SuspendLayout()
        Me.TabcontrolLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(193, 167)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 29)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(66, 167)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(87, 29)
        Me.btnRegister.TabIndex = 3
        Me.btnRegister.Text = "&Register"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMinimise)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, -6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 52)
        Me.Panel1.TabIndex = 4
        '
        'btnMinimise
        '
        Me.btnMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimise.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimise.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimise.Location = New System.Drawing.Point(231, 7)
        Me.btnMinimise.Name = "btnMinimise"
        Me.btnMinimise.Size = New System.Drawing.Size(40, 31)
        Me.btnMinimise.TabIndex = 6
        Me.btnMinimise.Text = "-"
        Me.btnMinimise.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMinimise.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(294, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(3, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(229, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "CLOTHING STORE MANAGEMENT SYSTEM"
        '
        'rbUser_register
        '
        Me.rbUser_register.AutoSize = True
        Me.rbUser_register.Location = New System.Drawing.Point(171, 75)
        Me.rbUser_register.Name = "rbUser_register"
        Me.rbUser_register.Size = New System.Drawing.Size(47, 17)
        Me.rbUser_register.TabIndex = 2
        Me.rbUser_register.TabStop = True
        Me.rbUser_register.Text = "User"
        Me.rbUser_register.UseVisualStyleBackColor = True
        '
        'rbAdmin_register
        '
        Me.rbAdmin_register.AutoSize = True
        Me.rbAdmin_register.Location = New System.Drawing.Point(111, 75)
        Me.rbAdmin_register.Name = "rbAdmin_register"
        Me.rbAdmin_register.Size = New System.Drawing.Size(54, 17)
        Me.rbAdmin_register.TabIndex = 2
        Me.rbAdmin_register.TabStop = True
        Me.rbAdmin_register.Text = "Admin"
        Me.rbAdmin_register.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBack)
        Me.GroupBox2.Controls.Add(Me.btnRegister)
        Me.GroupBox2.Controls.Add(Me.rbUser_register)
        Me.GroupBox2.Controls.Add(Me.rbAdmin_register)
        Me.GroupBox2.Controls.Add(Me.txtPswd_register)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.txtUserId)
        Me.GroupBox2.Controls.Add(Me.txtUsername_register)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 211)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "REGISTRATION"
        '
        'txtPswd_register
        '
        Me.txtPswd_register.Location = New System.Drawing.Point(111, 134)
        Me.txtPswd_register.Name = "txtPswd_register"
        Me.txtPswd_register.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtPswd_register.Size = New System.Drawing.Size(119, 20)
        Me.txtPswd_register.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(119, 20)
        Me.txtName.TabIndex = 1
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(108, 16)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(119, 20)
        Me.txtUserId.TabIndex = 1
        '
        'txtUsername_register
        '
        Me.txtUsername_register.Location = New System.Drawing.Point(111, 102)
        Me.txtUsername_register.Name = "txtUsername_register"
        Me.txtUsername_register.Size = New System.Drawing.Size(119, 20)
        Me.txtUsername_register.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(17, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Username"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(20, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(20, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "UserId"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(20, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Rank"
        '
        'tpRegister
        '
        Me.tpRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tpRegister.Controls.Add(Me.GroupBox2)
        Me.tpRegister.Location = New System.Drawing.Point(4, 22)
        Me.tpRegister.Name = "tpRegister"
        Me.tpRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegister.Size = New System.Drawing.Size(329, 240)
        Me.tpRegister.TabIndex = 1
        Me.tpRegister.Text = "Register Tab"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(40, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(78, 117)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 29)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'rbUser
        '
        Me.rbUser.AutoSize = True
        Me.rbUser.Location = New System.Drawing.Point(171, 25)
        Me.rbUser.Name = "rbUser"
        Me.rbUser.Size = New System.Drawing.Size(47, 17)
        Me.rbUser.TabIndex = 2
        Me.rbUser.TabStop = True
        Me.rbUser.Text = "User"
        Me.rbUser.UseVisualStyleBackColor = True
        '
        'LlblRegister
        '
        Me.LlblRegister.AutoSize = True
        Me.LlblRegister.ForeColor = System.Drawing.Color.Lime
        Me.LlblRegister.LinkColor = System.Drawing.Color.Lime
        Me.LlblRegister.Location = New System.Drawing.Point(33, 173)
        Me.LlblRegister.Name = "LlblRegister"
        Me.LlblRegister.Size = New System.Drawing.Size(174, 13)
        Me.LlblRegister.TabIndex = 2
        Me.LlblRegister.TabStop = True
        Me.LlblRegister.Text = "Dont have account? Register here."
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(111, 25)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(54, 17)
        Me.rbAdmin.TabIndex = 2
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.rbUser)
        Me.GroupBox1.Controls.Add(Me.rbAdmin)
        Me.GroupBox1.Controls.Add(Me.txtPswd)
        Me.GroupBox1.Controls.Add(Me.txtUname)
        Me.GroupBox1.Controls.Add(Me.lblPswd)
        Me.GroupBox1.Controls.Add(Me.lblUname)
        Me.GroupBox1.Controls.Add(Me.lblRank)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 152)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN"
        '
        'txtPswd
        '
        Me.txtPswd.Location = New System.Drawing.Point(111, 84)
        Me.txtPswd.Name = "txtPswd"
        Me.txtPswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.txtPswd.Size = New System.Drawing.Size(119, 20)
        Me.txtPswd.TabIndex = 1
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(111, 52)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(119, 20)
        Me.txtUname.TabIndex = 1
        '
        'lblPswd
        '
        Me.lblPswd.AutoSize = True
        Me.lblPswd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPswd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPswd.Location = New System.Drawing.Point(17, 82)
        Me.lblPswd.Name = "lblPswd"
        Me.lblPswd.Size = New System.Drawing.Size(86, 20)
        Me.lblPswd.TabIndex = 0
        Me.lblPswd.Text = "Password"
        '
        'lblUname
        '
        Me.lblUname.AutoSize = True
        Me.lblUname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblUname.Location = New System.Drawing.Point(17, 52)
        Me.lblUname.Name = "lblUname"
        Me.lblUname.Size = New System.Drawing.Size(91, 20)
        Me.lblUname.TabIndex = 0
        Me.lblUname.Text = "Username"
        '
        'lblRank
        '
        Me.lblRank.AutoSize = True
        Me.lblRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRank.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblRank.Location = New System.Drawing.Point(20, 22)
        Me.lblRank.Name = "lblRank"
        Me.lblRank.Size = New System.Drawing.Size(51, 20)
        Me.lblRank.TabIndex = 0
        Me.lblRank.Text = "Rank"
        '
        'tpLogin
        '
        Me.tpLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tpLogin.Controls.Add(Me.Label1)
        Me.tpLogin.Controls.Add(Me.LlblRegister)
        Me.tpLogin.Controls.Add(Me.GroupBox1)
        Me.tpLogin.Location = New System.Drawing.Point(4, 22)
        Me.tpLogin.Name = "tpLogin"
        Me.tpLogin.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLogin.Size = New System.Drawing.Size(329, 240)
        Me.tpLogin.TabIndex = 0
        Me.tpLogin.Text = "LOGIN TAB"
        '
        'TabcontrolLogin
        '
        Me.TabcontrolLogin.Controls.Add(Me.tpLogin)
        Me.TabcontrolLogin.Controls.Add(Me.tpRegister)
        Me.TabcontrolLogin.Location = New System.Drawing.Point(0, 24)
        Me.TabcontrolLogin.Name = "TabcontrolLogin"
        Me.TabcontrolLogin.SelectedIndex = 0
        Me.TabcontrolLogin.Size = New System.Drawing.Size(337, 266)
        Me.TabcontrolLogin.TabIndex = 5
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 279)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabcontrolLogin)
        Me.Name = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.tpRegister.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpLogin.ResumeLayout(False)
        Me.tpLogin.PerformLayout()
        Me.TabcontrolLogin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnMinimise As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents rbUser_register As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdmin_register As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPswd_register As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername_register As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tpRegister As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents rbUser As System.Windows.Forms.RadioButton
    Friend WithEvents LlblRegister As System.Windows.Forms.LinkLabel
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPswd As System.Windows.Forms.TextBox
    Friend WithEvents txtUname As System.Windows.Forms.TextBox
    Friend WithEvents lblPswd As System.Windows.Forms.Label
    Friend WithEvents lblUname As System.Windows.Forms.Label
    Friend WithEvents lblRank As System.Windows.Forms.Label
    Friend WithEvents tpLogin As System.Windows.Forms.TabPage
    Friend WithEvents TabcontrolLogin As System.Windows.Forms.TabControl
End Class
