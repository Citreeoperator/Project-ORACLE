Public Class FormPersonnel
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        FormEmployee.TopLevel = False
        pnlContainer.Controls.Add(FormEmployee)
        FormEmployee.BringToFront()
        FormEmployee.Show()
    End Sub

    Private Sub btnVolunteer_Click(sender As Object, e As EventArgs) Handles btnVolunteer.Click
        FormVolunteer.TopLevel = False
        pnlContainer.Controls.Add(FormVolunteer)
        FormVolunteer.BringToFront()
        FormVolunteer.Show()
    End Sub
End Class