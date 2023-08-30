Imports System.Data.SqlClient

Public Class FormAddDesignation
    Private Sub FormAddDesignation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDatainGrid()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If con.State = 1 Then con.Close()
        If txtDesignation.Text = "" Then txtDesignation.Focus() : Exit Sub
        Try
            qry = "insert into tblDesignation (Designation) values('" & txtDesignation.Text & "')"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Data Inserted Successfully")
                LoadDatainGrid()
                txtDesignation.Clear()
                txtDesignation.Focus()
            Else
                MsgBox("Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If con.State = 1 Then con.Close()
        If txtDesignation.Text = "" Then txtDesignation.Focus() : Exit Sub
        If _id = "" Then MsgBox("Select Any For Update") : Exit Sub
        Try
            qry = "update tblDesignation set Designation='" & txtDesignation.Text & "' where ID='" & _id & "'"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Data Updated Successfully", MsgBoxStyle.Information)
                LoadDatainGrid()
                txtDesignation.Clear()
                txtDesignation.Focus()
            Else
                MsgBox("Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If con.State = 1 Then con.Close()
        If txtDesignation.Text = "" Then txtDesignation.Focus() : Exit Sub
        If _id = "" Then MsgBox("Select Any For Delete") : Exit Sub
        Try
            qry = "Delete from tblDesignation where ID='" & _id & "'"
            i = InsertData(qry)
            If i >= 1 Then
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Information)
                LoadDatainGrid()
                txtDesignation.Clear()
                txtDesignation.Focus()
            Else
                MsgBox("Failed")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Dispose()
    End Sub
    Public Sub LoadDatainGrid()
        If con.State = 1 Then con.Close()
        ds.Clear()
        DataGridView1.DataSource = ds
        DataGridView1.DataSource = Nothing
        qry = "select * from tblDesignation with (nolock)"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MessageBox.Show("Data Not Found......")
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            Try
                i = DataGridView1.CurrentRow.Index
                _id = DataGridView1.Item(0, i).Value
                Me.txtDesignation.Text = DataGridView1.Item(1, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class