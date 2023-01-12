Public Class ReportPersonnel
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        Dim ReportEmployee As New pnlReportEmployee()

        ReportEmployee.TopLevel = False
        pnlRPTContainer.Controls.Add(ReportEmployee)
        ReportEmployee.BringToFront()
        ReportEmployee.Show()
    End Sub

    Private Sub btnVolunteer_Click(sender As Object, e As EventArgs) Handles btnVolunteer.Click
        Dim ReportVolunteer As New pnlReportVolunteer()

        ReportVolunteer.TopLevel = False
        pnlRPTContainer.Controls.Add(ReportVolunteer)
        ReportVolunteer.BringToFront()
        ReportVolunteer.Show()
    End Sub
End Class