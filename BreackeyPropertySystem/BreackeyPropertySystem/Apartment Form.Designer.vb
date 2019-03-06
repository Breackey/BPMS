<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApartmentForm
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
        Dim ApartmentNameLabel As System.Windows.Forms.Label
        Dim HouseNumberLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.txtapartment = New System.Windows.Forms.TextBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvApartment = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        ApartmentNameLabel = New System.Windows.Forms.Label()
        HouseNumberLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvApartment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApartmentNameLabel
        '
        ApartmentNameLabel.AutoSize = True
        ApartmentNameLabel.Location = New System.Drawing.Point(15, 47)
        ApartmentNameLabel.Name = "ApartmentNameLabel"
        ApartmentNameLabel.Size = New System.Drawing.Size(118, 15)
        ApartmentNameLabel.TabIndex = 3
        ApartmentNameLabel.Text = "Apartment Name:"
        '
        'HouseNumberLabel
        '
        HouseNumberLabel.AutoSize = True
        HouseNumberLabel.Location = New System.Drawing.Point(15, 94)
        HouseNumberLabel.Name = "HouseNumberLabel"
        HouseNumberLabel.Size = New System.Drawing.Size(66, 15)
        HouseNumberLabel.TabIndex = 5
        HouseNumberLabel.Text = "Location:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(18, 36)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(112, 13)
        Label2.TabIndex = 9
        Label2.Text = "Search Apartment No:"
        '
        'txtapartment
        '
        Me.txtapartment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtapartment.Location = New System.Drawing.Point(139, 47)
        Me.txtapartment.Name = "txtapartment"
        Me.txtapartment.Size = New System.Drawing.Size(200, 21)
        Me.txtapartment.TabIndex = 4
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(139, 91)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(200, 21)
        Me.txtLocation.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(ApartmentNameLabel)
        Me.GroupBox2.Controls.Add(Me.cmdCancel)
        Me.GroupBox2.Controls.Add(Me.txtapartment)
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(HouseNumberLabel)
        Me.GroupBox2.Controls.Add(Me.txtLocation)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 218)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Apartment Details"
        '
        'dgvApartment
        '
        Me.dgvApartment.AllowUserToAddRows = False
        Me.dgvApartment.AllowUserToDeleteRows = False
        Me.dgvApartment.BackgroundColor = System.Drawing.Color.LightGreen
        Me.dgvApartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvApartment.Location = New System.Drawing.Point(21, 73)
        Me.dgvApartment.Name = "dgvApartment"
        Me.dgvApartment.ReadOnly = True
        Me.dgvApartment.Size = New System.Drawing.Size(433, 254)
        Me.dgvApartment.TabIndex = 21
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label2)
        Me.GroupBox3.Controls.Add(Me.dgvApartment)
        Me.GroupBox3.Controls.Add(Me.cmdSearch)
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Location = New System.Drawing.Point(393, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(467, 333)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search House"
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(348, 28)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(130, 30)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(212, 20)
        Me.txtSearch.TabIndex = 0
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(32, 171)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(246, 171)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 23
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(616, 400)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 24
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'frmApartmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(863, 427)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmApartmentForm"
        Me.Text = "Apartment Form"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvApartment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents txtapartment As System.Windows.Forms.TextBox
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvApartment As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
End Class
