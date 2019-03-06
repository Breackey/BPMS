<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPricelist
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
        Dim Label2 As System.Windows.Forms.Label
        Dim FullNamesLabel As System.Windows.Forms.Label
        Dim ContactLabel As System.Windows.Forms.Label
        Dim NextofKinLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.btncancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvPricelist = New System.Windows.Forms.DataGridView()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtRent = New System.Windows.Forms.TextBox()
        Me.dtpDateReturned = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateSet = New System.Windows.Forms.DateTimePicker()
        Me.cboActive = New System.Windows.Forms.ComboBox()
        Me.cboroomno = New System.Windows.Forms.ComboBox()
        Label2 = New System.Windows.Forms.Label()
        FullNamesLabel = New System.Windows.Forms.Label()
        ContactLabel = New System.Windows.Forms.Label()
        NextofKinLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPricelist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(6, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(83, 13)
        Label2.TabIndex = 40
        Label2.Text = "Entry Number"
        '
        'FullNamesLabel
        '
        FullNamesLabel.AutoSize = True
        FullNamesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FullNamesLabel.Location = New System.Drawing.Point(12, 71)
        FullNamesLabel.Name = "FullNamesLabel"
        FullNamesLabel.Size = New System.Drawing.Size(90, 13)
        FullNamesLabel.TabIndex = 39
        FullNamesLabel.Text = "Room Number:"
        '
        'ContactLabel
        '
        ContactLabel.AutoSize = True
        ContactLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactLabel.Location = New System.Drawing.Point(12, 105)
        ContactLabel.Name = "ContactLabel"
        ContactLabel.Size = New System.Drawing.Size(38, 13)
        ContactLabel.TabIndex = 41
        ContactLabel.Text = "Rent:"
        '
        'NextofKinLabel
        '
        NextofKinLabel.AutoSize = True
        NextofKinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NextofKinLabel.Location = New System.Drawing.Point(12, 139)
        NextofKinLabel.Name = "NextofKinLabel"
        NextofKinLabel.Size = New System.Drawing.Size(61, 13)
        NextofKinLabel.TabIndex = 43
        NextofKinLabel.Text = "Date Set:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelationshipLabel.Location = New System.Drawing.Point(12, 173)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(83, 13)
        RelationshipLabel.TabIndex = 45
        RelationshipLabel.Text = "Date Retired:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(12, 207)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 53
        Label3.Text = "Active"
        '
        'btncancel
        '
        Me.btncancel.Location = New System.Drawing.Point(191, 256)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 27)
        Me.btncancel.TabIndex = 52
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.dgvPricelist)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(311, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 361)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricelists"
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
        'dgvPricelist
        '
        Me.dgvPricelist.AllowUserToAddRows = False
        Me.dgvPricelist.AllowUserToDeleteRows = False
        Me.dgvPricelist.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvPricelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPricelist.Location = New System.Drawing.Point(9, 62)
        Me.dgvPricelist.Name = "dgvPricelist"
        Me.dgvPricelist.ReadOnly = True
        Me.dgvPricelist.Size = New System.Drawing.Size(597, 293)
        Me.dgvPricelist.TabIndex = 31
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(681, 423)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 28)
        Me.cmdDelete.TabIndex = 48
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(36, 256)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 27)
        Me.cmdSave.TabIndex = 47
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtRent
        '
        Me.txtRent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRent.Location = New System.Drawing.Point(105, 102)
        Me.txtRent.Name = "txtRent"
        Me.txtRent.Size = New System.Drawing.Size(200, 20)
        Me.txtRent.TabIndex = 42
        '
        'dtpDateReturned
        '
        Me.dtpDateReturned.Location = New System.Drawing.Point(105, 167)
        Me.dtpDateReturned.Name = "dtpDateReturned"
        Me.dtpDateReturned.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateReturned.TabIndex = 54
        '
        'dtpDateSet
        '
        Me.dtpDateSet.Location = New System.Drawing.Point(105, 133)
        Me.dtpDateSet.Name = "dtpDateSet"
        Me.dtpDateSet.Size = New System.Drawing.Size(200, 20)
        Me.dtpDateSet.TabIndex = 55
        '
        'cboActive
        '
        Me.cboActive.FormattingEnabled = True
        Me.cboActive.Items.AddRange(New Object() {"1", "0"})
        Me.cboActive.Location = New System.Drawing.Point(105, 204)
        Me.cboActive.Name = "cboActive"
        Me.cboActive.Size = New System.Drawing.Size(200, 21)
        Me.cboActive.TabIndex = 56
        '
        'cboroomno
        '
        Me.cboroomno.FormattingEnabled = True
        Me.cboroomno.Location = New System.Drawing.Point(108, 68)
        Me.cboroomno.Name = "cboroomno"
        Me.cboroomno.Size = New System.Drawing.Size(121, 21)
        Me.cboroomno.TabIndex = 57
        '
        'frmPricelist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(956, 509)
        Me.Controls.Add(Me.cboroomno)
        Me.Controls.Add(Me.cboActive)
        Me.Controls.Add(Me.dtpDateSet)
        Me.Controls.Add(Me.dtpDateReturned)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(FullNamesLabel)
        Me.Controls.Add(ContactLabel)
        Me.Controls.Add(Me.txtRent)
        Me.Controls.Add(NextofKinLabel)
        Me.Controls.Add(RelationshipLabel)
        Me.Name = "frmPricelist"
        Me.Text = "Pricelist"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvPricelist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvPricelist As System.Windows.Forms.DataGridView
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtRent As System.Windows.Forms.TextBox
    Friend WithEvents dtpDateReturned As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDateSet As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboActive As System.Windows.Forms.ComboBox
    Friend WithEvents cboroomno As System.Windows.Forms.ComboBox
End Class
