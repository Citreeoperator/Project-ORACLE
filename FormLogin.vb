Imports System.Data.Common
Imports System.DirectoryServices
Imports MySql.Data.MySqlClient

Public Class FormLogin
#Region "Declares"
    Public conn As New MySqlConnection("server =192.168.0.155; user id =root; password=; database =db_mdrrmoopsys; port =3306;")
    Dim adptr As New MySqlDataAdapter
    Dim dtable As DataTable
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn.Open()
        adptr = New MySqlDataAdapter("SELECT * FROM tb_login where username= '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'", conn)
        dtable = New DataTable
        dtable.Clear()
        adptr.Fill(dtable)

        If dtable.Rows.Count() = 0 Then
            MessageBox.Show("LOGIN FAILED, Please re-enter your Account..!")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
            conn.Close()
        Else
            'MessageBox.Show("LOGIN SUCCESSFULLY")
            Me.Hide()
            FormLoading.Show()
        End If
    End Sub
End Class
