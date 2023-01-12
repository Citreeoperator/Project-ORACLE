Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Module CDUDDbConnect

    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

#Region "declaration"
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public Property MsgBoxResults As Object
    Public Property e As Object

#End Region
    Sub Bagohin()
        Dim result As DialogResult = MessageBox.Show("Update Data?", "edit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("Successfully Updated !", MsgBoxStyle.Information, "Notice")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Updating Cancelled")
        End If
    End Sub

    Sub Bura()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "remove", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("Data deleted !", MsgBoxStyle.Information, "Notice")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Deleting Cancelled")
        End If
    End Sub
    'this method Is For insert data
    Public Sub create(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("FAILED TO SAVE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("SUCCESSFULLY SAVED", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    'this method is to display data from database into datagridview
    Public Sub reload(ByVal sql As String, ByVal dtg As Object)
        Try
            dt = New DataTable
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            dtg.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    ' this method is to update record
    Public Sub updates(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql

                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            conn.Open()
            With cmd
                .Connection = conn
                .CommandText = sql

                result = cmd.ExecuteNonQuery
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

End Module
