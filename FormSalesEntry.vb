Imports System.Data.SqlClient

Public Class FormSalesEntry
    Dim cost As String = ""
    Dim MaxID As String = ""
    Dim qty As String = ""
    Dim qty2 As String = ""
    Dim tot As String = ""
    Private Sub FormSalesEntry_Load(ByVal sendr As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtdate.Text = Date.Today

    End Sub

    Private Sub btncart_Click(sender As Object, e As EventArgs) Handles btncart.Click
        If txtname.Text.Trim = "" Then txtname.Focus() : Exit Sub
        If txtmobile.Text.Trim = "" Then txtmobile.Focus() : Exit Sub
        MaxID = ""
        qry = "insert into tblSaleMaster (Customer,Mobile,Date) values('" & txtname.Text & "','" & txtmobile.Text & "','" & txtdate.Text & "')"
        i = InsertData(qry)
        If i >= 1 Then
            MsgBox("Add items into cart", MsgBoxStyle.Information)
            Panel1.Visible = True
            bindcmb()
            getMaxID()
        Else
            MsgBox("Failed", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub bindcmb()
        qry = "select * from tblItem with (NOlock)"
        Try
            If con.State = 1 Then con.Close()
            con.Open()
            cmd = New SqlCommand(qry, con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim ds1 As DataSet = New DataSet()
            sda.Fill(ds1, "tblItem")
            Dim a As Integer = ds1.Tables("tblItem").Rows.Count - 1
            Dim i As Integer = 0
            cmbItem.Items.Clear()

            For i = 0 To a
                cmbItem.Items.Add(ds1.Tables("tblItem").Rows(i)(1).ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("can not open Connection! ")
        End Try
    End Sub

    Private Sub cmbItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbItem.SelectedIndexChanged
        If con.State = 1 Then con.Close()
        txtQty.Clear()
        btnMinus.Enabled = False
        Try
            cmd = New SqlCommand("select * from [tblItem] with (nolock) where ItemTitle='" & cmbItem.Text & "'", con)
            con.Open()

            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                txtCost.Text = dr1.Item("Cost").ToString
                cost = dr1.Item("Cost").ToString
                txtQty.Focus()
            Else
                MsgBox("Price Not Found")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged
        If txtQty.Text = "" Then
            'MsgBox("Enter Quantity")
            txtCost.Text = cost
        Else
            txtCost.Text = Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtCost.Text)
            txtCost.ReadOnly = True
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If txtQty.Text = "" Then txtQty.Focus() : Exit Sub
        btnMinus.Enabled = False
        Checkstock()
        If Val(qty) >= Val(txtQty.Text) Then
            qry = "insert into tblSaleTemp (ID,ItemName,Quantity,TotalCost) values('" & MaxID & "','" & cmbItem.Text & "','" & txtQty.Text & "','" & txtCost.Text & "')"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("1 items Added in cart", MsgBoxStyle.Information)
                UpdateQty()
                showItemGrid()
            Else
                MsgBox("Failed", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Items Is Out Of Stock...", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub Checkstock()
        If con.State = 1 Then con.Close()
        Try
            cmd = New SqlCommand("select * from [tblStock] with (nolock) where ItemTitle='" & cmbItem.Text & "'", con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                qty = dr1.Item("Quantity").ToString
            Else
                MsgBox("Data Not Available")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub UpdateQty()
        If con.State = 1 Then con.Close()
        If Val(qty) >= Val(txtQty.Text) Then
            qty2 = Val(qty) - Val(txtQty.Text)
            qry = "Update tblStock set Quantity= '" & qty2 & "' where ItemTitle='" & cmbItem.Text & "'"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Items Qty Updated")
            Else
                MsgBox("Failed", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Items Is Out Of Stock...", MsgBoxStyle.Critical)
        End If
    End Sub
    Public Sub showItemGrid()
        If con.State = 1 Then con.Close()
        ds.Dispose()
        If MaxID = "" Then
            'Exit Sub
        End If
        'DataGridView1.Rows.Clear()
        qry = "select * from tblSaleTemp with (nolock) where ID='" & MaxID & "'"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
            CalTotal()
        Else

            MessageBox.Show("Data Not Found...")
        End If
    End Sub
    Public Sub CalTotal()
        Dim totamount As Integer = 0
        Dim a As Integer = 0
        For a = 0 To DataGridView1.Rows.Count - 1
            totamount += DataGridView1.Rows(a).Cells("TotalCost").Value
        Next
        txttotal.Text = totamount
    End Sub
    Public Sub getMaxID()
        MaxID = ""
        If con.State = 1 Then con.Close()
        Try
            cmd = New SqlCommand("select top 1 MAX(ID) as maxID from tblSaleMaster", con)
            con.Open()
            Dim dr1 As SqlDataReader = cmd.ExecuteReader()
            If dr1.Read() Then
                qty = dr1.Item("maxID").ToString
            Else

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If con.State = 1 Then con.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        qry = "Update tblSaleMaster set TotalSale = '" & txttotal.Text & "' where ID='" & MaxID & "' "
        i = InsertData(qry)
        If i > 1 Then
            MsgBox("SuccessFully Order Done..", MsgBoxStyle.Information)
            txtname.Clear()
            txtmobile.Clear()
            cmbItem.Text = ""
            txtQty.Clear()
            txtCost.Text = "0"
            txtrece.Text = "0"
            txtdue.Text = "0"
            txtch.Text = "0"
            Panel1.Visible = False
            txtname.Focus()
            ds.Clear()
            DataGridView1.DataSource = ds
            DataGridView1.DataSource = Nothing
            'DataGridView1.Rows.Clear
        Else
            MsgBox("Failed", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub txtrece_TextChanged(sender As Object, e As EventArgs) Handles txtrece.TextChanged
        If txtrece.Text <> "" Then
            If Val(txtrece.Text) > Val(txttotal.Text) Then
                txtch.Text = Val(txtrece.Text) - Val(txttotal.Text)
                txtdue.Text = 0
            ElseIf Val(txtrece.Text) < Val(txttotal.Text) Then
                txtdue.Text = Val(txttotal.Text) - Val(txtrece.Text)
                txtch.Text = 0
            End If
        Else
            txtdue.Text = 0
            txtch.Text = 0
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                i = DataGridView1.CurrentRow.Index
                _id = DataGridView1.Item(0, i).Value
                Me.cmbItem.Text = DataGridView1.Item(2, i).Value
                Me.txtQty.Text = DataGridView1.Item(3, i).Value
                Me.txtCost.Text = DataGridView1.Item(3, i).Value
                btnMinus.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If _id = "" Then
            MsgBox("select any item that you want to delete", MsgBoxStyle.Critical)
        Else
            Try
                qry = "Delete from tblSaleTemp where SaleID='" & _id & "'"
                i = InsertData(qry)
                If i > 0 Then
                    qry = "Select * from tblSaleTemp with (nolock) where ID='" & MaxID & "'"
                    con.Open()
                    ds = FetchData(qry)
                    If ds.Tables(0).Rows.Count > 0 Then
                        DataGridView1.DataSource = ds.Tables(0)
                        CalTotal()
                    Else
                        MessageBox.Show("Data Not Found...", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    MsgBox("Delete Item From Cart?", MsgBoxStyle.Exclamation)
                Else

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        btnMinus.Enabled = False
    End Sub
End Class