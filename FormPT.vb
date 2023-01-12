Public Class FormPT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTR.Click
        Dim ReportTR As New pnlReportTR()

        ReportTR.TopLevel = False
        pnlRPTContainer.Controls.Add(ReportTR)
        ReportTR.BringToFront()
        ReportTR.Show()
    End Sub

    Private Sub btnRS_Click(sender As Object, e As EventArgs) Handles btnRS.Click
        Dim ReportRS As New pnlReportRS()

        ReportRS.TopLevel = False
        pnlRPTContainer.Controls.Add(ReportRS)
        ReportRS.BringToFront()
        ReportRS.Show()
    End Sub

    'Private Sub pnlRPTContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlRPTContainer.Paint

    'End Sub
End Class