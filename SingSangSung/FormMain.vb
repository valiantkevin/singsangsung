Imports MySql.Data.MySqlClient
Imports System.String
Public Class FormMain
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
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
        refreshStatus()
    End Sub
    Private Sub btRoom_Click(sender As Object, e As EventArgs)
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim room As Button = DirectCast(sender, Button)
        Dim transactionNumber As Integer
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
        If roomList.TryGetValue(lbRoomNumber.Text.Substring(5), transactionNumber) Then
            query = "SELECT * FROM transaction WHERE transaction_id=" & transactionNumber
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
            tbCustomerName.Text = myDataReader("customer_name")
            tbCustomerName.Enabled = False
        Else
            tbCustomerName.Text = ""
            tbCustomerName.Enabled = True
        End If
        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
        refreshList()
        If Not tbCustomerName.Enabled Then
            refreshRoomTimer(transactionNumber)
        Else
            lbTimeLeft.Text = "00:00:00 Left"
        End If
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Dim form As New FormChangePass()
        Me.Hide()
        form.Show()
    End Sub
    Private Sub btOrderRoom_Click(sender As Object, e As EventArgs) Handles btOrderRoom.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim roomNumber As String = lbRoomNumber.Text.Substring(5)
        Dim transactionNumber As Integer
        Dim length As Integer
        If IsNullOrWhiteSpace(tbCustomerName.Text) Or IsNullOrWhiteSpace(cbAddTime.Text) Then
            MsgBox("Customer Name or Time can't be empty")
        Else
            If roomList.TryGetValue(lbRoomNumber.Text.Substring(5), transactionNumber) Then
                Dim query As String = "SELECT * FROM room_ol WHERE transaction_id=" & transactionNumber & " AND room_id=" & roomNumber
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
                length = myDataReader("time_length")
                length = length + cbAddTime.Text.Substring(0, cbAddTime.Text.IndexOf(" "))
                myDataReader.Close()
                query = "UPDATE room_ol SET time_length=" & length & " WHERE transaction_id=" & transactionNumber & " AND room_id=" & roomNumber
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                MsgBox("Add Time Success!")
                cbAddTime.SelectedIndex = -1
            Else
                Dim query As String = "SELECT * FROM keystore"
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
                Dim next_transaction_id As Integer = myDataReader("next_transaction_id")
                myDataReader.Close()
                query = "INSERT INTO transaction(transaction_id,customer_name,employee_id,isPaid) VALUES (" & next_transaction_id & ",'" & tbCustomerName.Text & "','" & employeeName & "',0)"
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                query = "INSERT INTO room_ol (room_id,transaction_id,time_length) VALUES (" & roomNumber & "," & next_transaction_id & "," & cbAddTime.Text.Substring(0, cbAddTime.Text.IndexOf(" ")) & ")"
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                next_transaction_id = next_transaction_id + 1
                MsgBox("Order New Room Success")
                query = "UPDATE keystore SET next_transaction_id=" & next_transaction_id
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                tbCustomerName.Enabled = False
                cbAddTime.SelectedIndex = -1
            End If
        End If
        refreshStatus()
    End Sub

    Private Sub AddNewRoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewRoomToolStripMenuItem.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        If isAdmin = 0 Then
            MsgBox("you're not authorized")
        Else
            Dim form As New FormAddRoom
            form.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddNewMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewMenuToolStripMenuItem.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        If isAdmin = 0 Then
            MsgBox("you're not authorized")
        Else
            Dim form As New FormAddMenu
            form.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        If isAdmin = 0 Then
            MsgBox("you're not authorized")
        Else
            Dim form As New FormNewEmployee
            form.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btInsert_Click(sender As Object, e As EventArgs) Handles btInsert.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        If Not tbCustomerName.Enabled Then
            If IsNullOrWhiteSpace(tbFnBCode.Text) Or IsNullOrWhiteSpace(tbPortion.Text) Or (Equals(tbFnBCode.Text, "Code")) Or (Equals(tbPortion.Text, "Portion")) Then
                MsgBox("Code or Portion cannot be empty")
            ElseIf (CInt(tbPortion.Text) < 1) Then
                MsgBox("Portion cannot be less than one")
            Else
                Dim query As String = "SELECT * FROM fnb WHERE fnb_id='" & tbFnBCode.Text & "'"
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
                    myDataReader.Close()
                    Dim transactionNumber As Integer
                    roomList.TryGetValue(lbRoomNumber.Text.Substring(5), transactionNumber)
                    query = "SELECT * FROM fnb_ol WHERE transaction_id=" & transactionNumber & " AND fnb_id='" & tbFnBCode.Text & "'"
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
                        myDataReader.Read()
                        Dim num_of_items As Integer = myDataReader("num_of_items")
                        myDataReader.Close()
                        query = "UPDATE fnb_ol SET num_of_items=" & num_of_items + tbPortion.Text & " WHERE transaction_id=" & transactionNumber & " AND fnb_id='" & tbFnBCode.Text & "'"
                        If myConn.State = ConnectionState.Closed Then
                            myConn.Open()
                        End If
                        If myCommand Is Nothing Then
                            myCommand = New MySqlCommand(query, myConn)
                        Else
                            myCommand.CommandText = query
                        End If
                        myCommand.ExecuteNonQuery()
                        myCommand.ExecuteNonQuery()
                        MsgBox("Menu order success")
                        tbPortion.Text = "Portion"
                        tbFnBCode.Text = "Code"
                    Else
                        myDataReader.Close()
                        query = "INSERT INTO fnb_ol VALUES('" & tbFnBCode.Text & "'," & transactionNumber & "," & tbPortion.Text & ")"
                        If myConn.State = ConnectionState.Closed Then
                            myConn.Open()
                        End If
                        If myCommand Is Nothing Then
                            myCommand = New MySqlCommand(query, myConn)
                        Else
                            myCommand.CommandText = query
                        End If
                        myCommand.ExecuteNonQuery()
                        MsgBox("Menu order success")
                        tbPortion.Text = "Portion"
                        tbFnBCode.Text = "Code"
                    End If
                Else
                    MsgBox("The code is not on the menu")
                    myDataReader.Close()
                End If
                refreshList()
            End If
        Else
            MsgBox("Room is not occupied")
        End If
    End Sub

    Private Sub refreshStatus()
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        roomList.Clear()
        transactionUnpaid.Clear()
        Dim query = "SELECT * FROM transaction WHERE isPaid=0"
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
                transactionUnpaid.Enqueue(myDataReader("transaction_id"))
            End While
            myDataReader.Close()
            For Each a As Integer In transactionUnpaid
                query = "SELECT * FROM room_ol WHERE transaction_id=" & a
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
                roomList.Add(myDataReader("room_id"), myDataReader("transaction_id"))
                myDataReader.Close()
            Next
        End If
        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub refreshList()
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim transactionNumber As Integer
        Dim total As Integer = 0
        roomList.TryGetValue(lbRoomNumber.Text.Substring(5), transactionNumber)
        Dim query = "SELECT * FROM fnb_ol WHERE transaction_id=" & transactionNumber
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        myDataReader = myCommand.ExecuteReader
        lvFnB.Items.Clear()
        lvFnB.View = View.Details
        lvFnB.BeginUpdate()
        If myDataReader.HasRows Then
            Dim fnb_ol As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
            While myDataReader.Read()
                fnb_ol.Add(myDataReader("fnb_id"), myDataReader("num_of_items"))
            End While
            myDataReader.Close()
            For Each a As KeyValuePair(Of String, Integer) In fnb_ol
                query = "SELECT * FROM fnb WHERE fnb_id='" & a.Key & "'"
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
                Dim item As ListViewItem = New ListViewItem(New String() {myDataReader("fnb_name"), a.Value, myDataReader("fnb_price"), myDataReader("fnb_price") * a.Value})
                total = total + (myDataReader("fnb_price") * a.Value)
                lvFnB.Items.Add(item)
                myDataReader.Close()
            Next
            If Not myDataReader.IsClosed Then
                myDataReader.Close()
            End If
        End If
        lvFnB.EndUpdate()
        lbTotalPrice.Text = total
    End Sub

    Private Sub tbPortion_GotFocus(sender As Object, e As EventArgs) Handles tbPortion.GotFocus
        If (Equals("Portion", tbPortion.Text)) Then
            tbPortion.Text = ""
        End If
    End Sub

    Private Sub tbFnBCode_GotFocus(sender As Object, e As EventArgs) Handles tbFnBCode.GotFocus
        If (Equals("Code", tbFnBCode.Text)) Then
            tbFnBCode.Text = ""
        End If
    End Sub

    Private Sub tbPortion_LostFocus(sender As Object, e As EventArgs) Handles tbPortion.LostFocus
        If (Equals("", tbPortion.Text)) Then
            tbPortion.Text = "Portion"
        End If
    End Sub

    Private Sub tbFnBCode_LostFocus(sender As Object, e As EventArgs) Handles tbFnBCode.LostFocus
        If (Equals("", tbFnBCode.Text)) Then
            tbFnBCode.Text = "Code"
        End If
    End Sub

    Private Sub refreshRoomTimer(transactionNumber As Integer)
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim query As String = "SELECT * FROM room_ol WHERE transaction_id=" & transactionNumber
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
        Dim start As Date
        start = myDataReader("time_start")
        Dim fin As Date = start.AddHours(myDataReader("time_length"))
        If Compare(fin, Date.Now()) Then
            lbTimeLeft.Text = DateDiff(DateInterval.Hour, Date.Now, fin) & ":" & DateDiff(DateInterval.Minute, Date.Now, fin) Mod 60 & ":" & DateDiff(DateInterval.Second, Date.Now, fin) Mod 60 & " Left"
        Else
            lbTimeLeft.Text = "00:00:00 Left"
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim form As New frLogin
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btPayment_Click(sender As Object, e As EventArgs) Handles btPayment.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        If tbCustomerName.Enabled Then
            MsgBox("Room is not occupied")
        Else
            roomList.TryGetValue(lbRoomNumber.Text.Substring(5), activePaymentNumber)
            Dim form As New FormPayment
            form.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class