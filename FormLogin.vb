Imports System.Data.SqlClient
Public Class Formlogin
    Private Sub Formlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Btnlogin_Click(sender As Object, e As EventArgs) Handles Btnlogin.Click
        If Len(Trim(txtUsername.Text)) = 0 Then
            MessageBox.Show("Please Enter Username", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsername.Clear()
            txtUsername.Focus()
            Exit Sub
        ElseIf Len(Trim(TxtPass.Text)) = 0 Then
            MessageBox.Show("Please Enter Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPass.Clear()
            TxtPass.Focus()
            Exit Sub

        End If
        'data code
        Try
            If con.State = 1 Then con.Close()
            cmd = New SqlCommand("select UserName,Password,UserType from tblLogin with(nolock) where UserName=@U and Password=@P and UserType=@UT", con)
            cmd.Parameters.AddWithValue("@U", txtUsername.Text)
            cmd.Parameters.AddWithValue("@P", TxtPass.Text)
            cmd.Parameters.AddWithValue("@UT", cmbUsertype.Text)
            cmd.Connection = con
            cmd.Connection.Open()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                username1 = txtUsername.Text
                utype = cmbUsertype.Text
                pass = TxtPass.Text
                con.Close()

                If (utype = "Admin" Or utype = "Manager") Then
                    TxtPass.Clear()
                    txtUsername.Clear()
                    Me.Hide()
                    Loading.Show()
                    '       MDIParent1.Show()

                ElseIf (utype = "User") Then
                    TxtPass.Clear()
                    txtUsername.Clear()
                    Me.Hide()
                    Loading.Show()
                    'MDIParent1.Show()
                End If
            Else
                MessageBox.Show("UserName And Password Are Not Valid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            If con.State = 1 Then con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As Integer
        result = MsgBox("Do you want to exit", MsgBoxStyle.YesNo)
        If result = DialogResult.Yes Then
            Me.txtUsername.Clear()
            Me.TxtPass.Clear()
            Me.cmbUsertype.Items.Clear()
            Me.Dispose()
            Exit Sub
            Application.Exit()
            Me.Close()
        End If
    End Sub

    Private Sub cmbUsertype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsertype.SelectedIndexChanged

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged

    End Sub
End Class