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
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.ProductDescriptionLabel = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SaveProductButton = New System.Windows.Forms.Button()
        Me.CancelProductButton = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AddProductPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddProductPanel
        '
        Me.AddProductPanel.Controls.Add(Me.Panel5)
        Me.AddProductPanel.Controls.Add(Me.Panel4)
        Me.AddProductPanel.Controls.Add(Me.Panel3)
        Me.AddProductPanel.Controls.Add(Me.Panel2)
        Me.AddProductPanel.Controls.Add(Me.Panel1)
        Me.AddProductPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddProductPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddProductPanel.Name = "AddProductPanel"
        Me.AddProductPanel.Size = New System.Drawing.Size(284, 303)
        Me.AddProductPanel.TabIndex = 0
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(14, 19)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(197, 78)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(20, 19)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(17, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 22)
        Me.TextBox1.TabIndex = 5
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Location = New System.Drawing.Point(17, 0)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(55, 16)
        Me.QuantityLabel.TabIndex = 3
        Me.QuantityLabel.Text = "Quantity"
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.Location = New System.Drawing.Point(11, 0)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(38, 16)
        Me.ProductPriceLabel.TabIndex = 2
        Me.ProductPriceLabel.Text = "Price"
        '
        'ProductDescriptionLabel
        '
        Me.ProductDescriptionLabel.AutoSize = True
        Me.ProductDescriptionLabel.Location = New System.Drawing.Point(11, 0)
        Me.ProductDescriptionLabel.Name = "ProductDescriptionLabel"
        Me.ProductDescriptionLabel.Size = New System.Drawing.Size(75, 16)
        Me.ProductDescriptionLabel.TabIndex = 1
        Me.ProductDescriptionLabel.Text = "Description"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Location = New System.Drawing.Point(11, 0)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(44, 16)
        Me.ProductNameLabel.TabIndex = 0
        Me.ProductNameLabel.Text = "Name"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ProductNameLabel)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 41)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ProductDescriptionLabel)
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 100)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ProductPriceLabel)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 141)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 46)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.QuantityLabel)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 187)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(284, 46)
        Me.Panel4.TabIndex = 12
        '
        'SaveProductButton
        '
        Me.SaveProductButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveProductButton.Location = New System.Drawing.Point(191, 0)
        Me.SaveProductButton.Name = "SaveProductButton"
        Me.SaveProductButton.Size = New System.Drawing.Size(75, 33)
        Me.SaveProductButton.TabIndex = 13
        Me.SaveProductButton.Text = "Save"
        Me.SaveProductButton.UseVisualStyleBackColor = True
        '
        'CancelProductButton
        '
        Me.CancelProductButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CancelProductButton.Location = New System.Drawing.Point(0, 0)
        Me.CancelProductButton.Name = "CancelProductButton"
        Me.CancelProductButton.Size = New System.Drawing.Size(75, 33)
        Me.CancelProductButton.TabIndex = 14
        Me.CancelProductButton.Text = "Cancel"
        Me.CancelProductButton.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CancelProductButton)
        Me.Panel5.Controls.Add(Me.SaveProductButton)
        Me.Panel5.Location = New System.Drawing.Point(12, 260)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(266, 33)
        Me.Panel5.TabIndex = 15
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 303)
        Me.Controls.Add(Me.AddProductPanel)
        Me.Name = "AddProduct"
        Me.Text = "Add Product"
        Me.AddProductPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddProductPanel As Panel
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents ProductPriceLabel As Label
    Friend WithEvents ProductDescriptionLabel As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CancelProductButton As Button
    Friend WithEvents SaveProductButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
