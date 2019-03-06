<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms
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
        Dim Label4 As System.Windows.Forms.Label
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbohouseno = New System.Windows.Forms.ComboBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(7, 25)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(90, 13)
        Label4.TabIndex = 45
        Label4.Text = "Room Number:"
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(209, 325)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 27)
        Me.cmdCancel.TabIndex = 41
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(55, 325)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 27)
        Me.cmdSave.TabIndex = 39
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(316, 19)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 42
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbohouseno)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.cmdCancel)
        Me.GroupBox1.Controls.Add(Me.txtRoomNo)
        Me.GroupBox1.Controls.Add(Me.cmdSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(322, 383)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pricelists Details"
        '
        'cbohouseno
        '
        Me.cbohouseno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbohouseno.FormattingEnabled = True
        Me.cbohouseno.Location = New System.Drawing.Point(103, 80)
        Me.cbohouseno.Name = "cbohouseno"
        Me.cbohouseno.Size = New System.Drawing.Size(135, 21)
        Me.cbohouseno.TabIndex = 50
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(85, 139)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(231, 168)
        Me.txtDescription.TabIndex = 49
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Location = New System.Drawing.Point(103, 40)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(213, 20)
        Me.txtRoomNo.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Room Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Apartment Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Description:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdDelete)
        Me.GroupBox2.Controls.Add(Label4)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.dgvRooms)
        Me.GroupBox2.Controls.Add(Me.cmdSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(351, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(417, 383)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Room:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(111, 22)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(199, 20)
        Me.txtSearch.TabIndex = 44
        '
        'dgvRooms
        '
        Me.dgvRooms.AllowUserToAddRows = False
        Me.dgvRooms.AllowUserToDeleteRows = False
        Me.dgvRooms.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(10, 59)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.ReadOnly = True
        Me.dgvRooms.Size = New System.Drawing.Size(401, 202)
        Me.dgvRooms.TabIndex = 43
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(166, 309)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 28)
        Me.cmdDelete.TabIndex = 49
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'frmRooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(780, 431)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRooms"
        Me.Text = "Rooms"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtRoomNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvRooms As System.Windows.Forms.DataGridView
    Friend WithEvents cbohouseno As System.Windows.Forms.ComboBox

    Friend WithEvents HouseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmdDelete As System.Windows.Forms.Button




End Class
