Imports MySql.Data.MySqlClient
Module DBModule
    Public myConn As MySqlConnection = New MySqlConnection("Server=localhost;Database=singsangsung;Uid=root;Pwd=root;")
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    'List of Global Variables
    Public employeeName As String
End Module
