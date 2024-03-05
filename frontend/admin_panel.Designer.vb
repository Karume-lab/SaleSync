<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class admin_panel
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.All_entities1 = New frontend.all_entities()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(995, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.ListAllToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(54, 26)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'ListAllToolStripMenuItem
        '
        Me.ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        Me.ListAllToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.ListAllToolStripMenuItem.Text = "View All"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem1, Me.ListAllToolStripMenuItem1})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(80, 26)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'AddNewToolStripMenuItem1
        '
        Me.AddNewToolStripMenuItem1.Name = "AddNewToolStripMenuItem1"
        Me.AddNewToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.AddNewToolStripMenuItem1.Text = "Add New"
        '
        'ListAllToolStripMenuItem1
        '
        Me.ListAllToolStripMenuItem1.Name = "ListAllToolStripMenuItem1"
        Me.ListAllToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ListAllToolStripMenuItem1.Text = "View All"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateSalesReportToolStripMenuItem, Me.ViewAllToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 26)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'GenerateSalesReportToolStripMenuItem
        '
        Me.GenerateSalesReportToolStripMenuItem.Name = "GenerateSalesReportToolStripMenuItem"
        Me.GenerateSalesReportToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.GenerateSalesReportToolStripMenuItem.Text = "Generate Sales Report"
        '
        'ViewAllToolStripMenuItem
        '
        Me.ViewAllToolStripMenuItem.Name = "ViewAllToolStripMenuItem"
        Me.ViewAllToolStripMenuItem.Size = New System.Drawing.Size(239, 26)
        Me.ViewAllToolStripMenuItem.Text = "View All"
        '
        'All_entities1
        '
        Me.All_entities1.BackColor = System.Drawing.SystemColors.Control
        Me.All_entities1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.All_entities1.Location = New System.Drawing.Point(0, 30)
        Me.All_entities1.Name = "All_entities1"
        Me.All_entities1.Size = New System.Drawing.Size(995, 404)
        Me.All_entities1.TabIndex = 1
        '
        'admin_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 434)
        Me.Controls.Add(Me.All_entities1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "admin_panel"
        Me.Text = "Admin Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StaffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GenerateSalesReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents All_entities1 As all_entities
End Class
