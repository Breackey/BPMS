Imports System.Data.OleDb

Public Class frmpayrent
    Dim tenantno, rent, rentpaid, balance As Integer
    Dim roomno, receiptno As String
    Dim datepaid As Date
    Private Sub frmpayrent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieverentdetails()
    End Sub

    Private Sub retrieveTenant(ByVal roomno As String)

        strsql = "SELECT Occupancy.tenantno, pricelist.rent, Occupancy.roomno FROM Occupancy, pricelist WHERE (((Occupancy.roomno)='" & roomno & "') AND ((Occupancy.active)=1) AND ((pricelist.active)=1));"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        cmd.CommandType = CommandType.Text
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                lbltenantno.Text = dr(0).ToString
                lblrent.Text = dr(1).ToString
                lblroomno.Text = dr(2).ToString
                txtsearch.ReadOnly = True
                btnSave.Enabled = True

            End While
        End If
        closeconnection()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim = String.Empty Then
            MessageBox.Show("Entry Number Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            roomno = txtsearch.Text.Trim
        End If
        retrieveTenant(roomno)
    End Sub

    Private Sub btnbalance_Click(sender As Object, e As EventArgs) Handles btnbalance.Click
        'validation
        If txtrentpaid.Text = String.Empty Then
            MessageBox.Show("Rent Paid Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            rentpaid = txtrentpaid.Text.Trim

        End If
        txtbalance.Text = CInt(lblrent.Text) - CInt(txtrentpaid.Text)
    End Sub

    Sub cleancontrols()
        txtsearch.Clear()
        lbltenantno.Text = ""
        lblroomno.Text = ""
        lblrent.Text = ""
        txtreceiptno.Text = ""
        txtrentpaid.Text = ""
        txtbalance.Text = ""
        dtpdatepaid.Value = Today
        txtsearch.ReadOnly = False
        btnSave.Enabled = False
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cleancontrols()

    End Sub

    Private Sub retrieverentdetails()
        strsql = "SELECT [Pay Rent].ReceiptNo, [Pay Rent].Datepaid, [Pay Rent].TenantNo, [Pay Rent].RoomNo, [Pay Rent].Rent, [Pay Rent].RentPaid, [Pay Rent].Balance FROM [Pay Rent];"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data
        dgvrentinfo.DataSource = table
        closeconnection()
        With dgvrentinfo
            .Columns(0).HeaderText = "Receipt Number"
            .Columns(1).HeaderText = "Date Paid"
            .Columns(2).HeaderText = "Tenant Number"
            .Columns(3).HeaderText = "Room Number"
            .Columns(4).HeaderText = "Rent"
            .Columns(5).HeaderText = "Rent Paid"
            .Columns(6).HeaderText = "Balance"

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'validation
        If lbltenantno.Text = String.Empty Then
            MessageBox.Show("Tenant Number Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtreceiptno.Text.Trim = String.Empty Then
            MessageBox.Show("Bank Receipt Number Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            receiptno = txtreceiptno.Text.Trim
        End If

        If txtrentpaid.Text = String.Empty Then
            MessageBox.Show("Rent Paid Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            rentpaid = txtrentpaid.Text.Trim

        End If

        If txtbalance.Text = String.Empty Then
            MessageBox.Show("Rent Paid Missing", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            balance = txtbalance.Text.Trim

        End If

        ' Try
        If btnSave.Text = "Save" Then
            txtsearch.Text = String.Empty

            strsql = "insert into Pay Rent (ReceiptNo, Datepaid, TenantNo, RoomNo, Rent, RentPaid,Balance)VALUES('" & receiptno & "','" & datepaid & "'," & tenantno & ",'" & roomno & "'," & rent & "," & rentpaid & "," & balance & ")"
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
            MessageBox.Show("Record saved Successfully", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Else
            '        If txtsearch.Text = String.Empty Then
            '            Exit Sub
            '        Else
            '            roomno = Integer.Parse(txtsearch.Text.Trim)
            '        End If
            '        strsql = "UPDATE rooms INNER JOIN pricelist ON rooms.roomno = pricelist.roomno SET pricelist.rent = " & rent & ", pricelist.dateset = '" & dateset & "', pricelist.dateretired = '" & dateretired & "', pricelist.active = " & active & "  WHERE (((pricelist.roomno)='" & roomno & "'))"
            '        myAdapter.UpdateCommand = New OleDbCommand
            '        '=====
            '        With myAdapter.UpdateCommand
            '            .CommandTimeout = 60
            '            .Connection = Conekta()
            '            .CommandType = CommandType.Text
            '            .CommandText = strsql
            '            .ExecuteScalar()
            '        End With
            '        MessageBox.Show("Record updated Successfully", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        '    retrievePrices()
        '    cleancontrols()
        'Catch ex As Exception
        '    MsgBox("Error occured and data was not saved")
        'End Try
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        roomno = dgvrentinfo.CurrentRow.Cells(2).Value.ToString

        'strsql = "DELETE Pay Rent.* from Pay Rent WHERE ReceiptNo= '" & receiptno & "'"
        strsql = "DELETE [Pay Rent].* FROM [Pay Rent] WHERE ((([Pay Rent].ReceiptNo)='" & receiptno & "'))"
        'Try
        If MsgBox("Are you sure you want to delete " & roomno & " from Pay Rent?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            myAdapter.DeleteCommand = New OleDbCommand
            '=====
            With myAdapter.DeleteCommand
                .CommandTimeout = 60
                .Connection = Conekta()
                .CommandType = CommandType.Text
                .CommandText = strsql
                .ExecuteScalar()
            End With
            MessageBox.Show("Record deleted Successfully", "Pay Rent ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            retrieverentdetails()
            cleancontrols()
        End If
        'Catch ex As Exception
        '    MsgBox("Error occured and deletion was halted")
        'End Try
    End Sub

    Private Sub dgvrentinfo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvrentinfo.CellContentClick

    End Sub

    Private Sub dgvrentinfo_DoubleClick(sender As Object, e As EventArgs) Handles dgvrentinfo.DoubleClick
        txtreceiptno.Text = dgvrentinfo.CurrentRow.Cells(0).Value.ToString
        dtpdatepaid.Text = dgvrentinfo.CurrentRow.Cells(1).Value.ToString
        lbltenantno.Text = dgvrentinfo.CurrentRow.Cells(2).Value.ToString
        lblroomno.Text = dgvrentinfo.CurrentRow.Cells(3).Value.ToString
        lblrent.Text = dgvrentinfo.CurrentRow.Cells(4).Value.ToString
        txtrentpaid.Text = dgvrentinfo.CurrentRow.Cells(5).Value.ToString
        txtbalance.Text = dgvrentinfo.CurrentRow.Cells(6).Value.ToString
       
    End Sub
End Class