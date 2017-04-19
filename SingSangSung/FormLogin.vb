Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frLogin
    Private Sub frLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not System.IO.File.Exists(System.IO.Path.Combine(path, file)) Then
            Dim fs As FileStream = System.IO.File.Create(System.IO.Path.Combine(path, file))
            fs.Close()
            Dim data As String() = New String(1) {numberOfRoom.ToString, "10"}
            Try
                System.IO.File.WriteAllLines(System.IO.Path.Combine(path, file), data)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            fs.Close()
        Else
            Dim data As String() = System.IO.File.ReadAllLines(System.IO.Path.Combine(path, file))
            numberOfRoom = data(0)
        End If
    End Sub
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim query As String = "SELECT employee_id, employee_password FROM employee where employee_id='" & tbUsername.Text & "' AND employee_password='" & tbPassword.Text & "'"
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
            employeeName = tbUsername.Text
            FormMain.Show()
            Me.Hide()
        Else
            MsgBox("Username / Password salah!")
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub
    Private Sub Login_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Return Then
            btLogin.PerformClick()
        End If
    End Sub
    Private Sub btExit_Click(sender As System.Object, e As System.EventArgs) Handles btExit.Click
        Application.Exit()
    End Sub
End Class
