<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_panel
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateSalesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StaffToolStripMenuItem
        '
        Me.StaffToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.ListAllToolStripMenuItem})
        Me.StaffToolStripMenuItem.Name = "StaffToolStripMenuItem"
        Me.StaffToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.StaffToolStripMenuItem.Text = "Staff"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem1, Me.ListAllToolStripMenuItem1})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProductsToolStripMenuItem.Text = "Products"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateSalesReportToolStripMenuItem, Me.ViewAllToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'ListAllToolStripMenuItem
        '
        Me.ListAllToolStripMenuItem.Name = "ListAllToolStripMenuItem"
        Me.ListAllToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ListAllToolStripMenuItem.Text = "View All"
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(777, 412)
        Me.Panel1.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(22, 13)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(655, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(683, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 22)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(22, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(741, 356)
        Me.Panel2.TabIndex = 4
        '
        'admin_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "admin_panel"
        Me.Text = "Admin Panel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
