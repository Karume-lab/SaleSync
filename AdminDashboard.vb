Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Threading
Imports MySqlConnector
Imports Mysqlx.Resultset

Public Class AdminDashboard

    Dim conn As New MySqlConnection(GetConnection)
    Dim StaffId As String
    Dim productId As String


    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductList.Visible = False
        StaffList.Visible = False

    End Sub

    Private Sub LoadProducts()

        Try
            ' Establish connection to the database
            conn.Open()
            ProductList.Rows.Clear()

            ' Construct SQL SELECT query
            Dim selectQuery As String = "SELECT product_id AS Id, name AS Name, price AS Price, quantity AS Quantity, description AS Description FROM products"
            Using adapter As New MySqlDataAdapter(selectQuery, conn)

                Dim productDataSet As New DataSet
                adapter.Fill(productDataSet)
                If productDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In productDataSet.Tables(0).Rows
                        ProductList.Rows.Add(row("Id"), row("Name"), row("Price"), row("Quantity"), row("Description"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            StaffNameTextBox.Clear()
            StaffEmailTextBox.Clear()
            StaffRoleComboBox.Text = ""

            StaffList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading staff: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub ListProducts_Click(sender As Object, e As EventArgs) Handles ListProducts.Click
        LoadProducts()
        ProductList.Visible = True
    End Sub


    Private Sub AddProductToDatabase()
        Try
            ' Establish connection to the database
            conn.Open()

            Dim productName As String = ProductNameTextBox.Text
            Dim productPrice As Decimal = Decimal.Parse(ProductPriceTextBox.Text)
            Dim productQuantity As Integer = Integer.Parse(ProductQuantityTextBox.Text)
            Dim productDescription As String = ProductDescriptionTextBox.Text
            Dim updatedAt As DateTime = DateTime.Now

            ' Construct SQL INSERT query with parameters
            Dim insertQuery As String = "INSERT INTO products (name, description, price, quantity, updated_at) VALUES (@name,@description, @price, @quantity, @updatedAt)"
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

            conn.Close()
            LoadProducts()


        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        AddProductToDatabase()
    End Sub

    Private Sub UpdateProductButton_Click(sender As Object, e As EventArgs) Handles UpdateProductButton.Click
        Try
            ' Establish connection to the database
            conn.Open()

            Dim productName As String = ProductNameTextBox.Text
            Dim productPrice As String = ProductPriceTextBox.Text
            Dim productQuantity As String = ProductQuantityTextBox.Text
            Dim productDescription As String = ProductDescriptionTextBox.Text
            Dim updatedAt As DateTime = DateTime.Now


            Dim result As DialogResult = MessageBox.Show($"Product - {productName} - Will be Updated", "Update Product", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                ' Construct SQL UPDATE query with parameters for staff
                Dim updateQuery As String = "UPDATE products SET name = @name, price=@price, quantity=@quantity, description=@description, updated_at = @updatedAt WHERE product_id = @productId"
                Using command As New MySqlCommand(updateQuery, conn)
                    ' Set parameter values for staff
                    command.Parameters.AddWithValue("@productId", productId)
                    command.Parameters.AddWithValue("@name", productName)
                    command.Parameters.AddWithValue("@price", productPrice)
                    command.Parameters.AddWithValue("@quantity", productQuantity)
                    command.Parameters.AddWithValue("@description", productDescription)
                    command.Parameters.AddWithValue("@updatedAt", updatedAt)

                    ' Execute the query 
                    command.ExecuteNonQuery()

                    MessageBox.Show("Product updated successfully!")
                End Using

                conn.Close()

                LoadProducts()
                UpdateProductButton.Enabled = False
            Else
                conn.Close()
                LoadProducts()
                UpdateProductButton.Enabled = False
            End If


        Catch ex As Exception
            MessageBox.Show("Error updating product: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try

    End Sub

    Private Sub ProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductList.CellContentClick
        Try
            If ProductList.Columns(e.ColumnIndex).Name = "ProductDeleteButton" Then
                productId = ProductList.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim productName As String = ProductList.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete {productName}?", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

                If result = DialogResult.OK Then
                    conn.Open()

                    ' Construct SQL DELETE query with parameter
                    Dim deleteQuery As String = "DELETE FROM products WHERE product_id = @productId"
                    Using command As New MySqlCommand(deleteQuery, conn)
                        ' Set parameter value
                        command.Parameters.AddWithValue("@productId", productId)

                        ' Execute the query
                        command.ExecuteNonQuery()

                        MessageBox.Show("Product deleted successfully!")
                    End Using
                    conn.Close()

                    LoadProducts()
                Else
                    conn.Close()
                    LoadProducts()

                End If

                ' Establish connection to the database
            ElseIf ProductList.Columns(e.ColumnIndex).Name = "ProductEditButton" Then
                productId = ProductList.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim productName As String = ProductList.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim productPrice As String = ProductList.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim productQuantity As String = ProductList.Rows(e.RowIndex).Cells(3).Value.ToString()
                Dim productDescription As String = ProductList.Rows(e.RowIndex).Cells(4).Value.ToString()


                ProductNameTextBox.Text = productName
                ProductPriceTextBox.Text = productPrice
                ProductQuantityTextBox.Text = productQuantity
                ProductDescriptionTextBox.Text = productDescription

                UpdateProductButton.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub AddStaffToDatabase()

        If String.IsNullOrEmpty(StaffNameTextBox.Text) OrElse String.IsNullOrEmpty(StaffEmailTextBox.Text) OrElse String.IsNullOrEmpty(StaffRoleComboBox.Text) Then
            MessageBox.Show("Please fill in all fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim emailRegex As New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        If emailRegex.IsMatch(StaffEmailTextBox.Text) Then
            Try
                ' Establish connection to the database
                conn.Open()

                Dim staffName As String = StaffNameTextBox.Text
                Dim staffEmail As String = StaffEmailTextBox.Text
                Dim staffRole As String = StaffRoleComboBox.Text
                Dim updatedAt As DateTime = DateTime.Now
                Dim hashedPwd As String = HashPassword(staffName, staffEmail)


                ' Construct SQL INSERT query with parameters for staff
                Dim insertQuery As String = "INSERT INTO staff (name, email, role, password, updated_at) VALUES (@name, @email, @role, @pwd, @updatedAt)"
                Using command As New MySqlCommand(insertQuery, conn)
                    ' Set parameter values for staff
                    command.Parameters.AddWithValue("@name", staffName)
                    command.Parameters.AddWithValue("@email", staffEmail)
                    command.Parameters.AddWithValue("@role", staffRole)
                    command.Parameters.AddWithValue("@pwd", hashedPwd)
                    command.Parameters.AddWithValue("@updatedAt", updatedAt)


                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Staff added successfully!")
                End Using

                conn.Close()
                LoadStaff()

            Catch ex As Exception
                MessageBox.Show("Error adding staff: " & ex.Message)
            Finally
                ' Close the database connection
                conn.Close()
            End Try

        Else
            MessageBox.Show("Please enter a valid email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

    End Sub

    Private Sub StaffList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffList.CellContentClick
        Try
            If StaffList.Columns(e.ColumnIndex).Name = "StaffDeleteButton" Then
                StaffId = StaffList.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim staffEmail As String = StaffList.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete {staffEmail}?", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)

                If result = DialogResult.OK Then
                    conn.Open()

                    ' Construct SQL DELETE query with parameter
                    Dim deleteQuery As String = "DELETE FROM staff WHERE staff_id = @staffId"
                    Using command As New MySqlCommand(deleteQuery, conn)
                        ' Set parameter value
                        command.Parameters.AddWithValue("@staffId", StaffId)

                        ' Execute the query
                        command.ExecuteNonQuery()

                        MessageBox.Show("Staff deleted successfully!")
                    End Using
                    conn.Close()

                    ' Reload the staff list
                    LoadStaff()
                Else
                    conn.Close()
                    LoadStaff()

                End If

                ' Establish connection to the database
            ElseIf StaffList.Columns(e.ColumnIndex).Name = "StaffEditButton" Then
                StaffId = StaffList.Rows(e.RowIndex).Cells(0).Value.ToString()
                Dim staffName As String = StaffList.Rows(e.RowIndex).Cells(1).Value.ToString()
                Dim staffEmail As String = StaffList.Rows(e.RowIndex).Cells(2).Value.ToString()
                Dim staffRole As String = StaffList.Rows(e.RowIndex).Cells(3).Value.ToString()

                StaffNameTextBox.Text = staffName
                StaffEmailTextBox.Text = staffEmail
                StaffRoleComboBox.Text = staffRole


                StaffUpdateButton.Enabled = True


            End If

        Catch ex As Exception
            MessageBox.Show("Error deleting staff: " & ex.Message)
        Finally
            conn.Close()

        End Try
    End Sub

    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaff.Click
        AddStaffToDatabase()
    End Sub

    Private Sub LoadStaff()
        Try
            ' Establish connection to the database
            conn.Open()
            StaffList.Rows.Clear()

            ' Construct SQL SELECT query for staff
            Dim selectQuery As String = "SELECT staff_id as Id, name AS Name, email AS Email, role AS Role FROM staff"
            Using adapter As New MySqlDataAdapter(selectQuery, conn)
                Dim staffDataSet As New DataSet
                adapter.Fill(staffDataSet)
                If staffDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In staffDataSet.Tables(0).Rows
                        StaffList.Rows.Add(row("Id"), row("Name"), row("Email"), row("Role"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            StaffEmailTextBox.Clear()
            StaffNameTextBox.Clear()
            StaffRoleComboBox.SelectedIndex = -1

            StaffList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading staff: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub ListStaff_Click(sender As Object, e As EventArgs) Handles ListStaffButton.Click
        StaffList.Visible = True
        LoadStaff()
    End Sub

    Private Sub StaffUpdateButton_Click(sender As Object, e As EventArgs) Handles StaffUpdateButton.Click
        Try
            ' Establish connection to the database
            conn.Open()

            Dim staffName As String = StaffNameTextBox.Text
            Dim staffEmail As String = StaffEmailTextBox.Text
            Dim staffRole As String = StaffRoleComboBox.Text
            Dim updatedAt As DateTime = DateTime.Now
            Dim hashedPwd As String = HashPassword(staffName, staffEmail)


            ' Construct SQL UPDATE query with parameters for staff
            Dim updateQuery As String = "UPDATE staff SET name = @name, email=@email, role = @role, password = @pwd, updated_at = @updatedAt WHERE staff_id = @staffId"
            Using command As New MySqlCommand(updateQuery, conn)
                ' Set parameter values for staff
                command.Parameters.AddWithValue("@staffId", StaffId)
                command.Parameters.AddWithValue("@name", staffName)
                command.Parameters.AddWithValue("@email", staffEmail)
                command.Parameters.AddWithValue("@role", staffRole)
                command.Parameters.AddWithValue("@pwd", hashedPwd)
                command.Parameters.AddWithValue("@updatedAt", updatedAt)

                ' Execute the query 
                command.ExecuteNonQuery()

                MessageBox.Show("Staff updated successfully!")
            End Using

            conn.Close()

            StaffUpdateButton.Enabled = False
            LoadStaff()

        Catch ex As Exception
            MessageBox.Show("Error updating staff: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub StaffClearButton_Click(sender As Object, e As EventArgs) Handles StaffClearButton.Click
        StaffNameTextBox.Clear()
        StaffEmailTextBox.Clear()
        StaffRoleComboBox.SelectedIndex = -1
        StaffUpdateButton.Enabled = False

    End Sub

    Private Sub ProductsSearchButton_Click(sender As Object, e As EventArgs)
        Try
            ' Establish connection to the database
            conn.Open()
            ProductList.Rows.Clear()

            Dim q As String = ProductsSearchInput.Text


            ' Construct SQL SELECT query

            Dim selectQuery As String = String.Format("SELECT product_id AS Id, name AS Name, price AS Price, quantity AS Quantity, description AS Description FROM products WHERE name LIKE '%{0}%' OR description LIKE '%{0}%';", q)

            Using adapter As New MySqlDataAdapter(selectQuery, conn)

                Dim productDataSet As New DataSet
                adapter.Fill(productDataSet)
                If productDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In productDataSet.Tables(0).Rows
                        ProductList.Rows.Add(row("Id"), row("Name"), row("Price"), row("Quantity"), row("Description"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            ProductQuantityTextBox.Clear()
            ProductDescriptionTextBox.Clear()

            ProductList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub
    Private Sub TellerDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub StaffAdminSidePanel_Paint(sender As Object, e As PaintEventArgs) Handles StaffAdminSidePanel.Paint

    End Sub

    Private Sub StaffSearchInput_TextChanged(sender As Object, e As EventArgs) Handles StaffSearchInput.TextChanged
        Try
            ' Establish connection to the database
            conn.Open()
            StaffList.Rows.Clear()

            Dim q As String = StaffSearchInput.Text


            ' Construct SQL SELECT query

            Dim selectQuery As String = String.Format("SELECT name AS Name, email AS Email, role AS Role FROM staff WHERE name LIKE '%{0}%';", q)

            Using adapter As New MySqlDataAdapter(selectQuery, conn)

                Dim staffDataSet As New DataSet
                adapter.Fill(staffDataSet)
                If staffDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In staffDataSet.Tables(0).Rows
                        StaffList.Rows.Add(row("Name"), row("Email"), row("Role"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            ProductQuantityTextBox.Clear()
            ProductDescriptionTextBox.Clear()

            ProductList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub ProductsSearchInput_TextChanged(sender As Object, e As EventArgs) Handles ProductsSearchInput.TextChanged
        Try
            ' Establish connection to the database
            conn.Open()
            ProductList.Rows.Clear()

            Dim q As String = ProductsSearchInput.Text


            ' Construct SQL SELECT query

            Dim selectQuery As String = String.Format("SELECT product_id AS Id, name AS Name, price AS Price, quantity AS Quantity, description AS Description FROM products WHERE name LIKE '%{0}%' OR description LIKE '%{0}%';", q)

            Using adapter As New MySqlDataAdapter(selectQuery, conn)

                Dim productDataSet As New DataSet
                adapter.Fill(productDataSet)
                If productDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In productDataSet.Tables(0).Rows
                        ProductList.Rows.Add(row("Id"), row("Name"), row("Price"), row("Quantity"), row("Description"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            ProductQuantityTextBox.Clear()
            ProductDescriptionTextBox.Clear()

            ProductList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub StaffSearchButton_Click(sender As Object, e As EventArgs)
        Try
            ' Establish connection to the database
            conn.Open()
            StaffList.Rows.Clear()

            Dim q As String = StaffSearchInput.Text


            ' Construct SQL SELECT query

            Dim selectQuery As String = String.Format("SELECT name AS Name, email AS Email, role AS Role FROM staff WHERE name LIKE '%{0}%';", q)

            Using adapter As New MySqlDataAdapter(selectQuery, conn)

                Dim staffDataSet As New DataSet
                adapter.Fill(staffDataSet)
                If staffDataSet.Tables(0).Rows.Count > 0 Then
                    For Each row As DataRow In staffDataSet.Tables(0).Rows
                        StaffList.Rows.Add(row("Name"), row("Email"), row("Role"), "", "Edit", "Delete")
                    Next
                End If
            End Using
            conn.Close()
            ProductNameTextBox.Clear()
            ProductPriceTextBox.Clear()
            ProductQuantityTextBox.Clear()
            ProductDescriptionTextBox.Clear()

            ProductList.Visible = True

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub
End Class
