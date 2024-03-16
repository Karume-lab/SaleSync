<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.AdminTabControl = New System.Windows.Forms.TabControl()
        Me.ProductsTab = New System.Windows.Forms.TabPage()
        Me.AdminBody = New System.Windows.Forms.Panel()
        Me.ProductList = New System.Windows.Forms.DataGridView()
        Me.ProductsAdminSidePanel = New System.Windows.Forms.Panel()
        Me.AdminSidebarButtons = New System.Windows.Forms.Panel()
        Me.AddProduct = New System.Windows.Forms.Button()
        Me.ListProducts = New System.Windows.Forms.Button()
        Me.ProductsSearchBar = New System.Windows.Forms.Panel()
        Me.ProductsSearchButton = New System.Windows.Forms.Button()
        Me.ProductsSearchInput = New System.Windows.Forms.TextBox()
        Me.StaffTab = New System.Windows.Forms.TabPage()
        Me.StaffList = New System.Windows.Forms.DataGridView()
        Me.StaffAdminSidePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AddStaff = New System.Windows.Forms.Button()
        Me.ListStaff = New System.Windows.Forms.Button()
        Me.StaffSearchBar = New System.Windows.Forms.Panel()
        Me.StaffSearchButton = New System.Windows.Forms.Button()
        Me.StaffSearchInput = New System.Windows.Forms.TextBox()
        Me.ReportsTab = New System.Windows.Forms.TabPage()
        Me.AdminTabControl.SuspendLayout()
        Me.ProductsTab.SuspendLayout()
        Me.AdminBody.SuspendLayout()
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsAdminSidePanel.SuspendLayout()
        Me.AdminSidebarButtons.SuspendLayout()
        Me.ProductsSearchBar.SuspendLayout()
        Me.StaffTab.SuspendLayout()
        CType(Me.StaffList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StaffAdminSidePanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StaffSearchBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'AdminTabControl
        '
        Me.AdminTabControl.Controls.Add(Me.ProductsTab)
        Me.AdminTabControl.Controls.Add(Me.StaffTab)
        Me.AdminTabControl.Controls.Add(Me.ReportsTab)
        Me.AdminTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminTabControl.Location = New System.Drawing.Point(0, 0)
        Me.AdminTabControl.Name = "AdminTabControl"
        Me.AdminTabControl.SelectedIndex = 0
        Me.AdminTabControl.Size = New System.Drawing.Size(800, 450)
        Me.AdminTabControl.TabIndex = 0
        '
        'ProductsTab
        '
        Me.ProductsTab.Controls.Add(Me.AdminBody)
        Me.ProductsTab.Controls.Add(Me.ProductsAdminSidePanel)
        Me.ProductsTab.Controls.Add(Me.ProductsSearchBar)
        Me.ProductsTab.Location = New System.Drawing.Point(4, 25)
        Me.ProductsTab.Name = "ProductsTab"
        Me.ProductsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ProductsTab.Size = New System.Drawing.Size(792, 421)
        Me.ProductsTab.TabIndex = 0
        Me.ProductsTab.Text = "PRODUCTS"
        Me.ProductsTab.UseVisualStyleBackColor = True
        '
        'AdminBody
        '
        Me.AdminBody.Controls.Add(Me.ProductList)
        Me.AdminBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminBody.Location = New System.Drawing.Point(219, 33)
        Me.AdminBody.Name = "AdminBody"
        Me.AdminBody.Size = New System.Drawing.Size(570, 385)
        Me.AdminBody.TabIndex = 3
        '
        'ProductList
        '
        Me.ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductList.Location = New System.Drawing.Point(6, 6)
        Me.ProductList.Name = "ProductList"
        Me.ProductList.RowHeadersWidth = 51
        Me.ProductList.RowTemplate.Height = 24
        Me.ProductList.Size = New System.Drawing.Size(559, 374)
        Me.ProductList.TabIndex = 0
        '
        'ProductsAdminSidePanel
        '
        Me.ProductsAdminSidePanel.Controls.Add(Me.AdminSidebarButtons)
        Me.ProductsAdminSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ProductsAdminSidePanel.Location = New System.Drawing.Point(3, 33)
        Me.ProductsAdminSidePanel.Name = "ProductsAdminSidePanel"
        Me.ProductsAdminSidePanel.Size = New System.Drawing.Size(216, 385)
        Me.ProductsAdminSidePanel.TabIndex = 2
        '
        'AdminSidebarButtons
        '
        Me.AdminSidebarButtons.Controls.Add(Me.AddProduct)
        Me.AdminSidebarButtons.Controls.Add(Me.ListProducts)
        Me.AdminSidebarButtons.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSidebarButtons.Location = New System.Drawing.Point(0, 0)
        Me.AdminSidebarButtons.Name = "AdminSidebarButtons"
        Me.AdminSidebarButtons.Size = New System.Drawing.Size(216, 74)
        Me.AdminSidebarButtons.TabIndex = 0
        '
        'AddProduct
        '
        Me.AddProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddProduct.Location = New System.Drawing.Point(0, 35)
        Me.AddProduct.Name = "AddProduct"
        Me.AddProduct.Size = New System.Drawing.Size(216, 36)
        Me.AddProduct.TabIndex = 1
        Me.AddProduct.Text = "Add Product"
        Me.AddProduct.UseVisualStyleBackColor = True
        '
        'ListProducts
        '
        Me.ListProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListProducts.Location = New System.Drawing.Point(0, 0)
        Me.ListProducts.Name = "ListProducts"
        Me.ListProducts.Size = New System.Drawing.Size(216, 35)
        Me.ListProducts.TabIndex = 0
        Me.ListProducts.Text = "List of Products"
        Me.ListProducts.UseVisualStyleBackColor = True
        '
        'ProductsSearchBar
        '
        Me.ProductsSearchBar.Controls.Add(Me.ProductsSearchButton)
        Me.ProductsSearchBar.Controls.Add(Me.ProductsSearchInput)
        Me.ProductsSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductsSearchBar.Location = New System.Drawing.Point(3, 3)
        Me.ProductsSearchBar.Name = "ProductsSearchBar"
        Me.ProductsSearchBar.Size = New System.Drawing.Size(786, 30)
        Me.ProductsSearchBar.TabIndex = 1
        '
        'ProductsSearchButton
        '
        Me.ProductsSearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductsSearchButton.Location = New System.Drawing.Point(444, 3)
        Me.ProductsSearchButton.Name = "ProductsSearchButton"
        Me.ProductsSearchButton.Size = New System.Drawing.Size(100, 23)
        Me.ProductsSearchButton.TabIndex = 0
        Me.ProductsSearchButton.Text = "SEARCH"
        Me.ProductsSearchButton.UseVisualStyleBackColor = True
        '
        'ProductsSearchInput
        '
        Me.ProductsSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductsSearchInput.Location = New System.Drawing.Point(225, 3)
        Me.ProductsSearchInput.Name = "ProductsSearchInput"
        Me.ProductsSearchInput.Size = New System.Drawing.Size(213, 22)
        Me.ProductsSearchInput.TabIndex = 0
        '
        'StaffTab
        '
        Me.StaffTab.Controls.Add(Me.StaffList)
        Me.StaffTab.Controls.Add(Me.StaffAdminSidePanel)
        Me.StaffTab.Controls.Add(Me.StaffSearchBar)
        Me.StaffTab.Location = New System.Drawing.Point(4, 25)
        Me.StaffTab.Name = "StaffTab"
        Me.StaffTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StaffTab.Size = New System.Drawing.Size(792, 421)
        Me.StaffTab.TabIndex = 1
        Me.StaffTab.Text = "STAFF"
        Me.StaffTab.UseVisualStyleBackColor = True
        '
        'StaffList
        '
        Me.StaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StaffList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StaffList.Location = New System.Drawing.Point(219, 33)
        Me.StaffList.Name = "StaffList"
        Me.StaffList.RowHeadersWidth = 51
        Me.StaffList.RowTemplate.Height = 24
        Me.StaffList.Size = New System.Drawing.Size(570, 385)
        Me.StaffList.TabIndex = 3
        '
        'StaffAdminSidePanel
        '
        Me.StaffAdminSidePanel.Controls.Add(Me.Panel2)
        Me.StaffAdminSidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.StaffAdminSidePanel.Location = New System.Drawing.Point(3, 33)
        Me.StaffAdminSidePanel.Name = "StaffAdminSidePanel"
        Me.StaffAdminSidePanel.Size = New System.Drawing.Size(216, 385)
        Me.StaffAdminSidePanel.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AddStaff)
        Me.Panel2.Controls.Add(Me.ListStaff)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(216, 74)
        Me.Panel2.TabIndex = 0
        '
        'AddStaff
        '
        Me.AddStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.AddStaff.Location = New System.Drawing.Point(0, 35)
        Me.AddStaff.Name = "AddStaff"
        Me.AddStaff.Size = New System.Drawing.Size(216, 36)
        Me.AddStaff.TabIndex = 1
        Me.AddStaff.Text = "Add Staff"
        Me.AddStaff.UseVisualStyleBackColor = True
        '
        'ListStaff
        '
        Me.ListStaff.Dock = System.Windows.Forms.DockStyle.Top
        Me.ListStaff.Location = New System.Drawing.Point(0, 0)
        Me.ListStaff.Name = "ListStaff"
        Me.ListStaff.Size = New System.Drawing.Size(216, 35)
        Me.ListStaff.TabIndex = 0
        Me.ListStaff.Text = "List of Staff"
        Me.ListStaff.UseVisualStyleBackColor = True
        '
        'StaffSearchBar
        '
        Me.StaffSearchBar.Controls.Add(Me.StaffSearchButton)
        Me.StaffSearchBar.Controls.Add(Me.StaffSearchInput)
        Me.StaffSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.StaffSearchBar.Location = New System.Drawing.Point(3, 3)
        Me.StaffSearchBar.Name = "StaffSearchBar"
        Me.StaffSearchBar.Size = New System.Drawing.Size(786, 30)
        Me.StaffSearchBar.TabIndex = 4
        '
        'StaffSearchButton
        '
        Me.StaffSearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffSearchButton.Location = New System.Drawing.Point(444, 3)
        Me.StaffSearchButton.Name = "StaffSearchButton"
        Me.StaffSearchButton.Size = New System.Drawing.Size(100, 23)
        Me.StaffSearchButton.TabIndex = 0
        Me.StaffSearchButton.Text = "SEARCH"
        Me.StaffSearchButton.UseVisualStyleBackColor = True
        '
        'StaffSearchInput
        '
        Me.StaffSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StaffSearchInput.Location = New System.Drawing.Point(225, 3)
        Me.StaffSearchInput.Name = "StaffSearchInput"
        Me.StaffSearchInput.Size = New System.Drawing.Size(213, 22)
        Me.StaffSearchInput.TabIndex = 0
        '
        'ReportsTab
        '
        Me.ReportsTab.Location = New System.Drawing.Point(4, 25)
        Me.ReportsTab.Name = "ReportsTab"
        Me.ReportsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ReportsTab.Size = New System.Drawing.Size(792, 421)
        Me.ReportsTab.TabIndex = 2
        Me.ReportsTab.Text = "REPORTS"
        Me.ReportsTab.UseVisualStyleBackColor = True
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AdminTabControl)
        Me.Name = "AdminDashboard"
        Me.Text = "ADMIN DASHBOARD"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AdminTabControl.ResumeLayout(False)
        Me.ProductsTab.ResumeLayout(False)
        Me.AdminBody.ResumeLayout(False)
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsAdminSidePanel.ResumeLayout(False)
        Me.AdminSidebarButtons.ResumeLayout(False)
        Me.ProductsSearchBar.ResumeLayout(False)
        Me.ProductsSearchBar.PerformLayout()
        Me.StaffTab.ResumeLayout(False)
        CType(Me.StaffList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StaffAdminSidePanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.StaffSearchBar.ResumeLayout(False)
        Me.StaffSearchBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminTabControl As TabControl
    Friend WithEvents ProductsTab As TabPage
    Friend WithEvents StaffTab As TabPage
    Friend WithEvents ReportsTab As TabPage
    Friend WithEvents ProductsSearchBar As Panel
    Friend WithEvents ProductsSearchInput As TextBox
    Friend WithEvents AdminBody As Panel
    Friend WithEvents ProductsAdminSidePanel As Panel
    Friend WithEvents ProductsSearchButton As Button
    Friend WithEvents AdminSidebarButtons As Panel
    Friend WithEvents ListProducts As Button
    Friend WithEvents AddProduct As Button
    Friend WithEvents ProductList As DataGridView
    Friend WithEvents StaffList As DataGridView
    Friend WithEvents StaffAdminSidePanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AddStaff As Button
    Friend WithEvents ListStaff As Button
    Friend WithEvents StaffSearchBar As Panel
    Friend WithEvents StaffSearchButton As Button
    Friend WithEvents StaffSearchInput As TextBox
End Class
