Imports MySqlConnector

Public Class AdminDashboard

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductList.Visible = False
        StaffList.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ProductsSearchInput.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles AdminBody.Paint

    End Sub

    Private Sub ProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductList.CellContentClick

    End Sub

    Private Sub LoadProducts()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='root';database=salesync"
        Dim conn As MySqlConnection
        conn = New MySqlConnection(ConnectionString)

        Try
            ' Establish connection to the database
            conn.Open()

            ' Construct SQL SELECT query
            Dim selectQuery As String = "SELECT product_id AS Id, name AS Name, price AS Price, description AS Description, quantity AS Quantity FROM products"
            Dim adapter As New MySqlDataAdapter(selectQuery, conn)

            ' Create a DataSet to store the retrieved data
            Dim productsDataSet As New DataSet()

            ' Fill the DataSet with the data from the query
            adapter.Fill(productsDataSet, "Products")

            ' Bind the DataSet to a DataGridView to display the products
            ProductList.DataSource = productsDataSet.Tables("Products")

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub ListProducts_Click(sender As Object, e As EventArgs) Handles ListProducts.Click
        ProductList.Visible = True
        LoadProducts()
    End Sub

    Private Sub StaffTab_Click(sender As Object, e As EventArgs) Handles StaffTab.Click

    End Sub

    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles AddProduct.Click
        Dim addProductForm As New AddProduct()
        addProductForm.Show()
    End Sub

    Private Sub AdminSearchBar_Paint(sender As Object, e As PaintEventArgs) Handles ProductsSearchBar.Paint

    End Sub

    Private Sub StaffList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffList.CellContentClick

    End Sub

    Private Sub AddStaff_Click(sender As Object, e As EventArgs) Handles AddStaff.Click
        Dim addStaffForm As New AddStaff()
        addStaffForm.Show()
    End Sub

    Private Sub LoadStaff()
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password='root';database=salesync"
        Dim conn As MySqlConnection
        conn = New MySqlConnection(ConnectionString)

        Try
            ' Establish connection to the database
            conn.Open()

            ' Construct SQL SELECT query for staff
            Dim selectQuery As String = "SELECT staff_id AS Id, name AS Name, email AS Email, role AS Role FROM staff"
            Dim adapter As New MySqlDataAdapter(selectQuery, conn)

            ' Create a DataSet to store the retrieved data
            Dim staffDataSet As New DataSet()

            ' Fill the DataSet with the data from the query
            adapter.Fill(staffDataSet, "Staff")

            ' Bind the DataSet to a DataGridView to display the staff
            StaffList.DataSource = staffDataSet.Tables("Staff")

        Catch ex As Exception
            MessageBox.Show("Error loading staff: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Sub ListStaff_Click(sender As Object, e As EventArgs) Handles ListStaff.Click
        StaffList.Visible = True
        LoadStaff()
    End Sub
End Class
