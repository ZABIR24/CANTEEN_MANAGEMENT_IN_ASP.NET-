Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.Net.NetworkInformation

Public Class FormItemEntry
    Private Sub FormItemEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindCombo()
        LoadDatainGrid()
    End Sub
    Private Sub BindCombo()
        cmbItemType.Items.Clear()
        ds.Clear()
        qry = "select * from tblItemType with (nolock)"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                cmbItemType.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)

        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If con.State = 1 Then con.Close()

        If txtTitle.Text = "" Then txtTitle.Focus() : Exit Sub
        If txtCost.Text = "" Then txtCost.Focus() : Exit Sub
        If txtDesc.Text = "" Then txtDesc.Focus() : Exit Sub
        If cmbItemType.Text = "" Then cmbItemType.Focus() : Exit Sub

        Try
            qry = "insert into tblItem (ItemTitle,ItemType,Cost,ItemDesc) values('" & txtTitle.Text & "','" & cmbItemType.Text & "','" & txtCost.Text & "','" & txtDesc.Text & "')"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Data Inserted Successfully")
                LoadDatainGrid()

            Else
                MsgBox("Failed")
            End If
            clr()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub LoadDatainGrid()

        If con.State = 1 Then con.Close()
        qry = "select * from tblItem  with(nolock)"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)


        End If

    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                i = DataGridView1.CurrentRow.Index
                _id = DataGridView1.Item(0, i).Value
                Me.txtTitle.Text = DataGridView1.Item(1, i).Value
                Me.cmbItemType.Text = DataGridView1.Item(2, i).Value
                Me.txtCost.Text = DataGridView1.Item(3, i).Value
                Me.txtDesc.Text = DataGridView1.Item(4, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        If con.State = 1 Then con.Close()

        If txtTitle.Text = "" Then txtTitle.Focus() : Exit Sub
        If txtCost.Text = "" Then txtCost.Focus() : Exit Sub
        If txtDesc.Text = "" Then txtDesc.Focus() : Exit Sub
        If cmbItemType.Text = "" Then cmbItemType.Focus() : Exit Sub

        Try
            qry = "update tblItem set ItemTitle='" & txtTitle.Text & "',ItemType='" & cmbItemType.Text & "',Cost='" & txtCost.Text & "',ItemDesc='" & txtDesc.Text & "' where ItemID=" & _id & ""
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Data Updated Successfully")
                LoadDatainGrid()

            Else
                MsgBox("Failed")
            End If
            clr()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As Integer = MsgBox("Do you want to Delete This Item?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then

            If _id = "" Then
                MsgBox("Select any row from gridview", MsgBoxStyle.Critical)
            Else
                Try
                    qry = "Delete from tblItem where ItemID=" & _id & ""
                    i = InsertData(qry)
                    If (i > 0) Then
                        MessageBox.Show("Deleted Successfully")

                    Else
                        MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    LoadDatainGrid()
                    clr()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub clr()
        txtTitle.Clear()
        txtCost.Clear()
        txtDesc.Clear()
        cmbItemType.Text = ""
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        clr()
    End Sub
End Class