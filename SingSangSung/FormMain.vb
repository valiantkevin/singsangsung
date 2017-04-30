Imports MySql.Data.MySqlClient
Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM room"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        myDataReader = myCommand.ExecuteReader
        Dim room As Button
        Dim i As Integer = 0
        If myDataReader.HasRows Then
            While myDataReader.Read()
                room = New Button
                room.Size = New Drawing.Size(50, 50)
                room.Location = New Point(10 + 60 * (i Mod 4), 10 + 60 * (i \ 4))
                room.Name = "btRoom" & myDataReader("room_id")
                room.Text = "Room " & myDataReader("room_id")
                AddHandler room.Click, AddressOf btRoom_Click
                SplitContainer1.Panel1.Controls.Add(room)
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub btRoom_Click(sender As Object, e As EventArgs)
        Dim room As Button = DirectCast(sender, Button)
        lbRoomNumber.Text = room.Text
        Dim room_id As String = room.Name.Substring(6)
        Dim query As String = "SELECT class_id FROM room WHERE room_id=" & room_id
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        lbRoomClass.Text = myCommand.ExecuteScalar()
        query = "SELECT * FROM room_class WHERE class_id='" & lbRoomClass.Text & "'"
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        myDataReader = myCommand.ExecuteReader
        myDataReader.Read()
        lbRoomPrice.Text = "$" & myDataReader("class_price") & "/Hour"
        lbRoomCapacity.Text = "Max " & myDataReader("max_cap") & " Persons"
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        If isAdmin Then
            MsgBox("You're Authorized")
        Else
            MsgBox("You're Not")
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim form As New FormChangePass()
        Me.Hide()
        form.Show()
    End Sub
End Class