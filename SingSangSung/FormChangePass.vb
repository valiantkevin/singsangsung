Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.String
Public Class FormChangePass
    Dim oldPassword As String
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim form As New FormMain
        form.Show()
        Me.Hide()
    End Sub
    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If IsNullOrEmpty(tbOld.Text) Or IsNullOrEmpty(tbNew1.Text) Or IsNullOrEmpty(tbNew2.Text) Then
            MsgBox("Password can't be empty")
        Else
            If Not oldPassword.Equals(tbOld.Text) Then
                MsgBox("Old Password is wrong. Please check again")
            Else
                If Not tbNew1.Text.Equals(tbNew2.Text) Then
                    MsgBox("New Password don't match")
                Else
                    Dim query As String = "UPDATE employee SET employee_password='" & tbNew1.Text & "' WHERE employee_id='" & employeeName & "'"
                    If myConn.State = ConnectionState.Closed Then
                        myConn.Open()
                    End If
                    If myCommand Is Nothing Then
                        myCommand = New MySqlCommand(query, myConn)
                    Else
                        myCommand.CommandText = query
                    End If
                    myCommand.ExecuteNonQuery()
                    Dim form As New FormMain
                    form.Show()
                    Me.Hide()
                End If
            End If
        End If
    End Sub
    Private Sub FormChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT * FROM employee WHERE employee_id='" & employeeName & "'"
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
        oldPassword = myDataReader("employee_password")
        myDataReader.Close()
    End Sub
End Class