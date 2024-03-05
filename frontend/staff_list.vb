Public Class staff_list
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Show()
        Dim edit_staff As New edit_staff
        edit_staff.ShowDialog()
    End Sub
End Class
