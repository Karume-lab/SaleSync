Public Class product_list
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Show()
        Dim edit_product As New edit_product
        edit_product.ShowDialog()
    End Sub
End Class
