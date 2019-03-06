Imports System.Data.OleDb
Public Class Occupancy
    Dim counter As Integer = 0
    Dim loading As Boolean
    Dim idno, hseno, active, tenantno As Integer, room, description, fullname, contact As String
    Dim movein, moveout As Date
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim idno As String
        If txtIdNumber.Text.Trim = String.Empty Then
            MessageBox.Show("Tenant ID Number Missing", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            idno = txtIdNumber.Text.Trim
        End If
        retrieveTenants(idno)
    End Sub
    Sub cleancontrols()
        txtIdNumber.Clear()
        lblfullname.Text = ""
        lblmobilenumber.Text = ""
        lblroomdescription.Text = ""
        lbltenantnumber.Text = ""
        cbohouse.SelectedIndex = -1
        cboroom.Items.Clear()
        lblroomdescription.Text = ""
        dtpmovein.Value = Today
        dtpmoveout.Value = Today
        cboActive.SelectedIndex = -1
        btnNewTenant.Enabled = False
        txtIdNumber.ReadOnly = False
        cmdSave.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cleancontrols()
    End Sub

    Private Sub frmOccupancy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loading = True
        retrieveOccupants()
        loadHouse()
        loading = False
    End Sub
    Private Sub retrieveTenants(ByVal idno As String)

        strsql = "SELECT tenant.tenantno,tenant.fullname, tenant.phone FROM tenant where tenant.nationalid= '" & idno & "'"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        cmd.CommandType = CommandType.Text
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                lbltenantnumber.Text = dr(0).ToString
                lblfullname.Text = dr(1).ToString
                lblmobilenumber.Text = dr(2).ToString
                txtIdNumber.ReadOnly = True
                cmdSave.Enabled = True
                btnNewTenant.Enabled = False
            End While
        Else

            btnNewTenant.Enabled = True

        End If
        closeconnection()

    End Sub

    Private Sub btnNewTenant_Click(sender As Object, e As EventArgs) Handles btnNewTenant.Click
        With frmTenantProfile
            .WindowState = FormWindowState.Normal
            .txtidno.Text = Me.txtIdNumber.Text
            .Show()
        End With
    End Sub
    Private Sub loadHouse()
        Dim strsql As String = "select houseno,housename from house"
        loadcombobox_data(strsql, cbohouse, "houseno", "housename")
    End Sub

    Private Sub cbohouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbohouse.SelectedIndexChanged
        'If loading = False Then

        '    Dim hseno As Integer = Integer.Parse(cbohouse.SelectedValue.ToString)
        '    Dim strsql As String = "select roomno,description from rooms where houseno = " & hseno & ""
        '    loadcombobox_data(strsql, cboroom, "description", "roomno")


        'End If
        cboroom.DataSource = Nothing
        cboroom.Items.Clear()
    End Sub

    Private Sub cbohouse_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbohouse.SelectedValueChanged



    End Sub

    Private Sub btnsearcroom_Click(sender As Object, e As EventArgs) Handles btnsearcroom.Click
        hseno = Integer.Parse(cbohouse.SelectedValue.ToString)
        Dim strsql As String = "select roomno,description from rooms where houseno = " & hseno & ""
        loadcombobox_data(strsql, cboroom, "roomno", "roomno")


    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        'do input validation

        If txtIdNumber.Text.Trim = String.Empty Then
            MessageBox.Show("Search field cannot be blank", "Occupancy", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            idno = txtIdNumber.Text
        End If
        If cbohouse.SelectedIndex = -1 Then
            MessageBox.Show("House Field cannot be blank", "Occupancy", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            hseno = Integer.Parse(cbohouse.SelectedValue.ToString)
        End If
        If cboroom.SelectedIndex = -1 Then
            MessageBox.Show("Room Field cannot be blank", "Occupancy", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            room = cboroom.Text
        End If

        If cmdSave.Text = "Save" Then

            strsql = "INSERT INTO Occupancy ( tenantno, fullname, phone, houseno, roomno, description, movein, moveout, active )SELECT Occupancy.tenantno, Occupancy.fullname, Occupancy.phone, Occupancy.houseno, Occupancy.roomno, Occupancy.description, Occupancy.movein, Occupancy.moveout, Occupancy.active FROM Occupancy WHERE (((Occupancy.tenantno)=11) AND ((Occupancy.fullname)='" & fullname & "') AND ((Occupancy.phone)='" & contact & "') AND ((Occupancy.houseno)=" & hseno & ") AND ((Occupancy.roomno)='" & room & "') AND ((Occupancy.description)='" & description & "') AND ((Occupancy.movein)='" & movein & "') AND ((Occupancy.moveout)='" & moveout & "') AND ((Occupancy.active)=" & active & "))"
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
            MessageBox.Show("Record saved Successfully", "Occupancy ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            retrieveOccupants()


        Else
            If cmdSave.Text = "Update" Then

                strsql = "UPDATE Occupancy SET Occupancy.houseno = " & hseno & ", Occupancy.roomno = '" & room & "', Occupancy.description = '" & description & "', Occupancy.movein = '" & movein & "', Occupancy.moveout = '" & moveout & "', Occupancy.active = " & active & " WHERE (((Occupancy.tenantno)=" & tenantno & "))"
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
            retrieveOccupants()
            cleancontrols()
                'Catch ex As Exception
                'MsgBox("Error occured and data was not saved")
                ' End Try
        End If
    End Sub

    Private Sub retrieveOccupants()
        strsql = "SELECT Occupancy.houseno, Occupancy.roomno, Occupancy.tenantno,Occupancy.fullname, Occupancy.phone, Occupancy.description, Occupancy.movein, Occupancy.moveout, Occupancy.active FROM Occupancy"

        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvOccupancy.DataSource = table
        closeconnection()
        With dgvOccupancy
            .Columns(0).HeaderText = "House Number"
            .Columns(1).HeaderText = "Room Number"
            .Columns(2).HeaderText = "Tenant Number"
            .Columns(3).HeaderText = "Full Name"
            .Columns(4).HeaderText = "Contact"
            .Columns(5).HeaderText = "Room Description"
            .Columns(6).HeaderText = "Move In Date"
            .Columns(7).HeaderText = "Move Out Date"
            .Columns(8).HeaderText = "Status"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Private Sub dgvOccupancy_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOccupancy.CellContentClick

    End Sub

    Private Sub dgvOccupancy_DoubleClick(sender As Object, e As EventArgs) Handles dgvOccupancy.DoubleClick

        cbohouse.Text = dgvOccupancy.CurrentRow.Cells(0).Value.ToString
        cboroom.Text = dgvOccupancy.CurrentRow.Cells(1).Value.ToString
        lbltenantnumber.Text = dgvOccupancy.CurrentRow.Cells(2).Value.ToString
        lblfullname.Text = dgvOccupancy.CurrentRow.Cells(3).Value.ToString
        lblmobilenumber.Text = dgvOccupancy.CurrentRow.Cells(4).Value.ToString
        lblroomdescription.Text = dgvOccupancy.CurrentRow.Cells(5).Value.ToString
        dtpmovein.Text = dgvOccupancy.CurrentRow.Cells(6).Value.ToString
        dtpmoveout.Text = dgvOccupancy.CurrentRow.Cells(7).Value.ToString
        cboActive.Text = dgvOccupancy.CurrentRow.Cells(8).Value.ToString

        cmdSave.Enabled = True
        cmdSave.Text = "Update"
        txtIdNumber.Text = String.Empty

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        tenantno = Integer.Parse(dgvOccupancy.CurrentRow.Cells(2).Value.ToString)
        fullname = dgvOccupancy.CurrentRow.Cells(3).Value.ToString
        strsql = "DELETE Occupancy.*, Occupancy.occupancyId FROM Occupancy WHERE (((Occupancy.tenantno)=" & tenantno & "));"
        Try
            If MsgBox("Are you sure you want to delete " & fullname & " from the Occupancy?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                myAdapter.DeleteCommand = New OleDbCommand
                '=====
                With myAdapter.DeleteCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                MessageBox.Show("Record deleted Successfully", "Occupancy ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                retrieveOccupants()
                cleancontrols()
            End If
        Catch ex As Exception
            MsgBox("Error occured and deletion was halted")
        End Try
    End Sub
End Class