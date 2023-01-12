Imports MySql.Data.MySqlClient
Public Class FormVolunteer
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

        If DataGridView1.Columns(e.ColumnIndex).Name = "edit" Then
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            txtID.Text = dr.Cells(0).Value.ToString()
            txtLastname.Text = dr.Cells(1).Value.ToString()
            txtFirstname.Text = dr.Cells(2).Value.ToString()
            txtMI.Text = dr.Cells(3).Value.ToString()
            txtGender.Text = dr.Cells(4).Value.ToString()
            txtAddress.Text = dr.Cells(5).Value.ToString()
            txtBirthdate.Text = dr.Cells(6).Value.ToString()
            txtBirthplace.Text = dr.Cells(7).Value.ToString()
            txtContact.Text = dr.Cells(8).Value.ToString()
            txtContactEmer.Text = dr.Cells(9).Value.ToString()
            txtRelationship.Text = dr.Cells(10).Value.ToString()
            txtAddressEmer.Text = dr.Cells(11).Value.ToString()
            txtContactEmer.Text = dr.Cells(12).Value.ToString()
            txtRemarks.Text = dr.Cells(13).Value.ToString()

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
            reload("SELECT * FROM volunteer order by volunteerid DESC", DataGridView1)
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

                    txtID.Text = .Rows(i).Cells(0).Value.ToString()
                    txtLastname.Text = .Rows(i).Cells(1).Value.ToString()
                    txtFirstname.Text = .Rows(i).Cells(2).Value.ToString()
                    txtMI.Text = .Rows(i).Cells(3).Value.ToString()
                    txtGender.Text = .Rows(i).Cells(4).Value.ToString()
                    txtAddress.Text = .Rows(i).Cells(5).Value.ToString()
                    txtBirthdate.Text = .Rows(i).Cells(6).Value.ToString()
                    txtBirthplace.Text = .Rows(i).Cells(7).Value.ToString()
                    txtContact.Text = .Rows(i).Cells(8).Value.ToString()
                    txtName.Text = .Rows(i).Cells(9).Value.ToString()
                    txtRelationship.Text = .Rows(i).Cells(10).Value.ToString()
                    txtAddressEmer.Text = .Rows(i).Cells(11).Value.ToString()
                    txtContactEmer.Text = .Rows(i).Cells(12).Value.ToString()
                    txtRemarks.Text = .Rows(i).Cells(13).Value.ToString()

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

        txtID.Clear()
        txtLastname.Clear()
        txtFirstname.Clear()
        txtMI.Clear()
        txtGender.Text = ""
        txtAddress.Clear()
        txtBirthdate.Clear()
        txtBirthplace.Clear()
        txtContact.Clear()
        txtName.Clear()
        txtRelationship.Clear()
        txtAddressEmer.Clear()
        txtContactEmer.Clear()
        txtRemarks.Clear()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' this is for saving record

        Try
            create("INSERT INTO volunteer (volunteerid, lastname, firstname, mi, gender, address, birthdate, birthplace, contactno, contactname, relationship, contactaddress, noofcontact, remarks) VALUES ('" & txtID.Text & "', '" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMI.Text & "', '" & txtGender.Text & "', '" & txtAddress.Text & "', '" & txtBirthdate.Text & "', '" & txtBirthplace.Text & "', '" & txtContact.Text & "', '" & txtName.Text & "', '" & txtRelationship.Text & "', '" & txtAddressEmer.Text & "', '" & txtContactEmer.Text & "', '" & txtRemarks.Text & "')")
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
            updates("UPDATE volunteer SET lastname = '" & txtLastname.Text & "', firstname = '" & txtFirstname.Text & "', mi='" & txtMI.Text & "', gender='" & txtGender.Text & "', address='" & txtAddress.Text & "', birthdate='" & txtBirthdate.Text & "', birthplace='" & txtBirthplace.Text & "', contactno='" & txtContact.Text & "', contactname='" & txtName.Text & "', relationship='" & txtRelationship.Text & "', contactaddress='" & txtAddressEmer.Text & "', noofcontact='" & txtContactEmer.Text & "', remarks='" & txtRemarks.Text & "' WHERE volunteerid='" & txtID.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        'this method is to delete data on records

        Try
            Bura()
            delete("DELETE FROM volunteer where volunteerid='" & txtID.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        clearfield()
    End Sub

    Private Sub FormVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clickGridView()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub
End Class