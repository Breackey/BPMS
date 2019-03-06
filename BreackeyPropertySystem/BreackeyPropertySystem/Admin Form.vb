Public Class frmadminform

    Private Sub TenantProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TenantProfileToolStripMenuItem.Click
        With frmTenantProfile
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub ApartmentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartmentDetailsToolStripMenuItem.Click
        With frmApartmentForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With


    End Sub

    Private Sub RentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OccupancyToolStripMenuItem.Click
        With Occupancy
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With

    End Sub

    Private Sub PricelistsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PricelistsToolStripMenuItem.Click
        With frmPricelist
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With

    End Sub

    Private Sub RoomsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomsToolStripMenuItem.Click
        With frmRooms
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Private Sub PayRentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PayRentToolStripMenuItem.Click
        With frmpayrent
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub
End Class