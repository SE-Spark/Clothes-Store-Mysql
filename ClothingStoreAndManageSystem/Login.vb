Imports MySql.Data.MySqlClient
Public Class Login
    Dim cmd As New MySqlCommand
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim conString As String = "server=localhost;user=root;password=;database=clothing_store"
    Dim query As String
    Public rb As String = String.Empty
    Public username As String = String.Empty
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
    End Sub
#Region "db connection"
    Public Sub dbConnect()
        Try
            With con
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = conString
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region " reader execution"
    Private Sub executeReader()
        Try
            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#End Region
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim rb As String = String.Empty
        btnLogin.Enabled = False
        If rbAdmin.Checked = False And rbUser.Checked = False Then
            MsgBox("please check your rank", MsgBoxStyle.Critical)
            btnLogin.Enabled = True
            Exit Sub
        End If
        If txtUname.Text = "" Or txtPswd.Text = "" Then
            MsgBox("empty field(s)!! Please all fields required ", MsgBoxStyle.Critical)
            btnLogin.Enabled = True
            Exit Sub
        End If
        If (rbAdmin.Checked) Then
            rb = "admin"
        ElseIf (rbUser.Checked) Then
            rb = "user"
        End If
        username = txtUname.Text
        Try
            dbConnect()
            query = "SELECT * FROM users WHERE Rank='" + rb + "' and Uname='" + txtUname.Text + "' and Pswd='" + txtPswd.Text + "'"
            executeReader()
            If reader.HasRows Then
                MsgBox("login successful", MsgBoxStyle.Information)

                Dim dash As New Dashboard
                dash.lblRank.Text = rb.ToUpper
                dash.lblUname.Text = username.ToUpper
                dash.Show()

                Me.Hide()
                txtUname.Clear()
                txtPswd.Clear()
                rbAdmin.Checked = False
                rbUser.Checked = False
            Else
                MsgBox("invalid entry! Please try again", MsgBoxStyle.Critical)
                txtUname.Clear()
                txtPswd.Clear()
                rbAdmin.Checked = False
                rbUser.Checked = False
                btnLogin.Enabled = True
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            btnLogin.Enabled = True
        End Try
    End Sub
#Region "user registration"
    Private Sub firstTimeCheck()
        Dim count As Integer
        Try
            dbConnect()
            query = "select count(UserId) FROM users"
            cmd = New MySqlCommand(query, con)
            count = Convert.ToInt32(cmd.ExecuteScalar)
            If count = 0 Then
                MsgBox("it seems your are running this system for the first time.lets continue")
                txtUserId.ReadOnly = True
                txtUserId.Text = "00001"
                rbAdmin_register.Checked = True
                rbUser_register.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub registerUser()
        If txtUserId.Text = "" Or txtName.Text = "" Or txtUsername_register.Text = "" Or txtPswd_register.Text = "" Then
            MsgBox("empty field(s)!! Please all fields required ", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If rbAdmin_register.Checked = False And rbUser_register.Checked = False Then
            MsgBox("please check your rank", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If rbAdmin_register.Checked = True Then
            rb = "admin"
        ElseIf rbUser_register.Checked = True Then
            rb = "user"
        End If
        Try
            dbConnect()
            query = "UPDATE users SET Uname='" + txtUsername_register.Text + "',Pswd='" + txtPswd_register.Text + "' where UserId ='" + txtUserId.Text + "' and Name='" + txtName.Text + "' and Rank='" + rb + "'"
            executeReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("account created successfully" & vbCrLf & "now login using the details you have provided", MsgBoxStyle.Information)
        TabcontrolLogin.SelectedTab = tpLogin
    End Sub
#End Region

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        If rbUser_register.Enabled = False Then
            If txtName.Text = "" Or txtUsername_register.Text = "" Or txtPswd_register.Text = "" Then
                MsgBox("empty field(s)!! Please all fields required ", MsgBoxStyle.Critical)
                Exit Sub
            End If
            rb = "admin"
            dbConnect()
            query = "INSERT INTO users(UserId,Name,Rank,Uname,Pswd) values('" + txtUserId.Text + "','" + txtName.Text + "','" + rb + "','" + txtUsername_register.Text + "','" + txtPswd_register.Text + "')"
            executeReader()
            MsgBox("account created successfully." & vbCrLf & "Now login  as admin using credintials you provided")
            TabcontrolLogin.SelectedTab = tpLogin
        Else
            registerUser()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        TabcontrolLogin.SelectedTab = tpLogin
    End Sub

    Private Sub LlblRegister_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LlblRegister.LinkClicked
        TabcontrolLogin.SelectedTab = tpRegister
        firstTimeCheck()
    End Sub

    Private Sub btnMinimise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class