<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TellerDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblProduct = New System.Windows.Forms.Label()
        Me.cmbProduct = New System.Windows.Forms.ComboBox()
        Me.dgridProducts = New System.Windows.Forms.DataGridView()
        Me.Product = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(893, 46)
        Me.Panel1.TabIndex = 0
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(767, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(71, 16)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "21/11/2024"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(665, 10)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "John Doe"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddProduct)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.lblQuantity)
        Me.Panel2.Controls.Add(Me.lblProduct)
        Me.Panel2.Controls.Add(Me.cmbProduct)
        Me.Panel2.Location = New System.Drawing.Point(-1, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(893, 96)
        Me.Panel2.TabIndex = 1
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(259, 54)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProduct.TabIndex = 4
        Me.btnAddProduct.Text = "Add"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(130, 55)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 22)
        Me.txtQuantity.TabIndex = 3
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(60, 58)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(55, 16)
        Me.lblQuantity.TabIndex = 2
        Me.lblQuantity.Text = "Quantity"
        '
        'lblProduct
        '
        Me.lblProduct.AutoSize = True
        Me.lblProduct.Location = New System.Drawing.Point(55, 11)
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.Size = New System.Drawing.Size(53, 16)
        Me.lblProduct.TabIndex = 1
        Me.lblProduct.Text = "Product"
        '
        'cmbProduct
        '
        Me.cmbProduct.FormattingEnabled = True
        Me.cmbProduct.Location = New System.Drawing.Point(130, 8)
        Me.cmbProduct.Name = "cmbProduct"
        Me.cmbProduct.Size = New System.Drawing.Size(204, 24)
        Me.cmbProduct.TabIndex = 0
        '
        'dgridProducts
        '
        Me.dgridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Product, Me.Price, Me.Quantity, Me.Total})
        Me.dgridProducts.Location = New System.Drawing.Point(-1, 136)
        Me.dgridProducts.Name = "dgridProducts"
        Me.dgridProducts.RowHeadersWidth = 51
        Me.dgridProducts.RowTemplate.Height = 24
        Me.dgridProducts.Size = New System.Drawing.Size(893, 226)
        Me.dgridProducts.TabIndex = 2
        '
        'Product
        '
        Me.Product.HeaderText = "Product Name"
        Me.Product.MinimumWidth = 6
        Me.Product.Name = "Product"
        Me.Product.ReadOnly = True
        Me.Product.Width = 125
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.MinimumWidth = 6
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 125
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MinimumWidth = 6
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Width = 125
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 125
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(694, 390)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 3
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(791, 390)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TellerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 439)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.dgridProducts)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TellerDashboard"
        Me.Text = "TellerDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProduct As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents dgridProducts As DataGridView
    Friend WithEvents Product As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnCancel As Button
End Class
