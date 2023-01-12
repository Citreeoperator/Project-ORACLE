Imports MySql.Data.MySqlClient
Public Class pnlReportEmployee
    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter

    Sub CountTR()
        'show count column

        Dim count As Integer
        count = DataGridView1.RowCount
        Label1.Text = count.ToString

    End Sub
    Sub VwGridview()

        Try
            reload("SELECT * FROM employee order by empid DESC", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub pnlReportTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
        CountTR()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class