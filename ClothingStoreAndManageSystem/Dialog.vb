Imports MySql.Data.MySqlClient
Public Class Dialog
    Public _mTransId As Integer
    Dim cmd As New MySqlCommand
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim conString As String = "server=localhost;user=root;password=;database=clothing_store"
    Dim query As String
    Private Sub txtBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBack.Click
        Me.Dispose()
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
    Private Sub btnAddNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNow.Click
        If txtQuantity.Text = "" Then
            MsgBox("Quantity cannot be null", MsgBoxStyle.Information)
            Exit Sub
        Else
            Try
                dbConnect()
                query = "SELECT qnty FROM temp_tb WHERE itemId='" + txtItem_Id.Text + "'"
                executeReader()
                If reader.HasRows Then
                    reader.Read()
                    Dim _mQnty As Integer = Convert.ToInt32(reader(0))
                    _mQnty += Val(txtQuantity.Text)
                    dbConnect()
                    query = "UPDATE temp_tb SET qnty='" + _mQnty.ToString + "' WHERE itemId='" + txtItem_Id.Text + "'"
                    executeReader()
                Else
                    dbConnect()
                    query = "INSERT INTO temp_tb(transId,itemId,qnty,date)VALUES('" + _mTransId.ToString + "','" + txtItem_Id.Text + "','" + txtQuantity.Text + "','" + Date.Now.ToShortDateString + "')"
                    executeReader()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Me.Dispose()
        End If
    End Sub

    Private Sub txtQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuantity.TextChanged
        calcTotal()
    End Sub
    Sub calcTotal()
        txtTotalPrize.Text = Val(txtQuantity.Text) * Val(txtUnitPrize.Text)
    End Sub

    Private Sub Dialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        calcTotal()
    End Sub

End Class