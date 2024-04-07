Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector

Public Class TellerDashboard

    Dim conn As New MySqlConnection(GetConnection)

    Private productDictionary As New Dictionary(Of Integer, String)()
    Private sumTotal As Double = 0
    Private Const TAX_RATE As Double = 0.16
    Private Const DISCOUNT_RATE As Double = 0.03
    Private Const MIN_DISCOUNT_AMOUNT As Double = 1000

    Private Sub LoadProductItems()
        Try
            ' Establish connection to the database
            conn.Open()

            ' Clear existing items in the ComboBox and the dictionary
            cmbProduct.Items.Clear()
            productDictionary.Clear()

            ' Construct SQL SELECT query
            Dim selectQuery As String = "SELECT product_id AS Id, name AS Name FROM products"
            Using command As New MySqlCommand(selectQuery, conn)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Add product ID and name to the dictionary
                        Dim productId As Integer = reader.GetInt32("Id")
                        Dim productName As String = reader.GetString("Name")
                        productDictionary.Add(productId, productName)

                        ' Add product name to the ComboBox
                        cmbProduct.Items.Add(productName)
                    End While
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading products: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try

    End Sub

    Private Sub InsertSale()
        Try
            ' Establish connection to the database
            conn.Open()

            ' Declare variables for sale details
            Dim dateOfPurchase As DateTime = DateTime.Now
            Dim totalPrice As Decimal = 0 ' Set the total price
            Dim servedBy As Integer = 4 ' Set the staff ID who served the sale

            ' Construct SQL INSERT query for sale
            Dim insertSaleQuery As String = "INSERT INTO sale (date_of_purchase, total_price, served_by, updated_at) VALUES (@date_of_purchase, @total_price, @served_by, @updated_at); SELECT LAST_INSERT_ID();"

            ' Execute the query to insert sale and get the inserted sale_id
            Dim saleId As Integer
            Using command As New MySqlCommand(insertSaleQuery, conn)
                command.Parameters.AddWithValue("@date_of_purchase", dateOfPurchase)
                command.Parameters.AddWithValue("@total_price", totalPrice)
                command.Parameters.AddWithValue("@served_by", servedBy)
                command.Parameters.AddWithValue("@updated_at", DateTime.Now)
                saleId = Convert.ToInt32(command.ExecuteScalar())
            End Using

            ' Construct SQL INSERT query for sale items
            Dim insertSaleItemQuery As String = "INSERT INTO sale_item (product, unit_price, quantity, sale, updated_at) VALUES (@product, @unit_price, @quantity, @sale, @updated_at)"

            ' Declare and add sale items
            Dim saleItems As New Dictionary(Of Integer, Integer)()

            ' Iterate through DataGridView rows to collect sale items
            For Each row As DataGridViewRow In dgridProducts.Rows
                ' Check if the row is not a new row
                If Not row.IsNewRow Then
                    Dim productName As String = row.Cells(0).Value.ToString()

                    ' Retrieve the product ID based on the product name
                    Dim productId As Integer = GetProductIdByName(productName)

                    If productId <> -1 Then ' Check if product ID is found
                        Dim quantity As Integer = CInt(row.Cells(2).Value)

                        ' Add the sale item to the dictionary
                        saleItems.Add(productId, quantity)
                    Else
                        MessageBox.Show("Product '" & productName & "' not found. Sale not recorded.")
                        Return ' Exit the subroutine if product ID is not found
                    End If
                End If
            Next

            ' Insert each sale item
            For Each saleItem In saleItems
                Using command As New MySqlCommand(insertSaleItemQuery, conn)
                    command.Parameters.AddWithValue("@product", saleItem.Key) ' Product ID
                    command.Parameters.AddWithValue("@unit_price", GetUnitPrice(saleItem.Key))
                    command.Parameters.AddWithValue("@quantity", saleItem.Value) ' Quantity of the product sold
                    command.Parameters.AddWithValue("@sale", saleId) ' ID of the sale record
                    command.Parameters.AddWithValue("@updated_at", DateTime.Now)
                    command.ExecuteNonQuery()
                End Using
            Next

            ' Construct SQL UPDATE query to update total price of the sale
            Dim updateQuery As String = "UPDATE sale SET total_price = @totalPrice WHERE sale_id = @saleId"

            Using command As New MySqlCommand(updateQuery, conn)
                command.Parameters.AddWithValue("@totalPrice", CalculateTotalPriceFromGrid())
                command.Parameters.AddWithValue("@saleId", saleId)

                ' Execute the query
                command.ExecuteNonQuery()
            End Using
            MessageBox.Show("Sale recorded successfully!")
        Catch ex As Exception
            MessageBox.Show("Error recording sale: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
    End Sub

    Private Function GetProductIdByName(productName As String) As Integer
        Dim productId As Integer = -1 ' Default value if product ID is not found
        Try
            ' Construct SQL query to retrieve product ID based on product name
            Dim selectProductIdQuery As String = "SELECT product_id FROM products WHERE name = @productName"
            Using command As New MySqlCommand(selectProductIdQuery, conn)
                command.Parameters.AddWithValue("@productName", productName)
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    productId = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving product ID: " & ex.Message)
        End Try
        Return productId
    End Function

    Private Function GetUnitPrice(productId As Integer) As Decimal
        Dim unitPrice As Decimal = 0
        Try
            ' Establish connection to the database
            ' conn.Open()

            ' Construct SQL query to retrieve unit price based on product ID
            Dim selectUnitPriceQuery As String = "SELECT price FROM products WHERE product_id = @productId"
            Using command As New MySqlCommand(selectUnitPriceQuery, conn)
                command.Parameters.AddWithValue("@productId", productId)
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing Then
                    unitPrice = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving unit price: " & ex.Message)
        Finally
            ' Close the database connection
            ' conn.Close()
        End Try
        Return unitPrice
    End Function

    Private Function GetProductPriceByName(productName As String) As Decimal
        Dim price As Decimal = 0
        Try
            ' Establish connection to the database
            conn.Open()

            ' Construct SQL query to retrieve product price based on product name
            Dim selectPriceQuery As String = "SELECT price FROM products WHERE name = @productName"

            Using command As New MySqlCommand(selectPriceQuery, conn)
                command.Parameters.AddWithValue("@productName", productName)

                ' Execute the query and retrieve the price
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    price = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error retrieving product price: " & ex.Message)
        Finally
            ' Close the database connection
            conn.Close()
        End Try
        Return price
    End Function

    Private Function CalculateTotalPriceFromGrid() As Decimal
        Dim totalPrice As Decimal = 0

        For Each row As DataGridViewRow In dgridProducts.Rows
            If Not row.IsNewRow Then
                Dim total As Decimal = CDec(row.Cells(3).Value)
                totalPrice += total
            End If
        Next

        Return totalPrice
    End Function



    Private Sub TellerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProductItems()
        lblUser.Text = loggedInUser
        lblDate.Text = Date.Now()
    End Sub
    Private Sub TellerDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub AdminDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        LoginForm.Show()
    End Sub

    Private Sub cmbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduct.SelectedIndexChanged
        ' Get the selected product name
        Dim selectedProductName As String = cmbProduct.SelectedItem.ToString()
        ' Get the corresponding product ID from the dictionary
        Dim selectedProductId As Integer = productDictionary.FirstOrDefault(Function(pair) pair.Value = selectedProductName).Key
        ' Use the selected product ID as needed
        ' MessageBox.Show("Selected Product ID: " & selectedProductId.ToString())
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim productName As String = cmbProduct.Text
        Dim price As Double = GetProductPriceByName(productName)
        Dim quantity As Integer = CInt(txtQuantity.Text)
        Dim Total As Double = price * quantity

        dgridProducts.Rows.Add(productName, price, quantity, Total)
        updateTotals(Total)
    End Sub

    Private Sub updateTotals(ByVal total As Double)

        ' Declare variables for discount, grand total, tax, and net total
        Dim discount As Double = 0
        Dim grandTotal As Double = 0

        ' Calculate the tax and net total
        Dim tax As Double = TAX_RATE * sumTotal
        Dim netTotal As Double = sumTotal - tax

        ' Calculate the discount if the total price is greater than the minimum discount amount
        If sumTotal > MIN_DISCOUNT_AMOUNT Then
            discount = DISCOUNT_RATE * sumTotal
        End If

        ' Update the total price
        sumTotal += total
        grandTotal = sumTotal - discount

        ' Update the labels with the new values
        lblGrandTotal.Text = "Ksh. " & grandTotal
        lblTax.Text = "Ksh. " & tax
        lblDiscount.Text = "Ksh. " & discount
        lblNetTotal.Text = "Ksh. " & netTotal

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs)
        InsertSale()
        dgridProducts.Rows.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        dgridProducts.Rows.Clear()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub dgridProducts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgridProducts.CellContentClick

    End Sub

End Class