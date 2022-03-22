Imports MySql.Data.MySqlClient
Public Class Dashboard
    Dim mDataTable As New DataTable
    Dim cmd As New MySqlCommand
    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim conString As String = "server=localhost;user=root;password=;database=clothing_store"
    Dim query As String
    Dim userTask As String = String.Empty
    Dim stockTask As String = String.Empty
    Public items As New List(Of Item)
    Public _transId As Integer
    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2
        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2
        btnStock_Click(sender, e)
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
#Region "executing mDatatable"
    Public Function executeDatatable() As DataTable
        mDataTable = New DataTable
        Try
            cmd = New MySqlCommand(query, con)
            adapter = New MySqlDataAdapter(cmd)
            adapter.Fill(mDataTable)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return mDataTable
    End Function
#End Region

#Region "system generater/auto userid"
    Private Sub userid()
        Try
            dbConnect()
            query = "SELECT max(userId) FROM users"
            cmd = New MySqlCommand(query, con)
            txtUserId.Text = Convert.ToInt32(cmd.ExecuteScalar)
            txtUserId.Text = Val(txtUserId.Text) + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region
#Region "view stock/STOCK Analyzer/  Items or products to be sold / dates populator"
    Private Sub viewStockManager(ByVal valToSearch As String)
        Try
            dbConnect()
            query = "SELECT * FROM items WHERE name LIKE '%" + valToSearch + "%' OR type LIKE '%" + valToSearch + "%'"
            dgStockManager.DataSource = executeDatatable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub fillMakeAsellDgv(ByVal valToSearch As String)
        Try
            dbConnect()
            query = "SELECT * FROM items WHERE name LIKE '%" + valToSearch + "%' OR type LIKE '%" + valToSearch + "%'"
            dgMakeASell.DataSource = executeDatatable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub datesPopulator()
        dbConnect()
        query = "SELECT date FROM sold"
        cbSearchByDate.DataSource = executeDatatable()
        cbSearchByDate.DisplayMember = "date"
    End Sub
    Private Sub stockAnalyzer(ByVal valToSearch As String)
        Try
            dbConnect()
            query = "SELECT items.itemId,items.name,items.type,items.sprice,sold.qnty FROM items LEFT JOIN sold ON sold.itemId=items.itemId WHERE sold.date LIKE '%" + valToSearch + "%'"
            dgViewStock.DataSource = executeDatatable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub viewSellItems(ByVal valToSearch As String)
        Try
            dbConnect()
            query = "SELECT itemId,name,type,qnty,sprice FROM items WHERE name LIKE '%" + valToSearch + "%' OR type LIKE '%" + valToSearch + "%'"
            dgMakeASell.DataSource = executeDatatable()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#Region "date sold/analyse by date"
    Sub dateSold()
        dbConnect()
        query = "SELECT DISTINCT(date) FROM sold"
        cbSearchByDate.DataSource = executeDatatable()
        cbSearchByDate.DisplayMember = "date"
    End Sub
    Sub analyzerDate(ByVal valToSearch As String)
        Dim _totalCost, _profit, _totalSells As Integer
        dbConnect()
        query = "SELECT sold.qnty,items.bprice,items.sprice FROM sold RIGHT JOIN items ON sold.itemId=items.itemId WHERE sold.date LIKE '%" + valToSearch + "%'"
        Try
            executeReader()
            While reader.Read
                _totalCost += Val(reader(0)) * Val(reader(1))
                _totalSells += Val(reader(0)) * Val(reader(2))
            End While
        Catch ex As Exception

        End Try
        _profit = _totalSells - _totalCost
        lblCost.Text = _totalCost
        lblProfit.Text = _profit
        lblSells.Text = _totalSells
    End Sub
#End Region
#End Region
    Private Sub btnStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock.Click
        TabControlAdmin.SelectedTab = tpViewStock
        lblAction.Text = "Stock Analysis"
        stockAnalyzer("")
        dateSold()
    End Sub

    Private Sub btnAddStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddStock.Click
        TabControlAdmin.SelectedTab = tpAddStock
        lblAction.Text = "Add Stock"
        stockTask = "add"
        clearStockInputControls()
        itemId()
    End Sub

    Private Sub btnStockManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStockManager.Click
        TabControlAdmin.SelectedTab = tpStockManager
        lblAction.Text = "Stock Manager"
        viewStockManager("")
        dateSold()
    End Sub

    Private Sub btnAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUser.Click
        TabControlAdmin.SelectedTab = tpAddUser
        lblAction.Text = "Adding New User"
        userTask = "add"
        clearUserInputControls()
        userid()
    End Sub
