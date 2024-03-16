Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductList.Visible = False
        StaffList.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ProductsSearchInput.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles AdminBody.Paint

    End Sub

    Private Sub ProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductList.CellContentClick

    End Sub

    Private Sub ListProducts_Click(sender As Object, e As EventArgs) Handles ListProducts.Click
        ProductList.Visible = True
    End Sub

    Private Sub StaffTab_Click(sender As Object, e As EventArgs) Handles StaffTab.Click

    End Sub

    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        Dim addProductForm As New AddProduct()
        addProductForm.Show()
    End Sub

    Private Sub AdminSearchBar_Paint(sender As Object, e As PaintEventArgs) Handles ProductsSearchBar.Paint

    End Sub

    Private Sub StaffList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffList.CellContentClick

    End Sub

    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaff.Click
        Dim addStaffForm As New AddStaff()
        addStaffForm.Show()
    End Sub

    Private Sub ListStaff_Click(sender As Object, e As EventArgs) Handles ListStaff.Click
        StaffList.Visible = True
    End Sub
End Class
