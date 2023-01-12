Imports MySql.Data.MySqlClient
Public Class FormRS
    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    'ForGridview
    Sub Updating()

        If DataGridView1.Columns(e.ColumnIndex).Name = "Edit" Then
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            txtRsid.Text = dr.Cells(0).Value.ToString()
            txtDate.Text = dr.Cells(1).Value.ToString()
            txtName.Text = dr.Cells(2).Value.ToString()
            txtCase.Text = dr.Cells(3).Value.ToString()
            txtAge.Text = dr.Cells(4).Value.ToString()
            cmbGender.Text = dr.Cells(5).Value.ToString()
            cmbAddress.Text = dr.Cells(6).Value.ToString()
            txtCName.Text = dr.Cells(7).Value.ToString()
            txtRelation.Text = dr.Cells(8).Value.ToString()
            txtContact.Text = dr.Cells(9).Value.ToString()
            txtOrigin.Text = dr.Cells(10).Value.ToString()
            txtDestination.Text = dr.Cells(11).Value.ToString()
            cmbDriver.Text = dr.Cells(12).Value.ToString()
            txtRefer.Text = dr.Cells(13).Value.ToString()
            txtRequest.Text = dr.Cells(14).Value.ToString()
            txtDispatch.Text = dr.Cells(15).Value.ToString()
            txtRemarks.Text = dr.Cells(16).Value.ToString()
        End If

    End Sub
    Sub Removing()

        Try

        Catch ex As Exception
            Bura()
            VwGridview()
        End Try

    End Sub

    Sub VwGridview()

        Try
            reload("SELECT * FROM regular_schedule order by rsid DESC", DataGridView1)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub clickGridView()
        Dim i As Integer
        Try
            With DataGridView1
                If .CurrentCell.Value Is Nothing Then
                    Exit Sub
                Else
                    i = .CurrentRow.Index
                    txtRsid.Text = .Rows(i).Cells(0).Value.ToString()
                    txtDate.Text = .Rows(i).Cells(1).Value.ToString()
                    txtName.Text = .Rows(i).Cells(2).Value.ToString()
                    txtCase.Text = .Rows(i).Cells(3).Value.ToString()
                    txtAge.Text = .Rows(i).Cells(4).Value.ToString()
                    cmbGender.Text = .Rows(i).Cells(5).Value.ToString()
                    cmbAddress.Text = .Rows(i).Cells(6).Value.ToString()
                    txtCName.Text = .Rows(i).Cells(7).Value.ToString()
                    txtRelation.Text = .Rows(i).Cells(8).Value.ToString()
                    txtContact.Text = .Rows(i).Cells(9).Value.ToString()
                    txtOrigin.Text = .Rows(i).Cells(10).Value.ToString()
                    txtDestination.Text = .Rows(i).Cells(11).Value.ToString()
                    cmbDriver.Text = .Rows(i).Cells(12).Value.ToString()
                    txtRefer.Text = .Rows(i).Cells(13).Value.ToString()
                    txtRequest.Text = .Rows(i).Cells(14).Value.ToString()
                    txtDispatch.Text = .Rows(i).Cells(15).Value.ToString()
                    txtRemarks.Text = .Rows(i).Cells(16).Value.ToString()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Sub Bagohin()
        'this is for message that display before updating records

        Dim result As DialogResult = MessageBox.Show("Update Data?", "EDIT", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("Successfully Updated !", MsgBoxStyle.Information, "Notice")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Updating Cancelled")
        End If
    End Sub

    Sub Bura()
        'this is for message that display before deleting records

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete?", "DELETE DATA", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("Data deleted !", MsgBoxStyle.Information, "Notice")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("Deleting Cancelled")
        End If
    End Sub


    Sub clearfield()
        'this is for clearing the fields on textbox
        txtRsid.Text = ""
        txtDate.Clear()
        txtName.Clear()
        txtCase.Clear()
        txtAge.Clear()
        cmbGender.Text = ""
        cmbAddress.Text = ""
        txtCName.Clear()
        txtRelation.Clear()
        txtContact.Clear()
        txtOrigin.Clear()
        txtDestination.Clear()
        cmbDriver.Text = ""
        txtRefer.Clear()
        txtRequest.Clear()
        txtDispatch.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Make running title in form
        Me.Text = Me.Text.Substring(1) & Me.Text.Substring(0, 1)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' this is for saving record

        Try
            create("INSERT INTO regular_schedule (rsid, date, name, patientcase, age, gender, address, contactname, relationship, contactno, origin, destination, driver, refer, request, dispatch, remarks) VALUES ('" & txtRsid.Text & "', '" & txtDate.Text & "', '" & txtName.Text & "', '" & txtCase.Text & "', '" & txtAge.Text & "', '" & cmbGender.Text & "', '" & cmbAddress.Text & "', '" & txtCName.Text & "', '" & txtRelation.Text & "', '" & txtContact.Text & "', '" & txtOrigin.Text & "', '" & txtDestination.Text & "', '" & cmbDriver.Text & "', '" & txtRefer.Text & "', '" & txtRequest.Text & "', '" & txtDispatch.Text & "', '" & txtRemarks.Text & "')")
            clearfield()
            VwGridview()
        Catch ex As Exception
            MsgBox("Data saved !", MsgBoxStyle.Information, "Notice")
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'this method is to update data on records

        Try
            Bagohin()
            updates("UPDATE regular_schedule SET date = '" & txtDate.Text & "', name = '" & txtName.Text & "', patientcase='" & txtCase.Text & "', age='" & txtAge.Text & "', gender='" & cmbGender.Text & "', address='" & cmbAddress.Text & "', contactname='" & txtCName.Text & "', relationship='" & txtRelation.Text & "', contactno='" & txtContact.Text & "', origin='" & txtOrigin.Text & "', destination='" & txtDestination.Text & "', driver='" & cmbDriver.Text & "', refer='" & txtRefer.Text & "', request='" & txtRequest.Text & "', dispatch='" & txtDispatch.Text & "', remarks='" & txtRemarks.Text & "' WHERE rsid='" & txtRsid.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        'this method is to delete data on records

        Try
            Bura()
            delete("DELETE FROM regular_schedule where rsid='" & txtRsid.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clickGridView()
    End Sub

    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        clearfield()
    End Sub

    Private Sub FormRS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub
End Class