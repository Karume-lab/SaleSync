Imports MySqlConnector

Module HelperFunctions
    Public loggedInUser As String
    Public Function GetConnection() As String
        Dim ConnectionString As String = "server=localhost;port=3306;user=root;password=root;database=salesync"
        Return ConnectionString
    End Function


    Public Function HashPassword(password As String, salt As String) As String
        ' Optional: Adjust the work factor (higher values = slower, more secure)
        Dim workFactor As Integer = 5

        ' Generate a salt if one isn't provided (recommended)
        If String.IsNullOrEmpty(salt) Then
            salt = BCrypt.Net.BCrypt.GenerateSalt(workFactor)
        End If

        Dim saltedPassword As String = password & salt
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(saltedPassword, workFactor)

        Return hashedPassword
    End Function

    Public Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Return BCrypt.Net.BCrypt.Verify(password, hashedPassword)
    End Function

End Module
