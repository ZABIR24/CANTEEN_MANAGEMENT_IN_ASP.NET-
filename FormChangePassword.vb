Imports System.Data.SqlClient
Public Class FormChangePassword
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub FormChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtnewpass.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If con.State = 1 Then con.Close()
        If txtoldpass.Text = "" Then txtoldpass.Focus() : Exit Sub
        If txtnewpass.Text = "" Then txtnewpass.Focus() : Exit Sub
        If txtconfirmpass.Text = "" Then txtconfirmpass.Focus() : Exit Sub
        If txtoldpass.Text = Module1.pass Then
            If txtnewpass.Text = txtconfirmpass.Text Then
                Try
                    qry = "update tblLogin set Password='" & txtnewpass.Text & "' where Username= '" & Module1.username1 & "'"
                    i = InsertData(qry)
                    If i >= 1 Then
                        MsgBox("Data Inserted Successfully")
                        txtconfirmpass.Clear()
                        txtnewpass.Clear()
                        txtoldpass.Clear()
                        Module1.username1 = ""
                        Me.Close()
                        MDIParent1.Hide()
                        Formlogin.Show()
                    Else
                        MsgBox("Failed")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Else
            MsgBox("Old Password |NOt Matched", MsgBoxStyle.Critical)
            Me.Dispose()
        End If
    End Sub
End Class