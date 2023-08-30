<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MasterEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemMangementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Lime
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterEntryToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.ItemMangementToolStripMenuItem, Me.StockManagementToolStripMenuItem, Me.SalesManagementToolStripMenuItem, Me.ChangePasswordToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1281, 36)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'MasterEntryToolStripMenuItem
        '
        Me.MasterEntryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AAToolStripMenuItem, Me.BBToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MasterEntryToolStripMenuItem.Name = "MasterEntryToolStripMenuItem"
        Me.MasterEntryToolStripMenuItem.Size = New System.Drawing.Size(136, 32)
        Me.MasterEntryToolStripMenuItem.Text = "Master Entry"
        '
        'AAToolStripMenuItem
        '
        Me.AAToolStripMenuItem.Name = "AAToolStripMenuItem"
        Me.AAToolStripMenuItem.Size = New System.Drawing.Size(245, 32)
        Me.AAToolStripMenuItem.Text = "Add Designation"
        '
        'BBToolStripMenuItem
        '
        Me.BBToolStripMenuItem.Name = "BBToolStripMenuItem"
        Me.BBToolStripMenuItem.Size = New System.Drawing.Size(245, 32)
        Me.BBToolStripMenuItem.Text = "Add ItemType"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(245, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(112, 32)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddEmployeeToolStripMenuItem
        '
        Me.AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        Me.AddEmployeeToolStripMenuItem.Size = New System.Drawing.Size(226, 32)
        Me.AddEmployeeToolStripMenuItem.Text = "Add Employee"
        '
        'ItemMangementToolStripMenuItem
        '
        Me.ItemMangementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemsToolStripMenuItem})
        Me.ItemMangementToolStripMenuItem.Name = "ItemMangementToolStripMenuItem"
        Me.ItemMangementToolStripMenuItem.Size = New System.Drawing.Size(176, 32)
        Me.ItemMangementToolStripMenuItem.Text = "Item Mangement"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(187, 32)
        Me.AddItemsToolStripMenuItem.Text = "Add Items"
        '
        'StockManagementToolStripMenuItem
        '
        Me.StockManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStockToolStripMenuItem})
        Me.StockManagementToolStripMenuItem.Name = "StockManagementToolStripMenuItem"
        Me.StockManagementToolStripMenuItem.Size = New System.Drawing.Size(195, 32)
        Me.StockManagementToolStripMenuItem.Text = "Stock Management"
        '
        'AddStockToolStripMenuItem
        '
        Me.AddStockToolStripMenuItem.Name = "AddStockToolStripMenuItem"
        Me.AddStockToolStripMenuItem.Size = New System.Drawing.Size(188, 32)
        Me.AddStockToolStripMenuItem.Text = "Add Stock"
        '
        'SalesManagementToolStripMenuItem
        '
        Me.SalesManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesFormToolStripMenuItem, Me.SalesReportToolStripMenuItem})
        Me.SalesManagementToolStripMenuItem.Name = "SalesManagementToolStripMenuItem"
        Me.SalesManagementToolStripMenuItem.Size = New System.Drawing.Size(191, 32)
        Me.SalesManagementToolStripMenuItem.Text = "Sales Management"
        '
        'SalesFormToolStripMenuItem
        '
        Me.SalesFormToolStripMenuItem.Name = "SalesFormToolStripMenuItem"
        Me.SalesFormToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.SalesFormToolStripMenuItem.Text = "Sales Form"
        '
        'SalesReportToolStripMenuItem
        '
        Me.SalesReportToolStripMenuItem.Name = "SalesReportToolStripMenuItem"
        Me.SalesReportToolStripMenuItem.Size = New System.Drawing.Size(224, 32)
        Me.SalesReportToolStripMenuItem.Text = "Sales Report"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(178, 32)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 722)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1281, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1281, 748)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemMangementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesReportToolStripMenuItem As ToolStripMenuItem
End Class
