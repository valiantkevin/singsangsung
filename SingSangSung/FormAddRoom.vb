Imports MySql.Data.MySqlClient
Imports System.String
Public Class FormAddRoom
    Private Sub FormAddRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM room_class"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                cbClass.Items.Add(myDataReader("class_id"))
            End While
        End If
        myDataReader.Close()
    End Sub

    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim form As New FormMain
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If IsNullOrWhiteSpace(tbRoom.Text) Or IsNullOrWhiteSpace(cbClass.Text) Then
            MsgBox("Room ID can't be empty")
        Else
            Dim query As String = "SELECT * FROM room WHERE room_id='" & tbRoom.Text & "'"
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If
            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(query, myConn)
            Else
                myCommand.CommandText = query
            End If
            myDataReader = myCommand.ExecuteReader
            If myDataReader.HasRows Then
                tbRoom.Text = Empty
                MsgBox("Duplicate Room ID")
                myDataReader.Close()
            Else
                myDataReader.Close()
                query = "INSERT INTO room VALUES (" & tbRoom.Text & ",'" & cbClass.Text & "')"
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                tbRoom.Text = Empty
                cbClass.SelectedIndex = -1
                MsgBox("New Room Added")
            End If
        End If
    End Sub
End Class