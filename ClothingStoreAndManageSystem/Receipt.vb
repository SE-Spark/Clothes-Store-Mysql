Imports MySql.Data.MySqlClient
Public Class Receipt
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim adapter As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim conString As String = "server=localhost;user=root;password=;database=clothing_store"
    Dim query As String
    Dim Dataset As New System.Data.DataSet
    Dim tables As New System.Data.DataTable
    Dim x As Integer = 0
    Dim Y As Integer = 0
    Private Sub Receipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        loaditems()
        ibldate.Text = Format(Date.Now, "Short Date")
        ibltime.Text = Format(Date.Now, "Long Time")
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
#End Region
    Public Sub loaditems()
        Try
            dbConnect()
            query = "SELECT sold.qnty,items.name,items.sprice FROM sold RIGHT JOIN items ON sold.itemId=items.itemId WHERE sold.transId='" + Trim(lblInvoice.Text) + "'"
            cmd = New MySqlCommand(query, con)
            reader = cmd.ExecuteReader
            dgwReport.Rows.Clear()
            While reader.Read
                dgwReport.Rows.Add(reader(0), reader(1), reader(2), Val(reader(0)) * Val(reader(2)))
                dgwReport.Height += 19
                x += 19
            End While
            Y = x - 30
            dgwReport.Height = dgwReport.Height - 20
            TotalAmount.Location = New Point(49, 245 + Y)
            ibltotal.Location = New Point(249, 245 + Y)
            Cash.Location = New Point(49, 262 + Y)
            lblCash.Location = New Point(249, 262 + Y)
            change.Location = New Point(49, 280 + Y)
            lblbalance.Location = New Point(249, 280 + Y)
            lblLine.Location = New Point(52, 299 + Y)
            lblOR.Location = New Point(86, 315 + Y)
            lblThank.Location = New Point(106, 331 + Y)
            btnexit.Location = New Point(198, 369 + Y)
            btnprint.Location = New Point(104, 369 + Y)
            Panel1.Height = Panel1.Height + Y
            Me.Height = Me.Height + Y
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnexit.Hide()
        btnprint.Hide()
        If dgwReport.Rows.Count = 0 Then
            MsgBox("Please load Items to print.", MsgBoxStyle.Exclamation, "Report")
            Exit Sub
        End If
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            Me.Height = Me.Height + Y
            Panel1.Height = Panel1.Height + Y
            PrintDocument1.Print()
        End If
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 50, 40)
        Dim aPS As New PageSetupDialog
        aPS.Document = PrintDocument1
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class