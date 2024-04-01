Imports MySqlConnector

Public Class AddProduct
    Private Sub AddProductToDatabase()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='salesync';database=salesync"
        Dim conn As MySqlConnection
        conn = New MySqlConnection(ConnectionString)
        Try
            ' Establish connection to the database
            conn.Open()

            Dim productName As String = ProductNameTextbox.Text
            Dim productPrice As Decimal = Decimal.Parse(ProductPriceTextBox.Text)
            Dim productDescription As String = ProductDescriptionTextBox.Text
            Dim productQuantity As Integer = Integer.Parse(ProductQuantityTextbox.Text)
            Dim updatedAt As DateTime = DateTime.Now

            ' Construct SQL INSERT query with parameters
            Dim insertQuery As String = "INSERT INTO products (name, price, description, quantity, updated_at) VALUES (@name, @price, @description, @quantity, @updatedAt)"
            Using command As New MySqlCommand(insertQuery, conn)
                ' Set parameter values
                command.Parameters.AddWithValue("@name", productName)
                command.Parameters.AddWithValue("@price", productPrice)
                command.Parameters.AddWithValue("@description", productDescription)
                command.Parameters.AddWithValue("@quantity", productQuantity)
                command.Parameters.AddWithValue("@updatedAt", updatedAt)

                ' Execute the query
                command.ExecuteNonQuery()

                MessageBox.Show("Product added successfully!")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub SaveProductButton_Click(sender As Object, e As EventArgs) Handles SaveProductButton.Click
        AddProductToDatabase()
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductDescriptionPanel_Paint(sender As Object, e As PaintEventArgs) Handles ProductDescriptionPanel.Paint

    End Sub
End Class
