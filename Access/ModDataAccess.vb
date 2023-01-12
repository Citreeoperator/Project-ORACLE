Imports MySql.Data.MySqlClient
Module ModDataAccess
    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'this method for the connection status of database
    Sub Konek()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
                FormMain.statusdb.Text = "CONNECTED"
                FormMain.statusdb.ForeColor = Color.DarkGreen
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            FormMain.statusdb.Text = "DISCONNECTED"
            FormMain.statusdb.ForeColor = Color.Red
        Finally
            conn.Close()
        End Try

    End Sub

    Public Function open() As MySqlConnection
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return conn
    End Function

    Public Function close() As MySqlConnection
        Try
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return conn
    End Function

End Module