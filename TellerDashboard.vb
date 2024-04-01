Public Class TellerDashboard
    Private Sub TellerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TellerDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub dgridProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridProducts.CellContentClick

    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub lblDate_Click(sender As Object, e As EventArgs) Handles lblDate.Click

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub
End Class