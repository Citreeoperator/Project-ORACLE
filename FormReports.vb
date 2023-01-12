Public Class FormReports
    Private Sub btnPTS_Click(sender As Object, e As EventArgs) Handles btnPTS.Click
        FormPT.TopLevel = False
        pnlReports.Controls.Add(FormPT)
        FormPT.BringToFront()
        FormPT.Show()
    End Sub

    Private Sub btnIR_Click(sender As Object, e As EventArgs) Handles btnIR.Click
        ReportIR.TopLevel = False
        pnlReports.Controls.Add(ReportIR)
        ReportIR.BringToFront()
        ReportIR.Show()
    End Sub

    Private Sub btnIMT_Click(sender As Object, e As EventArgs) Handles btnIMT.Click
        ReportIMT.TopLevel = False
        pnlReports.Controls.Add(ReportIMT)
        ReportIMT.BringToFront()
        ReportIMT.Show()
    End Sub

    Private Sub btnPersonnel_Click(sender As Object, e As EventArgs) Handles btnPersonnel.Click
        ReportPersonnel.TopLevel = False
        pnlReports.Controls.Add(ReportPersonnel)
        ReportPersonnel.BringToFront()
        ReportPersonnel.Show()
    End Sub
End Class