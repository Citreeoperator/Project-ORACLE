Imports System.Diagnostics.Eventing
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient

Public Class FormDashboard
    Public conn As New MySqlConnection("server=192.168.0.154; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.154; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter

    Sub VwGridTR()

        Try
            reload("SELECT * FROM transfer_request order by trid DESC", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub VwGridRS()

        Try
            reload("SELECT * FROM regular_schedule order by rsid DESC", DataGridView2)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub VwGridIR()

        Try
            reload("SELECT * FROM incident_report order by irid DESC", DataGridView3)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Sub CountTR()
        'show count column on dashboard transfer request

        Dim count1 As Integer
        count1 = DataGridView1.RowCount
        Label1.Text = count1.ToString

    End Sub
    Sub CountRS()
        'show count column on dashboard regular schedule

        Dim count2 As Integer
        count2 = DataGridView2.RowCount
        Label3.Text = count2.ToString

    End Sub
    Sub CountIR()
        'show count column on dashboard incident report

        Dim count3 As Integer
        count3 = DataGridView3.RowCount
        Label2.Text = count3.ToString

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        VwGridTR()
        VwGridRS()
        VwGridIR()

        CountTR()
        CountRS()
        CountIR()
    End Sub
End Class