Imports MySqlConnector

Public Class AddStaff
    Private Sub AddStaffToDatabase()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='root';database=salesync"
        Dim conn As MySqlConnection
        conn = New MySqlConnection(ConnectionString)
        Try
            ' Establish connection to the database
            conn.Open()

            Dim staffName As String = StaffNameTextbox.Text
            Dim staffEmail As String = EmailTextBox.Text
            Dim staffRole As String = RoleTextbox.Text
            Dim updatedAt As DateTime = DateTime.Now
            Dim defaultPwd As String = staffName


            ' Construct SQL INSERT query with parameters for staff
            Dim insertQuery As String = "INSERT INTO staff (name, email, role, password, updated_at) VALUES (@name, @email, @role, @pwd, @updatedAt)"
            Using command As New MySqlCommand(insertQuery, conn)
                ' Set parameter values for staff
                command.Parameters.AddWithValue("@name", staffName)
                command.Parameters.AddWithValue("@email", staffEmail)
                command.Parameters.AddWithValue("@role", staffRole)
                command.Parameters.AddWithValue("@pwd", defaultPwd)
                command.Parameters.AddWithValue("@updatedAt", updatedAt)


                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Staff added successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding staff: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub AddStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SaveStaffButton_Click(sender As Object, e As EventArgs) Handles SaveStaffButton.Click
        AddStaffToDatabase()
    End Sub
End Class