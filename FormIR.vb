Imports MySql.Data.MySqlClient
Public Class FormIR
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

            txtIrid.Text = dr.Cells(0).Value.ToString()
            txtDate.Text = dr.Cells(1).Value.ToString()
            txtTime.Text = dr.Cells(2).Value.ToString()
            txtNature.Text = dr.Cells(3).Value.ToString()
            txtPlace.Text = dr.Cells(4).Value.ToString()
            txtVictim.Text = dr.Cells(5).Value.ToString()
            txtInjured.Text = dr.Cells(6).Value.ToString()
            txtCasualty.Text = dr.Cells(7).Value.ToString()
            txtHospital.Text = dr.Cells(8).Value.ToString()
            txtCollision.Text = dr.Cells(9).Value.ToString()
            txtVehicle.Text = dr.Cells(10).Value.ToString()
            txtReporter.Text = dr.Cells(11).Value.ToString()
            txtContact.Text = dr.Cells(12).Value.ToString()
            txtPatientInfo.Text = dr.Cells(13).Value.ToString()
            txtVehicleInfo.Text = dr.Cells(14).Value.ToString()
            txtResporder.Text = dr.Cells(15).Value.ToString()
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
            reload("SELECT * FROM incident_report order by irid DESC", DataGridView1)
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
                    txtIrid.Text = .Rows(i).Cells(0).Value.ToString()
                    txtDate.Text = .Rows(i).Cells(1).Value.ToString()
                    txtTime.Text = .Rows(i).Cells(2).Value.ToString()
                    txtNature.Text = .Rows(i).Cells(3).Value.ToString()
                    txtPlace.Text = .Rows(i).Cells(4).Value.ToString()
                    txtVictim.Text = .Rows(i).Cells(5).Value.ToString()
                    txtInjured.Text = .Rows(i).Cells(6).Value.ToString()
                    txtCasualty.Text = .Rows(i).Cells(7).Value.ToString()
                    txtHospital.Text = .Rows(i).Cells(8).Value.ToString()
                    txtCollision.Text = .Rows(i).Cells(9).Value.ToString()
                    txtVehicle.Text = .Rows(i).Cells(10).Value.ToString()
                    txtReporter.Text = .Rows(i).Cells(11).Value.ToString()
                    txtContact.Text = .Rows(i).Cells(12).Value.ToString()
                    txtPatientInfo.Text = .Rows(i).Cells(13).Value.ToString()
                    txtVehicleInfo.Text = .Rows(i).Cells(14).Value.ToString()
                    txtResporder.Text = .Rows(i).Cells(15).Value.ToString()
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
        txtIrid.Clear()
        txtDate.Clear()
        txtTime.Clear()
        txtNature.Clear()
        txtPlace.Text = ""
        txtVictim.Clear()
        txtInjured.Clear()
        txtCasualty.Clear()
        txtHospital.Clear()
        txtCollision.Text = ""
        txtVehicle.Clear()
        txtReporter.Clear()
        txtContact.Clear()
        txtPatientInfo.Clear()
        txtVehicleInfo.Clear()
        txtResporder.Clear()
        txtRemarks.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' this is for saving record

        Try
            create("INSERT INTO incident_report (irid, date, time, nature, place, victimno, injuryno, casualtyno, hospital, collision, vehicle, reporter, contact, patientinfo, vehicleinfo, responder, remarks) VALUES ('" & txtIrid.Text & "', '" & txtDate.Text & "', '" & txtTime.Text & "', '" & txtNature.Text & "', '" & txtPlace.Text & "', '" & txtVictim.Text & "', '" & txtInjured.Text & "', '" & txtCasualty.Text & "', '" & txtHospital.Text & "', '" & txtCollision.Text & "', '" & txtVehicle.Text & "', '" & txtReporter.Text & "', '" & txtContact.Text & "', '" & txtPatientInfo.Text & "', '" & txtVehicleInfo.Text & "', '" & txtResporder.Text & "', '" & txtRemarks.Text & "')")
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
            updates("UPDATE incident_report SET date = '" & txtDate.Text & "', time = '" & txtTime.Text & "', nature='" & txtNature.Text & "', place='" & txtPlace.Text & "', victimno='" & txtVictim.Text & "', injuryno='" & txtInjured.Text & "', casualtyno='" & txtCasualty.Text & "', hospital='" & txtHospital.Text & "', collision='" & txtCollision.Text & "', vehicle='" & txtVehicle.Text & "', reporter='" & txtReporter.Text & "', contact='" & txtContact.Text & "', patientinfo='" & txtPatientInfo.Text & "', vehicleinfo='" & txtVehicleInfo.Text & "', responder='" & txtResporder.Text & "', remarks='" & txtRemarks.Text & "' WHERE irid='" & txtIrid.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnDelete_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        'this method is to delete data on records

        Try
            Bura()
            delete("DELETE FROM incident_report where irid='" & txtIrid.Text & "'")
            clearfield()
            VwGridview()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnNew_Click_1(sender As Object, e As EventArgs) Handles btnNew.Click
        clearfield()
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        clickGridView()
    End Sub

    Private Sub FormIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VwGridview()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        VwGridview()
    End Sub
End Class