Imports MySql.Data.MySqlClient
Imports System.String

Public Class FormNewEmployee
    Private Sub btFinish_Click(sender As Object, e As EventArgs) Handles btFinish.Click
        Dim form As New FormMain
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If IsNullOrWhiteSpace(tbUsername.Text) Or IsNullOrWhiteSpace(tbPassword.Text) Or IsNullOrWhiteSpace(tbConfirmPassword.Text) Or IsNullOrWhiteSpace(cbAdminStatus.Text) Then
            MsgBox("username, password or status can't be empty")
        Else
            If Not Equals(tbConfirmPassword.Text, tbPassword.Text) Then
                tbPassword.Text = ""
                tbConfirmPassword.Text = ""
                MsgBox("passwords don't match")
            Else
                Dim query As String = "SELECT * FROM employee WHERE employee_id='" & tbUsername.Text & "'"
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
                    MsgBox("Duplicate username")
                Else
                    myDataReader.Close()
                    Dim isAdmin As Integer
                    If Equals(cbAdminStatus.Text, "Admin") Then
                        isAdmin = 1
                    Else
                        isAdmin = 0
                    End If
                    query = "INSERT INTO employee VALUES('" & tbUsername.Text & "','" & tbPassword.Text & "'," & isAdmin & ")"
                    If myConn.State = ConnectionState.Closed Then
                        myConn.Open()
                    End If
                    If myCommand Is Nothing Then
                        myCommand = New MySqlCommand(query, myConn)
                    Else
                        myCommand.CommandText = query
                    End If
                    myCommand.ExecuteNonQuery()
                    MsgBox("New Employee Added")
                    tbUsername.Text = ""
                    tbPassword.Text = ""
                    tbConfirmPassword.Text = ""
                    cbAdminStatus.SelectedIndex = -1
                End If
            End If
            End If
    End Sub
End Class