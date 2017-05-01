Imports MySql.Data.MySqlClient
Imports System.String

Public Class FormAddMenu
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Dim form As New FormMain
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If IsNullOrWhiteSpace(tbCode.Text) Or IsNullOrWhiteSpace(tbName.Text) Or IsNullOrWhiteSpace(tbPrice.Text) Then
            MsgBox("Code or Name or Price can't be empty")
        Else
            Dim query As String = "SELECT * FROM fnb"
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
                MsgBox("Duplicate Menu Code")
                myDataReader.Close()
            Else
                myDataReader.Close()
                query = "INSERT INTO fnb VALUES ('" & tbCode.Text & "','" & tbName.Text & "'," & tbPrice.Text & ")"
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If
                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(query, myConn)
                Else
                    myCommand.CommandText = query
                End If
                myCommand.ExecuteNonQuery()
                tbCode.Text = Empty
                tbName.Text = Empty
                tbPrice.Text = Empty
                MsgBox("New Menu Added")
            End If
        End If
    End Sub
End Class