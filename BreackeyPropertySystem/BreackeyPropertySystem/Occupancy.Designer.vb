<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Occupancy
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
        Dim Label6 As System.Windows.Forms.Label
        Dim NextofKinLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNewTenant = New System.Windows.Forms.Button()
        Me.txtIdNumber = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.dtpmovein = New System.Windows.Forms.DateTimePicker()
        Me.dtpmoveout = New System.Windows.Forms.DateTimePicker()
        Me.btnsearcroom = New System.Windows.Forms.Button()
        Me.lblroomdescription = New System.Windows.Forms.Label()
        Me.cboroom = New System.Windows.Forms.ComboBox()
        Me.cbohouse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvOccupancy = New System.Windows.Forms.DataGridView()
        Me.lblfullname = New System.Windows.Forms.Label()
        Me.lblmobilenumber = New System.Windows.Forms.Label()
        Me.lbltenantnumber = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Label6 = New System.Windows.Forms.Label()
        NextofKinLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvOccupancy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(8, 206)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(43, 13)
        Label6.TabIndex = 74
        Label6.Text = "Active"
        '
        'NextofKinLabel
        '
        NextofKinLabel.AutoSize = True
        NextofKinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NextofKinLabel.Location = New System.Drawing.Point(8, 138)
        NextofKinLabel.Name = "NextofKinLabel"
        NextofKinLabel.Size = New System.Drawing.Size(98, 13)
        NextofKinLabel.TabIndex = 72
        NextofKinLabel.Text = "Moving In Date:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelationshipLabel.Location = New System.Drawing.Point(8, 172)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(92, 13)
        RelationshipLabel.TabIndex = 73
        RelationshipLabel.Text = "Vacating Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNewTenant)
        Me.GroupBox1.Controls.Add(Me.txtIdNumber)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search by ID Number"
        '
        'btnNewTenant
        '
        Me.btnNewTenant.Enabled = False
        Me.btnNewTenant.Location = New System.Drawing.Point(262, 19)
        Me.btnNewTenant.Name = "btnNewTenant"
        Me.btnNewTenant.Size = New System.Drawing.Size(83, 36)
        Me.btnNewTenant.TabIndex = 2
        Me.btnNewTenant.Text = "Add New Tenant"
        Me.btnNewTenant.UseVisualStyleBackColor = True
        '
        'txtIdNumber
        '
        Me.txtIdNumber.Location = New System.Drawing.Point(6, 31)
        Me.txtIdNumber.Name = "txtIdNumber"
        Me.txtIdNumber.Size = New System.Drawing.Size(169, 20)
        Me.txtIdNumber.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(181, 32)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Full Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mobile Number:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboActive)
        Me.GroupBox2.Controls.Add(Me.dtpmovein)
        Me.GroupBox2.Controls.Add(Me.dtpmoveout)
        Me.GroupBox2.Controls.Add(Label6)
        Me.GroupBox2.Controls.Add(NextofKinLabel)
        Me.GroupBox2.Controls.Add(RelationshipLabel)
        Me.GroupBox2.Controls.Add(Me.btnsearcroom)
        Me.GroupBox2.Controls.Add(Me.lblroomdescription)
        Me.GroupBox2.Controls.Add(Me.cboroom)
        Me.GroupBox2.Controls.Add(Me.cbohouse)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 258)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Occupancy Details"
        '
        'cboActive
        '
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Items.AddRange(New Object() {"1", "0"})
        Me.cboActive.Location = New System.Drawing.Point(111, 203)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(200, 21)
        Me.cboActive.TabIndex = 77
        '
        'dtpmovein
        '
        Me.dtpmovein.Location = New System.Drawing.Point(112, 132)
        Me.dtpmovein.Name = "dtpmovein"
        Me.dtpmovein.Size = New System.Drawing.Size(200, 20)
        Me.dtpmovein.TabIndex = 76
        '
        'dtpmoveout
        '
        Me.dtpmoveout.Location = New System.Drawing.Point(111, 166)
        Me.dtpmoveout.Name = "dtpmoveout"
        Me.dtpmoveout.Size = New System.Drawing.Size(200, 20)
        Me.dtpmoveout.TabIndex = 75
        '
        'btnsearcroom
        '
        Me.btnsearcroom.Location = New System.Drawing.Point(234, 20)
        Me.btnsearcroom.Name = "btnsearcroom"
        Me.btnsearcroom.Size = New System.Drawing.Size(75, 35)
        Me.btnsearcroom.TabIndex = 6
        Me.btnsearcroom.Text = "Get Rooms"
        Me.btnsearcroom.UseVisualStyleBackColor = True
        '
        'lblroomdescription
        '
        Me.lblroomdescription.AutoSize = True
        Me.lblroomdescription.BackColor = System.Drawing.Color.Black
        Me.lblroomdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblroomdescription.ForeColor = System.Drawing.Color.Lime
        Me.lblroomdescription.Location = New System.Drawing.Point(111, 98)
        Me.lblroomdescription.Name = "lblroomdescription"
        Me.lblroomdescription.Size = New System.Drawing.Size(11, 13)
        Me.lblroomdescription.TabIndex = 5
        Me.lblroomdescription.Text = "."
        '
        'cboroom
        '
        Me.cboroom.FormattingEnabled = True
        Me.cboroom.Location = New System.Drawing.Point(107, 57)
        Me.cboroom.Name = "cboroom"
        Me.cboroom.Size = New System.Drawing.Size(121, 21)
        Me.cboroom.TabIndex = 4
        '
        'cbohouse
        '
        Me.cbohouse.FormattingEnabled = True
        Me.cbohouse.Location = New System.Drawing.Point(107, 22)
        Me.cbohouse.Name = "cbohouse"
        Me.cbohouse.Size = New System.Drawing.Size(121, 21)
        Me.cbohouse.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Room Description:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "House:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvOccupancy)
        Me.GroupBox3.Location = New System.Drawing.Point(377, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(621, 282)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Room Occupancy"
        '
        'dgvOccupancy
        '
        Me.dgvOccupancy.AllowUserToAddRows = False
        Me.dgvOccupancy.AllowUserToDeleteRows = False
        Me.dgvOccupancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOccupancy.Location = New System.Drawing.Point(15, 19)
        Me.dgvOccupancy.Name = "dgvOccupancy"
        Me.dgvOccupancy.ReadOnly = True
        Me.dgvOccupancy.Size = New System.Drawing.Size(571, 248)
        Me.dgvOccupancy.TabIndex = 0
        '
        'lblfullname
        '
        Me.lblfullname.AutoSize = True
        Me.lblfullname.BackColor = System.Drawing.Color.Black
        Me.lblfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfullname.ForeColor = System.Drawing.Color.Lime
        Me.lblfullname.Location = New System.Drawing.Point(127, 129)
        Me.lblfullname.Name = "lblfullname"
        Me.lblfullname.Size = New System.Drawing.Size(11, 13)
        Me.lblfullname.TabIndex = 6
        Me.lblfullname.Text = "."
        '
        'lblmobilenumber
        '
        Me.lblmobilenumber.AutoSize = True
        Me.lblmobilenumber.BackColor = System.Drawing.Color.Black
        Me.lblmobilenumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmobilenumber.ForeColor = System.Drawing.Color.Lime
        Me.lblmobilenumber.Location = New System.Drawing.Point(127, 161)
        Me.lblmobilenumber.Name = "lblmobilenumber"
        Me.lblmobilenumber.Size = New System.Drawing.Size(11, 13)
        Me.lblmobilenumber.TabIndex = 7
        Me.lblmobilenumber.Text = "."
        '
        'lbltenantnumber
        '
        Me.lbltenantnumber.AutoSize = True
        Me.lbltenantnumber.BackColor = System.Drawing.Color.Black
        Me.lbltenantnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltenantnumber.ForeColor = System.Drawing.Color.Lime
        Me.lbltenantnumber.Location = New System.Drawing.Point(127, 93)
        Me.lbltenantnumber.Name = "lbltenantnumber"
        Me.lbltenantnumber.Size = New System.Drawing.Size(11, 13)
        Me.lbltenantnumber.TabIndex = 9
        Me.lbltenantnumber.Text = "."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Tenant No:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(169, 465)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 10
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(524, 354)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 28)
        Me.cmdDelete.TabIndex = 65
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(63, 465)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 66
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'Occupancy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(1010, 500)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.lbltenantnumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblmobilenumber)
        Me.Controls.Add(Me.lblfullname)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Occupancy"
        Me.Text = "Rentals"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvOccupancy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtIdNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblroomdescription As System.Windows.Forms.Label
    Friend WithEvents cboroom As System.Windows.Forms.ComboBox
    Friend WithEvents cbohouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfullname As System.Windows.Forms.Label
    Friend WithEvents lblmobilenumber As System.Windows.Forms.Label
    Friend WithEvents lbltenantnumber As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents btnNewTenant As System.Windows.Forms.Button
    Friend WithEvents dgvOccupancy As System.Windows.Forms.DataGridView
    Friend WithEvents btnsearcroom As System.Windows.Forms.Button
    Friend WithEvents cboActive As System.Windows.Forms.ComboBox
    Friend WithEvents dtpmovein As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpmoveout As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
End Class
