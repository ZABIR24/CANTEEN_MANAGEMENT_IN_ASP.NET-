
Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Public connectionstring As String = "Data Source =localhost\SQLEXPRESS;Initial Catalog = DBCanteenVB; Integrated Security=true;"
    Public con As New SqlConnection(connectionstring)
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public username1 As String = ""
    Public utype As String = ""
    Public pass As String = ""
    Public qry As String = ""
    Public i As Integer = 0
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public _id As String = ""

    'Search gridview Function
    Public Function FetchData(ByVal qry As String) As DataSet
        If con.State = 1 Then con.Close()
        con.Open()
        da = New SqlDataAdapter(qry, con)
        ds = New DataSet
        da.Fill(ds)
        Return ds
        con.Close()
    End Function

    'Insert Update Delete Function.
    Public Function InsertData(ByVal qry As String) As Integer
        If con.State = 1 Then con.Close()
        cmd = New SqlCommand(qry, con)
        cmd.Connection.Open()
        i = cmd.ExecuteNonQuery()
        If con.State = 1 Then con.Close()
        Return i
    End Function

End Module
