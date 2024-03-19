Imports System.Text.RegularExpressions

Public Class LoginForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LoginPasswordTextBox.Click
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If String.IsNullOrEmpty(EmailTextBox.Text) OrElse String.IsNullOrEmpty(PasswordTextBox.Text) Then
            MessageBox.Show("Please enter your email and password", " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim emailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If emailRegex.IsMatch(EmailTextBox.Text) Then
            Me.Hide()
            Dim adminDashboard As New AdminDashboard()
            adminDashboard.Show()
        Else
            MessageBox.Show("Please enter a valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
    End Sub

    Private Sub EmailTextBox_TextChanged(sender As Object, e As EventArgs) Handles EmailTextBox.TextChanged

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class