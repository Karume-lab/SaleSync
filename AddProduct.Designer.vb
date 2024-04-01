<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.AddProductPanel = New System.Windows.Forms.Panel()
        Me.AddProductButtonsPanel = New System.Windows.Forms.Panel()
        Me.CancelProductButton = New System.Windows.Forms.Button()
        Me.SaveProductButton = New System.Windows.Forms.Button()
        Me.ProductQuantityPanel = New System.Windows.Forms.Panel()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ProductQuantityTextbox = New System.Windows.Forms.TextBox()
        Me.ProductPricePanel = New System.Windows.Forms.Panel()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductDescriptionPanel = New System.Windows.Forms.Panel()
        Me.ProductDescriptionLabel = New System.Windows.Forms.Label()
        Me.ProductDescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNamePanel = New System.Windows.Forms.Panel()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.ProductNameTextbox = New System.Windows.Forms.TextBox()
        Me.AddProductPanel.SuspendLayout()
        Me.AddProductButtonsPanel.SuspendLayout()
        Me.ProductQuantityPanel.SuspendLayout()
        Me.ProductPricePanel.SuspendLayout()
        Me.ProductDescriptionPanel.SuspendLayout()
        Me.ProductNamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddProductPanel
        '
        Me.AddProductPanel.Controls.Add(Me.AddProductButtonsPanel)
        Me.AddProductPanel.Controls.Add(Me.ProductQuantityPanel)
        Me.AddProductPanel.Controls.Add(Me.ProductPricePanel)
        Me.AddProductPanel.Controls.Add(Me.ProductDescriptionPanel)
        Me.AddProductPanel.Controls.Add(Me.ProductNamePanel)
        Me.AddProductPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddProductPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddProductPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddProductPanel.Name = "AddProductPanel"
        Me.AddProductPanel.Size = New System.Drawing.Size(214, 253)
        Me.AddProductPanel.TabIndex = 0
        '
        'AddProductButtonsPanel
        '
        Me.AddProductButtonsPanel.Controls.Add(Me.CancelProductButton)
        Me.AddProductButtonsPanel.Controls.Add(Me.SaveProductButton)
        Me.AddProductButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddProductButtonsPanel.Location = New System.Drawing.Point(0, 226)
        Me.AddProductButtonsPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddProductButtonsPanel.Name = "AddProductButtonsPanel"
        Me.AddProductButtonsPanel.Size = New System.Drawing.Size(214, 27)
        Me.AddProductButtonsPanel.TabIndex = 15
        '
        'CancelProductButton
        '
        Me.CancelProductButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CancelProductButton.Location = New System.Drawing.Point(0, 0)
        Me.CancelProductButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelProductButton.Name = "CancelProductButton"
        Me.CancelProductButton.Size = New System.Drawing.Size(56, 27)
        Me.CancelProductButton.TabIndex = 14
        Me.CancelProductButton.Text = "Cancel"
        Me.CancelProductButton.UseVisualStyleBackColor = True
        '
        'SaveProductButton
        '
        Me.SaveProductButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveProductButton.Location = New System.Drawing.Point(158, 0)
        Me.SaveProductButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaveProductButton.Name = "SaveProductButton"
        Me.SaveProductButton.Size = New System.Drawing.Size(56, 27)
        Me.SaveProductButton.TabIndex = 13
        Me.SaveProductButton.Text = "Save"
        Me.SaveProductButton.UseVisualStyleBackColor = True
        '
        'ProductQuantityPanel
        '
        Me.ProductQuantityPanel.Controls.Add(Me.QuantityLabel)
        Me.ProductQuantityPanel.Controls.Add(Me.ProductQuantityTextbox)
        Me.ProductQuantityPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductQuantityPanel.Location = New System.Drawing.Point(0, 151)
        Me.ProductQuantityPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductQuantityPanel.Name = "ProductQuantityPanel"
        Me.ProductQuantityPanel.Size = New System.Drawing.Size(214, 37)
        Me.ProductQuantityPanel.TabIndex = 12
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(13, 0)
        Me.QuantityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(46, 13)
        Me.QuantityLabel.TabIndex = 3
        Me.QuantityLabel.Text = "Quantity"
        '
        'ProductQuantityTextbox
        '
        Me.ProductQuantityTextbox.Location = New System.Drawing.Point(15, 15)
        Me.ProductQuantityTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductQuantityTextbox.Name = "ProductQuantityTextbox"
        Me.ProductQuantityTextbox.Size = New System.Drawing.Size(76, 20)
        Me.ProductQuantityTextbox.TabIndex = 7
        '
        'ProductPricePanel
        '
        Me.ProductPricePanel.Controls.Add(Me.ProductPriceLabel)
        Me.ProductPricePanel.Controls.Add(Me.ProductPriceTextBox)
        Me.ProductPricePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductPricePanel.Location = New System.Drawing.Point(0, 114)
        Me.ProductPricePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductPricePanel.Name = "ProductPricePanel"
        Me.ProductPricePanel.Size = New System.Drawing.Size(214, 37)
        Me.ProductPricePanel.TabIndex = 11
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.Location = New System.Drawing.Point(8, 0)
        Me.ProductPriceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(31, 13)
        Me.ProductPriceLabel.TabIndex = 2
        Me.ProductPriceLabel.Text = "Price"
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(13, 15)
        Me.ProductPriceTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(76, 20)
        Me.ProductPriceTextBox.TabIndex = 6
        '
        'ProductDescriptionPanel
        '
        Me.ProductDescriptionPanel.Controls.Add(Me.ProductDescriptionLabel)
        Me.ProductDescriptionPanel.Controls.Add(Me.ProductDescriptionTextBox)
        Me.ProductDescriptionPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductDescriptionPanel.Location = New System.Drawing.Point(0, 33)
        Me.ProductDescriptionPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductDescriptionPanel.Name = "ProductDescriptionPanel"
        Me.ProductDescriptionPanel.Size = New System.Drawing.Size(214, 81)
        Me.ProductDescriptionPanel.TabIndex = 10
        '
        'ProductDescriptionLabel
        '
        Me.ProductDescriptionLabel.AutoSize = True
        Me.ProductDescriptionLabel.Location = New System.Drawing.Point(8, 0)
        Me.ProductDescriptionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        Me.ProductDescriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.ProductDescriptionLabel.TabIndex = 1
        Me.ProductDescriptionLabel.Text = "Description"
        '
        'ProductDescriptionTextBox
        '
        Me.ProductDescriptionTextBox.Location = New System.Drawing.Point(10, 15)
        Me.ProductDescriptionTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductDescriptionTextBox.Multiline = True
        Me.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox"
        Me.ProductDescriptionTextBox.Size = New System.Drawing.Size(149, 64)
        Me.ProductDescriptionTextBox.TabIndex = 8
        '
        'ProductNamePanel
        '
        Me.ProductNamePanel.Controls.Add(Me.ProductNameLabel)
        Me.ProductNamePanel.Controls.Add(Me.ProductNameTextbox)
        Me.ProductNamePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductNamePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProductNamePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductNamePanel.Name = "ProductNamePanel"
        Me.ProductNamePanel.Size = New System.Drawing.Size(214, 33)
        Me.ProductNamePanel.TabIndex = 9
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Location = New System.Drawing.Point(8, 0)
        Me.ProductNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(35, 13)
        Me.ProductNameLabel.TabIndex = 0
        Me.ProductNameLabel.Text = "Name"
        '
        'ProductNameTextbox
        '
        Me.ProductNameTextbox.Location = New System.Drawing.Point(10, 14)
        Me.ProductNameTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductNameTextbox.Name = "ProductNameTextbox"
        Me.ProductNameTextbox.Size = New System.Drawing.Size(139, 20)
        Me.ProductNameTextbox.TabIndex = 5
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(214, 253)
        Me.Controls.Add(Me.AddProductPanel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(230, 292)
        Me.MinimumSize = New System.Drawing.Size(230, 292)
        Me.Name = "AddProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Product"
        Me.AddProductPanel.ResumeLayout(False)
        Me.AddProductButtonsPanel.ResumeLayout(False)
        Me.ProductQuantityPanel.ResumeLayout(False)
        Me.ProductQuantityPanel.PerformLayout()
        Me.ProductPricePanel.ResumeLayout(False)
        Me.ProductPricePanel.PerformLayout()
        Me.ProductDescriptionPanel.ResumeLayout(False)
        Me.ProductDescriptionPanel.PerformLayout()
        Me.ProductNamePanel.ResumeLayout(False)
        Me.ProductNamePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddProductPanel As Panel
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents ProductPriceLabel As Label
    Friend WithEvents ProductDescriptionLabel As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents ProductDescriptionTextBox As TextBox
    Friend WithEvents ProductQuantityTextbox As TextBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductNameTextbox As TextBox
    Friend WithEvents ProductNamePanel As Panel
    Friend WithEvents ProductPricePanel As Panel
    Friend WithEvents ProductDescriptionPanel As Panel
    Friend WithEvents CancelProductButton As Button
    Friend WithEvents SaveProductButton As Button
    Friend WithEvents ProductQuantityPanel As Panel
    Friend WithEvents AddProductButtonsPanel As Panel
End Class
