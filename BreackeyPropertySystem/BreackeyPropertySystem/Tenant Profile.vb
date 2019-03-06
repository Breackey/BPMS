
Imports System.Data.OleDb
Public Class frmTenantProfile



    Private Sub Tenant_Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        retrieveTenants()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        Dim fullname As String = "", nationalid As String = "", phone As String = "", nextofkin As String = "", relationship As String, nokcontact As String = ""
        Dim tenantno As Integer
        'do input validation
        If txtfullname.Text.Trim = String.Empty Then
            MessageBox.Show("Tenant name cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            fullname = txtfullname.Text
        End If

        If txtidno.Text.Trim = String.Empty Then
            MessageBox.Show("Id Number cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nationalid = txtidno.Text.Trim
        End If

        If txtmobileno.Text.Trim = String.Empty Then
            MessageBox.Show("Mobile Number cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            phone = txtmobileno.Text.Trim
        End If
        If txtnextofkin.Text.Trim = String.Empty Then
            MessageBox.Show("Next of Kin cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nextofkin = txtnextofkin.Text
        End If

        If cborelationship.SelectedIndex = -1 Then
            MessageBox.Show("Relationship Type cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            relationship = cborelationship.Text
        End If

        If txtnokcontact.Text.Trim = String.Empty Then
            MessageBox.Show("Next of Kin contact cannot be blank", "Tenant Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            nokcontact = txtnokcontact.Text
        End If

        Try
            If cmdSave.Text = "Save" Then
                strsql = "insert into tenant (fullname, nationalid, phone, nextofkin, relationship, nextofkincontact)VALUES('" & fullname & "','" & nationalid & "','" & phone & "','" & nextofkin & "','" & relationship & "','" & nokcontact & "')"

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
                MessageBox.Show("Record saved Successfully", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If txtSearch.Text = String.Empty Then
                    Exit Sub
                Else
                    tenantno = Integer.Parse(txtSearch.Text.Trim)
                End If
                strsql = "update tenant set fullname ='" & fullname & "',nationalid='" & nationalid & "',phone='" & phone & "',nextofkin='" & nextofkin & "',relationship= '" & relationship & "',nextofkincontact='" & nokcontact & "' WHERE tenantno=" & tenantno & " "
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
            retrieveTenants()
            cleancontrols()
        Catch ex As Exception
            MsgBox("Error occured and data was not saved")
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        cleancontrols()
    End Sub
    Private Sub cleancontrols()
        txtfullname.Clear()
        txtidno.Clear()
        txtmobileno.Clear()
        txtnextofkin.Clear()
        txtSearch.Clear()
        cborelationship.SelectedIndex = -1
        txtnokcontact.Clear()
        cmdSave.Text = "Save"
        txtSearch.ReadOnly = False
        retrieveTenants()
    End Sub
    Private Sub retrieveTenants()
        strsql = "SELECT tenant.fullname, tenant.nationalid, tenant.phone, tenant.nextofkin, tenant.relationship, tenant.nextofkincontact ,tenant.tenantno FROM tenant"
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvTenants.DataSource = table
        closeconnection()
        With dgvTenants
            .Columns(0).HeaderText = "Tenant Name"
            .Columns(1).HeaderText = "National ID"
            .Columns(2).HeaderText = "Phone Number"
            .Columns(3).HeaderText = "Next of Kin"
            .Columns(4).HeaderText = "Relationship"
            .Columns(5).HeaderText = "NoK Contact"
            .Columns(6).HeaderText = "#"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub
    Private Sub retrieveTenants(ByVal tenantno As Integer)
        strsql = "SELECT tenant.fullname, tenant.nationalid, tenant.phone, tenant.nextofkin, tenant.relationship, tenant.nextofkincontact ,tenant.tenantno FROM tenant where tenantno= " & tenantno & ""
        Dim cmd As New OleDbCommand(strsql, Conekta())
        Dim adapter As New OleDbDataAdapter(cmd)
        cmd.CommandType = CommandType.Text
        Dim table As New DataTable
        'Get the data.
        adapter.Fill(table)
        'Display the data.
        dgvTenants.DataSource = table
        closeconnection()
        With dgvTenants
            .Columns(0).HeaderText = "Tenant Name"
            .Columns(1).HeaderText = "National ID"
            .Columns(2).HeaderText = "Phone Number"
            .Columns(3).HeaderText = "Next of Kin"
            .Columns(4).HeaderText = "Relationship"
            .Columns(5).HeaderText = "Nok Contact"
            .Columns(6).HeaderText = "#"
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        End With
    End Sub

    Private Sub dgvTenants_DoubleClick(sender As Object, e As EventArgs) Handles dgvTenants.DoubleClick
        txtfullname.Text = dgvTenants.CurrentRow.Cells(0).Value.ToString
        txtidno.Text = dgvTenants.CurrentRow.Cells(1).Value.ToString
        txtmobileno.Text = dgvTenants.CurrentRow.Cells(2).Value.ToString
        txtnextofkin.Text = dgvTenants.CurrentRow.Cells(3).Value.ToString
        cborelationship.Text = dgvTenants.CurrentRow.Cells(4).Value.ToString
        txtnokcontact.Text = dgvTenants.CurrentRow.Cells(5).Value.ToString
        txtSearch.Text = dgvTenants.CurrentRow.Cells(6).Value.ToString
        cmdSave.Text = "Update"
        txtSearch.ReadOnly = True
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim tenantno As Integer, fullname As String
        tenantno = Integer.Parse(dgvTenants.CurrentRow.Cells(6).Value.ToString)
        fullname = dgvTenants.CurrentRow.Cells(0).Value.ToString
        strsql = "delete from tenant where tenantno=" & tenantno & ""
        Try
            If MsgBox("Are you sure you want to delete " & fullname & " from tenants list?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                myAdapter.DeleteCommand = New OleDbCommand
                '=====
                With myAdapter.DeleteCommand
                    .CommandTimeout = 60
                    .Connection = Conekta()
                    .CommandType = CommandType.Text
                    .CommandText = strsql
                    .ExecuteScalar()
                End With
                MessageBox.Show("Record deleted Successfully", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                retrieveTenants()
            End If
        Catch ex As Exception
            MsgBox("Error occured and deletion was halted")
        End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim tenantno As Integer
        If txtSearch.Text.Trim = String.Empty Then
            MessageBox.Show("Tenant Number Missing", "Tenant Registration ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            tenantno = Integer.Parse(txtSearch.Text.Trim)
        End If
        retrieveTenants(tenantno)
    End Sub
End Class