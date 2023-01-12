Imports MySql.Data.MySqlClient

Public Class FormMain
    Public strcon As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Dim i As Integer = 0
    Dim j As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Make running title in form
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)

        'Make a Display Timer in Form
        lblTimer.Text = Date.Now.ToString("hh:mm tt")
        lblDater.Text = Date.Now.ToString("MMMM dd yyyy")

        'Make a blinking label
        Dim str As String = "Copyright 2023 - Powered by SkyeTech" & vbCrLf & "Developed by John Phillip V. Lasheras"
        Dim c(str.Length) As Char
        c = str.ToCharArray
        If j = 0 Then
            lblDate.ForeColor = Color.Blue
            If i < str.Length Then
                lblDate.Text = lblDate.Text & c(i)
                i = i + 1
            Else
                i = 0
                lblDate.Text = ""
            End If
            j = 1
        Else
            j = 0
            lblDate.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Konek()
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub btnPTS_Click(sender As Object, e As EventArgs) Handles btnPTS.Click
        formSelectorPTS.TopLevel = False
        pnlContainer.Controls.Add(formSelectorPTS)
        formSelectorPTS.BringToFront()
        formSelectorPTS.Show()
    End Sub

    Private Sub btnIR_Click(sender As Object, e As EventArgs) Handles btnIR.Click
        FormIR.TopLevel = False
        pnlContainer.Controls.Add(FormIR)
        FormIR.BringToFront()
        FormIR.Show()
    End Sub

    Private Sub btnOP_Click(sender As Object, e As EventArgs) Handles btnOP.Click
        FormPersonnel.TopLevel = False
        pnlContainer.Controls.Add(FormPersonnel)
        FormPersonnel.BringToFront()
        FormPersonnel.Show()
    End Sub

    Private Sub btnCD_Click(sender As Object, e As EventArgs) Handles btnCD.Click
        FormDirectory.TopLevel = False
        pnlContainer.Controls.Add(FormDirectory)
        FormDirectory.BringToFront()
        FormDirectory.Show()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnIMT.Click
        FormReports.TopLevel = False
        pnlContainer.Controls.Add(FormReports)
        FormReports.BringToFront()
        FormReports.Show()
    End Sub

    Private Sub btnAbout_Click_1(sender As Object, e As EventArgs) Handles btnAbout.Click
        FormAbout.TopLevel = False
        pnlContainer.Controls.Add(FormAbout)
        FormAbout.BringToFront()
        FormAbout.Show()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        FormIMT.TopLevel = False
        pnlContainer.Controls.Add(FormIMT)
        FormIMT.BringToFront()
        FormIMT.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FormDashboard.TopLevel = False
        pnlContainer.Controls.Add(FormDashboard)
        FormDashboard.BringToFront()
        FormDashboard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'terminate the application
        Application.Exit()
    End Sub
End Class