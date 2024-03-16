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
        Me.LoginEmailPanel = New System.Windows.Forms.Panel()
        Me.LoginEmailTextBox = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.LoginPasswordPanel = New System.Windows.Forms.Panel()
        Me.LoginPasswordTextBox = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.LoginPanel.SuspendLayout()
        Me.LoginEmailPanel.SuspendLayout()
        Me.LoginPasswordPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginPanel
        '
        Me.LoginPanel.Controls.Add(Me.LoginPasswordPanel)
        Me.LoginPanel.Controls.Add(Me.LoginEmailPanel)
        Me.LoginPanel.Location = New System.Drawing.Point(12, 12)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(206, 92)
        Me.LoginPanel.TabIndex = 0
        '
        'LoginEmailPanel
        '
        Me.LoginEmailPanel.Controls.Add(Me.LoginEmailTextBox)
        Me.LoginEmailPanel.Controls.Add(Me.EmailTextBox)
        Me.LoginEmailPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginEmailPanel.Location = New System.Drawing.Point(0, 0)
        Me.LoginEmailPanel.Name = "LoginEmailPanel"
        Me.LoginEmailPanel.Size = New System.Drawing.Size(206, 46)
        Me.LoginEmailPanel.TabIndex = 12
        '
        'LoginEmailTextBox
        '
        Me.LoginEmailTextBox.AutoSize = True
        Me.LoginEmailTextBox.Location = New System.Drawing.Point(11, 0)
        Me.LoginEmailTextBox.Name = "LoginEmailTextBox"
        Me.LoginEmailTextBox.Size = New System.Drawing.Size(41, 16)
        Me.LoginEmailTextBox.TabIndex = 2
        Me.LoginEmailTextBox.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(17, 19)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(181, 22)
        Me.EmailTextBox.TabIndex = 6
        '
        'LoginPasswordPanel
        '
        Me.LoginPasswordPanel.Controls.Add(Me.LoginPasswordTextBox)
        Me.LoginPasswordPanel.Controls.Add(Me.TextBox1)
        Me.LoginPasswordPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LoginPasswordPanel.Location = New System.Drawing.Point(0, 46)
        Me.LoginPasswordPanel.Name = "LoginPasswordPanel"
        Me.LoginPasswordPanel.Size = New System.Drawing.Size(206, 46)
        Me.LoginPasswordPanel.TabIndex = 12
        '
        'LoginPasswordTextBox
        '
        Me.LoginPasswordTextBox.AutoSize = True
        Me.LoginPasswordTextBox.Location = New System.Drawing.Point(11, 0)
        Me.LoginPasswordTextBox.Name = "LoginPasswordTextBox"
        Me.LoginPasswordTextBox.Size = New System.Drawing.Size(67, 16)
        Me.LoginPasswordTextBox.TabIndex = 2
        Me.LoginPasswordTextBox.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(17, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 22)
        Me.TextBox1.TabIndex = 6
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(58, 110)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(120, 37)
        Me.LoginButton.TabIndex = 0
        Me.LoginButton.Text = "LOGIN"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(231, 153)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.LoginPanel)
        Me.MaximumSize = New System.Drawing.Size(249, 200)
        Me.MinimumSize = New System.Drawing.Size(249, 200)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginEmailPanel.ResumeLayout(False)
        Me.LoginEmailPanel.PerformLayout()
        Me.LoginPasswordPanel.ResumeLayout(False)
        Me.LoginPasswordPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginPanel As Panel
    Friend WithEvents LoginEmailPanel As Panel
    Friend WithEvents LoginEmailTextBox As Label
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents LoginPasswordPanel As Panel
    Friend WithEvents LoginPasswordTextBox As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LoginButton As Button
End Class
