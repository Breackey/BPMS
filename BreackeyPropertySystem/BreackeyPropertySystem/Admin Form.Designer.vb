<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmadminform
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TenantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TenantProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OccupancyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PricelistsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PayRentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.TenantToolStripMenuItem, Me.ToolStripMenuItem2, Me.SignOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(817, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApartmentDetailsToolStripMenuItem, Me.RoomsToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(76, 20)
        Me.ToolStripMenuItem1.Text = "Apartment"
        '
        'ApartmentDetailsToolStripMenuItem
        '
        Me.ApartmentDetailsToolStripMenuItem.Name = "ApartmentDetailsToolStripMenuItem"
        Me.ApartmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ApartmentDetailsToolStripMenuItem.Text = "Apartment Details"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.RoomsToolStripMenuItem.Text = "Rooms "
        '
        'TenantToolStripMenuItem
        '
        Me.TenantToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TenantProfileToolStripMenuItem})
        Me.TenantToolStripMenuItem.Name = "TenantToolStripMenuItem"
        Me.TenantToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TenantToolStripMenuItem.Text = "Tenant"
        '
        'TenantProfileToolStripMenuItem
        '
        Me.TenantProfileToolStripMenuItem.Name = "TenantProfileToolStripMenuItem"
        Me.TenantProfileToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.TenantProfileToolStripMenuItem.Text = "Tenant Profile"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OccupancyToolStripMenuItem, Me.PricelistsToolStripMenuItem, Me.PayRentToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(57, 20)
        Me.ToolStripMenuItem2.Text = "Rentals"
        '
        'OccupancyToolStripMenuItem
        '
        Me.OccupancyToolStripMenuItem.Name = "OccupancyToolStripMenuItem"
        Me.OccupancyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OccupancyToolStripMenuItem.Text = "Occcupancy"
        '
        'PricelistsToolStripMenuItem
        '
        Me.PricelistsToolStripMenuItem.Name = "PricelistsToolStripMenuItem"
        Me.PricelistsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PricelistsToolStripMenuItem.Text = "Pricelists"
        '
        'PayRentToolStripMenuItem
        '
        Me.PayRentToolStripMenuItem.Name = "PayRentToolStripMenuItem"
        Me.PayRentToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PayRentToolStripMenuItem.Text = "Pay Rent"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem1})
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(117, 22)
        Me.LogOutToolStripMenuItem1.Text = "Log Out"
        '
        'frmadminform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 422)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmadminform"
        Me.Text = "Admin Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TenantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TenantProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OccupancyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApartmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PricelistsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PayRentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
