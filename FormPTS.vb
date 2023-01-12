Imports System.Runtime.CompilerServices

Public Class FormPTS
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Make running title in form
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        End
    End Sub
End Class