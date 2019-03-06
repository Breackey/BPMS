<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpayrent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lbltenantno = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblroomno = New System.Windows.Forms.Label()
        Me.dgvrentinfo = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblrent = New System.Windows.Forms.Label()
        Me.dtpdatepaid = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnbalance = New System.Windows.Forms.Button()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.txtrentpaid = New System.Windows.Forms.TextBox()
        Me.txtreceiptno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnreceipt = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.dgvrentinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(55, 435)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lbltenantno
        '
        Me.lbltenantno.AutoSize = True
        Me.lbltenantno.BackColor = System.Drawing.Color.Black
        Me.lbltenantno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenantno.ForeColor = System.Drawing.Color.Lime
        Me.lbltenantno.Location = New System.Drawing.Point(119, 88)
        Me.lbltenantno.Name = "lbltenantno"
        Me.lbltenantno.Size = New System.Drawing.Size(11, 13)
        Me.lbltenantno.TabIndex = 20
        Me.lbltenantno.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Tenant No:"
        '
        'lblroomno
        '
        Me.lblroomno.AutoSize = True
        Me.lblroomno.BackColor = System.Drawing.Color.Black
        Me.lblroomno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroomno.ForeColor = System.Drawing.Color.Lime
        Me.lblroomno.Location = New System.Drawing.Point(119, 124)
        Me.lblroomno.Name = "lblroomno"
        Me.lblroomno.Size = New System.Drawing.Size(11, 13)
        Me.lblroomno.TabIndex = 17
        Me.lblroomno.Text = "."
        '
        'dgvrentinfo
        '
        Me.dgvrentinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvrentinfo.Location = New System.Drawing.Point(15, 19)
        Me.dgvrentinfo.Name = "dgvrentinfo"
        Me.dgvrentinfo.Size = New System.Drawing.Size(606, 240)
        Me.dgvrentinfo.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvrentinfo)
        Me.GroupBox3.Location = New System.Drawing.Point(369, 27)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(631, 325)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rent Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Rent:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(208, 435)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblrent)
        Me.GroupBox2.Controls.Add(Me.dtpdatepaid)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnbalance)
        Me.GroupBox2.Controls.Add(Me.txtbalance)
        Me.GroupBox2.Controls.Add(Me.txtrentpaid)
        Me.GroupBox2.Controls.Add(Me.txtreceiptno)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 266)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rent Details"
        '
        'lblrent
        '
        Me.lblrent.AutoSize = True
        Me.lblrent.BackColor = System.Drawing.Color.Black
        Me.lblrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrent.ForeColor = System.Drawing.Color.Lime
        Me.lblrent.Location = New System.Drawing.Point(103, 98)
        Me.lblrent.Name = "lblrent"
        Me.lblrent.Size = New System.Drawing.Size(11, 13)
        Me.lblrent.TabIndex = 26
        Me.lblrent.Text = "."
        '
        'dtpdatepaid
        '
        Me.dtpdatepaid.Location = New System.Drawing.Point(106, 62)
        Me.dtpdatepaid.Name = "dtpdatepaid"
        Me.dtpdatepaid.Size = New System.Drawing.Size(200, 20)
        Me.dtpdatepaid.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Balance:"
        '
        'btnbalance
        '
        Me.btnbalance.Location = New System.Drawing.Point(143, 209)
        Me.btnbalance.Name = "btnbalance"
        Me.btnbalance.Size = New System.Drawing.Size(97, 30)
        Me.btnbalance.TabIndex = 14
        Me.btnbalance.Text = "Compute"
        Me.btnbalance.UseVisualStyleBackColor = True
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(106, 169)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(200, 20)
        Me.txtbalance.TabIndex = 13
        '
        'txtrentpaid
        '
        Me.txtrentpaid.Location = New System.Drawing.Point(106, 137)
        Me.txtrentpaid.Name = "txtrentpaid"
        Me.txtrentpaid.Size = New System.Drawing.Size(200, 20)
        Me.txtrentpaid.TabIndex = 12
        '
        'txtreceiptno
        '
        Me.txtreceiptno.Location = New System.Drawing.Point(106, 28)
        Me.txtreceiptno.Name = "txtreceiptno"
        Me.txtreceiptno.Size = New System.Drawing.Size(200, 20)
        Me.txtreceiptno.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Bank Receipt No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Rent Paid:"
        '
        'txtsearch
        '
        Me.txtsearch.Location = New System.Drawing.Point(11, 29)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(191, 20)
        Me.txtsearch.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(221, 27)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtsearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 60)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Room Number"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Room Number:"
        '
        'btnreceipt
        '
        Me.btnreceipt.Location = New System.Drawing.Point(122, 477)
        Me.btnreceipt.Name = "btnreceipt"
        Me.btnreceipt.Size = New System.Drawing.Size(111, 23)
        Me.btnreceipt.TabIndex = 25
        Me.btnreceipt.Text = "Generate Receipt"
        Me.btnreceipt.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(521, 376)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 26
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmpayrent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(1002, 526)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnreceipt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbltenantno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblroomno)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmpayrent"
        Me.Text = "Rent form"
        CType(Me.dgvrentinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lbltenantno As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblroomno As System.Windows.Forms.Label
    Friend WithEvents dgvrentinfo As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpdatepaid As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbalance As System.Windows.Forms.Button
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtrentpaid As System.Windows.Forms.TextBox
    Friend WithEvents txtreceiptno As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblrent As System.Windows.Forms.Label
    Friend WithEvents btnreceipt As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
