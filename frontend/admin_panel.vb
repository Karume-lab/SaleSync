Public Class admin_panel
    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Show()
        Dim add_staff As New new_staff
        add_staff.ShowDialog()
    End Sub

    Private Sub ListAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem1.Click
        Product_list1.Visible = True
    End Sub

    Private Sub ListAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListAllToolStripMenuItem.Click
        Staff_list1.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub admin_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Staff_list1.Visible = False
        Product_list1.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AddNewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem1.Click
        Show()
        Dim add_product As New new_product
        add_product.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub All_entities1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub All_entities1_Load_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Staff_list1_Load(sender As Object, e As EventArgs) Handles Staff_list1.Load

    End Sub
End Class