Imports System.Data.OleDb

Module globals
    Public ConStr As String
    Public con As OleDbConnection
    Public myAdapter As New OleDbDataAdapter
    Public strsql As String, opno As Integer

    Public Function Conekta() As OleDbConnection
        ConStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
        Application.StartupPath & "\BreackeyApartmentSystemDatabase.accdb"
        con = New OleDbConnection(ConStr)
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            Return con
        Catch ex As Exception
            MsgBox("Cannot connect to database " & vbNewLine & "Please check your connection and try again ", MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Sub closeconnection()
        Try
            If (Not con Is Nothing) Then
                con.Close()
                con.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub
    Public Sub loadcombobox_data(ByVal sql As String, ByVal cbo As ComboBox, _
                                 ByVal valmem As String, displaymem As String)
        Try
            Dim ds As New DataSet
            cbo.Items.Clear()

            Dim da = New OleDbDataAdapter(sql, Conekta)
            da.SelectCommand.CommandType = CommandType.Text
            da.Fill(ds, "data")
            With cbo
                .Items.Add(ds.Tables("data").DefaultView)
                .DataSource = ds.Tables("data")
                .DisplayMember = displaymem
                .ValueMember = valmem
                .SelectedIndex = -1
            End With
        Catch ex As Exception
        Finally
        End Try
    End Sub
End Module
