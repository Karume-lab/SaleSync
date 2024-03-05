Public Class search_bar
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
        Show()
        Dim edit_entity As New edit_product
        edit_entity.ShowDialog()
    End Sub
End Class
