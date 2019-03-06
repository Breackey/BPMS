Imports System.Data.OleDb
Public Class frmPricelist
    Dim roomno As String, rent As String, active As Integer, entryno As Integer
    Dim dateset As Date, dateretired As Date

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        'do input validation

        If txtRent.Text.Trim = String.Empty Then
            MessageBox.Show("Rent Field cannot be blank", "Pricelist", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            rent = txtRent.Text.Trim
        End If
        If cboActive.SelectedIndex = -1 Then
            MessageBox.Show("Status Field cannot be blank", "Pricelist", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            active = cboActive.Text
        End If

        Try
            If cmdSave.Text = "Save" Then
                If cboroomno.SelectedIndex = -1 Then
                    MessageBox.Show("Room Number cannot be blank", "Pricelist", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    roomno = cboroomno.Text
                End If

                strsql = "insert into pricelist (roomno, rent, dateset, dateretired, active)VALUES('" & roomno & "','" & rent & "','" & dateset & "','" & dateretired & "'," & active & ")"

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
                MessageBox.Show("Record saved Successfully", "Pricelist ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If txtSearch.Text = String.Empty Then
                    Exit Sub
                Else
                    entryno = Integer.Parse(txtSearch.Text.Trim)
                End If
                strsql = "UPDATE rooms INNER JOIN pricelist ON rooms.roomno = pricelist.roomno SET pricelist.rent = " & rent & ", pricelist.dateset = '" & dateset & "', pricelist.dateretired = '" & dateretired & "', pricelist.active = " & active & "  WHERE (((pricelist.roomno)='" & roomno & "'))"
                myAdapter.UpdateCommand = New OleDbCommand
                '=====
                With myAdapter.UpdateCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                MessageBox.Show("Record updated Successfully", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            retrievePrices()
            cleancontrols()
        Catch ex As Exception
            MsgBox("Error occured and data was not saved")
        End Try

    End Sub

    Private Sub cleancontrols()
        cboroomno.SelectedIndex = -1
        txtRent.Clear()
        dtpDateSet.Value = Today
        dtpDateReturned.Value = Today
        txtSearch.Clear()
        cboActive.SelectedIndex = -1
        cmdSave.Text = "Save"
        txtSearch.ReadOnly = False
        retrievePrices()
    End Sub
    Private Sub retrievePrices()
        strsql = "SELECT pricelist.entryno, pricelist.roomno, pricelist.rent, pricelist.dateset, pricelist.dateretired,pricelist.active FROM pricelist"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvPricelist.DataSource = table
        closeconnection()
        With dgvPricelist
            .Columns(0).HeaderText = "Entry Number"
            .Columns(1).HeaderText = "Room Number"
            .Columns(2).HeaderText = "Rent"
            .Columns(3).HeaderText = "Date Set"
            .Columns(4).HeaderText = "Date Returned"
            .Columns(5).HeaderText = "Status"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub
    Private Sub retrievePrices(ByVal tenantno As Integer)
        strsql = "SELECT pricelist.entryno, pricelist.roomno, pricelist.rent, pricelist.dateset, pricelist.dateretired,pricelist.active FROM pricelist where entryno= " & entryno & ""
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvPricelist.DataSource = table
        closeconnection()
        With dgvPricelist
            .Columns(0).HeaderText = "Entry Number"
            .Columns(1).HeaderText = "Room Number"
            .Columns(2).HeaderText = "Rent"
            .Columns(3).HeaderText = "Date Set"
            .Columns(4).HeaderText = "Date Returned"
            .Columns(5).HeaderText = "Status"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cleancontrols()

    End Sub

    Private Sub dgvPricelist_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPricelist.CellContentClick

    End Sub

    Private Sub dgvPricelist_DoubleClick(sender As Object, e As EventArgs) Handles dgvPricelist.DoubleClick
        txtSearch.Text = dgvPricelist.CurrentRow.Cells(0).Value.ToString
        cboroomno.Text = dgvPricelist.CurrentRow.Cells(1).Value.ToString
        txtRent.Text = dgvPricelist.CurrentRow.Cells(2).Value.ToString
        dtpDateSet.Text = dgvPricelist.CurrentRow.Cells(3).Value.ToString
        dtpDateReturned.Text = dgvPricelist.CurrentRow.Cells(4).Value.ToString
        cboActive.Text = dgvPricelist.CurrentRow.Cells(5).Value.ToString
        cmdSave.Text = "Update"
        txtSearch.ReadOnly = True

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        entryno = Integer.Parse(dgvPricelist.CurrentRow.Cells(0).Value.ToString)
        roomno = dgvPricelist.CurrentRow.Cells(1).Value.ToString
        strsql = "DELETE pricelist.*, pricelist.entryno FROM rooms INNER JOIN pricelist ON rooms.roomno = pricelist.roomno WHERE (((pricelist.entryno)=" & entryno & "))"
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
                MessageBox.Show("Record deleted Successfully", "Pricelist ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                retrievePrices()
            End If
        Catch ex As Exception
            MsgBox("Error occured and deletion was halted")
        End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If txtSearch.Text.Trim = String.Empty Then
            MessageBox.Show("Entry Number Missing", "Pricelist ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            entryno = Integer.Parse(txtSearch.Text.Trim)
        End If
        retrievePrices(entryno)
    End Sub

    Private Sub frmPricelist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strsql As String = "SELECT rooms.roomno FROM rooms"
        loadcombobox_data(strsql, cboroomno, "roomno", "roomno")


        retrievePrices()

    End Sub
End Class