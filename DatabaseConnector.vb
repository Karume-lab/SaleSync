Imports System.Data.SqlClient
Imports MySqlConnector

Module DatabaseConnector
    Public ReadOnly ConnectionString As String = "server=localhost;port=33060;user=root;password='root';database=salesync"
    Public ReadOnly Connection As New MySqlConnection(ConnectionString)

    Public Sub OpenConnection()
        If Connection.State <> ConnectionState.Open Then
            Connection.Open()
        End If
    End Sub

    Public Sub CloseConnection()
        If Connection.State = ConnectionState.Open Then
            Connection.Close()
        End If
    End Sub
End Module
