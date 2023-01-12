Imports MySql.Data.MySqlClient
Public Class FormDirectory
    Public conn As New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys; port=3306;")

    Public Function constat() As MySqlConnection
        Return New MySqlConnection("server=192.168.0.155; user id=root; password=; database=db_mdrrmoopsys")
    End Function

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public dset = New DataSet

    'ForGridview
    Sub Updating()

        If DataGridView1.Columns(e.ColumnIndex).Name = "edit" Then
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            txtContactID.Text = dr.Cells(0).Value.ToString()
            txtType.Text = dr.Cells(1).Value.ToString()
            txtAgencybrgy.Text = dr.Cells(2).Value.ToString()
            txtPerson.Text = dr.Cells(3).Value.ToString()
            txtFreq.Text = dr.Cells(4).Value.ToString()
            txtPosition.Text = dr.Cells(5).Value.ToString()
            txtRemarks.Text = dr.Cells(6).Value.ToString()

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
            reload("SELECT * FROM contact_directory order by agencybrgy ASC", DataGridView1)
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

                    txtContactID.Text = .Rows(i).Cells(0).Value.ToString()
                    txtType.Text = .Rows(i).Cells(1).Value.ToString()
                    txtAgencybrgy.Text = .Rows(i).Cells(2).Value.ToString()
                    txtPerson.Text = .Rows(i).Cells(3).Value.ToString()
                    txtFreq.Text = .Rows(i).Cells(4).Value.ToString()
                    txtPosition.Text = .Rows(i).Cells(5).Value.ToString()
                    txtRemarks.Text = .Rows(i).Cells(6).Value.ToString()

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

        txtContactID.Clear()
        txtType.Text = ""
        txtAgencybrgy.Clear()
        txtPerson.Clear()
        txtFreq.Clear()
        txtPosition.Clear()
        txtRemarks.Clear()

    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' this is for saving record

        Try
            create("INSERT INTO contact_directory (contactid, type, agencybrgy, person, freq, position, remarks) VALUES ('" & txtContactID.Text & "', '" & txtType.Text & "', '" & txtAgencybrgy.Text & "', '" & txtPerson.Text & "', '" & txtFreq.Text & "', '" & txtPosition.Text & "', '" & txtRemarks.Text & "')")
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
            updates("UPDATE contact_directory SET type = '" & txtType.Text & "', agencybrgy = '" & txtAgencybrgy.Text & "', person='" & txtPerson.Text & "', freq='" & txtFreq.Text & "', position='" & txtPosition.Text & "', remarks='" & txtRemarks.Text & "' WHERE contactid='" & txtContactID.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        'this method is to delete data on records

        Try
            Bura()
            delete("DELETE FROM contact_directory where contactid='" & txtContactID.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        clearfield()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        If txtSearch.Text <> "" Then

            da = New MySqlDataAdapter("SELECT * FROM contact_directory WHERE type like '%" & txtSearch.Text & "%' OR agencybrgy like '%" & txtSearch.Text & "%' OR position like '%" & txtSearch.Text & "%' ", conn)
            dset = New DataSet
            da.Fill(dset, "contact_directory")
            DataGridView1.DataSource = dset.Tables("contact_directory").DefaultView

        Else
            MsgBox("Please enter Keyword to Search Box", MsgBoxStyle.Information, "MESSAGE")
        End If
    End Sub

    Private Sub FormDirectory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clickGridView()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub
End Class