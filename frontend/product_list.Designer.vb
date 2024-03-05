<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class product_list
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.All_entities1 = New frontend.search_bar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'All_entities1
        '
        Me.All_entities1.BackColor = System.Drawing.SystemColors.Control
        Me.All_entities1.Dock = System.Windows.Forms.DockStyle.Top
        Me.All_entities1.Location = New System.Drawing.Point(0, 0)
        Me.All_entities1.Name = "All_entities1"
        Me.All_entities1.Size = New System.Drawing.Size(775, 47)
        Me.All_entities1.TabIndex = 6
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 69
        Me.ListBox1.Items.AddRange(New Object() {"product one", "product two", "product three", "product four", "product five", "...", "product n"})
        Me.ListBox1.Location = New System.Drawing.Point(0, 47)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(775, 410)
        Me.ListBox1.TabIndex = 8
        '
        'product_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.All_entities1)
        Me.Name = "product_list"
        Me.Size = New System.Drawing.Size(775, 457)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents All_entities1 As search_bar
    Friend WithEvents ListBox1 As ListBox
End Class
