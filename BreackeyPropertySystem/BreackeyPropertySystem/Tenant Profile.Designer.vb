<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenantProfile
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
        Dim FullNamesLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim NextofKinLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.txtfullname = New System.Windows.Forms.TextBox()
        Me.txtmobileno = New System.Windows.Forms.TextBox()
        Me.txtidno = New System.Windows.Forms.TextBox()
        Me.txtnextofkin = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvTenants = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cborelationship = New System.Windows.Forms.ComboBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.txtnokcontact = New System.Windows.Forms.TextBox()
        FullNamesLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        NextofKinLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTenants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FullNamesLabel
        '
        FullNamesLabel.AutoSize = True
        FullNamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FullNamesLabel.Location = New System.Drawing.Point(12, 46)
        FullNamesLabel.Name = "FullNamesLabel"
        FullNamesLabel.Size = New System.Drawing.Size(73, 13)
        FullNamesLabel.TabIndex = 1
        FullNamesLabel.Text = "Full Names:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(12, 81)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(68, 13)
        ContactLabel.TabIndex = 3
        ContactLabel.Text = "Mobile No:"
        '
        'NextofKinLabel
        '
        NextofKinLabel.AutoSize = True
        NextofKinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NextofKinLabel.Location = New System.Drawing.Point(12, 151)
        NextofKinLabel.Name = "NextofKinLabel"
        NextofKinLabel.Size = New System.Drawing.Size(70, 13)
        NextofKinLabel.TabIndex = 15
        NextofKinLabel.Text = "Nextof Kin:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelationshipLabel.Location = New System.Drawing.Point(12, 187)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(81, 13)
        RelationshipLabel.TabIndex = 17
        RelationshipLabel.Text = "Relationship:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(98, 13)
        Label2.TabIndex = 40
        Label2.Text = "Tenant Number:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(12, 226)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(83, 13)
        Label3.TabIndex = 39
        Label3.Text = "NoK Contact:"
        '
        'txtfullname
        '
        Me.txtfullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfullname.Location = New System.Drawing.Point(101, 39)
        Me.txtfullname.Name = "txtfullname"
        Me.txtfullname.Size = New System.Drawing.Size(200, 20)
        Me.txtfullname.TabIndex = 2
        '
        'txtmobileno
        '
        Me.txtmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmobileno.Location = New System.Drawing.Point(101, 74)
        Me.txtmobileno.Name = "txtmobileno"
        Me.txtmobileno.Size = New System.Drawing.Size(200, 20)
        Me.txtmobileno.TabIndex = 4
        '
        'txtidno
        '
        Me.txtidno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidno.Location = New System.Drawing.Point(101, 109)
        Me.txtidno.Name = "txtidno"
        Me.txtidno.Size = New System.Drawing.Size(200, 20)
        Me.txtidno.TabIndex = 16
        '
        'txtnextofkin
        '
        Me.txtnextofkin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnextofkin.Location = New System.Drawing.Point(101, 144)
        Me.txtnextofkin.Name = "txtnextofkin"
        Me.txtnextofkin.Size = New System.Drawing.Size(200, 20)
        Me.txtnextofkin.TabIndex = 18
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(38, 289)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 27)
        Me.cmdSave.TabIndex = 28
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(729, 389)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 28)
        Me.cmdDelete.TabIndex = 29
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.dgvTenants)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(326, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 361)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tenant Records"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(341, 26)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 38
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(110, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(225, 21)
        Me.txtSearch.TabIndex = 39
        '
        'dgvTenants
        '
        Me.dgvTenants.AllowUserToAddRows = False
        Me.dgvTenants.AllowUserToDeleteRows = False
        Me.dgvTenants.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvTenants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTenants.Location = New System.Drawing.Point(6, 56)
        Me.dgvTenants.Name = "dgvTenants"
        Me.dgvTenants.ReadOnly = True
        Me.dgvTenants.Size = New System.Drawing.Size(553, 299)
        Me.dgvTenants.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "ID NO:"
        '
        'cborelationship
        '
        Me.cborelationship.FormattingEnabled = True
        Me.cborelationship.Items.AddRange(New Object() {"Spouse", "Brother", "Sister", "Father", "Mother"})
        Me.cborelationship.Location = New System.Drawing.Point(101, 179)
        Me.cborelationship.Name = "cborelationship"
        Me.cborelationship.Size = New System.Drawing.Size(200, 21)
        Me.cborelationship.TabIndex = 37
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(191, 290)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 27)
        Me.btncancel.TabIndex = 38
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'txtnokcontact
        '
        Me.txtnokcontact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnokcontact.Location = New System.Drawing.Point(101, 223)
        Me.txtnokcontact.Name = "txtnokcontact"
        Me.txtnokcontact.Size = New System.Drawing.Size(200, 20)
        Me.txtnokcontact.TabIndex = 40
        '
        'frmTenantProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(901, 424)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.txtnokcontact)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.cborelationship)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(FullNamesLabel)
        Me.Controls.Add(Me.txtfullname)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.txtmobileno)
        Me.Controls.Add(NextofKinLabel)
        Me.Controls.Add(Me.txtidno)
        Me.Controls.Add(RelationshipLabel)
        Me.Controls.Add(Me.txtnextofkin)
        Me.Name = "frmTenantProfile"
        Me.Text = "Tenant Profile"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTenants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents txtfullname As System.Windows.Forms.TextBox
    Friend WithEvents txtmobileno As System.Windows.Forms.TextBox
    Friend WithEvents txtidno As System.Windows.Forms.TextBox
    Friend WithEvents txtnextofkin As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvTenants As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cborelationship As System.Windows.Forms.ComboBox
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents txtnokcontact As System.Windows.Forms.TextBox
End Class
