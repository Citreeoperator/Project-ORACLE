Imports System.Drawing.Printing
Imports System.Reflection.Emit
Imports MySql.Data.MySqlClient
Public Class pnlReportRS
    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter

    Sub VwGridview()

        Try
            reload("SELECT * FROM regular_schedule order by rsid DESC", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub CountTR()
        'show count column

        Dim count As Integer
        count = DataGridView1.RowCount
        Label1.Text = count.ToString

    End Sub

    Private Sub pnlReportTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
        CountTR()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.WindowState = FormWindowState.Maximized
        PrintPreviewDialog1.ShowDialog()

    End Sub


    Private Sub btnPageSetup_Click(sender As Object, e As EventArgs) Handles btnPageSetup.Click

        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Landscape = True
        PageSetupDialog1.Document.DefaultPageSettings.PaperSize = New PaperSize("Legal", 1400, 850)
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("PATIENT TRANSPORT SERVICES", New Font("Century Gothic", 14, FontStyle.Bold), Brushes.Black, New Point(10, 30))
        e.Graphics.DrawString("REGULAR SCHEDULE", New Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, New Point(10, 55))
        e.Graphics.DrawString("Date:" + DateTime.Now, New Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, New Point(10, 75))


        'how to print the datagridview
        Dim bmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bmp, New Rectangle(15, 10, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bmp, 0, 100)

    End Sub
End Class