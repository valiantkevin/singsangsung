Imports MySql.Data.MySqlClient
Module DBModule
    Public myConn As MySqlConnection = New MySqlConnection("Server=localhost;Database=singsangsung;Uid=root;Pwd=root;")
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    'List of Global Variables
    Public employeeName As String
    Public isAdmin As Boolean
    Public numberOfRoom As Integer
    Public roomList As Dictionary(Of Integer, Integer) = New Dictionary(Of Integer, Integer)
    Public transactionUnpaid As Queue(Of Integer) = New Queue(Of Integer)
End Module
