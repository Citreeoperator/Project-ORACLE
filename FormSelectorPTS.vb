Public Class formSelectorPTS
    'Private Sub btnTR_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub btnRS_Click(sender As Object, e As EventArgs)

    'End Sub

    Private Sub btnPTS_Click(sender As Object, e As EventArgs) Handles btnPTS.Click
        Dim selectTR As New pnlReportTR()

        FormTR.TopLevel = False
        pnlPTSSelect.Controls.Add(FormTR)
        FormTR.BringToFront()
        FormTR.Show()
    End Sub

    Private Sub btnIR_Click(sender As Object, e As EventArgs) Handles btnIR.Click
        Dim selectRS As New pnlReportRS()

        FormRS.TopLevel = False
        pnlPTSSelect.Controls.Add(FormRS)
        FormRS.BringToFront()
        FormRS.Show()
    End Sub
End Class