<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DBCanteenVBDataSet = New CanteenProject.DBCanteenVBDataSet()
        Me.TblSaleTempBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSaleTempTableAdapter = New CanteenProject.DBCanteenVBDataSetTableAdapters.tblSaleTempTableAdapter()
        CType(Me.DBCanteenVBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSaleTempBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TblSaleTempBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "CanteenProject.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DBCanteenVBDataSet
        '
        Me.DBCanteenVBDataSet.DataSetName = "DBCanteenVBDataSet"
        Me.DBCanteenVBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSaleTempBindingSource
        '
        Me.TblSaleTempBindingSource.DataMember = "tblSaleTemp"
        Me.TblSaleTempBindingSource.DataSource = Me.DBCanteenVBDataSet
        '
        'TblSaleTempTableAdapter
        '
        Me.TblSaleTempTableAdapter.ClearBeforeFill = True
        '
        'SalesReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "SalesReportForm"
        Me.Text = "SalesReportForm"
        CType(Me.DBCanteenVBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSaleTempBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DBCanteenVBDataSet As DBCanteenVBDataSet
    Friend WithEvents TblSaleTempBindingSource As BindingSource
    Friend WithEvents TblSaleTempTableAdapter As DBCanteenVBDataSetTableAdapters.tblSaleTempTableAdapter
End Class
