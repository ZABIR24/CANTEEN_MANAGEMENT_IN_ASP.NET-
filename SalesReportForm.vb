Public Class SalesReportForm
    Private Sub SalesReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBCanteenVBDataSet.tblSaleTemp' table. You can move, or remove it, as needed.
        Me.TblSaleTempTableAdapter.Fill(Me.DBCanteenVBDataSet.tblSaleTemp)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class