#Region "fill user manager dgv"
    Sub fillUsermanager()
        dbConnect()
        query = "SELECT userId,name,rank FROM users"
        dgUserManager.DataSource = executeDatatable()
    End Sub
#End Region
    Private Sub btnUserManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserManager.Click
        TabControlAdmin.SelectedTab = tpUserManager
        lblAction.Text = "Manage Users"
        fillUsermanager()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMaximise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaximise.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            Panel1.Height += 90
            lblRank.Top = Panel1.Height / 2 - 20
            lblUname.Top = Panel1.Height / 2 - 20
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
            Panel1.Height -= 90
            lblRank.Top = Panel1.Height / 2 - 20
            lblUname.Top = Panel1.Height / 2 - 20
        End If
    End Sub

    Private Sub btnMinimise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimise.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnBackToPanel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToPanel.Click
        TabControlDashboard.SelectedTab = tpAdmin
        btnBackToPanel.Visible = False
    End Sub

    Private Sub BTbtnMakeSells_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTbtnMakeSells.Click
        TabControlDashboard.SelectedTab = tpUser
        btnBackToPanel.Visible = True
        viewSellItems("")
        transId()
    End Sub

    Private Sub btnAnalyzerOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalyzerOk.Click
        stockAnalyzer(cbSearchByDate.SelectedText)
        analyzerDate(cbSearchByDate.SelectedText)
    End Sub
#Region "system generated item id and transaction ID"
    Private Sub itemId()
        Try
            dbConnect()
            query = "SELECT count(itemId) FROM items"
            cmd = New MySqlCommand(query, con)
            txtItemId.Text = Convert.ToInt32(cmd.ExecuteScalar)
            If Val(txtItemId.Text) > 0 Then
                query = "SELECT max(itemId) FROM items"
                cmd = New MySqlCommand(query, con)
                txtItemId.Text = Convert.ToInt32(cmd.ExecuteScalar)
                txtItemId.Text = Val(txtItemId.Text) + 101
            Else
                txtItemId.Text = 90
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub transId()
        Dim n As New Random
        Dim m As Integer = Int(n.Next(100000000, 299999999))
        txtSell_id.Text = Convert.ToString(m)
        _transId = Val(txtSell_id.Text)
    End Sub
#End Region
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        dbConnect()
        If stockTask = "add" Then
            query = "INSERT INTO items(itemId,name,qnty,info,bprice,sprice,type)VALUES('" + txtItemId.Text + "','" + txtItemName.Text + "','" + txtQuantity.Text + "','" + txtItemInfo.Text + "','" + txtBPrice.Text + "','" + txtSPrice.Text + "','" + txtType.Text + "')"
            Try
                executeReader()
                MsgBox("Item Added Successfully", MsgBoxStyle.Information)
                clearStockInputControls()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf stockTask = "update" Then
            query = "UPDATE items SET name='" + txtItemName.Text + "',qnty='" + txtQuantity.Text + "',info='" + txtItemInfo.Text + "',bprice='" + txtBPrice.Text + "',sprice='" + txtSPrice.Text + "',type ='" + txtType.Text + "' WHERE itemId='" + txtItemId.Text + "'"
            Try
                executeReader()
                MsgBox("Item updated Successfully", MsgBoxStyle.Information)
                clearStockInputControls()
                btnStockManager_Click(sender, e)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
#Region "clear Stock inputControls"
    Sub clearStockInputControls()
        txtItemId.Text = ""
        txtItemName.Text = ""
        txtQuantity.Text = ""
        txtItemInfo.Text = ""
        txtBPrice.Text = ""
        txtSPrice.Text = ""
        txtType.Text = ""
    End Sub
