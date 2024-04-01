<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStaff
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
        Me.AddStaffPanel = New System.Windows.Forms.Panel()
        Me.AddStaffButtonsPanel = New System.Windows.Forms.Panel()
        Me.CancelStaffButton = New System.Windows.Forms.Button()
        Me.SaveStaffButton = New System.Windows.Forms.Button()
        Me.ProductQuantityPanel = New System.Windows.Forms.Panel()
        Me.RoleLabel = New System.Windows.Forms.Label()
        Me.RoleTextbox = New System.Windows.Forms.TextBox()
        Me.ProductPricePanel = New System.Windows.Forms.Panel()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNamePanel = New System.Windows.Forms.Panel()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.StaffNameTextbox = New System.Windows.Forms.TextBox()
        Me.AddStaffPanel.SuspendLayout()
        Me.AddStaffButtonsPanel.SuspendLayout()
        Me.ProductQuantityPanel.SuspendLayout()
        Me.ProductPricePanel.SuspendLayout()
        Me.ProductNamePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddStaffPanel
        '
        Me.AddStaffPanel.Controls.Add(Me.AddStaffButtonsPanel)
        Me.AddStaffPanel.Controls.Add(Me.ProductQuantityPanel)
        Me.AddStaffPanel.Controls.Add(Me.ProductPricePanel)
        Me.AddStaffPanel.Controls.Add(Me.ProductNamePanel)
        Me.AddStaffPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddStaffPanel.Location = New System.Drawing.Point(0, 0)
        Me.AddStaffPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddStaffPanel.Name = "AddStaffPanel"
        Me.AddStaffPanel.Size = New System.Drawing.Size(163, 176)
        Me.AddStaffPanel.TabIndex = 1
        '
        'AddStaffButtonsPanel
        '
        Me.AddStaffButtonsPanel.Controls.Add(Me.CancelStaffButton)
        Me.AddStaffButtonsPanel.Controls.Add(Me.SaveStaffButton)
        Me.AddStaffButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AddStaffButtonsPanel.Location = New System.Drawing.Point(0, 149)
        Me.AddStaffButtonsPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.AddStaffButtonsPanel.Name = "AddStaffButtonsPanel"
        Me.AddStaffButtonsPanel.Size = New System.Drawing.Size(163, 27)
        Me.AddStaffButtonsPanel.TabIndex = 15
        '
        'CancelStaffButton
        '
        Me.CancelStaffButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.CancelStaffButton.Location = New System.Drawing.Point(0, 0)
        Me.CancelStaffButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CancelStaffButton.Name = "CancelStaffButton"
        Me.CancelStaffButton.Size = New System.Drawing.Size(56, 27)
        Me.CancelStaffButton.TabIndex = 14
        Me.CancelStaffButton.Text = "Cancel"
        Me.CancelStaffButton.UseVisualStyleBackColor = True
        '
        'SaveStaffButton
        '
        Me.SaveStaffButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveStaffButton.Location = New System.Drawing.Point(107, 0)
        Me.SaveStaffButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaveStaffButton.Name = "SaveStaffButton"
        Me.SaveStaffButton.Size = New System.Drawing.Size(56, 27)
        Me.SaveStaffButton.TabIndex = 13
        Me.SaveStaffButton.Text = "Save"
        Me.SaveStaffButton.UseVisualStyleBackColor = True
        '
        'ProductQuantityPanel
        '
        Me.ProductQuantityPanel.Controls.Add(Me.RoleLabel)
        Me.ProductQuantityPanel.Controls.Add(Me.RoleTextbox)
        Me.ProductQuantityPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductQuantityPanel.Location = New System.Drawing.Point(0, 70)
        Me.ProductQuantityPanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductQuantityPanel.Name = "ProductQuantityPanel"
        Me.ProductQuantityPanel.Size = New System.Drawing.Size(163, 37)
        Me.ProductQuantityPanel.TabIndex = 12
        '
        'RoleLabel
        '
        Me.RoleLabel.AutoSize = True
        Me.RoleLabel.Location = New System.Drawing.Point(13, 0)
        Me.RoleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.RoleLabel.Name = "RoleLabel"
        Me.RoleLabel.Size = New System.Drawing.Size(29, 13)
        Me.RoleLabel.TabIndex = 3
        Me.RoleLabel.Text = "Role"
        '
        'RoleTextbox
        '
        Me.RoleTextbox.Location = New System.Drawing.Point(15, 15)
        Me.RoleTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RoleTextbox.Name = "RoleTextbox"
        Me.RoleTextbox.Size = New System.Drawing.Size(134, 20)
        Me.RoleTextbox.TabIndex = 7
        '
        'ProductPricePanel
        '
        Me.ProductPricePanel.Controls.Add(Me.EmailLabel)
        Me.ProductPricePanel.Controls.Add(Me.EmailTextBox)
        Me.ProductPricePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductPricePanel.Location = New System.Drawing.Point(0, 33)
        Me.ProductPricePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductPricePanel.Name = "ProductPricePanel"
        Me.ProductPricePanel.Size = New System.Drawing.Size(163, 37)
        Me.ProductPricePanel.TabIndex = 11
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(8, 0)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 2
        Me.EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(13, 15)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(137, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'ProductNamePanel
        '
        Me.ProductNamePanel.Controls.Add(Me.ProductNameLabel)
        Me.ProductNamePanel.Controls.Add(Me.StaffNameTextbox)
        Me.ProductNamePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProductNamePanel.Location = New System.Drawing.Point(0, 0)
        Me.ProductNamePanel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ProductNamePanel.Name = "ProductNamePanel"
        Me.ProductNamePanel.Size = New System.Drawing.Size(163, 33)
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
        'StaffNameTextbox
        '
        Me.StaffNameTextbox.Location = New System.Drawing.Point(10, 14)
        Me.StaffNameTextbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StaffNameTextbox.Name = "StaffNameTextbox"
        Me.StaffNameTextbox.Size = New System.Drawing.Size(139, 20)
        Me.StaffNameTextbox.TabIndex = 5
        '
        'AddStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(163, 176)
        Me.Controls.Add(Me.AddStaffPanel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(179, 215)
        Me.MinimumSize = New System.Drawing.Size(179, 215)
        Me.Name = "AddStaff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Staff"
        Me.AddStaffPanel.ResumeLayout(False)
        Me.AddStaffButtonsPanel.ResumeLayout(False)
        Me.ProductQuantityPanel.ResumeLayout(False)
        Me.ProductQuantityPanel.PerformLayout()
        Me.ProductPricePanel.ResumeLayout(False)
        Me.ProductPricePanel.PerformLayout()
        Me.ProductNamePanel.ResumeLayout(False)
        Me.ProductNamePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddStaffPanel As Panel
    Friend WithEvents AddStaffButtonsPanel As Panel
    Friend WithEvents CancelStaffButton As Button
    Friend WithEvents SaveStaffButton As Button
    Friend WithEvents ProductQuantityPanel As Panel
    Friend WithEvents RoleLabel As Label
    Friend WithEvents RoleTextbox As TextBox
    Friend WithEvents ProductPricePanel As Panel
    Friend WithEvents EmailLabel As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents ProductNamePanel As Panel
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents StaffNameTextbox As TextBox
End Class
