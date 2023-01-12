Public Class FormLoading
    Private Sub TmrLoad_Tick(sender As Object, e As EventArgs) Handles TmrLoad.Tick
        'this method is for the picture to move from right to left
        PictureBox1.Location = New Point(PictureBox1.Location.X + 25, PictureBox1.Location.Y)

        Dim i As Double
        Static ictr As Integer
        'this method is for progress bar with percent number display
        For i = 1 To 100
            lblLoad.Text = ProgLoad.Value
        Next

        If ictr <= 100 Then
            ProgLoad.Value = ictr
            ictr = ictr + 8
        Else
            FormMain.Show()
            FormLogin.Hide()
            Me.Close()
        End If
    End Sub

    Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Transparent form
        Me.BackColor = Nothing
        TransparencyKey = BackColor
    End Sub
End Class