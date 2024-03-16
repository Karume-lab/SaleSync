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
        Me.AdminSideMenu = New System.Windows.Forms.Panel()
        Me.AdminSidebarButtons = New System.Windows.Forms.Panel()
        Me.AddProduct = New System.Windows.Forms.Button()
        Me.ListProducts = New System.Windows.Forms.Button()
        Me.AdminSearchBar = New System.Windows.Forms.Panel()
        Me.AdminSearchButton = New System.Windows.Forms.Button()
        Me.AdminSearchInput = New System.Windows.Forms.TextBox()
        Me.StaffTab = New System.Windows.Forms.TabPage()
        Me.ReportsTab = New System.Windows.Forms.TabPage()
        Me.AdminTabControl.SuspendLayout()
        Me.ProductsTab.SuspendLayout()
        Me.AdminBody.SuspendLayout()
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminSideMenu.SuspendLayout()
        Me.AdminSidebarButtons.SuspendLayout()
        Me.AdminSearchBar.SuspendLayout()
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
        Me.ProductsTab.Controls.Add(Me.AdminSideMenu)
        Me.ProductsTab.Controls.Add(Me.AdminSearchBar)
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
        'AdminSideMenu
        '
        Me.AdminSideMenu.Controls.Add(Me.AdminSidebarButtons)
        Me.AdminSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.AdminSideMenu.Location = New System.Drawing.Point(3, 33)
        Me.AdminSideMenu.Name = "AdminSideMenu"
        Me.AdminSideMenu.Size = New System.Drawing.Size(216, 385)
        Me.AdminSideMenu.TabIndex = 2
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
        'AdminSearchBar
        '
        Me.AdminSearchBar.Controls.Add(Me.AdminSearchButton)
        Me.AdminSearchBar.Controls.Add(Me.AdminSearchInput)
        Me.AdminSearchBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.AdminSearchBar.Location = New System.Drawing.Point(3, 3)
        Me.AdminSearchBar.Name = "AdminSearchBar"
        Me.AdminSearchBar.Size = New System.Drawing.Size(786, 30)
        Me.AdminSearchBar.TabIndex = 1
        '
        'AdminSearchButton
        '
        Me.AdminSearchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdminSearchButton.Location = New System.Drawing.Point(444, 3)
        Me.AdminSearchButton.Name = "AdminSearchButton"
        Me.AdminSearchButton.Size = New System.Drawing.Size(100, 23)
        Me.AdminSearchButton.TabIndex = 0
        Me.AdminSearchButton.Text = "SEARCH"
        Me.AdminSearchButton.UseVisualStyleBackColor = True
        '
        'AdminSearchInput
        '
        Me.AdminSearchInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdminSearchInput.Location = New System.Drawing.Point(225, 3)
        Me.AdminSearchInput.Name = "AdminSearchInput"
        Me.AdminSearchInput.Size = New System.Drawing.Size(213, 22)
        Me.AdminSearchInput.TabIndex = 0
        '
        'StaffTab
        '
        Me.StaffTab.Location = New System.Drawing.Point(4, 25)
        Me.StaffTab.Name = "StaffTab"
        Me.StaffTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StaffTab.Size = New System.Drawing.Size(792, 421)
        Me.StaffTab.TabIndex = 1
        Me.StaffTab.Text = "STAFF"
        Me.StaffTab.UseVisualStyleBackColor = True
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
        Me.AdminTabControl.ResumeLayout(False)
        Me.ProductsTab.ResumeLayout(False)
        Me.AdminBody.ResumeLayout(False)
        CType(Me.ProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminSideMenu.ResumeLayout(False)
        Me.AdminSidebarButtons.ResumeLayout(False)
        Me.AdminSearchBar.ResumeLayout(False)
        Me.AdminSearchBar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AdminTabControl As TabControl
    Friend WithEvents ProductsTab As TabPage
    Friend WithEvents StaffTab As TabPage
    Friend WithEvents ReportsTab As TabPage
    Friend WithEvents AdminSearchBar As Panel
    Friend WithEvents AdminSearchInput As TextBox
    Friend WithEvents AdminBody As Panel
    Friend WithEvents AdminSideMenu As Panel
    Friend WithEvents AdminSearchButton As Button
    Friend WithEvents AdminSidebarButtons As Panel
    Friend WithEvents ListProducts As Button
    Friend WithEvents AddProduct As Button
    Friend WithEvents ProductList As DataGridView
End Class
