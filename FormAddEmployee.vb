Imports System.Data.SqlClient
Public Class FormAddEmployee
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If txtname.Text = "" Then txtname.Focus() : Exit Sub
        If txtAddress.Text = "" Then txtAddress.Focus() : Exit Sub
        If txtCity.Text = "" Then txtCity.Focus() : Exit Sub
        If txtCountry.Text = "" Then txtCountry.Focus() : Exit Sub
        If txtDOB.Text = "" Then txtDOB.Focus() : Exit Sub
        If txtEmail.Text = "" Then txtEmail.Focus() : Exit Sub
        If txtMobile.Text = "" Then txtMobile.Focus() : Exit Sub
        If txtPIN.Text = "" Then txtPIN.Focus() : Exit Sub
        If txtSalary.Text = "" Then txtSalary.Focus() : Exit Sub
        If txtState.Text = "" Then txtState.Focus() : Exit Sub
        If cmbDesignation.Text = "" Then cmbDesignation.Focus() : Exit Sub

        Try

            qry = "Insert into tblEmployeeMgt (EmpName,Designation,Salary,Mobile,Email,DOB,Address,City,State,PINNo,Country) values('" & txtname.Text & "','" & cmbDesignation.Text & "','" & txtSalary.Text & "','" & txtMobile.Text & "','" & txtEmail.Text & "','" & txtDOB.Text & "','" & txtAddress.Text & "','" & txtCity.Text & "','" & txtState.Text & "','" & txtPIN.Text & "','" & txtCountry.Text & "')"
            cmd = New SqlCommand(qry, con)
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            i = cmd.ExecuteNonQuery()
            con.Close()
            If (i > 0) Then
                MsgBox("Success", MsgBoxStyle.Information)
                LoadDatainGrid()
                clr()
            Else
                MsgBox("Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LoadDatainGrid()

        If con.State = 1 Then con.Close()
        qry = "select * from tblEmployeeMgt  with(nolock)"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)


        End If

    End Sub

    Private Sub FormAddEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblEid.Visible = False
        BindCombo()
        LoadDatainGrid()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If (e.RowIndex >= 0) Then
            Try
                lblEid.Visible = True
                i = DataGridView1.CurrentRow.Index
                Me.lblEid.Text = DataGridView1.Item(0, i).Value
                Me.txtname.Text = DataGridView1.Item(1, i).Value
                Me.cmbDesignation.Text = DataGridView1.Item(2, i).Value
                Me.txtSalary.Text = DataGridView1.Item(3, i).Value
                Me.txtMobile.Text = DataGridView1.Item(4, i).Value
                Me.txtEmail.Text = DataGridView1.Item(5, i).Value
                Me.txtDOB.Text = DataGridView1.Item(6, i).Value
                Me.txtAddress.Text = DataGridView1.Item(7, i).Value
                Me.txtCity.Text = DataGridView1.Item(8, i).Value
                Me.txtState.Text = DataGridView1.Item(9, i).Value
                Me.txtPIN.Text = DataGridView1.Item(10, i).Value
                Me.txtCountry.Text = DataGridView1.Item(11, i).Value
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If txtname.Text = "" Then txtname.Focus() : Exit Sub
        If txtAddress.Text = "" Then txtAddress.Focus() : Exit Sub
        If txtCity.Text = "" Then txtCity.Focus() : Exit Sub
        If txtCountry.Text = "" Then txtCountry.Focus() : Exit Sub
        If txtDOB.Text = "" Then txtDOB.Focus() : Exit Sub
        If txtEmail.Text = "" Then txtEmail.Focus() : Exit Sub
        If txtMobile.Text = "" Then txtMobile.Focus() : Exit Sub
        If txtPIN.Text = "" Then txtPIN.Focus() : Exit Sub
        If txtSalary.Text = "" Then txtSalary.Focus() : Exit Sub
        If txtState.Text = "" Then txtState.Focus() : Exit Sub

        Try
            qry = "UpdatetblEmployeeMgt set EmpName='" & txtname.Text & "',Designation='" & cmbDesignation.Text & "',Salary='" & txtSalary.Text & "',Mobile='" & txtMobile.Text & "',Email='" & txtEmail.Text & "',DOB='" & txtDOB.Text & "',Address='" & txtAddress.Text & "',City='" & txtCity.Text & "',State='" & txtState.Text & "',PINNo='" & txtPIN.Text & "',Country='" & txtCountry.Text & "' where EmpID=" & lblEid.Text & ""
            i = InsertData(qry)
            If (i > 0) Then
                MsgBox("Updated Successfully", MsgBoxStyle.Information)
                LoadDatainGrid()
                clr()
            Else
                MsgBox("Update Failed", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim result As Integer = MsgBox("Do you want to Delete Employee?", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            If (lblEid.Text = "") Then
                MsgBox("Select any row from gridview for delete", MsgBoxStyle.Critical)
            Else
                Try
                    qry = "Delete from tblEmployeeMgt where EmpID=" & lblEid.Text & ""
                    i = InsertData(qry)
                    If (i > 0) Then
                        MsgBox("Deleted Successfully", MsgBoxStyle.Information)
                        LoadDatainGrid()
                        clr()
                    Else
                        MsgBox("Deleted cmd Failed", MsgBoxStyle.Critical)
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub
    Private Sub clr()
        txtname.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtCountry.Clear()
        txtDOB.Clear()
        txtEmail.Clear()
        txtMobile.Clear()
        txtPIN.Clear()
        txtSalary.Clear()
        txtState.Clear()
        txtSearch.Clear()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lblEid.Text = ""
        lblEid.Visible = False

        clr()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadDatainGrid()
        If txtSearch.Text = "" Then
            MsgBox("Enter Employee Name", MsgBoxStyle.Critical)
            LoadDatainGrid()
            Exit Sub
        Else
            qry = "Select * from tblEmployeeMgt with (nolock)"
            qry &= "where EmpName LIKE'%' + '" & txtSearch.Text & "'+'%' or City LIKE'%' + '" & txtSearch.Text & "'+'%'"
            ds = FetchData(qry)
            If (DataGridView1.Rows.Count > 0) Then
                clr()
                DataGridView1.DataSource = ds.Tables(0)
            Else
                clr()
                MsgBox("Record not Found...Try again", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub BindCombo()
        cmbDesignation.Items.Clear()
        ds.Clear()
        qry = "select * from tblDesignation with (nolock)"
        ds = FetchData(qry)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim a As Integer = ds.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            For i = 0 To a
                cmbDesignation.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
            Next
        Else
            MsgBox("No Record Found", MsgBoxStyle.Exclamation)

        End If
    End Sub
End Class