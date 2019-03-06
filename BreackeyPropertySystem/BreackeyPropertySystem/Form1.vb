Public Class frmlogin
    Dim Username As String, Password As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub cmdSignIn_Click(sender As Object, e As EventArgs) Handles cmdSignIn.Click
        If txtUserName.Text = "Admin" And txtPassword.Text = "1234" Then
            frmadminform.Show()
            Me.Hide()
        Else
            MsgBox("Invalid Log In", MsgBoxStyle.Information, "Error")

        End If



        'If txtUserName.Text = My.Settings.username And txtPassword.Text = My.Settings.passsword Then
        '    frmadminform.Show()
        '    Me.Hide()
        'Else
        '    MsgBox("Invalid Log In", MsgBoxStyle.Information, "Error")

        'End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub
End Class
