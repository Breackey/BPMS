Imports System.Data.OleDb
Public Class frmRooms
    Dim description As String
    Dim roomno As String
    Dim apartmentno As Integer
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        'do input validation
        If txtRoomNo.Text.Trim = String.Empty Then
            MessageBox.Show("Room Number cannot be blank", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            roomno = txtRoomNo.Text()
        End If

       

        If txtDescription.Text.Trim = String.Empty Then
            MessageBox.Show("Room Description cannot be blank", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            description = txtDescription.Text.Trim
        End If


        Try
            If cmdSave.Text = "Save" Then
                If cbohouseno.SelectedIndex = -1 Then
                    MessageBox.Show("Apartment Number cannot be blank", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    apartmentno = cbohouseno.SelectedIndex
                End If
                strsql = "insert into rooms (roomno, houseno, description)VALUES('" & roomno & "','" & apartmentno & "','" & description & "')"

                myAdapter.InsertCommand = New OleDbCommand
                '=====
                With myAdapter.InsertCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                '====
                MessageBox.Show("Record saved Successfully", "Rooms ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf cmdSave.Text = "Update" Then

                If txtSearch.Text = String.Empty Then
                    Exit Sub
                Else
                    roomno = txtSearch.Text.Trim
                End If

                apartmentno = cbohouseno.SelectedIndex

                strsql = "UPDATE rooms INNER JOIN house ON house.houseno = rooms.houseno SET rooms.description = '" & description & "' WHERE (((rooms.roomno)='" & roomno & "')) "
                myAdapter.UpdateCommand = New OleDbCommand
                '=====
                With myAdapter.UpdateCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                MessageBox.Show("Record updated Successfully", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            retrieveRooms()
            cleancontrols()
        Catch ex As Exception
            MsgBox("Error occured and data was not saved")
        End Try
    End Sub

    Private Sub cleancontrols()
        txtRoomNo.Clear()
        cbohouseno.SelectedIndex = -1
        txtDescription.Clear()
        cmdSave.Text = "Save"
        txtSearch.ReadOnly = False
        retrieveRooms()
    End Sub
    Private Sub retrieveRooms()
        strsql = "SELECT rooms.roomno, rooms.houseno, rooms.description FROM rooms"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvRooms.DataSource = table
        closeconnection()
        With dgvRooms
            .Columns(0).HeaderText = "Room Number"
            .Columns(1).HeaderText = "Apartment Number"
            .Columns(2).HeaderText = "Room Description"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub
    Private Sub retrieveRooms(ByVal roomno As String)
        strsql = "SELECT rooms.roomno, rooms.houseno, rooms.description FROM rooms WHERE (((rooms.roomno)='" & roomno & "'))"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvRooms.DataSource = table
        closeconnection()
        With dgvRooms
            .Columns(0).HeaderText = "Room Number"
            .Columns(1).HeaderText = "Apartment Number"
            .Columns(2).HeaderText = "Room Description"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cleancontrols()

    End Sub


    Private Sub dgvRooms_DoubleClick(sender As Object, e As EventArgs) Handles dgvRooms.DoubleClick
        txtRoomNo.Text = dgvRooms.CurrentRow.Cells(0).Value.ToString
        cbohouseno.Text = dgvRooms.CurrentRow.Cells(1).Value.ToString
        txtDescription.Text = dgvRooms.CurrentRow.Cells(2).Value.ToString
        txtSearch.Text = dgvRooms.CurrentRow.Cells(0).Value.ToString
        cmdSave.Text = "Update"
        txtSearch.ReadOnly = True
        txtRoomNo.ReadOnly = True

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtSearch.Text.Trim = String.Empty Then
            MessageBox.Show("Room Number Missing", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            roomno = txtSearch.Text.Trim
        End If
        retrieveRooms(roomno)
    End Sub

    Private Sub frmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "select houseno,housename from house"
        loadcombobox_data(strsql, cbohouseno, "houseno", "housename")
        retrieveRooms()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        roomno = dgvRooms.CurrentRow.Cells(0).Value.ToString
        strsql = "DELETE rooms.*, rooms.roomno FROM rooms WHERE (((rooms.roomno)='" & roomno & "'))"
        Try
            If MsgBox("Are you sure you want to delete " & roomno & " from the Pricelist?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                myAdapter.DeleteCommand = New OleDbCommand
                '=====
                With myAdapter.DeleteCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                MessageBox.Show("Record deleted Successfully", "Rooms", MessageBoxButtons.OK, MessageBoxIcon.Information)
                retrieveRooms()
            End If
        Catch ex As Exception
            MsgBox("Error occured and deletion was halted")
        End Try
    End Sub
End Class