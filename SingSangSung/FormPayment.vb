Imports MySql.Data.MySqlClient

Public Class FormPayment
    Private Sub FormPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalPrice As Integer = 0
        lbPaymentID.Text = "Payment #" & activePaymentNumber
        Dim query As String = "SELECT * FROM transaction WHERE transaction_id=" & activePaymentNumber
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
        lbCustomer.Text = "Customer: " & myDataReader("customer_name")
        lbTime.Text = DateTime.Now
        myDataReader.Close()
        query = "SELECT * FROM room_ol WHERE transaction_id=" & activePaymentNumber
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
        lbRoomNumber.Text = "Room " & myDataReader("room_id")
        lbLength.Text = myDataReader("time_length") & " Hours"
        myDataReader.Close()
        query = "SELECT * FROM room WHERE room_id=" & lbRoomNumber.Text.Substring(5)
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
        lbRoomClass.Text = myDataReader("class_id")
        myDataReader.Close()
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
        lbRoomPrice.Text = "$" & myDataReader("class_price") * lbLength.Text.Substring(0, lbLength.Text.IndexOf(" "))
        totalPrice = lbRoomPrice.Text.Substring(1)
        myDataReader.Close()
        query = "SELECT * FROM fnb_ol WHERE transaction_id=" & activePaymentNumber
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
            Dim fnb_ol As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
            While myDataReader.Read()
                fnb_ol.Add(myDataReader("fnb_id"), myDataReader("num_of_items"))
            End While
            myDataReader.Close()
            Dim pcs As Label
            Dim name As Label
            Dim price As Label
            Dim i As Integer = 0
            Dim pair As KeyValuePair(Of String, Integer)
            For Each pair In fnb_ol
                pcs = New Label
                pcs.Text = pair.Value
                pcs.Name = "lbPcs" & i
                pcs.Location = New Point(10, 125 + (i * 25))
                Me.Controls.Add(pcs)
                name = New Label
                query = "SELECT * FROM fnb WHERE fnb_id='" & pair.Key & "'"
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
                name.Text = myDataReader("fnb_name")
                name.Name = "lbName" & i
                name.Location = New Point(120, 125 + (i * 25))
                Me.Controls.Add(name)
                price = New Label
                price.Text = "$" & myDataReader("fnb_price") * pair.Value
                totalPrice = totalPrice + (myDataReader("fnb_price") * pair.Value)
                price.Name = "lbPrice" & i
                price.Location = New Point(350, 125 + (i * 25))
                Me.Controls.Add(price)
                myDataReader.Close()
                i = i + 1
            Next
        End If
        If Not myDataReader.IsClosed Then
            myDataReader.Close()
        End If
        lbTotal.Text = "Total Price: $" & totalPrice
    End Sub

    Private Sub btConfirm_Click(sender As Object, e As EventArgs) Handles btConfirm.Click
        If Not myDataReader.IsClosed() Then
            myDataReader.Close()
        End If
        Dim query As String = "UPDATE transaction SET isPaid=1 WHERE transaction_id=" & activePaymentNumber
        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If
        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(query, myConn)
        Else
            myCommand.CommandText = query
        End If
        myCommand.ExecuteNonQuery()
        MsgBox("Payment Success")
        Dim form As New FormMain
        form.Show()
        Me.Hide()
    End Sub
End Class