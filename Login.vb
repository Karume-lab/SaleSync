Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LoginPasswordTextBox.Click

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.Hide()
        Dim adminDashboard As New AdminDashboard()
        adminDashboard.Show()
    End Sub
End Class