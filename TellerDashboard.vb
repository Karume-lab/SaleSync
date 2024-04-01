Public Class TellerDashboard
    Private Sub TellerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TellerDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub
End Class
