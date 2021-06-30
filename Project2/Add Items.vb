Imports MySql.Data.MySqlClient
Public Class formAddItems
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim conn As String
        conn = "server=localhost;userid=root;password=;database=friend bakery"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strItemName As String = txtboxItems.Text
        Dim intQuantity As Integer = NudQuantity.Value
        Dim strPrice As String = txtboxPrice.Text

        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "INSERT INTO add_items VALUES (NULL, '" & strItemName & "' , '" & intQuantity & "' , '" & strPrice & "' )"
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()

        txtboxItems.Text = ""
        NudQuantity.Value = 1000
        txtboxPrice.Text = ""

        Dim row As DataRow
        For Each row In table.Rows
            DgvAddItems.Rows.Add(row("ItemName"), row("Quantity"), row("Price"))
        Next
    End Sub

    Private Sub BtnListAll_Click(sender As Object, e As EventArgs) Handles BtnListAll.Click
        Dim conn As String
        conn = "server=localhost;userid=root;password=;database=friend bakery"

        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Dim strItemName As String = txtboxItems.Text
        Dim intQuantity As Integer = NudQuantity.Value
        Dim strPrice As String = txtboxPrice.Text

        MySQL_Connection.ConnectionString = conn
        MySQL_Command.CommandText = "SELECT * FROM add_items"
        MySQL_Command.Connection = MySQL_Connection
        MySQL_Connection.Open()
        Reader = MySQL_Command.ExecuteReader
        table.Load(Reader)
        Reader.Close()
        MySQL_Connection.Close()
        MySQL_Connection.Dispose()

        Dim row As DataRow
        For Each row In table.Rows
            DgvAddItems.Rows.Add(row("ItemsName"), row("Quantity"), row("Price"))
        Next
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        formShopkeeper.Show()
        Me.Close()
    End Sub
End Class