#End Region
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clearStockInputControls()
        stockTask = "add"
    End Sub
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Or txtUserId.Text = "" Then
            MsgBox("Empty Fields", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim rad As String
        If rbRAdmin.Checked Then
            rad = "admin"
        ElseIf rbRUser.Checked Then
            rad = "user"
        Else
            MsgBox("unchecked Rank, please check", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If userTask = "add" Then
            dbConnect()
            query = "INSERT INTO users(userId,name,rank)VALUES('" + txtUserId.Text + "','" + txtName.Text + "','" + rad + "')"
            executeReader()
            MsgBox("User Added Successfully", MsgBoxStyle.Information)
            clearUserInputControls()
        ElseIf userTask = "update" Then
            dbConnect()
            query = "UPDATE users SET name='" + txtName.Text + "',rank='" + rad + "' WHERE userId='" + txtUserId.Text + "'"
            executeReader()
            MsgBox("User updated Successfully", MsgBoxStyle.Information)
            clearUserInputControls()
            btnUserManager_Click(sender, e)
        End If
    End Sub
#Region "clear User input Controls"
    Sub clearUserInputControls()
        txtName.Text = ""
        txtUserId.Text = ""
        rbRAdmin.Checked = False
        rbRUser.Checked = False
    End Sub
#End Region
    Private Sub btnClearUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearUser.Click
        txtName.Text = ""
        txtUserId.Text = ""
        rbRAdmin.Checked = False
        rbRUser.Checked = False
        userTask = "add"
    End Sub

    Private Sub btnAddNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNewUser.Click
        btnAddUser_Click(sender, e)
    End Sub

    Private Sub btnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteUser.Click
        If dgUserManager.SelectedRows.Count > 0 Then
            Dim user As String = dgUserManager.SelectedRows(0).Cells("userId").Value
            Dim res As New MsgBoxResult
            res = MsgBox("are you sure you want to Delete permenently the selected user", MsgBoxStyle.YesNo, "Deletion")
            If res = MsgBoxResult.Yes Then
                dbConnect()
                query = "DELETE FROM users WHERE userId='" + user + "'"
                executeReader()
                MsgBox("user deleted successfully", MsgBoxStyle.Information)
                fillUsermanager()
            End If
        End If
    End Sub

    Private Sub btnUpdateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateUser.Click
        If dgUserManager.SelectedRows.Count > 0 Then
            Dim user As String = dgUserManager.SelectedRows(0).Cells("userId").Value
            Dim res As New MsgBoxResult
            res = MsgBox("are you sure you want to Update the selected user", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                userTask = "update"
                TabControlAdmin.SelectedTab = tpAddUser
                txtUserId.Text = user
                txtName.Text = dgUserManager.SelectedRows(0).Cells("name").Value
                Dim rank As String = dgUserManager.SelectedRows(0).Cells("rank").Value
                If rank = "admin" Then
                    rbRAdmin.Checked = True
                Else
                    rbRUser.Checked = True
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_StockManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete_StockManager.Click
        If dgStockManager.SelectedRows.Count > 0 Then
            Dim item As String = dgUserManager.SelectedRows(0).Cells("itemId").Value
            Dim res As New MsgBoxResult
            res = MsgBox("are you sure you want to Delete permenently the selected Item", MsgBoxStyle.YesNo, "Deletion")
            If res = MsgBoxResult.Yes Then
                dbConnect()
                query = "DELETE FROM items WHERE itemId='" + item + "'"
                executeReader()
                MsgBox("user deleted successfully", MsgBoxStyle.Information)
                viewStockManager("")
            End If
        End If
    End Sub

    Private Sub btnUpdate_StockManager_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate_StockManager.Click
        If dgStockManager.SelectedRows.Count > 0 Then
            Dim item As String = dgStockManager.SelectedRows(0).Cells("itemId").Value
            Dim res As New MsgBoxResult
            res = MsgBox("are you sure you want to Update the selected user", MsgBoxStyle.YesNo)
            If res = MsgBoxResult.Yes Then
                stockTask = "update"
                TabControlAdmin.SelectedTab = tpAddStock
                txtItemId.Text = item
                txtItemName.Text = dgStockManager.SelectedRows(0).Cells("name").Value
                txtQuantity.Text = dgStockManager.SelectedRows(0).Cells("qnty").Value
                txtItemInfo.Text = dgStockManager.SelectedRows(0).Cells("info").Value
                txtBPrice.Text = dgStockManager.SelectedRows(0).Cells("bprice").Value
                txtSPrice.Text = dgStockManager.SelectedRows(0).Cells("sprice").Value
                txtType.Text = dgStockManager.SelectedRows(0).Cells("type").Value

            End If
        End If
    End Sub

    Private Sub txtSearch_item_sell_OnTextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch_item_sell.OnTextChange
        fillMakeAsellDgv(txtSearch_item_sell.text)
    End Sub

    Private Sub btnAddToSellList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddToSellList.Click
        If dgMakeASell.SelectedRows.Count > 0 Then
            Dim mitemId As String = dgMakeASell.SelectedRows(0).Cells("itemId").Value
            Dim sprice As String = dgMakeASell.SelectedRows(0).Cells("sprice").Value
            Dim name As String = dgMakeASell.SelectedRows(0).Cells("name").Value
            Dim dg As New Dialog
            dg._mTransId = _transId
            dg.txtItem_Id.Text = mitemId
            dg.txtItem.Text = name
            dg.txtUnitPrize.Text = sprice
            dg.ShowDialog()

            fillSellReportDatagridView()
        Else
            MsgBox("You must select the item to sell", MsgBoxStyle.Critical, "No Item Selected")
        End If
    End Sub
#Region "FillSellDatagridView"
    Sub fillSellReportDatagridView()
        dbConnect()
        query = "SELECT items.itemId,items.name,temp_tb.qnty,items.sprice FROM items LEFT JOIN temp_tb ON temp_tb.itemId=items.itemId"
        Try
            executeReader()
            dgSellReport.Rows.Clear()
            While reader.Read
                dgSellReport.Rows.Add(reader(0), reader(1), reader(2), reader(3), Val(reader(2)) * Val(reader(3)))
            End While
        Catch ex As Exception
        End Try
        itemsTotalCost()
    End Sub
#End Region
#Region "total Item Cost"
    Sub itemsTotalCost()
        Dim _sum As Integer = 0
        dbConnect()
        query = "SELECT temp_tb.qnty,items.sprice FROM temp_tb RIGHT JOIN items ON  temp_tb.itemId=items.itemId"
        Try
            executeReader()
            While reader.Read
                _sum += Val(reader(0)) * Val(reader(1))
            End While
        Catch ex As Exception
        End Try
        txtTotalPrize.Text = _sum
    End Sub
#End Region


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        fillSellReportDatagridView()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dgSellReport.SelectedRows.Count > 0 Then
            Dim _itemId As String = dgSellReport.SelectedRows(0).Cells("Column1").Value
            Dim res As DialogResult
            res = MsgBox("are you sure you want to update this Item: " + dgSellReport.SelectedRows(0).Cells("Column2").Value + "?", MsgBoxStyle.YesNo)
            If res = Windows.Forms.DialogResult.Yes Then
                dbConnect()
                query = "DELETE FROM temp_tb WHERE itemId='" + _itemId + "'"
                Try
                    executeReader()
                Catch ex As Exception
                End Try
                fillSellReportDatagridView()
            End If
        End If
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        txtBalance.Text = Val(txtAmount.Text) - Val(txtTotalPrize.Text)
    End Sub

    Private Sub btnMakePayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakePayment.Click
        If Val(txtBalance.Text) < 0 Then
            MsgBox("Insufficient Money, please check", MsgBoxStyle.Critical)
            Exit Sub
        End If
        salesProcessing()
    End Sub
#Region "sales processing "
    Sub salesProcessing()
        dbConnect()
        query = "SELECT itemId,qnty,date FROM temp_tb"
        Try
            executeReader()
            While reader.Read
                Dim item As New Item
                item.mItemId = reader(0)
                item.mQnty = reader(1)
                item.mDate = reader(2)
                items.Add(item)
            End While
            For Each Item As Item In items
                dbConnect()
                query = "INSERT INTO sold(transId,itemId,qnty,date)VALUES('" + _transId.ToString + "','" + Item.mItemId.ToString + "','" + Item.mQnty.ToString + "','" + Item.mDate.ToString + "')"
                executeReader()
            Next
            dbConnect()
            query = "DELETE FROM temp_tb WHERE transId='" + _transId.ToString + "'"
            executeReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim rc As New Receipt
        rc.lblInvoice.Text = _transId
        rc.lblEmpName.Text = lblUname.Text
        rc.ibltotal.Text = txtTotalPrize.Text
        rc.lblCash.Text = txtAmount.Text
        rc.lblbalance.Text = txtBalance.Text
        rc.ShowDialog()

        dgSellReport.Rows.Clear()
        transId()
    End Sub
#End Region

    Private Sub btnGenerateSellId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerateSellId.Click
        If txtSell_id.Text = "" Then
            transId()
        End If
    End Sub

End Class

