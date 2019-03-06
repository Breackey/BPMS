Imports System.Data.OleDb
Imports System.Data.OleDb.OleDbErrorCollection


Public Class frmApartmentForm
    Dim apartment As String
    Dim locate As String
    Dim houseno As Integer

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click


        'do input validation
        If txtapartment.Text.Trim = String.Empty Then
            MessageBox.Show("Apartment name cannot be blank", "Apartment Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            apartment = txtapartment.Text
        End If
        If txtLocation.Text.Trim = String.Empty Then
            MessageBox.Show("Apartment Location cannot be blank", "Apartment Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            locate = txtLocation.Text
        End If

        ' Try
        If cmdSave.Text = "Save" Then
            strsql = "Insert into house( housename, physicallocation)VALUES('" & apartment & "','" & locate & "')"

            myAdapter.InsertCommand = New OleDbCommand

            With myAdapter.InsertCommand
                .CommandTimeout = 60
                .Connection = Conekta()
                .CommandType = CommandType.Text
                .CommandText = strsql
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record saved Successfully", "Apartment ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If txtSearch.Text = String.Empty Then
                Exit Sub
            Else
                houseno = Integer.Parse(txtSearch.Text.Trim)
            End If
            strsql = "UPDATE house INNER JOIN rooms ON house.houseno = rooms.houseno SET house.housename = '" & apartment & "', house.physicallocation = '" & locate & "' WHERE (((house.houseno)=" & houseno & ")) "
            myAdapter.UpdateCommand = New OleDbCommand
            '=====
            With myAdapter.UpdateCommand
                .CommandTimeout = 60
                .Connection = Conekta()
                .CommandType = CommandType.Text
                .CommandText = strsql
                .ExecuteScalar()

            End With
            MessageBox.Show("Record updated Successfully", "Apartment ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        retrieveHouse()
        cleancontrols()
        'Catch ex As Exception
        '    MsgBox("Error occured and data was not saved")
        'End Try
    End Sub

    Private Sub retrieveHouse(ByVal houseno As Integer)
        strsql = "SELECT house.houseno, house.housename, house.physicallocation FROM house where houseno = " & houseno & ""
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim apartmenttable As New DataTable
        'Get the data.
        adapter.Fill(apartmenttable)
        'Display the data.
        dgvApartment.DataSource = apartmenttable
        closeconnection()
        With dgvApartment
            .Columns(0).HeaderText = "houseno"
            .Columns(1).HeaderText = "housename"
            .Columns(2).HeaderText = "physicallocation"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Private Sub cleancontrols()
        txtapartment.Clear()
        txtLocation.Clear()
        txtSearch.Clear()
        cmdSave.Text = "Save"
        txtSearch.ReadOnly = False
        retrieveHouse()
    End Sub

    Private Sub retrieveHouse()
        strsql = "SELECT house.houseno, house.housename, house.physicallocation FROM house"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim apartmenttable As New DataTable
        'Get the data.
        adapter.Fill(apartmenttable)
        'Display the data.
        dgvApartment.DataSource = apartmenttable
        closeconnection()
        With dgvApartment
            .Columns(0).HeaderText = "houseno"
            .Columns(1).HeaderText = "housename"
            .Columns(2).HeaderText = "physicallocation"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub
    Private Sub frmApartmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieveHouse()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cleancontrols()

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        houseno = Integer.Parse(dgvApartment.CurrentRow.Cells(0).Value.ToString)
        apartment = dgvApartment.CurrentRow.Cells(1).Value.ToString
        'Try
        If MsgBox("Are you sure you want to delete " & apartment & " from house list?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            strsql = "DELETE house.* FROM house WHERE (((house.houseno)=" & houseno & "))"
            myAdapter.DeleteCommand = New OleDbCommand
            '=====
            With myAdapter.DeleteCommand
                .CommandTimeout = 60
                .Connection = Conekta()
                .CommandType = CommandType.Text
                .CommandText = strsql
                .ExecuteNonQuery()
            End With

            MessageBox.Show("Record deleted Successfully", "House Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            retrieveHouse()
        End If
        'Catch ex As Exception
        '    MsgBox("Error occured and deletion was halted")
        'End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtSearch.Text.Trim = String.Empty Then
            MessageBox.Show("House Number Missing", "House Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            houseno = Integer.Parse(txtSearch.Text.Trim)
        End If
        retrieveHouse(houseno)
    End Sub

    Private Sub dgvApartment_DoubleClick(sender As Object, e As EventArgs) Handles dgvApartment.DoubleClick
        txtSearch.Text = dgvApartment.CurrentRow.Cells(0).Value.ToString
        txtapartment.Text = dgvApartment.CurrentRow.Cells(1).Value.ToString
        txtLocation.Text = dgvApartment.CurrentRow.Cells(2).Value.ToString
        cmdSave.Text = "Update"
        txtSearch.ReadOnly = True
    End Sub
End Class