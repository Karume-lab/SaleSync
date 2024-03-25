<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.LoginPasswordPanel = New System.Windows.Forms.Panel()
        Me.LoginPasswordTextBox = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginEmailPanel = New System.Windows.Forms.Panel()
        Me.LoginEmailTextBox = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.LoginPanel.SuspendLayout()
        Me.LoginPasswordPanel.SuspendLayout()
        Me.LoginEmailPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.LoginPasswordPanel)
        Me.LoginPanel.Controls.Add(Me.LoginEmailPanel)
        Me.LoginPanel.Location = New System.Drawing.Point(9, 10)
        Me.LoginPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(154, 75)
        Me.LoginPanel.TabIndex = 0
        '
        'LoginPasswordPanel
        '
        Me.LoginPasswordPanel.Controls.Add(Me.LoginPasswordTextBox)
        Me.LoginPasswordPanel.Controls.Add(Me.PasswordTextBox)
        Me.LoginPasswordPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginPasswordPanel.Location = New System.Drawing.Point(0, 37)
        Me.LoginPasswordPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginPasswordPanel.Name = "LoginPasswordPanel"
        Me.LoginPasswordPanel.Size = New System.Drawing.Size(154, 37)
        Me.LoginPasswordPanel.TabIndex = 12
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.AutoSize = True
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(8, 0)
        Me.LoginPasswordTextBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(53, 13)
        Me.LoginPasswordTextBox.TabIndex = 2
        Me.LoginPasswordTextBox.Text = "Password"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(13, 15)
        Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'LoginEmailPanel
        '
        Me.LoginEmailPanel.Controls.Add(Me.LoginEmailTextBox)
        Me.LoginEmailPanel.Controls.Add(Me.EmailTextBox)
        Me.LoginEmailPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginEmailPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginEmailPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginEmailPanel.Name = "LoginEmailPanel"
        Me.LoginEmailPanel.Size = New System.Drawing.Size(154, 37)
        Me.LoginEmailPanel.TabIndex = 12
        '
        'LoginEmailTextBox
        '
        Me.LoginEmailTextBox.AutoSize = True
        Me.LoginEmailTextBox.Location = New System.Drawing.Point(8, 0)
        Me.LoginEmailTextBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LoginEmailTextBox.Name = "LoginEmailTextBox"
        Me.LoginEmailTextBox.Size = New System.Drawing.Size(32, 13)
        Me.LoginEmailTextBox.TabIndex = 2
        Me.LoginEmailTextBox.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(13, 15)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(137, 20)
        Me.EmailTextBox.TabIndex = 6
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(44, 89)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(90, 30)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(175, 131)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.LoginPanel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(191, 170)
        Me.MinimumSize = New System.Drawing.Size(191, 170)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPasswordPanel.ResumeLayout(False)
        Me.LoginPasswordPanel.PerformLayout()
        Me.LoginEmailPanel.ResumeLayout(False)
        Me.LoginEmailPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginPanel As Panel
    Friend WithEvents LoginEmailPanel As Panel
    Friend WithEvents LoginEmailTextBox As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LoginPasswordPanel As Panel
    Friend WithEvents LoginPasswordTextBox As Label
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
End Class
